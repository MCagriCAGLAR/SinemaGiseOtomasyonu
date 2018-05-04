namespace SinemaGiseOtomasyonu
{
    partial class calisanPaneli
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
            this.butonBiletSat = new System.Windows.Forms.Button();
            this.butonBiletIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butonBiletSat
            // 
            this.butonBiletSat.BackColor = System.Drawing.Color.Gold;
            this.butonBiletSat.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            //this.butonBiletSat.Image = global::SinemaGiseOtomasyonu.Properties.Resources.TİK2;
            this.butonBiletSat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butonBiletSat.Location = new System.Drawing.Point(116, 67);
            this.butonBiletSat.Name = "butonBiletSat";
            this.butonBiletSat.Size = new System.Drawing.Size(122, 117);
            this.butonBiletSat.TabIndex = 0;
            this.butonBiletSat.Text = "BİLET\r\nSAT";
            this.butonBiletSat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butonBiletSat.UseVisualStyleBackColor = false;
            this.butonBiletSat.Click += new System.EventHandler(this.butonBiletSat_Click);
            // 
            // butonBiletIptal
            // 
            this.butonBiletIptal.BackColor = System.Drawing.Color.Gold;
            this.butonBiletIptal.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            //this.butonBiletIptal.Image = global::SinemaGiseOtomasyonu.Properties.Resources.xisaret2;
            this.butonBiletIptal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butonBiletIptal.Location = new System.Drawing.Point(277, 67);
            this.butonBiletIptal.Name = "butonBiletIptal";
            this.butonBiletIptal.Size = new System.Drawing.Size(114, 117);
            this.butonBiletIptal.TabIndex = 1;
            this.butonBiletIptal.Text = "BİLET\r\nİPTAL";
            this.butonBiletIptal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butonBiletIptal.UseVisualStyleBackColor = false;
            this.butonBiletIptal.Click += new System.EventHandler(this.butonBiletIptal_Click);
            // 
            // calisanPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackgroundImage = global::SinemaGiseOtomasyonu.Properties.Resources.calisanpanel;
            this.ClientSize = new System.Drawing.Size(503, 253);
            this.Controls.Add(this.butonBiletIptal);
            this.Controls.Add(this.butonBiletSat);
            this.Name = "calisanPaneli";
            this.Text = "calisanPaneli";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butonBiletSat;
        private System.Windows.Forms.Button butonBiletIptal;
    }
}