using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotik.Menu.Dokter
{
    public partial class edit : MetroFramework.Forms.MetroForm
    {
        private Controller controller;
        private Model.Dokter dokter;

        public edit(Controller controller)
        {
            this.controller = controller;

            InitializeComponent();
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            var db = Model.Database.Instance;
            var query = txt_cari.Text;
            var category = cb_jenis.SelectedItem.ToString();
            IEnumerable<Model.Dokter> result;

            if (category == "Kode")
            {
                //kalau ini pakai Like bisa ko ndre? jadi kode like query
                result = db.Query2<Model.Dokter>().Where(db.Column("Kode") == query).Execute();
            }
                else if (category == "Nama")
                {
                    //kalau ini pakai Like bisa ko ndre? jadi kode like query
                    result = db.Query2<Model.Dokter>().Where(db.Column("Nama") == query).Execute();
                }
                    else
                    {
                        MessageBox.Show("Tidak dapat menemukan Dokter.");
                        return;
                    }

            dokter = result.FirstOrDefault();

            if (dokter != null)
            {
                txt_kode.DataBindings.Clear();
                txt_kode.DataBindings.Clear();
                txt_nama.DataBindings.Clear();
                txt_alamat.DataBindings.Clear();
                txt_telp.DataBindings.Clear();
                txt_ket.DataBindings.Clear();

                txt_kode.DataBindings.Add("Text", dokter, "Kode");
                txt_nama.DataBindings.Add("Text", dokter, "Nama");
                txt_alamat.DataBindings.Add("Text", dokter, "Alamat");
                txt_telp.DataBindings.Add("Text", dokter, "Telp");
                txt_ket.DataBindings.Add("Text", dokter, "Keterangan");
            }
            else
            {
                txt_kode.DataBindings.Clear();
                txt_kode.DataBindings.Clear();
                txt_nama.DataBindings.Clear();
                txt_alamat.DataBindings.Clear();
                txt_telp.DataBindings.Clear();
                txt_ket.DataBindings.Clear();
            }
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            var db = Model.Database.Instance;
            db.Update(dokter);

            controller.Dokters = Model.Database.Instance.Query<Model.Dokter>();

            Close();
        }

        private void cb_jenis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
