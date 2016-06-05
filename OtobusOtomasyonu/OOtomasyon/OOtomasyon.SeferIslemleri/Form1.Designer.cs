namespace OOtomasyon.SeferIslemleri
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
            this.numTahminiVarisSuresi = new System.Windows.Forms.NumericUpDown();
            this.cmbSeferTipi = new System.Windows.Forms.ComboBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.dgvSeferler = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dtpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSeferSaati = new System.Windows.Forms.MaskedTextBox();
            this.numSeferUcreti = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbGuzergah = new System.Windows.Forms.ComboBox();
            this.lstSeferGuzergahi = new System.Windows.Forms.ListBox();
            this.btnGuzergahEkle = new System.Windows.Forms.Button();
            this.btnGuzergahSil = new System.Windows.Forms.Button();
            this.btnGuzergahTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTahminiVarisSuresi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeferUcreti)).BeginInit();
            this.SuspendLayout();
            // 
            // numTahminiVarisSuresi
            // 
            this.numTahminiVarisSuresi.Location = new System.Drawing.Point(190, 104);
            this.numTahminiVarisSuresi.Name = "numTahminiVarisSuresi";
            this.numTahminiVarisSuresi.Size = new System.Drawing.Size(315, 22);
            this.numTahminiVarisSuresi.TabIndex = 113;
            // 
            // cmbSeferTipi
            // 
            this.cmbSeferTipi.FormattingEnabled = true;
            this.cmbSeferTipi.Location = new System.Drawing.Point(190, 144);
            this.cmbSeferTipi.Name = "cmbSeferTipi";
            this.cmbSeferTipi.Size = new System.Drawing.Size(315, 22);
            this.cmbSeferTipi.TabIndex = 111;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(429, 417);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(76, 69);
            this.btnTemizle.TabIndex = 109;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // dgvSeferler
            // 
            this.dgvSeferler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeferler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeferler.Location = new System.Drawing.Point(514, 22);
            this.dgvSeferler.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvSeferler.Name = "dgvSeferler";
            this.dgvSeferler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeferler.Size = new System.Drawing.Size(428, 464);
            this.dgvSeferler.TabIndex = 108;
            this.dgvSeferler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeferler_CellClick);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListele.Location = new System.Drawing.Point(326, 417);
            this.btnListele.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(76, 69);
            this.btnListele.TabIndex = 107;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuncelle.Location = new System.Drawing.Point(223, 417);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(76, 69);
            this.btnGuncelle.TabIndex = 106;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSil.Location = new System.Drawing.Point(120, 417);
            this.btnSil.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(76, 69);
            this.btnSil.TabIndex = 105;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 14);
            this.label3.TabIndex = 101;
            this.label3.Text = "Tahmini Varış Süresi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 14);
            this.label2.TabIndex = 100;
            this.label2.Text = "Bitiş Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 14);
            this.label4.TabIndex = 102;
            this.label4.Text = "Sefer Tipi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 14);
            this.label1.TabIndex = 99;
            this.label1.Text = "Başlangıç Tarihi :";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEkle.Location = new System.Drawing.Point(17, 417);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(76, 69);
            this.btnEkle.TabIndex = 97;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dtpBaslangicTarihi
            // 
            this.dtpBaslangicTarihi.Location = new System.Drawing.Point(190, 22);
            this.dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            this.dtpBaslangicTarihi.Size = new System.Drawing.Size(315, 22);
            this.dtpBaslangicTarihi.TabIndex = 114;
            // 
            // dtpBitisTarihi
            // 
            this.dtpBitisTarihi.Location = new System.Drawing.Point(190, 59);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.Size = new System.Drawing.Size(315, 22);
            this.dtpBitisTarihi.TabIndex = 114;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 14);
            this.label5.TabIndex = 102;
            this.label5.Text = "Sefer Saati :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 14);
            this.label6.TabIndex = 102;
            this.label6.Text = "Sefer Ücreti :";
            // 
            // txtSeferSaati
            // 
            this.txtSeferSaati.Location = new System.Drawing.Point(190, 181);
            this.txtSeferSaati.Mask = "90:00";
            this.txtSeferSaati.Name = "txtSeferSaati";
            this.txtSeferSaati.Size = new System.Drawing.Size(315, 22);
            this.txtSeferSaati.TabIndex = 115;
            this.txtSeferSaati.ValidatingType = typeof(System.DateTime);
            // 
            // numSeferUcreti
            // 
            this.numSeferUcreti.Location = new System.Drawing.Point(190, 218);
            this.numSeferUcreti.Name = "numSeferUcreti";
            this.numSeferUcreti.Size = new System.Drawing.Size(315, 22);
            this.numSeferUcreti.TabIndex = 116;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 260);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 14);
            this.label7.TabIndex = 102;
            this.label7.Text = "Sefer Güzergahı :";
            // 
            // cmbGuzergah
            // 
            this.cmbGuzergah.FormattingEnabled = true;
            this.cmbGuzergah.Location = new System.Drawing.Point(190, 252);
            this.cmbGuzergah.Name = "cmbGuzergah";
            this.cmbGuzergah.Size = new System.Drawing.Size(315, 22);
            this.cmbGuzergah.TabIndex = 117;
            // 
            // lstSeferGuzergahi
            // 
            this.lstSeferGuzergahi.FormattingEnabled = true;
            this.lstSeferGuzergahi.ItemHeight = 14;
            this.lstSeferGuzergahi.Location = new System.Drawing.Point(190, 281);
            this.lstSeferGuzergahi.Name = "lstSeferGuzergahi";
            this.lstSeferGuzergahi.Size = new System.Drawing.Size(315, 130);
            this.lstSeferGuzergahi.TabIndex = 118;
            // 
            // btnGuzergahEkle
            // 
            this.btnGuzergahEkle.Location = new System.Drawing.Point(17, 281);
            this.btnGuzergahEkle.Name = "btnGuzergahEkle";
            this.btnGuzergahEkle.Size = new System.Drawing.Size(83, 22);
            this.btnGuzergahEkle.TabIndex = 119;
            this.btnGuzergahEkle.Text = "Ekle";
            this.btnGuzergahEkle.UseVisualStyleBackColor = true;
            this.btnGuzergahEkle.Click += new System.EventHandler(this.btnGuzergahEkle_Click);
            // 
            // btnGuzergahSil
            // 
            this.btnGuzergahSil.Location = new System.Drawing.Point(17, 309);
            this.btnGuzergahSil.Name = "btnGuzergahSil";
            this.btnGuzergahSil.Size = new System.Drawing.Size(83, 22);
            this.btnGuzergahSil.TabIndex = 119;
            this.btnGuzergahSil.Text = "Sil";
            this.btnGuzergahSil.UseVisualStyleBackColor = true;
            this.btnGuzergahSil.Click += new System.EventHandler(this.btnGuzergahSil_Click);
            // 
            // btnGuzergahTemizle
            // 
            this.btnGuzergahTemizle.Location = new System.Drawing.Point(17, 337);
            this.btnGuzergahTemizle.Name = "btnGuzergahTemizle";
            this.btnGuzergahTemizle.Size = new System.Drawing.Size(83, 22);
            this.btnGuzergahTemizle.TabIndex = 119;
            this.btnGuzergahTemizle.Text = "Temizle";
            this.btnGuzergahTemizle.UseVisualStyleBackColor = true;
            this.btnGuzergahTemizle.Click += new System.EventHandler(this.btnGuzergahTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(955, 505);
            this.Controls.Add(this.btnGuzergahTemizle);
            this.Controls.Add(this.btnGuzergahSil);
            this.Controls.Add(this.btnGuzergahEkle);
            this.Controls.Add(this.lstSeferGuzergahi);
            this.Controls.Add(this.cmbGuzergah);
            this.Controls.Add(this.numSeferUcreti);
            this.Controls.Add(this.txtSeferSaati);
            this.Controls.Add(this.dtpBitisTarihi);
            this.Controls.Add(this.dtpBaslangicTarihi);
            this.Controls.Add(this.numTahminiVarisSuresi);
            this.Controls.Add(this.cmbSeferTipi);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.dgvSeferler);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sefer İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTahminiVarisSuresi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeferUcreti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numTahminiVarisSuresi;
        private System.Windows.Forms.ComboBox cmbSeferTipi;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dgvSeferler;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DateTimePicker dtpBaslangicTarihi;
        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtSeferSaati;
        private System.Windows.Forms.NumericUpDown numSeferUcreti;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGuzergah;
        private System.Windows.Forms.ListBox lstSeferGuzergahi;
        private System.Windows.Forms.Button btnGuzergahEkle;
        private System.Windows.Forms.Button btnGuzergahSil;
        private System.Windows.Forms.Button btnGuzergahTemizle;
    }
}

