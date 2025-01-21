using otelrezervasyon.DAL;
using otelrezervasyon.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otelrezervasyon.BL
{
    internal class BLgiris
    {
        internal void girisbilgi(string girisKullanici,string girisSifre)
        {
            (new DALyoneticigiris()).yoneticiGiris(new ELgiris(girisKullanici, girisSifre)); 
        }
    }
}
