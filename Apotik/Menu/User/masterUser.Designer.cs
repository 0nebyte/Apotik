﻿namespace Apotik.Menu.User
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
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.btn_hapus = new MetroFramework.Controls.MetroTile();
            this.btn_edit = new MetroFramework.Controls.MetroTile();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
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
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.AllowUserToDeleteRows = false;
            this.dataGridViewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUser.AutoGenerateColumns = false;
            this.dataGridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.kodeDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.jKDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.telpDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dataGridViewUser.DataSource = this.userBindingSource;
            this.dataGridViewUser.Location = new System.Drawing.Point(23, 106);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            this.dataGridViewUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUser.ShowEditingIcon = false;
            this.dataGridViewUser.Size = new System.Drawing.Size(753, 366);
            this.dataGridViewUser.TabIndex = 10;
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
            // jKDataGridViewTextBoxColumn
            // 
            this.jKDataGridViewTextBoxColumn.DataPropertyName = "JK";
            this.jKDataGridViewTextBoxColumn.HeaderText = "JK";
            this.jKDataGridViewTextBoxColumn.Name = "jKDataGridViewTextBoxColumn";
            this.jKDataGridViewTextBoxColumn.ReadOnly = true;
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
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Apotik.Model.User);
            // 
            // obatBindingSource
            // 
            this.obatBindingSource.DataSource = typeof(Apotik.Model.Obat);
            // 
            // masterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 501);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_edit);
            this.Name = "masterUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Master User";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_tambah;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.BindingSource obatBindingSource;
        private MetroFramework.Controls.MetroTile btn_hapus;
        private MetroFramework.Controls.MetroTile btn_edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}