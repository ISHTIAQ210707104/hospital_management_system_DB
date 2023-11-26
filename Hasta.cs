using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_management_system
{
    public partial class Hasta : Form
    {
        public Hasta()
        {
            InitializeComponent();
            display();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=AHMED\SQLEXPRESS;Initial Catalog=hastaneDB;Integrated Security=True");

        private void display()
        {
            conn.Open();
            string query = "select * from HastaTbl";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var show = new DataSet();
            sqlDataAdapter.Fill(show);
            patientDGV.DataSource = show.Tables[0];
            conn.Close();
        }

        private void clear()
        {
            hastaadi.Text = "";
            kimlik.Text = "";
            cinsiyet.Text = "";
            dogum.Text = "";
            telefon.Text = "";
            kan.Text = "";
            sehir.Text = "";
            hastalik.Text = "";
            kayit.Text = "";
             key = 0;

        }
        private void Ekle_Click(object sender, EventArgs e)
        {
            if (hastaadi.Text == "" || kimlik.Text == "" || cinsiyet.Text == "" || dogum.Text == "" || telefon.Text == "" || kan.Text == "" || sehir.Text == "" || hastalik.Text == "" || kayit.Text == "")
            {

                MessageBox.Show("Boş bırakılamaz");

            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into HastaTbl([Hasta Adi], [Kimlik No], [Cinsiyet], [Doğum Tarihi], [Kan Grubu], [Telefon], [Şehir], [Hastalik], [Kayit Tarihi]) values (@r1, @r2, @r3, @r4, @r5, @r6, @r7, @r8, @r9)", conn);
                    cmd.Parameters.AddWithValue("@r1", hastaadi.Text);
                    cmd.Parameters.AddWithValue("@r2", kimlik.Text);
                    cmd.Parameters.AddWithValue("@r3", cinsiyet.Text);
                    cmd.Parameters.AddWithValue("@r4", dogum.Value.Date);
                    cmd.Parameters.AddWithValue("@r5", kan.Text);
                    cmd.Parameters.AddWithValue("@r6", telefon.Text);
                    cmd.Parameters.AddWithValue("@r7", sehir.Text);
                    cmd.Parameters.AddWithValue("@r8", hastalik.Text);
                    cmd.Parameters.AddWithValue("@r9", kayit.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hasta eklendi");
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

        private void duzenle_Click(object sender, EventArgs e)
        {
            if (hastaadi.Text == "" || kimlik.Text == "" || cinsiyet.Text == "" || dogum.Text == "" || telefon.Text == "" || kan.Text == "" || sehir.Text == "" || hastalik.Text == "" || kayit.Text == "")
            {

                MessageBox.Show("Boş bırakılamaz");

            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Update HastaTbl set [Hasta Adi] = @r1, [Kimlik No] = @r2, [Cinsiyet] = @r3, [Doğum Tarihi] = @r4, [Kan Grubu] = @r5, [Telefon] = @r6, [Şehir] = @r7, [Hastalik] = @r8, [Kayit Tarihi] = @r9 where [Hasta ID]=@r0", conn);
                    cmd.Parameters.AddWithValue("@r1", hastaadi.Text);
                    cmd.Parameters.AddWithValue("@r2", kimlik.Text);
                    cmd.Parameters.AddWithValue("@r3", cinsiyet.Text);
                    cmd.Parameters.AddWithValue("@r4", dogum.Value.Date);
                    cmd.Parameters.AddWithValue("@r5", kan.Text);
                    cmd.Parameters.AddWithValue("@r6", telefon.Text);
                    cmd.Parameters.AddWithValue("@r7", sehir.Text);
                    cmd.Parameters.AddWithValue("@r8", hastalik.Text);
                    cmd.Parameters.AddWithValue("@r9", kayit.Value.Date); ;
                    cmd.Parameters.AddWithValue("@r0", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hasta Düzenlendi");
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

        int key = 0;
        private void patientDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = patientDGV.SelectedCells[0].RowIndex;

            hastaadi.Text = patientDGV.Rows[secilen].Cells[1].Value.ToString();
            kimlik.Text = patientDGV.Rows[secilen].Cells[2].Value.ToString();
            cinsiyet.Text = patientDGV.Rows[secilen].Cells[3].Value.ToString();
            dogum.Text = patientDGV.Rows[secilen].Cells[4].Value.ToString();
            kan.Text = patientDGV.Rows[secilen].Cells[5].Value.ToString();
            telefon.Text = patientDGV.Rows[secilen].Cells[6].Value.ToString();
            sehir.Text = patientDGV.Rows[secilen].Cells[7].Value.ToString();
            hastalik.Text = patientDGV.Rows[secilen].Cells[8].Value.ToString();
            kayit.Text = patientDGV.Rows[secilen].Cells[9].Value.ToString();

            if (hastaadi.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(patientDGV.Rows[secilen].Cells[0].Value.ToString());
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
                    SqlCommand cmd = new SqlCommand("Delete from HastaTbl where [Hasta ID]=@r0", conn);
                    cmd.Parameters.AddWithValue("@r0", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hasta Silindi");
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



        private void logout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }



        private void doc_Click(object sender, EventArgs e)
        {
            Doctor obj = new Doctor();
            obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Hasta obj = new Hasta();
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

        private void patientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
