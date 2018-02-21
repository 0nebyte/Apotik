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

                var id = row.Cells[0].Value.ToString();
                var db = Model.Database.Instance;
                var obat = db.Query2<Model.Obat>().Where(db.Column("Id") == id).Execute().First();
                controller.ObatResep.Add(obat);
                controller.ObatResep = controller.ObatResep.ToList();
            }

            this.Close();
        }
    }
}
