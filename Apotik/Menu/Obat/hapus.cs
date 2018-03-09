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
    public partial class Hapus : MetroFramework.Forms.MetroForm
    {
        private Controller controller;
        private Model.Obat obat;

        public Hapus(Controller controller)
        {
            InitializeComponent();

            this.controller = controller;
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            var db = Model.Database.Instance;
            var query = string.Format("%{0}%", txt_cari.Text);
            var category = cb_jenis.SelectedItem.ToString();
            IEnumerable<Model.Obat> result;

            if (category == "Kode")
            {
                result = db.Query2<Model.Obat>().Where(db.Like(db.Column("Kode"), query)).Execute();
            }
            else if (category == "Nama")
            {
                result = db.Query2<Model.Obat>().Where(db.Like(db.Column("Nama"), query)).Execute();
            }
            else
            {
                MessageBox.Show("Tidak dapat menemukan obat.");
                return;
            }

            obat = result.FirstOrDefault();

            if (obat != null)
            {
                txt_kode.DataBindings.Clear();
                txt_kode.DataBindings.Clear();
                txt_nama.DataBindings.Clear();
                txt_satuan.DataBindings.Clear();
                txt_stok.DataBindings.Clear();
                txt_harga.DataBindings.Clear();
                txt_ket.DataBindings.Clear();

                txt_kode.DataBindings.Add("Text", obat, "Kode");
                txt_nama.DataBindings.Add("Text", obat, "Nama");
                txt_satuan.DataBindings.Add("Text", obat, "Satuan");
                txt_stok.DataBindings.Add("Text", obat, "Stok");
                txt_harga.DataBindings.Add("Text", obat, "Harga");
                txt_ket.DataBindings.Add("Text", obat, "Keterangan");
            }
            else
            {
                txt_kode.DataBindings.Clear();
                txt_kode.DataBindings.Clear();
                txt_nama.DataBindings.Clear();
                txt_satuan.DataBindings.Clear();
                txt_stok.DataBindings.Clear();
                txt_harga.DataBindings.Clear();
                txt_ket.DataBindings.Clear();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            controller.RemoveObat(obat);
            controller.RefreshData();
            Close();
        }
    }
}
