namespace OOtomasyon.PromosyonIslemleri
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
            this.dgvPromosyon = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dtpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.cmbPromosyonTipi = new System.Windows.Forms.ComboBox();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.nmPromosyonMiktari = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromosyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPromosyonMiktari)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPromosyon
            // 
            this.dgvPromosyon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPromosyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromosyon.Location = new System.Drawing.Point(498, 28);
            this.dgvPromosyon.Name = "dgvPromosyon";
            this.dgvPromosyon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPromosyon.Size = new System.Drawing.Size(455, 233);
            this.dgvPromosyon.TabIndex = 85;
            this.dgvPromosyon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPromosyon_CellClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuncelle.Location = new System.Drawing.Point(210, 197);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 64);
            this.btnGuncelle.TabIndex = 84;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSil.Location = new System.Drawing.Point(114, 197);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 64);
            this.btnSil.TabIndex = 83;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dtpBaslangicTarihi
            // 
            this.dtpBaslangicTarihi.Location = new System.Drawing.Point(160, 65);
            this.dtpBaslangicTarihi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            this.dtpBaslangicTarihi.Size = new System.Drawing.Size(302, 22);
            this.dtpBaslangicTarihi.TabIndex = 81;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 111);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 14);
            this.label13.TabIndex = 79;
            this.label13.Text = "Bitiş Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 14);
            this.label2.TabIndex = 78;
            this.label2.Text = "Başlangıç Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 14);
            this.label3.TabIndex = 80;
            this.label3.Text = "Promosyon Miktarı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 14);
            this.label1.TabIndex = 77;
            this.label1.Text = "Promosyon Tipi :";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEkle.Location = new System.Drawing.Point(18, 197);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 64);
            this.btnEkle.TabIndex = 73;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(402, 197);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 64);
            this.btnTemizle.TabIndex = 87;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListele.Location = new System.Drawing.Point(306, 197);
            this.btnListele.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 64);
            this.btnListele.TabIndex = 86;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // cmbPromosyonTipi
            // 
            this.cmbPromosyonTipi.FormattingEnabled = true;
            this.cmbPromosyonTipi.Location = new System.Drawing.Point(160, 27);
            this.cmbPromosyonTipi.Name = "cmbPromosyonTipi";
            this.cmbPromosyonTipi.Size = new System.Drawing.Size(302, 22);
            this.cmbPromosyonTipi.TabIndex = 88;
            // 
            // dtpBitisTarihi
            // 
            this.dtpBitisTarihi.Location = new System.Drawing.Point(160, 103);
            this.dtpBitisTarihi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.Size = new System.Drawing.Size(302, 22);
            this.dtpBitisTarihi.TabIndex = 81;
            // 
            // nmPromosyonMiktari
            // 
            this.nmPromosyonMiktari.Location = new System.Drawing.Point(160, 141);
            this.nmPromosyonMiktari.Name = "nmPromosyonMiktari";
            this.nmPromosyonMiktari.Size = new System.Drawing.Size(120, 22);
            this.nmPromosyonMiktari.TabIndex = 89;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(965, 453);
            this.Controls.Add(this.nmPromosyonMiktari);
            this.Controls.Add(this.cmbPromosyonTipi);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dgvPromosyon);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dtpBitisTarihi);
            this.Controls.Add(this.dtpBaslangicTarihi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(981, 492);
            this.MinimumSize = new System.Drawing.Size(981, 492);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promosyon İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromosyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPromosyonMiktari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPromosyon;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DateTimePicker dtpBaslangicTarihi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ComboBox cmbPromosyonTipi;
        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
        private System.Windows.Forms.NumericUpDown nmPromosyonMiktari;
    }
}

