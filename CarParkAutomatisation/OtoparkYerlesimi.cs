using System;
using System.Windows.Forms;


namespace CarParkAutomatisation 
{
    public partial class OtoparkYerlesimi : Form
    {
        private string aracplaka=UyeliksiGirisForm.PlakaVer();
        private string yer;
        Form1 form1 = new Form1();
        private static string sorgu;
        public OtoparkYerlesimi()
        {
            InitializeComponent();
        }
        private void a1Btn_Click(object sender, EventArgs e)
        {
            yer = a1Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            // faturanın cikis saati ve parksureis haric tum bilgileri dolduruldu.
            //simdi butona tıklandıktan sonra tekrardan ilk ekrana donülecek.
            form1.Show();
            // buradan "otoparktan çıkış" butonuna basılınca da cikis islemi baslayacak.
        }


        private void otoparktanCikisBtn_Click(object sender, EventArgs e)
        {
             // sorgu3 = "select uyeId from uyeler where plakaId" + "='"+plaka2+"'";
            sorgu = "select girisSaati from girisCikis where faturaId" + "=(select max(faturaId) from girisCikis where plakaId"+"='"+aracplaka+"')";
            //sorgu = "select girisSaati from girisCikis where faturaId" + "select max(faturaId) from girisCikis where plakaId"+"='"+aracplaka+"')";
            Veritabani.FaturaKes(sorgu, aracplaka);
        }
    }
    
}