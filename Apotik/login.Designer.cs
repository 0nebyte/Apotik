namespace Apotik
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.metroButtonLogin = new MetroFramework.Controls.MetroButton();
            this.metroButtonClose = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txt_username.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_username.Location = new System.Drawing.Point(70, 175);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 8, 4, 5);
            this.txt_username.MaxLength = 20;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(338, 35);
            this.txt_username.TabIndex = 1;
            this.txt_username.Click += new System.EventHandler(this.txt_username_Click);
            this.txt_username.MouseEnter += new System.EventHandler(this.txt_username_MouseEnter);
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txt_password.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_password.Location = new System.Drawing.Point(70, 262);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(338, 35);
            this.txt_password.TabIndex = 2;
            this.txt_password.Click += new System.EventHandler(this.txt_password_Click);
            // 
            // metroButtonLogin
            // 
            this.metroButtonLogin.Location = new System.Drawing.Point(213, 388);
            this.metroButtonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroButtonLogin.Name = "metroButtonLogin";
            this.metroButtonLogin.Size = new System.Drawing.Size(228, 60);
            this.metroButtonLogin.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButtonLogin.TabIndex = 3;
            this.metroButtonLogin.Text = "Login";
            this.metroButtonLogin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButtonLogin.Click += new System.EventHandler(this.metroButtonLogin_Click);
            // 
            // metroButtonClose
            // 
            this.metroButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroButtonClose.Location = new System.Drawing.Point(-9, 388);
            this.metroButtonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroButtonClose.Name = "metroButtonClose";
            this.metroButtonClose.Size = new System.Drawing.Size(225, 60);
            this.metroButtonClose.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButtonClose.TabIndex = 4;
            this.metroButtonClose.Text = "Cancel";
            this.metroButtonClose.Click += new System.EventHandler(this.metroButtonClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(22, 262);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 174);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(81, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 35);
            this.label1.TabIndex = 17;
            this.label1.Text = "APLIKASI APOTIK";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            // 
            // Login
            // 
            this.AcceptButton = this.metroButtonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.metroButtonClose;
            this.ClientSize = new System.Drawing.Size(434, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroButtonClose);
            this.Controls.Add(this.metroButtonLogin);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_password);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private MetroFramework.Controls.MetroButton metroButtonLogin;
        private MetroFramework.Controls.MetroButton metroButtonClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}