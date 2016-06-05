namespace OOtomasyon.BiletIslemleri
{
    partial class frmBiMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.biletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletSatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletİptalEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBildirim = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(44)))), ((int)(((byte)(39)))));
            this.menuStrip.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biletToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(836, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // biletToolStripMenuItem
            // 
            this.biletToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biletSatToolStripMenuItem,
            this.biletGörüntüleToolStripMenuItem,
            this.biletİptalEtToolStripMenuItem});
            this.biletToolStripMenuItem.Name = "biletToolStripMenuItem";
            this.biletToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.biletToolStripMenuItem.Text = "Bilet";
            // 
            // biletSatToolStripMenuItem
            // 
            this.biletSatToolStripMenuItem.Name = "biletSatToolStripMenuItem";
            this.biletSatToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.biletSatToolStripMenuItem.Text = "Bilet Sat";
            this.biletSatToolStripMenuItem.Click += new System.EventHandler(this.biletSatToolStripMenuItem_Click);
            // 
            // biletGörüntüleToolStripMenuItem
            // 
            this.biletGörüntüleToolStripMenuItem.Name = "biletGörüntüleToolStripMenuItem";
            this.biletGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.biletGörüntüleToolStripMenuItem.Text = "Bilet Görüntüle";
            // 
            // biletİptalEtToolStripMenuItem
            // 
            this.biletİptalEtToolStripMenuItem.Name = "biletİptalEtToolStripMenuItem";
            this.biletİptalEtToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.biletİptalEtToolStripMenuItem.Text = "Bilet İptal Et";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(44)))), ((int)(((byte)(39)))));
            this.statusStrip.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.lblBildirim});
            this.statusStrip.Location = new System.Drawing.Point(0, 454);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip.Size = new System.Drawing.Size(836, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLabel.Text = "Bildirimler :";
            // 
            // lblBildirim
            // 
            this.lblBildirim.Name = "lblBildirim";
            this.lblBildirim.Size = new System.Drawing.Size(0, 17);
            // 
            // frmBiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(836, 476);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmBiMain";
            this.Text = "Bilet İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBiMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem biletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletSatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletİptalEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblBildirim;
    }
}



