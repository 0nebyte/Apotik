namespace Apotik.Menu.User
{
    partial class edit
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
            this.txt_password = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_username = new MetroFramework.Controls.MetroTextBox();
            this.cmb_jk = new MetroFramework.Controls.MetroComboBox();
            this.cmb_role = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btn_cancel = new MetroFramework.Controls.MetroTile();
            this.txt_kode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_nama = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_alamat = new MetroFramework.Controls.MetroTextBox();
            this.txt_telp = new MetroFramework.Controls.MetroTextBox();
            this.btn_simpan = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txt_cari = new MetroFramework.Controls.MetroTextBox();
            this.btn_cari = new MetroFramework.Controls.MetroTile();
            this.cb_jenis = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(102, 48);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(208, 23);
            this.txt_password.TabIndex = 56;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(10, 52);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(63, 19);
            this.metroLabel9.TabIndex = 67;
            this.metroLabel9.Text = "Password";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(10, 23);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(68, 19);
            this.metroLabel8.TabIndex = 67;
            this.metroLabel8.Text = "Username";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_password);
            this.groupBox2.Controls.Add(this.metroLabel9);
            this.groupBox2.Controls.Add(this.txt_username);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Location = new System.Drawing.Point(355, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 100);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Login";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(102, 19);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(208, 23);
            this.txt_username.TabIndex = 56;
            // 
            // cmb_jk
            // 
            this.cmb_jk.FormattingEnabled = true;
            this.cmb_jk.ItemHeight = 23;
            this.cmb_jk.Items.AddRange(new object[] {
            "Pria",
            "Wanita"});
            this.cmb_jk.Location = new System.Drawing.Point(103, 91);
            this.cmb_jk.Name = "cmb_jk";
            this.cmb_jk.Size = new System.Drawing.Size(208, 29);
            this.cmb_jk.TabIndex = 69;
            // 
            // cmb_role
            // 
            this.cmb_role.FormattingEnabled = true;
            this.cmb_role.ItemHeight = 23;
            this.cmb_role.Items.AddRange(new object[] {
            "Karyawan"});
            this.cmb_role.Location = new System.Drawing.Point(103, 270);
            this.cmb_role.Name = "cmb_role";
            this.cmb_role.Size = new System.Drawing.Size(208, 29);
            this.cmb_role.TabIndex = 69;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(11, 98);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(86, 19);
            this.metroLabel7.TabIndex = 66;
            this.metroLabel7.Text = "Jenis Kelamin";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(11, 273);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(54, 19);
            this.metroLabel5.TabIndex = 63;
            this.metroLabel5.Text = "Jabatan";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.CustomBackground = true;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(532, 274);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 35);
            this.btn_cancel.TabIndex = 73;
            this.btn_cancel.Text = "BATAL";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_kode
            // 
            this.txt_kode.Location = new System.Drawing.Point(103, 19);
            this.txt_kode.Name = "txt_kode";
            this.txt_kode.Size = new System.Drawing.Size(208, 23);
            this.txt_kode.TabIndex = 56;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(11, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 66;
            this.metroLabel2.Text = "Nama";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(11, 136);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 65;
            this.metroLabel3.Text = "Alamat";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(11, 237);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(32, 19);
            this.metroLabel4.TabIndex = 64;
            this.metroLabel4.Text = "Telp";
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(103, 57);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(208, 23);
            this.txt_nama.TabIndex = 57;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_jk);
            this.groupBox1.Controls.Add(this.txt_kode);
            this.groupBox1.Controls.Add(this.cmb_role);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.txt_alamat);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.txt_telp);
            this.groupBox1.Controls.Add(this.txt_nama);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Location = new System.Drawing.Point(11, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 312);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Diri";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(11, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 19);
            this.metroLabel1.TabIndex = 67;
            this.metroLabel1.Text = "Kode";
            // 
            // txt_alamat
            // 
            this.txt_alamat.Location = new System.Drawing.Point(103, 132);
            this.txt_alamat.Multiline = true;
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.Size = new System.Drawing.Size(208, 86);
            this.txt_alamat.TabIndex = 58;
            // 
            // txt_telp
            // 
            this.txt_telp.Location = new System.Drawing.Point(103, 234);
            this.txt_telp.Name = "txt_telp";
            this.txt_telp.Size = new System.Drawing.Size(208, 23);
            this.txt_telp.TabIndex = 59;
            // 
            // btn_simpan
            // 
            this.btn_simpan.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_simpan.CustomBackground = true;
            this.btn_simpan.Location = new System.Drawing.Point(613, 274);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(75, 35);
            this.btn_simpan.TabIndex = 72;
            this.btn_simpan.Text = "SIMPAN";
            this.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_simpan.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.BackColor = System.Drawing.Color.LimeGreen;
            this.metroTile1.CustomBackground = true;
            this.metroTile1.Location = new System.Drawing.Point(-1, 8);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(724, 51);
            this.metroTile1.TabIndex = 74;
            this.metroTile1.Text = "UBAH DATA KARYAWAN";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.txt_cari);
            this.metroPanel1.Controls.Add(this.btn_cari);
            this.metroPanel1.Controls.Add(this.cb_jenis);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(11, 71);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(679, 87);
            this.metroPanel1.TabIndex = 77;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txt_cari
            // 
            this.txt_cari.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_cari.Location = new System.Drawing.Point(133, 30);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(463, 29);
            this.txt_cari.TabIndex = 2;
            // 
            // btn_cari
            // 
            this.btn_cari.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_cari.CustomBackground = true;
            this.btn_cari.Location = new System.Drawing.Point(590, 30);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(75, 29);
            this.btn_cari.TabIndex = 3;
            this.btn_cari.Text = "Cari";
            this.btn_cari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // cb_jenis
            // 
            this.cb_jenis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_jenis.FormattingEnabled = true;
            this.cb_jenis.ItemHeight = 23;
            this.cb_jenis.Items.AddRange(new object[] {
            "Kode",
            "Nama"});
            this.cb_jenis.Location = new System.Drawing.Point(6, 30);
            this.cb_jenis.Name = "cb_jenis";
            this.cb_jenis.Size = new System.Drawing.Size(121, 29);
            this.cb_jenis.TabIndex = 1;
            // 
            // edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 517);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.metroTile1);
            this.Name = "edit";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "edit";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_password;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txt_username;
        private MetroFramework.Controls.MetroComboBox cmb_jk;
        private MetroFramework.Controls.MetroComboBox cmb_role;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTile btn_cancel;
        private MetroFramework.Controls.MetroTextBox txt_kode;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_nama;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_alamat;
        private MetroFramework.Controls.MetroTextBox txt_telp;
        private MetroFramework.Controls.MetroTile btn_simpan;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txt_cari;
        private MetroFramework.Controls.MetroTile btn_cari;
        private MetroFramework.Controls.MetroComboBox cb_jenis;
    }
}