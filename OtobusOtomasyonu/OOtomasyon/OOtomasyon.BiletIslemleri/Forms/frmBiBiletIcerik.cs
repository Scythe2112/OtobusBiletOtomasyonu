using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOtomasyon.BLL;
using OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;

namespace OOtomasyon.BiletIslemleri.Forms
{
    public partial class frmBiBiletIcerik : Form
    {
        public frmBiBiletIcerik()
        {
            InitializeComponent();
        }

        BiletRepository biletR = new BiletRepository();
        MusteriRepository musteriR = new MusteriRepository();
        PromosyonTipleriRepository promosyontipleriR = new PromosyonTipleriRepository();
        PromosyonlarRepository promosyonlarR = new PromosyonlarRepository();
        OdemeTipleriRepository odemetipleriR = new OdemeTipleriRepository();
        MusteriKartlariRepository musteriKartlariR = new MusteriKartlariRepository();


        public static string Aciklama { get; set; }
        public static Bilet Bilet { get; set; }
        public static Bilet tempBilet { get; set; }
        public Musteri SecilenMusteri { get; set; }

        private void frmBiBiletIcerik_Load(object sender, EventArgs e)
        {
            FormTemizle();

            OdemeTipleriniGetir();
            PromosyonlariGetir();

            if (Aciklama != null)
            {
                lblAciklama.Text = Aciklama;
            }
            else
            {
                lblAciklama.Text = "Koltuk seçiminde hata oluştu Lütfen tekrar seçim yapınız.";
            }

            if (Bilet == null)
            {
                lblAciklama.Text = "Bilet bilgileri hatalı, Lütfen tekrar seçim yapınız.";
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string errorText;
            string tcKimlikNo = txtTcKimlikNo.Text;

            if (tcKimlikNo.Trim().Length == 11)
            {
                if (FormTool.LoginValidation(LoginValidationType.TcKimlikControl, tcKimlikNo, out errorText))
                {
                    SecilenMusteri = musteriR.SelectByTC(tcKimlikNo);
                    if (SecilenMusteri != null)
                    {
                        FormDoldur();
                    }
                    else
                    {
                        MessageBox.Show("Kayıtlı Müşteri Bulunamadı.");
                    }

                }
                else
                {
                    gbMusteriKarti.Visible = false;
                    pnlSatisTipi.Visible = false;
                    MessageBox.Show(errorText);

                }

            }
            else
            {
                FormTemizle();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            int koltukDurumu;

            if (Bilet == null)
            {
                lblAciklama.Text = "Bilet bilgileri hatalı, Lütfen tekrar seçim yapınız.";
                return;
            }

            //Müşteri olmadan ad ve soyad'la bilet alınırsa burda önce veritabanına müşteri diye kaydediliyor.
            if (SecilenMusteri == null)
            {

            }


            Bilet.MusteriID = SecilenMusteri.IDMusteri;
            Bilet.IslemTarihi = DateTime.Now;

            #region CinsiyetKontrolu


            if (rbBayan.Checked)
            {

                Bilet.KoltukTipiID = 1;
            }
            else if (rbBay.Checked)
            {
                Bilet.KoltukTipiID = 2;

                if (Bilet.KoltukNo % 2 == 0)
                {

                    if (biletR.SelectBySeferDetayID(Bilet.SeferDetayID).Where(x => (x.KoltukNo == Bilet.KoltukNo - 1) && x.KoltukTipiID == 1).ToList().Count > 0)
                    {
                        MessageBox.Show("Bayan yanı koltuk seçemezsiniz !");
                        return;
                    }

                }
                else
                {
                    if (biletR.SelectBySeferDetayID(Bilet.SeferDetayID).Where(x => (x.KoltukNo == Bilet.KoltukNo + 1) && x.KoltukTipiID == 1).ToList().Count > 0)
                    {
                        MessageBox.Show("Bayan yanı koltuk seçemezsiniz !");
                        return;
                    }
                }

            }
            else
            {
                MessageBox.Show("Lütfen cinsiyet seçiniz !");
                return;
            }
            #endregion



            if (rbSatis.Checked)
            {
                koltukDurumu = 1;

                if (cmbOdemeTipi.SelectedIndex != -1)
                {
                    Bilet.OdemeTipiID = Convert.ToInt32(cmbOdemeTipi.SelectedValue);

                    // Promosyon Kullandıysa
                    if (Bilet.OdemeTipiID == 3)
                    {
                        if (cmbSatisTipi.SelectedIndex != -1)
                        {

                            //Bonus Bilet seçtiyse
                            if (Convert.ToInt32(cmbSatisTipi.SelectedValue) == 2)
                            {
                                Promosyonlar pro = promosyonlarR.SelectAllActive(2);
                                if (pro.PromosyonMiktari <= SecilenMusteri.MusteriKartlari.BiletSayisi)
                                {
                                    Bilet.PromosyonID = pro.IDPromosyon;
                                }
                                else
                                {
                                    MessageBox.Show("Bonus Bilet sayısınız Promosyon için yeterli değil !");
                                    return;
                                }
                            }
                            else if (Convert.ToInt32(cmbSatisTipi.SelectedValue) == 11) //Bonus TL seçtiyse
                            {

                                if (Bilet.Ucret <= SecilenMusteri.MusteriKartlari.Bakiye)
                                {
                                    Bilet.PromosyonID = 5;
                                }
                                else
                                {
                                    MessageBox.Show("Bonus Bakiye miktarı Promosyon için yeterli değil !");
                                    return;
                                }


                            }
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Promosyon Tipi Seçiniz !");
                            return;
                        }

                    }
                    else //Yüzdelikli satış
                    {
                        Bilet.PromosyonID = 5;
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen Ödeme Tipi Seçiniz !");
                    return;
                }


            }
            else if (rbRezerve.Checked)
            {
                koltukDurumu = 2;
            }
            else
            {
                MessageBox.Show("Lütfen Koltuk Durumu Seçiniz !");
                return;
            }

            Bilet.PersonelID = 3;
            Bilet.KoltukDurumuID = koltukDurumu;
            Bilet.Durum = false;   // işlem görüyor anlamına gelmektedir. Bilet satışı bitip bitmediğini kontrol edioyoruz.
            biletR.Insert(Bilet);
            frmBiBiletSat.sepet.Add(Bilet);
            (frmBiBiletSat.frmBiletSat as frmBiBiletSat).SepetGoster();
            this.Close();

        }

        private void OdemeTipleriniGetir()
        {
            cmbOdemeTipi.ValueMember = "IDOdemeTipi";
            cmbOdemeTipi.DisplayMember = "OdemeTipi";
            cmbOdemeTipi.DataSource = odemetipleriR.SelectAll();
        }

        private void PromosyonlariGetir()
        {
            cmbSatisTipi.ValueMember = "IDPromosyonTipi";
            cmbSatisTipi.DisplayMember = "Promosyon";

            cmbSatisTipi.DataSource = promosyontipleriR.SelectAll().Where(x => x.IDPromosyonTipi != 1).ToList();

        }

        private void FormTemizle()
        {
            txtAd.Enabled = true;
            txtSoyad.Enabled = true;
            gbCinsiyet.Enabled = true;

            gbMusteriKarti.Visible = false;
            pnlSatisTipi.Visible = false;
            pnlSatisTipi.Visible = false;

            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;

            rbBayan.Checked = false;
            rbBay.Checked = false;
        }

        private void FormDoldur()
        {

            txtAd.Text = SecilenMusteri.Ad;
            txtSoyad.Text = SecilenMusteri.Soyad;

            if (SecilenMusteri.Cinsiyet == "Bayan")
                rbBayan.Checked = true;
            else
                rbBay.Checked = true;

            txtAd.Enabled = false;
            txtSoyad.Enabled = false;
            gbCinsiyet.Enabled = false;


            lblBonusBilet.Text = musteriKartlariR.SelectByID(SecilenMusteri.KartID).BiletSayisi.ToString() + " Bilet";
            lblBonusPara.Text = musteriKartlariR.SelectByID(SecilenMusteri.KartID).Bakiye.ToString() + " TL";

            gbMusteriKarti.Visible = true;
            pnlSatisTipi.Visible = false;

        }

        private void rbSatis_CheckedChanged(object sender, EventArgs e)
        {
            pnlOdemeTipi.Visible = true;
            gbMusteriKarti.Visible = true;
            pnlSatisTipi.Visible = false;


        }

        private void rbRezerve_CheckedChanged(object sender, EventArgs e)
        {
            pnlOdemeTipi.Visible = false;
            gbMusteriKarti.Visible = false;
            pnlSatisTipi.Visible = false;
        }

        private void cmbOdemeTipi_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbOdemeTipi.SelectedIndex == -1) return;

            if (Convert.ToInt32(cmbOdemeTipi.SelectedValue) == 3)
            {
                pnlSatisTipi.Visible = true;
            }
            else
            {
                pnlSatisTipi.Visible = false;

            }

        }


    }
}
