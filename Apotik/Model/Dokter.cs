using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotik.Model
{
   public class Dokter : BaseModel
    {
        public static string tableName = "tb_dokter";

        public Dokter()
        {
        }

        public Dokter(int id, string kode, string nama, string alamat, string notelp, string keterangan)
        {
            Id = id;
            Kode = kode;
            Nama = nama;
            Alamat = alamat;
            Telp = Telp;
            Keterangan = keterangan;
        }

        [Attributes.Field(Name = "id_dokter", PrimaryKey = true, AutoIncrement = true)]
        public int Id { get; set; }

        [Attributes.Field(Name = "kode_dokter", AllowNull = false)]
        public string Kode { get; set; }

        [Attributes.Field(Name = "nama", AllowNull = false)]
        public string Nama { get; set; }

        [Attributes.Field(Name = "alamat", AllowNull = false)]
        public string Alamat { get; set; }

        [Attributes.Field(Name = "notelp", AllowNull = false)]
        public string Telp { get; set; }

        [Attributes.Field(Name = "keterangan", AllowNull = true)]
        public string Keterangan { get; set; }

        public override string ToString()
        {
            return Nama;
        }
    }
}
