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

namespace OOtomasyon.MusteriIslemleri
{
    public partial class frmMiMain : Form
    {
        public frmMiMain()
        {
            InitializeComponent();
        }

        SehirlerRepository sehirlerR = new SehirlerRepository();
        MusteriRepository musteriR = new MusteriRepository();
        MusteriKartlariRepository mkR = new MusteriKartlariRepository();

        public Musteri SecilenMusteri { get; set; }


        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSehir.ValueMember = "IDSehir";
            cmbSehir.DataSource = sehirlerR.SelectAll();
            cmbSehir.DisplayMember = "Sehir";

            MusterileriGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            string errorText;

            if (!FormTool.LoginValidation(LoginValidationType.NameSurnameControl, txtAd.Text, out errorText))
            {
                MessageBox.Show(errorText);
                return;
            }
            else if (!FormTool.LoginValidation(LoginValidationType.NameSurnameControl, txtSoyad.Text, out errorText))
            {
                MessageBox.Show(errorText);
                return;
            }
            else if (Convert.ToInt32(cmbSehir.SelectedValue) == -1)
            {
                MessageBox.Show("Lütfen Şehir Alanını Doldurunuz");
                return;
            }
            else if (!FormTool.LoginValidation(LoginValidationType.PhoneControl, txtCepTel.Text, out errorText))
            {
                MessageBox.Show(errorText);
                return;

            }
            else if (!FormTool.LoginValidation(LoginValidationType.TcKimlikControl, txtTc.Text, out errorText))
            {
                MessageBox.Show(errorText);
                return;

            }
            else if (!FormTool.LoginValidation(LoginValidationType.EMailControl, txtEposta.Text, out errorText))
            {
                MessageBox.Show(errorText);
                return;

            }
            else if (!rbBay.Checked && !rbBayan.Checked)
            {
                MessageBox.Show("Lütfen Cinsiyet Alanını Doldurunuz");
                return;

            }
            else
            {
                MusteriEkle();

            }
        }

        private void MusteriEkle()
        {

            MusteriKartlari mk = new MusteriKartlari
            {
                IDKart = Guid.NewGuid().ToString(),
                Bakiye = (decimal)0,
                BiletSayisi = (int)0,
            };

            mkR.Insert(mk);

            Musteri mus = new Musteri
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                TcKimlikNo = txtTc.Text,
                DogumTarihi = Convert.ToDateTime(dtpDogumTarihi.Value),
                EPosta = txtEposta.Text,
                SehirID = Convert.ToInt32(cmbSehir.SelectedValue),
                CepTelefonu = txtCepTel.Text,
                Cinsiyet = rbBay.Checked == true ? "Bay" : "Bayan",
                KartID=mk.IDKart

            };
            musteriR.Insert(mus);

            MessageBox.Show("Müşteri başarı ile eklendi ve Müşteri Kartı oluşturuldu!");

            FormTool.FormTemizle(this.Controls);
            MusterileriGetir();
        }

        private void MusterileriGetir()
        {
            dgvMusteri.DataSource = musteriR.SelectAll().Select(x => new
            {
                MusteriID=x.IDMusteri,
                KartID=x.KartID,
                Ad=x.Ad,
                Soyad=x.Soyad
            }).ToList();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            FormTool.FormTemizle(this.Controls);

            if (SecilenMusteri == null)
            {
                MessageBox.Show("Lütfen Müşteri Seçiniz!");
            }
            else
            {
                grbMusteriKarti.Visible = false;

                txtAd.Text = SecilenMusteri.Ad;
                txtSoyad.Text = SecilenMusteri.Soyad;
                txtTc.Text = SecilenMusteri.TcKimlikNo;
                if (SecilenMusteri.Cinsiyet.Trim() == "Bay") rbBay.Checked = true;
                else if (SecilenMusteri.Cinsiyet.Trim() == "Bayan") rbBayan.Checked = true;

                if (SecilenMusteri.MusteriKartlari!=null)
                {
                dtpDogumTarihi.Value = (DateTime)SecilenMusteri.DogumTarihi;
                txtCepTel.Text = SecilenMusteri.CepTelefonu;
                txtEposta.Text = SecilenMusteri.EPosta;            
                cmbSehir.SelectedValue = SecilenMusteri.SehirID;
                grbMusteriKarti.Visible = true;
                lblBonusPara.Text = SecilenMusteri.MusteriKartlari.Bakiye.ToString();
                lblBonusBilet.Text = SecilenMusteri.MusteriKartlari.BiletSayisi.ToString();
                }

            }
        }

        private void dgvMusteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SecilenMusteri = musteriR.SelectByID(Convert.ToInt32(dgvMusteri.SelectedRows[0].Cells[0].Value));
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (SecilenMusteri == null)
            {
                MessageBox.Show("Müşteri Seçiniz!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Seçilen Müşteri silinecek emin misiniz?", "Silinecek ?",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    string Id = SecilenMusteri.KartID;
                    if (SecilenMusteri.MusteriKartlari!=null)
                    {
                        mkR.Delete(Id);
                    }
                    musteriR.Delete(SecilenMusteri.IDMusteri);
                    MusterileriGetir();
                    FormTool.FormTemizle(this.Controls);
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormTool.FormTemizle(this.Controls);
            MusterileriGetir();
            SecilenMusteri = null;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string errorText;

            if (!FormTool.LoginValidation(LoginValidationType.NameSurnameControl, txtAd.Text, out errorText))
            {
                MessageBox.Show(errorText);
                return;
            }
            else if (!FormTool.LoginValidation(LoginValidationType.NameSurnameControl, txtSoyad.Text, out errorText))
            {
                MessageBox.Show(errorText);
                return;
            }
            else if (Convert.ToInt32(cmbSehir.SelectedValue) == -1)
            {
                MessageBox.Show("Lütfen Şehir Alanını Doldurunuz");
                return;
            }
            else if (!FormTool.LoginValidation(LoginValidationType.PhoneControl, txtCepTel.Text, out errorText))
            {
                MessageBox.Show(errorText);
                return;

            }
            else if (!FormTool.LoginValidation(LoginValidationType.TcKimlikControl, txtTc.Text, out errorText))
            {
                MessageBox.Show(errorText);
                return;

            }
            else if (!FormTool.LoginValidation(LoginValidationType.EMailControl, txtEposta.Text, out errorText))
            {
                MessageBox.Show(errorText);
                return;

            }
            else if (!rbBay.Checked && !rbBayan.Checked)
            {
                MessageBox.Show("Lütfen Cinsiyet Alanını Doldurunuz");
                return;

            }

            SecilenMusteri.Ad = txtAd.Text;
            SecilenMusteri.Soyad = txtSoyad.Text;
            SecilenMusteri.TcKimlikNo = txtTc.Text;
            SecilenMusteri.DogumTarihi = Convert.ToDateTime(dtpDogumTarihi.Value);
            SecilenMusteri.EPosta = txtEposta.Text;
            SecilenMusteri.SehirID = Convert.ToInt32(cmbSehir.SelectedValue);
            SecilenMusteri.CepTelefonu = txtCepTel.Text;
            SecilenMusteri.Cinsiyet = rbBay.Checked == true ? "Bay" : "Bayan";
            musteriR.Update(SecilenMusteri);
            MusterileriGetir();

        }
    }
}