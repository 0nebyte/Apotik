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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.detailJualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penjualanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_penjualan)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailJualBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_penjualan
            // 
            this.dgv_penjualan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_penjualan.AutoGenerateColumns = false;
            this.dgv_penjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_penjualan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_penjualan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_penjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_penjualan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.obatDataGridViewTextBoxColumn,
            this.penjualanDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_penjualan, 3);
            this.dgv_penjualan.DataSource = this.detailJualBindingSource;
            this.dgv_penjualan.GridColor = System.Drawing.SystemColors.Menu;
            this.dgv_penjualan.Location = new System.Drawing.Point(4, 111);
            this.dgv_penjualan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_penjualan.Name = "dgv_penjualan";
            this.dgv_penjualan.Size = new System.Drawing.Size(1868, 462);
            this.dgv_penjualan.TabIndex = 0;
            this.dgv_penjualan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_penjualan_CellDoubleClick);
            // 
            // txt_faktur
            // 
            this.txt_faktur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.SetColumnSpan(this.txt_faktur, 2);
            this.txt_faktur.Location = new System.Drawing.Point(154, 5);
            this.txt_faktur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_faktur.Name = "txt_faktur";
            this.txt_faktur.Size = new System.Drawing.Size(300, 25);
            this.txt_faktur.TabIndex = 1;
            // 
            // txt_dokter
            // 
            this.txt_dokter.Location = new System.Drawing.Point(154, 40);
            this.txt_dokter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_dokter.Name = "txt_dokter";
            this.txt_dokter.Size = new System.Drawing.Size(300, 24);
            this.txt_dokter.TabIndex = 2;
            // 
            // dtp_jual
            // 
            this.dtp_jual.Location = new System.Drawing.Point(154, 74);
            this.dtp_jual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_jual.Name = "dtp_jual";
            this.dtp_jual.Size = new System.Drawing.Size(298, 26);
            this.dtp_jual.TabIndex = 4;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 0);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "No Faktur";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 35);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "[F2] Dokter";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(4, 69);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Tanggal";
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(140, 12);
            this.txt_subtotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(300, 35);
            this.txt_subtotal.TabIndex = 2;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.metroPanel1.HorizontalScrollbarSize = 15;
            this.metroPanel1.Location = new System.Drawing.Point(1416, 584);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(456, 200);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 15;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(16, 155);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(76, 19);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "Grand Total";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(78, 111);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(35, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "PPN";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(60, 66);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(47, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Diskon";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(45, 18);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(57, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Subtotal";
            // 
            // metroTextBox6
            // 
            this.metroTextBox6.Location = new System.Drawing.Point(140, 149);
            this.metroTextBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.Size = new System.Drawing.Size(300, 35);
            this.metroTextBox6.TabIndex = 2;
            // 
            // metroTextBox5
            // 
            this.metroTextBox5.Location = new System.Drawing.Point(140, 105);
            this.metroTextBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.Size = new System.Drawing.Size(300, 35);
            this.metroTextBox5.TabIndex = 2;
            // 
            // metroTextBox4
            // 
            this.metroTextBox4.Location = new System.Drawing.Point(140, 60);
            this.metroTextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.Size = new System.Drawing.Size(300, 35);
            this.metroTextBox4.TabIndex = 2;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_close.Location = new System.Drawing.Point(4, 721);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(112, 63);
            this.btn_close.Style = MetroFramework.MetroColorStyle.Red;
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Exit";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_close.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 750F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 976F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_close, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_faktur, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtp_jual, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_dokter, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgv_penjualan, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 126);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1876, 789);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(904, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "[F3] Daftar Barang";
            // 
            // detailJualBindingSource
            // 
            this.detailJualBindingSource.DataSource = typeof(Apotik.Model.DetailJual);
            // 
            // obatDataGridViewTextBoxColumn
            // 
            this.obatDataGridViewTextBoxColumn.DataPropertyName = "Obat";
            this.obatDataGridViewTextBoxColumn.HeaderText = "Obat";
            this.obatDataGridViewTextBoxColumn.Name = "obatDataGridViewTextBoxColumn";
            // 
            // penjualanDataGridViewTextBoxColumn
            // 
            this.penjualanDataGridViewTextBoxColumn.DataPropertyName = "Penjualan";
            this.penjualanDataGridViewTextBoxColumn.HeaderText = "Penjualan";
            this.penjualanDataGridViewTextBoxColumn.Name = "penjualanDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // Jual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 951);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "Jual";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Transaksi Penjualan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Jual_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_penjualan)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailJualBindingSource)).EndInit();
            this.ResumeLayout(false);

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
        public System.Windows.Forms.DataGridView dgv_penjualan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource detailJualBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn obatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penjualanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}