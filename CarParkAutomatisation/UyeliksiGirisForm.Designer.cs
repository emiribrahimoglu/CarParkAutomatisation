using System.ComponentModel;

namespace CarParkAutomatisation
{
    partial class UyeliksiGirisForm
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
            this.plakaNumLabel = new System.Windows.Forms.Label();
            this.plakaNumTxt = new System.Windows.Forms.TextBox();
            this.uyeliksizGirisButton = new MetroFramework.Controls.MetroButton();
            this.uyeliksizGirisFormLabel = new MetroFramework.Controls.MetroLabel();
            this.uyeolLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plakaNumLabel
            // 
            this.plakaNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.plakaNumLabel.Location = new System.Drawing.Point(56, 154);
            this.plakaNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.plakaNumLabel.Name = "plakaNumLabel";
            this.plakaNumLabel.Size = new System.Drawing.Size(199, 42);
            this.plakaNumLabel.TabIndex = 2;
            this.plakaNumLabel.Text = "Plaka Numarası";
            this.plakaNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plakaNumTxt
            // 
            this.plakaNumTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.plakaNumTxt.Location = new System.Drawing.Point(275, 159);
            this.plakaNumTxt.Margin = new System.Windows.Forms.Padding(4);
            this.plakaNumTxt.Name = "plakaNumTxt";
            this.plakaNumTxt.Size = new System.Drawing.Size(224, 30);
            this.plakaNumTxt.TabIndex = 1;
            // 
            // uyeliksizGirisButton
            // 
            this.uyeliksizGirisButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.uyeliksizGirisButton.Location = new System.Drawing.Point(154, 230);
            this.uyeliksizGirisButton.Margin = new System.Windows.Forms.Padding(4);
            this.uyeliksizGirisButton.Name = "uyeliksizGirisButton";
            this.uyeliksizGirisButton.Size = new System.Drawing.Size(265, 86);
            this.uyeliksizGirisButton.TabIndex = 3;
            this.uyeliksizGirisButton.Text = "GİRİŞ";
            this.uyeliksizGirisButton.UseSelectable = true;
            this.uyeliksizGirisButton.Click += new System.EventHandler(this.uyeliksizGirisButton_Click);
            // 
            // uyeliksizGirisFormLabel
            // 
            this.uyeliksizGirisFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.uyeliksizGirisFormLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.uyeliksizGirisFormLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.uyeliksizGirisFormLabel.Location = new System.Drawing.Point(170, 15);
            this.uyeliksizGirisFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uyeliksizGirisFormLabel.Name = "uyeliksizGirisFormLabel";
            this.uyeliksizGirisFormLabel.Size = new System.Drawing.Size(412, 108);
            this.uyeliksizGirisFormLabel.Style = MetroFramework.MetroColorStyle.Black;
            this.uyeliksizGirisFormLabel.TabIndex = 11;
            this.uyeliksizGirisFormLabel.Text = "ÜYELİKSİZ GİRİŞ EKRANI";
            this.uyeliksizGirisFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uyeliksizGirisFormLabel.UseCustomBackColor = true;
            this.uyeliksizGirisFormLabel.UseStyleColors = true;
            // 
            // uyeolLbl
            // 
            this.uyeolLbl.Location = new System.Drawing.Point(306, 193);
            this.uyeolLbl.Name = "uyeolLbl";
            this.uyeolLbl.Size = new System.Drawing.Size(179, 23);
            this.uyeolLbl.TabIndex = 2;
            this.uyeolLbl.Text = "Üye Olmak İster Misiniz?";
            this.uyeolLbl.Click += new System.EventHandler(this.uyeolLbl_Click);
            // 
            // UyeliksiGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(595, 358);
            this.Controls.Add(this.uyeolLbl);
            this.Controls.Add(this.uyeliksizGirisFormLabel);
            this.Controls.Add(this.uyeliksizGirisButton);
            this.Controls.Add(this.plakaNumTxt);
            this.Controls.Add(this.plakaNumLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UyeliksiGirisForm";
            this.Text = "UyeliksiGirisForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label plakaNumLabel;
        private System.Windows.Forms.TextBox plakaNumTxt;
        private MetroFramework.Controls.MetroButton uyeliksizGirisButton;
        private MetroFramework.Controls.MetroLabel uyeliksizGirisFormLabel;
        private System.Windows.Forms.Label uyeolLbl;

        #endregion
    }
}