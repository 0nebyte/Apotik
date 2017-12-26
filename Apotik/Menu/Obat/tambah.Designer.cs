namespace Apotik.Menu.Obat
{
    partial class tambah
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tambah));
            this.cmb_satuan = new MetroFramework.Controls.MetroComboBox();
            this.btn_cancel = new MetroFramework.Controls.MetroTile();
            this.btn_simpan = new MetroFramework.Controls.MetroTile();
            this.txt_ket = new MetroFramework.Controls.MetroTextBox();
            this.txt_harga = new MetroFramework.Controls.MetroTextBox();
            this.txt_stok = new MetroFramework.Controls.MetroTextBox();
            this.txt_nama = new MetroFramework.Controls.MetroTextBox();
            this.txt_kode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // cmb_satuan
            // 
            this.cmb_satuan.FormattingEnabled = true;
            this.cmb_satuan.ItemHeight = 23;
            this.cmb_satuan.Items.AddRange(new object[] {
            "Botol",
            "Strip",
            "Kapsul"});
            this.cmb_satuan.Location = new System.Drawing.Point(105, 144);
            this.cmb_satuan.Name = "cmb_satuan";
            this.cmb_satuan.Size = new System.Drawing.Size(208, 29);
            this.cmb_satuan.TabIndex = 3;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.CustomBackground = true;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(157, 321);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 35);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "BATAL";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(238, 321);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(75, 35);
            this.btn_simpan.TabIndex = 7;
            this.btn_simpan.Text = "SIMPAN";
            this.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_simpan.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // txt_ket
            // 
            this.txt_ket.Location = new System.Drawing.Point(105, 265);
            this.txt_ket.Name = "txt_ket";
            this.txt_ket.Size = new System.Drawing.Size(208, 23);
            this.txt_ket.TabIndex = 6;
            // 
            // txt_harga
            // 
            this.txt_harga.Location = new System.Drawing.Point(105, 222);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(208, 23);
            this.txt_harga.TabIndex = 5;
            // 
            // txt_stok
            // 
            this.txt_stok.Location = new System.Drawing.Point(105, 183);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(208, 23);
            this.txt_stok.TabIndex = 4;
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(105, 110);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(208, 23);
            this.txt_nama.TabIndex = 2;
            // 
            // txt_kode
            // 
            this.txt_kode.Location = new System.Drawing.Point(105, 72);
            this.txt_kode.Name = "txt_kode";
            this.txt_kode.Size = new System.Drawing.Size(208, 23);
            this.txt_kode.TabIndex = 1;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(12, 268);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(75, 19);
            this.metroLabel6.TabIndex = 34;
            this.metroLabel6.Text = "Keterangan";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(12, 225);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(45, 19);
            this.metroLabel5.TabIndex = 35;
            this.metroLabel5.Text = "Harga";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(13, 186);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(34, 19);
            this.metroLabel4.TabIndex = 36;
            this.metroLabel4.Text = "Stok";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(13, 151);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 37;
            this.metroLabel3.Text = "Satuan";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 113);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 38;
            this.metroLabel2.Text = "Nama";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 19);
            this.metroLabel1.TabIndex = 39;
            this.metroLabel1.Text = "Kode Obat";
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(-1, 6);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(340, 51);
            this.metroTile1.TabIndex = 40;
            this.metroTile1.Text = "TAMBAH OBAT";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // tambah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 378);
            this.Controls.Add(this.cmb_satuan);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.txt_ket);
            this.Controls.Add(this.txt_harga);
            this.Controls.Add(this.txt_stok);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.txt_kode);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTile1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(337, 378);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(337, 378);
            this.Name = "tambah";
            this.Text = "Tambah - Obat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmb_satuan;
        private MetroFramework.Controls.MetroTile btn_cancel;
        private MetroFramework.Controls.MetroTile btn_simpan;
        private MetroFramework.Controls.MetroTextBox txt_ket;
        private MetroFramework.Controls.MetroTextBox txt_harga;
        private MetroFramework.Controls.MetroTextBox txt_stok;
        private MetroFramework.Controls.MetroTextBox txt_nama;
        private MetroFramework.Controls.MetroTextBox txt_kode;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}