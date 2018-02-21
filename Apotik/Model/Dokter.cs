using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotik.Model
{
   public class Dokter : System.ComponentModel.INotifyPropertyChanged
    {
        #region INotifyPropertyChanged implementation
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        public void InvokePropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, e);
        }
        #endregion

        public static string tableName = "tb_dokter";

        private int id;
        private string kode;
        private string nama;
        private string alamat;
        private string telp;
        private string keterangan;

        public Dokter()
        {
        }

        public Dokter(int id, string kode, string nama, string alamat, string notelp, string keterangan)
        {
            this.id = id;
            this.kode = kode;
            this.nama = nama;
            this.alamat = alamat;
            this.telp = telp;
            this.keterangan = keterangan;
        }

        [Attributes.Field(Name = "id_dokter", PrimaryKey = true, AutoIncrement = true)]
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Id"));
            }
        }

        [Attributes.Field(Name = "kode_dokter", AllowNull = false)]
        public string Kode
        {
            get
            {
                return kode;
            }

            set
            {
                kode = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Kode"));
            }
        }

        [Attributes.Field(Name = "nama", AllowNull = false)]
        public string Nama
        {
            get
            {
                return nama;
            }

            set
            {
                nama = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Nama"));
            }
        }

        [Attributes.Field(Name = "alamat", AllowNull = false)]
        public string Alamat
        {
            get
            {
                return alamat;
            }

            set
            {
                alamat = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Alamat"));
            }
        }

        [Attributes.Field(Name = "notelp", AllowNull = false)]
        public string Telp
        {
            get
            {
                return telp;
            }

            set
            {
                telp = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Telp"));
            }
        }

        [Attributes.Field(Name = "keterangan", AllowNull = true)]
        public string Keterangan
        {
            get
            {
                return keterangan;
            }

            set
            {
                keterangan = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Keterangan"));
            }
        }

        public override string ToString()
        {
            return kode + " " + nama;
            //return base.ToString() + "\n" +
            //    "\tid: " + id + "\n" +
            //    "\tkode: " + kode + "\n" +
            //    "\tnama: " + nama + "\n" +
            //    "\talamat: " + alamat + "\n" +
            //    "\ttelp: " + telp + "\n" +
            //    "\tketerangan: " + keterangan;
        }
    }
}
