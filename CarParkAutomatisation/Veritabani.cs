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

        public static DataSet Sorgu(string komutString)
        {
            komut = new MySqlCommand(komutString, baglanti);
            adaptor = new MySqlDataAdapter(komut);
            dataSet = new DataSet();
            adaptor.Fill(dataSet, "sorguSonuc");
            return dataSet;
        }
    }
}