using System;
using System.Windows.Forms;
using MetroFramework;

namespace CarParkAutomatisation
{
    public partial class UyeliksiGirisForm : Form
    {
        private string sorguCumlesi;
        private string sorguCumlesi2;
        private int plakaid;
        private int plaka1;
        private static string duzplaka;
        

        

         
        
        
        public UyeliksiGirisForm()
        {
            InitializeComponent();
        }

        private void uyeliksizGirisButton_Click(object sender, EventArgs e)
        {




            UyeliksiGirisForm.duzplaka = plakaNumTxt.Text.ToUpper();
            
            sorguCumlesi = "select plakaId from plakalar where plaka" + "='"+plakaNumTxt.Text.ToUpper()+"'";
            plakaid = Veritabani.PlakaGetir(sorguCumlesi);
            if (plakaid==0)
            {    
                sorguCumlesi = "insert into plakalar (plaka) values (@plaka)";
                Veritabani.PlakaEkle(sorguCumlesi,plakaNumTxt.Text);
                MetroMessageBox.Show(this, "GİRİŞ BAŞARILI! HOŞGELDİNİZ!", "PLAKA SISTEME EKLENDI!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                // 
                
            }
            else // oyle bir plaka var demektir. o plaka uye mi diye sor
            {
                MetroMessageBox.Show(this, "GİRİŞ BAŞARILI! TEKRAR HOŞGELDİNİZ", "PLAKA SİSTEMDE MEVCUT",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                //sorguCumlesi = "select plakaId from uyeler where uyeler.plakaId" + "='"+plakaNumTxt.Text.ToUpper()+"'";
                
                // plakalardaki plaka idlerden uyelerdeki plaka id eslesiyorsa o adam uyedir
                // plkaid degiskeniyle bi plaka getirdik. eger bu plakaid uyeler tablsounda varsa uyedir
                

                sorguCumlesi2 = "select plakaId from uyeler where uyeler.plakaId= plakaid";
                plaka1 = Veritabani.PlakaGetir(sorguCumlesi2);
                //komut = new MySqlCommand(komutString, baglanti);
                //plakaid = Convert.ToInt32(komut.ExecuteScalar());
                if (plaka1!=0)
                {
                    MetroMessageBox.Show(this, "ÜYESİNİZ", "ÜYESİNİZ!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                }
                else
                {
                    MetroMessageBox.Show(this, "üye degilsiniz", "uye değil",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                }
                
                

                






            }
            
            //otoparkyerlesimi sayfasına gecis
            OtoparkYerlesimi otoparkYerlesimi = new OtoparkYerlesimi();
            otoparkYerlesimi.Show();
            // su anda plakami girdim ve yer secimi yapicam .
            // yer secimi yaptiktan sonra tiklanan her buton ayni fonksiyona gitsin ve
            // fonksiyonun icinde
            
            
            
            
            
            


            
        } //butonun parantezi bitti

        public static string PlakaVer()
        {
            
            MessageBox.Show("plaka ver:" + duzplaka);
            return duzplaka;
            
        }

        private void uyeolLbl_Click(object sender, EventArgs e)
        {
            YeniUye yeniUye = new YeniUye();
            yeniUye.Show();
        }
    }
}