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
            this.cmb_satuan = new System.Windows.Forms.ComboBox();
            this.txt_supp = new System.Windows.Forms.TextBox();
            this.txt_ket = new System.Windows.Forms.TextBox();
            this.txt_harga = new System.Windows.Forms.TextBox();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.txt_kode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_satuan
            // 
            this.cmb_satuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_satuan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_satuan.FormattingEnabled = true;
            this.cmb_satuan.Items.AddRange(new object[] {
            "Botol",
            "Strip",
            "Kapsul"});
            this.cmb_satuan.Location = new System.Drawing.Point(88, 79);
            this.cmb_satuan.Name = "cmb_satuan";
            this.cmb_satuan.Size = new System.Drawing.Size(121, 21);
            this.cmb_satuan.TabIndex = 3;
            // 
            // txt_supp
            // 
            this.txt_supp.Location = new System.Drawing.Point(88, 224);
            this.txt_supp.Name = "txt_supp";
            this.txt_supp.Size = new System.Drawing.Size(335, 20);
            this.txt_supp.TabIndex = 7;
            // 
            // txt_ket
            // 
            this.txt_ket.Location = new System.Drawing.Point(88, 164);
            this.txt_ket.Multiline = true;
            this.txt_ket.Name = "txt_ket";
            this.txt_ket.Size = new System.Drawing.Size(335, 54);
            this.txt_ket.TabIndex = 6;
            // 
            // txt_harga
            // 
            this.txt_harga.Location = new System.Drawing.Point(88, 135);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(335, 20);
            this.txt_harga.TabIndex = 5;
            // 
            // txt_stok
            // 
            this.txt_stok.Location = new System.Drawing.Point(88, 106);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(121, 20);
            this.txt_stok.TabIndex = 4;
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(88, 47);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(335, 20);
            this.txt_nama.TabIndex = 2;
            // 
            // txt_kode
            // 
            this.txt_kode.Location = new System.Drawing.Point(88, 18);
            this.txt_kode.Name = "txt_kode";
            this.txt_kode.Size = new System.Drawing.Size(335, 20);
            this.txt_kode.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Supplier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Keterangan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Harga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Satuan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kode Obat";
            // 
            // btn_simpan
            // 
            this.btn_simpan.Image = global::Apotik.Properties.Resources.UpgradeReport_Success;
            this.btn_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_simpan.Location = new System.Drawing.Point(347, 261);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(75, 23);
            this.btn_simpan.TabIndex = 8;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Apotik.Properties.Resources.UpgradeReport_Error;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(255, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Keluar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tambah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.cmb_satuan);
            this.Controls.Add(this.txt_supp);
            this.Controls.Add(this.txt_ket);
            this.Controls.Add(this.txt_harga);
            this.Controls.Add(this.txt_stok);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.txt_kode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tambah";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tambah";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_satuan;
        private System.Windows.Forms.TextBox txt_supp;
        private System.Windows.Forms.TextBox txt_ket;
        private System.Windows.Forms.TextBox txt_harga;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.TextBox txt_kode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Button button1;
    }
}