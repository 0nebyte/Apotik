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
            daftarObat = Model.Database.Instance.Query<Model.Obat>().Execute();
            dgv_obat.DataSource = daftarObat;

            // Focus search box
            ActiveControl = txt_cari;
        }

        private bool SendObat(int index)
        {
            DataGridViewRow row = dgv_obat.Rows[index];

            var id = row.Cells[0].Value.ToString();
            var db = Model.Database.Instance;
            var obat = db.Query<Model.Obat>().Where(db.Column("Id") == id).Execute().First();
            return controller.AddObat(obat);
        }

        private void dgv_obat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (SendObat(e.RowIndex))
                {
                    Close();
                }
            }
        }

        private void txt_cari_TextChanged(object sender, EventArgs e)
        {
            var db = Model.Database.Instance;

            if (txt_cari.Text.Trim() == "")
            {
                daftarObat = db.Query<Model.Obat>().Execute();
                dgv_obat.DataSource = daftarObat;
                return;
            }

            var searchQuery = "%" + txt_cari.Text + "%";
            daftarObat = db.Query<Model.Obat>().Where(db.Like(db.Column("Nama"), searchQuery)).Execute();
            dgv_obat.DataSource = daftarObat;
        }

        private void DataObat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgv_obat.Rows.Count == 0)
                {
                    return;
                }

                if (dgv_obat.SelectedRows.Count == 0)
                {
                    return;
                }

                if (SendObat(dgv_obat.SelectedRows[0].Index))
                {
                    Close();
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (dgv_obat.Rows.Count == 0)
                {
                    return;
                }

                if (dgv_obat.SelectedRows.Count == 0)
                {
                    dgv_obat.Rows[0].Selected = true;
                    return;
                }

                var selection = dgv_obat.SelectedRows[0].Index - 1;
                if (selection < 0)
                {
                    selection = 0;
                }
                dgv_obat.ClearSelection();
                dgv_obat.Rows[selection].Selected = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (dgv_obat.Rows.Count == 0)
                {
                    return;
                }

                if (dgv_obat.SelectedRows.Count == 0)
                {
                    dgv_obat.Rows[0].Selected = true;
                    return;
                }

                var selection = dgv_obat.SelectedRows[0].Index + 1;
                if (selection > dgv_obat.Rows.Count - 1)
                {
                    selection = dgv_obat.Rows.Count - 1;
                }
                dgv_obat.ClearSelection();
                dgv_obat.Rows[selection].Selected = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
