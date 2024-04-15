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
    public partial class DoktorPanel : Form
    {
        public DoktorPanel()
        {
            InitializeComponent();
        }

        private void btn_hastaEkle_Click(object sender, EventArgs e)
        {
            HastaEkle hastaEkle = new HastaEkle();
            hastaEkle.Show();
            this.Hide();
        }

        private void btn_hastaGuncelle_Click(object sender, EventArgs e)
        {
            HastaGüncelle hastaGüncelle = new HastaGüncelle();
            hastaGüncelle.Show();
            this.Hide();
        }
    }
}
