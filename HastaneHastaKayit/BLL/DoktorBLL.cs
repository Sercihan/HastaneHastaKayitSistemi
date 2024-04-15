using HastaneHastaKayit.DAL;
using HastaneHastaKayit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HastaneHastaKayit.BLL
{
    internal class DoktorBLL
    {
        DoktorDAL doktorDAL;
        public DoktorBLL() 
        { 
            doktorDAL = new DoktorDAL();
        }
        internal int HastaEkle(string ad, string soyad, string email, string telefon, long tc, string teshis, int tedavi)
        {
            if (string.IsNullOrEmpty(ad) ||
                string.IsNullOrEmpty(soyad) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(teshis))
            {
                return 202;
            }

            Hastum hasta = new Hastum()
            {
                Ad = ad,
                Soyad = soyad,
                Email = email,
                Telefon = telefon,
                Tc = tc,
                Teshis = teshis,
                TedaviSuresi = tedavi
            };
            return doktorDAL.HastaEkle(hasta);
        }

        internal List<Hastum> HastaListele()
        {
            return doktorDAL.HastaListele();
        }

        internal Hastum HastaGetir(int updateId)
        {
            return doktorDAL.HastaGetir(updateId);
        }

        internal int HastaGuncelle(string ad, string soyad, string email, string telefon, long tc, string teshis, int tedavi, Hastum hasta)
        {
            //Hastum hasta = new Hastum();
            
            hasta.Ad = ad;
            hasta.Soyad = soyad;
            hasta.Email = email;
            hasta.Telefon = telefon;
            hasta.Tc = tc;
            hasta.Teshis = teshis;
            hasta.TedaviSuresi=tedavi;

            return doktorDAL.HastaGuncelle(hasta);
        }
    }
}
