using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using OOtomasyon.BLL;

namespace OOtomasyon
{
    public partial class frmUiLogin : Form
    {

        public frmUiLogin()
        {
            InitializeComponent();
        }

        LoginRepository loginR = new LoginRepository();
        VardiyaKayitlariRepository vardiyaR = new VardiyaKayitlariRepository();

        private void Login_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void EkranGecisi_Tick(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string errorTextValidation;
            string errorTextControl;
            string kullaniciAdi = txtKullaniciAdi.Text;
            string parola = txtParola.Text;
            Personel personel = loginR.LoginControl(kullaniciAdi, FormTool.MD5Hash(parola), out errorTextControl);

            if (!FormTool.LoginValidation(LoginValidationType.UserName, kullaniciAdi, out errorTextValidation))
            {
                lblError.Visible = true;
                lblError.Text = errorTextValidation;
                lblError.BackColor = Color.DarkGray;
                lblError.ForeColor = Color.Red;
                return;
            }
            else if (!FormTool.LoginValidation(LoginValidationType.PasswordControl, parola, out errorTextValidation))
            {
                lblError.Visible = true;
                lblError.Text = errorTextValidation;
                lblError.BackColor = Color.DarkGray;
                lblError.ForeColor = Color.Red;
                return;
            }
            else if (personel == null)
            {
                lblError.Visible = true;
                lblError.Text = errorTextControl;
                lblError.BackColor = Color.DarkGray;
                lblError.ForeColor = Color.Red;
                return;
            }
            else
            {
                frmUiPersonel menuForm = new frmUiPersonel();
                frmUiPersonel.GirisYapanPersonel = personel;
                VardiyaKayitlari vardiyaKaydi = new VardiyaKayitlari()
                {
                    PersonelID = personel.IDPersonel,
                    LoginGirisTarihi = DateTime.Now
                };
                vardiyaR.Insert(vardiyaKaydi);

                menuForm.Show();
                this.Visible = false;
            }
        }

        private void frmUiLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
