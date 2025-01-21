using MySql.Data.MySqlClient ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otelrezervasyon.DAL
{
     class baglanti
    {
        public MySqlConnection baglantiGetir()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253; Database=25_132330019; Uid=25_132330019; Pwd=!nif.ogr19AT");
                baglanti.Open();
            return baglanti;
        }
    }
}
