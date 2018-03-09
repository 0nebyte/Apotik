using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotik.Menu.Obat
{
    public partial class Tambah : MetroFramework.Forms.MetroForm
    {
        private Controller controller;
        private Model.Obat model;

        public Tambah(Controller controller, Model.Obat obat = null)
        {
            this.controller = controller;

            InitializeComponent();

            if (obat != null)
                model = obat;
            else
                model = new Model.Obat();

            txt_kode.DataBindings.Add("Text", model, "Kode");
            txt_nama.DataBindings.Add("Text", model, "Nama");
            cmb_satuan.DataBindings.Add("Text", model, "Satuan");
            txt_stok.DataBindings.Add("Text", model, "Stok");
            txt_harga.DataBindings.Add("Text", model, "Harga");
            txt_ket.DataBindings.Add("Text", model, "Keterangan");
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            var db = Model.Database.Instance;
            db.Save(model);

            controller.Obats = Model.Database.Instance.Query<Model.Obat>();

            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
