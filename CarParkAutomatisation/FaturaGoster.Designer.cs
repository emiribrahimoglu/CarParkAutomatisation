using System.ComponentModel;

namespace CarParkAutomatisation
{
    partial class FaturaGoster
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
            this.label1 = new System.Windows.Forms.Label();
            this.plakaLabel = new System.Windows.Forms.Label();
            this.parkLabel = new System.Windows.Forms.Label();
            this.girisLabel = new System.Windows.Forms.Label();
            this.cikisLabel = new System.Windows.Forms.Label();
            this.ucretLabel = new System.Windows.Forms.Label();
            this.sureLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.label1.Location = new System.Drawing.Point(71, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "FATURA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plakaLabel
            // 
            this.plakaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.plakaLabel.Location = new System.Drawing.Point(12, 174);
            this.plakaLabel.Name = "plakaLabel";
            this.plakaLabel.Size = new System.Drawing.Size(744, 57);
            this.plakaLabel.TabIndex = 1;
            this.plakaLabel.Text = "PLAKA: ";
            this.plakaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // parkLabel
            // 
            this.parkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.parkLabel.Location = new System.Drawing.Point(12, 231);
            this.parkLabel.Name = "parkLabel";
            this.parkLabel.Size = new System.Drawing.Size(744, 57);
            this.parkLabel.TabIndex = 2;
            this.parkLabel.Text = "PARK YERİ: ";
            this.parkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // girisLabel
            // 
            this.girisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.girisLabel.Location = new System.Drawing.Point(12, 288);
            this.girisLabel.Name = "girisLabel";
            this.girisLabel.Size = new System.Drawing.Size(744, 57);
            this.girisLabel.TabIndex = 3;
            this.girisLabel.Text = "GIRIS SAATI: ";
            this.girisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cikisLabel
            // 
            this.cikisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.cikisLabel.Location = new System.Drawing.Point(12, 345);
            this.cikisLabel.Name = "cikisLabel";
            this.cikisLabel.Size = new System.Drawing.Size(744, 57);
            this.cikisLabel.TabIndex = 4;
            this.cikisLabel.Text = "CIKIS SAATI: ";
            this.cikisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucretLabel
            // 
            this.ucretLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.ucretLabel.Location = new System.Drawing.Point(12, 459);
            this.ucretLabel.Name = "ucretLabel";
            this.ucretLabel.Size = new System.Drawing.Size(744, 57);
            this.ucretLabel.TabIndex = 5;
            this.ucretLabel.Text = "UCRET: ";
            this.ucretLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sureLabel
            // 
            this.sureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.sureLabel.Location = new System.Drawing.Point(12, 402);
            this.sureLabel.Name = "sureLabel";
            this.sureLabel.Size = new System.Drawing.Size(744, 57);
            this.sureLabel.TabIndex = 6;
            this.sureLabel.Text = "PARK SURESI: ";
            this.sureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FaturaGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(775, 521);
            this.Controls.Add(this.sureLabel);
            this.Controls.Add(this.ucretLabel);
            this.Controls.Add(this.cikisLabel);
            this.Controls.Add(this.girisLabel);
            this.Controls.Add(this.parkLabel);
            this.Controls.Add(this.plakaLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FaturaGoster";
            this.Text = "FaturaGoster";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label cikisLabel;
        private System.Windows.Forms.Label girisLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label parkLabel;
        private System.Windows.Forms.Label plakaLabel;
        private System.Windows.Forms.Label sureLabel;
        private System.Windows.Forms.Label ucretLabel;

        #endregion
    }
}