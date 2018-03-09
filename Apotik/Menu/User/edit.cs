using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotik.Menu.User
{
    public partial class Edit : MetroFramework.Forms.MetroForm
    {

        private Controller controller;
        private Model.User user;

        public Edit(Controller controller)
        {
            this.controller = controller;

            InitializeComponent();
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            var db = Model.Database.Instance;
            var query = txt_cari.Text;
            var category = cb_jenis.SelectedItem.ToString();
            IEnumerable<Model.User> result;

            if (category == "Kode")
            {
                //kalau ini pakai Like bisa ko ndre? jadi kode like query
                result = db.Query2<Model.User>().Where(db.Column("Kode") == query).Execute();
            }
            else if (category == "Nama")
            {
                //kalau ini pakai Like bisa ko ndre? jadi kode like query
                result = db.Query2<Model.User>().Where(db.Column("Nama") == query).Execute();
            }
            else
            {
                MessageBox.Show("Tidak dapat menemukan obat.");
                return;
            }

            user = result.FirstOrDefault();

            if (user != null)
            {
                txt_kode.DataBindings.Clear();
                txt_kode.DataBindings.Clear();
                txt_nama.DataBindings.Clear();
                cmb_jk.DataBindings.Clear();
                txt_alamat.DataBindings.Clear();
                txt_telp.DataBindings.Clear();
                txt_username.DataBindings.Clear();
                txt_password.DataBindings.Clear();
                cmb_role.DataBindings.Clear();

                txt_kode.DataBindings.Add("Text", user, "Kode");
                txt_nama.DataBindings.Add("Text", user, "Nama");
                cmb_jk.DataBindings.Add("Text", user, "JK");
                txt_alamat.DataBindings.Add("Text", user, "Alamat");
                txt_telp.DataBindings.Add("Text", user, "Telp");
                txt_username.DataBindings.Add("Text", user, "Username");
                txt_password.DataBindings.Add("Text", user, "Password");
                cmb_role.DataBindings.Add("Text", user, "Role");
            }
            else
            {
                txt_kode.DataBindings.Clear();
                txt_kode.DataBindings.Clear();
                txt_nama.DataBindings.Clear();
                cmb_jk.DataBindings.Clear();
                txt_alamat.DataBindings.Clear();
                txt_telp.DataBindings.Clear();
                txt_username.DataBindings.Clear();
                txt_password.DataBindings.Clear();
                cmb_role.DataBindings.Clear();
            }
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            var db = Model.Database.Instance;
            db.Update(user);

            controller.Users = Model.Database.Instance.Query<Model.User>();

            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
