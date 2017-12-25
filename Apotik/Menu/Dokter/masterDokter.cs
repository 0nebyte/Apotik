﻿using System;
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
    public partial class masterDokter : MetroFramework.Forms.MetroForm
    {
        private Controller controller;

        public masterDokter( Controller controller)
        {
            this.controller = controller;
            InitializeComponent();


        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            var tambah = new tambah();
            tambah.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var edit = new edit();
            edit.ShowDialog();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            var hapus = new hapus();
            hapus.ShowDialog();
        }
    }
}
