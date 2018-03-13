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
    public partial class DataDokter : MetroFramework.Forms.MetroForm
    {
        private Controller controller;
        private IEnumerable<Model.Dokter> daftarDokter;

        public DataDokter(Controller controller)
        {
            this.controller = controller;

            InitializeComponent();

            // Init data
            daftarDokter = Model.Database.Instance.Query<Model.Dokter>().Execute();
            dgv_dokter.DataSource = daftarDokter;
        }

        private void dataDokter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void dgv_dokter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_dokter.Rows[e.RowIndex];
                var id = row.Cells[0].Value.ToString();
                var db = Model.Database.Instance;
                var dokter = db.Query<Model.Dokter>().Where(db.Column("Id") == id).Execute().First();
                controller.Penjualan.Dokter = dokter;
            }
            Close();
        }
    }
}
