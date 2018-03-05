using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotik.Model
{
    public class Obat : BaseModel
    {
        public static string tableName = "tb_obat";

        private int id;
        private string kode;
        private string nama;
        private string satuan;
        private int stok;
        private int harga;
        private string keterangan;

        public Obat()
        {
        }

        public Obat(int id, string kode, string nama, string satuan, int stok, int harga,
            string keterangan)
        {
            this.id = id;
            this.kode = kode;
            this.nama = nama;
            this.satuan = satuan;
            this.stok = stok;
            this.harga = harga;
            this.keterangan = keterangan;
        }

        [Attributes.Field(Name = "id_obat", PrimaryKey = true, AutoIncrement = true)]
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Id"));
            }
        }

        [Attributes.Field(Name = "kode_obat", AllowNull = false)]
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

        [Attributes.Field(Name = "satuan", AllowNull = false)]
        public string Satuan
        {
            get { return satuan; }
            set
            {
                satuan = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Satuan"));
            }
        }

        [Attributes.Field(Name = "stok", AllowNull = false)]
        public int Stok
        {
            get { return stok; }
            set
            {
                stok = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Stok"));
            }
        }

        [Attributes.Field(Name = "harga", AllowNull = false)]
        public int Harga
        {
            get { return harga; }
            set
            {
                harga = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Harga"));
            }
        }

        [Attributes.Field(Name = "keterangan", AllowNull = false)]
        public string Keterangan
        {
            get { return keterangan; }
            set
            {
                keterangan = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Keterangan"));
            }
        }

        public override string ToString()
        {
            return nama;
        }
    }
}
