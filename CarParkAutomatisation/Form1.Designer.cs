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
            this.personelButton = new MetroFramework.Controls.MetroButton();
            this.uyeliksizButton = new MetroFramework.Controls.MetroButton();
            this.baslikLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saatLabel
            // 
            this.saatLabel.AutoSize = true;
            this.saatLabel.BackColor = System.Drawing.Color.Transparent;
            this.saatLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.saatLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.saatLabel.Location = new System.Drawing.Point(16, 11);
            this.saatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saatLabel.Name = "saatLabel";
            this.saatLabel.Size = new System.Drawing.Size(134, 25);
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
            this.tarihLabel.BackColor = System.Drawing.Color.Transparent;
            this.tarihLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.tarihLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.tarihLabel.Location = new System.Drawing.Point(385, 11);
            this.tarihLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tarihLabel.Name = "tarihLabel";
            this.tarihLabel.Size = new System.Drawing.Size(139, 25);
            this.tarihLabel.TabIndex = 1;
            this.tarihLabel.Text = "VarsayilanTarih";
            this.tarihLabel.UseCustomBackColor = true;
            // 
            // personelButton
            // 
            this.personelButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.personelButton.Location = new System.Drawing.Point(188, 304);
            this.personelButton.Margin = new System.Windows.Forms.Padding(4);
            this.personelButton.Name = "personelButton";
            this.personelButton.Size = new System.Drawing.Size(312, 139);
            this.personelButton.TabIndex = 2;
            this.personelButton.Text = "Personel Girişi";
            this.personelButton.UseSelectable = true;
            this.personelButton.Click += new System.EventHandler(this.personelButton_Click);
            // 
            // uyeliksizButton
            // 
            this.uyeliksizButton.BackColor = System.Drawing.Color.Transparent;
            this.uyeliksizButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.uyeliksizButton.ForeColor = System.Drawing.Color.Transparent;
            this.uyeliksizButton.Location = new System.Drawing.Point(188, 157);
            this.uyeliksizButton.Margin = new System.Windows.Forms.Padding(4);
            this.uyeliksizButton.Name = "uyeliksizButton";
            this.uyeliksizButton.Size = new System.Drawing.Size(312, 139);
            this.uyeliksizButton.TabIndex = 1;
            this.uyeliksizButton.Text = "GIRIS";
            this.uyeliksizButton.UseSelectable = true;
            this.uyeliksizButton.Click += new System.EventHandler(this.uyeliksizButton_Click);
            // 
            // baslikLabel
            // 
            this.baslikLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.baslikLabel.Location = new System.Drawing.Point(240, 78);
            this.baslikLabel.Name = "baslikLabel";
            this.baslikLabel.Size = new System.Drawing.Size(224, 57);
            this.baslikLabel.TabIndex = 3;
            this.baslikLabel.Text = "OTOPARK";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(692, 546);
            this.Controls.Add(this.baslikLabel);
            this.Controls.Add(this.uyeliksizButton);
            this.Controls.Add(this.personelButton);
            this.Controls.Add(this.tarihLabel);
            this.Controls.Add(this.saatLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "OtoparkOtomasyon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label baslikLabel;
        private MetroFramework.Controls.MetroButton personelButton;
        private MetroFramework.Controls.MetroLabel saatLabel;
        private System.Windows.Forms.Timer saatTimer;
        private MetroFramework.Controls.MetroLabel tarihLabel;
        private MetroFramework.Controls.MetroButton uyeliksizButton;

        #endregion
    }
}