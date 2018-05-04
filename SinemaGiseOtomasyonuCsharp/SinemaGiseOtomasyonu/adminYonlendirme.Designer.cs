namespace SinemaGiseOtomasyonu
{
    partial class adminYonlendirme
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
            this.butonCalisanEkleSil = new System.Windows.Forms.Button();
            this.butonFSS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butonCalisanEkleSil
            // 
            this.butonCalisanEkleSil.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            //this.butonCalisanEkleSil.Image = global::SinemaGiseOtomasyonu.Properties.Resources.kullanıcı_user_ebeveyn;
            this.butonCalisanEkleSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butonCalisanEkleSil.Location = new System.Drawing.Point(269, 66);
            this.butonCalisanEkleSil.Name = "butonCalisanEkleSil";
            this.butonCalisanEkleSil.Size = new System.Drawing.Size(155, 120);
            this.butonCalisanEkleSil.TabIndex = 1;
            this.butonCalisanEkleSil.Text = "Çalışan\r\nEKLE/SİL";
            this.butonCalisanEkleSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butonCalisanEkleSil.UseVisualStyleBackColor = true;
            this.butonCalisanEkleSil.Click += new System.EventHandler(this.butonCalisanEkleSil_Click);
            // 
            // butonFSS
            // 
            this.butonFSS.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            //this.butonFSS.Image = global::SinemaGiseOtomasyonu.Properties.Resources.new_line_cinema_logo;
            this.butonFSS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butonFSS.Location = new System.Drawing.Point(51, 66);
            this.butonFSS.Name = "butonFSS";
            this.butonFSS.Size = new System.Drawing.Size(155, 120);
            this.butonFSS.TabIndex = 0;
            this.butonFSS.Text = "Film, Salon, Seans EKLE/SİL";
            this.butonFSS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butonFSS.UseVisualStyleBackColor = true;
            this.butonFSS.Click += new System.EventHandler(this.butonFSS_Click);
            // 
            // adminYonlendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(480, 252);
            this.Controls.Add(this.butonCalisanEkleSil);
            this.Controls.Add(this.butonFSS);
            this.Name = "adminYonlendirme";
            this.Text = "adminYonlendirme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butonFSS;
        private System.Windows.Forms.Button butonCalisanEkleSil;
    }
}