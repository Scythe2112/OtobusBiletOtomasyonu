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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Sefer SecilenSefer { get; set; }

        SeferTipleriRepository stR = new SeferTipleriRepository();
        SeferRepository sR = new SeferRepository();
        SeferDetayRepository sdR = new SeferDetayRepository();
        SeferGuzergahiRepository sgR = new SeferGuzergahiRepository();
        GuzergahlarRepository gR = new GuzergahlarRepository();

        private void Form1_Load(object sender, EventArgs e)
        {
            SeferTipleriniGetir();
            GuzergahlariGetir();
            dtpBaslangicTarihi.Value = DateTime.Now;
            dtpBitisTarihi.Value = DateTime.Now.AddDays(30);
            SeferleriGetir();

            lstSeferGuzergahi.DisplayMember = "Guzergah";
            lstSeferGuzergahi.ValueMember = "IDGuzergah";

        }

        private void GuzergahlariGetir()
        {
            cmbGuzergah.ValueMember = "IDGuzergah";
            cmbGuzergah.DataSource = gR.SelectAll();
            cmbGuzergah.DisplayMember = "Guzergah";
        }

        private void SeferTipleriniGetir()
        {
            cmbSeferTipi.ValueMember = "IDSeferTipi";
            cmbSeferTipi.DataSource = stR.SelectAll();
            cmbSeferTipi.DisplayMember = "SeferTipi";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if ((dtpBaslangicTarihi.Value.Day < DateTime.Now.Day) && (dtpBaslangicTarihi.Value.Month < DateTime.Now.Month) && (dtpBaslangicTarihi.Value.Year < DateTime.Now.Year))
            {
                MessageBox.Show("Sefer başlangıç tarihini hatalı !");
                return;

            }
            else if (((dtpBitisTarihi.Value.Day < DateTime.Now.Day) && (dtpBitisTarihi.Value.Month < DateTime.Now.Month) && (dtpBitisTarihi.Value.Year < DateTime.Now.Year)) || dtpBaslangicTarihi.Value > dtpBitisTarihi.Value)
            {
                MessageBox.Show("Sefer bitiş tarihini hatalı !");
                return;

            }
            else if (numTahminiVarisSuresi.Value < 30)
            {
                MessageBox.Show("Varış süresi 30 dk'dan az olamaz !");
                return;

            }
            else if (cmbSeferTipi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen sefer tipi seçiniz !");
                return;

            }
            else if (txtSeferSaati.Text.Length != 5)
            {
                MessageBox.Show("Lütfen sefer saatini giriniz !");
                return;

            }
            else if (numSeferUcreti.Value<20)
            {
                MessageBox.Show("Sefer ücreti en az 20 TL olmalıdır !");
                return;

            }
            else if (lstSeferGuzergahi.Items.Count<2)
            {
                MessageBox.Show("Sefer en az 2 Güzergahlı olmalıdır !");
                return;
            }
            else
            {
                SeferEkle();
            }
        }

        private void SeferEkle()
        {
            int seferGunleri = (dtpBitisTarihi.Value - dtpBaslangicTarihi.Value).Days;

            Sefer sfr = new Sefer()
            {
                BaslangicTarihi = dtpBaslangicTarihi.Value,
                BitisTarihi = dtpBitisTarihi.Value,
                TahminiVarisSuresi = (int)numTahminiVarisSuresi.Value,
                SeferTipiID = Convert.ToInt32(cmbSeferTipi.SelectedValue),
                SeferDurum = true
            };
            sR.Insert(sfr);

            for (int i = 0; i < seferGunleri; i++)
            {
                SeferDetay sfrDetay = new SeferDetay()
                {
                    SeferID = sfr.IDSefer,
                    SeferTarihi = dtpBaslangicTarihi.Value.AddDays(i),
                    SeferSaati=txtSeferSaati.Text,
                    Ucret=numSeferUcreti.Value
                };
                sdR.Insert(sfrDetay);
            }

            for (int i = 0; i < lstSeferGuzergahi.Items.Count; i++)
            {
                SeferGuzergahi sfrGuzergahi = new SeferGuzergahi()
                {
                    GuzergahID=(lstSeferGuzergahi.Items[i] as Guzergahlar).IDGuzergah,
                    SeferID=sfr.IDSefer,
                    GuzergahSirasi=(i+1)
                };
                sgR.Insert(sfrGuzergahi);
            }

            MessageBox.Show("Sefer başarı ile eklendi Sefer Detay sayfasını kontrol ediniz.");
            SeferleriGetir();
            FormTool.FormTemizle(this.Controls);
        }

        private void SeferleriGetir()
        {
            dgvSeferler.DataSource = sR.SelectAll().Where(s=>s.SeferDurum==true).Select(x => new
            {
                SeferID = x.IDSefer,
                KalkisYeri = x.SeferGuzergahi.Select(a => a.Guzergahlar.Guzergah).First(),
                VarisYeri = x.SeferGuzergahi.Select(b => b.Guzergahlar.Guzergah).Reverse().First(),
            }).ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (SecilenSefer == null)
            {
                MessageBox.Show("Sefer Seçiniz!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Seçilen Sefer bilgileri Pasif hale getirilecektir ?", "Emin misin ?",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        SecilenSefer.SeferDurum = false;
                        sR.Update(SecilenSefer);
                        SeferleriGetir();
                        FormTool.FormTemizle(this.Controls);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void dgvSeferler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SecilenSefer = sR.SelectByID(Convert.ToInt32(dgvSeferler.SelectedRows[0].Cells[0].Value));
        }

        private void btnGuzergahEkle_Click(object sender, EventArgs e)
        {
            lstSeferGuzergahi.Items.Add(gR.SelectByID((int)cmbGuzergah.SelectedValue));
        }

        private void btnGuzergahSil_Click(object sender, EventArgs e)
        {
            if (lstSeferGuzergahi.Items.Count>0)
            {
                for (int i = lstSeferGuzergahi.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lstSeferGuzergahi.Items.Remove(lstSeferGuzergahi.SelectedItems[i]);
                }
            }

        }

        private void btnGuzergahTemizle_Click(object sender, EventArgs e)
        {
            if (lstSeferGuzergahi.Items.Count > 0)
            {
                lstSeferGuzergahi.Items.Clear();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormTool.FormTemizle(this.Controls);
            SeferleriGetir();
            SecilenSefer = null;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            FormTool.FormTemizle(this.Controls);

            if (SecilenSefer == null)
            {
                MessageBox.Show("Lütfen Sefer Seçiniz!");
            }
            else
            {
                dtpBaslangicTarihi.Value = SecilenSefer.BaslangicTarihi;
                dtpBitisTarihi.Value = SecilenSefer.BitisTarihi;
                numTahminiVarisSuresi.Value =(int)SecilenSefer.TahminiVarisSuresi;
                cmbSeferTipi.SelectedValue = (int)SecilenSefer.SeferTipiID;
                txtSeferSaati.Text = (SecilenSefer.SeferDetay.First() as SeferDetay).SeferSaati;
                numSeferUcreti.Text = (SecilenSefer.SeferDetay.First() as SeferDetay).Ucret.ToString();


                foreach (SeferGuzergahi item in SecilenSefer.SeferGuzergahi)
                {
                    lstSeferGuzergahi.Items.Add(item.Guzergahlar);
                }

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (SecilenSefer==null)
            {
                MessageBox.Show("Lütfen Sefer Seçiniz !");

            }
            else if ((dtpBaslangicTarihi.Value.Day < DateTime.Now.Day) && (dtpBaslangicTarihi.Value.Month < DateTime.Now.Month) && (dtpBaslangicTarihi.Value.Year < DateTime.Now.Year))
            {
                MessageBox.Show("Sefer başlangıç tarihini hatalı !");
                return;

            }
            else if (((dtpBitisTarihi.Value.Day < DateTime.Now.Day) && (dtpBitisTarihi.Value.Month < DateTime.Now.Month) && (dtpBitisTarihi.Value.Year < DateTime.Now.Year)) || dtpBaslangicTarihi.Value > dtpBitisTarihi.Value)
            {
                MessageBox.Show("Sefer bitiş tarihini hatalı !");
                return;

            }
            else if (numTahminiVarisSuresi.Value < 30)
            {
                MessageBox.Show("Varış süresi 30 dk'dan az olamaz !");
                return;

            }
            else if (cmbSeferTipi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen sefer tipi seçiniz !");
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
            else if (lstSeferGuzergahi.Items.Count < 2)
            {
                MessageBox.Show("Sefer en az 2 Güzergahlı olmalıdır !");
                return;
            }
            else
            {
                SecilenSefer.TahminiVarisSuresi = (int)numTahminiVarisSuresi.Value;
                SecilenSefer.SeferTipiID = (int)cmbSeferTipi.SelectedValue;
                sR.Update(SecilenSefer);

                foreach (SeferDetay item in SecilenSefer.SeferDetay)
                {
                    item.Ucret = (int)numSeferUcreti.Value;
                    item.SeferSaati = txtSeferSaati.Text;
                    sdR.Update(item);
                }

                sgR.DeleteAll(SecilenSefer.IDSefer);

                for (int i = 0; i < lstSeferGuzergahi.Items.Count; i++)
                {
                    SeferGuzergahi sfrGuzergahi = new SeferGuzergahi()
                    {
                        GuzergahID = (lstSeferGuzergahi.Items[i] as Guzergahlar).IDGuzergah,
                        SeferID = SecilenSefer.IDSefer,
                        GuzergahSirasi = (i + 1)
                    };
                    sgR.Insert(sfrGuzergahi);
                }

                MessageBox.Show("Sefer bilgileri başarı ile güncellendi !");
                SeferleriGetir();
                FormTool.FormTemizle(this.Controls);
            }
        }
    }
}
