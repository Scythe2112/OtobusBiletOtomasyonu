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
    public partial class GirisSayfasi : Form
    {

        public GirisSayfasi()
        {
            InitializeComponent();
        }

        LoginRepository loginR = new LoginRepository();

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string errorTextValidation;
            string errorTextControl;
            string kullaniciAdi = txtKullaniciAdi.Text;
            string parola = txtParola.Text;

            if (!FormTool.LoginValidation(LoginValidationType.UserName, kullaniciAdi, out errorTextValidation))
            {
                lblError.Text = errorTextValidation;
                lblError.BackColor = Color.White;
                lblError.ForeColor = Color.Red;
                return;
            }
            else if (!FormTool.LoginValidation(LoginValidationType.PasswordControl, parola, out errorTextValidation))
            {
                lblError.Text = errorTextValidation;
                lblError.BackColor = Color.White;
                lblError.ForeColor = Color.Red;
                return;
            }
            else if (loginR.LoginControl(kullaniciAdi, FormTool.MD5Hash(parola), out errorTextControl) == null)
            {
                lblError.Text = errorTextControl;
                lblError.BackColor = Color.White;
                lblError.ForeColor = Color.Red;
                return;
            }
            else
            {
                PersonelSayfasi menuForm = new PersonelSayfasi();
                PersonelSayfasi.GirisYapanPersonel = loginR.LoginControl(kullaniciAdi, parola, out errorTextControl);
                menuForm.Show();
                this.Visible = false;
                
            }
        }
    }
}
