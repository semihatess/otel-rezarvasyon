using otelrezervasyon.DAL;
using otelrezervasyon.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static otelrezervasyon.DAL.DALrezervasyon;

namespace otelrezervasyon.BL
{
    internal class BLrezervasyon
    {
        public class MusteriIslemleri
        {
           private MusteriVeriErisim e= new MusteriVeriErisim();
            public DataTable Listele()
            { return e.MusterileriGetir(); }

        }
        internal void MusteriEkle(string musteriad, string musterisoyad, string odaNo, string giristarihi, string cikistarihi, string odatipi)
        {
            new DALrezervasyon().MusteriEkle(musteriad, musterisoyad, odaNo, giristarihi, cikistarihi, odatipi);
        }
        internal void MusteriGuncelle(string musteriad, string musterisoyad, string odaNo, string giristarihi, string cikistarihi, string odatipi, int musteriid)
        {
            new DALrezervasyon().MusteriGuncelle(musteriad,musterisoyad,odaNo,giristarihi,cikistarihi,odatipi,musteriid);
        }
        public void MusteriSil(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Geçerli bir ID girin.");
            }

            new DALrezervasyon().MusteriSil(id);
        }
    }


}