using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotik.Menu.Transaksi.Penjualan
{
    public partial class dataDokter : MetroFramework.Forms.MetroForm
    {
        private Controller controller;
        public dataDokter(Controller controller)
        {
            this.controller = controller;

            InitializeComponent();

            dgv_dokter.DataBindings.Add("DataSource", controller, "Dokters");

            controller.Dokters = Model.Database.Instance.Query<Model.Dokter>();
        }

        private void dataDokter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgv_dokter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_dokter.Rows[e.RowIndex];
                Jual jl = new Jual(controller);

                
                jl.txt_dokter.Text = row.Cells[1].Value.ToString();
               // jl.txt_subtotal.Text = row.Cells[1].Value.ToString();
                MessageBox.Show(row.Cells[2].Value.ToString(), "test", MessageBoxButtons.OK);
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
