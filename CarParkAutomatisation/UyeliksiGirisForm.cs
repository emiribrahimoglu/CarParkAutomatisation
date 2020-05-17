using System;
using System.Windows.Forms;
using MetroFramework;

namespace CarParkAutomatisation
{
    public partial class UyeliksiGirisForm : Form
    {
        public UyeliksiGirisForm()
        {
            InitializeComponent();
        }

        private void uyeliksizGirisButton_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "GİRİŞ BAŞARILI! HOŞGELDİNİZ!", "ÜYELİKSİZ OLARAK GİRİŞ İŞLEMİ",
                MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
        }
    }
}