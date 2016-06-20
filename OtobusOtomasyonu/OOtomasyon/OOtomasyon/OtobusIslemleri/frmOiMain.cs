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

namespace OOtomasyon.OtobusIslemleri
{
    public partial class frmOiMain : Form
    {
        public frmOiMain()
        {
            InitializeComponent();
        }

        public Otobus SecilenOtobus { get; set; }

        SubeRepository subeR = new SubeRepository();
        OtobusDurumlariRepository odR = new OtobusDurumlariRepository();
        OtobusOzellikleriRepository ooR = new OtobusOzellikleriRepository();
        OtobusOzellikDetayRepository oodR = new OtobusOzellikDetayRepository();
        OtobusRepository oR = new OtobusRepository();
        OtobusTipleriRepository otR = new OtobusTipleriRepository();

        private void Form1_Load(object sender, EventArgs e)
        {
            SubeleriGetir();
            OzellikleriGetir();
            DurumlariGetir();
            TipleriGetir();
            OtobusleriGetir();
        }

        private void TipleriGetir()
        {
            cmbOtobusTipi.ValueMember = "IDOtobusTipi";
            cmbOtobusTipi.DataSource = otR.SelectAll();
            cmbOtobusTipi.DisplayMember = "OtobusTipi";
        }

        private void OtobusleriGetir()
        {
            dgvOtobusler.DataSource = oR.SelectAll().Select(x => new
            {
                OtobusID = x.IDOtobus,
                Plaka = x.PlakaNo,
                Durum = x.OtobusDurumlari.OtobusDurumu
            }).ToList();
        }

        private void DurumlariGetir()
        {
            cmbOtobusDurumu.ValueMember = "IDOtobusDurumu";
            cmbOtobusDurumu.DataSource = odR.SelectAll();
            cmbOtobusDurumu.DisplayMember = "OtobusDurumu";
        }

        private void OzellikleriGetir()
        {
            foreach (OtobusOzellikleri item in ooR.SelectAll())
            {
                CheckBox chk = new CheckBox()
                {
                    Text = item.OtobusOzellik,
                    Tag = item.IDOtobusOzellik,
                    Name = "chk" + item.IDOtobusOzellik,
                    
                };

                grbOtobusOzellikleri.Controls.Add(chk);
            }
        }

        private void SubeleriGetir()
        {
            cmbSube.ValueMember = "IDSube";
            cmbSube.DataSource = subeR.SelectAll();
            cmbSube.DisplayMember = "Adi";
        }

