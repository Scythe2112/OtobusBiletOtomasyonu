namespace OOtomasyon.BiletIslemleri.Forms
{
    partial class frmBiBiletIcerik
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlOdemeTipi = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOdemeTipi = new System.Windows.Forms.ComboBox();
            this.pnlSatisTipi = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSatisTipi = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.gbMusteriKarti = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBonusBilet = new System.Windows.Forms.Label();
            this.lblBonusPara = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRezerve = new System.Windows.Forms.RadioButton();
            this.rbSatis = new System.Windows.Forms.RadioButton();
            this.gbCinsiyet = new System.Windows.Forms.GroupBox();
            this.rbBay = new System.Windows.Forms.RadioButton();
            this.rbBayan = new System.Windows.Forms.RadioButton();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTcKimlikNo = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlOdemeTipi.SuspendLayout();
            this.pnlSatisTipi.SuspendLayout();
            this.gbMusteriKarti.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbCinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.pnlOdemeTipi);
            this.panel1.Controls.Add(this.pnlSatisTipi);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.gbMusteriKarti);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gbCinsiyet);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.txtTcKimlikNo);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblAciklama);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 461);
            this.panel1.TabIndex = 0;
            // 
            // pnlOdemeTipi
            // 
            this.pnlOdemeTipi.Controls.Add(this.label2);
            this.pnlOdemeTipi.Controls.Add(this.cmbOdemeTipi);
            this.pnlOdemeTipi.Location = new System.Drawing.Point(28, 243);
            this.pnlOdemeTipi.Name = "pnlOdemeTipi";
            this.pnlOdemeTipi.Size = new System.Drawing.Size(297, 33);
            this.pnlOdemeTipi.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ödeme Tipi :";
            // 
            // cmbOdemeTipi
            // 
            this.cmbOdemeTipi.FormattingEnabled = true;
            this.cmbOdemeTipi.Location = new System.Drawing.Point(91, 3);
            this.cmbOdemeTipi.Name = "cmbOdemeTipi";
            this.cmbOdemeTipi.Size = new System.Drawing.Size(206, 21);
            this.cmbOdemeTipi.TabIndex = 3;
            this.cmbOdemeTipi.SelectedIndexChanged += new System.EventHandler(this.cmbOdemeTipi_SelectedIndexChanged);
            // 
            // pnlSatisTipi
            // 
            this.pnlSatisTipi.Controls.Add(this.label5);
            this.pnlSatisTipi.Controls.Add(this.cmbSatisTipi);
            this.pnlSatisTipi.Location = new System.Drawing.Point(28, 352);
            this.pnlSatisTipi.Name = "pnlSatisTipi";
            this.pnlSatisTipi.Size = new System.Drawing.Size(297, 34);
            this.pnlSatisTipi.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Satış Tipi :";
            // 
            // cmbSatisTipi
            // 
            this.cmbSatisTipi.FormattingEnabled = true;
            this.cmbSatisTipi.Location = new System.Drawing.Point(91, 6);
            this.cmbSatisTipi.Name = "cmbSatisTipi";
            this.cmbSatisTipi.Size = new System.Drawing.Size(206, 21);
            this.cmbSatisTipi.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(250, 388);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // gbMusteriKarti
            // 
            this.gbMusteriKarti.Controls.Add(this.label9);
            this.gbMusteriKarti.Controls.Add(this.label8);
            this.gbMusteriKarti.Controls.Add(this.lblBonusBilet);
            this.gbMusteriKarti.Controls.Add(this.lblBonusPara);
            this.gbMusteriKarti.Location = new System.Drawing.Point(119, 280);
            this.gbMusteriKarti.Name = "gbMusteriKarti";
            this.gbMusteriKarti.Size = new System.Drawing.Size(206, 66);
            this.gbMusteriKarti.TabIndex = 5;
            this.gbMusteriKarti.TabStop = false;
            this.gbMusteriKarti.Text = "Müşteri Kartı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(44)))), ((int)(((byte)(39)))));
            this.label9.Location = new System.Drawing.Point(30, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bonus Para :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(44)))), ((int)(((byte)(39)))));
            this.label8.Location = new System.Drawing.Point(30, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Satın Alınan Bilet :";
            // 
            // lblBonusBilet
            // 
            this.lblBonusBilet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBonusBilet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(44)))), ((int)(((byte)(39)))));
            this.lblBonusBilet.Location = new System.Drawing.Point(128, 40);
            this.lblBonusBilet.Name = "lblBonusBilet";
            this.lblBonusBilet.Size = new System.Drawing.Size(69, 13);
            this.lblBonusBilet.TabIndex = 0;
            // 
            // lblBonusPara
            // 
            this.lblBonusPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBonusPara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(44)))), ((int)(((byte)(39)))));
            this.lblBonusPara.Location = new System.Drawing.Point(104, 16);
            this.lblBonusPara.Name = "lblBonusPara";
            this.lblBonusPara.Size = new System.Drawing.Size(93, 13);
            this.lblBonusPara.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRezerve);
            this.groupBox1.Controls.Add(this.rbSatis);
            this.groupBox1.Location = new System.Drawing.Point(119, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 40);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Koltuk Durumu";
            // 
            // rbRezerve
            // 
            this.rbRezerve.AutoSize = true;
            this.rbRezerve.Location = new System.Drawing.Point(131, 17);
            this.rbRezerve.Name = "rbRezerve";
            this.rbRezerve.Size = new System.Drawing.Size(65, 17);
            this.rbRezerve.TabIndex = 0;
            this.rbRezerve.TabStop = true;
            this.rbRezerve.Text = "Rezerve";
            this.rbRezerve.UseVisualStyleBackColor = true;
            this.rbRezerve.CheckedChanged += new System.EventHandler(this.rbRezerve_CheckedChanged);
            // 
            // rbSatis
            // 
            this.rbSatis.AutoSize = true;
            this.rbSatis.Location = new System.Drawing.Point(6, 17);
            this.rbSatis.Name = "rbSatis";
            this.rbSatis.Size = new System.Drawing.Size(48, 17);
            this.rbSatis.TabIndex = 0;
            this.rbSatis.TabStop = true;
            this.rbSatis.Text = "Satış";
            this.rbSatis.UseVisualStyleBackColor = true;
            this.rbSatis.CheckedChanged += new System.EventHandler(this.rbSatis_CheckedChanged);
            // 
            // gbCinsiyet
            // 
            this.gbCinsiyet.Controls.Add(this.rbBay);
            this.gbCinsiyet.Controls.Add(this.rbBayan);
            this.gbCinsiyet.Location = new System.Drawing.Point(119, 151);
            this.gbCinsiyet.Name = "gbCinsiyet";
            this.gbCinsiyet.Size = new System.Drawing.Size(206, 40);
            this.gbCinsiyet.TabIndex = 4;
            this.gbCinsiyet.TabStop = false;
            this.gbCinsiyet.Text = "Cinsiyet";
            // 
            // rbBay
            // 
            this.rbBay.AutoSize = true;
            this.rbBay.Location = new System.Drawing.Point(131, 19);
            this.rbBay.Name = "rbBay";
            this.rbBay.Size = new System.Drawing.Size(43, 17);
            this.rbBay.TabIndex = 0;
            this.rbBay.TabStop = true;
            this.rbBay.Text = "Bay";
            this.rbBay.UseVisualStyleBackColor = true;
            // 
            // rbBayan
            // 
            this.rbBayan.AutoSize = true;
            this.rbBayan.Location = new System.Drawing.Point(6, 17);
            this.rbBayan.Name = "rbBayan";
            this.rbBayan.Size = new System.Drawing.Size(55, 17);
            this.rbBayan.TabIndex = 0;
            this.rbBayan.TabStop = true;
            this.rbBayan.Text = "Bayan";
            this.rbBayan.UseVisualStyleBackColor = true;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(119, 125);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(206, 20);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtTcKimlikNo
            // 
            this.txtTcKimlikNo.Location = new System.Drawing.Point(119, 72);
            this.txtTcKimlikNo.Name = "txtTcKimlikNo";
            this.txtTcKimlikNo.Size = new System.Drawing.Size(206, 20);
            this.txtTcKimlikNo.TabIndex = 1;
            this.txtTcKimlikNo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(119, 98);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(206, 20);
            this.txtAd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "TC  :";
            // 
            // lblAciklama
            // 
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(44)))), ((int)(((byte)(39)))));
            this.lblAciklama.Location = new System.Drawing.Point(36, 9);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(289, 60);
            this.lblAciklama.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // frmBiBiletIcerik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 461);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(380, 500);
            this.Name = "frmBiBiletIcerik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilet İçerik";
            this.Load += new System.EventHandler(this.frmBiBiletIcerik_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlOdemeTipi.ResumeLayout(false);
            this.pnlOdemeTipi.PerformLayout();
            this.pnlSatisTipi.ResumeLayout(false);
            this.pnlSatisTipi.PerformLayout();
            this.gbMusteriKarti.ResumeLayout(false);
            this.gbMusteriKarti.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCinsiyet.ResumeLayout(false);
            this.gbCinsiyet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox gbMusteriKarti;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBonusBilet;
        private System.Windows.Forms.Label lblBonusPara;
        private System.Windows.Forms.GroupBox gbCinsiyet;
        private System.Windows.Forms.RadioButton rbBay;
        private System.Windows.Forms.RadioButton rbBayan;
        private System.Windows.Forms.ComboBox cmbSatisTipi;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTcKimlikNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSatisTipi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOdemeTipi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRezerve;
        private System.Windows.Forms.RadioButton rbSatis;
        private System.Windows.Forms.Panel pnlOdemeTipi;
    }
}