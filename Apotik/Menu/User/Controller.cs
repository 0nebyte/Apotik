using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotik.Menu.User
{
    public class Controller : BaseController
    {
        private Model.Database db;
        private IEnumerable<Model.User> daftarUser;

        public IEnumerable<Model.User> DaftarUser
        {
            get { return daftarUser; }
            set
            {
                daftarUser = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("DaftarUser"));
            }
        }

        public bool Validate(Model.User user)
        {
            //Kode
            if (user.Kode == null || user.Kode.Trim() == "")
            {
                MessageBox.Show("Kode pengguna tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            //Nama
            if (user.Nama == null || user.Nama.Trim() == "")
            {
                MessageBox.Show("Nama pengguna tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            //Jenis Kelamin
            if (user.JK == null || user.JK.Trim() == "")
            {
                MessageBox.Show("Jenis kelamin pengguna tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            //Alamat
            if (user.Alamat == null || user.Alamat.Trim() == "")
            {
                MessageBox.Show("Alamat pengguna tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            //Telp
            if (user.Telp == null || user.Telp.Trim() == "")
            {
                MessageBox.Show("Nomor telepon pengguna tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            //Jabatan
            if (user.Role == null || user.Role.Trim() == "")
            {
                MessageBox.Show("Jabatan pengguna tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            //Username
            if (user.Username == null || user.Username.Trim() == "")
            {
                MessageBox.Show("Username pengguna tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            //Password
            if (user.Password == null || user.Password.Trim() == "")
            {
                MessageBox.Show("Password pengguna tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool AddUser(Model.User user)
        {
            if (Validate(user))
            {
                db.Save(user);
                return true;
            }

            return false;
        }

        public bool UpdateUser(Model.User user)
        {
            if (Validate(user))
            {
                db.Update(user);
                return true;
            }

            return false;
        }

        public void RefreshData()
        {
            DaftarUser = db.Query<Model.User>().Execute();
        }

        public Controller()
        {
            db = Model.Database.Instance;
        }
    }
}
