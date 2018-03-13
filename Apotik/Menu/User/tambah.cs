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
    public partial class Tambah : MetroFramework.Forms.MetroForm
    {
        private Controller controller;
        private Model.User model;

        public Tambah(Controller controller, Model.User user = null)
        {
            this.controller = controller;

            InitializeComponent();

            if (user != null)
                model = user;
            else
                model = new Model.User();

            txt_kode.DataBindings.Add("Text", model, "Kode");
            txt_nama.DataBindings.Add("Text", model, "Nama");
            cmb_jk.DataBindings.Add("Text", model, "JK");
            txt_alamat.DataBindings.Add("Text", model, "Alamat");
            txt_telp.DataBindings.Add("Text", model, "Telp");
            txt_username.DataBindings.Add("Text", model, "Username");
            txt_password.DataBindings.Add("Text", model, "Password");
            cmb_role.DataBindings.Add("Text", model, "Role");
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (controller.AddUser(model))
            {
                controller.RefreshData();
                Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
