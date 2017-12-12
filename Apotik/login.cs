using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotik
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "admin" && txt_password.Text == "admin")
            {
                var form = new Home();
                form.Show();
                this.Hide();
        

            }
            else
            {
                MessageBox.Show("Username atau password salah!", "warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
