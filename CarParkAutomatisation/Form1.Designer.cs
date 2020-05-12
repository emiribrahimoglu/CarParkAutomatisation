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
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.emirnaber = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(411, 246);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(121, 47);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "metroButton2";
            this.metroButton2.UseSelectable = true;
            // 
            // emirnaber
            // 
            this.emirnaber.Location = new System.Drawing.Point(198, 270);
            this.emirnaber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emirnaber.Name = "emirnaber";
            this.emirnaber.Size = new System.Drawing.Size(65, 22);
            this.emirnaber.TabIndex = 2;
            this.emirnaber.Text = "emir";
            this.emirnaber.UseSelectable = true;
            this.emirnaber.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(146, 133);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(65, 22);
            this.metroButton3.TabIndex = 3;
            this.metroButton3.Text = "babaaaaa";
            this.metroButton3.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.emirnaber);
            this.Controls.Add(this.metroButton2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton emirnaber;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}