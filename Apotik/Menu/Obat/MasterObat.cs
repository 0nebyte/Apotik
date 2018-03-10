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
    public partial class MasterObat : MetroFramework.Forms.MetroForm
    {
        private Controller controller;

        public MasterObat(Controller controller)
        {
            this.controller = controller;

            InitializeComponent();

            dataGridView1.DataBindings.Add("DataSource", controller, "DaftarObat");

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
            var hapus = new Hapus(controller);
            hapus.ShowDialog();
        }
    }
}
