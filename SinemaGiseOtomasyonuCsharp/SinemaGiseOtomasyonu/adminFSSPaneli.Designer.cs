namespace SinemaGiseOtomasyonu
{
    partial class adminPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPaneli));
            this.groupBoxFilm = new System.Windows.Forms.GroupBox();
            this.cbFilmTuru = new System.Windows.Forms.ComboBox();
            this.cbYapimci = new System.Windows.Forms.ComboBox();
            this.cb3D = new System.Windows.Forms.ComboBox();
            this.labelFilmAdi = new System.Windows.Forms.Label();
            this.labelfilmTuru = new System.Windows.Forms.Label();
            this.tbFilmSuresi = new System.Windows.Forms.TextBox();
            this.labelfilm3D = new System.Windows.Forms.Label();
            this.labelFilmSuresi = new System.Windows.Forms.Label();
            this.tbFilmAdi = new System.Windows.Forms.TextBox();
            this.labelYerliYabanci = new System.Windows.Forms.Label();
            this.groupBoxFilm2 = new System.Windows.Forms.GroupBox();
            this.tbFilmSil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSalon = new System.Windows.Forms.GroupBox();
            this.groupBoxSalon2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSalonSil = new System.Windows.Forms.TextBox();
            this.labelSalon = new System.Windows.Forms.Label();
            this.labelKapasite = new System.Windows.Forms.Label();
            this.tbKapasite = new System.Windows.Forms.TextBox();
            this.tbSalonAdi = new System.Windows.Forms.TextBox();
            this.groupBoxSeans = new System.Windows.Forms.GroupBox();
            this.groupBoxSeans2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSeansSil = new System.Windows.Forms.TextBox();
            this.labelSaat = new System.Windows.Forms.Label();
            this.labelSeansSaati = new System.Windows.Forms.Label();
            this.tbSeansSaati = new System.Windows.Forms.TextBox();
            this.lwFilm = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFilmAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFilmTuru = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3D = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderYapimci = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bSeansSil = new System.Windows.Forms.Button();
            this.bSalonSil = new System.Windows.Forms.Button();
            this.bFilmSil = new System.Windows.Forms.Button();
            this.butonSeansSil = new System.Windows.Forms.Button();
            this.butonSalonSil = new System.Windows.Forms.Button();
            this.butonFilmKaydet = new System.Windows.Forms.Button();
            this.butonSeansKaydet = new System.Windows.Forms.Button();
            this.butonFilmSil = new System.Windows.Forms.Button();
            this.butonSeansGoster = new System.Windows.Forms.Button();
            this.butonSalonGoster = new System.Windows.Forms.Button();
            this.butonFilmGoster = new System.Windows.Forms.Button();
            this.butonSalonKaydet = new System.Windows.Forms.Button();
            this.butonSalon = new System.Windows.Forms.Button();
            this.butonSeans = new System.Windows.Forms.Button();
            this.butonFilm = new System.Windows.Forms.Button();
            this.groupBoxFilm.SuspendLayout();
            this.groupBoxFilm2.SuspendLayout();
            this.groupBoxSalon.SuspendLayout();
            this.groupBoxSalon2.SuspendLayout();
            this.groupBoxSeans.SuspendLayout();
            this.groupBoxSeans2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFilm
            // 
            this.groupBoxFilm.BackColor = System.Drawing.Color.ForestGreen;
            this.groupBoxFilm.Controls.Add(this.butonFilmKaydet);
            this.groupBoxFilm.Controls.Add(this.cbFilmTuru);
            this.groupBoxFilm.Controls.Add(this.cbYapimci);
            this.groupBoxFilm.Controls.Add(this.cb3D);
            this.groupBoxFilm.Controls.Add(this.labelFilmAdi);
            this.groupBoxFilm.Controls.Add(this.labelfilmTuru);
            this.groupBoxFilm.Controls.Add(this.tbFilmSuresi);
            this.groupBoxFilm.Controls.Add(this.labelfilm3D);
            this.groupBoxFilm.Controls.Add(this.labelFilmSuresi);
            this.groupBoxFilm.Controls.Add(this.tbFilmAdi);
            this.groupBoxFilm.Controls.Add(this.labelYerliYabanci);
            this.groupBoxFilm.Location = new System.Drawing.Point(14, 69);
            this.groupBoxFilm.Name = "groupBoxFilm";
            this.groupBoxFilm.Size = new System.Drawing.Size(250, 200);
            this.groupBoxFilm.TabIndex = 1;
            this.groupBoxFilm.TabStop = false;
            this.groupBoxFilm.Text = "Film Ekleme Paneli";
            // 
            // cbFilmTuru
            // 
            this.cbFilmTuru.FormattingEnabled = true;
            this.cbFilmTuru.Items.AddRange(new object[] {
            "Aksiyon",
            "Bilim Kurgu",
            "Dram",
            "Fantastik",
            "Gerilim",
            "Komedi",
            "Korku",
            "Macera",
            "Romantik",
            "Romantik Komedi"});
            this.cbFilmTuru.Location = new System.Drawing.Point(113, 50);
            this.cbFilmTuru.Name = "cbFilmTuru";
            this.cbFilmTuru.Size = new System.Drawing.Size(126, 21);
            this.cbFilmTuru.TabIndex = 2;
            // 
            // cbYapimci
            // 
            this.cbYapimci.FormattingEnabled = true;
            this.cbYapimci.Items.AddRange(new object[] {
            "Yerli",
            "Yabancı"});
            this.cbYapimci.Location = new System.Drawing.Point(113, 127);
            this.cbYapimci.Name = "cbYapimci";
            this.cbYapimci.Size = new System.Drawing.Size(126, 21);
            this.cbYapimci.TabIndex = 5;
            // 
            // cb3D
            // 
            this.cb3D.FormattingEnabled = true;
            this.cb3D.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.cb3D.Location = new System.Drawing.Point(113, 76);
            this.cb3D.Name = "cb3D";
            this.cb3D.Size = new System.Drawing.Size(126, 21);
            this.cb3D.TabIndex = 3;
            // 
            // labelFilmAdi
            // 
            this.labelFilmAdi.AutoSize = true;
            this.labelFilmAdi.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFilmAdi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFilmAdi.Location = new System.Drawing.Point(4, 27);
            this.labelFilmAdi.Name = "labelFilmAdi";
            this.labelFilmAdi.Size = new System.Drawing.Size(64, 17);
            this.labelFilmAdi.TabIndex = 4;
            this.labelFilmAdi.Text = "Film Adı:";
            // 
            // labelfilmTuru
            // 
            this.labelfilmTuru.AutoSize = true;
            this.labelfilmTuru.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelfilmTuru.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelfilmTuru.Location = new System.Drawing.Point(4, 52);
            this.labelfilmTuru.Name = "labelfilmTuru";
            this.labelfilmTuru.Size = new System.Drawing.Size(72, 17);
            this.labelfilmTuru.TabIndex = 4;
            this.labelfilmTuru.Text = "Film Türü:";
            // 
            // tbFilmSuresi
            // 
            this.tbFilmSuresi.Location = new System.Drawing.Point(113, 101);
            this.tbFilmSuresi.Name = "tbFilmSuresi";
            this.tbFilmSuresi.Size = new System.Drawing.Size(126, 20);
            this.tbFilmSuresi.TabIndex = 4;
            // 
            // labelfilm3D
            // 
            this.labelfilm3D.AutoSize = true;
            this.labelfilm3D.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelfilm3D.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelfilm3D.Location = new System.Drawing.Point(4, 77);
            this.labelfilm3D.Name = "labelfilm3D";
            this.labelfilm3D.Size = new System.Drawing.Size(62, 17);
            this.labelfilm3D.TabIndex = 4;
            this.labelfilm3D.Text = "Film 3D:";
            // 
            // labelFilmSuresi
            // 
            this.labelFilmSuresi.AutoSize = true;
            this.labelFilmSuresi.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFilmSuresi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFilmSuresi.Location = new System.Drawing.Point(4, 102);
            this.labelFilmSuresi.Name = "labelFilmSuresi";
            this.labelFilmSuresi.Size = new System.Drawing.Size(110, 17);
            this.labelFilmSuresi.TabIndex = 4;
            this.labelFilmSuresi.Text = "Film Süresi(dk):";
            // 
            // tbFilmAdi
            // 
            this.tbFilmAdi.Location = new System.Drawing.Point(113, 26);
            this.tbFilmAdi.Name = "tbFilmAdi";
            this.tbFilmAdi.Size = new System.Drawing.Size(126, 20);
            this.tbFilmAdi.TabIndex = 1;
            // 
            // labelYerliYabanci
            // 
            this.labelYerliYabanci.AutoSize = true;
            this.labelYerliYabanci.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYerliYabanci.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelYerliYabanci.Location = new System.Drawing.Point(4, 128);
            this.labelYerliYabanci.Name = "labelYerliYabanci";
            this.labelYerliYabanci.Size = new System.Drawing.Size(106, 17);
            this.labelYerliYabanci.TabIndex = 4;
            this.labelYerliYabanci.Text = "Film Yapımcısı:";
            // 
            // groupBoxFilm2
            // 
            this.groupBoxFilm2.BackColor = System.Drawing.Color.Firebrick;
            this.groupBoxFilm2.Controls.Add(this.bFilmSil);
            this.groupBoxFilm2.Controls.Add(this.tbFilmSil);
            this.groupBoxFilm2.Controls.Add(this.label1);
            this.groupBoxFilm2.Location = new System.Drawing.Point(14, 69);
            this.groupBoxFilm2.Name = "groupBoxFilm2";
            this.groupBoxFilm2.Size = new System.Drawing.Size(250, 200);
            this.groupBoxFilm2.TabIndex = 4;
            this.groupBoxFilm2.TabStop = false;
            this.groupBoxFilm2.Text = "Film Silme Paneli";
            this.groupBoxFilm2.Enter += new System.EventHandler(this.groupBoxFilm2_Enter);
            // 
            // tbFilmSil
            // 
            this.tbFilmSil.Location = new System.Drawing.Point(72, 43);
            this.tbFilmSil.Name = "tbFilmSil";
            this.tbFilmSil.Size = new System.Drawing.Size(100, 20);
            this.tbFilmSil.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film ID:";
            // 
            // groupBoxSalon
            // 
            this.groupBoxSalon.BackColor = System.Drawing.Color.ForestGreen;
            this.groupBoxSalon.Controls.Add(this.butonSalonKaydet);
            this.groupBoxSalon.Controls.Add(this.labelSalon);
            this.groupBoxSalon.Controls.Add(this.labelKapasite);
            this.groupBoxSalon.Controls.Add(this.tbKapasite);
            this.groupBoxSalon.Controls.Add(this.tbSalonAdi);
            this.groupBoxSalon.Location = new System.Drawing.Point(288, 68);
            this.groupBoxSalon.Name = "groupBoxSalon";
            this.groupBoxSalon.Size = new System.Drawing.Size(250, 200);
            this.groupBoxSalon.TabIndex = 2;
            this.groupBoxSalon.TabStop = false;
            this.groupBoxSalon.Text = "Salon Ekleme Paneli";
            // 
            // groupBoxSalon2
            // 
            this.groupBoxSalon2.BackColor = System.Drawing.Color.Firebrick;
            this.groupBoxSalon2.Controls.Add(this.bSalonSil);
            this.groupBoxSalon2.Controls.Add(this.label2);
            this.groupBoxSalon2.Controls.Add(this.tbSalonSil);
            this.groupBoxSalon2.Location = new System.Drawing.Point(288, 68);
            this.groupBoxSalon2.Name = "groupBoxSalon2";
            this.groupBoxSalon2.Size = new System.Drawing.Size(250, 200);
            this.groupBoxSalon2.TabIndex = 5;
            this.groupBoxSalon2.TabStop = false;
            this.groupBoxSalon2.Text = "Salon Silme Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salon ID:";
            // 
            // tbSalonSil
            // 
            this.tbSalonSil.Location = new System.Drawing.Point(84, 44);
            this.tbSalonSil.Name = "tbSalonSil";
            this.tbSalonSil.Size = new System.Drawing.Size(111, 20);
            this.tbSalonSil.TabIndex = 0;
            // 
            // labelSalon
            // 
            this.labelSalon.AutoSize = true;
            this.labelSalon.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSalon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSalon.Location = new System.Drawing.Point(9, 27);
            this.labelSalon.Name = "labelSalon";
            this.labelSalon.Size = new System.Drawing.Size(72, 17);
            this.labelSalon.TabIndex = 4;
            this.labelSalon.Text = "Salon Adı:";
            // 
            // labelKapasite
            // 
            this.labelKapasite.AutoSize = true;
            this.labelKapasite.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKapasite.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelKapasite.Location = new System.Drawing.Point(13, 51);
            this.labelKapasite.Name = "labelKapasite";
            this.labelKapasite.Size = new System.Drawing.Size(69, 17);
            this.labelKapasite.TabIndex = 4;
            this.labelKapasite.Text = "Kapasite:";
            // 
            // tbKapasite
            // 
            this.tbKapasite.Location = new System.Drawing.Point(97, 50);
            this.tbKapasite.Name = "tbKapasite";
            this.tbKapasite.Size = new System.Drawing.Size(126, 20);
            this.tbKapasite.TabIndex = 2;
            // 
            // tbSalonAdi
            // 
            this.tbSalonAdi.Location = new System.Drawing.Point(97, 27);
            this.tbSalonAdi.Name = "tbSalonAdi";
            this.tbSalonAdi.Size = new System.Drawing.Size(126, 20);
            this.tbSalonAdi.TabIndex = 1;
            // 
            // groupBoxSeans
            // 
            this.groupBoxSeans.BackColor = System.Drawing.Color.ForestGreen;
            this.groupBoxSeans.Controls.Add(this.butonSeansKaydet);
            this.groupBoxSeans.Controls.Add(this.labelSaat);
            this.groupBoxSeans.Controls.Add(this.labelSeansSaati);
            this.groupBoxSeans.Controls.Add(this.tbSeansSaati);
            this.groupBoxSeans.Location = new System.Drawing.Point(561, 68);
            this.groupBoxSeans.Name = "groupBoxSeans";
            this.groupBoxSeans.Size = new System.Drawing.Size(250, 200);
            this.groupBoxSeans.TabIndex = 3;
            this.groupBoxSeans.TabStop = false;
            this.groupBoxSeans.Text = "Seans Ekleme Paneli";
            // 
            // groupBoxSeans2
            // 
            this.groupBoxSeans2.BackColor = System.Drawing.Color.Firebrick;
            this.groupBoxSeans2.Controls.Add(this.bSeansSil);
            this.groupBoxSeans2.Controls.Add(this.label3);
            this.groupBoxSeans2.Controls.Add(this.tbSeansSil);
            this.groupBoxSeans2.Location = new System.Drawing.Point(561, 68);
            this.groupBoxSeans2.Name = "groupBoxSeans2";
            this.groupBoxSeans2.Size = new System.Drawing.Size(250, 200);
            this.groupBoxSeans2.TabIndex = 6;
            this.groupBoxSeans2.TabStop = false;
            this.groupBoxSeans2.Text = "Seans Silme Paneli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Seans ID:";
            // 
            // tbSeansSil
            // 
            this.tbSeansSil.Location = new System.Drawing.Point(81, 43);
            this.tbSeansSil.Name = "tbSeansSil";
            this.tbSeansSil.Size = new System.Drawing.Size(100, 20);
            this.tbSeansSil.TabIndex = 0;
            // 
            // labelSaat
            // 
            this.labelSaat.AutoSize = true;
            this.labelSaat.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSaat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSaat.Location = new System.Drawing.Point(108, 55);
            this.labelSaat.Name = "labelSaat";
            this.labelSaat.Size = new System.Drawing.Size(46, 17);
            this.labelSaat.TabIndex = 6;
            this.labelSaat.Text = "SS:DD";
            // 
            // labelSeansSaati
            // 
            this.labelSeansSaati.AutoSize = true;
            this.labelSeansSaati.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSeansSaati.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSeansSaati.Location = new System.Drawing.Point(6, 27);
            this.labelSeansSaati.Name = "labelSeansSaati";
            this.labelSeansSaati.Size = new System.Drawing.Size(88, 17);
            this.labelSeansSaati.TabIndex = 4;
            this.labelSeansSaati.Text = "Seans Saati:";
            // 
            // tbSeansSaati
            // 
            this.tbSeansSaati.Location = new System.Drawing.Point(96, 25);
            this.tbSeansSaati.Name = "tbSeansSaati";
            this.tbSeansSaati.Size = new System.Drawing.Size(126, 20);
            this.tbSeansSaati.TabIndex = 1;
            // 
            // lwFilm
            // 
            this.lwFilm.BackColor = System.Drawing.SystemColors.Highlight;
            this.lwFilm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeaderFilmAdi,
            this.columnHeaderFilmTuru,
            this.columnHeader3D,
            this.columnHeaderSure,
            this.columnHeaderYapimci});
            this.lwFilm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lwFilm.ForeColor = System.Drawing.Color.Crimson;
            this.lwFilm.GridLines = true;
            this.lwFilm.Location = new System.Drawing.Point(12, 327);
            this.lwFilm.Name = "lwFilm";
            this.lwFilm.Size = new System.Drawing.Size(796, 232);
            this.lwFilm.TabIndex = 4;
            this.lwFilm.UseCompatibleStateImageBehavior = false;
            this.lwFilm.View = System.Windows.Forms.View.Details;
            this.lwFilm.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Film Kodu";
            this.columnHeader1.Width = 68;
            // 
            // columnHeaderFilmAdi
            // 
            this.columnHeaderFilmAdi.Text = "Filmin Adı";
            this.columnHeaderFilmAdi.Width = 171;
            // 
            // columnHeaderFilmTuru
            // 
            this.columnHeaderFilmTuru.Text = "Filmin Türü";
            this.columnHeaderFilmTuru.Width = 156;
            // 
            // columnHeader3D
            // 
            this.columnHeader3D.Text = "Film 3D mi ?";
            this.columnHeader3D.Width = 94;
            // 
            // columnHeaderSure
            // 
            this.columnHeaderSure.Text = "Filmin Süresi";
            this.columnHeaderSure.Width = 114;
            // 
            // columnHeaderYapimci
            // 
            this.columnHeaderYapimci.Text = "Film Yerli mi ?";
            this.columnHeaderYapimci.Width = 109;
            // 
            // bSeansSil
            // 
            this.bSeansSil.BackColor = System.Drawing.Color.Firebrick;
            //this.bSeansSil.Image = global::SinemaGiseOtomasyonu.Properties.Resources.asd;
            this.bSeansSil.Location = new System.Drawing.Point(131, 70);
            this.bSeansSil.Name = "bSeansSil";
            this.bSeansSil.Size = new System.Drawing.Size(50, 50);
            this.bSeansSil.TabIndex = 2;
            this.bSeansSil.UseVisualStyleBackColor = false;
            this.bSeansSil.Click += new System.EventHandler(this.bSeansSil_Click);
            // 
            // bSalonSil
            // 
            this.bSalonSil.BackColor = System.Drawing.Color.Firebrick;
            //this.bSalonSil.Image = global::SinemaGiseOtomasyonu.Properties.Resources.asd;
            this.bSalonSil.Location = new System.Drawing.Point(145, 74);
            this.bSalonSil.Name = "bSalonSil";
            this.bSalonSil.Size = new System.Drawing.Size(50, 50);
            this.bSalonSil.TabIndex = 2;
            this.bSalonSil.UseVisualStyleBackColor = false;
            this.bSalonSil.Click += new System.EventHandler(this.bSalonSil_Click);
            // 
            // bFilmSil
            // 
            this.bFilmSil.BackColor = System.Drawing.Color.Firebrick;
            //this.bFilmSil.Image = global::SinemaGiseOtomasyonu.Properties.Resources.asd;
            this.bFilmSil.Location = new System.Drawing.Point(122, 75);
            this.bFilmSil.Name = "bFilmSil";
            this.bFilmSil.Size = new System.Drawing.Size(50, 50);
            this.bFilmSil.TabIndex = 2;
            this.bFilmSil.UseVisualStyleBackColor = false;
            this.bFilmSil.Click += new System.EventHandler(this.bFilmSil_Click);
            // 
            // butonSeansSil
            // 
            this.butonSeansSil.BackColor = System.Drawing.Color.Firebrick;
            this.butonSeansSil.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonSeansSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            //this.butonSeansSil.Image = global::SinemaGiseOtomasyonu.Properties.Resources.asd;
            this.butonSeansSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butonSeansSil.Location = new System.Drawing.Point(703, 0);
            this.butonSeansSil.Name = "butonSeansSil";
            this.butonSeansSil.Size = new System.Drawing.Size(108, 62);
            this.butonSeansSil.TabIndex = 10;
            this.butonSeansSil.Text = "Seans\r\nSil";
            this.butonSeansSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butonSeansSil.UseVisualStyleBackColor = false;
            this.butonSeansSil.Click += new System.EventHandler(this.butonSeansSil_Click);
            // 
            // butonSalonSil
            // 
            this.butonSalonSil.BackColor = System.Drawing.Color.Firebrick;
            this.butonSalonSil.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonSalonSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            //this.butonSalonSil.Image = global::SinemaGiseOtomasyonu.Properties.Resources.asd;
            this.butonSalonSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butonSalonSil.Location = new System.Drawing.Point(431, 1);
            this.butonSalonSil.Name = "butonSalonSil";
            this.butonSalonSil.Size = new System.Drawing.Size(107, 62);
            this.butonSalonSil.TabIndex = 9;
            this.butonSalonSil.Text = "Salon\r\nSil";
            this.butonSalonSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butonSalonSil.UseVisualStyleBackColor = false;
            this.butonSalonSil.Click += new System.EventHandler(this.butonSalonSil_Click);
            // 
            // butonFilmKaydet
            // 
            this.butonFilmKaydet.Image = ((System.Drawing.Image)(resources.GetObject("butonFilmKaydet.Image")));
            this.butonFilmKaydet.Location = new System.Drawing.Point(189, 150);
            this.butonFilmKaydet.Name = "butonFilmKaydet";
            this.butonFilmKaydet.Size = new System.Drawing.Size(50, 50);
            this.butonFilmKaydet.TabIndex = 6;
            this.butonFilmKaydet.UseVisualStyleBackColor = true;
            this.butonFilmKaydet.Click += new System.EventHandler(this.butonFilmKaydet_Click);
            // 
            // butonSeansKaydet
            // 
            this.butonSeansKaydet.Image = ((System.Drawing.Image)(resources.GetObject("butonSeansKaydet.Image")));
            this.butonSeansKaydet.Location = new System.Drawing.Point(172, 76);
            this.butonSeansKaydet.Name = "butonSeansKaydet";
            this.butonSeansKaydet.Size = new System.Drawing.Size(50, 50);
            this.butonSeansKaydet.TabIndex = 2;
            this.butonSeansKaydet.UseVisualStyleBackColor = true;
            this.butonSeansKaydet.Click += new System.EventHandler(this.butonSeansKaydet_Click);
            // 
            // butonFilmSil
            // 
            this.butonFilmSil.BackColor = System.Drawing.Color.Firebrick;
            this.butonFilmSil.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonFilmSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            //this.butonFilmSil.Image = global::SinemaGiseOtomasyonu.Properties.Resources.asd;
            this.butonFilmSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butonFilmSil.Location = new System.Drawing.Point(147, 1);
            this.butonFilmSil.Name = "butonFilmSil";
            this.butonFilmSil.Size = new System.Drawing.Size(117, 62);
            this.butonFilmSil.TabIndex = 8;
            this.butonFilmSil.Text = "Film\r\nSil";
            this.butonFilmSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butonFilmSil.UseVisualStyleBackColor = false;
            this.butonFilmSil.Click += new System.EventHandler(this.butonFilmSil_Click);
            // 
            // butonSeansGoster
            // 
            this.butonSeansGoster.BackColor = System.Drawing.Color.ForestGreen;
            this.butonSeansGoster.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonSeansGoster.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butonSeansGoster.Image = ((System.Drawing.Image)(resources.GetObject("butonSeansGoster.Image")));
            this.butonSeansGoster.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butonSeansGoster.Location = new System.Drawing.Point(622, 274);
            this.butonSeansGoster.Name = "butonSeansGoster";
            this.butonSeansGoster.Size = new System.Drawing.Size(120, 45);
            this.butonSeansGoster.TabIndex = 7;
            this.butonSeansGoster.Text = "Seansları\r\nGöster";
            this.butonSeansGoster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butonSeansGoster.UseVisualStyleBackColor = false;
            this.butonSeansGoster.Click += new System.EventHandler(this.butonSeansGoster_Click);
            // 
            // butonSalonGoster
            // 
            this.butonSalonGoster.BackColor = System.Drawing.Color.ForestGreen;
            this.butonSalonGoster.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonSalonGoster.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butonSalonGoster.Image = ((System.Drawing.Image)(resources.GetObject("butonSalonGoster.Image")));
            this.butonSalonGoster.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butonSalonGoster.Location = new System.Drawing.Point(351, 274);
            this.butonSalonGoster.Name = "butonSalonGoster";
            this.butonSalonGoster.Size = new System.Drawing.Size(120, 45);
            this.butonSalonGoster.TabIndex = 6;
            this.butonSalonGoster.Text = "Salonları\r\nGöster";
            this.butonSalonGoster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butonSalonGoster.UseVisualStyleBackColor = false;
            this.butonSalonGoster.Click += new System.EventHandler(this.butonSalonGoster_Click);
            // 
            // butonFilmGoster
            // 
            this.butonFilmGoster.BackColor = System.Drawing.Color.ForestGreen;
            this.butonFilmGoster.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonFilmGoster.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butonFilmGoster.Image = ((System.Drawing.Image)(resources.GetObject("butonFilmGoster.Image")));
            this.butonFilmGoster.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butonFilmGoster.Location = new System.Drawing.Point(66, 274);
            this.butonFilmGoster.Name = "butonFilmGoster";
            this.butonFilmGoster.Size = new System.Drawing.Size(120, 45);
            this.butonFilmGoster.TabIndex = 5;
            this.butonFilmGoster.Text = "Filmleri\r\nGöster";
            this.butonFilmGoster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butonFilmGoster.UseVisualStyleBackColor = false;
            this.butonFilmGoster.Click += new System.EventHandler(this.butonFilmGoster_Click);
            // 
            // butonSalonKaydet
            // 
            this.butonSalonKaydet.Image = ((System.Drawing.Image)(resources.GetObject("butonSalonKaydet.Image")));
            this.butonSalonKaydet.Location = new System.Drawing.Point(173, 76);
            this.butonSalonKaydet.Name = "butonSalonKaydet";
            this.butonSalonKaydet.Size = new System.Drawing.Size(50, 50);
            this.butonSalonKaydet.TabIndex = 3;
            this.butonSalonKaydet.UseVisualStyleBackColor = true;
            this.butonSalonKaydet.Click += new System.EventHandler(this.butonSalonKaydet_Click);
            // 
            // butonSalon
            // 
            this.butonSalon.BackColor = System.Drawing.Color.ForestGreen;
            this.butonSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonSalon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            //this.butonSalon.Image = global::SinemaGiseOtomasyonu.Properties.Resources.Netvibes_512x512;
            this.butonSalon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butonSalon.Location = new System.Drawing.Point(288, 1);
            this.butonSalon.Name = "butonSalon";
            this.butonSalon.Size = new System.Drawing.Size(121, 62);
            this.butonSalon.TabIndex = 2;
            this.butonSalon.Text = "Salon\r\nEkle";
            this.butonSalon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butonSalon.UseVisualStyleBackColor = false;
            this.butonSalon.Click += new System.EventHandler(this.butonSalon_Click);
            // 
            // butonSeans
            // 
            this.butonSeans.BackColor = System.Drawing.Color.ForestGreen;
            this.butonSeans.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonSeans.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            //this.butonSeans.Image = global::SinemaGiseOtomasyonu.Properties.Resources.Netvibes_512x512;
            this.butonSeans.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butonSeans.Location = new System.Drawing.Point(561, 1);
            this.butonSeans.Name = "butonSeans";
            this.butonSeans.Size = new System.Drawing.Size(119, 62);
            this.butonSeans.TabIndex = 1;
            this.butonSeans.Text = "Seans\r\nEkle";
            this.butonSeans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butonSeans.UseVisualStyleBackColor = false;
            this.butonSeans.Click += new System.EventHandler(this.butonSeans_Click);
            // 
            // butonFilm
            // 
            this.butonFilm.BackColor = System.Drawing.Color.ForestGreen;
            this.butonFilm.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonFilm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            //this.butonFilm.Image = global::SinemaGiseOtomasyonu.Properties.Resources.Netvibes_512x512;
            this.butonFilm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butonFilm.Location = new System.Drawing.Point(12, 0);
            this.butonFilm.Name = "butonFilm";
            this.butonFilm.Size = new System.Drawing.Size(114, 62);
            this.butonFilm.TabIndex = 0;
            this.butonFilm.Text = "Film\r\nEkle";
            this.butonFilm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butonFilm.UseVisualStyleBackColor = false;
            this.butonFilm.Click += new System.EventHandler(this.butonFilm_Click);
            // 
            // adminPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 561);
            this.Controls.Add(this.groupBoxSeans2);
            this.Controls.Add(this.groupBoxSalon2);
            this.Controls.Add(this.groupBoxFilm2);
            this.Controls.Add(this.butonSeansSil);
            this.Controls.Add(this.butonSalonSil);
            this.Controls.Add(this.groupBoxFilm);
            this.Controls.Add(this.groupBoxSeans);
            this.Controls.Add(this.butonFilmSil);
            this.Controls.Add(this.butonSeansGoster);
            this.Controls.Add(this.butonSalonGoster);
            this.Controls.Add(this.butonFilmGoster);
            this.Controls.Add(this.lwFilm);
            this.Controls.Add(this.groupBoxSalon);
            this.Controls.Add(this.butonSalon);
            this.Controls.Add(this.butonSeans);
            this.Controls.Add(this.butonFilm);
            this.Name = "adminPaneli";
            this.Text = "adminPaneli";
            this.Load += new System.EventHandler(this.adminPaneli_Load);
            this.groupBoxFilm.ResumeLayout(false);
            this.groupBoxFilm.PerformLayout();
            this.groupBoxFilm2.ResumeLayout(false);
            this.groupBoxFilm2.PerformLayout();
            this.groupBoxSalon.ResumeLayout(false);
            this.groupBoxSalon.PerformLayout();
            this.groupBoxSalon2.ResumeLayout(false);
            this.groupBoxSalon2.PerformLayout();
            this.groupBoxSeans.ResumeLayout(false);
            this.groupBoxSeans.PerformLayout();
            this.groupBoxSeans2.ResumeLayout(false);
            this.groupBoxSeans2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butonFilm;
        private System.Windows.Forms.Button butonSeans;
        private System.Windows.Forms.Button butonSalon;
        private System.Windows.Forms.GroupBox groupBoxFilm;
        private System.Windows.Forms.Label labelFilmAdi;
        private System.Windows.Forms.Label labelfilmTuru;
        private System.Windows.Forms.Label labelfilm3D;
        private System.Windows.Forms.Label labelFilmSuresi;
        private System.Windows.Forms.Label labelYerliYabanci;
        private System.Windows.Forms.TextBox tbFilmAdi;
        private System.Windows.Forms.TextBox tbFilmSuresi;
        private System.Windows.Forms.GroupBox groupBoxSalon;
        private System.Windows.Forms.Label labelSalon;
        private System.Windows.Forms.Label labelKapasite;
        private System.Windows.Forms.TextBox tbKapasite;
        private System.Windows.Forms.TextBox tbSalonAdi;
        private System.Windows.Forms.GroupBox groupBoxSeans;
        private System.Windows.Forms.Label labelSeansSaati;
        private System.Windows.Forms.TextBox tbSeansSaati;
        private System.Windows.Forms.ListView lwFilm;
        private System.Windows.Forms.ColumnHeader columnHeaderFilmAdi;
        private System.Windows.Forms.ColumnHeader columnHeaderFilmTuru;
        private System.Windows.Forms.ColumnHeader columnHeader3D;
        private System.Windows.Forms.ColumnHeader columnHeaderSure;
        private System.Windows.Forms.ColumnHeader columnHeaderYapimci;
        private System.Windows.Forms.Button butonFilmGoster;
        private System.Windows.Forms.Button butonSalonGoster;
        private System.Windows.Forms.Button butonSeansGoster;
        private System.Windows.Forms.ComboBox cbYapimci;
        private System.Windows.Forms.ComboBox cb3D;
        private System.Windows.Forms.ComboBox cbFilmTuru;
        private System.Windows.Forms.Label labelSaat;
        private System.Windows.Forms.Button butonFilmKaydet;
        private System.Windows.Forms.Button butonSalonKaydet;
        private System.Windows.Forms.Button butonSeansKaydet;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button butonFilmSil;
        private System.Windows.Forms.Button butonSalonSil;
        private System.Windows.Forms.Button butonSeansSil;
        private System.Windows.Forms.GroupBox groupBoxFilm2;
        private System.Windows.Forms.Button bFilmSil;
        private System.Windows.Forms.TextBox tbFilmSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxSalon2;
        private System.Windows.Forms.Button bSalonSil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSalonSil;
        private System.Windows.Forms.GroupBox groupBoxSeans2;
        private System.Windows.Forms.Button bSeansSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSeansSil;
    }
}