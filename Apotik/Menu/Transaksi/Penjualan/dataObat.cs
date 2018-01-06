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
    public partial class dataObat : MetroFramework.Forms.MetroForm
    {
        private Controller controller;
        public dataObat(Controller controller)
        {
            this.controller = controller;

            InitializeComponent();

            dgv_obat.DataBindings.Add("DataSource", controller, "Obats");

            controller.Obats = Model.Database.Instance.Query<Model.Obat>();
        }

        private void dgv_obat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_obat.Rows[e.RowIndex];
                Jual jl = new Jual(controller);

                //jl.dgv_penjualan.SelectedRows
                jl.txt_dokter.Text = row.Cells[1].Value.ToString();
                // jl.txt_subtotal.Text = row.Cells[1].Value.ToString();
                MessageBox.Show(row.Cells[2].Value.ToString(), "test", MessageBoxButtons.OK);

                var dgvtest = new Menu.Transaksi.Penjualan.Jual(controller);
               // dgvtest.dgv_penjualan.RowsAdded();
            }
            

        }
    }
}
