using System;
using System.Windows.Forms;

namespace CarParkAutomatisation
{
    public partial class PersonelForm : Form
    {
        public PersonelForm()
        {
            InitializeComponent();
        }

        private void sifreGosterButton_Click(object sender, EventArgs e)
        {
            sifreGosterButton.Text = personelSifreTxt.UseSystemPasswordChar ? "Gizle" : "Göster";
        }
    }
}