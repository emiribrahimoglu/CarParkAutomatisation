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
            this.araccekLabel.Location = new System.Drawing.Point(122, 22);
            this.araccekLabel.Name = "araccekLabel";
            this.araccekLabel.Size = new System.Drawing.Size(220, 64);
            this.araccekLabel.TabIndex = 0;
            this.araccekLabel.Text = "Araç Çekme";
            this.araccekLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cekilenTxt
            // 
            this.cekilenTxt.Location = new System.Drawing.Point(134, 114);
            this.cekilenTxt.Name = "cekilenTxt";
            this.cekilenTxt.Size = new System.Drawing.Size(208, 22);
            this.cekilenTxt.TabIndex = 1;
            // 
            // plakaLabel
            // 
            this.plakaLabel.Location = new System.Drawing.Point(12, 113);
            this.plakaLabel.Name = "plakaLabel";
            this.plakaLabel.Size = new System.Drawing.Size(100, 23);
            this.plakaLabel.TabIndex = 2;
            this.plakaLabel.Text = "Plaka:";
            // 
            // yeniyerLabel
            // 
            this.yeniyerLabel.Location = new System.Drawing.Point(12, 154);
            this.yeniyerLabel.Name = "yeniyerLabel";
            this.yeniyerLabel.Size = new System.Drawing.Size(116, 23);
            this.yeniyerLabel.TabIndex = 3;
            this.yeniyerLabel.Text = "Yeni Park Yeri:";
            // 
            // yeniyerTxt
            // 
            this.yeniyerTxt.Location = new System.Drawing.Point(134, 151);
            this.yeniyerTxt.Name = "yeniyerTxt";
            this.yeniyerTxt.Size = new System.Drawing.Size(208, 22);
            this.yeniyerTxt.TabIndex = 2;
            // 
            // aracCekBtn
            // 
            this.aracCekBtn.Location = new System.Drawing.Point(143, 227);
            this.aracCekBtn.Name = "aracCekBtn";
            this.aracCekBtn.Size = new System.Drawing.Size(190, 45);
            this.aracCekBtn.TabIndex = 3;
            this.aracCekBtn.Text = "Araç Çek";
            this.aracCekBtn.UseSelectable = true;
            this.aracCekBtn.Click += new System.EventHandler(this.aracCekBtn_Click);
            // 
            // AracCek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(415, 304);
            this.Controls.Add(this.aracCekBtn);
            this.Controls.Add(this.yeniyerTxt);
            this.Controls.Add(this.yeniyerLabel);
            this.Controls.Add(this.plakaLabel);
            this.Controls.Add(this.cekilenTxt);
            this.Controls.Add(this.araccekLabel);
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