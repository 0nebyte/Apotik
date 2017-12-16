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
        public view()
        {
            InitializeComponent();
            BindGrid();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var tambah = new tambah();
            tambah.ShowDialog();
        }

        private void BindGrid()
        {
            grid_obat.DataSource = Model.Database.Instance.Query<Model.Obat>();
        }
    }
}
