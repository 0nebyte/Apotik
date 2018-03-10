using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotik
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Exit()
        {
            DialogResult dialogResult = MessageBox.Show("Keluar dari aplikasi?", "Keluar", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Tutup_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void tambahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obat = new Menu.Obat.Tambah(new Menu.Obat.Controller());
            obat.MdiParent = this;
            obat.Show();
        }

        private void obatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var masterObat = new Menu.Obat.MasterObat(new Menu.Obat.Controller());
            masterObat.MdiParent = this;
            masterObat.Show();
        }

        private void dokterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var masterdokter = new Menu.Dokter.MasterDokter(new Menu.Dokter.Controller());
            masterdokter.MdiParent = this;
            masterdokter.Show();
        }

        private void distributorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var masterDistributor = new Menu.Distributor.MasterDistributor(
                new Apotik.Menu.Distributor.Controller());
            masterDistributor.MdiParent = this;
            masterDistributor.Show();
        }

        private void penggunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var masterUser = new Menu.User.MasterUser(new Apotik.Menu.User.Controller());
            masterUser.MdiParent = this;
            masterUser.Show();
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var jual = new Menu.Transaksi.Penjualan.Jual();
            jual.ShowDialog();
        }

        private void mnu_file_exit_Click(object sender, EventArgs e)
        {
            Exit();
        }
    }
}
