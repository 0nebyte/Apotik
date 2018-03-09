using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotik.Model
{
    [Attributes.Table(TableName = "tb_distributor")]
    public class Distributor : BaseModel
    {
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
        public virtual int Id { get; set; }

        [Attributes.Field(Name = "kode_distributor", AllowNull = false)]
        public virtual string Kode { get; set; }

        [Attributes.Field(Name = "nama", AllowNull = false)]
        public virtual string Nama { get; set; }

        [Attributes.Field(Name = "alamat", AllowNull = false)]
        public virtual string Alamat { get; set; }

        [Attributes.Field(Name = "kota", AllowNull = false)]
        public virtual string Kota { get; set; }

        [Attributes.Field(Name = "notelp", AllowNull = false)]
        public virtual string Telp { get; set; }

        [Attributes.Field(Name = "bank", AllowNull = true)]
        public virtual string Bank { get; set; }

        [Attributes.Field(Name = "norek", AllowNull = false)]
        public virtual string Norek { get; set; }

        [Attributes.Field(Name = "email", AllowNull = true)]
        public virtual string Email { get; set; }

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
