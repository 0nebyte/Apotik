﻿using System;
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
    public partial class Jual : MetroFramework.Forms.MetroForm
    {
        private Controller controller;
        public Jual(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
            this.KeyPreview = true;
           
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Keluar dari form ini?","Exit", 
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                this.Close();
            }  
        }

        private void Jual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                var dokter = new dataDokter(controller);
                dokter.Show();
            }
        }
    }
}
