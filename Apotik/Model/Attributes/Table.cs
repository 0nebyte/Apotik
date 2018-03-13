using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotik.Model.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class Table : Attribute
    {
        public string TableName { get; set; }
    }
}
