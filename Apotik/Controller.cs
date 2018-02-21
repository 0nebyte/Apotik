using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotik
{
    public class Controller : System.ComponentModel.INotifyPropertyChanged
    {
        public Controller()
        {
            dokterResep = new Model.Dokter();
        }

        private Model.Dokter dokterResep;
        public Model.Dokter DokterResep
        {
            get { return dokterResep; }
            set
            {
                dokterResep = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("DokterResep"));
            }
        }

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

    
        private IEnumerable<Model.Distributor> distributors = new List<Model.Distributor>();
        public IEnumerable<Model.Distributor> Distributors
        {
            get { return distributors; }
            set
            {
                distributors = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Distributors"));
            }
        }

        private IEnumerable<Model.Penjualan> penjualans = new List<Model.Penjualan>();
        public IEnumerable<Model.Penjualan> Penjualans
        {
            get { return Penjualans; }
            set
            {
                penjualans = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Penjualans"));
            }
        }

        private IEnumerable<Model.User> users = new List<Model.User>();
        public IEnumerable<Model.User> Users
        {
            get { return users; }
            set
            {
                users = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Users"));
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
