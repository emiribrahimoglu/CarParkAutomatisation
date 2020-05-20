using System;
using System.Windows.Forms;
using MetroFramework;

namespace CarParkAutomatisation
{
    public partial class PersonelForm : Form
    {
        private string sorgu;
        public PersonelForm()
        {
            InitializeComponent();
        }

        private void sifreGosterButton_Click(object sender, EventArgs e)
        {
            sifreGosterButton.Text = personelSifreTxt.UseSystemPasswordChar ? "Gizle" : "Göster";
        }

        private void personelGirisButton_Click(object sender, EventArgs e)
        {
            bool girisDurum;
            // textboxlara girilen veriler veritabani ile karşılaştırılacak
            //sorguCumlesi = "select plakaId from plakalar where plaka=" + "'"+uyelikPlakaTxt.Text+"'";
            sorgu = "select perId from personel where perSifre"+"='"+personelSifreTxt.Text+"'";
            girisDurum = Veritabani.PersonelKontrol(sorgu, new string[] {personelIdTxt.Text, personelSifreTxt.Text});
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