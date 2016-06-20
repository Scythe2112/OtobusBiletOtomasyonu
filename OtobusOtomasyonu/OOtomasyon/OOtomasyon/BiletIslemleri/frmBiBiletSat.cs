using OOtomasyon.BLL;
using OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOtomasyon.BiletIslemleri
{
    public partial class frmBiBiletSat : Form
    {
        public frmBiBiletSat()
        {
            InitializeComponent();

            sepet = new List<Bilet>();
            frmBiletSat = this;
        }

        public static List<Bilet> sepet { get; set; }
        public static SeferRepository seferR = new SeferRepository();
        public static SeferDetayRepository seferDetayR = new SeferDetayRepository();

        KoltukDurumlariRepository koltukdurumlariR = new KoltukDurumlariRepository();
        SeferGuzergahiRepository seferGuzergahiR = new SeferGuzergahiRepository();
        GuzergahlarRepository guzergahlarR = new GuzergahlarRepository();
        OtobusRepository otobusR = new OtobusRepository();
        BiletRepository biletR = new BiletRepository();
        MusteriRepository musteriR = new MusteriRepository();
        PromosyonlarRepository promosyonlarR = new PromosyonlarRepository();


        public Bilet Bilet { get; set; }
        public static Form frmBiletSat { get; set; }

        public int BinisYeri { get; set; }
        public int InisYeri { get; set; }
        public int SecilenSeferDetay { get; set; }

        public string BinisYeriS { get; set; }
        public string InisYeriS { get; set; }
        public string Aciklama { get; set; }

        private void frmBiBiletSat_Load(object sender, EventArgs e)
        {
            cmbNereden.ValueMember = "IDGuzergah";
            cmbNereden.DataSource = guzergahlarR.SelectAll();
            cmbNereden.DisplayMember = "Guzergah";

            cmbNereye.ValueMember = "IDGuzergah";
            cmbNereye.DataSource = guzergahlarR.SelectAll();
            cmbNereye.DisplayMember = "Guzergah";

            flpSolBir.BackColor = Color.White;
            flpSolIki.BackColor = Color.White;
            flpSagBir.BackColor = Color.White;
            flpSagIki.BackColor = Color.White;

            PanelGonurluguKontrolu();


        }

        private void btnSeferAra_Click(object sender, EventArgs e)
        {

            DateTime tarih = dtpTarih.Value;

            BinisYeri = Convert.ToInt32(cmbNereden.SelectedValue);
            InisYeri = Convert.ToInt32(cmbNereye.SelectedValue);

            BinisYeriS = guzergahlarR.SelectByID(BinisYeri).Guzergah;
            InisYeriS = guzergahlarR.SelectByID(InisYeri).Guzergah;

            dgvSeferler.Rows.Clear();

            int start = Convert.ToInt32(cmbNereden.SelectedValue);
            int end = Convert.ToInt32(cmbNereye.SelectedValue);

            List<SeferDetay> seferDetaylar = seferDetayR.GuzergahaGoreSeferDetayGetir(start, end);

            //tarih süzgeci
            seferDetaylar = seferDetaylar.Where(a => string.Format("{0:d}", a.SeferTarihi.Value) == string.Format("{0:d}", tarih) && a.SeferTarihi.Value.AddHours(23).AddMinutes(59)>DateTime.Now).ToList();

            if (seferDetaylar.Count > 0)
            {

                foreach (var seferDetay in seferDetaylar)
                {
                    DataGridViewRow satir = (DataGridViewRow)dgvSeferler.Rows[0].Clone();
                    satir.Cells[0].Value = seferDetay.Sefer.SeferGuzergahi.Select(a => a.Guzergahlar.Guzergah).First()
     + " -->" + seferDetay.Sefer.SeferGuzergahi.Select(b => b.Guzergahlar.Guzergah).Reverse().First();
                    satir.Cells[1].Value = string.Format("{0:dd.MMMM.yyyy}", seferDetay.SeferTarihi) +" "+ seferDetay.SeferSaati;
                    satir.Cells[2].Value = string.Format("{0:C}", seferDetay.Ucret);
                    satir.Cells[3].Value = "Detay Gör";


                    satir.Tag = seferDetay.IDSeferDetay;
                    dgvSeferler.Rows.Add(satir);

                }

                MessageBox.Show(seferDetaylar.Count+" kayıt listelendi.");
            }
            else
            {
                flpSolBir.Controls.Clear();
                flpSolIki.Controls.Clear();
                flpSagBir.Controls.Clear();
                flpSagIki.Controls.Clear();
            }
        }

        private void dgvSeferler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSeferler.SelectedRows[0].Tag != null)
            {
                SecilenSeferDetay = Convert.ToInt32(dgvSeferler.SelectedRows[0].Tag);
                KoltuklariGetir(SecilenSeferDetay);
            }
            else
            {
                SecilenSeferDetay = 0;
            }
        }

        private void KoltuklariGetir(int seferDetayID)
        {

            flpSolBir.Controls.Clear();
            flpSolIki.Controls.Clear();
            flpSagBir.Controls.Clear();
            flpSagIki.Controls.Clear();

            if (SecilenSeferDetay != 0)
            {
                SeferDetay sfrDetay = seferDetayR.SelectByID(SecilenSeferDetay);

                Otobus oto = otobusR.SelectByID((int)sfrDetay.OtobusID);

                int start = seferGuzergahiR.SeferGuzergahiGetir(sfrDetay.SeferID).First().GuzergahSirasi;
                int end = seferGuzergahiR.SeferGuzergahiGetir(sfrDetay.SeferID).Last().GuzergahSirasi;

                int binis = Convert.ToInt32(cmbNereden.SelectedValue);
                int inis = Convert.ToInt32(cmbNereye.SelectedValue);

                List<Bilet> Koltuklar = biletR.SelectBySeferDetayID(sfrDetay, start, end ,binis , inis);

                // 2 veritabanında 2+2 koltuk demek
                if (oto.OtobusTipiID == 2)
                {
                    int i = 1;
                    int j = 1;
                    while (i <= oto.KoltukSayisi)
                    {

                        Button koltukLabel = new Button()
                        {

                            BackColor = Color.LightCyan,
                            Name = "lblKoltuk_" + i,
                            Size = new Size(35, 30),
                            Tag = i,
                            Cursor = Cursors.Hand,
                            Text = i + "",
                            Margin = new Padding(5, 0, 5, 5)
                        };

                        Bilet temp = Koltuklar.FirstOrDefault(x => x.KoltukNo == i);

                        if (temp != null)
                        {


                            if (temp.KoltukTipiID == 1)
                            {
                                koltukLabel.BackColor = Color.Pink;
                            }
                            else if (temp.KoltukTipiID == 2)
                            {
                                koltukLabel.BackColor = Color.Blue;

                            }

                            koltukLabel.Enabled = false;

                        }



                        //tum butonlar icin bir click olayı atandı:
                        koltukLabel.Click += KoltukLabel_Click;
                        koltukLabel.MouseEnter += KoltukLabel_MouseEnter;
                        koltukLabel.MouseLeave += KoltukLabel_MouseLeave;

                        //panele butonlar eklendi.
                        if (i <= 22)
                        {
                            if (i % 4 == 1)
                                flpSolBir.Controls.Add(koltukLabel);
                            else if (i % 4 == 2)
                                flpSolIki.Controls.Add(koltukLabel);
                            else if (i % 4 == 3)
                                flpSagBir.Controls.Add(koltukLabel);
                            else if (i % 4 == 0)
                                flpSagIki.Controls.Add(koltukLabel);

                            i++;
                            j++;
                        }
                        else if (j == 23)
                        {
                            Label koltukLabelKapi = new Label()
                            {
                                Text = "Ara",
                                Size = new Size(35, 30),
                                Margin = new Padding(5, 0, 5, 5)
                            };
                            flpSagBir.Controls.Add(koltukLabelKapi);
                            j++;
                        }
                        else if (j == 24)
                        {
                            Label koltukLabelKapi = new Label()
                            {

                                Text = "Ara",
                                Size = new Size(35, 30),
                                Margin = new Padding(5, 0, 5, 5)
                            };
                            flpSagIki.Controls.Add(koltukLabelKapi);
                            j++;
                        }
                        else if (i >= 23)
                        {
                            if (i % 4 == 1)
                                flpSolBir.Controls.Add(koltukLabel);
                            else if (i % 4 == 2)
                                flpSolIki.Controls.Add(koltukLabel);
                            else if (i % 4 == 3)
                                flpSagBir.Controls.Add(koltukLabel);
                            else if (i % 4 == 0)
                                flpSagIki.Controls.Add(koltukLabel);

                            i++;
                            j++;
                        }
                    }

                }
                else if (oto.OtobusTipiID == 1)
                { // 1 veritabanında 2+1 koltuk tipi demek
                    int i = 1;
                    int j = 1;
                    while (i <= oto.KoltukSayisi)
                    {

                        Button koltukLabel = new Button()
                        {

                            BackColor = Color.LightCyan,
                            Name = "lblKoltuk_" + i,
                            Size = new Size(35, 30),
                            Tag = i,
                            Cursor = Cursors.Hand,
                            Text = i + "",
                            Margin = new Padding(5, 0, 5, 5)
                        };

                        Bilet temp = Koltuklar.FirstOrDefault(x => x.KoltukNo == i);

                        if (temp != null)
                        {
                            if (temp.KoltukTipiID == 1)
                            {
                                koltukLabel.BackColor = Color.Pink;
                            }
                            else if (temp.KoltukTipiID == 2)
                            {
                                koltukLabel.BackColor = Color.Blue;
                            }
                            koltukLabel.Enabled = false;
                        }

                        //tum butonlar icin bir click olayı atandı:
                        koltukLabel.Click += KoltukLabel_Click;
                        koltukLabel.MouseEnter += KoltukLabel_MouseEnter;
                        koltukLabel.MouseLeave += KoltukLabel_MouseLeave;

                        //panele butonlar eklendi.
                        if (i <= 25)
                        {
                            if (i % 3 == 1)
                                flpSolBir.Controls.Add(koltukLabel);
                            else if (i % 3 == 2)
                                flpSagBir.Controls.Add(koltukLabel);
                            else if (i % 3 == 0)
                                flpSagIki.Controls.Add(koltukLabel);

                            i++;
                            j++;
                        }
                        else if (j == 26)
                        {
                            Label koltukLabelKapi = new Label()
                            {
                                Text = "Ara",
                                Size = new Size(35, 30),
                                Margin = new Padding(5, 0, 5, 5)
                            };
                            flpSagBir.Controls.Add(koltukLabelKapi);
                            j++;
                        }
                        else if (j == 27)
                        {
                            Label koltukLabelKapi = new Label()
                            {

                                Text = "Ara",
                                Size = new Size(35, 30),
                                Margin = new Padding(5, 0, 5, 5)
                            };
                            flpSagIki.Controls.Add(koltukLabelKapi);
                            j++;
                        }
                        else if (i >= 26)
                        {
                            if (i % 3 == 1)
                                flpSolBir.Controls.Add(koltukLabel);
                            else if (i % 3 == 2)
                                flpSagBir.Controls.Add(koltukLabel);
                            else if (i % 3 == 0)
                                flpSagIki.Controls.Add(koltukLabel);
                            i++;
                            j++;
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Lütfen Sefer Seçiniz.");
            }
        }

        private void KoltukLabel_MouseLeave(object sender, EventArgs e)
        {
            Button secilenKoltuk = sender as Button;
            if (secilenKoltuk.Enabled == true)
            {
                secilenKoltuk.BackColor = Color.LightCyan;
            }
        }

        private void KoltukLabel_MouseEnter(object sender, EventArgs e)
        {
            Button secilenKoltuk = sender as Button;
            if (secilenKoltuk.Enabled == true)
            {
                secilenKoltuk.BackColor = Color.Green;


            }
        }

        private void KoltukLabel_Click(object sender, EventArgs e)
        {
            Button secilenKoltuk = sender as Button;
            Bilet = new Bilet();
            Bilet.BinisYeri = BinisYeri;
            Bilet.InisYeri = InisYeri;
            Bilet.Ucret = Convert.ToInt32(Convert.ToDecimal(dgvSeferler.SelectedRows[0].Cells[2].Value.ToString().Substring(0, dgvSeferler.SelectedRows[0].Cells[2].Value.ToString().Length - 1)));
            Bilet.KoltukNo = Convert.ToInt32(secilenKoltuk.Tag);
            Bilet.SeferDetayID = SecilenSeferDetay;

            frmBiBiletIcerik.Bilet = Bilet;

            Aciklama = "Biniş Yeri :" + BinisYeriS + "\nİniş Yeri : " + InisYeriS + "\nKoltuk No :" + secilenKoltuk.Tag.ToString() + "\nFiyat :" + dgvSeferler.SelectedRows[0].Cells[2].Value.ToString() + " TL \nKalkış Saati :" + dgvSeferler.SelectedRows[0].Cells[1].Value.ToString();

            frmBiBiletIcerik.Aciklama = Aciklama;

            frmBiBiletIcerik frmBiletIcerik = new frmBiBiletIcerik();
            frmBiletIcerik.ShowDialog();

        }

        public void SepetGoster()
        {
            var sepetDetaylar = sepet.Select(x => new
            {
                Guzergah = guzergahlarR.SelectByID(x.BinisYeri).Guzergah
                + " -->" + guzergahlarR.SelectByID(x.InisYeri).Guzergah,
                Saat = seferDetayR.SelectByID(x.SeferDetayID).SeferSaati,
                Fiyat = string.Format("{0:C}", x.Ucret),
                Koltuk = x.KoltukNo + " Numara",
                Durum = koltukdurumlariR.SelectByID(x.KoltukDurumuID).KoltukDurum,
                BiletID = x.IDBilet

            }).ToList();

            dgvSefer.Rows.Clear();

            if (sepetDetaylar.Count > 0)
            {

                foreach (var sepetDetay in sepetDetaylar)
                {
                    DataGridViewRow satir = (DataGridViewRow)dgvSefer.Rows[0].Clone();
                    satir.Cells[0].Value = sepetDetay.Guzergah;
                    satir.Cells[1].Value = sepetDetay.Saat;
                    satir.Cells[2].Value = string.Format("{0:C}", sepetDetay.Fiyat);
                    satir.Cells[3].Value = string.Format("{0:d}", sepetDetay.Koltuk);
                    satir.Cells[4].Value = sepetDetay.Durum;


                    satir.Tag = sepetDetay.BiletID;
                    dgvSefer.Rows.Add(satir);

                }
            }
            else
            {
                dgvSefer.Rows.Clear();
            }


            KoltuklariGetir(SecilenSeferDetay);
            lblBiletSayisi.Text = sepet.Count().ToString() + " Adet";
            lblToplamUcret.Text = string.Format("{0:C}", sepet.Where(x => x.KoltukDurumuID == 1).Sum(x => x.Ucret));
            PanelGonurluguKontrolu();
        }

        private void PanelGonurluguKontrolu()
        {
            if (sepet.Count() == 0)
            {
                pnlSepetDetay.Visible = false;
                pnlSepet.Visible = false;
                pnlButonlar.Visible = false;
               
            }
            else
            {
                pnlSepetDetay.Visible = true;
                pnlSepet.Visible = true;
                pnlButonlar.Visible = true;
            }
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sepet.Count; i++)
            {
                sepet[i].Durum = true;
                biletR.Update(sepet[i]);
            }

            sepet.Clear();
            PanelGonurluguKontrolu();

            flpSolBir.Controls.Clear();
            flpSolIki.Controls.Clear();
            flpSagBir.Controls.Clear();
            flpSagIki.Controls.Clear();
            
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int tempGuzergahId = cmbNereden.SelectedIndex;
            cmbNereden.SelectedIndex = cmbNereye.SelectedIndex;
            cmbNereye.SelectedIndex = tempGuzergahId;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvSefer.RowCount > 0)
            {
                
                foreach (DataGridViewRow item in dgvSefer.SelectedRows)
                {
                    if (item.Tag!=null)
                    {
                        Bilet blt = biletR.SelectByID(Convert.ToInt32(item.Tag));
                        Musteri mst = musteriR.SelectByID(blt.MusteriID);
                        if (blt.PromosyonID==2)
                        {
                            Promosyonlar pro = promosyonlarR.SelectAllActive(2);
                            mst.MusteriKartlari.BiletSayisi += pro.PromosyonMiktari;
                        }
                        else if (blt.PromosyonID == 3)
                        {
                            Promosyonlar pro = promosyonlarR.SelectAllActive(1);
                            mst.MusteriKartlari.Bakiye -= (Bilet.Ucret * pro.PromosyonMiktari) / 100;
                            mst.MusteriKartlari.BiletSayisi -= 1;
                        }
                        else if (blt.PromosyonID == 6)
                        {
                            mst.MusteriKartlari.Bakiye += Bilet.Ucret;
                        }
                        biletR.Delete(Convert.ToInt32(item.Tag));
                        sepet.Remove(sepet.FirstOrDefault(x => x.IDBilet == Convert.ToInt32(item.Tag)));
                    }
                }
                SepetGoster();
                KoltuklariGetir(SecilenSeferDetay);
                
            }
        }

        private void btnSatisIptal_Click(object sender, EventArgs e)
        {
            if (dgvSefer.RowCount > 0)
            {
                foreach (Bilet item in sepet)
                {
                    Musteri mst = musteriR.SelectByID(item.MusteriID);
                    if (item.PromosyonID == 2)
                    {
                        Promosyonlar pro = promosyonlarR.SelectAllActive(2);
                        mst.MusteriKartlari.BiletSayisi += pro.PromosyonMiktari;
                    }
                    else if (item.PromosyonID == 3)
                    {
                        Promosyonlar pro = promosyonlarR.SelectAllActive(1);
                        mst.MusteriKartlari.Bakiye -= (Bilet.Ucret * pro.PromosyonMiktari) / 100;
                        mst.MusteriKartlari.BiletSayisi -= 1;
                    }
                    else if (item.PromosyonID == 6)
                    {
                        mst.MusteriKartlari.Bakiye += Bilet.Ucret;
                    }
                    biletR.Delete(Convert.ToInt32(item.IDBilet));
                }
                sepet.Clear();
                PanelGonurluguKontrolu();
                KoltuklariGetir(SecilenSeferDetay);
            }
        }

        private void dgvSeferler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SecilenSeferDetay==0)
            {
                MessageBox.Show("Lütfen Sefer Detay seçiniz.");
            }
            else
            {
                SeferDetay sfrDetay = seferDetayR.SelectByID(SecilenSeferDetay);
                string icerik = string.Format("Sefer Güzergahı: {0} \n Sefer Zamanı: {1} \n Tahmini Varış Süresi : {2} \n Sefer Tipi: {3} \n Sefer Otobüsü: {4}", sfrDetay.Sefer.SeferGuzergahi.Select(a => a.Guzergahlar.Guzergah).First()
     + " -->" + sfrDetay.Sefer.SeferGuzergahi.Select(b => b.Guzergahlar.Guzergah).Reverse().First(), string.Format("{0:dd.MMMM.yyyy}", sfrDetay.SeferTarihi) + " " + sfrDetay.SeferSaati,sfrDetay.Sefer.TahminiVarisSuresi +" dk" ,sfrDetay.Sefer.SeferTipleri.SeferTipi,sfrDetay.Otobus.PlakaNo);


                string ozellikler = "\n Otobüs Özellikleri";
                foreach (OtobusOzellikDetay item in sfrDetay.Otobus.OtobusOzellikDetay)
                {
                    ozellikler += " \n \t -" + item.OtobusOzellikleri.OtobusOzellik;
                }

                MessageBox.Show(icerik+ozellikler);
            } 
        }
    }
}
