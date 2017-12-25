namespace Apotik.Menu.Distributor
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.btn_cancel = new MetroFramework.Controls.MetroTile();
            this.btn_simpan = new MetroFramework.Controls.MetroTile();
            this.btn_cari = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txt_cari = new MetroFramework.Controls.MetroTextBox();
            this.cb_jenis = new MetroFramework.Controls.MetroComboBox();
            this.txt_alamat = new MetroFramework.Controls.MetroTextBox();
            this.txt_email = new MetroFramework.Controls.MetroTextBox();
            this.txt_norek = new MetroFramework.Controls.MetroTextBox();
            this.txt_telp = new MetroFramework.Controls.MetroTextBox();
            this.txt_kota = new MetroFramework.Controls.MetroTextBox();
            this.txt_nama = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txt_kode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.BackColor = System.Drawing.Color.LimeGreen;
            this.metroTile1.CustomBackground = true;
            this.metroTile1.Location = new System.Drawing.Point(1, 7);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(471, 51);
            this.metroTile1.TabIndex = 74;
            this.metroTile1.Text = "UBAH DISTRIBUTOR";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.CustomBackground = true;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(279, 483);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 35);
            this.btn_cancel.TabIndex = 66;
            this.btn_cancel.Text = "BATAL";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // btn_simpan
            // 
            this.btn_simpan.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_simpan.CustomBackground = true;
            this.btn_simpan.Location = new System.Drawing.Point(361, 483);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(75, 35);
            this.btn_simpan.TabIndex = 65;
            this.btn_simpan.Text = "SIMPAN";
            this.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_simpan.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // btn_cari
            // 
            this.btn_cari.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_cari.CustomBackground = true;
            this.btn_cari.Location = new System.Drawing.Point(340, 30);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(75, 29);
            this.btn_cari.TabIndex = 3;
            this.btn_cari.Text = "Cari";
            this.btn_cari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.txt_cari);
            this.metroPanel1.Controls.Add(this.btn_cari);
            this.metroPanel1.Controls.Add(this.cb_jenis);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(14, 64);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(422, 87);
            this.metroPanel1.TabIndex = 73;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txt_cari
            // 
            this.txt_cari.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_cari.Location = new System.Drawing.Point(133, 30);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(207, 29);
            this.txt_cari.TabIndex = 2;
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
            // txt_alamat
            // 
            this.txt_alamat.Location = new System.Drawing.Point(106, 224);
            this.txt_alamat.Multiline = true;
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.Size = new System.Drawing.Size(330, 86);
            this.txt_alamat.TabIndex = 77;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(106, 440);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(330, 23);
            this.txt_email.TabIndex = 81;
            // 
            // txt_norek
            // 
            this.txt_norek.Location = new System.Drawing.Point(106, 402);
            this.txt_norek.Name = "txt_norek";
            this.txt_norek.Size = new System.Drawing.Size(330, 23);
            this.txt_norek.TabIndex = 80;
            // 
            // txt_telp
            // 
            this.txt_telp.Location = new System.Drawing.Point(106, 362);
            this.txt_telp.Name = "txt_telp";
            this.txt_telp.Size = new System.Drawing.Size(330, 23);
            this.txt_telp.TabIndex = 79;
            // 
            // txt_kota
            // 
            this.txt_kota.Location = new System.Drawing.Point(106, 324);
            this.txt_kota.Name = "txt_kota";
            this.txt_kota.Size = new System.Drawing.Size(330, 23);
            this.txt_kota.TabIndex = 78;
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(106, 188);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(330, 23);
            this.txt_nama.TabIndex = 76;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(13, 443);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(41, 19);
            this.metroLabel7.TabIndex = 82;
            this.metroLabel7.Text = "Email";
            // 
            // txt_kode
            // 
            this.txt_kode.Location = new System.Drawing.Point(106, 150);
            this.txt_kode.Name = "txt_kode";
            this.txt_kode.Size = new System.Drawing.Size(330, 23);
            this.txt_kode.TabIndex = 75;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(13, 405);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(84, 19);
            this.metroLabel6.TabIndex = 83;
            this.metroLabel6.Text = "No Rekening";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(13, 365);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 19);
            this.metroLabel5.TabIndex = 84;
            this.metroLabel5.Text = "No Telepon";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(14, 327);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(35, 19);
            this.metroLabel4.TabIndex = 85;
            this.metroLabel4.Text = "Kota";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(14, 229);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 86;
            this.metroLabel3.Text = "Alamat";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(14, 191);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 87;
            this.metroLabel2.Text = "Nama";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 154);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 19);
            this.metroLabel1.TabIndex = 88;
            this.metroLabel1.Text = "Kode";
            // 
            // edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 541);
            this.Controls.Add(this.txt_alamat);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_norek);
            this.Controls.Add(this.txt_telp);
            this.Controls.Add(this.txt_kota);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txt_kode);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.metroPanel1);
            this.Name = "edit";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "edit";
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile btn_cancel;
        private MetroFramework.Controls.MetroTile btn_simpan;
        private MetroFramework.Controls.MetroTile btn_cari;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txt_cari;
        private MetroFramework.Controls.MetroComboBox cb_jenis;
        private MetroFramework.Controls.MetroTextBox txt_alamat;
        private MetroFramework.Controls.MetroTextBox txt_email;
        private MetroFramework.Controls.MetroTextBox txt_norek;
        private MetroFramework.Controls.MetroTextBox txt_telp;
        private MetroFramework.Controls.MetroTextBox txt_kota;
        private MetroFramework.Controls.MetroTextBox txt_nama;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txt_kode;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}