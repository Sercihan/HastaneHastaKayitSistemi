using HastaneHastaKayit.BLL;
using HastaneHastaKayit.DAL;
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
    public partial class HastaEkle : Form
    {
        DoktorBLL doktorBLL;
        int result;
        public HastaEkle()
        {
            InitializeComponent();
            doktorBLL = new DoktorBLL();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            result = doktorBLL.HastaEkle(txt_ad.Text, txt_soyad.Text, txt_email.Text, msk_telefon.Text,Convert.ToInt64(txt_tc.Text), rtxt_teshis.Text, (int)nmr_tedavi.Value);

            if (Hata.Hatalar.ContainsKey(result))
            {
                MessageBox.Show(Hata.Hatalar[result]);

                if (result == 400)
                {
                    txt_ad.Text = "";
                    txt_soyad.Text = "";
                    txt_email.Text = "";
                    msk_telefon.Text = "";
                    txt_tc.Text = "";
                    rtxt_teshis.Text = "";
                    nmr_tedavi.Value = nmr_tedavi.Minimum;
                }
            }
        }
    }
}
