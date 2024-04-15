using HastaneHastaKayit.BLL;
using HastaneHastaKayit.DAL;
using HastaneHastaKayit.Models;

namespace HastaneHastaKayit
{
    public partial class Form1 : Form
    {
        AdminBLL adminBLL;
        int result;
        public Form1()
        {
            InitializeComponent();
            adminBLL = new AdminBLL();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            result = adminBLL.GirisKontrol(txt_email.Text, txt_sifre.Text);

            if (Hata.Hatalar.ContainsKey(result))
            {
                MessageBox.Show(Hata.Hatalar[result]);

                if (result == 100)
                {
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                    this.Hide();
                }
                else if (result == 200)
                {
                    DoktorPanel doktor = new DoktorPanel();
                    doktor.Show();
                    this.Hide();
                }
            }
        }
    }
}
