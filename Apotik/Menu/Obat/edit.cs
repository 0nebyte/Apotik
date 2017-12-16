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
    public partial class edit : Form
    {
        public edit()
        {
            InitializeComponent();
        }

        private void edit_Load(object sender, EventArgs e)
        {

        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            gb_data.Visible = true;
        }

        private void cmb_jenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cari.ReadOnly = false;
        }
    }
}
