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
    public partial class DataObat : MetroFramework.Forms.MetroForm
    {
        private Controller controller;
        private IEnumerable<Model.Obat> daftarObat;

        public DataObat(Controller controller)
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
                if (obat.Stok == 0)
                {
                    MessageBox.Show(string.Format("Barang '{0}' telah habis.", obat.Nama), "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                var detail = controller.DetailJual.FirstOrDefault(p => p.Detail.Obat.Id == obat.Id);
                if (detail == null)
                {
                    var d = Model.BaseModel.New<Model.DetailJual>();
                    d.Penjualan = controller.Penjualan;
                    d.Obat = obat;

                    detail = new DetailDataSource(d);
                    controller.DetailJual.Add(detail);
                }

                if (obat.Stok > detail.Quantity)
                {
                    detail.Quantity += 1;
                }
                else
                {
                    MessageBox.Show(string.Format("Penjualan barang '{0}' tidak dapat melibihi stok.", obat.Nama),
                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // Update Penjualan
                controller.Penjualan.SubTotal =
                    controller.DetailJual.Aggregate(0, (sum, d) => sum + d.SubTotal);
                var diskon = (int)(controller.Penjualan.SubTotal * controller.Penjualan.Diskon / 100.0f);
                var ppn = (int)(controller.Penjualan.SubTotal * controller.Penjualan.PPN / 100.0f);
                controller.Penjualan.GrandTotal = controller.Penjualan.SubTotal - diskon + ppn;

                controller.DetailJual = controller.DetailJual.ToList();
            }

            Close();
        }
    }
}
