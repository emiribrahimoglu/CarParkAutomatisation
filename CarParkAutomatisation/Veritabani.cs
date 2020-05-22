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
        private static string baglantiString = "server=127.0.0.1;uid=root;pwd=engtrq;database=vtproje";
        private static MySqlConnection baglanti;
        private static MySqlCommand komut;
        private static MySqlDataAdapter adaptor;
        private static MySqlDataReader dataReader;
        private static DataSet dataSet;
        private static string[] uyeOlDizi;
        private static int idTemp;
        private static string sifreTemp;
        
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
            string sorgu;
            parkyeri = yer;
            
            //bu fonksiyon, yer seçimi tiklandiginda acilmasi icin her butonun click olayına eklenecektir
            DateTime girisSaati = DateTime.Now;
            sorgu = "select plakaId from plakalar where plaka" + "='"+aracplaka+"'";
            komut = new MySqlCommand(sorgu,baglanti);
            plaka2 = Convert.ToInt32(komut.ExecuteScalar()); // giris yapan aracın plakaId si alindi.
            MessageBox.Show("plaka2:" + plaka2);
            
            komut.CommandText = "select uyeId from uyeler where plakaId" + "='"+plaka2+"'";
            kisiId = Convert.ToInt32(komut.ExecuteScalar()); // giris yapan arac sahibinin  uyeId si alindi.
            MessageBox.Show("kişi id:" + kisiId);

            if (kisiId!=0) // kisiye kesilecek ucret belirlendi. 
            {
                komut.CommandText = "select ucretId from ucretlendirmeler where ucretId=1";
                ucretid = Convert.ToInt32(komut.ExecuteScalar());
            }
            else
            {
                komut.CommandText = "select ucretid from ucretlendirmeler where ucretId=2";
                ucretid = Convert.ToInt32(komut.ExecuteScalar());
            }
            
            //parkyerleri tablosuna park yerini ve park durumunu dolu olarak gir.

            komut.CommandText = "insert into parkyerleri (parkyeri, parkyeridurum) values(@parkyeri, @parkyeridurum);";
            komut.Parameters.Add("@parkyeri", MySqlDbType.VarChar).Value = yer;
            komut.Parameters.Add("@parkyeridurum", MySqlDbType.UInt16).Value = parkyeridurum;
            komut.ExecuteNonQuery();
            
            // park yeri girildi. simdi o park yerine ait id alınacak.
            komut.CommandText = "select parkId from parkyerleri where parkyeri" + "='"+yer+"'";
            parkid = Convert.ToInt32(komut.ExecuteScalar()); // aracın park edildigi id alindi.
            
            // toplanan bilgileri o plakaId sayesinde giriscikis tablosuna gir.

            komut.CommandText =
                "insert into giriscikis (plakaId, parkId, girisSaati, ucretId) values(@plakaId, @parkId, @girisSaati, @ucretId);";
            komut.Parameters.Add("@plakaId", MySqlDbType.Int32).Value = plaka2;
            komut.Parameters.Add("@parkId", MySqlDbType.Int32).Value = parkid;
            komut.Parameters.Add("@girisSaati", MySqlDbType.DateTime).Value = girisSaati;
            komut.Parameters.Add("@ucretId", MySqlDbType.Int32).Value = ucretid;
            komut.ExecuteNonQuery();
        }

        public static void FaturaKes(string sorgu, string aracplaka)
        {
            komut = new MySqlCommand(sorgu,baglanti);
            DateTime girisSaati = Convert.ToDateTime(komut.ExecuteScalar());
            if (girisSaati != DateTime.MinValue)
            {
                DateTime cikisSaati = DateTime.Now; // bu deger alindi, veritabanina girilecek
                MessageBox.Show("Giriş Saati: " + girisSaati + Environment.NewLine + "Çıkış Saati: "+ cikisSaati);
                cikisSaati = cikisSaati.AddHours(2).AddMinutes(30);
                int parkSuresi = Convert.ToInt32(cikisSaati.Subtract(girisSaati).TotalMinutes);
                MessageBox.Show("Dakika tipinde park süresi: " + parkSuresi);
                
                komut.CommandText = "select plakaId from plakalar where plaka=@aracplaka";
                komut.Parameters.Add("@aracplaka", MySqlDbType.VarChar).Value = aracplaka;
                int aracplakaid = Convert.ToInt32(komut.ExecuteScalar());
                komut.CommandText = "select max(faturaId) from girisCikis where plakaId=@aracplakaid";
                komut.Parameters.Add("@aracplakaid", MySqlDbType.Int32).Value = aracplakaid;
                string maxfaturaid = Convert.ToString(komut.ExecuteScalar());
                MessageBox.Show("Max Fatura ID:: " + maxfaturaid);
                
                komut.CommandText = "update girisCikis set cikisSaati=@cikisSaati, parkSuresi=@toplamParkSuresi where faturaId=@maxfaturaid";
                MessageBox.Show("Update Komutu:: "+komut.CommandText);
                komut.Parameters.Add("@cikisSaati", MySqlDbType.DateTime).Value = cikisSaati;
                komut.Parameters.Add("@toplamParkSuresi", MySqlDbType.Double).Value = parkSuresi;
                komut.Parameters.Add("@maxfaturaid", MySqlDbType.VarChar).Value = maxfaturaid;
                komut.ExecuteNonQuery();
                 
                komut.CommandText =
                     "select ucret from ucretlendirmeler,girisCikis where girisCikis.faturaId=(select max(faturaId) from girisCikis where plakaId=@aracplakaid and girisCikis.ucretId=ucretlendirmeler.ucretId)";
                MessageBox.Show("Select Komutu:: "+komut.CommandText);
                double tarife = Convert.ToDouble(komut.ExecuteScalar());
                double ucret = Convert.ToDouble(parkSuresi) / 60 * tarife;
                if (parkSuresi%60>30)
                {
                     ucret += Convert.ToInt32(tarife / 2);
                }
                 
                FaturaGoster faturaGoster = new FaturaGoster(aracplaka,parkyeri,girisSaati,cikisSaati, parkSuresi,ucret);
                faturaGoster.Show();
            }

        }

    }
}