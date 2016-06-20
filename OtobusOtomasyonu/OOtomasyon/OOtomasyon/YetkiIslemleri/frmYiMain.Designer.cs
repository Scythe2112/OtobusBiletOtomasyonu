namespace OOtomasyon.YetkiIslemleri
{
    partial class frmYiMain
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
            this.btnYetkiTemizle = new System.Windows.Forms.Button();
            this.btnYetkiSil = new System.Windows.Forms.Button();
            this.btnYetkiEkle = new System.Windows.Forms.Button();
            this.cmbModul = new System.Windows.Forms.ComboBox();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labe1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lstFormlar = new System.Windows.Forms.ListBox();
            this.lstYetkiTipleri = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtForm = new System.Windows.Forms.TextBox();
            this.btnFormEkle = new System.Windows.Forms.Button();
            this.dgvYetkiler = new System.Windows.Forms.DataGridView();
            this.YetkiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YetkiTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFormAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYetkiler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYetkiTemizle
            // 
            this.btnYetkiTemizle.Location = new System.Drawing.Point(23, 233);
            this.btnYetkiTemizle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnYetkiTemizle.Name = "btnYetkiTemizle";
            this.btnYetkiTemizle.Size = new System.Drawing.Size(111, 45);
            this.btnYetkiTemizle.TabIndex = 143;
            this.btnYetkiTemizle.Text = "Temizle";
            this.btnYetkiTemizle.UseVisualStyleBackColor = true;
            this.btnYetkiTemizle.Click += new System.EventHandler(this.btnYetkiTemizle_Click);
            // 
            // btnYetkiSil
            // 
            this.btnYetkiSil.Location = new System.Drawing.Point(23, 172);
            this.btnYetkiSil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnYetkiSil.Name = "btnYetkiSil";
            this.btnYetkiSil.Size = new System.Drawing.Size(111, 45);
            this.btnYetkiSil.TabIndex = 142;
            this.btnYetkiSil.Text = "Sil";
            this.btnYetkiSil.UseVisualStyleBackColor = true;
            this.btnYetkiSil.Click += new System.EventHandler(this.btnYetkiSil_Click);
            // 
            // btnYetkiEkle
            // 
            this.btnYetkiEkle.Location = new System.Drawing.Point(23, 111);
            this.btnYetkiEkle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnYetkiEkle.Name = "btnYetkiEkle";
            this.btnYetkiEkle.Size = new System.Drawing.Size(111, 45);
            this.btnYetkiEkle.TabIndex = 141;
            this.btnYetkiEkle.Text = "Ekle";
            this.btnYetkiEkle.UseVisualStyleBackColor = true;
            this.btnYetkiEkle.Click += new System.EventHandler(this.btnYetkiEkle_Click);
            // 
            // cmbModul
            // 
            this.cmbModul.FormattingEnabled = true;
            this.cmbModul.Location = new System.Drawing.Point(142, 53);
            this.cmbModul.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbModul.Name = "cmbModul";
            this.cmbModul.Size = new System.Drawing.Size(292, 22);
            this.cmbModul.TabIndex = 139;
            this.cmbModul.SelectedIndexChanged += new System.EventHandler(this.cmbModul_SelectedIndexChanged);
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(142, 17);
            this.cmbPersonel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(292, 22);
            this.cmbPersonel.TabIndex = 133;
            this.cmbPersonel.SelectedIndexChanged += new System.EventHandler(this.cmbPersonel_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 127;
            this.label2.Text = "Modül :";
            // 
            // labe1
            // 
            this.labe1.AutoSize = true;
            this.labe1.Location = new System.Drawing.Point(19, 25);
            this.labe1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labe1.Name = "labe1";
            this.labe1.Size = new System.Drawing.Size(71, 14);
            this.labe1.TabIndex = 124;
            this.labe1.Text = "Personel :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKaydet.Location = new System.Drawing.Point(23, 294);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(111, 45);
            this.btnKaydet.TabIndex = 120;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lstFormlar
            // 
            this.lstFormlar.FormattingEnabled = true;
            this.lstFormlar.ItemHeight = 14;
            this.lstFormlar.Location = new System.Drawing.Point(600, 111);
            this.lstFormlar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstFormlar.Name = "lstFormlar";
            this.lstFormlar.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstFormlar.Size = new System.Drawing.Size(184, 228);
            this.lstFormlar.TabIndex = 140;
            // 
            // lstYetkiTipleri
            // 
            this.lstYetkiTipleri.FormattingEnabled = true;
            this.lstYetkiTipleri.ItemHeight = 14;
            this.lstYetkiTipleri.Location = new System.Drawing.Point(792, 111);
            this.lstYetkiTipleri.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstYetkiTipleri.Name = "lstYetkiTipleri";
            this.lstYetkiTipleri.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstYetkiTipleri.Size = new System.Drawing.Size(184, 228);
            this.lstYetkiTipleri.TabIndex = 140;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(652, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 14);
            this.label3.TabIndex = 124;
            this.label3.Text = "Formlar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(849, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 14);
            this.label4.TabIndex = 124;
            this.label4.Text = "Yetki Türleri";
            // 
            // txtForm
            // 
            this.txtForm.Location = new System.Drawing.Point(639, 17);
            this.txtForm.Name = "txtForm";
            this.txtForm.Size = new System.Drawing.Size(233, 22);
            this.txtForm.TabIndex = 144;
            // 
            // btnFormEkle
            // 
            this.btnFormEkle.Location = new System.Drawing.Point(878, 17);
            this.btnFormEkle.Name = "btnFormEkle";
            this.btnFormEkle.Size = new System.Drawing.Size(103, 23);
            this.btnFormEkle.TabIndex = 145;
            this.btnFormEkle.Text = "Form Ekle";
            this.btnFormEkle.UseVisualStyleBackColor = true;
            this.btnFormEkle.Click += new System.EventHandler(this.btnFormEkle_Click);
            // 
            // dgvYetkiler
            // 
            this.dgvYetkiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYetkiler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.YetkiID,
            this.ModelAdi,
            this.FormAdi,
            this.YetkiTipi});
            this.dgvYetkiler.Location = new System.Drawing.Point(142, 111);
            this.dgvYetkiler.Name = "dgvYetkiler";
            this.dgvYetkiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYetkiler.Size = new System.Drawing.Size(451, 228);
            this.dgvYetkiler.TabIndex = 146;
            // 
            // YetkiID
            // 
            this.YetkiID.HeaderText = "Yetki No";
            this.YetkiID.Name = "YetkiID";
            // 
            // ModelAdi
            // 
            this.ModelAdi.HeaderText = "Model Adı";
            this.ModelAdi.Name = "ModelAdi";
            // 
            // FormAdi
            // 
            this.FormAdi.HeaderText = "Form Adı";
            this.FormAdi.Name = "FormAdi";
            // 
            // YetkiTipi
            // 
            this.YetkiTipi.HeaderText = "Yetki Tipi";
            this.YetkiTipi.Name = "YetkiTipi";
            // 
            // txtFormAdi
            // 
            this.txtFormAdi.Location = new System.Drawing.Point(639, 52);
            this.txtFormAdi.Name = "txtFormAdi";
            this.txtFormAdi.Size = new System.Drawing.Size(233, 22);
            this.txtFormAdi.TabIndex = 144;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 124;
            this.label1.Text = "Form :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 14);
            this.label5.TabIndex = 127;
            this.label5.Text = "Form Adı:";
            // 
            // frmYiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 369);
            this.Controls.Add(this.dgvYetkiler);
            this.Controls.Add(this.btnFormEkle);
            this.Controls.Add(this.txtFormAdi);
            this.Controls.Add(this.txtForm);
            this.Controls.Add(this.btnYetkiTemizle);
            this.Controls.Add(this.btnYetkiSil);
            this.Controls.Add(this.btnYetkiEkle);
            this.Controls.Add(this.lstYetkiTipleri);
            this.Controls.Add(this.lstFormlar);
            this.Controls.Add(this.cmbModul);
            this.Controls.Add(this.cmbPersonel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labe1);
            this.Controls.Add(this.btnKaydet);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmYiMain";
            this.Text = "Yetki İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYetkiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYetkiTemizle;
        private System.Windows.Forms.Button btnYetkiSil;
        private System.Windows.Forms.Button btnYetkiEkle;
        private System.Windows.Forms.ComboBox cmbModul;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labe1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListBox lstFormlar;
        private System.Windows.Forms.ListBox lstYetkiTipleri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtForm;
        private System.Windows.Forms.Button btnFormEkle;
        private System.Windows.Forms.DataGridView dgvYetkiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn YetkiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn YetkiTipi;
        private System.Windows.Forms.TextBox txtFormAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}

