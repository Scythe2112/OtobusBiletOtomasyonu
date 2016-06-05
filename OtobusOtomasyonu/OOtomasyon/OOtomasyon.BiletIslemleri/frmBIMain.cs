using OOtomasyon.BiletIslemleri.Forms;
using OOtomasyon.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOtomasyon.BiletIslemleri
{
    public partial class frmBiMain : Form
    {

        public frmBiMain()
        {
            InitializeComponent();
        }

        private void frmBiMain_Load(object sender, EventArgs e)
        {

        }

        private void biletSatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBiBiletSat frmBiletSat = new frmBiBiletSat();
            FormTool.FormKontroluYap(frmBiletSat, this);
        }
    }
}
