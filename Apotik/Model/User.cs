using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotik.Model
{
    [Attributes.Table(TableName = "tb_user")]
    public class User : BaseModel
    {
        [Attributes.Field(Name = "id_user", PrimaryKey = true, AutoIncrement = true)]
        public virtual int Id { get; set; }

        [Attributes.Field(Name = "kode_user", AllowNull = false)]
        public virtual string Kode { get; set; }

        [Attributes.Field(Name = "nama", AllowNull = false)]
        public virtual string Nama { get; set; }

        [Attributes.Field(Name = "jk", AllowNull = false)]
        public virtual string JK { get; set; }

        [Attributes.Field(Name = "alamat", AllowNull = false)]
        public virtual string Alamat { get; set; }

        [Attributes.Field(Name = "notelp", AllowNull = false)]
        public virtual string Telp { get; set; }

        [Attributes.Field(Name = "username", AllowNull = false)]
        public virtual string Username { get; set; }

        [Attributes.Field(Name = "password", AllowNull = false)]
        public virtual string Password { get; set; }

        [Attributes.Field(Name = "role", AllowNull = false)]
        public virtual string Role { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                "\tid: " + Id + "\n" +
                "\tnama: " + Nama + "\n" +
                "\tjk: " + JK + "\n" +
                "\talamat: " + Alamat + "\n" +
                "\ttelp: " + Telp + "\n" +
                "\tusername: " + Username + "\n" +
                "\tpassword: " + Password + "\n" +
                "\trole: " + Role;
        }
    }
}
