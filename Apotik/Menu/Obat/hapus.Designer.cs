namespace Apotik.Menu.Obat
{
    partial class hapus
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
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.txt_kode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxOK = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOK)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(78, 42);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(335, 20);
            this.txt_nama.TabIndex = 30;
            // 
            // txt_kode
            // 
            this.txt_kode.Location = new System.Drawing.Point(78, 13);
            this.txt_kode.Name = "txt_kode";
            this.txt_kode.Size = new System.Drawing.Size(335, 20);
            this.txt_kode.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Kode Obat";
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = global::Apotik.Properties.Resources.Actions_window_close_icon;
            this.pictureBoxClose.Location = new System.Drawing.Point(327, 68);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(40, 38);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 31;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // pictureBoxOK
            // 
            this.pictureBoxOK.Image = global::Apotik.Properties.Resources.ok_icon;
            this.pictureBoxOK.Location = new System.Drawing.Point(373, 68);
            this.pictureBoxOK.Name = "pictureBoxOK";
            this.pictureBoxOK.Size = new System.Drawing.Size(40, 38);
            this.pictureBoxOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOK.TabIndex = 32;
            this.pictureBoxOK.TabStop = false;
            this.pictureBoxOK.Click += new System.EventHandler(this.pictureBoxOK_Click);
            // 
            // hapus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 125);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.pictureBoxOK);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.txt_kode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "hapus";
            this.Text = "hapus";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxOK;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.TextBox txt_kode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}