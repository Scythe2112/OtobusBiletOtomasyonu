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

namespace OOtomasyon.SeferIslemleri.Forms
{
    public partial class frmSeferDetay : Form
    {
        public frmSeferDetay()
        {
            InitializeComponent();
        }

        public SeferDetay SecilenSeferDetay { get; set; }

        PersonelRepository pR = new PersonelRepository();
        OtobusRepository oR = new OtobusRepository();
        SeferRepository sR = new SeferRepository();
        SeferDetayRepository sdR = new SeferDetayRepository();
        SeferPersonelRepository spR = new SeferPersonelRepository();
        ServisRepository servisR = new ServisRepository();

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
            cmbSefer.DataSource = sR.SelectAll().Select(x => new { x.IDSefer, Guzergah = x.SeferGuzergahi.First().Guzergahlar.Guzergah + "->" + x.SeferGuzergahi.Last().Guzergahlar.Guzergah }).ToList();
            cmbSefer.DisplayMember = "Guzergah";
        }

        private void OtobusleriGetir()
        {
            cmbOtobus.ValueMember = "IDOtobus";
            cmbOtobus.DataSource = oR.SelectAll();
            cmbOtobus.DisplayMember = "PlakaNo";

            cmbServisAracı.ValueMember = "IDOtobus";
            cmbServisAracı.DataSource = oR.SelectAll();
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

                foreach (SeferPersonel item in SecilenSeferDetay.SeferPersonel)
                {
                    lstSeferPersonelleri.Items.Add(item.Personel.Ad + " " + item.Personel.Ad + "->" + item.Personel.Unvan);
                }

                if (SecilenSeferDetay.Servis.Count >0)
                {
                    grbServisBilgileri.Visible = true;
                    cmbServisAracı.SelectedValue = SecilenSeferDetay.Servis.Select(x=>x.OtobusID);
                    txtKalkisYeri.Text = SecilenSeferDetay.Servis.Select(x => x.KalkisYeri.ToString()).ToString();
                    txtServisSaati.Text = SecilenSeferDetay.Servis.Select(x => x.KalkisSaati.ToString()).ToString();
                    numServisUcreti.Value = (int)Convert.ToDecimal(SecilenSeferDetay.Servis.Select(x => x.ServisUcreti.ToString()).ToString());
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
                    Tarih = (DateTime)y.SeferTarihi,
                    Saat = y.SeferSaati,
                    Ucret = y.Ucret,
                }).ToList();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            SecilenSeferDetay = null;
            dgvSeferDetaylar.DataSource = null;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

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
                Ucret=numSeferUcreti.Value
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
                    ServisUcreti=numServisUcreti.Value
                    
                };
                servisR.Insert(sfrGuzergahi);
            }


            MessageBox.Show("Sefer başarı ile eklendi Sefer Detay sayfasını kontrol ediniz.");
            SeferleriGetir();
            FormTool.FormTemizle(this.Controls);
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            lstSeferPersonelleri.Items.Add(pR.SelectByID((int)cmbSeferPersonel.SelectedValue));
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            if (lstSeferPersonelleri.Items.Count > 0)
            {
                for (int i = lstSeferPersonelleri.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lstSeferPersonelleri.Items.Remove(lstSeferPersonelleri.SelectedItems[i]);
                }
            }
        }

        private void btnPersonelTemizle_Click(object sender, EventArgs e)
        {
            if (lstSeferPersonelleri.Items.Count > 0)
            {
                lstSeferPersonelleri.Items.Clear();
            }
        }
    }
}
