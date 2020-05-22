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
        
        public FaturaGoster(int aracplakaid, string yeri, DateTime gsaati, DateTime csaati, double parksuresi, double toplamucret)
        {
            InitializeComponent();
            plakaLabel.Text += @" "+aracplakaid;
            parkLabel.Text += @" " + yeri;
            girisLabel.Text += @" " + gsaati;
            cikisLabel.Text += @" " + csaati;
            sureLabel.Text += @" " + parksuresi.ToString("F") + " Dakika";
            ucretLabel.Text += @" " + toplamucret.ToString("F") + " TL";
            
        }  
            

    }
}