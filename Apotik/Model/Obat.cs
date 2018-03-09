using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotik.Model
{
    [Attributes.Table(TableName = "tb_obat")]
    public class Obat : BaseModel
    {
        public Obat()
        {
        }

        public Obat(int id, string kode, string nama, string satuan, int stok, int harga,
            string keterangan)
        {
            Id = id;
            Kode = kode;
            Nama = nama;
            Satuan = satuan;
            Stok = stok;
            Harga = harga;
            Keterangan = keterangan;
        }

        [Attributes.Field(Name = "id_obat", PrimaryKey = true, AutoIncrement = true)]
        public virtual int Id { get; set; }

        [Attributes.Field(Name = "kode_obat", AllowNull = false)]
        public virtual string Kode { get; set; }

        [Attributes.Field(Name = "nama", AllowNull = false)]
        public virtual string Nama { get; set; }

        [Attributes.Field(Name = "satuan", AllowNull = false)]
        public virtual string Satuan { get; set; }

        [Attributes.Field(Name = "stok", AllowNull = false)]
        public virtual int Stok { get; set; }

        [Attributes.Field(Name = "harga", AllowNull = false)]
        public virtual int Harga { get; set; }

        [Attributes.Field(Name = "keterangan", AllowNull = false)]
        public virtual string Keterangan { get; set; }

        public override string ToString()
        {
            return Nama;
        }
    }
}
