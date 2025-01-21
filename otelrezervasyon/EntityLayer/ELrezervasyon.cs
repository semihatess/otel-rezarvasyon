using otelrezervasyon.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otelrezervasyon.EntityLayer
{
    internal class ELrezervasyon
    {
        private string musteriaAd;
        private string musteriSoyad;
        private string OdaNo;
        private string giristarihi;
        private string cikistarihi;
        private string odatipi;
        private int musteriid;


        public ELrezervasyon(string musteriad, string musterisoyad, string odaNo, string giristarihi, string cikistarihi,string odatipi,int musteriid)
        
        {
            this.musteriaAd = musteriad;
            this.musteriSoyad = musterisoyad;
            this.OdaNo = odaNo;
            this.giristarihi = giristarihi;
            this.cikistarihi = cikistarihi;
            this.odatipi = odatipi;
            this.musteriid = musteriid;
         }
        public ELrezervasyon(string musteriad, string musterisoyad, string odaNo, string giristarihi, string cikistarihi, string odatipi)

        {
            this.musteriaAd = musteriad;
            this.musteriSoyad = musterisoyad;
            this.OdaNo = odaNo;
            this.giristarihi = giristarihi;
            this.cikistarihi = cikistarihi;
            this.odatipi = odatipi;
            
        }
        public string MUSTERİAD { get { return musteriaAd; } set { musteriaAd = value; } }
        public string MUSTERİSOYAD { get { return musteriSoyad; } set { musteriSoyad = value; } }
        public string ODANO { get { return OdaNo; } set { OdaNo = value; } }
        public string GIRISTARİHİ { get { return giristarihi; } set { giristarihi = value; } }
        public string CIKISTARİHİ { get { return cikistarihi; } set { cikistarihi = value; } }
        public string ODATİPİ { get { return odatipi; } set { odatipi = value; } }
        public int MUSTERİD { get { return musteriid; } set { musteriid = value; } }
        public override string ToString()
        {
            return this.musteriaAd + "-" + this.musteriSoyad + "-" + this.OdaNo + "-" + this.giristarihi + "-" + this.cikistarihi + "-" + this.odatipi + "-" + this.musteriid;
        }

        }

    }

