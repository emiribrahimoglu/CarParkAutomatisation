using System;
using System.Windows.Forms;

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
            // textboxlara girilen veriler veritabani ile karşılaştırılacak
            //sorguCumlesi = "select plakaId from plakalar where plaka=" + "'"+uyelikPlakaTxt.Text+"'";
            sorgu = "select perId from personel where perId=" + "'"+personelIdTxt.Text+"'";
           
        }
    }
}