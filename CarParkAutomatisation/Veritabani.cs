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
        private static int peridTemp;
        private static string persifreTemp;

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
                peridTemp = Convert.ToInt32(komut.ExecuteScalar());
                if (peridTemp != Convert.ToInt32(personelGirisBilgi[0])) return false;
                komutString = "select perSifre from personel where perSifre" + "='" + personelGirisBilgi[1] + "'";
                komut.CommandText = komutString;
                persifreTemp = komut.ExecuteScalar().ToString();
                return persifreTemp==personelGirisBilgi[1];
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
                komut.Parameters.Add("@plaka", MySqlDbType.VarChar).Value = plaka;
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
                komut.Parameters.Add("@telno", MySqlDbType.Int32).Value = Convert.ToInt32(uyeOlDizi[3]);
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

    }
}