using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Apotik.Model
{
    class Builder
    {
        public static TypeBuilder CreateType(string typeSignature, Type parent)
        {
            var assemblyName = new AssemblyName(typeSignature);
            var assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName,
                AssemblyBuilderAccess.Run);
            var moduleBuilder = assemblyBuilder.DefineDynamicModule("MainModule");
            return moduleBuilder.DefineType(typeSignature,
                TypeAttributes.Public |
                TypeAttributes.Class |
                TypeAttributes.AutoClass |
                TypeAttributes.AnsiClass |
                TypeAttributes.BeforeFieldInit |
                TypeAttributes.AutoLayout,
                parent);
        }

        public static void CreateProperty(TypeBuilder typeBuilder, string propertyName, Type propertyType)
        {
            var propertyBuilder = typeBuilder.DefineProperty(propertyName, PropertyAttributes.HasDefault,
                propertyType, null);

            // Property get method
            var getMethodBuilder = typeBuilder.DefineMethod("get_" + propertyName,
                MethodAttributes.Public |
                MethodAttributes.Virtual |
                MethodAttributes.SpecialName |
                MethodAttributes.HideBySig,
                propertyType, Type.EmptyTypes);
            var getILGen = getMethodBuilder.GetILGenerator();

            // Call base type get property
            var baseType = typeBuilder.BaseType;
            var baseGetMethod = baseType.GetProperty(propertyName).GetMethod;

            getILGen.Emit(OpCodes.Ldarg_0);
            getILGen.Emit(OpCodes.Call, baseGetMethod);
            getILGen.Emit(OpCodes.Ret);

            // Property set method
            var setMethodBuilder = typeBuilder.DefineMethod("set_" + propertyName,
                MethodAttributes.Public |
                MethodAttributes.Virtual |
                MethodAttributes.SpecialName |
                MethodAttributes.HideBySig,
                null, new[] { propertyType });
            var setILGen = setMethodBuilder.GetILGenerator();

            var modifyProperty = setILGen.DefineLabel();
            var exitSet = setILGen.DefineLabel();

            setILGen.MarkLabel(modifyProperty);

            // Call base type set property
            var baseSetMethod = baseType.GetProperty(propertyName).SetMethod;

            setILGen.Emit(OpCodes.Ldarg_0);
            setILGen.Emit(OpCodes.Ldarg_1);
            setILGen.Emit(OpCodes.Call, baseSetMethod);

            // Call BaseModel.InvokePropertyChanged
            var propertyChangedEventArgsConstructor = typeof(System.ComponentModel.PropertyChangedEventArgs)
                .GetConstructor(new[] { typeof(string) });
            var invokePropertyChanged = typeof(BaseModel).GetMethod("InvokePropertyChanged",
                new[] { typeof(System.ComponentModel.PropertyChangedEventArgs) });

            setILGen.Emit(OpCodes.Ldarg_0);
            setILGen.Emit(OpCodes.Ldstr, propertyName);
            setILGen.Emit(OpCodes.Newobj, propertyChangedEventArgsConstructor);
            setILGen.Emit(OpCodes.Call, invokePropertyChanged);

            setILGen.MarkLabel(exitSet);
            setILGen.Emit(OpCodes.Ret);

            propertyBuilder.SetGetMethod(getMethodBuilder);
            propertyBuilder.SetSetMethod(setMethodBuilder);
        }
    }
}
