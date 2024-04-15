using HastaneHastaKayit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneHastaKayit.DAL
{
    internal class DoktorDAL
    {
        private readonly HastaneSistemiContext context;
        public static int hastaId;
        public DoktorDAL() 
        {
            context = new HastaneSistemiContext();

        }
        internal int HastaEkle(Hastum hasta)
        {
            context.Hasta.Add(hasta);
            context.SaveChanges();
            return 400;
        }

        internal List<Hastum> HastaListele()
        {
            return context.Hasta.ToList();
        }

        internal Hastum HastaGetir(int updateId)
        {
            return context.Hasta.Find(updateId); // int olmalı id yollamalıyım
        }

        internal int HastaGuncelle(Hastum hasta)
        {
            context.Hasta.Update(hasta);
            context.SaveChanges();
            return 401;
        }
    }
    
}
