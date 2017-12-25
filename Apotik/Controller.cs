using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotik
{
    public class Controller : System.ComponentModel.INotifyPropertyChanged
    {
        private IEnumerable<Model.Obat> obats = new List<Model.Obat>();

        public IEnumerable<Model.Obat> Obats
        {
            get { return obats;  }
            set
            {
                obats = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Obats"));
            }
        }

        private IEnumerable<Model.Dokter> dokters = new List<Model.Dokter>();

        public IEnumerable<Model.Dokter> Dokters
        {
            get { return dokters; }
            set
            {
                dokters = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Dokters"));
            }
        }

        #region INotifyPropertyChanged implementation
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        public void InvokePropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, e);
        }
        #endregion
    }
}
