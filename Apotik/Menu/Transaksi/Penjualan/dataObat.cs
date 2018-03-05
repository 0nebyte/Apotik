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
        private IEnumerable<Model.Obat> daftarObat;

        public dataObat(Controller controller)
        {
            InitializeComponent();

            this.controller = controller;

            // Init Data
            daftarObat = Model.Database.Instance.Query2<Model.Obat>().Execute();
            dgv_obat.DataSource = daftarObat;
        }

        private void dgv_obat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_obat.Rows[e.RowIndex];

                var id = row.Cells[0].Value.ToString();
                var db = Model.Database.Instance;
                var obat = db.Query2<Model.Obat>().Where(db.Column("Id") == id).Execute().First();
                controller.DaftarObat.Add(obat);
                controller.DaftarObat = controller.DaftarObat.ToList();
            }

            Close();
        }
    }
}
