using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneHastaKayit
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btn_doktorListele_Click(object sender, EventArgs e)
        {
            DoktorListele doktorListe = new DoktorListele();
            doktorListe.Show();
            this.Hide();
        }

        private void btn_hemsireListele_Click(object sender, EventArgs e)
        {
            HemsireListele hemsireListe = new HemsireListele();
            hemsireListe.Show();
            this.Hide();
        }

        private void btn_doktorEkle_Click(object sender, EventArgs e)
        {
            DoktorEkle doktorEkle = new DoktorEkle();
            doktorEkle.Show();
            this.Hide();
        }

        private void btn_hemsireEkle_Click(object sender, EventArgs e)
        {
            HemsireEkle hemsireEkle = new HemsireEkle();
            hemsireEkle.Show();
            this.Hide();
        }
    }
}
