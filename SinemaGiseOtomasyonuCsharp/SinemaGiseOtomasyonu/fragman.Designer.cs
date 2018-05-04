namespace SinemaGiseOtomasyonu
{
    partial class fragman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fragman));
            this.WMPfilm = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.WMPfilm)).BeginInit();
            this.SuspendLayout();
            // 
            // WMPfilm
            // 
            this.WMPfilm.Enabled = true;
            this.WMPfilm.Location = new System.Drawing.Point(-1, 0);
            this.WMPfilm.Name = "WMPfilm";
            this.WMPfilm.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPfilm.OcxState")));
            this.WMPfilm.Size = new System.Drawing.Size(650, 387);
            this.WMPfilm.TabIndex = 0;
            // 
            // fragman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 387);
            this.Controls.Add(this.WMPfilm);
            this.Name = "fragman";
            this.Text = "fragman";
            this.Load += new System.EventHandler(this.fragman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WMPfilm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMPfilm;
    }
}