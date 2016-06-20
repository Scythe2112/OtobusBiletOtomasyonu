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

namespace OOtomasyon.PersonelIslemleri
{
    public partial class frmPeiMain : Form
    {
        public frmPeiMain()
        {
            InitializeComponent();
        }

        PersonelRepository personelRep = new PersonelRepository();
        SehirlerRepository sehirRep = new SehirlerRepository();
        UnvanRepository unRep = new UnvanRepository();
        SubeRepository subRep = new SubeRepository();
        LoginRepository loginR = new LoginRepository();

        public Personel SecilenPersonel { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSehirP.ValueMember = "IDSehir";
            cmbSehirP.DataSource = sehirRep.SelectAll();
            cmbSehirP.DisplayMember = "Sehir";

            cmbUnvan.ValueMember = "IDUnvan";
            cmbUnvan.DataSource = unRep.SelectAll();
            cmbUnvan.DisplayMember = "Unvan";

            cmbSube.ValueMember = "IDSube";
            cmbSube.DataSource = subRep.SelectAll();
            cmbSube.DisplayMember = "Adi";

            PersonelGetir();


        }

        private void PersonelGetir()
        {
            dgvPersonel.DataSource = personelRep.SelectAll().Select(x => new
            {
                PersonelID = x.IDPersonel,
                Unvan = x.Unvanlar.Unvan,
                Ad = x.Ad,
                Soyad = x.Soyad,
                Sube = x.Sube.Adi

            }).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string errorText;

            if (!FormTool.LoginValidation(LoginValidationType.NameSurnameControl, txtAdP.Text,out errorText))
            {
                MessageBox.Show(errorText);
                return;
            }
            else if (!FormTool.LoginValidation(LoginValidationType.NameSurnameControl, TxtSoyadP.Text, out errorText))
            {
                MessageBox.Show(errorText);
                return;
            }
            else if (Convert.ToInt32(cmbSehirP.SelectedValue) == -1)
            {
                MessageBox.Show("Lütfen Şehir Alanını Doldurunuz");
                return;
            }
            else if (!FormTool.LoginValidation(LoginValidationType.PhoneControl, txtCepTelP.Text, out errorText))
            {
                MessageBox.Show(errorText);
                return;

            }            
            else if (!FormTool.LoginValidation(LoginValidationType.TcKimlikControl, txtTCKNP.Text, out errorText))
            {
                MessageBox.Show(errorText);
                return;

            }
            else if (Convert.ToInt32(cmbSube.SelectedValue) == -1)
            {
                MessageBox.Show("Lütfen Şube Alanını Doldurunuz");
                return;

            }
            else if (Convert.ToInt32(cmbUnvan.SelectedValue) == -1)
            {
                cmbUnvan.BackColor = Color.Red;
                MessageBox.Show("Lütfen Ünvan Alanını Doldurunuz");
                return;

            }
            else
            {

                if (Convert.ToInt32(cmbUnvan.SelectedValue) != 1 && Convert.ToInt32(cmbUnvan.SelectedValue) != 4)
                {

                    if ( string.IsNullOrEmpty(txtParola.Text) || string.IsNullOrEmpty(txtParolaTekrar.Text))
                    {
                        MessageBox.Show("Parola Oluşturma Alanlarını doldurunuz!");
                        return;
                    }
                    else if (txtParola.Text.Length <4)
                    {
                        MessageBox.Show("Parola en az 4 karakterden oluşmalıdır!");
                        return;
                    }
                    else if(txtParola.Text!= txtParolaTekrar.Text)
                    {
                        MessageBox.Show("Parolalar uyuşmuyor");
                        return;
                    }
                    else
                    {
                        PersonelEkle(true);
                    }
                }
                else
                {
                    PersonelEkle(false);
                }


            }
        }

        private void PersonelEkle(bool durum)
        {
            Personel per = new Personel
            {
                Ad = txtAdP.Text,
                Soyad = TxtSoyadP.Text,
                Unvan = Convert.ToInt32(cmbUnvan.SelectedValue),
                TcKimlikNo = txtTCKNP.Text,
                DogumTarihi = Convert.ToDateTime(dtpDogumTarihiP.Value),
                Aciklama = txtAciklamaP.Text,
                EvTelefonu = txtEvTelP.Text,
                CepTelefonu = txtCepTelP.Text,
                IseGirisTarihi = Convert.ToDateTime(dtpIseGirisTarihiP.Value),
                Adres = txtAdresP.Text,
                SehirID = Convert.ToInt32(cmbSehirP.SelectedValue),
                SubeID = Convert.ToInt32(cmbSube.SelectedValue)
            };
            personelRep.Insert(per);
            MessageBox.Show("Personel başarıyla eklendi!");

            if (durum)
            {
                Login log = new Login {
                    PersonelID = per.IDPersonel,
                    KullaniciAdi = per.Ad.Substring(0, 2) + per.Soyad.Substring(0, 2) + per.TcKimlikNo.Substring(0, 2),
                    Parola=FormTool.MD5Hash(txtParola.Text)
                };
                loginR.Insert(log);
            MessageBox.Show(" Parola Oluşturuldu!");

            }

            FormTool.FormTemizle(this.Controls);
            PersonelGetir();
        }

