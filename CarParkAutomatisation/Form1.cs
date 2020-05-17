using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkAutomatisation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saatLabel.Text = DateTime.Now.ToLongTimeString();
            tarihLabel.Text = DateTime.Today.ToLongDateString();
            saatTimer.Enabled = true;
        }

        private void saatTimer_Tick(object sender, EventArgs e)
        {
            saatLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void personelButton_Click(object sender, EventArgs e)
        {
            PersonelForm personelForm = new PersonelForm();
            personelForm.Show();
            //this.Hide();
        }

        private void uyeliksizButton_Click(object sender, EventArgs e)
        {
            UyeliksiGirisForm uyeliksiGirisForm = new UyeliksiGirisForm();
            uyeliksiGirisForm.Show();
            //this.Hide();
        }

        private void uyeButton_Click(object sender, EventArgs e)
        {
            UyeGirisForm uyeGirisForm = new UyeGirisForm();
            uyeGirisForm.Show();
        }
    }
}