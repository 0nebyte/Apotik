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
            this.Master = new System.Windows.Forms.ToolStripDropDownButton();
            this.obatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distributorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penggunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Transaksi = new System.Windows.Forms.ToolStripDropDownButton();
            this.penjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembelianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Tutup = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_file_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 784);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1512, 30);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(60, 25);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(55, 55);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Master,
            this.toolStripSeparator1,
            this.Transaksi,
            this.toolStripSeparator2,
            this.Tutup});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 33);
            this.toolStripMenu.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.toolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripMenu.ShowItemToolTips = false;
            this.toolStripMenu.Size = new System.Drawing.Size(1512, 93);
            this.toolStripMenu.TabIndex = 1;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // Master
            // 
            this.Master.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obatToolStripMenuItem,
            this.dokterToolStripMenuItem,
            this.distributorToolStripMenuItem,
            this.penggunaToolStripMenuItem});
            this.Master.Image = ((System.Drawing.Image)(resources.GetObject("Master.Image")));
            this.Master.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Master.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.Master.Name = "Master";
            this.Master.Size = new System.Drawing.Size(97, 90);
            this.Master.Text = "MASTER";
            this.Master.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Master.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // obatToolStripMenuItem
            // 
            this.obatToolStripMenuItem.Name = "obatToolStripMenuItem";
            this.obatToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.obatToolStripMenuItem.Text = "Obat";
            this.obatToolStripMenuItem.Click += new System.EventHandler(this.obatToolStripMenuItem_Click);
            // 
            // dokterToolStripMenuItem
            // 
            this.dokterToolStripMenuItem.Name = "dokterToolStripMenuItem";
            this.dokterToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.dokterToolStripMenuItem.Text = "Dokter";
            this.dokterToolStripMenuItem.Click += new System.EventHandler(this.dokterToolStripMenuItem_Click);
            // 
            // distributorToolStripMenuItem
            // 
            this.distributorToolStripMenuItem.Name = "distributorToolStripMenuItem";
            this.distributorToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.distributorToolStripMenuItem.Text = "Distributor";
            this.distributorToolStripMenuItem.Click += new System.EventHandler(this.distributorToolStripMenuItem_Click);
            // 
            // penggunaToolStripMenuItem
            // 
            this.penggunaToolStripMenuItem.Name = "penggunaToolStripMenuItem";
            this.penggunaToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.penggunaToolStripMenuItem.Text = "Pengguna";
            this.penggunaToolStripMenuItem.Click += new System.EventHandler(this.penggunaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 93);
            // 
            // Transaksi
            // 
            this.Transaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penjualanToolStripMenuItem,
            this.pembelianToolStripMenuItem});
            this.Transaksi.Image = ((System.Drawing.Image)(resources.GetObject("Transaksi.Image")));
            this.Transaksi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Transaksi.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.Transaksi.Name = "Transaksi";
            this.Transaksi.Size = new System.Drawing.Size(122, 90);
            this.Transaksi.Text = "TRANSAKSI";
            this.Transaksi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Transaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // penjualanToolStripMenuItem
            // 
            this.penjualanToolStripMenuItem.Name = "penjualanToolStripMenuItem";
            this.penjualanToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.penjualanToolStripMenuItem.Text = "Penjualan";
            this.penjualanToolStripMenuItem.Click += new System.EventHandler(this.penjualanToolStripMenuItem_Click);
            // 
            // pembelianToolStripMenuItem
            // 
            this.pembelianToolStripMenuItem.Name = "pembelianToolStripMenuItem";
            this.pembelianToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.pembelianToolStripMenuItem.Text = "Pembelian";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 93);
            // 
            // Tutup
            // 
            this.Tutup.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Tutup.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tutup.Image = ((System.Drawing.Image)(resources.GetObject("Tutup.Image")));
            this.Tutup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tutup.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.Tutup.Name = "Tutup";
            this.Tutup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tutup.Size = new System.Drawing.Size(82, 90);
            this.Tutup.Text = "Keluar";
            this.Tutup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Tutup.Click += new System.EventHandler(this.Tutup_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1512, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_file_exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnu_file_exit
            // 
            this.mnu_file_exit.Name = "mnu_file_exit";
            this.mnu_file_exit.Size = new System.Drawing.Size(123, 30);
            this.mnu_file_exit.Text = "E&xit";
            this.mnu_file_exit.Click += new System.EventHandler(this.mnu_file_exit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1512, 814);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apotik 1.0";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton Tutup;
        private System.Windows.Forms.ToolStripDropDownButton Master;
        private System.Windows.Forms.ToolStripMenuItem obatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dokterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distributorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penggunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton Transaksi;
        private System.Windows.Forms.ToolStripMenuItem penjualanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pembelianToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_file_exit;
    }
}



