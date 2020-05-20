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
        Veritabani.Faturalandir(aracplaka);
        
        
        
    }
    
    
    
    
    
    
    
    
    }
}