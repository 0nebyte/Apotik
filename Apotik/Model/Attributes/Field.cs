using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotik.Model.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class Field : Attribute
    {
        private string name;
        private bool primaryKey = false;
        private bool autoIncrement = false;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public bool PrimaryKey
        {
            get
            {
                return primaryKey;
            }

            set
            {
                primaryKey = value;
            }
        }

        public bool AutoIncrement
        {
            get
            {
                return autoIncrement;
            }

            set
            {
                autoIncrement = value;
            }
        }
    }
}
