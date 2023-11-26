namespace hospital_management_system
{
    partial class Receptionist
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receptionist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.patient = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.doctor = new System.Windows.Forms.Label();
            this.recep = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.hastane = new System.Windows.Forms.Label();
            this.kimlik = new System.Windows.Forms.TextBox();
            this.sehir = new System.Windows.Forms.ComboBox();
            this.cinsiyet = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sil = new System.Windows.Forms.Button();
            this.duzenle = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.resepsiyonistTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDBDataSet = new hospital_management_system.hastaneDBDataSet();
            this.hastaneDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.resepsiyonistTblTableAdapter = new hospital_management_system.hastaneDBDataSetTableAdapters.ResepsiyonistTblTableAdapter();
            this.receptionistDGV = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resepsiyonistTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionistDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.patient);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lab);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.doctor);
            this.panel1.Controls.Add(this.recep);
            this.panel1.Controls.Add(this.logout);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 638);
            this.panel1.TabIndex = 3;
            // 
            // patient
            // 
            this.patient.AutoSize = true;
            this.patient.BackColor = System.Drawing.Color.Black;
            this.patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patient.Location = new System.Drawing.Point(117, 105);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(82, 25);
            this.patient.TabIndex = 11;
            this.patient.Text = "Patients";
            this.patient.Click += new System.EventHandler(this.patient_Click);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.BackColor = System.Drawing.Color.Black;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logout.Location = new System.Drawing.Point(117, 575);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(82, 25);
            this.logout.TabIndex = 10;
            this.logout.Text = "Log Out";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.BackColor = System.Drawing.Color.Black;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab.Location = new System.Drawing.Point(117, 396);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(105, 25);
            this.lab.TabIndex = 8;
            this.lab.Text = "Laboratory";
            this.lab.Click += new System.EventHandler(this.lab_Click);
            // 
            // doctor
            // 
            this.doctor.AutoSize = true;
            this.doctor.BackColor = System.Drawing.Color.Black;
            this.doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.doctor.Location = new System.Drawing.Point(117, 197);
            this.doctor.Name = "doctor";
            this.doctor.Size = new System.Drawing.Size(79, 25);
            this.doctor.TabIndex = 6;
            this.doctor.Text = "Doctors";
            this.doctor.Click += new System.EventHandler(this.doctor_Click);
            // 
            // recep
            // 
            this.recep.AutoSize = true;
            this.recep.BackColor = System.Drawing.Color.Black;
            this.recep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recep.Location = new System.Drawing.Point(117, 302);
            this.recep.Name = "recep";
            this.recep.Size = new System.Drawing.Size(128, 25);
            this.recep.TabIndex = 5;
            this.recep.Text = "Receptionists";
            this.recep.Click += new System.EventHandler(this.recep_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(703, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 25);
            this.label11.TabIndex = 44;
            this.label11.Text = "Şifre";
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(708, 185);
            this.sifre.Multiline = true;
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(206, 35);
            this.sifre.TabIndex = 43;
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(516, 185);
            this.telefon.Multiline = true;
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(186, 35);
            this.telefon.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(511, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 41;
            this.label8.Text = "Telefon";
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(280, 120);
            this.ad.Multiline = true;
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(218, 35);
            this.ad.TabIndex = 40;
            this.ad.TextChanged += new System.EventHandler(this.ad_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(275, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "Resepsiyonist Ad";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Controls.Add(this.hastane);
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Location = new System.Drawing.Point(264, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1083, 74);
            this.panel6.TabIndex = 45;
            // 
            // hastane
            // 
            this.hastane.AutoSize = true;
            this.hastane.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hastane.Location = new System.Drawing.Point(363, 21);
            this.hastane.Name = "hastane";
            this.hastane.Size = new System.Drawing.Size(388, 32);
            this.hastane.TabIndex = 0;
            this.hastane.Text = "  Hastane Yönetim Sistemi  ";
            // 
            // kimlik
            // 
            this.kimlik.Location = new System.Drawing.Point(280, 186);
            this.kimlik.Multiline = true;
            this.kimlik.Name = "kimlik";
            this.kimlik.Size = new System.Drawing.Size(218, 35);
            this.kimlik.TabIndex = 49;
            // 
            // sehir
            // 
            this.sehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sehir.FormattingEnabled = true;
            this.sehir.Items.AddRange(new object[] {
            "Istanbul",
            "Ankara",
            "İzmir",
            "Bursa",
            "Antalya",
            "Konya",
            "Gaziantep",
            "Şanlıurfa",
            "Mersin",
            "Adana",
            "Diyarbakır",
            "Kayseri",
            "Samsun",
            "Akçaabat",
            "Denizli",
            "Çankaya",
            "Esenyurt",
            "Eskişehir",
            "Seyhan",
            "Küçükçekmece",
            "Erzurum",
            "Bağcılar",
            "Pendik",
            "Selçuklu",
            "Yıldırım",
            "Kartal",
            "Batman",
            "Esenler",
            "Kahramanmaraş",
            "Kâğıthane",
            "Avcılar",
            "Trabzon",
            "Malatya",
            "Elazığ",
            "Yüreğir",
            "Hatay",
            "Sivas",
            "Gebze",
            "Kocaeli",
            "Kayapınar",
            "Manisa",
            "Konak",
            "Van",
            "Pamukkale",
            "Sarıyer",
            "Meram",
            "Tarsus",
            "Balıkesir",
            "Beylikdüzü",
            "Sultanbeyli",
            "Aksaray",
            "Alanya",
            "Yeşilyurt",
            "Adıyaman",
            "Afyonkarahisar",
            "İskenderun",
            "Battalgazi",
            "Çorum",
            "Güngören",
            "Çorlu",
            "Sakarya",
            "Arnavutköy",
            "İnegöl",
            "Kütahya",
            "Osmaniye",
            "Isparta",
            "Siverek",
            "Tuzla",
            "Kızıltepe",
            "Uşak",
            "Çekme",
            "Büyükçekmece",
            "Beykoz",
            "Düzce",
            "Manavgat",
            "Ordu",
            "Bolu",
            "Tekirdağ",
            "Tokat",
            "Viranşehir",
            "Karaköprü",
            "Karaman",
            "Muş",
            "Kırıkkale",
            "Aydın",
            "Çanakkale",
            "Edirne",
            "Torbalı",
            "Ereğli",
            "Bodrum",
            "Menemen",
            "Akhisar",
            "Çerkezköy",
            "Siirt",
            "Körfez",
            "Talas",
            "Turgutlu",
            "Gölcük",
            "Salihli",
            "Ceyhan",
            "Bingöl",
            "Fethiye",
            "Erzincan",
            "Nazilli",
            "Bartın",
            "Edremit",
            "Bandırma",
            "Kırşehir",
            "Nevşehir",
            "Ağrı",
            "Amasya",
            "Kastamonu",
            "Lüleburgaz",
            "Ereğli",
            "Yalova",
            "Cizre",
            "Elbistan",
            "Nizip",
            "Rize",
            "Çarşamba",
            "Silivri",
            "Iğdır",
            "Giresun",
            "Silopi",
            "Ödemiş",
            "Karabük",
            "Kozan",
            "Ergani",
            "Çayırova",
            "Ünye",
            "Polatlı",
            "Serik",
            "Kadirli",
            "Patnos",
            "Kâhta",
            "Doğubayazıt",
            "Samandağ",
            "Zonguldak",
            "Söke",
            "Yüksekova",
            "Silifke",
            "Niğde",
            "Karatepe",
            "Kapaklı",
            "Fatsa",
            "Kilis",
            "Kars",
            "Kuşadası",
            "Midyat",
            "Akçakale",
            "Burdur",
            "Soma",
            "Kemalpaşa",
            "Nusaybin",
            "Yozgat",
            "Alaşehir",
            "Suruç",
            "Bergama",
            "Tavşanlı",
            "Çankırı",
            "Şırnak",
            "Mardin",
            "Bilecik",
            "Hakkari",
            "Bitlis",
            "Bayburt",
            "Kırklareli",
            "Gümüşhane",
            "Muğla",
            "Ardahan",
            "Tunceli",
            "Artvin",
            "Yumurtalık",
            "Sinop",
            "Yenice",
            "Adalar",
            "Çağlayan",
            "Mahmutbey",
            "Etimesgut",
            "Samandıra",
            "Keçiören",
            "Pursaklar",
            "Melikgazi",
            "Altındağ",
            "Buca",
            "Gaziemir",
            "Karşıyaka",
            "Kemerburgaz",
            "Mamak",
            "Bornova",
            "Burç",
            "Sincan",
            "Kazanlı",
            "Yenimahalle",
            "Hadımköy",
            "Mahmut Şevket Paşa",
            "Değirmendere",
            "Yolboyu",
            "Bağlar",
            "Yenişehir",
            "Erenler",
            "Kazımpaşa",
            "Serdivan",
            "Darıca"});
            this.sehir.Location = new System.Drawing.Point(736, 119);
            this.sehir.Name = "sehir";
            this.sehir.Size = new System.Drawing.Size(176, 34);
            this.sehir.TabIndex = 48;
            this.sehir.Text = "Şehir";
            // 
            // cinsiyet
            // 
            this.cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinsiyet.FormattingEnabled = true;
            this.cinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.cinsiyet.Location = new System.Drawing.Point(516, 120);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.Size = new System.Drawing.Size(188, 34);
            this.cinsiyet.TabIndex = 47;
            this.cinsiyet.Text = "Cinsiyet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(275, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 50;
            this.label7.Text = "Kimlik No";
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sil.Location = new System.Drawing.Point(1064, 183);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(130, 37);
            this.sil.TabIndex = 53;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // duzenle
            // 
            this.duzenle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.duzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duzenle.Location = new System.Drawing.Point(1064, 136);
            this.duzenle.Name = "duzenle";
            this.duzenle.Size = new System.Drawing.Size(130, 37);
            this.duzenle.TabIndex = 52;
            this.duzenle.Text = "Düzenle";
            this.duzenle.UseVisualStyleBackColor = false;
            this.duzenle.Click += new System.EventHandler(this.duzenle_Click);
            // 
            // ekle
            // 
            this.ekle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekle.Location = new System.Drawing.Point(1064, 92);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(130, 37);
            this.ekle.TabIndex = 51;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // resepsiyonistTblBindingSource
            // 
            this.resepsiyonistTblBindingSource.DataMember = "ResepsiyonistTbl";
            this.resepsiyonistTblBindingSource.DataSource = this.hastaneDBDataSetBindingSource;
            // 
            // hastaneDBDataSetBindingSource
            // 
            this.hastaneDBDataSetBindingSource.DataSource = this.hastaneDBDataSet;
            this.hastaneDBDataSetBindingSource.Position = 0;
            // 
            // hastaneDBDataSet
            // 
            this.hastaneDBDataSet.DataSetName = "hastaneDBDataSet";
            this.hastaneDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaneDBDataSetBindingSource1
            // 
            this.hastaneDBDataSetBindingSource1.DataSource = this.hastaneDBDataSet;
            this.hastaneDBDataSetBindingSource1.Position = 0;
            // 
            // resepsiyonistTblTableAdapter
            // 
            this.resepsiyonistTblTableAdapter.ClearBeforeFill = true;
            // 
            // receptionistDGV
            // 
            this.receptionistDGV.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.receptionistDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receptionistDGV.GridColor = System.Drawing.SystemColors.Menu;
            this.receptionistDGV.Location = new System.Drawing.Point(271, 258);
            this.receptionistDGV.Name = "receptionistDGV";
            this.receptionistDGV.RowHeadersWidth = 51;
            this.receptionistDGV.RowTemplate.Height = 24;
            this.receptionistDGV.Size = new System.Drawing.Size(1062, 367);
            this.receptionistDGV.TabIndex = 54;
            this.receptionistDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.receptionistDGV_CellContentClick_1);
            this.receptionistDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.receptionistDGV_CellDoubleClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(21, 76);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(81, 80);
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(17, 174);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(83, 80);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 274);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 79);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 370);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 80);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(21, 564);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(62, 53);
            this.pictureBox5.TabIndex = 77;
            this.pictureBox5.TabStop = false;
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 637);
            this.Controls.Add(this.receptionistDGV);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.duzenle);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kimlik);
            this.Controls.Add(this.sehir);
            this.Controls.Add(this.cinsiyet);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Receptionist";
            this.Text = "Receptionist";
            this.Load += new System.EventHandler(this.Receptionist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resepsiyonistTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionistDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label doctor;
        private System.Windows.Forms.Label recep;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox kimlik;
        private System.Windows.Forms.ComboBox sehir;
        private System.Windows.Forms.ComboBox cinsiyet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button duzenle;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.BindingSource hastaneDBDataSetBindingSource;
        private hastaneDBDataSet hastaneDBDataSet;
        private System.Windows.Forms.BindingSource hastaneDBDataSetBindingSource1;
        private System.Windows.Forms.BindingSource resepsiyonistTblBindingSource;
        private hastaneDBDataSetTableAdapters.ResepsiyonistTblTableAdapter resepsiyonistTblTableAdapter;
        private System.Windows.Forms.DataGridView receptionistDGV;
        private System.Windows.Forms.Label hastane;
        private System.Windows.Forms.Label patient;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}