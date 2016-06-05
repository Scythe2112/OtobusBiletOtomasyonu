using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOtomasyon.BLL;
using OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;

namespace OOtomasyon.PromosyonIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PromosyonlarRepository pR = new PromosyonlarRepository();
        PromosyonTipleriRepository ptR = new PromosyonTipleriRepository();

        public Promosyonlar SecilenPromosyon { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPromosyonTipi.ValueMember = "IDPromosyonTipi";
            cmbPromosyonTipi.DataSource = ptR.SelectAll();
            cmbPromosyonTipi.DisplayMember = "Promosyon";

            dtpBitisTarihi.Value = DateTime.Now.AddDays(30);

            PromosyonlariGetir();
        }

        private void PromosyonlariGetir()
        {
            dgvPromosyon.DataSource = pR.SelectAll().Where(x=>x.PromosyonTipiID!=11).Select(x => new
            {
                PromosyonID = x.IDPromosyon,
                PromosyonTipi = x.PromosyonTipleri.Promosyon
            }).ToList();

        }

        private void dgvPromosyon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SecilenPromosyon = pR.SelectByID(Convert.ToInt32(dgvPromosyon.SelectedRows[0].Cells[0].Value));
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (SecilenPromosyon == null)
            {
                MessageBox.Show("Promosyon Seçiniz!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Seçilen Promosyon silinecek emin misiniz?", "Silinecek ?",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int Id = SecilenPromosyon.IDPromosyon;
                    pR.Delete(Id);
                    PromosyonlariGetir();
                    FormTool.FormTemizle(this.Controls);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SecilenPromosyon.PromosyonTipiID= Convert.ToInt32(cmbPromosyonTipi.SelectedValue);
            SecilenPromosyon.BaslangicTarihi = dtpBaslangicTarihi.Value;
            SecilenPromosyon.PromosyonMiktari = Convert.ToInt32(nmPromosyonMiktari.Value);
            SecilenPromosyon.BitisTarihi = dtpBitisTarihi.Value;

            pR.Update(SecilenPromosyon);
            PromosyonlariGetir();
            MessageBox.Show("Kayıt başarı ile güncellendi !");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (cmbPromosyonTipi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Promosyon Tipi seçiniz !");
            }
            else if (!(dtpBitisTarihi.Value>dtpBaslangicTarihi.Value) || !(dtpBaslangicTarihi.Value<DateTime.Now))
            {
                MessageBox.Show("Lütfen Promosyon tarihlerini uygun giriniz !");

            }
            else if (nmPromosyonMiktari.Value<1)
            {
                MessageBox.Show("Lütfen Promosyon miktarını seçiniz !");

            }
            else
            {
                PromosyonEkle();
            }

        }

        private void PromosyonEkle()
        {

            if ((pR.SelectAllActive() as List<Promosyonlar>).FirstOrDefault(x => x.PromosyonTipiID == (int)cmbPromosyonTipi.SelectedValue) == null)
            {
                Promosyonlar pr = new Promosyonlar
                {
                    PromosyonTipiID = (int)cmbPromosyonTipi.SelectedValue,
                    BaslangicTarihi = dtpBaslangicTarihi.Value,
                    BitisTarihi = dtpBitisTarihi.Value,
                    PromosyonMiktari = (int)nmPromosyonMiktari.Value
                };

                pR.Insert(pr);
                PromosyonlariGetir();
                MessageBox.Show("Kayıt başarıyla eklendi !");

            }
            else
            {
                MessageBox.Show("Bu türde aktif bir Promosyon vardır. Lütfen O promosyonu güncelleyin!");
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            if (SecilenPromosyon == null)
            {
                MessageBox.Show("Lütfen Promosyon Seçiniz!");
            }
            else
            {
                cmbPromosyonTipi.SelectedValue = SecilenPromosyon.PromosyonTipiID;
                dtpBaslangicTarihi.Value = SecilenPromosyon.BaslangicTarihi;
                dtpBitisTarihi.Value = SecilenPromosyon.BitisTarihi;
                nmPromosyonMiktari.Value = SecilenPromosyon.PromosyonMiktari;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormTool.FormTemizle(this.Controls);
            PromosyonlariGetir();
            SecilenPromosyon = null;
        }
    }
}
