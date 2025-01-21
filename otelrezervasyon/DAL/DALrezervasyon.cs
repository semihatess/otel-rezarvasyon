using MySql.Data.MySqlClient;
using otelrezervasyon.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otelrezervasyon.DAL
{
    public class DALrezervasyon
    {       
            public class MusteriVeriErisim
            {
                public DataTable MusterileriGetir()
                {
                    DataTable musteriTablosu = new DataTable();
                    string sual = "SELECT * FROM Rezervasyonlar";
                    using (MySqlCommand komut = new MySqlCommand(sual, new baglanti().baglantiGetir()))
                    {
                        MySqlDataAdapter adaptor = new MySqlDataAdapter(komut);
                        adaptor.Fill(musteriTablosu);
                    }
                    return musteriTablosu;
                }
            }
            public void MusteriEkle(string musteriad, string musterisoyad, string odaNo, string giristarihi, string cikistarihi, string odatipi)

            {
                string kaydet = "INSERT INTO Rezervasyonlar (MusteriAd,MusteriSoyad,OdaNo,GirisTarihi,CikisTarihi,OdaTipi) VALUES (@MusteriAd, @MusteriSoyad,@OdaNo, @GirisTarihi,@CikisTarihi,@OdaTipi)";
                using (MySqlCommand komut = new MySqlCommand(kaydet, new baglanti().baglantiGetir()))
                {
                    komut.Parameters.AddWithValue("@MusteriAd", musteriad);
                    komut.Parameters.AddWithValue("@MusteriSoyad", musterisoyad);
                    komut.Parameters.AddWithValue("@OdaNo", odaNo);
                    komut.Parameters.AddWithValue("@GirisTarihi", giristarihi);
                    komut.Parameters.AddWithValue("@CikisTarihi", cikistarihi);
                    komut.Parameters.AddWithValue("@OdaTipi", odatipi);
                    komut.ExecuteNonQuery();
                }
            }
            public void MusteriGuncelle(string musteriad, string musterisoyad, string odaNo, string giristarihi, string cikistarihi,string odatipi,int musteriid)
            {
                string guncelle = "UPDATE Rezervasyonlar SET MusteriAd = @MusteriAd, MusteriSoyad = @MusteriSoyad,   OdaNo = @OdaNo, GirisTarihi = @GirisTarihi,CikisTarihi=@CikisTarihi, OdaTipi = @OdaTipi WHERE MusteriID = @MusteriID";
                using (MySqlCommand komut = new MySqlCommand(guncelle, new baglanti().baglantiGetir()))
                {
                    komut.Parameters.AddWithValue("@MusteriID", musteriid);
                    komut.Parameters.AddWithValue("@MusteriAD", musteriad);
                    komut.Parameters.AddWithValue("@MusteriSoyad", musterisoyad);
                    komut.Parameters.AddWithValue("@OdaNo", odaNo);
                    komut.Parameters.AddWithValue("@GirisTarihi", giristarihi);
                    komut.Parameters.AddWithValue("@CikisTarihi", cikistarihi);
                    komut.Parameters.AddWithValue("@OdaTipi", odatipi);
                    komut.ExecuteNonQuery();
                }
            }
            public void MusteriSil(int musteriid)
            {
                string sual = "DELETE FROM Rezervasyonlar WHERE MusteriID = @MusteriID";

                using (MySqlCommand komut = new MySqlCommand(sual, new baglanti().baglantiGetir()))
                {
                    komut.Parameters.AddWithValue("@MusteriID", musteriid);
                    komut.ExecuteNonQuery ();
                }
            }
        }
    
}
