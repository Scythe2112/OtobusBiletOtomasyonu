namespace OOtomasyon.MuhasebeIslemleri
{
    partial class frmMuiMain
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
            this.gbHarcamalar = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numHarcamaUcreti = new System.Windows.Forms.NumericUpDown();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.cmbHarcamaTipleri2 = new System.Windows.Forms.ComboBox();
            this.cmbSeferDetay = new System.Windows.Forms.ComboBox();
            this.cmbSefer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbHarcamaTipleri = new System.Windows.Forms.GroupBox();
            this.cmbHarcamaTipleri = new System.Windows.Forms.ComboBox();
            this.btnHarcamaTipiGuncelle = new System.Windows.Forms.Button();
            this.btnHarcamaTipiSil = new System.Windows.Forms.Button();
            this.btnHarcamaTipiEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHarcamaTipi = new System.Windows.Forms.TextBox();
            this.gbSeferHarcamaları = new System.Windows.Forms.GroupBox();
            this.dgvSeferDetayHarcamalari = new System.Windows.Forms.DataGridView();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.gbHarcamalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHarcamaUcreti)).BeginInit();
            this.gbHarcamaTipleri.SuspendLayout();
            this.gbSeferHarcamaları.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferDetayHarcamalari)).BeginInit();
            this.SuspendLayout();
            // 
            // gbHarcamalar
            // 
            this.gbHarcamalar.Controls.Add(this.button2);
            this.gbHarcamalar.Controls.Add(this.button1);
            this.gbHarcamalar.Controls.Add(this.numHarcamaUcreti);
            this.gbHarcamalar.Controls.Add(this.txtAciklama);
            this.gbHarcamalar.Controls.Add(this.cmbHarcamaTipleri2);
            this.gbHarcamalar.Controls.Add(this.cmbSeferDetay);
            this.gbHarcamalar.Controls.Add(this.cmbSefer);
            this.gbHarcamalar.Controls.Add(this.label4);
            this.gbHarcamalar.Controls.Add(this.label3);
            this.gbHarcamalar.Controls.Add(this.label2);
            this.gbHarcamalar.Controls.Add(this.label6);
            this.gbHarcamalar.Controls.Add(this.label5);
            this.gbHarcamalar.Location = new System.Drawing.Point(13, 13);
            this.gbHarcamalar.Name = "gbHarcamalar";
            this.gbHarcamalar.Size = new System.Drawing.Size(401, 404);
            this.gbHarcamalar.TabIndex = 0;
            this.gbHarcamalar.TabStop = false;
            this.gbHarcamalar.Text = "Harcamalar";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "Harcama Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Harcamaları Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numHarcamaUcreti
            // 
            this.numHarcamaUcreti.Location = new System.Drawing.Point(137, 147);
            this.numHarcamaUcreti.Name = "numHarcamaUcreti";
            this.numHarcamaUcreti.Size = new System.Drawing.Size(233, 22);
            this.numHarcamaUcreti.TabIndex = 10;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(137, 196);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(233, 140);
            this.txtAciklama.TabIndex = 9;
            // 
            // cmbHarcamaTipleri2
            // 
            this.cmbHarcamaTipleri2.FormattingEnabled = true;
            this.cmbHarcamaTipleri2.Location = new System.Drawing.Point(137, 108);
            this.cmbHarcamaTipleri2.Name = "cmbHarcamaTipleri2";
            this.cmbHarcamaTipleri2.Size = new System.Drawing.Size(233, 22);
            this.cmbHarcamaTipleri2.TabIndex = 7;
            // 
            // cmbSeferDetay
            // 
            this.cmbSeferDetay.FormattingEnabled = true;
            this.cmbSeferDetay.Location = new System.Drawing.Point(137, 65);
            this.cmbSeferDetay.Name = "cmbSeferDetay";
            this.cmbSeferDetay.Size = new System.Drawing.Size(233, 22);
            this.cmbSeferDetay.TabIndex = 8;
            // 
            // cmbSefer
            // 
            this.cmbSefer.FormattingEnabled = true;
            this.cmbSefer.Location = new System.Drawing.Point(137, 26);
            this.cmbSefer.Name = "cmbSefer";
            this.cmbSefer.Size = new System.Drawing.Size(233, 22);
            this.cmbSefer.TabIndex = 8;
            this.cmbSefer.SelectedIndexChanged += new System.EventHandler(this.cmbSefer_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Açıklama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Harcama Ücreti :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Harcama Tipi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sefer Detay :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sefer :";
            // 
            // gbHarcamaTipleri
            // 
            this.gbHarcamaTipleri.Controls.Add(this.cmbHarcamaTipleri);
            this.gbHarcamaTipleri.Controls.Add(this.btnHarcamaTipiGuncelle);
            this.gbHarcamaTipleri.Controls.Add(this.btnHarcamaTipiSil);
            this.gbHarcamaTipleri.Controls.Add(this.btnHarcamaTipiEkle);
            this.gbHarcamaTipleri.Controls.Add(this.label1);
            this.gbHarcamaTipleri.Controls.Add(this.txtHarcamaTipi);
            this.gbHarcamaTipleri.Location = new System.Drawing.Point(464, 13);
            this.gbHarcamaTipleri.Name = "gbHarcamaTipleri";
            this.gbHarcamaTipleri.Size = new System.Drawing.Size(390, 117);
            this.gbHarcamaTipleri.TabIndex = 0;
            this.gbHarcamaTipleri.TabStop = false;
            this.gbHarcamaTipleri.Text = "Harcama Tipleri";
            // 
            // cmbHarcamaTipleri
            // 
            this.cmbHarcamaTipleri.FormattingEnabled = true;
            this.cmbHarcamaTipleri.Location = new System.Drawing.Point(9, 21);
            this.cmbHarcamaTipleri.Name = "cmbHarcamaTipleri";
            this.cmbHarcamaTipleri.Size = new System.Drawing.Size(267, 22);
            this.cmbHarcamaTipleri.TabIndex = 9;
            // 
            // btnHarcamaTipiGuncelle
            // 
            this.btnHarcamaTipiGuncelle.Location = new System.Drawing.Point(282, 73);
            this.btnHarcamaTipiGuncelle.Name = "btnHarcamaTipiGuncelle";
            this.btnHarcamaTipiGuncelle.Size = new System.Drawing.Size(86, 24);
            this.btnHarcamaTipiGuncelle.TabIndex = 6;
            this.btnHarcamaTipiGuncelle.Text = "GÜNCELLE";
            this.btnHarcamaTipiGuncelle.UseVisualStyleBackColor = true;
            this.btnHarcamaTipiGuncelle.Click += new System.EventHandler(this.btnHarcamaTipiGuncelle_Click);
            // 
            // btnHarcamaTipiSil
            // 
            this.btnHarcamaTipiSil.Location = new System.Drawing.Point(282, 45);
            this.btnHarcamaTipiSil.Name = "btnHarcamaTipiSil";
            this.btnHarcamaTipiSil.Size = new System.Drawing.Size(86, 24);
            this.btnHarcamaTipiSil.TabIndex = 7;
            this.btnHarcamaTipiSil.Text = "SİL";
            this.btnHarcamaTipiSil.UseVisualStyleBackColor = true;
            this.btnHarcamaTipiSil.Click += new System.EventHandler(this.btnHarcamaTipiSil_Click);
            // 
            // btnHarcamaTipiEkle
            // 
            this.btnHarcamaTipiEkle.Location = new System.Drawing.Point(282, 18);
            this.btnHarcamaTipiEkle.Name = "btnHarcamaTipiEkle";
            this.btnHarcamaTipiEkle.Size = new System.Drawing.Size(86, 24);
            this.btnHarcamaTipiEkle.TabIndex = 8;
            this.btnHarcamaTipiEkle.Text = "EKLE";
            this.btnHarcamaTipiEkle.UseVisualStyleBackColor = true;
            this.btnHarcamaTipiEkle.Click += new System.EventHandler(this.btnHarcamaTipiEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Harcama Tipi :";
            // 
            // txtHarcamaTipi
            // 
            this.txtHarcamaTipi.Location = new System.Drawing.Point(108, 65);
            this.txtHarcamaTipi.Name = "txtHarcamaTipi";
            this.txtHarcamaTipi.Size = new System.Drawing.Size(168, 22);
            this.txtHarcamaTipi.TabIndex = 4;
            // 
            // gbSeferHarcamaları
            // 
            this.gbSeferHarcamaları.Controls.Add(this.dgvSeferDetayHarcamalari);
            this.gbSeferHarcamaları.Controls.Add(this.lblMiktar);
            this.gbSeferHarcamaları.Location = new System.Drawing.Point(464, 147);
            this.gbSeferHarcamaları.Name = "gbSeferHarcamaları";
            this.gbSeferHarcamaları.Size = new System.Drawing.Size(390, 270);
            this.gbSeferHarcamaları.TabIndex = 0;
            this.gbSeferHarcamaları.TabStop = false;
            this.gbSeferHarcamaları.Text = "Sefer Detay Harcamaları";
            // 
            // dgvSeferDetayHarcamalari
            // 
            this.dgvSeferDetayHarcamalari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeferDetayHarcamalari.Location = new System.Drawing.Point(6, 21);
            this.dgvSeferDetayHarcamalari.Name = "dgvSeferDetayHarcamalari";
            this.dgvSeferDetayHarcamalari.Size = new System.Drawing.Size(378, 218);
            this.dgvSeferDetayHarcamalari.TabIndex = 0;
            // 
            // lblMiktar
            // 
            this.lblMiktar.Location = new System.Drawing.Point(6, 245);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(378, 20);
            this.lblMiktar.TabIndex = 3;
            // 
            // frmMuiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(866, 429);
            this.Controls.Add(this.gbSeferHarcamaları);
            this.Controls.Add(this.gbHarcamaTipleri);
            this.Controls.Add(this.gbHarcamalar);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMuiMain";
            this.Text = "Muhasebe İşlemleri";
            this.Load += new System.EventHandler(this.frmMuiMain_Load);
            this.gbHarcamalar.ResumeLayout(false);
            this.gbHarcamalar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHarcamaUcreti)).EndInit();
            this.gbHarcamaTipleri.ResumeLayout(false);
            this.gbHarcamaTipleri.PerformLayout();
            this.gbSeferHarcamaları.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferDetayHarcamalari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHarcamalar;
        private System.Windows.Forms.GroupBox gbHarcamaTipleri;
        private System.Windows.Forms.GroupBox gbSeferHarcamaları;
        private System.Windows.Forms.ComboBox cmbHarcamaTipleri;
        private System.Windows.Forms.Button btnHarcamaTipiGuncelle;
        private System.Windows.Forms.Button btnHarcamaTipiSil;
        private System.Windows.Forms.Button btnHarcamaTipiEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHarcamaTipi;
        private System.Windows.Forms.NumericUpDown numHarcamaUcreti;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ComboBox cmbHarcamaTipleri2;
        private System.Windows.Forms.ComboBox cmbSeferDetay;
        private System.Windows.Forms.ComboBox cmbSefer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvSeferDetayHarcamalari;
        private System.Windows.Forms.Label lblMiktar;
    }
}