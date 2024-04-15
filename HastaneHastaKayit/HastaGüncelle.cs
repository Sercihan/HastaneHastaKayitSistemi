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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HastaneHastaKayit
{
    public partial class HastaGüncelle : Form
    {
        DoktorBLL doktorBLL;
        int result;
        public HastaGüncelle()
        {
            InitializeComponent();
            doktorBLL = new DoktorBLL();
            dg_hastaListe.DataSource = doktorBLL.HastaListele();
        }

        Hastum hasta;
        int updateId;

        //private void dg_hastaListe_DoubleClick(object sender, EventArgs e)
        //{
        //    //DataGridView dataGridView = (DataGridView)sender;
        //    //updateId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value); // id alamıyorum

        //}
        private void dg_hastaListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow selectedRow = dg_hastaListe.Rows[e.RowIndex];
            updateId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            hasta = doktorBLL.HastaGetir(updateId);

            txt_ad.Text = hasta.Ad;
            txt_soyad.Text = hasta.Soyad;
            txt_email.Text = hasta.Email;
            msk_telefon.Text = hasta.Telefon;
            txt_tc.Text = hasta.Tc.ToString();
            rtxt_teshis.Text = hasta.Teshis;
            nmr_tedavi.Value = hasta.TedaviSuresi;
        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            
            result = doktorBLL.HastaGuncelle(txt_ad.Text, txt_soyad.Text, txt_email.Text, msk_telefon.Text, Convert.ToInt64(txt_tc.Text), rtxt_teshis.Text, (int)nmr_tedavi.Value, hasta);
            if (result == 202)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız");
            }
            else if (result == 401)
            {
                txt_ad.Text = "";
                txt_soyad.Text = "";
                txt_email.Text = "";
                msk_telefon.Text = "";
                txt_tc.Text = "";
                rtxt_teshis.Text = "";
                nmr_tedavi.Value = nmr_tedavi.Minimum;
            }
            else
            {
                MessageBox.Show("Bilinmeyen bir hata oluştu. Lütfen sistem yöneticiniz ile görüşünüz..");
            }
        }
    }
}
