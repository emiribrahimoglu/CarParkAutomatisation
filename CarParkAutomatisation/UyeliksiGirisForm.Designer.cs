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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeliksiGirisForm));
            this.plakaNumLabel = new System.Windows.Forms.Label();
            this.plakaNumTxt = new System.Windows.Forms.TextBox();
            this.uyeliksizGirisButton = new MetroFramework.Controls.MetroButton();
            this.uyeliksizGirisFormLabel = new MetroFramework.Controls.MetroLabel();
            this.homeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plakaNumLabel
            // 
            this.plakaNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.plakaNumLabel.Location = new System.Drawing.Point(42, 125);
            this.plakaNumLabel.Name = "plakaNumLabel";
            this.plakaNumLabel.Size = new System.Drawing.Size(149, 34);
            this.plakaNumLabel.TabIndex = 2;
            this.plakaNumLabel.Text = "Plaka Numarası";
            this.plakaNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plakaNumTxt
            // 
            this.plakaNumTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.plakaNumTxt.Location = new System.Drawing.Point(206, 129);
            this.plakaNumTxt.Name = "plakaNumTxt";
            this.plakaNumTxt.Size = new System.Drawing.Size(169, 26);
            this.plakaNumTxt.TabIndex = 9;
            // 
            // uyeliksizGirisButton
            // 
            this.uyeliksizGirisButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.uyeliksizGirisButton.Location = new System.Drawing.Point(112, 209);
            this.uyeliksizGirisButton.Name = "uyeliksizGirisButton";
            this.uyeliksizGirisButton.Size = new System.Drawing.Size(199, 70);
            this.uyeliksizGirisButton.TabIndex = 10;
            this.uyeliksizGirisButton.Text = "GİRİŞ";
            this.uyeliksizGirisButton.UseSelectable = true;
            this.uyeliksizGirisButton.Click += new System.EventHandler(this.uyeliksizGirisButton_Click);
            // 
            // uyeliksizGirisFormLabel
            // 
            this.uyeliksizGirisFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.uyeliksizGirisFormLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.uyeliksizGirisFormLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.uyeliksizGirisFormLabel.Location = new System.Drawing.Point(55, 9);
            this.uyeliksizGirisFormLabel.Name = "uyeliksizGirisFormLabel";
            this.uyeliksizGirisFormLabel.Size = new System.Drawing.Size(309, 88);
            this.uyeliksizGirisFormLabel.Style = MetroFramework.MetroColorStyle.Green;
            this.uyeliksizGirisFormLabel.TabIndex = 11;
            this.uyeliksizGirisFormLabel.Text = "ÜYELİKSİZ GİRİŞ EKRANI";
            this.uyeliksizGirisFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uyeliksizGirisFormLabel.UseCustomBackColor = true;
            this.uyeliksizGirisFormLabel.UseStyleColors = true;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Image = ((System.Drawing.Image) (resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(12, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(67, 62);
            this.homeButton.TabIndex = 12;
            this.homeButton.UseVisualStyleBackColor = false;
            // 
            // UyeliksiGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 291);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.uyeliksizGirisFormLabel);
            this.Controls.Add(this.uyeliksizGirisButton);
            this.Controls.Add(this.plakaNumTxt);
            this.Controls.Add(this.plakaNumLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UyeliksiGirisForm";
            this.Text = "UyeliksiGirisForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label plakaNumLabel;
        private System.Windows.Forms.TextBox plakaNumTxt;
        private MetroFramework.Controls.MetroButton uyeliksizGirisButton;
        private MetroFramework.Controls.MetroLabel uyeliksizGirisFormLabel;

        #endregion
    }
}