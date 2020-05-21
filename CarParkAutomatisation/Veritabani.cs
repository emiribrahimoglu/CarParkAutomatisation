using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MySql.Data.MySqlClient;

namespace CarParkAutomatisation
{
    public static class Veritabani
    {
        private static string baglantiString = "server=127.0.0.1;uid=root;pwd=.zahid746.;database=vtproje";
        private static MySqlConnection baglanti;
        private static MySqlCommand komut;
        private static MySqlDataAdapter adaptor;
        private static MySqlDataReader dataReader;
        private static DataSet dataSet;
        private static string[] uyeOlDizi;
        private static int idTemp;
        private static string sifreTemp;
        // fatura fonk icin gerekli degiskenler:
        private static DateTime? girisSaati;
        private static DateTime? cikisSaati;
        private static string sorgu1;
        private static string sorgu2;
        private static string sorgu3;
        private static string sorgu4;
        private static string sorgu5;
        private static string sorgu6;
        private static string sorgu7;
        
        // faturagoster icin gerekli degiskenler
        private static string parkyeri;
        
        public static void Baglan()
        {
            try
            {
                baglanti = new MySqlConnection(baglantiString);
                baglanti.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            MessageBox.Show("Veritabanı Bağlantı Durumu: " + baglanti.State);

        }

        public static bool PersonelKontrol(string komutString, string[] personelGirisBilgi)
        {
            try
            {
                komut = new MySqlCommand(komutString, baglanti);
                idTemp = Convert.ToInt32(komut.ExecuteScalar());
                if (idTemp != Convert.ToInt32(personelGirisBilgi[0])) return false;
                komutString = "select perSifre from personel where perSifre" + "='" + personelGirisBilgi[1] + "'";
                komut.CommandText = komutString;
                sifreTemp = komut.ExecuteScalar().ToString();
                return sifreTemp==personelGirisBilgi[1];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }
        
        public static bool UyeKontrol(string komutString, string[] uyeGirisBilgi)
        {
            try
            {
                komut = new MySqlCommand(komutString, baglanti);
                idTemp = Convert.ToInt32(komut.ExecuteScalar());
                if (idTemp != Convert.ToInt32(uyeGirisBilgi[0])) return false;
                komutString = "select uyeSifre from uyeler where uyeSifre" + "='" + uyeGirisBilgi[1] + "'";
                komut.CommandText = komutString;
                sifreTemp = komut.ExecuteScalar().ToString();
                return sifreTemp==uyeGirisBilgi[1];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }

        public static int PlakaGetir(string komutString)
        {
            int plakaid = 0;
            
            try
            {
                komut = new MySqlCommand(komutString, baglanti);
                plakaid = Convert.ToInt32(komut.ExecuteScalar());
                return plakaid;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return plakaid;
            }
        }

        public static void PlakaEkle(string komutString, string plaka)
        {
            try
            {
                komut = new MySqlCommand(komutString, baglanti);
                komut.Parameters.Add("@plaka", MySqlDbType.VarChar).Value = plaka.ToUpper();
                komut.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static DataSet Sorgu(string komutString)
        {
            try
            {
                komut = new MySqlCommand(komutString, baglanti);
                adaptor = new MySqlDataAdapter(komut);
                dataSet = new DataSet();
                adaptor.Fill(dataSet, "sorguSonuc");
                return dataSet;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new DataSet();
            }
            
        }

        public static void KayitOlInsert(string komutString, string parametreler)
        {
            try
            {
                komut = new MySqlCommand(komutString, baglanti);
                uyeOlDizi = parametreler.Split(' ');
                komut.Parameters.Add("@uyeSifre", MySqlDbType.VarChar).Value = uyeOlDizi[0];
                komut.Parameters.Add("@ad", MySqlDbType.VarChar).Value = uyeOlDizi[1];
                komut.Parameters.Add("@soyad", MySqlDbType.VarChar).Value = uyeOlDizi[2];
                komut.Parameters.Add("@telno", MySqlDbType.Int64).Value = Convert.ToInt64(uyeOlDizi[3]);
                komut.Parameters.Add("@uyelikbaslangici", MySqlDbType.DateTime).Value =
                    Convert.ToDateTime(uyeOlDizi[4]+" "+uyeOlDizi[5]);
                komut.Parameters.Add("@plakaId", MySqlDbType.Int32).Value = Convert.ToInt32(uyeOlDizi[6]);
                komut.ExecuteNonQuery();
                /*adaptor = new MySqlDataAdapter(komut);
                dataSet = new DataSet();
                adaptor.Fill(dataSet, "sorguSonuc");*/
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + Environment.NewLine + e.Data);
            }
        }

        public static void Faturalandir(string aracplaka,string yer)
        {
            //plakaId, parkId, girisSaati, ucret
            
            int plaka2 = 0;
            int kisiId = 0;
            double ucretid = 0;
            bool parkyeridurum = true;
            int parkid = 0;
            
            //bu fonksiyon, yer seçimi tiklandiginda acilmasi icin her butonun click olayına eklenecektir
            girisSaati = DateTime.Now;
            sorgu1 = "select plakaId from plakalar where plaka" + "='"+aracplaka+"'";
            komut = new MySqlCommand(sorgu1,baglanti);
            plaka2 = Convert.ToInt32(komut.ExecuteScalar()); // giris yapan aracın plakaId si alindi.
            MessageBox.Show("plaka2:" + plaka2);
            
            sorgu3 = "select uyeId from uyeler where plakaId" + "='"+plaka2+"'"; 
            komut = new MySqlCommand(sorgu3,baglanti);
            kisiId = Convert.ToInt32(komut.ExecuteScalar()); // giris yapan arac sahibinin  uyeId si alindi.
            MessageBox.Show("kişi id:" + kisiId);

            if (kisiId!=0) // kisiye kesilecek ucret belirlendi. 
            {
                sorgu2 = "select ucretId from ucretlendirmeler where ucretId=1";
                komut = new MySqlCommand(sorgu2,baglanti);
                ucretid = Convert.ToInt32(komut.ExecuteScalar());
            }
            else
            {
                sorgu4 = "select ucretid from ucretlendirmeler where ucretId=2";
                komut = new MySqlCommand(sorgu4,baglanti);
                ucretid = Convert.ToInt32(komut.ExecuteScalar());
            }
            
            //parkyerleri tablosuna park yerini ve park durumunu dolu olarak gir.

            sorgu5 = "insert into parkyerleri (parkyeri, parkyeridurum) values(@parkyeri, @parkyeridurum);";
            komut = new MySqlCommand(sorgu5,baglanti);
            komut.Parameters.Add("@parkyeri", MySqlDbType.VarChar).Value = yer;
            komut.Parameters.Add("@parkyeridurum", MySqlDbType.UInt16).Value = parkyeridurum;
            komut.ExecuteNonQuery();
            
            // park yeri girildi. simdi o park yerine ait id alınacak.
            sorgu6 = "select parkId from parkyerleri where parkyeri" + "='"+yer+"'";
            komut = new MySqlCommand(sorgu6,baglanti);
            parkid = Convert.ToInt32(komut.ExecuteScalar()); // aracın park edildigi id alindi.
            
            // toplanan bilgileri o plakaId sayesinde giriscikis tablosuna gir.

            sorgu7 =
                "insert into giriscikis (plakaId, parkId, girisSaati, ucretId) values(@plakaId, @parkId, @girisSaati, @ucretId);";
            komut = new MySqlCommand(sorgu7,baglanti);
            komut.Parameters.Add("@plakaId", MySqlDbType.Int32).Value = plaka2;
            komut.Parameters.Add("@parkId", MySqlDbType.Int32).Value = parkid;
            komut.Parameters.Add("@girisSaati", MySqlDbType.DateTime).Value = girisSaati;
            komut.Parameters.Add("@ucretId", MySqlDbType.Int32).Value = ucretid;
            komut.ExecuteNonQuery();
        }

        public static void FaturaKes(string sorgu, string aracplaka)
        {
            komut = new MySqlCommand(sorgu,baglanti);
            girisSaati = Convert.ToDateTime(komut.ExecuteScalar());
            if (girisSaati.HasValue)
            {
                cikisSaati = DateTime.Now; // bu deger alindi, veritabanina girilecek
                TimeSpan? parkSuresi = cikisSaati - girisSaati;
                MessageBox.Show("?parksuresi: "+ parkSuresi);
                TimeSpan timeSpan = parkSuresi.Value;
                MessageBox.Show("timespan degeri: "+ timeSpan);
                
                // DateTime tmp = Convert.ToDateTime(timeSpan); 
                // string saat = Convert.ToString(timeSpan.Hours);
                // string dakika = Convert.ToString(timeSpan.Minutes);
                
                double toplamParkSuresi = timeSpan.Minutes; // park suresi de alindi veritabanına girilebilir.

                //komut.CommandText = "insert into girisCikis (cikisSaati, parkSuresi) values(@cikisSaati, @parkSuresi);";
                //komut.Parameters.Add("@cikisSaati", MySqlDbType.DateTime).Value = cikisSaati;
                //komut.Parameters.Add("@parkSuresi", MySqlDbType.Double).Value = toplamParkSuresi;
                //komut.ExecuteNonQuery(); // girisCikis tablosu tamamen doldu. 
                
                 komut.CommandText = "update girisCikis "+"set cikisSaati='"+cikisSaati+"' and parkSuresi=" +
                                     toplamParkSuresi+" where faturaId=(select max(faturaId) from girisCikis where plakaId='"+aracplaka+"';";
                 MessageBox.Show(komut.CommandText);
                 komut.ExecuteNonQuery();
                 
                 komut.CommandText =
                     "select ucret from ucretlendirmeler,girisCikis where girisCikis.faturaId"+"="+"(select "+"max(faturaId) "+"from girisCikis "+
                     "where plakaId=" + "'" + aracplaka + "') and girisCikis.ucretId=ucretlendirmeler.ucretId;";
                 MessageBox.Show(komut.CommandText);
                 double tarife = Convert.ToDouble(komut.ExecuteScalar());
                 double ucret = (toplamParkSuresi / 60) * tarife;
                 if (toplamParkSuresi%60>30)
                 {
                     ucret += tarife / 2;
                 }
                 
                 FaturaGoster faturaGoster = new FaturaGoster(aracplaka,parkyeri,girisSaati.Value,cikisSaati.Value,toplamParkSuresi,ucret);
                 faturaGoster.Show();
            }

        }

    }
}