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
    public partial class edit : Form
    {
        private Controller controller;
        private Model.Obat obat;

        public edit(Controller controller)
        {
            this.controller = controller;

            InitializeComponent();
        }

        private void edit_Load(object sender, EventArgs e)
        {
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            var query = txt_cari.Text;
            var category = cmb_jenis.SelectedItem.ToString();
            IEnumerable<Model.Obat> result;

            if (category == "Kode")
            {
                result = Model.Database.Instance
                    .Query<Model.Obat>("kode_obat = '" + query + "'");
            }
            else if (category == "Nama")
            {
                result = Model.Database.Instance
                    .Query<Model.Obat>("nama = '" + query + "'");
            }
            else
            {
                MessageBox.Show("Tidak dapat menemukan obat.");
                return;
            }

            obat = result.FirstOrDefault();
            txt_kode.DataBindings.Add("Text", obat, "Kode");
            txt_nama.DataBindings.Add("Text", obat, "Nama");
            txt_satuan.DataBindings.Add("Text", obat, "Satuan");
            txt_stok.DataBindings.Add("Text", obat, "Stok");
            txt_harga.DataBindings.Add("Text", obat, "Harga");
            txt_ket.DataBindings.Add("Text", obat, "Keterangan");

            gb_data.Visible = true;
        }

        private void cmb_jenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cari.ReadOnly = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            var db = Model.Database.Instance;
            db.Update(obat, "id_obat = '" + obat.Id + "'");

            controller.Obats = Model.Database.Instance.Query<Model.Obat>();

            Close();
        }
    }
}
