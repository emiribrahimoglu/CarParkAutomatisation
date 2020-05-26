using System.ComponentModel;

namespace CarParkAutomatisation
{
    partial class AracCek
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
            this.araccekLabel = new System.Windows.Forms.Label();
            this.cekilenTxt = new System.Windows.Forms.TextBox();
            this.plakaLabel = new System.Windows.Forms.Label();
            this.yeniyerLabel = new System.Windows.Forms.Label();
            this.yeniyerTxt = new System.Windows.Forms.TextBox();
            this.aracCekBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // araccekLabel
            // 
            this.araccekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.araccekLabel.Location = new System.Drawing.Point(92, 18);
            this.araccekLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.araccekLabel.Name = "araccekLabel";
            this.araccekLabel.Size = new System.Drawing.Size(165, 52);
            this.araccekLabel.TabIndex = 0;
            this.araccekLabel.Text = "Araç Çekme";
            this.araccekLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cekilenTxt
            // 
            this.cekilenTxt.Location = new System.Drawing.Point(100, 93);
            this.cekilenTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cekilenTxt.Name = "cekilenTxt";
            this.cekilenTxt.Size = new System.Drawing.Size(157, 20);
            this.cekilenTxt.TabIndex = 1;
            // 
            // plakaLabel
            // 
            this.plakaLabel.Location = new System.Drawing.Point(9, 92);
            this.plakaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.plakaLabel.Name = "plakaLabel";
            this.plakaLabel.Size = new System.Drawing.Size(75, 19);
            this.plakaLabel.TabIndex = 2;
            this.plakaLabel.Text = "Plaka:";
            // 
            // yeniyerLabel
            // 
            this.yeniyerLabel.Location = new System.Drawing.Point(9, 125);
            this.yeniyerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yeniyerLabel.Name = "yeniyerLabel";
            this.yeniyerLabel.Size = new System.Drawing.Size(87, 19);
            this.yeniyerLabel.TabIndex = 3;
            this.yeniyerLabel.Text = "Yeni Park Yeri:";
            // 
            // yeniyerTxt
            // 
            this.yeniyerTxt.Location = new System.Drawing.Point(100, 123);
            this.yeniyerTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yeniyerTxt.Name = "yeniyerTxt";
            this.yeniyerTxt.Size = new System.Drawing.Size(157, 20);
            this.yeniyerTxt.TabIndex = 2;
            // 
            // aracCekBtn
            // 
            this.aracCekBtn.Location = new System.Drawing.Point(107, 184);
            this.aracCekBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aracCekBtn.Name = "aracCekBtn";
            this.aracCekBtn.Size = new System.Drawing.Size(142, 37);
            this.aracCekBtn.TabIndex = 3;
            this.aracCekBtn.Text = "Araç Çek";
            this.aracCekBtn.UseSelectable = true;
            this.aracCekBtn.Click += new System.EventHandler(this.aracCekBtn_Click);
            // 
            // AracCek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(311, 247);
            this.Controls.Add(this.aracCekBtn);
            this.Controls.Add(this.yeniyerTxt);
            this.Controls.Add(this.yeniyerLabel);
            this.Controls.Add(this.plakaLabel);
            this.Controls.Add(this.cekilenTxt);
            this.Controls.Add(this.araccekLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AracCek";
            this.Text = "AracCek";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private MetroFramework.Controls.MetroButton aracCekBtn;
        private System.Windows.Forms.Label araccekLabel;
        private System.Windows.Forms.TextBox cekilenTxt;
        private System.Windows.Forms.Label plakaLabel;
        private System.Windows.Forms.Label yeniyerLabel;
        private System.Windows.Forms.TextBox yeniyerTxt;

        #endregion
    }
}