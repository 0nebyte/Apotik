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

    

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
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

        private void hapusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obat = new Menu.Obat.hapus();
            obat.MdiParent = this;
            obat.Show();
        }

        private void Obat_Click(object sender, EventArgs e)
        {
            var obat = new Menu.Obat.view(controller);
            obat.MdiParent = this;
            obat.Show();
        }

        private void ubahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obat = new Menu.Obat.edit();
            obat.MdiParent = this;
            obat.Show();
        }

        private void tambahToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var tambahUser = new Menu.User.tambah();
            tambahUser.MdiParent = this;
            tambahUser.Show();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            var viewUser = new Menu.User.view();
            viewUser.MdiParent = this;
            viewUser.Show();
        }

        private void Dokter_Click(object sender, EventArgs e)
        {
            var viewDokter = new Menu.Dokter.view();
            viewDokter.MdiParent = this;
            viewDokter.Show();
        }

        private void Distributor_Click(object sender, EventArgs e)
        {
            var viewDsitributor = new Menu.Distributor.view();
            viewDsitributor.MdiParent = this;
            viewDsitributor.Show();
        }
    }
}
