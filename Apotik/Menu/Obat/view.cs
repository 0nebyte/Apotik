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
    public partial class view : Form
    {
        private Controller controller;

        public view(Controller controller)
        {
            this.controller = controller;

            InitializeComponent();

            grid_obat.DataBindings.Add("DataSource", controller, "Obats");

            controller.Obats = Model.Database.Instance.Query<Model.Obat>();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var tambah = new tambah(controller);
            tambah.ShowDialog();
        }
    }
}
