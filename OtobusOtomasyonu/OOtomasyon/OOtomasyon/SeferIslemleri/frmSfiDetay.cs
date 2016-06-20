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

namespace OOtomasyon.SeferIslemleri
{
    public partial class frmSfiDetay : Form
    {
        public frmSfiDetay()
        {
            InitializeComponent();
        }

        public SeferDetay SecilenSeferDetay { get; set; }
        public List<Personel> SeferPersonel { get; set; } = new List<Personel>();

        PersonelRepository pR = new PersonelRepository();
        OtobusRepository oR = new OtobusRepository();
        SeferRepository sR = new SeferRepository();
        SeferDetayRepository sdR = new SeferDetayRepository();
        SeferPersonelRepository spR = new SeferPersonelRepository();
        ServisRepository servisR = new ServisRepository();
        HarcamalarRepository hR = new HarcamalarRepository();

        private void frmSeferDetay_Load(object sender, EventArgs e)
        {
            SeferleriGetir();
            OtobusleriGetir();
            PersonelleriGetir();
            grbServisBilgileri.Visible = false;

            lstSeferPersonelleri.DisplayMember = "Ad";
            lstSeferPersonelleri.ValueMember = "IDPersonel";
        }

        private void SeferleriGetir()
        {
            cmbSefer.ValueMember = "IDSefer";
            cmbSefer.DataSource = sR.SelectAll().Select(x => new { x.IDSefer, Guzergah = x.SeferGuzergahi.First().Guzergahlar.Guzergah + " -> " + x.SeferGuzergahi.Last().Guzergahlar.Guzergah }).ToList();
            cmbSefer.DisplayMember = "Guzergah";
        }

        private void OtobusleriGetir()
        {
            cmbOtobus.ValueMember = "IDOtobus";
            cmbOtobus.DataSource = oR.SelectAllActive();
            cmbOtobus.DisplayMember = "PlakaNo";

            cmbServisAracı.ValueMember = "IDOtobus";
            cmbServisAracı.DataSource = oR.SelectAllActive();
            cmbServisAracı.DisplayMember = "PlakaNo";
        }

        private void PersonelleriGetir()
        {
            cmbSeferPersonel.ValueMember = "IDPersonel";
            cmbSeferPersonel.DataSource = pR.SelectAll().Select(x => new { x.IDPersonel, AdSoyadUnvan = x.Ad + " " + x.Soyad + " -> " + x.Unvanlar.Unvan }).ToList();
            cmbSeferPersonel.DisplayMember = "AdSoyadUnvan";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkServisEkle.Checked)
            {
                grbServisBilgileri.Visible = true;
            }
            else
            {
                grbServisBilgileri.Visible = false;
            }
        }

