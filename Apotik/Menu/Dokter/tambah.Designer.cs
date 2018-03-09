namespace Apotik.Menu.Dokter
{
    partial class Tambah
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
            this.btn_cancel = new MetroFramework.Controls.MetroTile();
            this.btn_simpan = new MetroFramework.Controls.MetroTile();
            this.txt_ket = new MetroFramework.Controls.MetroTextBox();
            this.txt_telp = new MetroFramework.Controls.MetroTextBox();
            this.txt_nama = new MetroFramework.Controls.MetroTextBox();
            this.txt_kode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.txt_alamat = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.CustomBackground = true;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(156, 332);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 35);
            this.btn_cancel.TabIndex = 48;
            this.btn_cancel.Text = "BATAL";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(237, 332);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(75, 35);
            this.btn_simpan.TabIndex = 47;
            this.btn_simpan.Text = "SIMPAN";
            this.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_simpan.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // txt_ket
            // 
            this.txt_ket.Location = new System.Drawing.Point(104, 290);
            this.txt_ket.Name = "txt_ket";
            this.txt_ket.Size = new System.Drawing.Size(208, 23);
            this.txt_ket.TabIndex = 46;
            // 
            // txt_telp
            // 
            this.txt_telp.Location = new System.Drawing.Point(104, 251);
            this.txt_telp.Name = "txt_telp";
            this.txt_telp.Size = new System.Drawing.Size(208, 23);
            this.txt_telp.TabIndex = 44;
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(104, 112);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(208, 23);
            this.txt_nama.TabIndex = 42;
            // 
            // txt_kode
            // 
            this.txt_kode.Location = new System.Drawing.Point(104, 74);
            this.txt_kode.Name = "txt_kode";
            this.txt_kode.Size = new System.Drawing.Size(208, 23);
            this.txt_kode.TabIndex = 41;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(11, 293);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(75, 19);
            this.metroLabel6.TabIndex = 49;
            this.metroLabel6.Text = "Keterangan";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(12, 254);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(32, 19);
            this.metroLabel4.TabIndex = 51;
            this.metroLabel4.Text = "Telp";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(12, 153);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 52;
            this.metroLabel3.Text = "Alamat";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 115);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 53;
            this.metroLabel2.Text = "Nama";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 19);
            this.metroLabel1.TabIndex = 54;
            this.metroLabel1.Text = "Kode";
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(-2, 7);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(340, 51);
            this.metroTile1.TabIndex = 55;
            this.metroTile1.Text = "TAMBAH DOKTER";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // txt_alamat
            // 
            this.txt_alamat.Location = new System.Drawing.Point(104, 149);
            this.txt_alamat.Multiline = true;
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.Size = new System.Drawing.Size(208, 86);
            this.txt_alamat.TabIndex = 44;
            // 
            // tambah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 385);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.txt_ket);
            this.Controls.Add(this.txt_alamat);
            this.Controls.Add(this.txt_telp);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.txt_kode);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTile1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(337, 385);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(337, 385);
            this.Name = "tambah";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "tambah";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile btn_cancel;
        private MetroFramework.Controls.MetroTile btn_simpan;
        private MetroFramework.Controls.MetroTextBox txt_ket;
        private MetroFramework.Controls.MetroTextBox txt_telp;
        private MetroFramework.Controls.MetroTextBox txt_nama;
        private MetroFramework.Controls.MetroTextBox txt_kode;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTextBox txt_alamat;
    }
}