namespace Apotik.Menu.Transaksi.Penjualan
{
    partial class dataObat
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
            this.penjualanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_obat = new System.Windows.Forms.DataGridView();
            this.obatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.penjualanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_obat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // penjualanBindingSource
            // 
            this.penjualanBindingSource.DataSource = typeof(Apotik.Model.Penjualan);
            // 
            // obatBindingSource
            // 
            this.obatBindingSource.DataSource = typeof(Apotik.Model.Obat);
            // 
            // dgv_obat
            // 
            this.dgv_obat.AllowUserToAddRows = false;
            this.dgv_obat.AllowUserToDeleteRows = false;
            this.dgv_obat.AllowUserToOrderColumns = true;
            this.dgv_obat.AllowUserToResizeColumns = false;
            this.dgv_obat.AllowUserToResizeRows = false;
            this.dgv_obat.AutoGenerateColumns = false;
            this.dgv_obat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_obat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_obat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_obat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.kodeDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.satuanDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.keteranganDataGridViewTextBoxColumn});
            this.dgv_obat.DataSource = this.obatBindingSource;
            this.dgv_obat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_obat.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_obat.Location = new System.Drawing.Point(20, 60);
            this.dgv_obat.MultiSelect = false;
            this.dgv_obat.Name = "dgv_obat";
            this.dgv_obat.ReadOnly = true;
            this.dgv_obat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_obat.Size = new System.Drawing.Size(708, 418);
            this.dgv_obat.TabIndex = 1;
            this.dgv_obat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_obat_CellClick);
            // 
            // obatBindingSource1
            // 
            this.obatBindingSource1.DataSource = typeof(Apotik.Model.Obat);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodeDataGridViewTextBoxColumn
            // 
            this.kodeDataGridViewTextBoxColumn.DataPropertyName = "Kode";
            this.kodeDataGridViewTextBoxColumn.HeaderText = "Kode";
            this.kodeDataGridViewTextBoxColumn.Name = "kodeDataGridViewTextBoxColumn";
            this.kodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // satuanDataGridViewTextBoxColumn
            // 
            this.satuanDataGridViewTextBoxColumn.DataPropertyName = "Satuan";
            this.satuanDataGridViewTextBoxColumn.HeaderText = "Satuan";
            this.satuanDataGridViewTextBoxColumn.Name = "satuanDataGridViewTextBoxColumn";
            this.satuanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            this.stokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keteranganDataGridViewTextBoxColumn
            // 
            this.keteranganDataGridViewTextBoxColumn.DataPropertyName = "Keterangan";
            this.keteranganDataGridViewTextBoxColumn.HeaderText = "Keterangan";
            this.keteranganDataGridViewTextBoxColumn.Name = "keteranganDataGridViewTextBoxColumn";
            this.keteranganDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 498);
            this.Controls.Add(this.dgv_obat);
            this.Name = "dataObat";
            this.Text = "dataObat";
            ((System.ComponentModel.ISupportInitialize)(this.penjualanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_obat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource obatBindingSource;
        private System.Windows.Forms.BindingSource penjualanBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource obatBindingSource1;
        public System.Windows.Forms.DataGridView dgv_obat;
    }
}