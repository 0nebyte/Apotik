﻿namespace Apotik.Menu.Dokter
{
    partial class masterDokter
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
            this.dataGridViewDokter = new System.Windows.Forms.DataGridView();
            this.obatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_hapus = new MetroFramework.Controls.MetroTile();
            this.btn_edit = new MetroFramework.Controls.MetroTile();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDokter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokterBindingSource)).BeginInit();
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
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // dataGridViewDokter
            // 
            this.dataGridViewDokter.AllowUserToAddRows = false;
            this.dataGridViewDokter.AllowUserToDeleteRows = false;
            this.dataGridViewDokter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDokter.AutoGenerateColumns = false;
            this.dataGridViewDokter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDokter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewDokter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDokter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.kodeDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.telpDataGridViewTextBoxColumn,
            this.keteranganDataGridViewTextBoxColumn});
            this.dataGridViewDokter.DataSource = this.dokterBindingSource;
            this.dataGridViewDokter.Location = new System.Drawing.Point(23, 106);
            this.dataGridViewDokter.Name = "dataGridViewDokter";
            this.dataGridViewDokter.ReadOnly = true;
            this.dataGridViewDokter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDokter.ShowEditingIcon = false;
            this.dataGridViewDokter.Size = new System.Drawing.Size(753, 366);
            this.dataGridViewDokter.TabIndex = 10;
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
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
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
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
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
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telpDataGridViewTextBoxColumn
            // 
            this.telpDataGridViewTextBoxColumn.DataPropertyName = "Telp";
            this.telpDataGridViewTextBoxColumn.HeaderText = "Telp";
            this.telpDataGridViewTextBoxColumn.Name = "telpDataGridViewTextBoxColumn";
            this.telpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keteranganDataGridViewTextBoxColumn
            // 
            this.keteranganDataGridViewTextBoxColumn.DataPropertyName = "Keterangan";
            this.keteranganDataGridViewTextBoxColumn.HeaderText = "Keterangan";
            this.keteranganDataGridViewTextBoxColumn.Name = "keteranganDataGridViewTextBoxColumn";
            this.keteranganDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dokterBindingSource
            // 
            this.dokterBindingSource.DataSource = typeof(Apotik.Model.Dokter);
            // 
            // masterDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 501);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.dataGridViewDokter);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_edit);
            this.Name = "masterDokter";
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Master Dokter";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDokter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_tambah;
        private System.Windows.Forms.DataGridView dataGridViewDokter;
        private System.Windows.Forms.BindingSource obatBindingSource;
        private MetroFramework.Controls.MetroTile btn_hapus;
        private MetroFramework.Controls.MetroTile btn_edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dokterBindingSource;
    }
}