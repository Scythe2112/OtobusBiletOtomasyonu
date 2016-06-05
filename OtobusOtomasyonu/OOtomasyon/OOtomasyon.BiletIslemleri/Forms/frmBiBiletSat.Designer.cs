namespace OOtomasyon.BiletIslemleri.Forms
{
    partial class frmBiBiletSat
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
            this.pnlArama = new System.Windows.Forms.Panel();
            this.btnSeferAra = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbNereye = new System.Windows.Forms.ComboBox();
            this.cmbNereden = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSeferler = new System.Windows.Forms.Panel();
            this.dgvSeferler = new System.Windows.Forms.DataGridView();
            this.Guzergah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlKoltuklar = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flpSolIki = new System.Windows.Forms.FlowLayoutPanel();
            this.flpSagIki = new System.Windows.Forms.FlowLayoutPanel();
            this.flpSagBir = new System.Windows.Forms.FlowLayoutPanel();
            this.flpSolBir = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlSepet = new System.Windows.Forms.Panel();
            this.dgvSefer = new System.Windows.Forms.DataGridView();
            this.pnlSepetDetay = new System.Windows.Forms.Panel();
            this.btnSatis = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblToplamUcret = new System.Windows.Forms.Label();
            this.lblBiletSayisi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSatisIptal = new System.Windows.Forms.Button();
            this.GuzergahBilet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaatBilet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiyatBilet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KoltukNoBilet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BiletDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlButonlar = new System.Windows.Forms.Panel();
            this.pnlArama.SuspendLayout();
            this.pnlSeferler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferler)).BeginInit();
            this.pnlKoltuklar.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlSepet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSefer)).BeginInit();
            this.pnlSepetDetay.SuspendLayout();
            this.pnlButonlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlArama
            // 
            this.pnlArama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.pnlArama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlArama.Controls.Add(this.btnSeferAra);
            this.pnlArama.Controls.Add(this.btnSwap);
            this.pnlArama.Controls.Add(this.dtpTarih);
            this.pnlArama.Controls.Add(this.cmbNereye);
            this.pnlArama.Controls.Add(this.cmbNereden);
            this.pnlArama.Controls.Add(this.label3);
            this.pnlArama.Controls.Add(this.label2);
            this.pnlArama.Controls.Add(this.label1);
            this.pnlArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlArama.Location = new System.Drawing.Point(10, 10);
            this.pnlArama.Name = "pnlArama";
            this.pnlArama.Size = new System.Drawing.Size(406, 113);
            this.pnlArama.TabIndex = 0;
            // 
            // btnSeferAra
            // 
            this.btnSeferAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeferAra.Location = new System.Drawing.Point(325, 65);
            this.btnSeferAra.Name = "btnSeferAra";
            this.btnSeferAra.Size = new System.Drawing.Size(75, 23);
            this.btnSeferAra.TabIndex = 4;
            this.btnSeferAra.Text = "Sefer Ara";
            this.btnSeferAra.UseVisualStyleBackColor = true;
            this.btnSeferAra.Click += new System.EventHandler(this.btnSeferAra_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(105, 26);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(40, 21);
            this.btnSwap.TabIndex = 3;
            this.btnSwap.Text = "<=>";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // dtpTarih
            // 
            this.dtpTarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Location = new System.Drawing.Point(261, 27);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(140, 20);
            this.dtpTarih.TabIndex = 2;
            // 
            // cmbNereye
            // 
            this.cmbNereye.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.Location = new System.Drawing.Point(151, 27);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(104, 21);
            this.cmbNereye.TabIndex = 1;
            // 
            // cmbNereden
            // 
            this.cmbNereden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbNereden.FormattingEnabled = true;
            this.cmbNereden.Location = new System.Drawing.Point(3, 27);
            this.cmbNereden.Name = "cmbNereden";
            this.cmbNereden.Size = new System.Drawing.Size(96, 21);
            this.cmbNereden.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(258, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "TARİH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(148, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NEREYE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEREDEN";
            // 
            // pnlSeferler
            // 
            this.pnlSeferler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSeferler.Controls.Add(this.dgvSeferler);
            this.pnlSeferler.Location = new System.Drawing.Point(10, 129);
            this.pnlSeferler.Name = "pnlSeferler";
            this.pnlSeferler.Size = new System.Drawing.Size(406, 402);
            this.pnlSeferler.TabIndex = 0;
            // 
            // dgvSeferler
            // 
            this.dgvSeferler.AllowUserToDeleteRows = false;
            this.dgvSeferler.AllowUserToOrderColumns = true;
            this.dgvSeferler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeferler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dgvSeferler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeferler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Guzergah,
            this.Saat,
            this.Fiyat,
            this.Detay});
            this.dgvSeferler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSeferler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(44)))), ((int)(((byte)(39)))));
            this.dgvSeferler.Location = new System.Drawing.Point(0, 0);
            this.dgvSeferler.Name = "dgvSeferler";
            this.dgvSeferler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeferler.Size = new System.Drawing.Size(404, 400);
            this.dgvSeferler.TabIndex = 0;
            this.dgvSeferler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeferler_CellClick);
            // 
            // Guzergah
            // 
            this.Guzergah.HeaderText = "Güzergah";
            this.Guzergah.Name = "Guzergah";
            // 
            // Saat
            // 
            this.Saat.HeaderText = "Saat";
            this.Saat.Name = "Saat";
            // 
            // Fiyat
            // 
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.Name = "Fiyat";
            // 
            // Detay
            // 
            this.Detay.HeaderText = "Detay";
            this.Detay.Name = "Detay";
            this.Detay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // pnlKoltuklar
            // 
            this.pnlKoltuklar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKoltuklar.Controls.Add(this.panel4);
            this.pnlKoltuklar.Controls.Add(this.panel5);
            this.pnlKoltuklar.Controls.Add(this.panel3);
            this.pnlKoltuklar.Location = new System.Drawing.Point(422, 10);
            this.pnlKoltuklar.Name = "pnlKoltuklar";
            this.pnlKoltuklar.Size = new System.Drawing.Size(237, 521);
            this.pnlKoltuklar.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::OOtomasyon.BiletIslemleri.Properties.Resources.Otobus_Orta;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.flpSolIki);
            this.panel4.Controls.Add(this.flpSagIki);
            this.panel4.Controls.Add(this.flpSagBir);
            this.panel4.Controls.Add(this.flpSolBir);
            this.panel4.Location = new System.Drawing.Point(0, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 454);
            this.panel4.TabIndex = 0;
            // 
            // flpSolIki
            // 
            this.flpSolIki.Location = new System.Drawing.Point(55, 3);
            this.flpSolIki.Name = "flpSolIki";
            this.flpSolIki.Size = new System.Drawing.Size(37, 448);
            this.flpSolIki.TabIndex = 0;
            // 
            // flpSagIki
            // 
            this.flpSagIki.Location = new System.Drawing.Point(182, 3);
            this.flpSagIki.Name = "flpSagIki";
            this.flpSagIki.Size = new System.Drawing.Size(37, 448);
            this.flpSagIki.TabIndex = 0;
            // 
            // flpSagBir
            // 
            this.flpSagBir.Location = new System.Drawing.Point(139, 3);
            this.flpSagBir.Name = "flpSagBir";
            this.flpSagBir.Size = new System.Drawing.Size(37, 448);
            this.flpSagBir.TabIndex = 0;
            // 
            // flpSolBir
            // 
            this.flpSolBir.Location = new System.Drawing.Point(12, 3);
            this.flpSolBir.Name = "flpSolBir";
            this.flpSolBir.Size = new System.Drawing.Size(37, 448);
            this.flpSolBir.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::OOtomasyon.BiletIslemleri.Properties.Resources.Otobus_Arka;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(0, 503);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(234, 17);
            this.panel5.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackgroundImage = global::OOtomasyon.BiletIslemleri.Properties.Resources.Otobus_On;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(0, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 60);
            this.panel3.TabIndex = 0;
            // 
            // pnlSepet
            // 
            this.pnlSepet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSepet.Controls.Add(this.dgvSefer);
            this.pnlSepet.Location = new System.Drawing.Point(665, 10);
            this.pnlSepet.Name = "pnlSepet";
            this.pnlSepet.Size = new System.Drawing.Size(341, 403);
            this.pnlSepet.TabIndex = 0;
            // 
            // dgvSefer
            // 
            this.dgvSefer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSefer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dgvSefer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSefer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GuzergahBilet,
            this.SaatBilet,
            this.FiyatBilet,
            this.KoltukNoBilet,
            this.BiletDurum});
            this.dgvSefer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSefer.Location = new System.Drawing.Point(0, 0);
            this.dgvSefer.Name = "dgvSefer";
            this.dgvSefer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSefer.Size = new System.Drawing.Size(339, 401);
            this.dgvSefer.TabIndex = 0;
            // 
            // pnlSepetDetay
            // 
            this.pnlSepetDetay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.pnlSepetDetay.Controls.Add(this.label7);
            this.pnlSepetDetay.Controls.Add(this.lblToplamUcret);
            this.pnlSepetDetay.Controls.Add(this.lblBiletSayisi);
            this.pnlSepetDetay.Controls.Add(this.label4);
            this.pnlSepetDetay.Location = new System.Drawing.Point(666, 449);
            this.pnlSepetDetay.Name = "pnlSepetDetay";
            this.pnlSepetDetay.Size = new System.Drawing.Size(340, 82);
            this.pnlSepetDetay.TabIndex = 0;
            // 
            // btnSatis
            // 
            this.btnSatis.Location = new System.Drawing.Point(266, 3);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(75, 23);
            this.btnSatis.TabIndex = 1;
            this.btnSatis.Text = "Satış Bitir";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(13, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "TOPLAM ÜCRET :";
            // 
            // lblToplamUcret
            // 
            this.lblToplamUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamUcret.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(44)))), ((int)(((byte)(39)))));
            this.lblToplamUcret.Location = new System.Drawing.Point(141, 42);
            this.lblToplamUcret.Name = "lblToplamUcret";
            this.lblToplamUcret.Size = new System.Drawing.Size(101, 23);
            this.lblToplamUcret.TabIndex = 0;
            // 
            // lblBiletSayisi
            // 
            this.lblBiletSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBiletSayisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(44)))), ((int)(((byte)(39)))));
            this.lblBiletSayisi.Location = new System.Drawing.Point(141, 10);
            this.lblBiletSayisi.Name = "lblBiletSayisi";
            this.lblBiletSayisi.Size = new System.Drawing.Size(101, 23);
            this.lblBiletSayisi.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "BİLET SAYISI :";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(0, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSatisIptal
            // 
            this.btnSatisIptal.Location = new System.Drawing.Point(136, 3);
            this.btnSatisIptal.Name = "btnSatisIptal";
            this.btnSatisIptal.Size = new System.Drawing.Size(75, 23);
            this.btnSatisIptal.TabIndex = 3;
            this.btnSatisIptal.Text = "Satış İptal";
            this.btnSatisIptal.UseVisualStyleBackColor = true;
            this.btnSatisIptal.Click += new System.EventHandler(this.btnSatisIptal_Click);
            // 
            // GuzergahBilet
            // 
            this.GuzergahBilet.HeaderText = "Güzergah";
            this.GuzergahBilet.Name = "GuzergahBilet";
            this.GuzergahBilet.ReadOnly = true;
            // 
            // SaatBilet
            // 
            this.SaatBilet.HeaderText = "Saat";
            this.SaatBilet.Name = "SaatBilet";
            this.SaatBilet.ReadOnly = true;
            // 
            // FiyatBilet
            // 
            this.FiyatBilet.HeaderText = "Fiyat";
            this.FiyatBilet.Name = "FiyatBilet";
            this.FiyatBilet.ReadOnly = true;
            // 
            // KoltukNoBilet
            // 
            this.KoltukNoBilet.HeaderText = "Koltuk No";
            this.KoltukNoBilet.Name = "KoltukNoBilet";
            this.KoltukNoBilet.ReadOnly = true;
            // 
            // BiletDurum
            // 
            this.BiletDurum.HeaderText = "Bilet Durumu";
            this.BiletDurum.Name = "BiletDurum";
            this.BiletDurum.ReadOnly = true;
            // 
            // pnlButonlar
            // 
            this.pnlButonlar.Controls.Add(this.btnSil);
            this.pnlButonlar.Controls.Add(this.btnSatisIptal);
            this.pnlButonlar.Controls.Add(this.btnSatis);
            this.pnlButonlar.Location = new System.Drawing.Point(666, 418);
            this.pnlButonlar.Name = "pnlButonlar";
            this.pnlButonlar.Size = new System.Drawing.Size(341, 29);
            this.pnlButonlar.TabIndex = 4;
            // 
            // frmBiBiletSat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(205)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1080, 584);
            this.Controls.Add(this.pnlButonlar);
            this.Controls.Add(this.pnlSepetDetay);
            this.Controls.Add(this.pnlSepet);
            this.Controls.Add(this.pnlKoltuklar);
            this.Controls.Add(this.pnlSeferler);
            this.Controls.Add(this.pnlArama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBiBiletSat";
            this.Text = "Bilet Sat";
            this.Load += new System.EventHandler(this.frmBiBiletSat_Load);
            this.pnlArama.ResumeLayout(false);
            this.pnlArama.PerformLayout();
            this.pnlSeferler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferler)).EndInit();
            this.pnlKoltuklar.ResumeLayout(false);
            this.pnlKoltuklar.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.pnlSepet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSefer)).EndInit();
            this.pnlSepetDetay.ResumeLayout(false);
            this.pnlButonlar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlArama;
        private System.Windows.Forms.Panel pnlSeferler;
        private System.Windows.Forms.Panel pnlKoltuklar;
        private System.Windows.Forms.Panel pnlSepet;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ComboBox cmbNereye;
        private System.Windows.Forms.ComboBox cmbNereden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeferAra;
        private System.Windows.Forms.DataGridView dgvSeferler;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flpSolIki;
        private System.Windows.Forms.FlowLayoutPanel flpSagIki;
        private System.Windows.Forms.FlowLayoutPanel flpSagBir;
        private System.Windows.Forms.FlowLayoutPanel flpSolBir;
        public System.Windows.Forms.DataGridView dgvSefer;
        private System.Windows.Forms.Panel pnlSepetDetay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblToplamUcret;
        private System.Windows.Forms.Label lblBiletSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guzergah;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detay;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSatisIptal;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuzergahBilet;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaatBilet;
        private System.Windows.Forms.DataGridViewTextBoxColumn FiyatBilet;
        private System.Windows.Forms.DataGridViewTextBoxColumn KoltukNoBilet;
        private System.Windows.Forms.DataGridViewTextBoxColumn BiletDurum;
        private System.Windows.Forms.Panel pnlButonlar;
    }
}