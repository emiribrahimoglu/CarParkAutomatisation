using System;
using System.Windows.Forms;

namespace CarParkAutomatisation
{
    public partial class AracCek : Form
    {
        private static string sorgu;
        public AracCek()
        {
            InitializeComponent();
            int plaka = Convert.ToInt32(UyeliksiGirisForm.PlakaVer());
            sorgu = "select plakaId from girisCikis where plakaId" + "='"+plaka+"'";
            int plaka2 = Veritabani.PlakaGetir(sorgu);//cekilecek aracın plakası alındı
            //--ust gereksız olabilir
        }
        
        /* girilen plaka id ye ait gerekli bilgiler cekilecek
           aracın park edildigi yer (giriscikis tablosundaki park id) degistirilecek
           yani textbox a girdigimiz yeni yerin id si ile degistirilecek
           aracı yeni yerine cekilmis olacak
         */


        private void aracCekBtn_Click(object sender, EventArgs e)
        {
            sorgu = "select plakaId from plakalar where plaka" + "='" + cekilenTxt.Text.ToUpper() + "'";
            int plakaid = Veritabani.PlakaGetir(sorgu);
            sorgu = "select parkId from parkyerleri where parkyeri" + "='"+yeniyerTxt.Text.ToUpper()+"'";
            int parkid = Veritabani.ParkIdGetir(sorgu);
            sorgu = "update girisCikis set parkId = @parkid where girisCikis.plakaId = @cekilenid";
            Veritabani.AraciCek(sorgu,plakaid,parkid);
            MetroFramework.MetroMessageBox.Show(this, "Araç Yeni Yerine Çekildi.", "Çekme İşlemi Başarılı",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();
        }
    }
}