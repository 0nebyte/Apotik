using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotik.Model
{
    public class Distributor : BaseModel
    {
        public static string tableName = "tb_distributor";

        public Distributor()
        {
        }

        public Distributor(int id, string kode, string nama, string alamat, string kota, 
            string telp,string bank, string norek, string email)
        {
            Id = id;
            Kode = kode;
            Nama = nama;
            Alamat = alamat;
            Kota = kota;
            Telp = telp;
            Bank = bank;
            Norek = norek;
            Email = email;
        }

        [Attributes.Field(Name = "id_distributor", PrimaryKey = true, AutoIncrement = true)]
        public int Id { get; set; }

        [Attributes.Field(Name = "kode_distributor", AllowNull = false)]
        public string Kode { get; set; }

        [Attributes.Field(Name = "nama", AllowNull = false)]
        public string Nama { get; set; }

        [Attributes.Field(Name = "alamat", AllowNull = false)]
        public string Alamat { get; set; }

        [Attributes.Field(Name = "kota", AllowNull = false)]
        public string Kota { get; set; }

        [Attributes.Field(Name = "notelp", AllowNull = false)]
        public string Telp { get; set; }

        [Attributes.Field(Name = "bank", AllowNull = true)]
        public string Bank { get; set; }

        [Attributes.Field(Name = "norek", AllowNull = false)]
        public string Norek { get; set; }

        [Attributes.Field(Name = "email", AllowNull = true)]
        public string Email { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                "\tid: " + Id + "\n" +
                "\tkode: " + Kode + "\n" +
                "\tnama: " + Nama + "\n" +
                "\talamat: " + Alamat + "\n" +
                "\tkota: " + Kota + "\n" +
                "\ttelp: " + Telp + "\n" +
                "\tbank: " + Bank + "\n" +
                "\tnorek: " + Norek + "\n" +
                "\tketerangan: " + Email;
        }
    }
}
