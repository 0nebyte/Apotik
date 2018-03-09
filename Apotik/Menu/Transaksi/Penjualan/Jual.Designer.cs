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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_penjualan = new System.Windows.Forms.DataGridView();
            this.dtp_jual = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_grandtotal = new System.Windows.Forms.TextBox();
            this.txt_ppn = new System.Windows.Forms.TextBox();
            this.txt_diskon = new System.Windows.Forms.TextBox();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.txt_dokter = new System.Windows.Forms.TextBox();
            this.txt_faktur = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_batal = new System.Windows.Forms.Button();
            this.detailDataSourceBinding = new System.Windows.Forms.BindingSource(this.components);
            this.kodeObatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaObatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Toolbox = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_penjualan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailDataSourceBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "[F3] Daftar Barang";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgv_penjualan
            // 
            this.dgv_penjualan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_penjualan.AutoGenerateColumns = false;
            this.dgv_penjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_penjualan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_penjualan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_penjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_penjualan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeObatDataGridViewTextBoxColumn,
            this.namaObatDataGridViewTextBoxColumn,
            this.satuanDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.subTotalDataGridViewTextBoxColumn,
            this.Toolbox});
            this.dgv_penjualan.DataSource = this.detailDataSourceBinding;
            this.dgv_penjualan.GridColor = System.Drawing.SystemColors.Menu;
            this.dgv_penjualan.Location = new System.Drawing.Point(22, 131);
            this.dgv_penjualan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_penjualan.Name = "dgv_penjualan";
            this.dgv_penjualan.Size = new System.Drawing.Size(734, 244);
            this.dgv_penjualan.TabIndex = 0;
            this.dgv_penjualan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_penjualan_CellContentClick);
            this.dgv_penjualan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_penjualan_CellDoubleClick);
            this.dgv_penjualan.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_penjualan_CellValueChanged);
            this.dgv_penjualan.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_penjualan_DataError);
            // 
            // dtp_jual
            // 
            this.dtp_jual.Location = new System.Drawing.Point(122, 81);
            this.dtp_jual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_jual.Name = "dtp_jual";
            this.dtp_jual.Size = new System.Drawing.Size(298, 26);
            this.dtp_jual.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "No. Faktur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "[F2] Dokter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tanggal";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_grandtotal);
            this.groupBox1.Controls.Add(this.txt_ppn);
            this.groupBox1.Controls.Add(this.txt_diskon);
            this.groupBox1.Controls.Add(this.txt_subtotal);
            this.groupBox1.Location = new System.Drawing.Point(342, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 153);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Grandtotal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "PPN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Diskon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Subtotal";
            // 
            // txt_grandtotal
            // 
            this.txt_grandtotal.Location = new System.Drawing.Point(96, 115);
            this.txt_grandtotal.Name = "txt_grandtotal";
            this.txt_grandtotal.Size = new System.Drawing.Size(312, 26);
            this.txt_grandtotal.TabIndex = 3;
            // 
            // txt_ppn
            // 
            this.txt_ppn.Location = new System.Drawing.Point(96, 83);
            this.txt_ppn.Name = "txt_ppn";
            this.txt_ppn.Size = new System.Drawing.Size(312, 26);
            this.txt_ppn.TabIndex = 2;
            // 
            // txt_diskon
            // 
            this.txt_diskon.Location = new System.Drawing.Point(96, 51);
            this.txt_diskon.Name = "txt_diskon";
            this.txt_diskon.Size = new System.Drawing.Size(312, 26);
            this.txt_diskon.TabIndex = 1;
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(96, 19);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(312, 26);
            this.txt_subtotal.TabIndex = 0;
            // 
            // txt_dokter
            // 
            this.txt_dokter.Location = new System.Drawing.Point(122, 47);
            this.txt_dokter.Name = "txt_dokter";
            this.txt_dokter.Size = new System.Drawing.Size(298, 26);
            this.txt_dokter.TabIndex = 12;
            // 
            // txt_faktur
            // 
            this.txt_faktur.Location = new System.Drawing.Point(122, 15);
            this.txt_faktur.Name = "txt_faktur";
            this.txt_faktur.Size = new System.Drawing.Size(298, 26);
            this.txt_faktur.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btn_simpan);
            this.groupBox2.Controls.Add(this.btn_batal);
            this.groupBox2.Location = new System.Drawing.Point(22, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 153);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(119, 19);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(109, 46);
            this.btn_simpan.TabIndex = 1;
            this.btn_simpan.Text = "[F8] Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_batal
            // 
            this.btn_batal.Location = new System.Drawing.Point(6, 19);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(107, 47);
            this.btn_batal.TabIndex = 0;
            this.btn_batal.Text = "[ESC] Batal";
            this.btn_batal.UseVisualStyleBackColor = true;
            this.btn_batal.Click += new System.EventHandler(this.btn_batal_Click);
            // 
            // detailDataSourceBinding
            // 
            this.detailDataSourceBinding.DataSource = typeof(Apotik.Menu.Transaksi.Penjualan.DetailDataSource);
            // 
            // kodeObatDataGridViewTextBoxColumn
            // 
            this.kodeObatDataGridViewTextBoxColumn.DataPropertyName = "KodeObat";
            this.kodeObatDataGridViewTextBoxColumn.HeaderText = "Kode Obat";
            this.kodeObatDataGridViewTextBoxColumn.Name = "kodeObatDataGridViewTextBoxColumn";
            this.kodeObatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaObatDataGridViewTextBoxColumn
            // 
            this.namaObatDataGridViewTextBoxColumn.DataPropertyName = "NamaObat";
            this.namaObatDataGridViewTextBoxColumn.HeaderText = "Nama Obat";
            this.namaObatDataGridViewTextBoxColumn.Name = "namaObatDataGridViewTextBoxColumn";
            this.namaObatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // satuanDataGridViewTextBoxColumn
            // 
            this.satuanDataGridViewTextBoxColumn.DataPropertyName = "Satuan";
            this.satuanDataGridViewTextBoxColumn.HeaderText = "Satuan";
            this.satuanDataGridViewTextBoxColumn.Name = "satuanDataGridViewTextBoxColumn";
            this.satuanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga Satuan";
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            this.subTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Toolbox
            // 
            this.Toolbox.HeaderText = "";
            this.Toolbox.Name = "Toolbox";
            this.Toolbox.Text = "Hapus";
            this.Toolbox.UseColumnTextForButtonValue = true;
            // 
            // Jual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_faktur);
            this.Controls.Add(this.txt_dokter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_penjualan);
            this.Controls.Add(this.dtp_jual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Jual";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Transaksi Penjualan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Jual_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_penjualan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detailDataSourceBinding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource detailDataSourceBinding;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgv_penjualan;
        private System.Windows.Forms.DateTimePicker dtp_jual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_dokter;
        private System.Windows.Forms.TextBox txt_faktur;
        private System.Windows.Forms.TextBox txt_grandtotal;
        private System.Windows.Forms.TextBox txt_ppn;
        private System.Windows.Forms.TextBox txt_diskon;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Button btn_batal;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Toolbox;
    }
}