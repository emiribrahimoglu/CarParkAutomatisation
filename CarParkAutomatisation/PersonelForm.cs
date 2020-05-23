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
            sorgu = "select perId from personel where perSifre"+"='"+personelSifreTxt.Text+"'";
            girisDurum = Veritabani.PersonelKontrol(sorgu, new string[] {personelIdTxt.Text, personelSifreTxt.Text});
            if (girisDurum)
            {
                MetroMessageBox.Show(this, "HOŞGELDİNİZ!", "GİRİŞ BAŞARILI", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Veritabani.Personelid = Convert.ToInt32(personelIdTxt.Text);
                AracCek aracCek = new AracCek();
                aracCek.Show();
                Close();
            }
            else
            {
                MetroMessageBox.Show(this, "ID VEYA ŞİFRE HATALI GİRİLDİ", "GİRİŞ BAŞARISIZ", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            
            
        }
    }
}