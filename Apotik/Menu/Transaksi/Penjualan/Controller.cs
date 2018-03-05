using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotik.Menu.Transaksi.Penjualan
{
    public class Controller : System.ComponentModel.INotifyPropertyChanged
    {
        private IList<Apotik.Model.Obat> daftarObat = new List<Apotik.Model.Obat>();
        public IList<Apotik.Model.Obat> DaftarObat
        {
            get { return daftarObat; }
            set
            {
                daftarObat = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("DaftarObat"));
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
