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
            
        }
        
        private void aracCekBtn_Click(object sender, EventArgs e)
        {
            //Aracı çekmeden önce yeni-eski parkid'leri plaka id'si vesaire alınıp gönderiliyor,
            //işlem yapılan satırların max fatura id'ye göre en güncel işleme güncelleme yapıldığından emin olunuyor.
            sorgu = "select plakaId from plakalar where plaka" + "='" + cekilenTxt.Text.ToUpper() + "'";
            int plakaid = Veritabani.PlakaGetir(sorgu);
            sorgu = "select parkId from parkyerleri where parkyeri" + "='"+yeniyerTxt.Text.ToUpper()+"'";
            int parkid = Veritabani.ParkIdGetir(sorgu);
            string sorgu2 = "select max(faturaid) from giriscikis where plakaid" + "='" + plakaid + "'";
            sorgu = "select parkId from giriscikis where plakaId" + "='" + plakaid + "'";
            int eskiparkid = Veritabani.ParkIdGetir(sorgu);
            sorgu = "update girisCikis set parkId = @parkid where faturaId = @faturaid";
            Veritabani.AraciCek(sorgu,plakaid,parkid,eskiparkid, sorgu2);
            MetroFramework.MetroMessageBox.Show(this, "Araç Yeni Yerine Çekildi.", "Çekme İşlemi Başarılı",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();
        }

        
    }
}