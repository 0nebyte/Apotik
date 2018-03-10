using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotik.Menu.Distributor
{
    public class Controller : BaseController
    {
        private Model.Database db;
        private IEnumerable<Model.Distributor> daftarDistributor;

        public IEnumerable<Model.Distributor> DaftarDistributor
        {
            get { return daftarDistributor; }
            set
            {
                daftarDistributor = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("DaftarDistributor"));
            }
        }

        public bool Validate(Model.Distributor distributor)
        {
            if (distributor.Kode == null || distributor.Kode.Trim() == "")
            {
                MessageBox.Show("Kode distributor tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (distributor.Nama == null || distributor.Nama.Trim() == "")
            {
                MessageBox.Show("Nama distributor tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (distributor.Alamat == null || distributor.Alamat.Trim() == "")
            {
                MessageBox.Show("Alamat distributor tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (distributor.Kota == null || distributor.Kota.Trim() == "")
            {
                MessageBox.Show("Kota distributor tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (distributor.Telp == null || distributor.Telp.Trim() == "")
            {
                MessageBox.Show("Nomor telepon distributor tidak boleh kosong.", "Kesalahan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (distributor.Bank == null || distributor.Bank.Trim() == "")
            {
                MessageBox.Show("Kolom bank tidak boleh kosong.", "Kesalahan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (distributor.Norek == null || distributor.Norek.Trim() == "")
            {
                MessageBox.Show("Nomor rekening tidak boleh kosong.", "Kesalahan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (distributor.Email == null)
            {
                distributor.Email = "";
            }

            return true;
        }

        public bool AddDistributor(Model.Distributor distributor)
        {
            if (Validate(distributor))
            {
                db.Save(distributor);
                return true;
            }

            return false;
        }

        public bool UpdateDistributor(Model.Distributor distributor)
        {
            if (Validate(distributor))
            {
                db.Update(distributor);
                return true;
            }

            return false;
        }

        public void RefreshData()
        {
            DaftarDistributor = db.Query2<Model.Distributor>().Execute();
        }

        public Controller()
        {
            db = Model.Database.Instance;
        }
    }
}
