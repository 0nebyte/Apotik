namespace Apotik
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.Obat = new System.Windows.Forms.ToolStripDropDownButton();
            this.tambahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hapusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Dokter = new System.Windows.Forms.ToolStripDropDownButton();
            this.Distributor = new System.Windows.Forms.ToolStripDropDownButton();
            this.Penjualan = new System.Windows.Forms.ToolStripDropDownButton();
            this.Pembelian = new System.Windows.Forms.ToolStripDropDownButton();
            this.Tutup = new System.Windows.Forms.ToolStripButton();
            this.statusStrip.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 507);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
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
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(1008, 62);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // Obat
            // 
            this.Obat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Obat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahToolStripMenuItem,
            this.ubahToolStripMenuItem,
            this.hapusToolStripMenuItem});
            this.Obat.Image = global::Apotik.Properties.Resources.medical_pills_pot_icon1;
            this.Obat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Obat.Name = "Obat";
            this.Obat.Size = new System.Drawing.Size(68, 59);
            this.Obat.Text = "Obat";
            this.Obat.Click += new System.EventHandler(this.Obat_Click);
            // 
            // tambahToolStripMenuItem
            // 
            this.tambahToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tambahToolStripMenuItem.BackgroundImage")));
            this.tambahToolStripMenuItem.Name = "tambahToolStripMenuItem";
            this.tambahToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tambahToolStripMenuItem.Text = "Tambah";
            this.tambahToolStripMenuItem.Click += new System.EventHandler(this.tambahToolStripMenuItem_Click);
            // 
            // ubahToolStripMenuItem
            // 
            this.ubahToolStripMenuItem.Name = "ubahToolStripMenuItem";
            this.ubahToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ubahToolStripMenuItem.Text = "Ubah";
            this.ubahToolStripMenuItem.Click += new System.EventHandler(this.ubahToolStripMenuItem_Click);
            // 
            // hapusToolStripMenuItem
            // 
            this.hapusToolStripMenuItem.Name = "hapusToolStripMenuItem";
            this.hapusToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hapusToolStripMenuItem.Text = "Hapus";
            this.hapusToolStripMenuItem.Click += new System.EventHandler(this.hapusToolStripMenuItem_Click);
            // 
            // Dokter
            // 
            this.Dokter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Dokter.Image = global::Apotik.Properties.Resources.Doctor_icon;
            this.Dokter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Dokter.Name = "Dokter";
            this.Dokter.Size = new System.Drawing.Size(68, 59);
            this.Dokter.Text = "Dokter";
            // 
            // Distributor
            // 
            this.Distributor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Distributor.Image = global::Apotik.Properties.Resources.distributor_report_icon;
            this.Distributor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Distributor.Name = "Distributor";
            this.Distributor.Size = new System.Drawing.Size(68, 59);
            this.Distributor.Text = "Distributor";
            // 
            // Penjualan
            // 
            this.Penjualan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Penjualan.Image = global::Apotik.Properties.Resources.Cash_register_icon;
            this.Penjualan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Penjualan.Name = "Penjualan";
            this.Penjualan.Size = new System.Drawing.Size(68, 59);
            this.Penjualan.Text = "Penjualan";
            // 
            // Pembelian
            // 
            this.Pembelian.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Pembelian.Image = global::Apotik.Properties.Resources.basket_icon;
            this.Pembelian.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Pembelian.Name = "Pembelian";
            this.Pembelian.Size = new System.Drawing.Size(68, 59);
            this.Pembelian.Text = "Pembelian";
            // 
            // Tutup
            // 
            this.Tutup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tutup.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tutup.Image = global::Apotik.Properties.Resources.Close_2_icon;
            this.Tutup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tutup.Name = "Tutup";
            this.Tutup.Size = new System.Drawing.Size(59, 59);
            this.Tutup.Text = "Tutup Aplikasi";
            this.Tutup.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Tutup.Click += new System.EventHandler(this.Tutup_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1008, 529);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Name = "Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apotik 1.0";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripDropDownButton Obat;
        private System.Windows.Forms.ToolStripMenuItem tambahToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton Dokter;
        private System.Windows.Forms.ToolStripDropDownButton Distributor;
        private System.Windows.Forms.ToolStripDropDownButton Penjualan;
        private System.Windows.Forms.ToolStripDropDownButton Pembelian;
        private System.Windows.Forms.ToolStripButton Tutup;
        private System.Windows.Forms.ToolStripMenuItem ubahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hapusToolStripMenuItem;
    }
}



