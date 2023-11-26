namespace hospital_management_system
{
    partial class Prescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prescription));
            this.panel6 = new System.Windows.Forms.Panel();
            this.hastane = new System.Windows.Forms.Label();
            this.doctoradi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hastaadi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.doktor = new System.Windows.Forms.ComboBox();
            this.hasta = new System.Windows.Forms.ComboBox();
            this.test = new System.Windows.Forms.ComboBox();
            this.testadi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ilac = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ekle = new System.Windows.Forms.Button();
            this.recete = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.receteDGV = new System.Windows.Forms.DataGridView();
            this.masraf = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.print = new System.Windows.Forms.Button();
            this.doctor = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lab = new System.Windows.Forms.Label();
            this.recep = new System.Windows.Forms.Label();
            this.patients = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receteDGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Controls.Add(this.hastane);
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Location = new System.Drawing.Point(263, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1150, 74);
            this.panel6.TabIndex = 46;
            // 
            // hastane
            // 
            this.hastane.AutoSize = true;
            this.hastane.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hastane.Location = new System.Drawing.Point(406, 24);
            this.hastane.Name = "hastane";
            this.hastane.Size = new System.Drawing.Size(388, 32);
            this.hastane.TabIndex = 2;
            this.hastane.Text = "  Hastane Yönetim Sistemi  ";
            // 
            // doctoradi
            // 
            this.doctoradi.Enabled = false;
            this.doctoradi.Location = new System.Drawing.Point(458, 120);
            this.doctoradi.Multiline = true;
            this.doctoradi.Name = "doctoradi";
            this.doctoradi.Size = new System.Drawing.Size(218, 35);
            this.doctoradi.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(453, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Doktor Adı";
            // 
            // hastaadi
            // 
            this.hastaadi.Enabled = false;
            this.hastaadi.Location = new System.Drawing.Point(458, 189);
            this.hastaadi.Multiline = true;
            this.hastaadi.Name = "hastaadi";
            this.hastaadi.Size = new System.Drawing.Size(218, 35);
            this.hastaadi.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(453, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 49;
            this.label7.Text = "Hasta Adı";
            // 
            // doktor
            // 
            this.doktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doktor.FormattingEnabled = true;
            this.doktor.Location = new System.Drawing.Point(271, 120);
            this.doktor.Name = "doktor";
            this.doktor.Size = new System.Drawing.Size(176, 34);
            this.doktor.TabIndex = 51;
            this.doktor.Text = "Doktor ID";
            this.doktor.SelectionChangeCommitted += new System.EventHandler(this.doktor_SelectionChangeCommitted);
            // 
            // hasta
            // 
            this.hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasta.FormattingEnabled = true;
            this.hasta.Location = new System.Drawing.Point(271, 189);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(176, 34);
            this.hasta.TabIndex = 52;
            this.hasta.Text = "Hasta ID";
            this.hasta.SelectionChangeCommitted += new System.EventHandler(this.hasta_SelectionChangeCommitted);
            // 
            // test
            // 
            this.test.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test.FormattingEnabled = true;
            this.test.Location = new System.Drawing.Point(271, 260);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(176, 34);
            this.test.TabIndex = 55;
            this.test.Text = "Test ID";
            this.test.SelectionChangeCommitted += new System.EventHandler(this.test_SelectionChangeCommitted);
            // 
            // testadi
            // 
            this.testadi.Enabled = false;
            this.testadi.Location = new System.Drawing.Point(458, 260);
            this.testadi.Multiline = true;
            this.testadi.Name = "testadi";
            this.testadi.Size = new System.Drawing.Size(218, 35);
            this.testadi.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(453, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 53;
            this.label8.Text = "Test Adı";
            // 
            // ilac
            // 
            this.ilac.Location = new System.Drawing.Point(271, 340);
            this.ilac.Multiline = true;
            this.ilac.Name = "ilac";
            this.ilac.Size = new System.Drawing.Size(220, 80);
            this.ilac.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(271, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 25);
            this.label9.TabIndex = 57;
            this.label9.Text = "İlaçlar";
            // 
            // ekle
            // 
            this.ekle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekle.Location = new System.Drawing.Point(515, 413);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(130, 37);
            this.ekle.TabIndex = 58;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // recete
            // 
            this.recete.Location = new System.Drawing.Point(729, 107);
            this.recete.Multiline = true;
            this.recete.Name = "recete";
            this.recete.Size = new System.Drawing.Size(640, 300);
            this.recete.TabIndex = 60;
            this.recete.TextChanged += new System.EventHandler(this.recete_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1018, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 25);
            this.label10.TabIndex = 61;
            this.label10.Text = "Reçete";
            // 
            // receteDGV
            // 
            this.receteDGV.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.receteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receteDGV.Location = new System.Drawing.Point(271, 456);
            this.receteDGV.Name = "receteDGV";
            this.receteDGV.RowHeadersWidth = 51;
            this.receteDGV.RowTemplate.Height = 24;
            this.receteDGV.Size = new System.Drawing.Size(1128, 241);
            this.receteDGV.TabIndex = 62;
            this.receteDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.receteDGV_CellDoubleClick);
            // 
            // masraf
            // 
            this.masraf.AutoSize = true;
            this.masraf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masraf.Location = new System.Drawing.Point(497, 312);
            this.masraf.Name = "masraf";
            this.masraf.Size = new System.Drawing.Size(72, 25);
            this.masraf.TabIndex = 64;
            this.masraf.Text = "Masraf";
            // 
            // cost
            // 
            this.cost.Enabled = false;
            this.cost.Location = new System.Drawing.Point(497, 340);
            this.cost.Multiline = true;
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(161, 37);
            this.cost.TabIndex = 63;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.Location = new System.Drawing.Point(1011, 413);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(130, 37);
            this.print.TabIndex = 65;
            this.print.Text = "Yazdır";
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // doctor
            // 
            this.doctor.AutoSize = true;
            this.doctor.BackColor = System.Drawing.Color.Black;
            this.doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.doctor.Location = new System.Drawing.Point(118, 186);
            this.doctor.Name = "doctor";
            this.doctor.Size = new System.Drawing.Size(79, 25);
            this.doctor.TabIndex = 6;
            this.doctor.Text = "Doctors";
            this.doctor.Click += new System.EventHandler(this.doctor_Click);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.BackColor = System.Drawing.Color.Black;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logout.Location = new System.Drawing.Point(118, 647);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(82, 25);
            this.logout.TabIndex = 10;
            this.logout.Text = "Log Out";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lab);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.recep);
            this.panel1.Controls.Add(this.patients);
            this.panel1.Controls.Add(this.doctor);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 711);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(21, 635);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(62, 53);
            this.pictureBox5.TabIndex = 76;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(21, 64);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(81, 80);
            this.pictureBox4.TabIndex = 75;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(21, 162);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 80);
            this.pictureBox3.TabIndex = 74;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 262);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 79);
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 358);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 80);
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.BackColor = System.Drawing.Color.Black;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab.Location = new System.Drawing.Point(118, 383);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(105, 25);
            this.lab.TabIndex = 71;
            this.lab.Text = "Laboratory";
            this.lab.Click += new System.EventHandler(this.lab_Click);
            // 
            // recep
            // 
            this.recep.AutoSize = true;
            this.recep.BackColor = System.Drawing.Color.Black;
            this.recep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recep.Location = new System.Drawing.Point(118, 289);
            this.recep.Name = "recep";
            this.recep.Size = new System.Drawing.Size(128, 25);
            this.recep.TabIndex = 70;
            this.recep.Text = "Receptionists";
            this.recep.Click += new System.EventHandler(this.recep_Click);
            // 
            // patients
            // 
            this.patients.AutoSize = true;
            this.patients.BackColor = System.Drawing.Color.Black;
            this.patients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patients.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patients.Location = new System.Drawing.Point(118, 93);
            this.patients.Name = "patients";
            this.patients.Size = new System.Drawing.Size(82, 25);
            this.patients.TabIndex = 69;
            this.patients.Text = "Patients";
            this.patients.Click += new System.EventHandler(this.patients_Click);
            // 
            // Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 709);
            this.Controls.Add(this.print);
            this.Controls.Add(this.masraf);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.receteDGV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.recete);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ilac);
            this.Controls.Add(this.test);
            this.Controls.Add(this.testadi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.hasta);
            this.Controls.Add(this.doktor);
            this.Controls.Add(this.hastaadi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.doctoradi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Prescription";
            this.Text = "Prescription";
            this.Load += new System.EventHandler(this.Prescription_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receteDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox doctoradi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hastaadi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox doktor;
        private System.Windows.Forms.ComboBox hasta;
        private System.Windows.Forms.ComboBox test;
        private System.Windows.Forms.TextBox testadi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ilac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.TextBox recete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView receteDGV;
        private System.Windows.Forms.Label hastane;
        private System.Windows.Forms.Label masraf;
        private System.Windows.Forms.TextBox cost;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Label doctor;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label recep;
        private System.Windows.Forms.Label patients;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}