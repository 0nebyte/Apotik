using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotik.Menu.Transaksi.Penjualan
{
    public class Controller : System.ComponentModel.INotifyPropertyChanged
    {
        public Model.Penjualan Penjualan { get; } = Model.BaseModel.New<Model.Penjualan>();

        private IList<DetailDataSource> detailJual = new List<DetailDataSource>();
        public IList<DetailDataSource> DetailJual
        {
            get { return detailJual; }
            set
            {
                detailJual = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("DetailJual"));
            }
        }

        #region INotifyPropertyChangedImplementation
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        public void InvokePropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, e);
        }
        #endregion
    }

    public class DetailDataSource
    {
        private Model.DetailJual detail;

        public DetailDataSource(Model.DetailJual detail)
        {
            this.detail = detail;
        }

        public Model.DetailJual Detail { get { return detail; } }
        public string KodeObat { get { return detail.Obat.Kode; } }
        public string NamaObat { get { return detail.Obat.Nama; } }
        public string Satuan { get { return detail.Obat.Satuan; } }
        public int Quantity { get { return detail.Quantity; } set { detail.Quantity = value; } }
        public int Harga { get { return detail.Obat.Harga; } }
        public int SubTotal { get { return detail.Obat.Harga * detail.Quantity; } }
    }
}
