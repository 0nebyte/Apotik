namespace Apotik
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.Obat = new System.Windows.Forms.ToolStripDropDownButton();
            this.tambahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Dokter = new System.Windows.Forms.ToolStripDropDownButton();
            this.Distributor = new System.Windows.Forms.ToolStripDropDownButton();
            this.Penjualan = new System.Windows.Forms.ToolStripDropDownButton();
            this.Pembelian = new System.Windows.Forms.ToolStripDropDownButton();
            this.Tutup = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(55, 55);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Obat,
            this.Dokter,
            this.Distributor,
            this.Penjualan,
            this.Pembelian,
            this.Tutup});
            this.toolStripMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(1512, 28);
            this.toolStripMenu.TabIndex = 1;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // Obat
            // 
            this.Obat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Obat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahToolStripMenuItem});
            this.Obat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Obat.Name = "Obat";
            this.Obat.Size = new System.Drawing.Size(18, 4);
            this.Obat.Text = "Obat";
            this.Obat.Click += new System.EventHandler(this.Obat_Click);
            // 
            // tambahToolStripMenuItem
            // 
            this.tambahToolStripMenuItem.Name = "tambahToolStripMenuItem";
            this.tambahToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.tambahToolStripMenuItem.Text = "Tambah";
            this.tambahToolStripMenuItem.Click += new System.EventHandler(this.tambahToolStripMenuItem_Click);
            // 
            // Dokter
            // 
            this.Dokter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Dokter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Dokter.Name = "Dokter";
            this.Dokter.Size = new System.Drawing.Size(18, 4);
            this.Dokter.Text = "Dokter";
            // 
            // Distributor
            // 
            this.Distributor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Distributor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Distributor.Name = "Distributor";
            this.Distributor.Size = new System.Drawing.Size(18, 4);
            this.Distributor.Text = "Distributor";
            // 
            // Penjualan
            // 
            this.Penjualan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Penjualan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Penjualan.Name = "Penjualan";
            this.Penjualan.Size = new System.Drawing.Size(18, 4);
            this.Penjualan.Text = "Penjualan";
            // 
            // Pembelian
            // 
            this.Pembelian.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Pembelian.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Pembelian.Name = "Pembelian";
            this.Pembelian.Size = new System.Drawing.Size(18, 4);
            this.Pembelian.Text = "Pembelian";
            // 
            // Tutup
            // 
            this.Tutup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tutup.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tutup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tutup.Name = "Tutup";
            this.Tutup.Size = new System.Drawing.Size(23, 4);
            this.Tutup.Text = "Tutup Aplikasi";
            this.Tutup.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Tutup.Click += new System.EventHandler(this.Tutup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1512, 814);
            this.ControlBox = false;
            this.Controls.Add(this.toolStripMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apotik - Beta Version";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton Tutup;
        private System.Windows.Forms.ToolStripDropDownButton Obat;
        private System.Windows.Forms.ToolStripDropDownButton Dokter;
        private System.Windows.Forms.ToolStripDropDownButton Penjualan;
        private System.Windows.Forms.ToolStripDropDownButton Pembelian;
        private System.Windows.Forms.ToolStripDropDownButton Distributor;
        private System.Windows.Forms.ToolStripMenuItem tambahToolStripMenuItem;
    }
}

