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

namespace OOtomasyon.YetkiIslemleri
{
    public partial class frmYiMain : Form
    {
        public frmYiMain()
        {
            InitializeComponent();
        }

        PersonelRepository personelR = new PersonelRepository();
        ModulRepository modulR = new ModulRepository();
        FormlarRepository formlarR = new FormlarRepository();
        YetkiRepository yetkiR = new YetkiRepository();
        YetkiTipleriRepository yetkiTurleriR = new YetkiTipleriRepository();

        public static List<Yetki> Yetkiler { get; set; } = new List<Yetki>();

        private void Form1_Load(object sender, EventArgs e)
        {
            PersonelGetir();
            ModulGetir();
            YetkiTipiGetir();
        }

        private void YetkiTipiGetir()
        {
            lstYetkiTipleri.ValueMember = "YetkiTipleri1";
            lstYetkiTipleri.DataSource = yetkiTurleriR.SelectAll().ToList();
            lstYetkiTipleri.DisplayMember = "YetkiAdi";
        }

        private void ModulGetir()
        {
            cmbModul.ValueMember = "IDModul";
            cmbModul.DataSource = modulR.SelectAll().ToList();
            cmbModul.DisplayMember = "ModulAdi";
        }

        private void PersonelGetir()
        {
            cmbPersonel.ValueMember = "IDPersonel";
            cmbPersonel.DataSource = personelR.SelectAll().Select(per => new { adSoyad = per.Ad + " " + per.Soyad, per.IDPersonel }).ToList();
            cmbPersonel.DisplayMember = "adSoyad";

        }

        private void cmbModul_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secilenModulid = Convert.ToInt32(cmbModul.SelectedValue);
            if (secilenModulid != 0)
            {
                lstFormlar.ValueMember = "IDForm";
                lstFormlar.DataSource = formlarR.SelectAll().Where(f => f.ModulID == secilenModulid).ToList();
                lstFormlar.DisplayMember = "FormAdi";
            }
        }

        private void btnFormEkle_Click(object sender, EventArgs e)
        {
            string formadi = txtFormAdi.Text;
            string form = txtForm.Text;

            int modulid = Convert.ToInt32(cmbModul.SelectedValue);
            if (formlarR.FormControl(form, modulid) == null)
            {
                formlarR.Insert(new Formlar() { Form = form, FormAdi = formadi, ModulID = modulid });
                MessageBox.Show("Kayıt Başarı ile Eklendi");
                txtForm.Text = string.Empty;
                txtFormAdi.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Form Kayıtlarda Mevcuttur !");
                txtForm.Text = string.Empty;
                txtFormAdi.Text = string.Empty;
            }
        }

        private void btnYetkiEkle_Click(object sender, EventArgs e)
        {
            int personelid = Convert.ToInt32(cmbPersonel.SelectedValue);

            foreach (Formlar item in lstFormlar.SelectedItems)
            {
                foreach (YetkiTipleri item1 in lstYetkiTipleri.SelectedItems)
                {
                    if (item1.YetkiTipleri1 == 1 || item1.YetkiTipleri1 == 2)
                    {
                        if (!(Yetkiler.Where(y => y.FormID == item.IDForm && y.PersonelID == personelid && (y.YetkiTipiID == 1 || y.YetkiTipiID == 2)).FirstOrDefault() != null))
                        {
                            Yetki y = new Yetki()
                            {
                                FormID = item.IDForm,
                                PersonelID = personelid,
                                YetkiTipiID = item1.YetkiTipleri1
                            };
                            Yetkiler.Add(y);
                            break;
                        }
                    }
                    else if (!(Yetkiler.Where(y => y.FormID == item.IDForm && y.PersonelID == personelid && y.YetkiTipiID == item1.YetkiTipleri1).FirstOrDefault() != null))
                    {
                        if ((Yetkiler.Where(z => z.FormID == item.IDForm && z.PersonelID == personelid && (z.YetkiTipiID == 1 || z.YetkiTipiID == 2)).FirstOrDefault() != null)) return;

                            Yetki y = new Yetki()
                        {
                            FormID = item.IDForm,
                            PersonelID = personelid,
                            YetkiTipiID = item1.YetkiTipleri1
                        };
                        Yetkiler.Add(y);
                    }
                }
            }

            YetkileriGoster();
        }

        private void YetkileriGoster()
        {
            PersonelYetkileriGetir();

            foreach (Yetki item in Yetkiler)
            {
                DataGridViewRow row = (DataGridViewRow)dgvYetkiler.Rows[0].Clone();
                row.Cells[0].Value = item.IDYetki;
                row.Cells[1].Value = formlarR.SelectByID(item.FormID).Modul.ModulAdi;
                row.Cells[2].Value = formlarR.SelectByID(item.FormID).FormAdi;
                row.Cells[3].Value = yetkiTurleriR.SelectByID(item.YetkiTipiID).YetkiAdi;

                row.Tag = item;
                dgvYetkiler.Rows.Add(row);

            }
        }

        private void cmbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonelYetkileriGetir();
        }

        private void PersonelYetkileriGetir()
        {
            dgvYetkiler.Rows.Clear();

            if (cmbPersonel.SelectedIndex != -1)
            {
                int personelid = Convert.ToInt32(cmbPersonel.SelectedValue);

                foreach (Yetki item in yetkiR.SelectAllByID(personelid))
                {
                    DataGridViewRow row = (DataGridViewRow)dgvYetkiler.Rows[0].Clone();
                    row.Cells[0].Value = item.IDYetki;
                    row.Cells[1].Value = formlarR.SelectByID(item.FormID).Modul.ModulAdi;
                    row.Cells[2].Value = formlarR.SelectByID(item.FormID).FormAdi;
                    row.Cells[3].Value = yetkiTurleriR.SelectByID(item.YetkiTipiID).YetkiAdi;

                    row.Tag = item;
                    dgvYetkiler.Rows.Add(row);
                }
            }
        }

        private void btnYetkiTemizle_Click(object sender, EventArgs e)
        {
            Yetkiler.Clear();
            dgvYetkiler.Rows.Clear();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int personelid = Convert.ToInt32(cmbPersonel.SelectedValue);
            yetkiR.DeleteAll(personelid);

            foreach (DataGridViewRow item in dgvYetkiler.Rows)
            {
                if (item.Cells[1].Value != null)
                {
                    Yetki y = item.Tag as Yetki;
                    yetkiR.Insert(y);
                }
            }
            MessageBox.Show("Kayıtlar Başarı ile Eklendi..");
            Yetkiler.Clear();
            dgvYetkiler.Rows.Clear();
        }

        private void btnYetkiSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvYetkiler.SelectedRows)
            {
                if (item.Cells[1].Value != null)
                {
                    Yetkiler.Remove(item.Tag as Yetki);
                    dgvYetkiler.Rows.Remove(item);

                }
            }
        }


    }
}
