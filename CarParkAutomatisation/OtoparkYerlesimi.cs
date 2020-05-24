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
            // kisi bu butona tikladigi zaman veri tabanindan bu butonun yeri getirilecek
            // insert edilme yapılmayacak
            string yer = a1Btn.Text;
            
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
            /* faturanın cikis saati ve parksureis haric tum bilgileri dolduruldu.
            simdi butona tıklandıktan sonra tekrardan ilk ekrana donülecek.
            Form1 form1 = new Form1();
            form1.Show();
             buradan "otoparktan çıkış" butonuna basılınca da cikis islemi baslayacak.
             */
        }
        


        private void otoparktanCikisBtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select plakaId from plakalar where plaka" + "='" + aracplaka + "'";
            int aracplakaid = Veritabani.PlakaGetir(sorgu);
            sorgu = "select girisSaati from girisCikis where faturaId" + "=(select max(faturaId) from girisCikis where plakaId"+"='"+aracplakaid+"')";
            Veritabani.FaturaKes(sorgu, aracplaka);
            Close();
        }

        private void a2Btn_Click(object sender, EventArgs e)
        {
            string yer = a2Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
            
        }

        private void a3Btn_Click(object sender, EventArgs e)
        {
            string yer = a3Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void a4Btn_Click(object sender, EventArgs e)
        {
            string yer = a4Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void a5Btn_Click(object sender, EventArgs e)
        {
            string yer = a5Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void a6Btn_Click(object sender, EventArgs e)
        {
            string yer = a6Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void b1Btn_Click(object sender, EventArgs e)
        {
            string yer = b1Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void b2Btn_Click(object sender, EventArgs e)
        {
            string yer = b2Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void b3Btn_Click(object sender, EventArgs e)
        {
            string yer = b3Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void b4Btn_Click(object sender, EventArgs e)
        {
            string yer = b4Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void b5Btn_Click(object sender, EventArgs e)
        {
            string yer = b5Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void b6Btn_Click(object sender, EventArgs e)
        {
            string yer = b6Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void c1Btn_Click(object sender, EventArgs e)
        {
            string yer = c1Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void c2Btn_Click(object sender, EventArgs e)
        {
            string yer = c2Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void c3Btn_Click(object sender, EventArgs e)
        {
            string yer = c3Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void c4Btn_Click(object sender, EventArgs e)
        {
            string yer = c4Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void c5Btn_Click(object sender, EventArgs e)
        {
            string yer = c5Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void c6Btn_Click(object sender, EventArgs e)
        {
            string yer = c6Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void d1Btn_Click(object sender, EventArgs e)
        {
            string yer = d1Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void d2Btn_Click(object sender, EventArgs e)
        {
            string yer = d2Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void d3Btn_Click(object sender, EventArgs e)
        {
            string yer = d3Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void d4Btn_Click(object sender, EventArgs e)
        {
            string yer = d4Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void d5Btn_Click(object sender, EventArgs e)
        {
            string yer = d5Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void d6Btn_Click(object sender, EventArgs e)
        {
            string yer = d6Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void e1Btn_Click(object sender, EventArgs e)
        {
            string yer = e1Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void e2Btn_Click(object sender, EventArgs e)
        {
            string yer = e2Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void e3Btn_Click(object sender, EventArgs e)
        {
            string yer = e3Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void e4Btn_Click(object sender, EventArgs e)
        {
            string yer = e4Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void e5Btn_Click(object sender, EventArgs e)
        {
            string yer = e5Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void e6Btn_Click(object sender, EventArgs e)
        {
            string yer = e6Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void f1Btn_Click(object sender, EventArgs e)
        {
            string yer = f1Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void f2Btn_Click(object sender, EventArgs e)
        {
            string yer = f2Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void f3Btn_Click(object sender, EventArgs e)
        {
            string yer = f3Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void f4Btn_Click(object sender, EventArgs e)
        {
            string yer = f4Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void f5Btn_Click(object sender, EventArgs e)
        {
            string yer = f5Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        private void f6Btn_Click(object sender, EventArgs e)
        {
            string yer = f6Btn.Text;
            Veritabani.Faturalandir(aracplaka,yer);
            Close();
        }

        
    }
    
}