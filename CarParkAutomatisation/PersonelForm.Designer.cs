using System.ComponentModel;

namespace CarParkAutomatisation
{
    partial class PersonelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.personelIdLabel = new System.Windows.Forms.Label();
            this.personelSifreLabel = new System.Windows.Forms.Label();
            this.personalGirisFormLabel = new MetroFramework.Controls.MetroLabel();
            this.sifreGosterButton = new MetroFramework.Controls.MetroButton();
            this.personelGirisButton = new MetroFramework.Controls.MetroButton();
            this.personelSifreTxt = new System.Windows.Forms.TextBox();
            this.personelIdTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // personelIdLabel
            // 
            this.personelIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.personelIdLabel.Location = new System.Drawing.Point(71, 186);
            this.personelIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.personelIdLabel.Name = "personelIdLabel";
            this.personelIdLabel.Size = new System.Drawing.Size(140, 42);
            this.personelIdLabel.TabIndex = 0;
            this.personelIdLabel.Text = "Personel ID";
            this.personelIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // personelSifreLabel
            // 
            this.personelSifreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.personelSifreLabel.Location = new System.Drawing.Point(41, 261);
            this.personelSifreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.personelSifreLabel.Name = "personelSifreLabel";
            this.personelSifreLabel.Size = new System.Drawing.Size(169, 42);
            this.personelSifreLabel.TabIndex = 1;
            this.personelSifreLabel.Text = "Personel Şifre";
            this.personelSifreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // personalGirisFormLabel
            // 
            this.personalGirisFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.personalGirisFormLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.personalGirisFormLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.personalGirisFormLabel.Location = new System.Drawing.Point(112, -1);
            this.personalGirisFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.personalGirisFormLabel.Name = "personalGirisFormLabel";
            this.personalGirisFormLabel.Size = new System.Drawing.Size(412, 108);
            this.personalGirisFormLabel.Style = MetroFramework.MetroColorStyle.Black;
            this.personalGirisFormLabel.TabIndex = 4;
            this.personalGirisFormLabel.Text = "PERSONEL GİRİŞ EKRANI";
            this.personalGirisFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.personalGirisFormLabel.UseCustomBackColor = true;
            this.personalGirisFormLabel.UseStyleColors = true;
            // 
            // sifreGosterButton
            // 
            this.sifreGosterButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.sifreGosterButton.Location = new System.Drawing.Point(452, 266);
            this.sifreGosterButton.Margin = new System.Windows.Forms.Padding(4);
            this.sifreGosterButton.Name = "sifreGosterButton";
            this.sifreGosterButton.Size = new System.Drawing.Size(72, 32);
            this.sifreGosterButton.TabIndex = 3;
            this.sifreGosterButton.Text = "Göster";
            this.sifreGosterButton.UseSelectable = true;
            this.sifreGosterButton.Click += new System.EventHandler(this.sifreGosterButton_Click);
            // 
            // personelGirisButton
            // 
            this.personelGirisButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.personelGirisButton.Location = new System.Drawing.Point(179, 390);
            this.personelGirisButton.Margin = new System.Windows.Forms.Padding(4);
            this.personelGirisButton.Name = "personelGirisButton";
            this.personelGirisButton.Size = new System.Drawing.Size(265, 86);
            this.personelGirisButton.TabIndex = 4;
            this.personelGirisButton.Text = "GİRİŞ";
            this.personelGirisButton.UseSelectable = true;
            this.personelGirisButton.Click += new System.EventHandler(this.personelGirisButton_Click);
            // 
            // personelSifreTxt
            // 
            this.personelSifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.personelSifreTxt.Location = new System.Drawing.Point(219, 266);
            this.personelSifreTxt.Margin = new System.Windows.Forms.Padding(4);
            this.personelSifreTxt.Name = "personelSifreTxt";
            this.personelSifreTxt.Size = new System.Drawing.Size(224, 30);
            this.personelSifreTxt.TabIndex = 2;
            // 
            // personelIdTxt
            // 
            this.personelIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.personelIdTxt.Location = new System.Drawing.Point(219, 191);
            this.personelIdTxt.Margin = new System.Windows.Forms.Padding(4);
            this.personelIdTxt.Name = "personelIdTxt";
            this.personelIdTxt.Size = new System.Drawing.Size(224, 30);
            this.personelIdTxt.TabIndex = 1;
            // 
            // PersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(625, 519);
            this.Controls.Add(this.personelIdTxt);
            this.Controls.Add(this.personelSifreTxt);
            this.Controls.Add(this.personelGirisButton);
            this.Controls.Add(this.sifreGosterButton);
            this.Controls.Add(this.personalGirisFormLabel);
            this.Controls.Add(this.personelSifreLabel);
            this.Controls.Add(this.personelIdLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonelForm";
            this.Text = "PersonelForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private MetroFramework.Controls.MetroLabel personalGirisFormLabel;
        private MetroFramework.Controls.MetroButton personelGirisButton;
        private System.Windows.Forms.Label personelIdLabel;
        private System.Windows.Forms.TextBox personelIdTxt;
        private System.Windows.Forms.Label personelSifreLabel;
        private System.Windows.Forms.TextBox personelSifreTxt;
        private MetroFramework.Controls.MetroButton sifreGosterButton;

        #endregion
    }
}