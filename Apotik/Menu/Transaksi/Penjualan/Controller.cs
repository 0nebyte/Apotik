using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotik.Menu.Transaksi.Penjualan
{
    public class Controller : System.ComponentModel.INotifyPropertyChanged
    {
        private IList<Model.DetailJual> detailJual = new List<Model.DetailJual>();
        public IList<Model.DetailJual> DetailJual
        {
            get { return detailJual; }
            set
            {
                detailJual = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("DetailJual"));
            }
        }

        private Model.Dokter dokter;
        public Model.Dokter Dokter
        {
            get { return dokter; }
            set
            {
                dokter = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Dokter"));
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
}
