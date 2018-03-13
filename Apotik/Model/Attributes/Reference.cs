using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotik.Model.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class Reference : Attribute
    {
        private Type type;
        private bool multiple;

        public Type Type
        {
            get { return type; }
            set { type = value; }
        }

        public bool Multiple
        {
            get { return multiple; }
            set { multiple = value; }
        }

        public bool AllowNull { get; set; }
    }
}
