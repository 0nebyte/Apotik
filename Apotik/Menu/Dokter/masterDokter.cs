using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotik.Menu.Dokter
{
    public partial class MasterDokter : MetroFramework.Forms.MetroForm
    {
        private Controller controller;

        public MasterDokter( Controller controller)
        {
            this.controller = controller;

            InitializeComponent();

            dataGridViewDokter.DataBindings.Add("DataSource", controller, "DaftarDokter");

            controller.RefreshData();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            var tambah = new Tambah(controller);
            tambah.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var edit = new Edit(controller);
            edit.ShowDialog();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            var hapus = new Hapus();
            hapus.ShowDialog();
        }
    }
}
