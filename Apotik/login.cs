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
    // public partial class login : Form
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        private Controller controller;

        public Login(Controller controller)
        {
            this.controller = controller;

            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "admin" && txt_password.Text == "admin")
            {
                var form = new Home(controller);
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
         
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_username_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            txt_password.Text = "";
            txt_password.PasswordChar = '*';
        }

        private void txt_username_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void metroButtonLogin_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "admin" && txt_password.Text == "admin")
            {
                var form = new Home(controller);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void metroButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
