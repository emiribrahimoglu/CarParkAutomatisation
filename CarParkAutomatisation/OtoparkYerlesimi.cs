using System;
using System.Windows.Forms;


namespace CarParkAutomatisation 
{
    public partial class OtoparkYerlesimi : Form
    {
        private string aracplaka=UyeliksiGirisForm.PlakaVer();
        public OtoparkYerlesimi()
        {
            InitializeComponent();
        }
        private void a1Btn_Click(object sender, EventArgs e)
        {
            string yer = a1Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            // faturanın cikis saati ve parksureis haric tum bilgileri dolduruldu.
            //simdi butona tıklandıktan sonra tekrardan ilk ekrana donülecek.
            Form1 form1 = new Form1();
            form1.Show();
            // buradan "otoparktan çıkış" butonuna basılınca da cikis islemi baslayacak.
        }


        private void otoparktanCikisBtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select plakaId from plakalar where plaka" + "='" + aracplaka + "'";
            int aracplakaid = Veritabani.PlakaGetir(sorgu);
            sorgu = "select girisSaati from girisCikis where faturaId" + "=(select max(faturaId) from girisCikis where plakaId"+"='"+aracplakaid+"')";
            Veritabani.FaturaKes(sorgu, aracplaka);
        }
    }
    
}