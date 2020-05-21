using System;
using System.Windows.Forms;

namespace CarParkAutomatisation
{
    public partial class FaturaGoster : Form
    {
        public FaturaGoster()
        {
            InitializeComponent();
        }
        
        public FaturaGoster(string aracplaka, string yeri, DateTime gsaati, DateTime csaati, double parksuresi, double toplamucret)
        {
            plakaLabel.Text += " "+aracplaka;
            parkLabel.Text += " " + yeri;
            girisLabel.Text += " " + gsaati;
            cikisLabel.Text += " " + csaati;
            sureLabel.Text += " " + parksuresi + "Dakika";
            ucretLabel.Text += " " + toplamucret + "TL";

        }  
            

    }
}