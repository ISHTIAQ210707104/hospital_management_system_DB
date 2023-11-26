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
    public partial class Laboratory : Form
    {
        public Laboratory()
        {
            InitializeComponent();
            display();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=AHMED\SQLEXPRESS;Initial Catalog=hastaneDB;Integrated Security=True");


        private void display()
        {
            conn.Open();
            string query = "select * from TestTbl";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var show = new DataSet();
            sqlDataAdapter.Fill(show);
            labDGV.DataSource = show.Tables[0];
            conn.Close();
        }

        private void clear()
        {
            test.Text = "";
            masraf.Text = "";

            key = 0;

        }
        private void Laboratory_Load(object sender, EventArgs e)
        {

        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if(test.Text == "" || masraf.Text == "")
            {

                MessageBox.Show("Boş bırakılamaz");

            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into TestTbl([Test Adi], [Masraf]) values (@r1, @r2)", conn);
                    cmd.Parameters.AddWithValue("@r1", test.Text);
                    cmd.Parameters.AddWithValue("@r2", masraf.Text);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doktor eklendi");
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

        

        private void labDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = labDGV.SelectedCells[0].RowIndex;

            test.Text = labDGV.Rows[secilen].Cells[1].Value.ToString();
            masraf.Text = labDGV.Rows[secilen].Cells[2].Value.ToString();
           

            if (test.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(labDGV.Rows[secilen].Cells[0].Value.ToString());
            }
        }

        private void duzenle_Click(object sender, EventArgs e)
        {
            if (test.Text == "" || masraf.Text == "")
            {

                MessageBox.Show("Boş bırakılamaz");

            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Update TestTbl set [Test Adi] = @r1, [Masraf] = @r2 where [Test No] =@r0", conn);
                    cmd.Parameters.AddWithValue("@r1", test.Text);
                    cmd.Parameters.AddWithValue("@r2", masraf.Text);

                    cmd.Parameters.AddWithValue("@r0", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Düzenlendi");
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
                    SqlCommand cmd = new SqlCommand("Delete from TestTbl where [Test No]=@r0", conn);
                    cmd.Parameters.AddWithValue("@r0", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Test Silindi");
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

        private void doctor_Click(object sender, EventArgs e)
        {
            Doctor obj = new Doctor();
            obj.Show();
            this.Hide();
        }

        private void patients_Click(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
