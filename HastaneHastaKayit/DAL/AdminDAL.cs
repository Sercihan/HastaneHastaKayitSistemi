using HastaneHastaKayit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneHastaKayit.DAL
{
    
    internal class AdminDAL
    {
        public static int doktorId;
        private readonly HastaneSistemiContext context;

        public AdminDAL()
        {
            context = new HastaneSistemiContext();
        }

        internal int GirisKontrol(string email, string sifre)
        {
            //AdminKontrolü
            if (email == "ser@gmail.com")
            {
                SistemKullanicisi yonetici = context.SistemKullanicisis.Where(i => i.Email == email && i.Sifre == sifre).FirstOrDefault();

                if (yonetici != null)
                {
                    //Admin Panel
                    return 100;
                }
                else
                {
                    return 101; //Yönetici Şifre Hatası
                }
            }
            else
            {
                Doktor doktor = context.Doktors.Where(i => i.Email == email && i.Sifre == sifre).FirstOrDefault();

                if (doktor != null)
                {
                    doktorId = doktor.Id;
                    //Doktor Panel
                    return 200;//Giriş Başarılı
                }
                else
                {
                    return 201;//Email veya Şifre hatalı
                }
            }
        }

        internal List<Doktor> DoktorListele()
        {
            return context.Doktors.ToList();
        }
        internal List<Hemsire> HemsireListele()
        {
            return context.Hemsires.ToList();
        }

        internal int HemsireEkle(Hemsire hemsire)
        {
            context.Hemsires.Add(hemsire);
            context.SaveChanges();
            return 300;
        }

        internal int DoktorEkle(Doktor doktor)
        {
            context.Doktors.Add(doktor);
            context.SaveChanges();
            return 203;
        }

    }    
}
