namespace Apotik.Menu.Transaksi.Penjualan
{
    partial class Jual
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
            this.dgv_penjualan = new System.Windows.Forms.DataGridView();
            this.txt_faktur = new MetroFramework.Controls.MetroTextBox();
            this.txt_dokter = new MetroFramework.Controls.MetroTextBox();
            this.dtp_jual = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_subtotal = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox6 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.btn_close = new MetroFramework.Controls.MetroTile();
            this.id_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SATUAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_jual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_penjualan)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_penjualan
            // 
            this.dgv_penjualan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_penjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_penjualan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_penjualan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_penjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_penjualan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_barang,
            this.nama_barang,
            this.SATUAN,
            this.QTY,
            this.harga_jual,
            this.TOTAL});
            this.dgv_penjualan.GridColor = System.Drawing.SystemColors.Menu;
            this.dgv_penjualan.Location = new System.Drawing.Point(1, 186);
            this.dgv_penjualan.Name = "dgv_penjualan";
            this.dgv_penjualan.Size = new System.Drawing.Size(824, 294);
            this.dgv_penjualan.TabIndex = 0;
            this.dgv_penjualan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_penjualan_CellDoubleClick);
            // 
            // txt_faktur
            // 
            this.txt_faktur.Location = new System.Drawing.Point(85, 87);
            this.txt_faktur.Name = "txt_faktur";
            this.txt_faktur.Size = new System.Drawing.Size(200, 23);
            this.txt_faktur.TabIndex = 1;
            // 
            // txt_dokter
            // 
            this.txt_dokter.Location = new System.Drawing.Point(85, 116);
            this.txt_dokter.Name = "txt_dokter";
            this.txt_dokter.Size = new System.Drawing.Size(200, 23);
            this.txt_dokter.TabIndex = 2;
            // 
            // dtp_jual
            // 
            this.dtp_jual.Location = new System.Drawing.Point(85, 149);
            this.dtp_jual.Name = "dtp_jual";
            this.dtp_jual.Size = new System.Drawing.Size(200, 20);
            this.dtp_jual.TabIndex = 4;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "No Faktur";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(5, 115);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "[F2] Dokter";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(25, 144);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Tanggal";
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(93, 8);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(200, 23);
            this.txt_subtotal.TabIndex = 2;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroTextBox6);
            this.metroPanel1.Controls.Add(this.metroTextBox5);
            this.metroPanel1.Controls.Add(this.metroTextBox4);
            this.metroPanel1.Controls.Add(this.txt_subtotal);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(508, 486);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(317, 130);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(11, 101);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(76, 19);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "Grand Total";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(52, 72);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(35, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "PPN";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(40, 43);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(47, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Diskon";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(30, 12);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(57, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Subtotal";
            // 
            // metroTextBox6
            // 
            this.metroTextBox6.Location = new System.Drawing.Point(93, 97);
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.Size = new System.Drawing.Size(200, 23);
            this.metroTextBox6.TabIndex = 2;
            // 
            // metroTextBox5
            // 
            this.metroTextBox5.Location = new System.Drawing.Point(93, 68);
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.Size = new System.Drawing.Size(200, 23);
            this.metroTextBox5.TabIndex = 2;
            // 
            // metroTextBox4
            // 
            this.metroTextBox4.Location = new System.Drawing.Point(93, 39);
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.Size = new System.Drawing.Size(200, 23);
            this.metroTextBox4.TabIndex = 2;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_close.Location = new System.Drawing.Point(10, 575);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 41);
            this.btn_close.Style = MetroFramework.MetroColorStyle.Red;
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Exit";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_close.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // id_barang
            // 
            this.id_barang.HeaderText = "ID BARANG";
            this.id_barang.Name = "id_barang";
            // 
            // nama_barang
            // 
            this.nama_barang.HeaderText = "NAMA BARANG";
            this.nama_barang.Name = "nama_barang";
            // 
            // SATUAN
            // 
            this.SATUAN.HeaderText = "SATUAN";
            this.SATUAN.Name = "SATUAN";
            // 
            // QTY
            // 
            this.QTY.HeaderText = "QTY";
            this.QTY.Name = "QTY";
            // 
            // harga_jual
            // 
            this.harga_jual.HeaderText = "HARGA JUAL";
            this.harga_jual.Name = "harga_jual";
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            // 
            // Jual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 618);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtp_jual);
            this.Controls.Add(this.txt_dokter);
            this.Controls.Add(this.txt_faktur);
            this.Controls.Add(this.dgv_penjualan);
            this.MinimizeBox = false;
            this.Name = "Jual";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Transaksi Penjualan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Jual_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_penjualan)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txt_faktur;
        private System.Windows.Forms.DateTimePicker dtp_jual;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox6;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroTile btn_close;
        public MetroFramework.Controls.MetroTextBox txt_dokter;
        public MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroTextBox txt_subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SATUAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_jual;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        public System.Windows.Forms.DataGridView dgv_penjualan;
    }
}