        private void dgvSeferDetaylar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SecilenSeferDetay = sdR.SelectByID(Convert.ToInt32(dgvSeferDetaylar.SelectedRows[0].Cells[0].Value));
        }

        private void btnListele_Click(object sender, EventArgs e)
        {

            if (SecilenSeferDetay == null)
            {
                MessageBox.Show("Lütfen Sefer Detay Seçiniz!");
            }
            else
            {
                cmbSefer.SelectedItem = SecilenSeferDetay.Sefer;
                cmbOtobus.SelectedItem = SecilenSeferDetay.Otobus;
                dtpSeferTarihi.Value = SecilenSeferDetay.SeferTarihi.Value;
                txtSeferSaati.Text = SecilenSeferDetay.SeferSaati;
                numSeferUcreti.Text = SecilenSeferDetay.Ucret.ToString();

                SeferPersonel.Clear();

                foreach (SeferPersonel item in SecilenSeferDetay.SeferPersonel)
                {
                    SeferPersonel.Add(item.Personel);
                }
                PersonelListele();

                if (SecilenSeferDetay.Servis.Count >0)
                {
                    grbServisBilgileri.Visible = true;
                    cmbServisAracı.SelectedItem = SecilenSeferDetay.Servis;
                    txtKalkisYeri.Text = SecilenSeferDetay.Servis.Select(x => x.KalkisYeri).FirstOrDefault();
                    txtServisSaati.Text = SecilenSeferDetay.Servis.Select(x => x.KalkisSaati).FirstOrDefault();
                    numServisUcreti.Value = (decimal)SecilenSeferDetay.Servis.Select(x => x.ServisUcreti ?? 0).FirstOrDefault();
                }
                else
                {
                    FormTool.FormTemizle(grbServisBilgileri.Controls);
                    grbServisBilgileri.Visible = false;
                }
            }
        }

        private void cmbSefer_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeferDetaylariGetir();
        }

        private void SeferDetaylariGetir()
        {
            if ((int)cmbSefer.SelectedValue != -1)
            {
                dgvSeferDetaylar.DataSource = sdR.SelectAll((int)cmbSefer.SelectedValue).Select(y => new
                {
                    ID = y.IDSeferDetay,
                    Tarih = string.Format("{0:dd.MMMM.yyyy}",(DateTime)y.SeferTarihi) ,
                    Saat = y.SeferSaati,
                    Ucret = string.Format("{0:C}",y.Ucret) ,
                }).OrderByDescending(s=>s.ID).ToList();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            SecilenSeferDetay = null;
            FormTool.FormTemizle(this.Controls);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (SecilenSeferDetay==null)
            {
                MessageBox.Show("Lütfen Sefer Datay seçiniz.");
            }

            else if (cmbSefer.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Sefer Seçiniz !");
                return;

            }
            else if (cmbOtobus.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Otobüs Seçiniz !");
                return;

            }
            else if (sR.SelectByID((int)cmbSefer.SelectedValue).BaslangicTarihi > dtpSeferTarihi.Value ||
                sR.SelectByID((int)cmbSefer.SelectedValue).BitisTarihi < dtpSeferTarihi.Value)
            {
                MessageBox.Show(string.Format("Sefer ,{0} ile {1} tarihleri arasında olmalıdır!", sR.SelectByID((int)cmbSefer.SelectedValue).BaslangicTarihi, sR.SelectByID((int)cmbSefer.SelectedValue).BitisTarihi));
                return;

            }
            else if (txtSeferSaati.Text.Length != 5)
            {
                MessageBox.Show("Lütfen sefer saatini giriniz !");
                return;

            }
            else if (numSeferUcreti.Value < 20)
            {
                MessageBox.Show("Sefer ücreti en az 20 TL olmalıdır !");
                return;

            }
            else if (lstSeferPersonelleri.Items.Count < 4)
            {
                MessageBox.Show("Seferde en az 4 Personel olmalıdır !");
                return;
            }
            else if (chkServisEkle.Checked && (cmbServisAracı.SelectedIndex == -1 || string.IsNullOrEmpty(txtKalkisYeri.Text.Trim()) || txtServisSaati.Text.Length != 5))
            {
                MessageBox.Show("Sefer Servis Bilgilerini Giriniz !");
                return;
            }
            else
            {
       
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbSefer.SelectedIndex==-1)
            {
                MessageBox.Show("Lütfen Sefer Seçiniz !");
                return;

            }
            else if (cmbOtobus.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Otobüs Seçiniz !");
                return;

            }
            else if (sR.SelectByID((int)cmbSefer.SelectedValue).BaslangicTarihi>dtpSeferTarihi.Value || 
                sR.SelectByID((int)cmbSefer.SelectedValue).BitisTarihi < dtpSeferTarihi.Value)
            {
                MessageBox.Show(string.Format("Sefer ,{0} ile {1} tarihleri arasında olmalıdır!", sR.SelectByID((int)cmbSefer.SelectedValue).BaslangicTarihi, sR.SelectByID((int)cmbSefer.SelectedValue).BitisTarihi));
                return;

            }
            else if (txtSeferSaati.Text.Length != 5)
            {
                MessageBox.Show("Lütfen sefer saatini giriniz !");
                return;

            }
            else if (numSeferUcreti.Value < 20)
            {
                MessageBox.Show("Sefer ücreti en az 20 TL olmalıdır !");
                return;

            }
            else if (lstSeferPersonelleri.Items.Count < 4)
            {
                MessageBox.Show("Seferde en az 4 Personel olmalıdır !");
                return;
            }
            else if (chkServisEkle.Checked && (cmbServisAracı.SelectedIndex == -1 || string.IsNullOrEmpty(txtKalkisYeri.Text.Trim()) || txtServisSaati.Text.Length != 5))
            {
                    MessageBox.Show("Sefer Servis Bilgilerini Giriniz !");
                    return;
            }
            else
            {
                SeferDetayEkle();
            }
        }

        private void SeferDetayEkle()
        {
            SeferDetay sfrDty = new SeferDetay()
            {
                SeferID=(int)cmbSefer.SelectedValue,
                OtobusID=(int)cmbOtobus.SelectedValue,
                SeferSaati=txtSeferSaati.Text,
                SeferTarihi=dtpSeferTarihi.Value,
                Ucret=numSeferUcreti.Value,
            };
            sdR.Insert(sfrDty);

            for (int i = 0; i < lstSeferPersonelleri.Items.Count; i++)
            {
                SeferPersonel sfrPer = new SeferPersonel()
                {
                    PersonelID= (lstSeferPersonelleri.Items[i] as Personel).IDPersonel,
                    SeferDetayID= sfrDty.IDSeferDetay
                };
                spR.Insert(sfrPer);
            }

            if (chkServisEkle.Checked)
            {
                Servis sfrGuzergahi = new Servis()
                {
                    SeferDetayID=sfrDty.IDSeferDetay,
                    OtobusID=(int)cmbOtobus.SelectedValue,
                    KalkisSaati=txtServisSaati.Text,
                    ServisUcreti=numServisUcreti.Value,
                    KalkisYeri=txtKalkisYeri.Text ?? "Şube Önü"
                };
                servisR.Insert(sfrGuzergahi);
            }


            MessageBox.Show("Sefer başarı ile eklendi Sefer Detay sayfasını kontrol ediniz.");
            SeferleriGetir();
            SeferPersonel.Clear();
            FormTool.FormTemizle(this.Controls);
        }

        private void SeferDetayGuncelle()
        {

            SecilenSeferDetay.SeferID = (int)cmbSefer.SelectedValue;
            SecilenSeferDetay.OtobusID = (int)cmbOtobus.SelectedValue;
            SecilenSeferDetay.SeferSaati = txtSeferSaati.Text;
            SecilenSeferDetay.SeferTarihi = dtpSeferTarihi.Value;
            SecilenSeferDetay.Ucret = numSeferUcreti.Value;
            
            sdR.Update(SecilenSeferDetay);

            spR.DeleteAll(SecilenSeferDetay.IDSeferDetay);
            for (int i = 0; i < lstSeferPersonelleri.Items.Count; i++)
            {
                
                SeferPersonel sfrPer = lstSeferPersonelleri.Items[i] as SeferPersonel;
                sfrPer.SeferDetayID = SecilenSeferDetay.IDSeferDetay;
                spR.Insert(sfrPer);
            }

            servisR.DeleteAll(SecilenSeferDetay.IDSeferDetay);
            if (chkServisEkle.Checked)
            {
                Servis sfrGuzergahi = new Servis()
                {
                    SeferDetayID = SecilenSeferDetay.IDSeferDetay,
                    OtobusID = (int)cmbOtobus.SelectedValue,
                    KalkisSaati = txtServisSaati.Text,
                    ServisUcreti = numServisUcreti.Value,
                    KalkisYeri = txtKalkisYeri.Text ?? "Şube Önü"
                };
                servisR.Insert(sfrGuzergahi);
            }


            MessageBox.Show("Sefer başarı ile eklendi Sefer Detay sayfasını kontrol ediniz.");
            SeferleriGetir();
            SeferPersonel.Clear();
            FormTool.FormTemizle(this.Controls);



        }

        private void PersonelListele()
        {
            lstSeferPersonelleri.Items.Clear();
            foreach (Personel item in SeferPersonel)
            {
                lstSeferPersonelleri.Items.Add(item);
            }

        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            if (!SeferPersonel.Contains(pR.SelectByID((int)cmbSeferPersonel.SelectedValue)))
            {
                SeferPersonel.Add(pR.SelectByID((int)cmbSeferPersonel.SelectedValue));
                PersonelListele();
            }
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            if (SeferPersonel.Count > 0)
            {
                for (int i = lstSeferPersonelleri.SelectedItems.Count - 1; i >= 0; i--)
                {
                    SeferPersonel.Remove(lstSeferPersonelleri.SelectedItems[i] as Personel);
                }
                PersonelListele();
            }
        }

        private void btnPersonelTemizle_Click(object sender, EventArgs e)
        {
            if (SeferPersonel.Count > 0)
            {
                SeferPersonel.Clear();
                PersonelListele();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (SecilenSeferDetay == null)
            {
                MessageBox.Show("Sefer Detay Seçiniz!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Seçilen Sefer Detay bilgileri silinecektir?", "Emin misin ?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (SecilenSeferDetay.Servis.Count>0)
                        {
                            servisR.Delete(SecilenSeferDetay.Servis.First().IDServis);
                        }
                        if (SecilenSeferDetay.SeferPersonel.Count>0)
                        {
                                spR.DeleteAll(SecilenSeferDetay.IDSeferDetay);
                            
                        }
                        if (SecilenSeferDetay.Harcamalar.Count > 0)
                        {
                            foreach (Harcamalar item in (List<Harcamalar>)SecilenSeferDetay.Harcamalar)
                            {
                                hR.Delete(item.IDHarcama);
                            }
                        }

                        sdR.Delete(SecilenSeferDetay.IDSeferDetay);

                        MessageBox.Show("Kayıt başarıyla silindi.");
                        FormTool.FormTemizle(this.Controls);
                        SeferDetaylariGetir();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }
    }
}
