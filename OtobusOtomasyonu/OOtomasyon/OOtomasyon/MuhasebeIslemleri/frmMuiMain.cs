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

namespace OOtomasyon.MuhasebeIslemleri
{
    public partial class frmMuiMain : Form
    {
        public frmMuiMain()
        {
            InitializeComponent();
        }

        SeferRepository seferR = new SeferRepository();
        SeferDetayRepository seferDetayR = new SeferDetayRepository();
        HarcamaTipleriRepository harcamaTipleriR = new HarcamaTipleriRepository();
        HarcamalarRepository harcamalarR = new HarcamalarRepository();

        private void frmMuiMain_Load(object sender, EventArgs e)
        {
            HarcamaTipleriGetir();
            SeferGetir();
        }

        private void SeferGetir()
        {
            cmbSefer.ValueMember = "IDSefer";
            cmbSefer.DataSource = seferR.SelectAll().Select(x => new { x.IDSefer, Guzergah = x.SeferGuzergahi.First().Guzergahlar.Guzergah + " -> " + x.SeferGuzergahi.Last().Guzergahlar.Guzergah }).ToList();
            cmbSefer.DisplayMember = "Guzergah";

        }

        private void HarcamaTipleriGetir()
        {
            cmbHarcamaTipleri.ValueMember = "IDHarcamaTipi";
            cmbHarcamaTipleri.DisplayMember = "HarcamaTipi";
            cmbHarcamaTipleri.DataSource = harcamaTipleriR.SelectAll();

            cmbHarcamaTipleri2.ValueMember = "IDHarcamaTipi";
            cmbHarcamaTipleri2.DisplayMember = "HarcamaTipi";
            cmbHarcamaTipleri2.DataSource = harcamaTipleriR.SelectAll();
        }

        private void btnHarcamaTipiEkle_Click(object sender, EventArgs e)
        {
            string harcamatipi = txtHarcamaTipi.Text.Trim();

            if (harcamatipi.Length < 4)
            {
                MessageBox.Show("Harcama Tipi en az 5 karakterden oluşmalıdır.");
                return;
            }
            else if (harcamaTipleriR.HarcamaTipiVarMi(harcamatipi))
            {
                MessageBox.Show("Harcama Tipi kayıtlarda mevcuttur !");
                return;
            }
            else
            {
                HarcamaTipleri harcamatipleri = new HarcamaTipleri
                {
                    HarcamaTipi = harcamatipi
                };
                harcamaTipleriR.Insert(harcamatipleri);

                MessageBox.Show("Harcama Tipi başarıyla eklendi.");
                HarcamaTipleriGetir();
                txtHarcamaTipi.Text = string.Empty;
            }
        }

        private void btnHarcamaTipiSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbHarcamaTipleri.SelectedIndex != -1)
                {
                    DialogResult result = MessageBox.Show("Seçilen Harcama Tipi silinecektir?", "Emin misin ?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        HarcamaTipleri deleted = cmbHarcamaTipleri.SelectedItem as HarcamaTipleri;

                        harcamaTipleriR.Delete(deleted.IDHarcamaTipi);
                        MessageBox.Show("Harcama Tipi başarıyla silindi.");
                        HarcamaTipleriGetir();
                        txtHarcamaTipi.Text = string.Empty;

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Harcama Tipi'nin bağlantılı olduğu kayıtlar mevcut, silme işlemi başarısız !");
                return;
            }
        }

        private void btnHarcamaTipiGuncelle_Click(object sender, EventArgs e)
        {
            if (cmbHarcamaTipleri.SelectedIndex != -1)
            {
                string harcamatipi = txtHarcamaTipi.Text.Trim();

                if (harcamatipi.Length < 4)
                {
                    MessageBox.Show("Harcama Tipi en az 5 karakterden oluşmalıdır.");
                    return;
                }
                else
                {
                    HarcamaTipleri harcamatipleri = harcamaTipleriR.SelectByID((int)cmbHarcamaTipleri.SelectedValue);
                    harcamatipleri.HarcamaTipi = harcamatipi;
                    harcamaTipleriR.Update(harcamatipleri);
                    MessageBox.Show("Harcama Tipi başarıyla güncellendi.");
                    HarcamaTipleriGetir();
                    txtHarcamaTipi.Text = string.Empty;
                }
            }
        }

        private void cmbSefer_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeferDetayGetir();
        }

        private void SeferDetayGetir()
        {
            if (cmbSefer.SelectedIndex!=-1)
            {
                Sefer sfr = seferR.SelectByID((int)cmbSefer.SelectedValue);

                cmbSeferDetay.ValueMember = "ID";

                cmbSeferDetay.DataSource=sfr.SeferDetay.Select(y => new
                {
                    ID = y.IDSeferDetay,
                    Tarih = string.Format("{0:dd.MMMM.yyyy}", (DateTime)y.SeferTarihi)
                }).OrderByDescending(s => s.ID).ToList();

                cmbSeferDetay.DisplayMember = "Tarih";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbSefer.SelectedIndex==-1)
            {
                MessageBox.Show("Lütfen Sefer seçin !");
                return;
            }
            else if (cmbSeferDetay.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Sefer Detay seçin !");
                return;
            }
            else if (cmbHarcamaTipleri2.SelectedIndex ==-1)
            {
                MessageBox.Show("Lütfen Harcama Tipi seçin !");
                return;
            }
            else if (numHarcamaUcreti.Value<=0)
            {
                MessageBox.Show("Lütfen Harcama Ücreti 0'dan büyük olmalıdır !");
                return;
            }

            Harcamalar hrcm = new Harcamalar()
            {
                Aciklama=txtAciklama.Text ?? "Açıklama Yok",
                HarcamaTipiID= (int)cmbHarcamaTipleri2.SelectedValue,
                SeferDetayID= (int)cmbSeferDetay.SelectedValue,
                Ucret=numHarcamaUcreti.Value
            };
            harcamalarR.Insert(hrcm);
            MessageBox.Show("Harcama başarıyla eklendi.");
            txtAciklama.Text = string.Empty;
            numHarcamaUcreti.Value = 0;
            cmbHarcamaTipleri2.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvSeferDetayHarcamalari.DataSource = null;

            if (cmbSeferDetay.SelectedIndex != -1)
            {
                SeferDetay sfrDty = seferDetayR.SelectByID((int)cmbSeferDetay.SelectedValue);

                if (sfrDty.Harcamalar.Count>0)
                {
                    var hr= sfrDty.Harcamalar.Select(h => new
                    {
                        HarcamaTipi = h.HarcamaTipleri.HarcamaTipi,
                        Ucret = h.Ucret,
                        Acikalama = h.Aciklama
                    }).OrderByDescending(s => s.Ucret).ToList();

                    dgvSeferDetayHarcamalari.DataSource = hr;
                    lblMiktar.Text = "Toplam Harcama Toplamı : " + hr.Sum(x => x.Ucret).ToString() + " TL";
                }
                else
                {
                    MessageBox.Show("Sefer Detaya ait Harcama bulunamadı !");
                    lblMiktar.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Lütfen Sefer Detay Seçiniz !");
                return;
            }
        }
    }
}
