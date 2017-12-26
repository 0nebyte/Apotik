using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotik.Model
{
    public class Distributor : System.ComponentModel.INotifyPropertyChanged
    {
        #region INotifyPropertyChanged implementation
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        public void InvokePropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, e);
        }
        #endregion

        public static string tableName = "tb_distributor";

        private int id;
        private string kode;
        private string nama;
        private string alamat;
        private string kota;
        private string telp;
        private string bank;
        private string norek;
        private string email;

        public Distributor()
        {
        }

        public Distributor(int id, string kode, string nama, string alamat, string kota, 
            string telp,string bank, string norek, string email)
        {
            this.id = id;
            this.kode = kode;
            this.nama = nama;
            this.alamat = alamat;
            this.kota = kota;
            this.telp = telp;
            this.bank = bank;
            this.norek = norek;
            this.email = email;
        }

        [Attributes.Field(Name = "id_distributor", PrimaryKey = true, AutoIncrement = true)]
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

        [Attributes.Field(Name = "kode_distributor", AllowNull = false)]
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

        [Attributes.Field(Name = "kota", AllowNull = false)]
        public string Kota
        {
            get
            {
                return kota;
            }

            set
            {
                kota = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Kota"));
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

        [Attributes.Field(Name = "bank", AllowNull = true)]
        public string Bank
        {
            get
            {
                return bank;
            }

            set
            {
                bank = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Bank"));
            }
        }

        [Attributes.Field(Name = "norek", AllowNull = false)]
        public string Norek
        {
            get
            {
                return norek;
            }

            set
            {
                norek = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Norek"));
            }
        }

        [Attributes.Field(Name = "email", AllowNull = true)]
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Email"));
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                "\tid: " + id + "\n" +
                "\tkode: " + kode + "\n" +
                "\tnama: " + nama + "\n" +
                "\talamat: " + alamat + "\n" +
                "\tkota: " + kota + "\n" +
                "\ttelp: " + telp + "\n" +
                "\tbank: " + bank + "\n" +
                "\tnorek: " + norek + "\n" +
                "\tketerangan: " + email;
        }
    }
}
