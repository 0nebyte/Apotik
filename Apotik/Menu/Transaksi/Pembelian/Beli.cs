using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotik.Menu.Transaksi.Pembelian
{
    public partial class Beli : MetroFramework.Forms.MetroForm
    {
        private Controller controller;
        public Beli(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
            this.KeyPreview = true;

        }
    }
}
