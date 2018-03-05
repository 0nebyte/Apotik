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
    public partial class Jual : MetroFramework.Forms.MetroForm
    {
        private Controller controller;
        public Jual(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
            this.KeyPreview = true;

            txt_dokter.DataBindings.Add("Text", controller, "DokterResep");

            dgv_penjualan.DataBindings.Add("DataSource", controller, "ObatResep");

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Keluar dari form ini?","Exit", 
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                this.Close();
            }  
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
        }

        private void dgv_penjualan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var obat = new dataObat(controller);
            obat.ShowDialog();
        }
    }
}
