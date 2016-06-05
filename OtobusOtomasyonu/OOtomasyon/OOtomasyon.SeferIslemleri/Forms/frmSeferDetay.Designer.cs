namespace OOtomasyon.SeferIslemleri.Forms
{
    partial class frmSeferDetay
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
            this.dgvSeferDetaylar = new System.Windows.Forms.DataGridView();
            this.btnPersonelTemizle = new System.Windows.Forms.Button();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.lstSeferPersonelleri = new System.Windows.Forms.ListBox();
            this.cmbOtobus = new System.Windows.Forms.ComboBox();
            this.numSeferUcreti = new System.Windows.Forms.NumericUpDown();
            this.txtSeferSaati = new System.Windows.Forms.MaskedTextBox();
            this.cmbSeferPersonel = new System.Windows.Forms.ComboBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dtpSeferTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSefer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbServisAracı = new System.Windows.Forms.ComboBox();
            this.grbServisBilgileri = new System.Windows.Forms.GroupBox();
            this.txtKalkisYeri = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtServisSaati = new System.Windows.Forms.MaskedTextBox();
            this.numServisUcreti = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.chkServisEkle = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferDetaylar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeferUcreti)).BeginInit();
            this.grbServisBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServisUcreti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSeferDetaylar
            // 
            this.dgvSeferDetaylar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeferDetaylar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeferDetaylar.Location = new System.Drawing.Point(442, 13);
            this.dgvSeferDetaylar.Name = "dgvSeferDetaylar";
            this.dgvSeferDetaylar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeferDetaylar.Size = new System.Drawing.Size(533, 520);
            this.dgvSeferDetaylar.TabIndex = 0;
            this.dgvSeferDetaylar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeferDetaylar_CellClick);
            // 
            // btnPersonelTemizle
            // 
            this.btnPersonelTemizle.Location = new System.Drawing.Point(17, 266);
            this.btnPersonelTemizle.Name = "btnPersonelTemizle";
            this.btnPersonelTemizle.Size = new System.Drawing.Size(83, 22);
            this.btnPersonelTemizle.TabIndex = 136;
            this.btnPersonelTemizle.Text = "Temizle";
            this.btnPersonelTemizle.UseVisualStyleBackColor = true;
            this.btnPersonelTemizle.Click += new System.EventHandler(this.btnPersonelTemizle_Click);
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.Location = new System.Drawing.Point(17, 238);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(83, 22);
            this.btnPersonelSil.TabIndex = 135;
            this.btnPersonelSil.Text = "Sil";
            this.btnPersonelSil.UseVisualStyleBackColor = true;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(17, 210);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(83, 22);
            this.btnPersonelEkle.TabIndex = 134;
            this.btnPersonelEkle.Text = "Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // lstSeferPersonelleri
            // 
            this.lstSeferPersonelleri.FormattingEnabled = true;
            this.lstSeferPersonelleri.ItemHeight = 15;
            this.lstSeferPersonelleri.Location = new System.Drawing.Point(152, 210);
            this.lstSeferPersonelleri.Name = "lstSeferPersonelleri";
            this.lstSeferPersonelleri.Size = new System.Drawing.Size(283, 124);
            this.lstSeferPersonelleri.TabIndex = 133;
            // 
            // cmbOtobus
            // 
            this.cmbOtobus.FormattingEnabled = true;
            this.cmbOtobus.Location = new System.Drawing.Point(153, 42);
            this.cmbOtobus.Name = "cmbOtobus";
            this.cmbOtobus.Size = new System.Drawing.Size(283, 23);
            this.cmbOtobus.TabIndex = 132;
            // 
            // numSeferUcreti
            // 
            this.numSeferUcreti.Location = new System.Drawing.Point(153, 125);
            this.numSeferUcreti.Name = "numSeferUcreti";
            this.numSeferUcreti.Size = new System.Drawing.Size(283, 21);
            this.numSeferUcreti.TabIndex = 131;
            // 
            // txtSeferSaati
            // 
            this.txtSeferSaati.Location = new System.Drawing.Point(153, 98);
            this.txtSeferSaati.Mask = "90:00";
            this.txtSeferSaati.Name = "txtSeferSaati";
            this.txtSeferSaati.Size = new System.Drawing.Size(283, 21);
            this.txtSeferSaati.TabIndex = 130;
            this.txtSeferSaati.ValidatingType = typeof(System.DateTime);
            // 
            // cmbSeferPersonel
            // 
            this.cmbSeferPersonel.FormattingEnabled = true;
            this.cmbSeferPersonel.Location = new System.Drawing.Point(152, 180);
            this.cmbSeferPersonel.Name = "cmbSeferPersonel";
            this.cmbSeferPersonel.Size = new System.Drawing.Size(283, 23);
            this.cmbSeferPersonel.TabIndex = 129;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(355, 465);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(76, 69);
            this.btnTemizle.TabIndex = 128;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListele.Location = new System.Drawing.Point(270, 465);
            this.btnListele.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(76, 69);
            this.btnListele.TabIndex = 127;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuncelle.Location = new System.Drawing.Point(184, 465);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(76, 69);
            this.btnGuncelle.TabIndex = 126;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSil.Location = new System.Drawing.Point(98, 465);
            this.btnSil.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(76, 69);
            this.btnSil.TabIndex = 125;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 123;
            this.label2.Text = "Otobüs :";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(15, 133);
            this.label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(91, 15);
            this.label.TabIndex = 122;
            this.label.Text = "Sefer Ücreti :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 121;
            this.label4.Text = "Sefer Saati :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 124;
            this.label1.Text = "Sefer :";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEkle.Location = new System.Drawing.Point(13, 465);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(76, 69);
            this.btnEkle.TabIndex = 120;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dtpSeferTarihi
            // 
            this.dtpSeferTarihi.Location = new System.Drawing.Point(153, 71);
            this.dtpSeferTarihi.Name = "dtpSeferTarihi";
            this.dtpSeferTarihi.Size = new System.Drawing.Size(282, 21);
            this.dtpSeferTarihi.TabIndex = 137;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 123;
            this.label3.Text = "Sefer Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 15);
            this.label5.TabIndex = 122;
            this.label5.Text = "Sefer Detay Personel :";
            // 
            // cmbSefer
            // 
            this.cmbSefer.FormattingEnabled = true;
            this.cmbSefer.Location = new System.Drawing.Point(153, 13);
            this.cmbSefer.Name = "cmbSefer";
            this.cmbSefer.Size = new System.Drawing.Size(283, 23);
            this.cmbSefer.TabIndex = 129;
            this.cmbSefer.SelectedIndexChanged += new System.EventHandler(this.cmbSefer_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 123;
            this.label6.Text = "Servis :";
            // 
            // cmbServisAracı
            // 
            this.cmbServisAracı.FormattingEnabled = true;
            this.cmbServisAracı.Location = new System.Drawing.Point(103, 25);
            this.cmbServisAracı.Name = "cmbServisAracı";
            this.cmbServisAracı.Size = new System.Drawing.Size(130, 23);
            this.cmbServisAracı.TabIndex = 132;
            // 
            // grbServisBilgileri
            // 
            this.grbServisBilgileri.Controls.Add(this.txtKalkisYeri);
            this.grbServisBilgileri.Controls.Add(this.label8);
            this.grbServisBilgileri.Controls.Add(this.label7);
            this.grbServisBilgileri.Controls.Add(this.label6);
            this.grbServisBilgileri.Controls.Add(this.cmbServisAracı);
            this.grbServisBilgileri.Controls.Add(this.txtServisSaati);
            this.grbServisBilgileri.Controls.Add(this.numServisUcreti);
            this.grbServisBilgileri.Controls.Add(this.label9);
            this.grbServisBilgileri.Location = new System.Drawing.Point(12, 340);
            this.grbServisBilgileri.Name = "grbServisBilgileri";
            this.grbServisBilgileri.Size = new System.Drawing.Size(419, 97);
            this.grbServisBilgileri.TabIndex = 138;
            this.grbServisBilgileri.TabStop = false;
            this.grbServisBilgileri.Text = "Servis Bilgileri";
            // 
            // txtKalkisYeri
            // 
            this.txtKalkisYeri.Location = new System.Drawing.Point(103, 55);
            this.txtKalkisYeri.Name = "txtKalkisYeri";
            this.txtKalkisYeri.Size = new System.Drawing.Size(130, 21);
            this.txtKalkisYeri.TabIndex = 133;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 123;
            this.label8.Text = "Kalkış Saati :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 123;
            this.label7.Text = "Kalkış Yeri :";
            // 
            // txtServisSaati
            // 
            this.txtServisSaati.Location = new System.Drawing.Point(344, 55);
            this.txtServisSaati.Mask = "90:00";
            this.txtServisSaati.Name = "txtServisSaati";
            this.txtServisSaati.Size = new System.Drawing.Size(69, 21);
            this.txtServisSaati.TabIndex = 130;
            this.txtServisSaati.ValidatingType = typeof(System.DateTime);
            // 
            // numServisUcreti
            // 
            this.numServisUcreti.Location = new System.Drawing.Point(344, 27);
            this.numServisUcreti.Name = "numServisUcreti";
            this.numServisUcreti.Size = new System.Drawing.Size(69, 21);
            this.numServisUcreti.TabIndex = 131;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 122;
            this.label9.Text = "Servis Ücreti :";
            // 
            // chkServisEkle
            // 
            this.chkServisEkle.AutoSize = true;
            this.chkServisEkle.Location = new System.Drawing.Point(18, 316);
            this.chkServisEkle.Name = "chkServisEkle";
            this.chkServisEkle.Size = new System.Drawing.Size(105, 19);
            this.chkServisEkle.TabIndex = 139;
            this.chkServisEkle.Text = "Servis Ekle :";
            this.chkServisEkle.UseVisualStyleBackColor = true;
            this.chkServisEkle.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmSeferDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(987, 545);
            this.Controls.Add(this.chkServisEkle);
            this.Controls.Add(this.grbServisBilgileri);
            this.Controls.Add(this.dtpSeferTarihi);
            this.Controls.Add(this.btnPersonelTemizle);
            this.Controls.Add(this.btnPersonelSil);
            this.Controls.Add(this.btnPersonelEkle);
            this.Controls.Add(this.lstSeferPersonelleri);
            this.Controls.Add(this.cmbOtobus);
            this.Controls.Add(this.numSeferUcreti);
            this.Controls.Add(this.txtSeferSaati);
            this.Controls.Add(this.cmbSefer);
            this.Controls.Add(this.cmbSeferPersonel);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgvSeferDetaylar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmSeferDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sefer Detayları";
            this.Load += new System.EventHandler(this.frmSeferDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferDetaylar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeferUcreti)).EndInit();
            this.grbServisBilgileri.ResumeLayout(false);
            this.grbServisBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServisUcreti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSeferDetaylar;
        private System.Windows.Forms.Button btnPersonelTemizle;
        private System.Windows.Forms.Button btnPersonelSil;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.ListBox lstSeferPersonelleri;
        private System.Windows.Forms.ComboBox cmbOtobus;
        private System.Windows.Forms.NumericUpDown numSeferUcreti;
        private System.Windows.Forms.MaskedTextBox txtSeferSaati;
        private System.Windows.Forms.ComboBox cmbSeferPersonel;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DateTimePicker dtpSeferTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSefer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbServisAracı;
        private System.Windows.Forms.GroupBox grbServisBilgileri;
        private System.Windows.Forms.TextBox txtKalkisYeri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtServisSaati;
        private System.Windows.Forms.NumericUpDown numServisUcreti;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkServisEkle;
    }
}