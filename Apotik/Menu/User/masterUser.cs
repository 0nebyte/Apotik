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
        private Controller controller;

        public masterUser(Controller controller)
        {
            this.controller = controller;

            InitializeComponent();

            dataGridViewUser.DataBindings.Add("DataSource", controller, "Users");

            controller.Users = Model.Database.Instance.Query<Model.User>();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            var tambah = new tambah(controller);
            tambah.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var edit = new edit(controller);
            edit.ShowDialog();
        }
    }
}
