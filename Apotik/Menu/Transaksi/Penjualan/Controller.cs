using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotik.Menu.Transaksi.Penjualan
{
    public class Controller : BaseController
    {
        private Model.Database db;
        private Model.Penjualan penjualan;
        private IList<DetailDataSource> detailJual = new List<DetailDataSource>();

        public Model.Penjualan Penjualan { get { return penjualan; } }

        public IList<DetailDataSource> DetailJual
        {
            get { return detailJual; }
            set
            {
                detailJual = value;
                InvokePropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("DetailJual"));
            }
        }

        public void AddObat(Model.Obat obat)
        {
            if (obat.Stok == 0)
            {
                MessageBox.Show(string.Format("Barang '{0}' telah habis.", obat.Nama), "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var detail = DetailJual.FirstOrDefault(p => p.Detail.Obat.Id == obat.Id);
            if (detail == null)
            {
                var d = db.New<Model.DetailJual>();
                d.Penjualan = Penjualan;
                d.Obat = obat;

                detail = new DetailDataSource(d);
                DetailJual.Add(detail);
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

            CalculatePrices();

            DetailJual = DetailJual.ToList();
        }

        public void DeleteObat(string kode)
        {
            detailJual.Remove(detailJual.FirstOrDefault(p => p.KodeObat == kode));
            CalculatePrices();
            DetailJual = detailJual.ToList();
        }

        public void CalculatePrices()
        {
            Penjualan.SubTotal = DetailJual.Aggregate(0, (sum, d) => sum + d.SubTotal);
            var diskon = (int)(Penjualan.SubTotal * Penjualan.Diskon / 100.0f);
            var ppn = (int)(Penjualan.SubTotal * Penjualan.PPN / 100.0f);
            Penjualan.GrandTotal = Penjualan.SubTotal - diskon + ppn;
        }

        public Controller()
        {
            db = Model.Database.Instance;
            penjualan = db.New<Model.Penjualan>();
        }
    }

    public class DetailDataSource
    {
        private Model.DetailJual detail;

        public DetailDataSource(Model.DetailJual detail)
        {
            this.detail = detail;
        }

        public Model.DetailJual Detail { get { return detail; } }
        public string KodeObat { get { return detail.Obat.Kode; } }
        public string NamaObat { get { return detail.Obat.Nama; } }
        public string Satuan { get { return detail.Obat.Satuan; } }
        public int Quantity { get { return detail.Quantity; } set { detail.Quantity = value; } }
        public int Harga { get { return detail.Obat.Harga; } }
        public int SubTotal { get { return detail.Obat.Harga * detail.Quantity; } }
    }
}
