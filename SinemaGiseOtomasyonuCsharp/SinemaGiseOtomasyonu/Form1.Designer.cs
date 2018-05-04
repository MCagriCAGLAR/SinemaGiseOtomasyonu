namespace SinemaGiseOtomasyonu
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
            this.butonCikis = new System.Windows.Forms.Button();
            this.butonMusteri = new System.Windows.Forms.Button();
            this.butonAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butonCikis
            // 
            this.butonCikis.BackColor = System.Drawing.Color.DarkRed;
            this.butonCikis.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonCikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            //this.butonCikis.Image = global::SinemaGiseOtomasyonu.Properties.Resources.exit;
            this.butonCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butonCikis.Location = new System.Drawing.Point(107, 167);
            this.butonCikis.Name = "butonCikis";
            this.butonCikis.Size = new System.Drawing.Size(120, 110);
            this.butonCikis.TabIndex = 2;
            this.butonCikis.Text = "Çıkış";
            this.butonCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butonCikis.UseVisualStyleBackColor = false;
            this.butonCikis.Click += new System.EventHandler(this.butonCikis_Click);
            // 
            // butonMusteri
            // 
            this.butonMusteri.BackColor = System.Drawing.Color.ForestGreen;
            this.butonMusteri.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonMusteri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            //this.butonMusteri.Image = global::SinemaGiseOtomasyonu.Properties.Resources.Ekran_Alıntısı;
            this.butonMusteri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butonMusteri.Location = new System.Drawing.Point(184, 29);
            this.butonMusteri.Name = "butonMusteri";
            this.butonMusteri.Size = new System.Drawing.Size(120, 110);
            this.butonMusteri.TabIndex = 1;
            this.butonMusteri.Text = "Müşteri Girişi";
            this.butonMusteri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butonMusteri.UseVisualStyleBackColor = false;
            this.butonMusteri.Click += new System.EventHandler(this.butonMusteri_Click);
            // 
            // butonAdmin
            // 
            this.butonAdmin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butonAdmin.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            //this.butonAdmin.Image = global::SinemaGiseOtomasyonu.Properties.Resources.login;
            this.butonAdmin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butonAdmin.Location = new System.Drawing.Point(30, 29);
            this.butonAdmin.Name = "butonAdmin";
            this.butonAdmin.Size = new System.Drawing.Size(120, 110);
            this.butonAdmin.TabIndex = 0;
            this.butonAdmin.Text = "Admin Girişi";
            this.butonAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butonAdmin.UseVisualStyleBackColor = false;
            this.butonAdmin.Click += new System.EventHandler(this.butonAdmin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackgroundImage = global::SinemaGiseOtomasyonu.Properties.Resources.wwwww;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.butonCikis);
            this.Controls.Add(this.butonMusteri);
            this.Controls.Add(this.butonAdmin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butonAdmin;
        private System.Windows.Forms.Button butonMusteri;
        private System.Windows.Forms.Button butonCikis;
    }
}

