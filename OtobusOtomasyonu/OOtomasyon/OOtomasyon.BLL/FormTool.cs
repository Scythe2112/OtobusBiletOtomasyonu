using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOtomasyon.DAL;
using System.Security.Cryptography;

namespace OOtomasyon.BLL
{
    public class FormTool
    {
        public static void FormTemizle(Control.ControlCollection koleksiyon)
        {
            foreach (Control item in koleksiyon)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
                else if (item is CheckBox)
                {
                    CheckBox chk = (CheckBox)item;
                    chk.Checked = false;
                }
                else if (item is DateTimePicker)
                {
                    DateTimePicker dt = item as DateTimePicker;
                    dt.Value = DateTime.Now;
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = 0;
                }
                else if (item is NumericUpDown)
                {
                    (item as NumericUpDown).Value = 0;
                }
                else if (item is Panel)
                {
                    FormTemizle((item as Panel).Controls);
                }
                else if (item is GroupBox)
                {
                    FormTemizle((item as GroupBox).Controls);
                }
                else if (item is ListBox)
                {
                    (item as ListBox).Items.Clear();
                }
            }
        }

        public static void FormKontroluYap(Form gelenForm, Form parentForm)
        {
            bool acikMi = false;

            foreach (Form item in parentForm.MdiChildren)
            {
                if (item.Text == gelenForm.Text)
                    acikMi = true;
            }

            if (!acikMi)
            {
                gelenForm.MdiParent = parentForm;
                gelenForm.WindowState = FormWindowState.Maximized;
                gelenForm.Show();
            }
        }

        public static bool LoginValidation(LoginValidationType type, string value, out string errorText)
        {
            bool result = true;
            errorText = "Başarılı";
            switch (type)
            {
                case LoginValidationType.NameSurnameControl:

                    #region NameSurnameControl

                    if (value.Trim().Length == 0)
                    {
                        errorText = "Ad ve Soyad alanları boş bırakılamaz!";
                        result = false;
                    }
                    else if (value.Trim().Length < 3 || value.Trim().Length > 20)
                    {
                        errorText = "Ad ve Soyad 3 karakterden küçük 20 karakterden büyük olamaz!";
                        result = false;
                    }
                    else
                    {
                        foreach (char item in value)
                        {
                            if (Char.IsLetterOrDigit(item))
                            {
                                if (Char.IsDigit(item))
                                {
                                    errorText = "Ad ve Soyad rakam içeremez!";
                                    result = false;
                                    break;
                                }
                            }
                            else
                            {
                                errorText = "Ad ve Soyad alanları alfanumeric karakter içeremez!";
                                result = false;
                                break;
                            }

                        }
                    }
                    break;
                #endregion

                case LoginValidationType.EMailControl:

                    #region EMailControl
                    if (value.Trim().Length != 0)
                    {
                        //@ isareti yoksa ya da birden fazla varsa;
                        if (value.IndexOf('@') == -1 || value.LastIndexOf('@') != value.IndexOf('@'))
                        {
                            errorText = "Lütfen e-posta adresinizi doğru formatta giriniz";
                            result = false;
                            break;
                        }
                        //. ile @ arasında en az 1 karakter yoksa ya da . adresin sonuna yazıldıysa
                        if ((value.LastIndexOf('.') - value.IndexOf('@')) <= 1 || value.LastIndexOf('.') == value.Length - 1)
                        {
                            errorText = "Lütfen e-posta adresinizi doğru formatta giriniz";
                            result = false;
                            break;
                        }
                    }
                    else
                    {
                        errorText = "Lütfen e-posta alanını doldurunuz.!";
                        result = false;
                        break;
                    }

                    break;
                #endregion

                case LoginValidationType.PhoneControl:

                    #region PhoneControl

                    if (value.Trim().Length != 0)
                    {
                        if (value.Length != 10)
                        {
                            errorText = "Lütfen Telefon numarasını 10 haneli olacak şekilde giriniz!";
                            result = false;
                        }

                        else
                        {
                            foreach (char item in value)
                            {
                                if (Char.IsLetterOrDigit(item))
                                {
                                    if (Char.IsLetter(item))
                                    {
                                        errorText = "Telefon numarası harf içeremez!";
                                        result = false;
                                        break;
                                    }
                                }
                                else
                                {
                                    errorText = "Telefon numarası alfanumeric karakter içeremez!";
                                    result = false;
                                    break;
                                }

                            }
                        }
                    }
                    else
                    {
                        errorText = "Telefon numarası boş bırakılamaz!";
                        result = false;
                    }
                    break;
                #endregion

                case LoginValidationType.PasswordControl:

                    #region PasswordControl


                    if (value.Trim().Length == 0)
                    {
                        errorText = "Parola boş bırakılamaz!";
                        result = false;
                    }
                    else if (value.Trim().Length < 4 || value.Trim().Length > 20)
                    {
                        errorText = "Parola 4 karakterden küçük 20 karakterden büyük olamaz!";
                        result = false;
                    }

                    break;
                #endregion

                case LoginValidationType.UserName:

                    #region UserName


                    if (value.Trim().Length == 0)
                    {
                        errorText = "Kullanıcı Adı boş bırakılamaz!";
                        result = false;
                    }
                    else
                    {
                        foreach (char item in value)
                        {
                            if (!Char.IsLetterOrDigit(item))
                            {
                                errorText = "Kullanıcı Adı alfanumeric karakter içeremez!";
                                result = false;
                                break;
                            }
                        }
                    }

                    break;
                #endregion

                case LoginValidationType.TcKimlikControl:

                    #region TcKimlikControl


                    if (value.Trim().Length == 0)
                    {
                        errorText = "Tc Kimlik boş bırakılamaz!";
                        result = false;
                    }
                    else if (value.Trim().Length != 11)
                    {
                        errorText = "Tc Kimlik 11 Rakamdan oluşmalıdır.!";
                        result = false;
                    }
                    else
                    {
                        foreach (char item in value)
                        {
                            if (Char.IsLetterOrDigit(item))
                            {
                                if (Char.IsLetter(item))
                                {
                                    errorText = "TC Kimlik Numarası karakter içeremez!";
                                    result = false;
                                    break;
                                }
                            }
                            else
                            {
                                errorText = "TC Kimlik Numarası alfanumeric karakter içeremez!";
                                result = false;
                                break;
                            }

                        }
                    }

                    break;
                    #endregion

            }

            return result;
        }

        public static string MD5Hash(string metin)
        {
            // MD5CryptoServiceProvider nesnenin yeni bir instance'sını oluşturalım.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            //Girilen veriyi bir byte dizisine dönüştürelim ve hash hesaplamasını yapalım.
            byte[] btr = Encoding.UTF8.GetBytes(metin);
            btr = md5.ComputeHash(btr);

            //byte'ları biriktirmek için yeni bir StringBuilder ve string oluşturalım.
            StringBuilder sb = new StringBuilder();

            //hash yapılmış her bir byte'ı dizi içinden alalım ve her birini hexadecimal string olarak formatlayalım.
            foreach (byte ba in btr)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            //hexadecimal(onaltılık) stringi geri döndürelim.
            return sb.ToString();
        }
    }
}
