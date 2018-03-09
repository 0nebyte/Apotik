using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotik.Menu.Distributor
{
    public partial class Tambah : MetroFramework.Forms.MetroForm
    {
        private Controller controller;
        private Model.Distributor model;

        public Tambah(Controller controller, Model.Distributor distributor = null)
        {
            this.controller = controller;

            InitializeComponent();

            if (distributor != null)
                model = distributor;
            else
                model = new Model.Distributor();

            txt_kode.DataBindings.Add("Text", model, "Kode");
            txt_nama.DataBindings.Add("Text", model, "Nama");
            txt_alamat.DataBindings.Add("Text", model, "Alamat");
            txt_kota.DataBindings.Add("Text", model, "Kota");
            txt_telp.DataBindings.Add("Text", model, "Telp");
            cmb_bank.DataBindings.Add("Text", model, "Bank");
            txt_norek.DataBindings.Add("Text", model, "Norek");
            txt_email.DataBindings.Add("Text", model, "Email");
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            var db = Model.Database.Instance;
            db.Save(model);

            controller.Distributors = Model.Database.Instance.Query<Model.Distributor>();

            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
