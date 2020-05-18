﻿using System.ComponentModel;

namespace CarParkAutomatisation
{
    partial class UyeGirisForm
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
            this.uyeIdTxt = new System.Windows.Forms.TextBox();
            this.uyeSifreTxt = new System.Windows.Forms.TextBox();
            this.uyeGirisButton = new MetroFramework.Controls.MetroButton();
            this.sifreGosterButton = new MetroFramework.Controls.MetroButton();
            this.uyeSifreLabel = new System.Windows.Forms.Label();
            this.uyeIdLabel = new System.Windows.Forms.Label();
            this.uyelikAcButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // uyeIdTxt
            // 
            this.uyeIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.uyeIdTxt.Location = new System.Drawing.Point(192, 152);
            this.uyeIdTxt.Name = "uyeIdTxt";
            this.uyeIdTxt.Size = new System.Drawing.Size(169, 26);
            this.uyeIdTxt.TabIndex = 15;
            // 
            // uyeSifreTxt
            // 
            this.uyeSifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.uyeSifreTxt.Location = new System.Drawing.Point(192, 213);
            this.uyeSifreTxt.Name = "uyeSifreTxt";
            this.uyeSifreTxt.Size = new System.Drawing.Size(169, 26);
            this.uyeSifreTxt.TabIndex = 14;
            // 
            // uyeGirisButton
            // 
            this.uyeGirisButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.uyeGirisButton.Location = new System.Drawing.Point(152, 340);
            this.uyeGirisButton.Name = "uyeGirisButton";
            this.uyeGirisButton.Size = new System.Drawing.Size(199, 70);
            this.uyeGirisButton.TabIndex = 13;
            this.uyeGirisButton.Text = "GİRİŞ";
            this.uyeGirisButton.UseSelectable = true;
            // 
            // sifreGosterButton
            // 
            this.sifreGosterButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.sifreGosterButton.Location = new System.Drawing.Point(367, 213);
            this.sifreGosterButton.Name = "sifreGosterButton";
            this.sifreGosterButton.Size = new System.Drawing.Size(54, 26);
            this.sifreGosterButton.TabIndex = 12;
            this.sifreGosterButton.Text = "Göster";
            this.sifreGosterButton.UseSelectable = true;
            // 
            // uyeSifreLabel
            // 
            this.uyeSifreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.uyeSifreLabel.Location = new System.Drawing.Point(59, 209);
            this.uyeSifreLabel.Name = "uyeSifreLabel";
            this.uyeSifreLabel.Size = new System.Drawing.Size(127, 34);
            this.uyeSifreLabel.TabIndex = 11;
            this.uyeSifreLabel.Text = "Üye Şifre";
            this.uyeSifreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uyeIdLabel
            // 
            this.uyeIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.uyeIdLabel.Location = new System.Drawing.Point(81, 148);
            this.uyeIdLabel.Name = "uyeIdLabel";
            this.uyeIdLabel.Size = new System.Drawing.Size(105, 34);
            this.uyeIdLabel.TabIndex = 10;
            this.uyeIdLabel.Text = "Üye ID";
            this.uyeIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uyelikAcButton
            // 
            this.uyelikAcButton.BackColor = System.Drawing.Color.Transparent;
            this.uyelikAcButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uyelikAcButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.uyelikAcButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.uyelikAcButton.Location = new System.Drawing.Point(192, 245);
            this.uyelikAcButton.Name = "uyelikAcButton";
            this.uyelikAcButton.Size = new System.Drawing.Size(165, 27);
            this.uyelikAcButton.Style = MetroFramework.MetroColorStyle.Teal;
            this.uyelikAcButton.TabIndex = 16;
            this.uyelikAcButton.Text = "Üye Değil misiniz?";
            this.uyelikAcButton.UseCustomBackColor = true;
            this.uyelikAcButton.UseSelectable = true;
            this.uyelikAcButton.UseStyleColors = true;
            this.uyelikAcButton.Click += new System.EventHandler(this.uyelikAcButton_Click);
            // 
            // UyeGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 462);
            this.Controls.Add(this.uyelikAcButton);
            this.Controls.Add(this.uyeIdTxt);
            this.Controls.Add(this.uyeSifreTxt);
            this.Controls.Add(this.uyeGirisButton);
            this.Controls.Add(this.sifreGosterButton);
            this.Controls.Add(this.uyeSifreLabel);
            this.Controls.Add(this.uyeIdLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UyeGirisForm";
            this.Text = "UyeGirisForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private MetroFramework.Controls.MetroButton sifreGosterButton;
        private MetroFramework.Controls.MetroButton uyeGirisButton;
        private System.Windows.Forms.Label uyeIdLabel;
        private System.Windows.Forms.TextBox uyeIdTxt;
        private MetroFramework.Controls.MetroButton uyelikAcButton;
        private System.Windows.Forms.Label uyeSifreLabel;
        private System.Windows.Forms.TextBox uyeSifreTxt;

        #endregion
    }
}