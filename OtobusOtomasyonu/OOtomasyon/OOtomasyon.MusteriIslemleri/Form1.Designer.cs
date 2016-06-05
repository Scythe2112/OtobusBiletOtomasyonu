namespace OOtomasyon.MusteriIslemleri
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
            this.dgvMusteri = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtCepTel = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.grbMusteriKarti = new System.Windows.Forms.GroupBox();
            this.grbCinsiyet = new System.Windows.Forms.GroupBox();
            this.rbBayan = new System.Windows.Forms.RadioButton();
            this.rbBay = new System.Windows.Forms.RadioButton();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.lblBonusPara = new System.Windows.Forms.Label();
            this.lblBonusBilet = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteri)).BeginInit();
            this.grbMusteriKarti.SuspendLayout();
            this.grbCinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMusteri
            // 
            this.dgvMusteri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteri.Location = new System.Drawing.Point(154, 330);
            this.dgvMusteri.Name = "dgvMusteri";
            this.dgvMusteri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusteri.Size = new System.Drawing.Size(874, 311);
            this.dgvMusteri.TabIndex = 72;
            this.dgvMusteri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMusteri_CellClick);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListele.Location = new System.Drawing.Point(445, 248);
            this.btnListele.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 64);
            this.btnListele.TabIndex = 70;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuncelle.Location = new System.Drawing.Point(348, 248);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 64);
            this.btnGuncelle.TabIndex = 69;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSil.Location = new System.Drawing.Point(251, 248);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 64);
            this.btnSil.TabIndex = 68;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 298);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 14);
            this.label14.TabIndex = 67;
            this.label14.Text = "*  gerekli alanlar";
            // 
            // cmbSehir
            // 
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Location = new System.Drawing.Point(689, 87);
            this.cmbSehir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(341, 22);
            this.cmbSehir.TabIndex = 64;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(154, 127);
            this.dtpDogumTarihi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(339, 22);
            this.dtpDogumTarihi.TabIndex = 62;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 95);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 14);
            this.label13.TabIndex = 60;
            this.label13.Text = "TC Kimlik* :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(535, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 14);
            this.label8.TabIndex = 58;
            this.label8.Text = "Cep Tel* :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(535, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 14);
            this.label7.TabIndex = 56;
            this.label7.Text = "Memleket* :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 14);
            this.label2.TabIndex = 55;
            this.label2.Text = "Soyad* :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(535, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 14);
            this.label6.TabIndex = 52;
            this.label6.Text = "E-Posta :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 14);
            this.label3.TabIndex = 61;
            this.label3.Text = "Doğum Tarihi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 50;
            this.label1.Text = "Ad* :";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(154, 87);
            this.txtTc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(339, 22);
            this.txtTc.TabIndex = 49;
            // 
            // txtCepTel
            // 
            this.txtCepTel.Location = new System.Drawing.Point(689, 51);
            this.txtCepTel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCepTel.Name = "txtCepTel";
            this.txtCepTel.Size = new System.Drawing.Size(339, 22);
            this.txtCepTel.TabIndex = 47;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(154, 46);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(339, 22);
            this.txtSoyad.TabIndex = 44;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(154, 12);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(339, 22);
            this.txtAd.TabIndex = 43;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEkle.Location = new System.Drawing.Point(154, 248);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 64);
            this.btnEkle.TabIndex = 42;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // grbMusteriKarti
            // 
            this.grbMusteriKarti.Controls.Add(this.label10);
            this.grbMusteriKarti.Controls.Add(this.label9);
            this.grbMusteriKarti.Controls.Add(this.lblBonusBilet);
            this.grbMusteriKarti.Controls.Add(this.lblBonusPara);
            this.grbMusteriKarti.Location = new System.Drawing.Point(689, 222);
            this.grbMusteriKarti.Name = "grbMusteriKarti";
            this.grbMusteriKarti.Size = new System.Drawing.Size(339, 90);
            this.grbMusteriKarti.TabIndex = 71;
            this.grbMusteriKarti.TabStop = false;
            this.grbMusteriKarti.Text = "Müşteri Kartı";
            // 
            // grbCinsiyet
            // 
            this.grbCinsiyet.Controls.Add(this.rbBay);
            this.grbCinsiyet.Controls.Add(this.rbBayan);
            this.grbCinsiyet.Location = new System.Drawing.Point(689, 127);
            this.grbCinsiyet.Name = "grbCinsiyet";
            this.grbCinsiyet.Size = new System.Drawing.Size(339, 68);
            this.grbCinsiyet.TabIndex = 73;
            this.grbCinsiyet.TabStop = false;
            this.grbCinsiyet.Text = "Cinsiyet";
            // 
            // rbBayan
            // 
            this.rbBayan.AutoSize = true;
            this.rbBayan.Location = new System.Drawing.Point(6, 30);
            this.rbBayan.Name = "rbBayan";
            this.rbBayan.Size = new System.Drawing.Size(66, 18);
            this.rbBayan.TabIndex = 0;
            this.rbBayan.TabStop = true;
            this.rbBayan.Text = "Bayan";
            this.rbBayan.UseVisualStyleBackColor = true;
            // 
            // rbBay
            // 
            this.rbBay.AutoSize = true;
            this.rbBay.Location = new System.Drawing.Point(222, 30);
            this.rbBay.Name = "rbBay";
            this.rbBay.Size = new System.Drawing.Size(50, 18);
            this.rbBay.TabIndex = 0;
            this.rbBay.TabStop = true;
            this.rbBay.Text = "Bay";
            this.rbBay.UseVisualStyleBackColor = true;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(689, 11);
            this.txtEposta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(339, 22);
            this.txtEposta.TabIndex = 46;
            // 
            // lblBonusPara
            // 
            this.lblBonusPara.ForeColor = System.Drawing.Color.Red;
            this.lblBonusPara.Location = new System.Drawing.Point(219, 26);
            this.lblBonusPara.Name = "lblBonusPara";
            this.lblBonusPara.Size = new System.Drawing.Size(100, 13);
            this.lblBonusPara.TabIndex = 0;
            // 
            // lblBonusBilet
            // 
            this.lblBonusBilet.ForeColor = System.Drawing.Color.Red;
            this.lblBonusBilet.Location = new System.Drawing.Point(219, 54);
            this.lblBonusBilet.Name = "lblBonusBilet";
            this.lblBonusBilet.Size = new System.Drawing.Size(100, 14);
            this.lblBonusBilet.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 14);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bonus Bilet:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 14);
            this.label10.TabIndex = 0;
            this.label10.Text = "Bonus Para:";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(542, 248);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 64);
            this.btnTemizle.TabIndex = 74;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1044, 651);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.grbCinsiyet);
            this.Controls.Add(this.dgvMusteri);
            this.Controls.Add(this.grbMusteriKarti);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbSehir);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtCepTel);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnEkle);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1060, 690);
            this.MinimumSize = new System.Drawing.Size(1060, 640);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteri)).EndInit();
            this.grbMusteriKarti.ResumeLayout(false);
            this.grbMusteriKarti.PerformLayout();
            this.grbCinsiyet.ResumeLayout(false);
            this.grbCinsiyet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMusteri;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtCepTel;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox grbMusteriKarti;
        private System.Windows.Forms.GroupBox grbCinsiyet;
        private System.Windows.Forms.RadioButton rbBay;
        private System.Windows.Forms.RadioButton rbBayan;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBonusBilet;
        private System.Windows.Forms.Label lblBonusPara;
        private System.Windows.Forms.Button btnTemizle;
    }
}

