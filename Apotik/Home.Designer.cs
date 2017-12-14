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
            this.User = new System.Windows.Forms.ToolStripDropDownButton();
            this.tambahToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.User,
            this.Tutup});
            this.toolStripMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripMenu.ShowItemToolTips = false;
            this.toolStripMenu.Size = new System.Drawing.Size(1008, 82);
            this.toolStripMenu.TabIndex = 1;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // Obat
            // 
            this.Obat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahToolStripMenuItem,
            this.ubahToolStripMenuItem,
            this.hapusToolStripMenuItem});
            this.Obat.Image = ((System.Drawing.Image)(resources.GetObject("Obat.Image")));
            this.Obat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Obat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Obat.Margin = new System.Windows.Forms.Padding(10, 1, 15, 2);
            this.Obat.Name = "Obat";
            this.Obat.Size = new System.Drawing.Size(68, 74);
            this.Obat.Text = "Obat";
            this.Obat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Obat.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.Obat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Obat.Click += new System.EventHandler(this.Obat_Click);
            // 
            // tambahToolStripMenuItem
            // 
            this.tambahToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tambahToolStripMenuItem.BackgroundImage")));
            this.tambahToolStripMenuItem.Name = "tambahToolStripMenuItem";
            this.tambahToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.tambahToolStripMenuItem.Text = "Tambah";
            this.tambahToolStripMenuItem.Click += new System.EventHandler(this.tambahToolStripMenuItem_Click);
            // 
            // ubahToolStripMenuItem
            // 
            this.ubahToolStripMenuItem.Name = "ubahToolStripMenuItem";
            this.ubahToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.ubahToolStripMenuItem.Text = "Ubah";
            this.ubahToolStripMenuItem.Click += new System.EventHandler(this.ubahToolStripMenuItem_Click);
            // 
            // hapusToolStripMenuItem
            // 
            this.hapusToolStripMenuItem.Name = "hapusToolStripMenuItem";
            this.hapusToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.hapusToolStripMenuItem.Text = "Hapus";
            this.hapusToolStripMenuItem.Click += new System.EventHandler(this.hapusToolStripMenuItem_Click);
            // 
            // Dokter
            // 
            this.Dokter.Image = ((System.Drawing.Image)(resources.GetObject("Dokter.Image")));
            this.Dokter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Dokter.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.Dokter.Name = "Dokter";
            this.Dokter.Size = new System.Drawing.Size(68, 74);
            this.Dokter.Text = "Dokter";
            this.Dokter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Dokter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Dokter.Click += new System.EventHandler(this.Dokter_Click);
            // 
            // Distributor
            // 
            this.Distributor.Image = ((System.Drawing.Image)(resources.GetObject("Distributor.Image")));
            this.Distributor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Distributor.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.Distributor.Name = "Distributor";
            this.Distributor.Size = new System.Drawing.Size(76, 74);
            this.Distributor.Text = "Distributor";
            this.Distributor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Distributor.Click += new System.EventHandler(this.Distributor_Click);
            // 
            // Penjualan
            // 
            this.Penjualan.Image = ((System.Drawing.Image)(resources.GetObject("Penjualan.Image")));
            this.Penjualan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Penjualan.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.Penjualan.Name = "Penjualan";
            this.Penjualan.Size = new System.Drawing.Size(72, 74);
            this.Penjualan.Text = "Penjualan";
            this.Penjualan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Penjualan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Pembelian
            // 
            this.Pembelian.Image = ((System.Drawing.Image)(resources.GetObject("Pembelian.Image")));
            this.Pembelian.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Pembelian.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.Pembelian.Name = "Pembelian";
            this.Pembelian.Size = new System.Drawing.Size(76, 74);
            this.Pembelian.Text = "Pembelian";
            this.Pembelian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // User
            // 
            this.User.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahToolStripMenuItem1});
            this.User.Image = ((System.Drawing.Image)(resources.GetObject("User.Image")));
            this.User.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.User.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(74, 74);
            this.User.Text = "Pengguna";
            this.User.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.User.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.User.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // tambahToolStripMenuItem1
            // 
            this.tambahToolStripMenuItem1.Name = "tambahToolStripMenuItem1";
            this.tambahToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.tambahToolStripMenuItem1.Text = "tambah";
            this.tambahToolStripMenuItem1.Click += new System.EventHandler(this.tambahToolStripMenuItem1_Click);
            // 
            // Tutup
            // 
            this.Tutup.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tutup.Image = ((System.Drawing.Image)(resources.GetObject("Tutup.Image")));
            this.Tutup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tutup.Name = "Tutup";
            this.Tutup.Size = new System.Drawing.Size(59, 79);
            this.Tutup.Text = "Keluar";
            this.Tutup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Home";
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
        private System.Windows.Forms.ToolStripDropDownButton User;
        private System.Windows.Forms.ToolStripMenuItem tambahToolStripMenuItem1;
    }
}



