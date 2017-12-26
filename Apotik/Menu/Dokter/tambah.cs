using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotik.Menu.Dokter
{
    public partial class tambah : MetroFramework.Forms.MetroForm
    {
        private Controller controller;
        private Model.Dokter model;

        public tambah(Controller controller, Model.Dokter dokter = null)
        {
            this.controller = controller;

            InitializeComponent();

            if (dokter != null)
                model = dokter;
            else
                model = new Model.Dokter();

            txt_kode.DataBindings.Add("Text", model, "Kode");
            txt_nama.DataBindings.Add("Text", model, "Nama");
            txt_alamat.DataBindings.Add("Text", model, "Alamat");
            txt_telp.DataBindings.Add("Text", model, "Telp");
            txt_ket.DataBindings.Add("Text", model, "Keterangan");
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            var db = Model.Database.Instance;
            db.Save(model);

            controller.Dokters = Model.Database.Instance.Query<Model.Dokter>();

            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
