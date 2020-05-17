using System.Windows.Forms;

namespace CarParkAutomatisation
{
    public partial class UyeGirisForm : Form
    {
        public UyeGirisForm()
        {
            InitializeComponent();
        }

        private void uyelikAcButton_Click(object sender, System.EventArgs e)
        {
            YeniUye yeniUye = new YeniUye();
            yeniUye.Show();
        }
    }
}