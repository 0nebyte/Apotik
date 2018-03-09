namespace Apotik.Menu.Obat
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.txt_cari = new MetroFramework.Controls.MetroTextBox();
            this.btn_cari = new MetroFramework.Controls.MetroTile();
            this.cb_jenis = new MetroFramework.Controls.MetroComboBox();
            this.btn_cancel = new MetroFramework.Controls.MetroTile();
            this.btn_simpan = new MetroFramework.Controls.MetroTile();
            this.cmb_satuan = new MetroFramework.Controls.MetroComboBox();
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_cari
            // 
            this.txt_cari.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_cari.Location = new System.Drawing.Point(200, 46);
            this.txt_cari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(310, 45);
            this.txt_cari.TabIndex = 2;
            // 
            // btn_cari
            // 
            this.btn_cari.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_cari.CustomBackground = true;
            this.btn_cari.Location = new System.Drawing.Point(510, 46);
            this.btn_cari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(112, 45);
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
            this.cb_jenis.Location = new System.Drawing.Point(9, 46);
            this.cb_jenis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_jenis.Name = "cb_jenis";
            this.cb_jenis.Size = new System.Drawing.Size(180, 29);
            this.cb_jenis.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.CustomBackground = true;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(416, 669);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(112, 54);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "BATAL";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // btn_simpan
            // 
            this.btn_simpan.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_simpan.CustomBackground = true;
            this.btn_simpan.Location = new System.Drawing.Point(538, 669);
            this.btn_simpan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(112, 54);
            this.btn_simpan.TabIndex = 10;
            this.btn_simpan.Text = "SIMPAN";
            this.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_simpan.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // cmb_satuan
            // 
            this.cmb_satuan.FormattingEnabled = true;
            this.cmb_satuan.ItemHeight = 23;
            this.cmb_satuan.Items.AddRange(new object[] {
            "Botol",
            "Strip",
            "Kapsul"});
            this.cmb_satuan.Location = new System.Drawing.Point(158, 412);
            this.cmb_satuan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_satuan.Name = "cmb_satuan";
            this.cmb_satuan.Size = new System.Drawing.Size(492, 29);
            this.cmb_satuan.TabIndex = 6;
            // 
            // txt_ket
            // 
            this.txt_ket.Location = new System.Drawing.Point(158, 602);
            this.txt_ket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ket.Name = "txt_ket";
            this.txt_ket.Size = new System.Drawing.Size(494, 35);
            this.txt_ket.TabIndex = 9;
            // 
            // txt_harga
            // 
            this.txt_harga.Location = new System.Drawing.Point(158, 535);
            this.txt_harga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(494, 35);
            this.txt_harga.TabIndex = 8;
            // 
            // txt_stok
            // 
            this.txt_stok.Location = new System.Drawing.Point(158, 475);
            this.txt_stok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(494, 35);
            this.txt_stok.TabIndex = 7;
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(158, 363);
            this.txt_nama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(494, 35);
            this.txt_nama.TabIndex = 5;
            // 
            // txt_kode
            // 
            this.txt_kode.Location = new System.Drawing.Point(158, 305);
            this.txt_kode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_kode.Name = "txt_kode";
            this.txt_kode.Size = new System.Drawing.Size(494, 35);
            this.txt_kode.TabIndex = 4;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(18, 606);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(75, 19);
            this.metroLabel6.TabIndex = 49;
            this.metroLabel6.Text = "Keterangan";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(18, 540);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(45, 19);
            this.metroLabel5.TabIndex = 50;
            this.metroLabel5.Text = "Harga";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(20, 480);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(34, 19);
            this.metroLabel4.TabIndex = 51;
            this.metroLabel4.Text = "Stok";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(20, 426);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 52;
            this.metroLabel3.Text = "Satuan";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(20, 368);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 53;
            this.metroLabel2.Text = "Nama";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 311);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 19);
            this.metroLabel1.TabIndex = 54;
            this.metroLabel1.Text = "Kode Obat";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.txt_cari);
            this.metroPanel1.Controls.Add(this.btn_cari);
            this.metroPanel1.Controls.Add(this.cb_jenis);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 15;
            this.metroPanel1.Location = new System.Drawing.Point(18, 97);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(633, 134);
            this.metroPanel1.TabIndex = 57;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 15;
            // 
            // metroTile1
            // 
            this.metroTile1.BackColor = System.Drawing.Color.LimeGreen;
            this.metroTile1.CustomBackground = true;
            this.metroTile1.Location = new System.Drawing.Point(-2, 9);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(706, 78);
            this.metroTile1.TabIndex = 58;
            this.metroTile1.Text = "UBAH DATA OBAT";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(687, 743);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.cmb_satuan);
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
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(687, 743);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(687, 743);
            this.Movable = false;
            this.Name = "edit";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Edit - Obat";
            this.Load += new System.EventHandler(this.edit_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_cari;
        private MetroFramework.Controls.MetroTile btn_cari;
        private MetroFramework.Controls.MetroComboBox cb_jenis;
        private MetroFramework.Controls.MetroTile btn_cancel;
        private MetroFramework.Controls.MetroTile btn_simpan;
        private MetroFramework.Controls.MetroComboBox cmb_satuan;
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
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}