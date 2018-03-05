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

        private int id;
        private string kode;
        private string nama;
        private string jk;
        private string alamat;
        private string kota;
        private string telp;
        private string username;
        private string password;
        private string role;

        public User(int id, string kode, string nama, string jk, string alamat, string kota,
            string telp, string username, string password, string role)
        {
            this.id = id;
            this.kode = kode;
            this.nama = nama;
            this.jk = jk;
            this.alamat = alamat;
            this.kota = kota;
            this.telp = telp;
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public User()
        {
        }

        [Attributes.Field(Name = "id_user", PrimaryKey = true, AutoIncrement = true)]
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Id"));
            }
        }

        [Attributes.Field(Name = "kode_user", AllowNull = false)]
        public string Kode
        {
            get { return kode; }
            set
            {
                kode = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Kode"));
            }
        }

        [Attributes.Field(Name = "nama", AllowNull = false)]
        public string Nama
        {
            get { return nama; }
            set
            {
                nama = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Nama"));
            }
        }

        [Attributes.Field(Name = "jk", AllowNull = false)]
        public string JK
        {
            get { return jk; }
            set
            {
                jk = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("JK"));
            }
        }

        [Attributes.Field(Name = "alamat", AllowNull = false)]
        public string Alamat
        {
            get { return alamat; }
            set
            {
                alamat = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Alamat"));
            }
        }

        [Attributes.Field(Name = "notelp", AllowNull = false)]
        public string Telp
        {
            get { return telp; }
            set
            {
                telp = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Telp"));
            }
        }

        [Attributes.Field(Name = "username", AllowNull = false)]
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Username"));
            }
        }

        [Attributes.Field(Name = "password", AllowNull = false)]
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Password"));
            }
        }

        [Attributes.Field(Name = "role", AllowNull = false)]
        public string Role
        {
            get { return role; }
            set
            {
                role = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Role"));
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                "\tid: " + id + "\n" +
                "\tnama: " + nama + "\n" +
                "\tjk: " + jk + "\n" +
                "\talamat: " + alamat + "\n" +
                "\ttelp: " + telp + "\n" +
                "\tusername: " + username + "\n" +
                "\tpassword: " + password + "\n" +
                "\trole: " + role;
        }
    }
}
