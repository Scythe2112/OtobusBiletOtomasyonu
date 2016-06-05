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

namespace OOtomasyon.SubeIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GuzergahlarRepository guzergahlarR = new GuzergahlarRepository();
        SubeRepository subeR = new SubeRepository();

        public Sube SecilenSube { get; set; }

        private void Main_Load(object sender, EventArgs e)
        {
            cmbGuzergah.ValueMember = "IDGuzergah";
            cmbGuzergah.DataSource = guzergahlarR.SelectAll();
            cmbGuzergah.DisplayMember = "Guzergah";

            SubeleriGetir();
        }

        private void SubeleriGetir()
        {
            dgvSubeler.DataSource = subeR.SelectAll().Select(x => new
            {
                SubeID=x.IDSube,
                Adi=x.Adi,
                Guzergah=x.Guzergahlar.Guzergah

            }).ToList();
        }

        private void SubeEkle()
        {
            Sube sub = new Sube
            {
                Adi = txtSubeAdi.Text,
                Telefon = txtTelefon.Text,
                Fax = txtFax.Text,
                Adres = txtAdres.Text,
                GuzergahID = Convert.ToInt32(cmbGuzergah.SelectedValue)
                
            };

            subeR.Insert(sub);
            MessageBox.Show("Şube başarıyla eklendi!");
            FormTool.FormTemizle(this.Controls);
            SubeleriGetir();
        }

        private void dgvSubeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SecilenSube = subeR.SelectByID(Convert.ToInt32(dgvSubeler.SelectedRows[0].Cells[0].Value));
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string errorText;

            if (string.IsNullOrEmpty(txtSubeAdi.Text.Trim()) && txtSubeAdi.Text.Trim().Length<5)
            {
                MessageBox.Show("Sube Adı alanı en az 5 harften oluşmalıdır !");
                return;
            }
            else if (!FormTool.LoginValidation(LoginValidationType.PhoneControl, txtTelefon.Text.Trim(), out errorText))
            {
                MessageBox.Show(errorText);
                return;
            }
            else if (Convert.ToInt32(cmbGuzergah.SelectedValue) == -1)
            {
                MessageBox.Show("Lütfen Güzergah Alanını Doldurunuz");
                return;
            }
            else if (!FormTool.LoginValidation(LoginValidationType.PhoneControl, txtFax.Text.Trim(), out errorText))
            {
                MessageBox.Show("Fax Alanı Hatalı !");
                return;

            }
            else if (string.IsNullOrEmpty(txtAdres.Text.Trim()) || txtAdres.Text.Trim().Length < 10)
            {
                MessageBox.Show("Adres Alanı boş bırakılamaz ve 10 harften küçük olamaz !");
                return;
            }
            else
            {
                SubeEkle();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (SecilenSube == null)
            {
                MessageBox.Show("Şube Seçiniz!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Seçilen Şube silinecek emin misiniz?", "Silinecek ?",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        subeR.Delete(SecilenSube.IDSube);
                        SubeleriGetir();
                        FormTool.FormTemizle(this.Controls);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormTool.FormTemizle(this.Controls);
            SubeleriGetir();
            SecilenSube = null;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            if (SecilenSube == null)
            {
                MessageBox.Show("Lütfen Şube Seçiniz!");
            }
            else
            {
                txtSubeAdi.Text = SecilenSube.Adi;
                txtTelefon.Text = SecilenSube.Telefon;
                txtFax.Text = SecilenSube.Fax;
                txtAdres.Text = SecilenSube.Adres;
                cmbGuzergah.SelectedValue = Convert.ToInt32(SecilenSube.GuzergahID);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string errorText;

            if (SecilenSube==null)
            {
                MessageBox.Show("Lütfen Şube Seçiniz !");
            }
            else if (string.IsNullOrEmpty(txtSubeAdi.Text.Trim()) && txtSubeAdi.Text.Trim().Length < 5)
            {
                MessageBox.Show("Sube Adı alanı en az 5 harften oluşmalıdır !");
                return;
            }
            else if (!FormTool.LoginValidation(LoginValidationType.PhoneControl, txtTelefon.Text.Trim(), out errorText))
            {
                MessageBox.Show(errorText);
                return;
            }
            else if (Convert.ToInt32(cmbGuzergah.SelectedValue) == -1)
            {
                MessageBox.Show("Lütfen Güzergah Alanını Doldurunuz");
                return;
            }
            else if (!FormTool.LoginValidation(LoginValidationType.PhoneControl, txtFax.Text.Trim(), out errorText))
            {
                MessageBox.Show("Fax Alanı Hatalı !");
                return;

            }
            else if ( string.IsNullOrEmpty(txtAdres.Text.Trim()) || txtAdres.Text.Trim().Length<10)
            {
                MessageBox.Show("Adres Alanı boş bırakılamaz ve 10 harften küçük olamaz !");
                return;
            }
            else
            {
                SecilenSube.Adi = txtSubeAdi.Text;
                SecilenSube.Telefon = txtTelefon.Text;
                SecilenSube.Fax = txtFax.Text;
                SecilenSube.Adres = txtAdres.Text;
                SecilenSube.GuzergahID = Convert.ToInt32(cmbGuzergah.SelectedValue);
                subeR.Update(SecilenSube);
                SubeleriGetir();
                MessageBox.Show("Şube bilgileri başarıyla güncellendi !");
            }
        }
    }
}
