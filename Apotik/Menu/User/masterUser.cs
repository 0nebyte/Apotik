﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotik.Menu.User
{
    public partial class masterUser : MetroFramework.Forms.MetroForm
    {
        public masterUser()
        {
            InitializeComponent();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            var tambah = new tambah();
            tambah.ShowDialog();
        }
    }
}
