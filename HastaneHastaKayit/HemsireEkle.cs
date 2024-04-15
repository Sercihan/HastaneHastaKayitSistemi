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
    public partial class HemsireEkle : Form
    {
        AdminBLL adminBLL;
        int result;
        public HemsireEkle()
        {
            InitializeComponent();
            adminBLL = new AdminBLL();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            result = adminBLL.HemsireEkle(txt_ad.Text, txt_soyad.Text, Convert.ToInt64(txt_tc.Text));

            if (Hata.Hatalar.ContainsKey(result))
            {
                MessageBox.Show(Hata.Hatalar[result]);

                if (result == 300)
                {
                    txt_ad.Text = "";
                    txt_soyad.Text = "";
                    txt_tc.Text = "";
                }
            }

        }
    }
}
