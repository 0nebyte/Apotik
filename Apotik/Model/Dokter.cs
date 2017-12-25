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

        public Dokter(int id, string kode, string nama, string alamat, string telp, string keterangan)
        {
            this.id = id;
            this.kode = kode;
            this.nama = nama;
            this.alamat = alamat;
            this.telp = telp;
            this.keterangan = keterangan;
        }

        [Attributes.Field(Name = "id", PrimaryKey = true, AutoIncrement = true)]
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

        [Attributes.Field(Name = "kode", AllowNull = false)]
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

        [Attributes.Field(Name = "kode_obat", AllowNull = false)]
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

    }
}
