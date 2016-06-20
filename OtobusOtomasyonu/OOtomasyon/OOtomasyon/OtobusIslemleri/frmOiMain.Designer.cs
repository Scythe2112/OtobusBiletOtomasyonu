namespace OOtomasyon.OtobusIslemleri
{
    partial class frmOiMain
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
            this.btnTemizle = new System.Windows.Forms.Button();
            this.dgvOtobusler = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.cmbSube = new System.Windows.Forms.ComboBox();
            this.numKoltukSayisi = new System.Windows.Forms.NumericUpDown();
            this.cmbOtobusTipi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOtobusDurumu = new System.Windows.Forms.ComboBox();
            this.grbOtobusOzellikleri = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtobusler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKoltukSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(430, 369);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(76, 69);
            this.btnTemizle.TabIndex = 92;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // dgvOtobusler
            // 
            this.dgvOtobusler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOtobusler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOtobusler.Location = new System.Drawing.Point(515, 10);
            this.dgvOtobusler.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvOtobusler.Name = "dgvOtobusler";
            this.dgvOtobusler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOtobusler.Size = new System.Drawing.Size(495, 428);
            this.dgvOtobusler.TabIndex = 91;
            this.dgvOtobusler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOtobusler_CellClick);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListele.Location = new System.Drawing.Point(327, 369);
            this.btnListele.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(76, 69);
            this.btnListele.TabIndex = 90;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuncelle.Location = new System.Drawing.Point(224, 369);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(76, 69);
            this.btnGuncelle.TabIndex = 89;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSil.Location = new System.Drawing.Point(121, 369);
            this.btnSil.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(76, 69);
            this.btnSil.TabIndex = 88;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 14);
            this.label3.TabIndex = 84;
            this.label3.Text = "Koltuk Sayısı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 81;
            this.label2.Text = "Şube :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 14);
            this.label4.TabIndex = 85;
            this.label4.Text = "Otobüs Tipi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 79;
            this.label1.Text = "Plaka :";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEkle.Location = new System.Drawing.Point(18, 369);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(76, 69);
            this.btnEkle.TabIndex = 75;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(191, 10);
            this.txtPlaka.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(315, 22);
            this.txtPlaka.TabIndex = 76;
            // 
            // cmbSube
            // 
            this.cmbSube.FormattingEnabled = true;
            this.cmbSube.Location = new System.Drawing.Point(191, 47);
            this.cmbSube.Name = "cmbSube";
            this.cmbSube.Size = new System.Drawing.Size(315, 22);
            this.cmbSube.TabIndex = 94;
            // 
            // numKoltukSayisi
            // 
            this.numKoltukSayisi.Location = new System.Drawing.Point(191, 92);
            this.numKoltukSayisi.Name = "numKoltukSayisi";
            this.numKoltukSayisi.Size = new System.Drawing.Size(315, 22);
            this.numKoltukSayisi.TabIndex = 95;
            // 
            // cmbOtobusTipi
            // 
            this.cmbOtobusTipi.FormattingEnabled = true;
            this.cmbOtobusTipi.Location = new System.Drawing.Point(191, 132);
            this.cmbOtobusTipi.Name = "cmbOtobusTipi";
            this.cmbOtobusTipi.Size = new System.Drawing.Size(315, 22);
            this.cmbOtobusTipi.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 14);
            this.label5.TabIndex = 85;
            this.label5.Text = "Otobüs Durumu:";
            // 
            // cmbOtobusDurumu
            // 
            this.cmbOtobusDurumu.FormattingEnabled = true;
            this.cmbOtobusDurumu.Location = new System.Drawing.Point(191, 180);
            this.cmbOtobusDurumu.Name = "cmbOtobusDurumu";
            this.cmbOtobusDurumu.Size = new System.Drawing.Size(315, 22);
            this.cmbOtobusDurumu.TabIndex = 94;
            // 
            // grbOtobusOzellikleri
            // 
            this.grbOtobusOzellikleri.Location = new System.Drawing.Point(191, 221);
            this.grbOtobusOzellikleri.Name = "grbOtobusOzellikleri";
            this.grbOtobusOzellikleri.Size = new System.Drawing.Size(315, 142);
            this.grbOtobusOzellikleri.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 221);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 14);
            this.label6.TabIndex = 85;
            this.label6.Text = "Otobüs Özellikleri:";
            // 
            // frmOiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.grbOtobusOzellikleri);
            this.Controls.Add(this.numKoltukSayisi);
            this.Controls.Add(this.cmbOtobusDurumu);
            this.Controls.Add(this.cmbOtobusTipi);
            this.Controls.Add(this.cmbSube);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.dgvOtobusler);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.btnEkle);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmOiMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otobüs İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtobusler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKoltukSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dgvOtobusler;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.ComboBox cmbSube;
        private System.Windows.Forms.NumericUpDown numKoltukSayisi;
        private System.Windows.Forms.ComboBox cmbOtobusTipi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOtobusDurumu;
        private System.Windows.Forms.FlowLayoutPanel grbOtobusOzellikleri;
        private System.Windows.Forms.Label label6;
    }
}

