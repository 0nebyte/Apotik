using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotik.Menu.User
{
    public partial class MasterUser : MetroFramework.Forms.MetroForm
    {
        private Controller controller;

        public MasterUser(Controller controller)
        {
            this.controller = controller;

            InitializeComponent();

            dataGridViewUser.DataBindings.Add("DataSource", controller, "DaftarUser");

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
    }
}
