using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotik.Model
{
    public class Penjualan : BaseModel
    {
        public static string tableName = "tb_jual";

        private int id;
        private string id_dokter;
        private string faktur;
        private string id_obat;
        private string qty;
        private string total;
        private string sub_total;
        private string diskon;
        private string ppn;
        private string grand_total;
        

        public Penjualan()
        {
        }

        public Penjualan(int id, string id_dokter, string faktur, string id_obat, string qty, string total, 
            string sub_total, string diskon, string ppn, string grand_total)
        {
            this.id = id;
            this.id_dokter = id_dokter;
            this.faktur = faktur;
            this.id_obat = id_obat;
            this.qty = qty;
            this.total = total;
            this.sub_total = sub_total;
            this.diskon = diskon;
            this.ppn = ppn;
            this.grand_total = grand_total;
        }

        [Attributes.Field(Name = "id_jual", PrimaryKey = true, AutoIncrement = true)]
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Id"));
            }
        }

        [Attributes.Field(Name = "id_dokter", AllowNull = true)]
        public string ID_Dokter
        {
            get { return id_dokter; }
            set
            {
                id_dokter = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Id_Obat"));
            }
        }

        [Attributes.Field(Name = "no_faktur", AllowNull = true)]
        public string Faktur
        {
            get { return faktur; }
            set
            {
                faktur = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Faktur"));
            }
        }

        [Attributes.Field(Name = "id_obat", AllowNull = true)]
        public string ID_Obat
        {
            get { return id_dokter; }
            set
            {
                id_obat = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Id_Obat"));
            }
        }

        [Attributes.Field(Name = "qty", AllowNull = true)]
        public string Qty
        {
            get { return qty; }
            set
            {
                qty = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("qty"));
            }
        }

        [Attributes.Field(Name = "total", AllowNull = true)]
        public string Total
        {
            get { return total; }
            set
            {
                total = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Total"));
            }
        }

        [Attributes.Field(Name = "sub_total", AllowNull = true)]
        public string Sub_Total
        {
            get { return sub_total; }
            set
            {
                sub_total = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Sub_Total"));
            }
        }

        [Attributes.Field(Name = "diskon", AllowNull = true)]
        public string Diskon
        {
            get { return diskon; }
            set
            {
                diskon = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Diskon"));
            }
        }

        [Attributes.Field(Name = "ppn", AllowNull = true)]
        public string PPN
        {
            get { return ppn; }
            set
            {
                ppn = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("PPN"));
            }
        }

        [Attributes.Field(Name = "grand_total", AllowNull = true)]
        public string Grand_Total
        {
            get { return grand_total; }
            set
            {
                grand_total = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Grand_Total"));
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                "\tid: " + id + "\n" +
                "\tIdDokter: " + id_dokter + "\n" +
                "\tfaktur: " + faktur + "\n" +
                "\tidobat: " + id_obat + "\n" +
                "\tqty: " + qty + "\n" +
                "\ttotal: " + total + "\n" +
                "\tsubtotal: " + sub_total + "\n" +
                "\tdiskon: " + diskon + "\n" +
                "\tppn: " + ppn + "\n" +
                "\tgrandtotal: " + grand_total;
        }
    }
}
