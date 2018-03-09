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
    public partial class Form1 : Form
    {
        private Controller controller;

        public Form1(Controller controller)
        {
            this.controller = controller;

            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var login = new login(controller);
            login.Close();

            this.Close();
             
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("oke");
        }

        private void Tutup_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Obat_Click(object sender, EventArgs e)
        {
           
        }

        private void tambahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obat = new Menu.Obat.Tambah(new Apotik.Menu.Obat.Controller());
            obat.ShowDialog();
        }
    }
}
