namespace hospital_management_system
{
    partial class Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.doc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.recep = new System.Windows.Forms.Label();
            this.hasta = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.hastane = new System.Windows.Forms.Label();
            this.sil = new System.Windows.Forms.Button();
            this.duzenle = new System.Windows.Forms.Button();
            this.Ekle = new System.Windows.Forms.Button();
            this.dogum = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.kimlik = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uzman = new System.Windows.Forms.ComboBox();
            this.cinsiyet = new System.Windows.Forms.ComboBox();
            this.doktoradi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tecrube = new System.Windows.Forms.Label();
            this.exp = new System.Windows.Forms.TextBox();
            this.doktorTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDBDataSet = new hospital_management_system.hastaneDBDataSet();
            this.doktorTblTableAdapter = new hospital_management_system.hastaneDBDataSetTableAdapters.DoktorTblTableAdapter();
            this.DGVdoctor = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doktorTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdoctor)).BeginInit();
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
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.doc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lab);
            this.panel1.Controls.Add(this.recep);
            this.panel1.Controls.Add(this.hasta);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 713);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // doc
            // 
            this.doc.AutoSize = true;
            this.doc.BackColor = System.Drawing.Color.Black;
            this.doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.doc.Location = new System.Drawing.Point(117, 196);
            this.doc.Name = "doc";
            this.doc.Size = new System.Drawing.Size(69, 25);
            this.doc.TabIndex = 11;
            this.doc.Text = "Doctor";
            this.doc.Click += new System.EventHandler(this.doc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(117, 644);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Log Out";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.BackColor = System.Drawing.Color.Black;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab.Location = new System.Drawing.Point(117, 387);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(105, 25);
            this.lab.TabIndex = 8;
            this.lab.Text = "Laboratory";
            this.lab.Click += new System.EventHandler(this.lab_Click);
            // 
            // recep
            // 
            this.recep.AutoSize = true;
            this.recep.BackColor = System.Drawing.Color.Black;
            this.recep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recep.Location = new System.Drawing.Point(117, 293);
            this.recep.Name = "recep";
            this.recep.Size = new System.Drawing.Size(128, 25);
            this.recep.TabIndex = 5;
            this.recep.Text = "Receptionists";
            this.recep.Click += new System.EventHandler(this.recep_Click);
            // 
            // hasta
            // 
            this.hasta.AutoSize = true;
            this.hasta.BackColor = System.Drawing.Color.Black;
            this.hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hasta.Location = new System.Drawing.Point(117, 95);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(82, 25);
            this.hasta.TabIndex = 4;
            this.hasta.Text = "Patients";
            this.hasta.Click += new System.EventHandler(this.hasta_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Controls.Add(this.hastane);
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Location = new System.Drawing.Point(264, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1148, 74);
            this.panel6.TabIndex = 4;
            // 
            // hastane
            // 
            this.hastane.AutoSize = true;
            this.hastane.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hastane.Location = new System.Drawing.Point(380, 21);
            this.hastane.Name = "hastane";
            this.hastane.Size = new System.Drawing.Size(388, 32);
            this.hastane.TabIndex = 1;
            this.hastane.Text = "  Hastane Yönetim Sistemi  ";
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sil.Location = new System.Drawing.Point(958, 237);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(130, 37);
            this.sil.TabIndex = 36;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // duzenle
            // 
            this.duzenle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.duzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duzenle.Location = new System.Drawing.Point(772, 237);
            this.duzenle.Name = "duzenle";
            this.duzenle.Size = new System.Drawing.Size(130, 37);
            this.duzenle.TabIndex = 35;
            this.duzenle.Text = "Düzenle";
            this.duzenle.UseVisualStyleBackColor = false;
            this.duzenle.Click += new System.EventHandler(this.duzenle_Click);
            // 
            // Ekle
            // 
            this.Ekle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ekle.Location = new System.Drawing.Point(572, 237);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(130, 37);
            this.Ekle.TabIndex = 34;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = false;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // dogum
            // 
            this.dogum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogum.Location = new System.Drawing.Point(958, 188);
            this.dogum.Name = "dogum";
            this.dogum.Size = new System.Drawing.Size(408, 34);
            this.dogum.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(953, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 25);
            this.label9.TabIndex = 30;
            this.label9.Text = "Doğum Tarihi";
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(516, 187);
            this.telefon.Multiline = true;
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(186, 35);
            this.telefon.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(511, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "Telefon";
            // 
            // kimlik
            // 
            this.kimlik.Location = new System.Drawing.Point(281, 187);
            this.kimlik.Multiline = true;
            this.kimlik.Name = "kimlik";
            this.kimlik.Size = new System.Drawing.Size(218, 35);
            this.kimlik.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(276, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Kimlik No";
            // 
            // uzman
            // 
            this.uzman.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uzman.FormattingEnabled = true;
            this.uzman.Items.AddRange(new object[] {
            "İç Hastalıkları",
            "Alerji Hastalıkları",
            "Endokrinoloji ve Metabolizma Hastalıkları",
            "Gastroenteroloji",
            "Nefroloji",
            "Romatoloji",
            "İş ve Meslek Hastalıkları",
            "İmmünoloji",
            "Hematoloji",
            "Geriatri",
            "Tıbbi Onkoloji",
            "Yoğun Bakım",
            "Kardiyoloji",
            "Göğüs Hastalıkları",
            "Alerjik Göğüs Hastalıkları",
            "Enfeksiyon Hastalıkları",
            "Nöroloji",
            "Psikiyatri",
            "Çocuk Sağlığı ve Hastalıkları",
            "Çocuk Kardiyolojisi",
            "Çocuk Metabolizma Hastalıkları",
            "Çocuk Endokrinolojisi",
            "Çocuk Hematolojisi",
            "Çocuk Nefrolojisi",
            "Çocuk Nörolojisi",
            "Çocuk Alerjisi",
            "Çocuk Onkolojisi",
            "Çocuk Gastroenteroloji, Hepatoloji ve Beslenme",
            "Çocuk Enfeksiyon Hastalıkları",
            "Neonatoloji",
            "Genetik",
            "Çocuk Göğüs Hastalıkları",
            "Çocuk İmmünolojisi",
            "Yoğun Bakım",
            "Çocuk Psikiyatrisi",
            "Dermatoloji",
            "Fiziksel Tıp ve Rehabilitasyon",
            "Romatoloji",
            "Genel Cerrahi",
            "Gastroentroloji Cerrahisi",
            "Çocuk Cerrahisi",
            "Çocuk Ürolojisi",
            "Göğüs Cerrahisi",
            "Kalp ve Damar Cerrahisi",
            "Çocuk Kalp ve Damar Cerrahisi",
            "Beyin ve Sinir Cerrahisi",
            "Plastik, Rekonstrüktif ve Estetik Cerrahi",
            "El Cerrahisi",
            "Ortopedi ve Travmatoloji",
            "El Cerrahisi",
            "Üroloji",
            "Çocuk Ürolojisi",
            "Androloji",
            "Kulak-Burun-Boğaz Hastalıkları",
            "Göz Hastalıkları",
            "Kadın Hastalıkları ve Doğum",
            "Üreme Endokrinolojisi ve İnfertilite",
            "Perinatoloji",
            "Anesteziyoloji ve Reanimasyon",
            "Algoloji",
            "Radyasyon Onkolojisi",
            "Radyoloji",
            "Nöroradyoloji",
            "Girişimsel Radyoloji",
            "Pediyatrik Radyoloji",
            "Nükleer Tıp",
            "Tıbbi Patoloji",
            "Sitopatoloji",
            "Dermatopatoloji",
            "Nöropatoloji",
            "Tıbbi Genetik",
            "Klinik Sitogenetik",
            "Klinik Moleküler Genetik",
            "Klinik Genetik",
            "Tıbbi Biyokimya",
            "Tıbbi Mikrobiyoloji",
            "Tıbbi Parazitoloji",
            "Viroloji",
            "İmmünoloji",
            "Mikoloji",
            "Tıbbi Farmakoloji",
            "Toksikoloji",
            "Spor Hekimliği",
            "Askeri Sahra Hekimliği",
            "Hava ve Uzay Hekimliği",
            "Sualtı Hekimliği ve Hiperbarik Tıp",
            "Acil Tıp",
            "Adli Tıp",
            "Toksikoloji",
            "Halk Sağlığı",
            "Epidemiyoloji",
            "Çevre Sağlığı",
            "İşyeri Hekimliği",
            "Okul Hekimliği",
            "Fizyoloji",
            "Aile Hekimliği",
            "Anatomi",
            "Embriyoloji ve Histoloji"});
            this.uzman.Location = new System.Drawing.Point(708, 110);
            this.uzman.Name = "uzman";
            this.uzman.Size = new System.Drawing.Size(194, 34);
            this.uzman.TabIndex = 24;
            this.uzman.Text = "Uzmanlık Alanı";
            // 
            // cinsiyet
            // 
            this.cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinsiyet.FormattingEnabled = true;
            this.cinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.cinsiyet.Location = new System.Drawing.Point(516, 110);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.Size = new System.Drawing.Size(186, 34);
            this.cinsiyet.TabIndex = 23;
            this.cinsiyet.Text = "Cinsiyet";
            // 
            // doktoradi
            // 
            this.doktoradi.Location = new System.Drawing.Point(281, 110);
            this.doktoradi.Multiline = true;
            this.doktoradi.Name = "doktoradi";
            this.doktoradi.Size = new System.Drawing.Size(218, 35);
            this.doktoradi.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(276, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Doktor Adı";
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(708, 187);
            this.sifre.Multiline = true;
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(206, 35);
            this.sifre.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(703, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 25);
            this.label11.TabIndex = 38;
            this.label11.Text = "Şifre";
            // 
            // tecrube
            // 
            this.tecrube.AutoSize = true;
            this.tecrube.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tecrube.Location = new System.Drawing.Point(953, 81);
            this.tecrube.Name = "tecrube";
            this.tecrube.Size = new System.Drawing.Size(85, 25);
            this.tecrube.TabIndex = 41;
            this.tecrube.Text = "Tecrübe";
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(958, 109);
            this.exp.Multiline = true;
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(206, 35);
            this.exp.TabIndex = 40;
            // 
            // doktorTblBindingSource
            // 
            this.doktorTblBindingSource.DataMember = "DoktorTbl";
            this.doktorTblBindingSource.DataSource = this.hastaneDBDataSet;
            // 
            // hastaneDBDataSet
            // 
            this.hastaneDBDataSet.DataSetName = "hastaneDBDataSet";
            this.hastaneDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doktorTblTableAdapter
            // 
            this.doktorTblTableAdapter.ClearBeforeFill = true;
            // 
            // DGVdoctor
            // 
            this.DGVdoctor.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.DGVdoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdoctor.Location = new System.Drawing.Point(281, 293);
            this.DGVdoctor.Name = "DGVdoctor";
            this.DGVdoctor.RowHeadersWidth = 51;
            this.DGVdoctor.RowTemplate.Height = 24;
            this.DGVdoctor.Size = new System.Drawing.Size(1118, 404);
            this.DGVdoctor.TabIndex = 42;
            this.DGVdoctor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVdoctor_CellDoubleClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(21, 65);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(81, 80);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(17, 163);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(83, 80);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 263);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 79);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 359);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 80);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(21, 630);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(62, 53);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 709);
            this.Controls.Add(this.DGVdoctor);
            this.Controls.Add(this.tecrube);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.duzenle);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.dogum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.kimlik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uzman);
            this.Controls.Add(this.cinsiyet);
            this.Controls.Add(this.doktoradi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doktorTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdoctor)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label recep;
        private System.Windows.Forms.Label hasta;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button duzenle;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.DateTimePicker dogum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox kimlik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox uzman;
        private System.Windows.Forms.ComboBox cinsiyet;
        private System.Windows.Forms.TextBox doktoradi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label tecrube;
        private System.Windows.Forms.TextBox exp;
        private hastaneDBDataSet hastaneDBDataSet;
        private System.Windows.Forms.BindingSource doktorTblBindingSource;
        private hastaneDBDataSetTableAdapters.DoktorTblTableAdapter doktorTblTableAdapter;
        private System.Windows.Forms.Label hastane;
        private System.Windows.Forms.DataGridView DGVdoctor;
        private System.Windows.Forms.Label doc;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}