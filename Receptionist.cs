using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hospital_management_system
{


    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
            display();
        }
        
        SqlConnection conn = new SqlConnection(@"Data Source=AHMED\SQLEXPRESS;Initial Catalog=hastaneDB;Integrated Security=True");

        private void ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void display()
        {
            conn.Open();
            string query = "select * from ResepsiyonistTbl";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var show = new DataSet();
            sqlDataAdapter.Fill(show);
            receptionistDGV.DataSource = show.Tables[0];
            conn.Close();
        }
        private void ekle_Click(object sender, EventArgs e)
        {
            if(ad.Text == "" || cinsiyet.Text == "" || sehir.Text == "" || kimlik.Text == "" || telefon.Text == "" || sifre.Text == "")
            {
            
                MessageBox.Show("Boş bırakılamaz");
            
            }else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into ResepsiyonistTbl([Resepsiyonist Adi], [Kimlik No], [Cinsiyet], [Şehir], [Telefon], [Şifre]) values (@r1, @r2, @r3, @r4, @r5, @r6)", conn);
                    cmd.Parameters.AddWithValue("@r1", ad.Text);
                    cmd.Parameters.AddWithValue("@r2", kimlik.Text);
                    cmd.Parameters.AddWithValue("@r3", cinsiyet.Text);
                    cmd.Parameters.AddWithValue("@r4", sehir.Text);
                    cmd.Parameters.AddWithValue("@r5", telefon.Text);
                    cmd.Parameters.AddWithValue("@r6", sifre.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Resepsiyonist eklendi");
                    conn.Close();
                    display();
                    clear();
                }
                catch(Exception ex) 
                {
                MessageBox.Show(ex.Message);
                }
            }
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneDBDataSet.ResepsiyonistTbl' table. You can move, or remove it, as needed.
            this.resepsiyonistTblTableAdapter.Fill(this.hastaneDBDataSet.ResepsiyonistTbl);

        }

        int key = 0;




        private void duzenle_Click(object sender, EventArgs e)
        {
            if (ad.Text == "" || cinsiyet.Text == "" || sehir.Text == "" || kimlik.Text == "" || telefon.Text == "" || sifre.Text == "")
            {

                MessageBox.Show("Boş bırakılamaz");

            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Update ResepsiyonistTbl set [Resepsiyonist Adi] = @r1, [Kimlik No]= @r2, [Cinsiyet]=@r3, [Şehir]=@r4, [Telefon]=@r5, [Şifre]=@r6 where [Resepsiyonist ID]=@r0", conn);
                    cmd.Parameters.AddWithValue("@r1", ad.Text);
                    cmd.Parameters.AddWithValue("@r2", kimlik.Text);
                    cmd.Parameters.AddWithValue("@r3", cinsiyet.Text);
                    cmd.Parameters.AddWithValue("@r4", sehir.Text);
                    cmd.Parameters.AddWithValue("@r5", telefon.Text);
                    cmd.Parameters.AddWithValue("@r6", sifre.Text);
                    cmd.Parameters.AddWithValue("@r0", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Resepsiyonist Düzenlendi");
                    conn.Close();
                    display();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {

                MessageBox.Show("İlkini Seç");

            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Delete from ResepsiyonistTbl where [Resepsiyonist ID]=@r0", conn);
                    cmd.Parameters.AddWithValue("@r0", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Resepsiyonist Silindi");
                    conn.Close();
                    display();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void clear()
        {
            ad.Text = "";
            kimlik.Text = "";
            cinsiyet.Text = "";
            sehir.Text = "";
            telefon.Text = "";
            sifre.Text = "";
            key = 0;

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void receptionistDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void receptionistDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = receptionistDGV.SelectedCells[0].RowIndex;

            ad.Text = receptionistDGV.Rows[secilen].Cells[1].Value.ToString();
            kimlik.Text = receptionistDGV.Rows[secilen].Cells[2].Value.ToString();
            cinsiyet.Text = receptionistDGV.Rows[secilen].Cells[3].Value.ToString();
            sehir.Text = receptionistDGV.Rows[secilen].Cells[4].Value.ToString();
            telefon.Text = receptionistDGV.Rows[secilen].Cells[5].Value.ToString();
            sifre.Text = receptionistDGV.Rows[secilen].Cells[6].Value.ToString();

            if (ad.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(receptionistDGV.Rows[secilen].Cells[0].Value.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void patient_Click(object sender, EventArgs e)
        {
            Hasta obj = new Hasta();
            obj.Show();
            this.Hide();
        }

        private void doctor_Click(object sender, EventArgs e)
        {
            Doctor obj = new Doctor();
            obj.Show();
            this.Hide();
        }

        private void recep_Click(object sender, EventArgs e)
        {
            Receptionist obj = new Receptionist();
            obj.Show();
            this.Hide();
        }

        private void lab_Click(object sender, EventArgs e)
        {
            Laboratory obj = new Laboratory();
            obj.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
