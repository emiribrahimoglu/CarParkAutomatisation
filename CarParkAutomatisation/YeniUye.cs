using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkAutomatisation
{
    public partial class YeniUye : Form
    {
        private string sorguCumlesi;
        private string uyeOlParametreler;
        private int plakaid;
        public YeniUye()
        {
            InitializeComponent();
        }

        private void uyeOlButton_Click(object sender, EventArgs e)
        {
            sorguCumlesi = "insert into plakalar (plaka) values (@plaka)";
            Veritabani.PlakaEkle(sorguCumlesi,uyelikPlakaTxt.Text);
            sorguCumlesi = "select plakaId from plakalar where plaka=" + "'"+uyelikPlakaTxt.Text+"'";
            plakaid = Veritabani.PlakaGetir(sorguCumlesi);
            sorguCumlesi =
                "insert into uyeler (uyeSifre, ad, soyad, telno, uyelikbaslangici, plakaId) values(@uyeSifre, @ad, @soyad, @telno, @uyelikbaslangici, @plakaId);";
            uyeOlParametreler = uyelikSifreTxt.Text + " " + uyelikAdTxt.Text + " " + uyelikSoyadTxt.Text + " "+uyelikTelTxt.Text+" " +DateTime.Now + " " + plakaid;
            Veritabani.KayitOlInsert(sorguCumlesi, uyeOlParametreler);
            
            //uye olduktan sonra yeniden plaka girdirip ondan sonra otoparkyerlesimini sayfasına oradan gecilecek
            UyeliksiGirisForm uyeliksiGirisForm = new UyeliksiGirisForm();
            uyeliksiGirisForm.Show();
        }
    }
}