        private void cmbUnvan_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormTool.FormTemizle(grbParolaOlusturma.Controls);

            if (Convert.ToInt32(cmbUnvan.SelectedValue) != 1 && Convert.ToInt32(cmbUnvan.SelectedValue) != 4)
            {
                grbParolaOlusturma.Visible = true;
            }
            else
            {
                grbParolaOlusturma.Visible = false;
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            if (SecilenPersonel==null)
            {
                MessageBox.Show("Lütfen Personel Seçiniz!");
            }
            else
            {
                txtAdP.Text = SecilenPersonel.Ad;
                TxtSoyadP.Text = SecilenPersonel.Soyad;
                cmbUnvan.SelectedValue = SecilenPersonel.Unvan;
                txtTCKNP.Text = SecilenPersonel.TcKimlikNo;
                dtpDogumTarihiP.Value = (DateTime)SecilenPersonel.DogumTarihi;
                txtAciklamaP.Text = SecilenPersonel.Aciklama;
                txtEvTelP.Text = SecilenPersonel.EvTelefonu;
                txtCepTelP.Text = SecilenPersonel.CepTelefonu;
                dtpIseGirisTarihiP.Value = (DateTime)SecilenPersonel.IseGirisTarihi;
                txtAdresP.Text = SecilenPersonel.Adres;
                cmbSehirP.SelectedValue = SecilenPersonel.SehirID;
                cmbSube.SelectedValue = SecilenPersonel.SubeID;
            }
        }

        private void dgvPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SecilenPersonel = personelRep.SelectByID(Convert.ToInt32(dgvPersonel.SelectedRows[0].Cells[0].Value));
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (SecilenPersonel==null)
            {
                MessageBox.Show("Personel Seçiniz!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Seçilen Personel silinecek emin misiniz?", "Silinecek ?",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    personelRep.Delete(SecilenPersonel.IDPersonel);
                    PersonelGetir();
                    FormTool.FormTemizle(this.Controls);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtParola.Text))
            {
                 if (txtParola.Text.Length < 4)
                {
                    MessageBox.Show("Parola en az 4 karakterden oluşmalıdır!");
                    return;
                }
                else if (txtParola.Text != txtParolaTekrar.Text)
                {
                    MessageBox.Show("Parolalar uyuşmuyor");
                    return;
                }
                else
                {
                    if (SecilenPersonel.Login==null)
                    {
                        Login log = new Login
                        {
                            PersonelID = SecilenPersonel.IDPersonel,
                            KullaniciAdi = SecilenPersonel.Ad.Substring(0, 2) + SecilenPersonel.Soyad.Substring(0, 2) + SecilenPersonel.TcKimlikNo.Substring(0, 2),
                            Parola = FormTool.MD5Hash(txtParola.Text)
                        };
                        loginR.Insert(log);
                    }

                    SecilenPersonel.Login.Parola = FormTool.MD5Hash(txtParola.Text);
                }
            }

            SecilenPersonel.Ad = txtAdP.Text;
            SecilenPersonel.Soyad = TxtSoyadP.Text;
            SecilenPersonel.Unvan = Convert.ToInt32(cmbUnvan.SelectedValue);
            SecilenPersonel.TcKimlikNo = txtTCKNP.Text;
            SecilenPersonel.DogumTarihi = Convert.ToDateTime(dtpDogumTarihiP.Value);
            SecilenPersonel.Aciklama = txtAciklamaP.Text;
            SecilenPersonel.EvTelefonu = txtEvTelP.Text;
            SecilenPersonel.CepTelefonu = txtCepTelP.Text;
            SecilenPersonel.IseGirisTarihi = Convert.ToDateTime(dtpIseGirisTarihiP.Value);
            SecilenPersonel.Adres = txtAdresP.Text;
            SecilenPersonel.SehirID = Convert.ToInt32(cmbSehirP.SelectedValue);
            SecilenPersonel.SubeID = Convert.ToInt32(cmbSube.SelectedValue);
            personelRep.Update(SecilenPersonel);
            PersonelGetir();
            FormTool.FormTemizle(grbParolaOlusturma.Controls);
            MessageBox.Show("Personel bilgileri başarıyla güncellendi.");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormTool.FormTemizle(this.Controls);
            PersonelGetir();
            SecilenPersonel = null;
        }
    }
}

