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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelForm));
            this.personelIdLabel = new System.Windows.Forms.Label();
            this.personelSifreLabel = new System.Windows.Forms.Label();
            this.personalGirisFormLabel = new MetroFramework.Controls.MetroLabel();
            this.sifreGosterButton = new MetroFramework.Controls.MetroButton();
            this.personelGirisButton = new MetroFramework.Controls.MetroButton();
            this.homeButton = new System.Windows.Forms.Button();
            this.personelSifreTxt = new System.Windows.Forms.TextBox();
            this.personelIdTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // personelIdLabel
            // 
            this.personelIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.personelIdLabel.Location = new System.Drawing.Point(53, 151);
            this.personelIdLabel.Name = "personelIdLabel";
            this.personelIdLabel.Size = new System.Drawing.Size(105, 34);
            this.personelIdLabel.TabIndex = 0;
            this.personelIdLabel.Text = "Personel ID";
            this.personelIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // personelSifreLabel
            // 
            this.personelSifreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.personelSifreLabel.Location = new System.Drawing.Point(31, 212);
            this.personelSifreLabel.Name = "personelSifreLabel";
            this.personelSifreLabel.Size = new System.Drawing.Size(127, 34);
            this.personelSifreLabel.TabIndex = 1;
            this.personelSifreLabel.Text = "Personel Şifre";
            this.personelSifreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // personalGirisFormLabel
            // 
            this.personalGirisFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.personalGirisFormLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.personalGirisFormLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.personalGirisFormLabel.Location = new System.Drawing.Point(84, -1);
            this.personalGirisFormLabel.Name = "personalGirisFormLabel";
            this.personalGirisFormLabel.Size = new System.Drawing.Size(309, 88);
            this.personalGirisFormLabel.Style = MetroFramework.MetroColorStyle.Green;
            this.personalGirisFormLabel.TabIndex = 4;
            this.personalGirisFormLabel.Text = "PERSONEL GİRİŞ EKRANI";
            this.personalGirisFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.personalGirisFormLabel.UseCustomBackColor = true;
            this.personalGirisFormLabel.UseStyleColors = true;
            // 
            // sifreGosterButton
            // 
            this.sifreGosterButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.sifreGosterButton.Location = new System.Drawing.Point(339, 216);
            this.sifreGosterButton.Name = "sifreGosterButton";
            this.sifreGosterButton.Size = new System.Drawing.Size(54, 26);
            this.sifreGosterButton.TabIndex = 5;
            this.sifreGosterButton.Text = "Göster";
            this.sifreGosterButton.UseSelectable = true;
            this.sifreGosterButton.Click += new System.EventHandler(this.sifreGosterButton_Click);
            // 
            // personelGirisButton
            // 
            this.personelGirisButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.personelGirisButton.Location = new System.Drawing.Point(134, 317);
            this.personelGirisButton.Name = "personelGirisButton";
            this.personelGirisButton.Size = new System.Drawing.Size(199, 70);
            this.personelGirisButton.TabIndex = 6;
            this.personelGirisButton.Text = "GİRİŞ";
            this.personelGirisButton.UseSelectable = true;
            this.personelGirisButton.Click += new System.EventHandler(this.personelGirisButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Image = ((System.Drawing.Image) (resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(11, 11);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(67, 62);
            this.homeButton.TabIndex = 7;
            this.homeButton.UseVisualStyleBackColor = false;
            // 
            // personelSifreTxt
            // 
            this.personelSifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.personelSifreTxt.Location = new System.Drawing.Point(164, 216);
            this.personelSifreTxt.Name = "personelSifreTxt";
            this.personelSifreTxt.Size = new System.Drawing.Size(169, 26);
            this.personelSifreTxt.TabIndex = 8;
            // 
            // personelIdTxt
            // 
            this.personelIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.personelIdTxt.Location = new System.Drawing.Point(164, 155);
            this.personelIdTxt.Name = "personelIdTxt";
            this.personelIdTxt.Size = new System.Drawing.Size(169, 26);
            this.personelIdTxt.TabIndex = 9;
            // 
            // PersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 422);
            this.Controls.Add(this.personelIdTxt);
            this.Controls.Add(this.personelSifreTxt);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.personelGirisButton);
            this.Controls.Add(this.sifreGosterButton);
            this.Controls.Add(this.personalGirisFormLabel);
            this.Controls.Add(this.personelSifreLabel);
            this.Controls.Add(this.personelIdLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PersonelForm";
            this.Text = "PersonelForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button homeButton;
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