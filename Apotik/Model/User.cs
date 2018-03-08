using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotik.Model
{
    public class User : BaseModel
    {
        public static string tableName = "tb_user";

        public User(int id, string kode, string nama, string jk, string alamat, string kota,
            string telp, string username, string password, string role)
        {
            Id = id;
            Kode = kode;
            Nama = nama;
            JK = jk;
            Alamat = alamat;
            Telp = telp;
            Username = username;
            Password = password;
            Role = role;
        }

        public User()
        {
        }

        [Attributes.Field(Name = "id_user", PrimaryKey = true, AutoIncrement = true)]
        public int Id { get; set; }

        [Attributes.Field(Name = "kode_user", AllowNull = false)]
        public string Kode { get; set; }

        [Attributes.Field(Name = "nama", AllowNull = false)]
        public string Nama { get; set; }

        [Attributes.Field(Name = "jk", AllowNull = false)]
        public string JK { get; set; }

        [Attributes.Field(Name = "alamat", AllowNull = false)]
        public string Alamat { get; set; }

        [Attributes.Field(Name = "notelp", AllowNull = false)]
        public string Telp { get; set; }

        [Attributes.Field(Name = "username", AllowNull = false)]
        public string Username { get; set; }

        [Attributes.Field(Name = "password", AllowNull = false)]
        public string Password { get; set; }

        [Attributes.Field(Name = "role", AllowNull = false)]
        public string Role { get; set; }

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
