namespace OOtomasyon.SubeIslemleri
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
            this.btnTemizle = new System.Windows.Forms.Button();
            this.dgvSubeler = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.cmbGuzergah = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtSubeAdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubeler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(453, 352);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(76, 69);
            this.btnTemizle.TabIndex = 67;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // dgvSubeler
            // 
            this.dgvSubeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubeler.Location = new System.Drawing.Point(550, 15);
            this.dgvSubeler.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvSubeler.Name = "dgvSubeler";
            this.dgvSubeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubeler.Size = new System.Drawing.Size(461, 411);
            this.dgvSubeler.TabIndex = 66;
            this.dgvSubeler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubeler_CellClick);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListele.Location = new System.Drawing.Point(345, 352);
            this.btnListele.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(76, 69);
            this.btnListele.TabIndex = 65;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuncelle.Location = new System.Drawing.Point(237, 352);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(76, 69);
            this.btnGuncelle.TabIndex = 64;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSil.Location = new System.Drawing.Point(129, 352);
            this.btnSil.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(76, 69);
            this.btnSil.TabIndex = 63;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cmbGuzergah
            // 
            this.cmbGuzergah.FormattingEnabled = true;
            this.cmbGuzergah.Location = new System.Drawing.Point(190, 52);
            this.cmbGuzergah.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cmbGuzergah.Name = "cmbGuzergah";
            this.cmbGuzergah.Size = new System.Drawing.Size(340, 22);
            this.cmbGuzergah.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 135);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 14);
            this.label13.TabIndex = 58;
            this.label13.Text = "Fax :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 98);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 14);
            this.label11.TabIndex = 52;
            this.label11.Text = "Telefon  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 172);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 14);
            this.label9.TabIndex = 51;
            this.label9.Text = "Adres :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 48;
            this.label1.Text = "Şube Adı :";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(190, 172);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(340, 135);
            this.txtAdres.TabIndex = 46;
            // 
            // txtSubeAdi
            // 
            this.txtSubeAdi.Location = new System.Drawing.Point(190, 15);
            this.txtSubeAdi.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtSubeAdi.Name = "txtSubeAdi";
            this.txtSubeAdi.Size = new System.Drawing.Size(340, 22);
            this.txtSubeAdi.TabIndex = 44;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEkle.Location = new System.Drawing.Point(21, 352);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(76, 69);
            this.btnEkle.TabIndex = 43;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 14);
            this.label2.TabIndex = 53;
            this.label2.Text = "Şube Güzergahı :";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(190, 90);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(340, 22);
            this.txtTelefon.TabIndex = 68;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(190, 127);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(340, 22);
            this.txtFax.TabIndex = 68;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 461);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.dgvSubeler);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.cmbGuzergah);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtSubeAdi);
            this.Controls.Add(this.btnEkle);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şube İşlemleri";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dgvSubeler;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox cmbGuzergah;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtSubeAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtFax;
    }
}