        private void dgvOtobusler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SecilenOtobus = oR.SelectByID(Convert.ToInt32(dgvOtobusler.SelectedRows[0].Cells[0].Value));
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtPlaka.Text.Trim().Length == 0 || txtPlaka.Text.Trim().Length > 16 || txtPlaka.Text.Trim().Length < 4)
            {
                MessageBox.Show("Otobüs plakası uygun formatta değil !");
                return;
            }
            else if (cmbSube.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Şube seçiniz !");
                return;

            }
            else if (numKoltukSayisi.Value < 16 || numKoltukSayisi.Value > 100)
            {
                MessageBox.Show("Koltuk sayısı 16 ile 100 arasında olmalıdır !");
                return;
            }
            else if (cmbOtobusDurumu.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Otobüs durumu seçiniz !");
                return;

            }
            else if (cmbOtobusTipi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Otobüs tipi seçiniz !");
                return;

            }
            else
            {
                OtobusEkle();
            }
        }

        private void OtobusEkle()
        {
            if (oR.SelectAll().FirstOrDefault(x => x.PlakaNo == txtPlaka.Text.Trim()) == null)
            {
                Otobus oto = new Otobus
                {
                    SubeID = Convert.ToInt32(cmbSube.SelectedValue),
                    OtobusDurumuID = Convert.ToInt32(cmbOtobusDurumu.SelectedValue),
                    OtobusTipiID = Convert.ToInt32(cmbOtobusTipi.SelectedValue),
                    KoltukSayisi = Convert.ToInt32(numKoltukSayisi.Value),
                    PlakaNo = txtPlaka.Text.Trim(),
                };

                oR.Insert(oto);

                foreach (CheckBox item in grbOtobusOzellikleri.Controls)
                {
                    if (item.Checked)
                    {
                        OtobusOzellikDetay ood = new OtobusOzellikDetay();
                        ood.OtobusID = oto.IDOtobus;
                        ood.OtobusOzellikID = Convert.ToInt32(item.Tag);
                        oodR.Insert(ood);
                    }

                }
                OtobusleriGetir();
                MessageBox.Show("Otobus kaydı başarı ile eklendi !");
                FormTool.FormTemizle(this.Controls);
            }
            else
            {
                MessageBox.Show("Bu Plaka'da bir otobüs mevcuttur. Lütfen Otobüs bilgilerini güncelleyin!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (SecilenOtobus == null)
            {
                MessageBox.Show("Otobüs Seçiniz!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Seçilen Otobüs Pasif konuma getirilecek?", "Emin misin ?",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SecilenOtobus.OtobusDurumuID = 2;
                    oR.Update(SecilenOtobus);
                    OtobusleriGetir();
                    FormTool.FormTemizle(this.Controls);
                }
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            FormTool.FormTemizle(grbOtobusOzellikleri.Controls);

            if (SecilenOtobus == null)
            {
                MessageBox.Show("Lütfen Otobus Seçiniz!");
            }
            else
            {
                cmbSube.SelectedValue = SecilenOtobus.SubeID;
                cmbOtobusTipi.SelectedValue = SecilenOtobus.OtobusTipiID;
                cmbOtobusDurumu.SelectedValue = SecilenOtobus.OtobusDurumuID;
                txtPlaka.Text = SecilenOtobus.PlakaNo;
                numKoltukSayisi.Value = SecilenOtobus.KoltukSayisi;


                foreach (OtobusOzellikDetay item in SecilenOtobus.OtobusOzellikDetay)
                {
                    foreach (CheckBox itemchk in grbOtobusOzellikleri.Controls)
                    {
                        if (Convert.ToInt32(itemchk.Tag) == item.OtobusOzellikID)
                        {
                            itemchk.Checked = true;
                        }
                    }
                }


            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormTool.FormTemizle(this.Controls);
            OtobusleriGetir();
            SecilenOtobus = null;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtPlaka.Text.Trim().Length == 0 || txtPlaka.Text.Trim().Length > 16 || txtPlaka.Text.Trim().Length < 4)
            {
                MessageBox.Show("Otobüs plakası uygun formatta değil !");
                return;
            }
            else if (cmbSube.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Şube seçiniz !");
                return;

            }
            else if (numKoltukSayisi.Value < 16 || numKoltukSayisi.Value > 100)
            {
                MessageBox.Show("Koltuk sayısı 16 ile 100 arasında olmalıdır !");
                return;
            }
            else if (cmbOtobusDurumu.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Otobüs durumu seçiniz !");
                return;

            }
            else if (cmbOtobusTipi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Otobüs tipi seçiniz !");
                return;

            }
            else
            {

                SecilenOtobus.SubeID = Convert.ToInt32(cmbSube.SelectedValue);
                SecilenOtobus.OtobusDurumuID = Convert.ToInt32(cmbOtobusDurumu.SelectedValue);
                SecilenOtobus.OtobusTipiID = Convert.ToInt32(cmbOtobusTipi.SelectedValue);
                SecilenOtobus.KoltukSayisi = Convert.ToInt32(numKoltukSayisi.Value);
                SecilenOtobus.PlakaNo = txtPlaka.Text.Trim();

                oodR.DeleteAll(SecilenOtobus.IDOtobus);

                foreach (CheckBox item in grbOtobusOzellikleri.Controls)
                {
                    if (item.Checked)
                    {
                        OtobusOzellikDetay ood = new OtobusOzellikDetay();
                        ood.OtobusID = SecilenOtobus.IDOtobus;
                        ood.OtobusOzellikID = Convert.ToInt32(item.Tag);
                        oodR.Insert(ood);
                    }

                }

                oR.Update(SecilenOtobus);
                OtobusleriGetir();
                MessageBox.Show("Otobus kaydı başarı ile güncellendi !");
                FormTool.FormTemizle(this.Controls);
            }
        }
    }
}
