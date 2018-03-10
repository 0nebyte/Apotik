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
                var dokter = new DataDokter(controller);
                dokter.ShowDialog();
            }
            else if (e.KeyCode == Keys.F3)
            {
                var obat = new DataObat(controller);
                obat.ShowDialog();
            }
            else if (e.KeyCode == Keys.F8)
            {
                btn_simpan_Click(null, null);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void dgv_penjualan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var obat = new DataObat(controller);
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
            if (controller.DetailJual.Count() == 0)
            {
                MessageBox.Show("Penjualan kosong tidak diperbolehkan.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var result = MessageBox.Show("Lakukan penjualan?", "Apotik", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            controller.DoTransaction();
            Close();
        }

        private void dgv_penjualan_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                // Kolom quantity
                MessageBox.Show("Quantity harus berupa angka.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

        private void dgv_penjualan_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex != 3)
            {
                return;
            }

            var kodeObat = (string)dgv_penjualan.Rows[e.RowIndex].Cells[0].Value;
            var quantity = dgv_penjualan.Rows[e.RowIndex].Cells[3].Value;

            var detail = controller.DetailJual.FirstOrDefault(p => p.KodeObat == kodeObat);
            if (detail == null)
            {
                // Harusnya tidak pernah terjadi
                throw new NotImplementedException();
            }

            if (detail.Quantity > detail.Detail.Obat.Stok)
            {
                MessageBox.Show(string.Format("Penjualan barang '{0}' tidak boleh melibihi stok.",
                    detail.Detail.Obat.Nama), "Apotik", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                detail.Quantity = detail.Detail.Obat.Stok;
            }
            else if (detail.Quantity < 1)
            {
                MessageBox.Show(string.Format("Penjualan barang '{0}' harus minimal 1.",
                    detail.Detail.Obat.Nama), "Apotik", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                detail.Quantity = 1;
            }
        }

        private void dgv_penjualan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = (DataGridView)sender;

            if (dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >=0)
            {
                var kodeObat = (string)dgv.Rows[e.RowIndex].Cells[0].Value;
                controller.DeleteObat(kodeObat);
            }
        }
    }
}
