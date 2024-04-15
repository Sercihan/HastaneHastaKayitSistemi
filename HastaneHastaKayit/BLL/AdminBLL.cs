using HastaneHastaKayit.DAL;
using HastaneHastaKayit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneHastaKayit.BLL
{
    internal class AdminBLL
    {
        AdminDAL adminDAL;
        public AdminBLL()
        {
            adminDAL = new AdminDAL();
        }

        internal int GirisKontrol(string email, string sifre) 
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sifre))
            {
                return 202;
            }
            return adminDAL.GirisKontrol(email, sifre);
        }

        internal List<Doktor> DoktorListele()
        {
            return adminDAL.DoktorListele();
        }
        internal List<Hemsire> HemsireListele()
        {
            return adminDAL.HemsireListele();
        }

        internal int HemsireEkle(string ad, string soyad, long tc)
        {
            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad))
            {
                return 202;
            }

            Hemsire hemsire = new Hemsire() 
            {
                Ad = ad,
                Soyad = soyad,
                Tc = tc
            };
            return adminDAL.HemsireEkle(hemsire);
        }

        internal int DoktorEkle(string ad, string soyad, string doktorKimlik ,long tc, string email, string sifre)
        {
            if (string.IsNullOrEmpty(ad) ||
                string.IsNullOrEmpty(soyad) ||
                string.IsNullOrEmpty(doktorKimlik) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(sifre))
            {
                return 202;
            }

            Doktor doktor = new Doktor()
            {
                Ad = ad,
                Soyad = soyad,
                DoktorKimligi = doktorKimlik,
                Tc = tc,
                Email = email,
                Sifre = sifre
            };
            return adminDAL.DoktorEkle(doktor);
        }
    }
}
