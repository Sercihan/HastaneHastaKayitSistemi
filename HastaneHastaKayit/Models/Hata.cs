using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneHastaKayit.Models
{
    internal class Hata
    {
        public static SortedList<int, string> Hatalar = new SortedList<int, string>()
        {
            {100,"Yönetici Giriş Başarılı"},
            {101,"Yönetici Şifre Hatası"},
            {200,"Doktor Giriş Başarılı"},
            {201,"Doktor Giriş Bilgileri Hatalı"},
            {202,"Alanlar Boş Geçilemez"},
            {203,"Doktor Ekleme Başarılı"},
            {204,"Aynı Email Kayıtlı"},
            {205,"Aynı TC Kayıtlı"},
            {300,"Hemşire Ekleme Başarılı"},
            {400,"Hasta Ekleme Başarılı"},
            {401,"Hasta Güncelleme Başarılı"}
        };
    }
}
