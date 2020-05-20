using System;
using System.Windows.Forms;
using MetroFramework;

namespace CarParkAutomatisation
{
    public partial class UyeliksiGirisForm : Form
    {
        private string sorguCumlesi;
        private int plakaid;
        public UyeliksiGirisForm()
        {
            InitializeComponent();
        }

        private void uyeliksizGirisButton_Click(object sender, EventArgs e)
        {
            
            sorguCumlesi = "select plakaId from plakalar where plaka" + "='"+plakaNumTxt.Text.ToUpper()+"'";
            plakaid = Veritabani.PlakaGetir(sorguCumlesi);
            if (plakaid==0)
            {    
                sorguCumlesi = "insert into plakalar (plaka) values (@plaka)";
                Veritabani.PlakaEkle(sorguCumlesi,plakaNumTxt.Text);
                MetroMessageBox.Show(this, "GİRİŞ BAŞARILI! HOŞGELDİNİZ!", "PLAKA SISTEME EKLENDI!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                
            }
            else
            {
                MetroMessageBox.Show(this, "GİRİŞ BAŞARILI! TEKRAR HOŞGELDİNİZ", "PLAKA SİSTEMDE MEVCUT",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
            }


            
        }
    }
}