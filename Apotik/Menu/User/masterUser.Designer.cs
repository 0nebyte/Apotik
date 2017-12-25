namespace Apotik.Menu.User
{
    partial class masterUser
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
            this.btn_tambah = new MetroFramework.Controls.MetroTile();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_hapus = new MetroFramework.Controls.MetroTile();
            this.btn_edit = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_tambah
            // 
            this.btn_tambah.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_tambah.CustomBackground = true;
            this.btn_tambah.Location = new System.Drawing.Point(23, 63);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(75, 37);
            this.btn_tambah.TabIndex = 7;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_tambah.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.kodeDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.satuanDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.keteranganDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.obatBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(753, 366);
            this.dataGridView1.TabIndex = 10;
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
            // obatBindingSource
            // 
            this.obatBindingSource.DataSource = typeof(Apotik.Model.Obat);
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.Color.Red;
            this.btn_hapus.CustomBackground = true;
            this.btn_hapus.Location = new System.Drawing.Point(185, 63);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(75, 37);
            this.btn_hapus.TabIndex = 8;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_hapus.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_edit.CustomBackground = true;
            this.btn_edit.Location = new System.Drawing.Point(104, 63);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 37);
            this.btn_edit.TabIndex = 9;
            this.btn_edit.Text = "Edit";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_edit.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // masterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 501);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_edit);
            this.Name = "masterUser";
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Master User";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_tambah;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource obatBindingSource;
        private MetroFramework.Controls.MetroTile btn_hapus;
        private MetroFramework.Controls.MetroTile btn_edit;
    }
}