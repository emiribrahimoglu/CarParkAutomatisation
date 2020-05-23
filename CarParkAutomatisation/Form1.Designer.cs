namespace CarParkAutomatisation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.saatLabel = new MetroFramework.Controls.MetroLabel();
            this.saatTimer = new System.Windows.Forms.Timer(this.components);
            this.tarihLabel = new MetroFramework.Controls.MetroLabel();
            this.uyeButton = new MetroFramework.Controls.MetroButton();
            this.personelButton = new MetroFramework.Controls.MetroButton();
            this.uyeliksizButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // saatLabel
            // 
            this.saatLabel.AutoSize = true;
            this.saatLabel.BackColor = System.Drawing.Color.Cyan;
            this.saatLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.saatLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.saatLabel.Location = new System.Drawing.Point(12, 9);
            this.saatLabel.Name = "saatLabel";
            this.saatLabel.Size = new System.Drawing.Size(124, 25);
            this.saatLabel.TabIndex = 0;
            this.saatLabel.Text = "VarsayilanSaat";
            this.saatLabel.UseCustomBackColor = true;
            // 
            // saatTimer
            // 
            this.saatTimer.Interval = 1000;
            this.saatTimer.Tick += new System.EventHandler(this.saatTimer_Tick);
            // 
            // tarihLabel
            // 
            this.tarihLabel.AutoSize = true;
            this.tarihLabel.BackColor = System.Drawing.Color.Cyan;
            this.tarihLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.tarihLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.tarihLabel.Location = new System.Drawing.Point(384, 9);
            this.tarihLabel.Name = "tarihLabel";
            this.tarihLabel.Size = new System.Drawing.Size(126, 25);
            this.tarihLabel.TabIndex = 1;
            this.tarihLabel.Text = "VarsayilanTarih";
            this.tarihLabel.UseCustomBackColor = true;
            // 
            // uyeButton
            // 
            this.uyeButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.uyeButton.Location = new System.Drawing.Point(0, 182);
            this.uyeButton.Name = "uyeButton";
            this.uyeButton.Size = new System.Drawing.Size(234, 113);
            this.uyeButton.TabIndex = 2;
            this.uyeButton.Text = "Üye Girişi";
            this.uyeButton.UseSelectable = true;
            this.uyeButton.Click += new System.EventHandler(this.uyeButton_Click);
            // 
            // personelButton
            // 
            this.personelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.personelButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.personelButton.Location = new System.Drawing.Point(0, 361);
            this.personelButton.Name = "personelButton";
            this.personelButton.Size = new System.Drawing.Size(519, 83);
            this.personelButton.TabIndex = 3;
            this.personelButton.Text = "Personel Girişi";
            this.personelButton.UseSelectable = true;
            this.personelButton.Click += new System.EventHandler(this.personelButton_Click);
            // 
            // uyeliksizButton
            // 
            this.uyeliksizButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.uyeliksizButton.Location = new System.Drawing.Point(268, 182);
            this.uyeliksizButton.Name = "uyeliksizButton";
            this.uyeliksizButton.Size = new System.Drawing.Size(234, 113);
            this.uyeliksizButton.TabIndex = 4;
            this.uyeliksizButton.Text = "Üyeliksiz Giriş";
            this.uyeliksizButton.UseSelectable = true;
            this.uyeliksizButton.Click += new System.EventHandler(this.uyeliksizButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 444);
            this.Controls.Add(this.uyeliksizButton);
            this.Controls.Add(this.personelButton);
            this.Controls.Add(this.uyeButton);
            this.Controls.Add(this.tarihLabel);
            this.Controls.Add(this.saatLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "OtoparkOtomasyon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private MetroFramework.Controls.MetroButton personelButton;
        private MetroFramework.Controls.MetroLabel saatLabel;
        private System.Windows.Forms.Timer saatTimer;
        private MetroFramework.Controls.MetroLabel tarihLabel;
        private MetroFramework.Controls.MetroButton uyeButton;
        private MetroFramework.Controls.MetroButton uyeliksizButton;

        #endregion
    }
}