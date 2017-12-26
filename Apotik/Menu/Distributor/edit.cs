using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotik.Menu.Distributor
{
    public partial class edit : MetroFramework.Forms.MetroForm
    {

        private Controller controller;
        private Model.Distributor distributor;

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
            IEnumerable<Model.Distributor> result;

            if (category == "Kode")
            {
                //kalau ini pakai Like bisa ko ndre? jadi kode like query
                result = db.Query2<Model.Distributor>().Where(db.Column("Kode") == query).Execute();
            }
            else if (category == "Nama")
            {
                //kalau ini pakai Like bisa ko ndre? jadi kode like query
                result = db.Query2<Model.Distributor>().Where(db.Column("Nama") == query).Execute();
            }
            else
            {
                MessageBox.Show("Tidak dapat menemukan distributor.");
                return;
            }

            distributor = result.FirstOrDefault();

            if (distributor != null)
            {
                txt_kode.DataBindings.Clear();
                txt_kode.DataBindings.Clear();
                txt_nama.DataBindings.Clear();
                txt_alamat.DataBindings.Clear();
                txt_kota.DataBindings.Clear();
                txt_telp.DataBindings.Clear();
                cmb_bank.DataBindings.Clear();
                txt_norek.DataBindings.Clear();
                txt_email.DataBindings.Clear();

                txt_kode.DataBindings.Add("Text", distributor, "Kode");
                txt_nama.DataBindings.Add("Text", distributor, "Nama");
                txt_alamat.DataBindings.Add("Text", distributor, "Alamat");
                txt_kota.DataBindings.Add("Text", distributor, "Kota");
                txt_telp.DataBindings.Add("Text", distributor, "Telp");
                cmb_bank.DataBindings.Add("Text", distributor, "Bank");
                txt_norek.DataBindings.Add("Text", distributor, "Norek");
                txt_email.DataBindings.Add("Text", distributor, "Email");
            }
            else
            {
                txt_kode.DataBindings.Clear();
                txt_kode.DataBindings.Clear();
                txt_nama.DataBindings.Clear();
                txt_alamat.DataBindings.Clear();
                txt_kota.DataBindings.Clear();
                txt_telp.DataBindings.Clear();
                cmb_bank.DataBindings.Clear();
                txt_norek.DataBindings.Clear();
                txt_email.DataBindings.Clear();
            }
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            var db = Model.Database.Instance;
            db.Update(distributor);

            controller.Distributors = Model.Database.Instance.Query<Model.Distributor>();

            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
