using System;
using System.Windows.Forms;
using MetroFramework;

namespace CarParkAutomatisation
{
    public partial class UyeGirisForm : Form
    {
        private string sorgu;
        public UyeGirisForm()
        {
            InitializeComponent();
        }

        private void uyelikAcButton_Click(object sender, System.EventArgs e)
        {
            YeniUye yeniUye = new YeniUye();
            yeniUye.Show();
        }

        private void uyeGirisButton_Click(object sender, EventArgs e)
        {
            bool girisDurum;
            // textboxlara girilen veriler veritabani ile karşılaştırılacak
            //sorguCumlesi = "select plakaId from plakalar where plaka=" + "'"+uyelikPlakaTxt.Text+"'";
            sorgu = "select uyeId from uyeler where uyeSifre"+"='"+uyeSifreTxt.Text+"'";
            girisDurum = Veritabani.UyeKontrol(sorgu, new string[] {uyeIdTxt.Text, uyeSifreTxt.Text});
            if (girisDurum)
            {
                MetroMessageBox.Show(this, "HOŞGELDİNİZ!", "GİRİŞ BAŞARILI", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MetroMessageBox.Show(this, "ID VEYA ŞİFRE HATALI GİRİLDİ", "GİRİŞ BAŞARISIZ", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}