using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOtomasyon.DAL;
using OOtomasyon.BLL.Repositories;
using OOtomasyon.BLL;

namespace OOtomasyon
{
    public partial class frmUiPersonel : Form
    {
        public frmUiPersonel()
        {
            InitializeComponent();
        }

        public static Personel GirisYapanPersonel { get; set; }

        ModulRepository modulR = new ModulRepository();
        VardiyaKayitlariRepository vardiyaR = new VardiyaKayitlariRepository();
        PersonelRepository personelR = new PersonelRepository();

        private void PersonelSayfasi_Load(object sender, EventArgs e)
        {
            CalisanBilgiGetir();

            List<Modul> pModul = personelR.SelectModulsByID(GirisYapanPersonel.IDPersonel);

            foreach (Modul mdlitem in pModul)
            {
                ToolStripMenuItem menuitem = new ToolStripMenuItem();
                menuitem.Text = mdlitem.ModulAdi;

                foreach (Formlar frmitem in mdlitem.Formlar)
                {
                    if (GirisYapanPersonel.Yetki.FirstOrDefault(x=>x.Formlar==frmitem)!=null)
                    {
                    ToolStripMenuItem submenuitem = new ToolStripMenuItem();
                    submenuitem.Text = frmitem.FormAdi;
                    submenuitem.Tag = "OOtomasyon." + mdlitem.Modul1 + "." + frmitem.Form;
                    submenuitem.Click += Submenuitem_Click;
                    menuitem.DropDownItems.Add(submenuitem);
                    }
                }
                menu.Items.Add(menuitem);
            }
        }

        private void Submenuitem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem capture = sender as ToolStripMenuItem;
            Type type = Type.GetType(capture.Tag.ToString());
            Form thisFrm = (Form)Activator.CreateInstance(type);
            FormTool.FormKontroluYap(thisFrm, this);
        }

        private void CalisanBilgiGetir()
        {
            VardiyaKayitlari vardiyaSon = vardiyaR.SelectAll().Where(x => x.PersonelID == GirisYapanPersonel.IDPersonel).OrderByDescending(y => y.LoginGirisTarihi).Take(2).LastOrDefault();

            statuslbl.Text= "Sayın : "+GirisYapanPersonel.Ad + " " + GirisYapanPersonel.Soyad+", Son Vardıya Kaydı: "+string.Format("{0:g}", vardiyaSon.LoginGirisTarihi) + " - " + string.Format("{0:g}", vardiyaSon.LoginCikisTarihi) +", Son Giriş Zamanı:  "+string.Format("{0:g}", GirisYapanPersonel.VardiyaKayitlari.OrderByDescending(x => x.LoginGirisTarihi).Take(1).FirstOrDefault().LoginGirisTarihi.Value);

        }

        private void frmUiPersonel_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış Yapmak İstediğinize Emin misiniz?", "Oturum Kapanış ?",
MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int vardiyaId = vardiyaR.SelectAll().Where(x => x.PersonelID == GirisYapanPersonel.IDPersonel).OrderByDescending(y => y.LoginGirisTarihi).Take(1).FirstOrDefault().IDVardiye;
                VardiyaKayitlari cikis=vardiyaR.SelectByID(vardiyaId);
                cikis.LoginCikisTarihi = DateTime.Now;
                vardiyaR.Update(cikis);
                e.Cancel = false;

                frmUiLogin login = new frmUiLogin();
                login.Show();
                this.Visible = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
