using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotik.Menu.Transaksi.Penjualan
{
    public partial class Jual : Form
    {
        private Controller controller;

        public Jual()
        {
            InitializeComponent();

            controller = new Controller();
            KeyPreview = true;

            txt_dokter.DataBindings.Add("Text", controller.Penjualan, "Dokter");
            txt_subtotal.DataBindings.Add("Text", controller.Penjualan, "SubTotal");
            txt_diskon.DataBindings.Add("Text", controller.Penjualan, "Diskon");
            txt_ppn.DataBindings.Add("Text", controller.Penjualan, "PPN");
            txt_grandtotal.DataBindings.Add("Text", controller.Penjualan, "GrandTotal");
            dgv_penjualan.DataBindings.Add("DataSource", controller, "DetailJual");
        }

        private void Jual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                var dokter = new dataDokter(controller);
                dokter.ShowDialog();
            }
            else if (e.KeyCode == Keys.F3)
            {
                var obat = new dataObat(controller);
                obat.ShowDialog();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void dgv_penjualan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var obat = new dataObat(controller);
            obat.ShowDialog();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Keluar dari form ini?","Exit",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
        }
    }
}
