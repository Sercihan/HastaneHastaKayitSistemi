using HastaneHastaKayit.BLL;
using HastaneHastaKayit.Models;
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
    public partial class DoktorEkle : Form
    {
        AdminBLL adminBLL;
        int result;
        public DoktorEkle()
        {
            InitializeComponent();
            adminBLL = new AdminBLL();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            result = adminBLL.DoktorEkle(txt_ad.Text, txt_soyad.Text, txt_doktorKimlik.Text,Convert.ToInt64(txt_tc.Text), txt_email.Text, txt_sifre.Text);

            if (Hata.Hatalar.ContainsKey(result))
            {
                MessageBox.Show(Hata.Hatalar[result]);

                if (result == 203)
                {
                    txt_ad.Text = "";
                    txt_soyad.Text = "";
                    txt_doktorKimlik.Text = "";
                    txt_tc.Text = "";
                    txt_email.Text = "";
                    txt_sifre.Text = "";
                }
            }
        }
    }
}
