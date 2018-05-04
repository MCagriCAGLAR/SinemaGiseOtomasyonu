namespace SinemaGiseOtomasyonu
{
    partial class biletIptal
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
            this.tbBiletSil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butonBiletİptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBiletSil
            // 
            this.tbBiletSil.Location = new System.Drawing.Point(198, 47);
            this.tbBiletSil.Name = "tbBiletSil";
            this.tbBiletSil.Size = new System.Drawing.Size(100, 20);
            this.tbBiletSil.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(65, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "BiletID Giriniz :";
            // 
            // butonBiletİptal
            // 
            this.butonBiletİptal.BackColor = System.Drawing.Color.Brown;
            this.butonBiletİptal.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonBiletİptal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            //this.butonBiletİptal.Image = global::SinemaGiseOtomasyonu.Properties.Resources.asd;
            this.butonBiletİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butonBiletİptal.Location = new System.Drawing.Point(198, 96);
            this.butonBiletİptal.Name = "butonBiletİptal";
            this.butonBiletİptal.Size = new System.Drawing.Size(100, 57);
            this.butonBiletİptal.TabIndex = 2;
            this.butonBiletİptal.Text = "SİL";
            this.butonBiletİptal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butonBiletİptal.UseVisualStyleBackColor = false;
            this.butonBiletİptal.Click += new System.EventHandler(this.butonBiletİptal_Click);
            // 
            // biletIptal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(391, 216);
            this.Controls.Add(this.butonBiletİptal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBiletSil);
            this.Name = "biletIptal";
            this.Text = "biletIptal";
            this.Load += new System.EventHandler(this.biletIptal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBiletSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butonBiletİptal;
    }
}