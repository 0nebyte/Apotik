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
        private Controller controller;
        private int childFormNumber = 0;

        public Home(Controller controller)
        {
            this.controller = controller;

            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Tutup_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Keluar dari aplikasi?", "Keluar", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //nothing
            }
        }

        private void tambahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obat = new Menu.Obat.tambah(controller);
            obat.MdiParent = this;
            obat.Show();
        }


        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void obatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var masterObat = new Menu.Obat.MasterObat(controller);
            masterObat.MdiParent = this;
            masterObat.Show();
        }

        private void dokterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var masterdokter = new Menu.Dokter.masterDokter(controller);
            masterdokter.MdiParent = this;
            masterdokter.Show();
        }

        private void distributorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var masterDistributor = new Menu.Distributor.masterDistributor(controller);
            masterDistributor.MdiParent = this;
            masterDistributor.Show();
        }

        private void penggunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var masterUser = new Menu.User.masterUser(controller);
            masterUser.MdiParent = this;
            masterUser.Show();

        }
    }
}
