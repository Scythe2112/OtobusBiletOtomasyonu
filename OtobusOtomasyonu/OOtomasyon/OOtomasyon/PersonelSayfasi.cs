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

namespace OOtomasyon
{
    public partial class PersonelSayfasi : Form
    {
        public PersonelSayfasi()
        {
            InitializeComponent();
        }

        public static Personel GirisYapanPersonel { get; set; }

        private void PersonelSayfasi_Load(object sender, EventArgs e)
        {

        }
    }
}
