using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotik.Menu.Obat
{
    public class Controller : BaseController
    {
        private Model.Database db;
        private IEnumerable<Model.Obat> daftarObat;

        public IEnumerable<Model.Obat> DaftarObat
        {
            get { return daftarObat; }
            set
            {
                daftarObat = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("DaftarObat"));
            }
        }

        public bool Validate(Model.Obat obat)
        {
            if (obat.Kode == null || obat.Kode.Trim() == "")
            {
                MessageBox.Show("Kode obat tidak boleh kosong.", "Kesalahan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (obat.Nama == null || obat.Nama.Trim() == "")
            {
                MessageBox.Show("Nama obat tidak boleh kosong.", "Kesalahan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (obat.Satuan == null || obat.Satuan.Trim() == "")
            {
                MessageBox.Show("Satuan obat tidak boleh kosong.", "Kesalahan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (obat.Harga == 0)
            {
                MessageBox.Show("Harga harus lebih dari 0 (nol).", "Kesalahan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (obat.Keterangan == null || obat.Keterangan.Trim() == "")
            {
                MessageBox.Show("Keterangan obat harus diisi.", "Kesalahan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void RefreshData()
        {
            DaftarObat = db.Query2<Model.Obat>().Execute();
        }

        public bool AddObat(Model.Obat obat)
        {
            if (Validate(obat))
            {
                db.Save(obat);
                return true;
            }

            return false;
        }

        public bool UpdateObat(Model.Obat obat)
        {
            if (Validate(obat))
            {
                db.Update(obat);
                return true;
            }

            return false;
        }

        public void RemoveObat(Model.Obat obat)
        {
            throw new NotImplementedException();
        }

        public Controller()
        {
            db = Model.Database.Instance;
        }
    }
}
