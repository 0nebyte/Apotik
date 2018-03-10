using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotik.Menu.Dokter
{
    public class Controller : BaseController
    {
        private Model.Database db;
        private IEnumerable<Model.Dokter> daftarDokter;

        public IEnumerable<Model.Dokter> DaftarDokter
        {
            get { return daftarDokter; }
            set
            {
                daftarDokter = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("DaftarDokter"));
            }
        }

        public bool Validate(Model.Dokter dokter)
        {
            if (dokter.Kode == null || dokter.Kode.Trim() == "")
            {
                MessageBox.Show("Kode dokter tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (dokter.Nama == null || dokter.Nama.Trim() == "")
            {
                MessageBox.Show("Nama dokter tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (dokter.Alamat == null || dokter.Alamat.Trim() == "")
            {
                MessageBox.Show("Alamat dokter tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (dokter.Telp == null || dokter.Telp.Trim() == "")
            {
                MessageBox.Show("Nomor telepon dokter tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (dokter.Keterangan == null)
            {
                dokter.Keterangan = "";
            }

            return true;
        }

        public bool AddDokter(Model.Dokter dokter)
        {
            if (Validate(dokter))
            {
                db.Save(dokter);
                return true;
            }

            return false;
        }

        public bool UpdateDokter(Model.Dokter dokter)
        {
            if (Validate(dokter))
            {
                db.Update(dokter);
                return true;
            }

            return false;
        }

        public void RefreshData()
        {
            DaftarDokter = db.Query<Model.Dokter>().Execute();
        }

        public Controller()
        {
            db = Model.Database.Instance;
        }
    }
}
