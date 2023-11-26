using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_management_system
{
    public partial class Prescription : Form
    {
        public Prescription()
        {
            InitializeComponent();
            display();
            GetDocId();
            GetPatId();
            GetTestId();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=AHMED\SQLEXPRESS;Initial Catalog=hastaneDB;Integrated Security=True");

        private void Prescription_Load(object sender, EventArgs e)
        {

        }
        private void display()
        {
            conn.Open();
            string query = "select * from ReceteTbl";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var show = new DataSet();
            sqlDataAdapter.Fill(show);
            receteDGV.DataSource = show.Tables[0];
            conn.Close();
        }


        int key = 0;
        private void clear()
        {
            hasta.Text = "";
            hastaadi.Text = "";
            doktor.Text = "";
            doctoradi.Text = "";
            test.Text = "";
            testadi.Text = "";
            ilac.Text = "";
            cost.Text = "";
            key = 0;

        }

        private void GetDocAdi()
        {
            conn.Open();
            string query = "Select * from DoktorTbl where [Doktor ID] = "+doktor.SelectedValue.ToString()+"";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                doctoradi.Text = dr["Doktor Adi"].ToString();
            }

            conn.Close() ;
        }

        private void GetDocId()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select [Doktor ID] from DoktorTbl", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("[Doktor ID]", typeof(int));
            dt.Load(rdr);
            doktor.ValueMember = "Doktor ID";
            doktor.DataSource = dt;
            conn.Close();
        }

        private void GetPatAdi()
        {
            conn.Open();
            string query = "Select * from HastaTbl where [Hasta ID] = " + hasta.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                hastaadi.Text = dr["Hasta Adi"].ToString();
            }

            conn.Close();
        }
        private void GetPatId()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select [Hasta ID] from HastaTbl", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("[Hasta ID]", typeof(int));
            dt.Load(rdr);
            hasta.ValueMember = "Hasta ID";
            hasta.DataSource = dt;
            conn.Close();
        }

        private void GetTestAdi()
        {
            conn.Open();
            string query = "Select * from TestTbl where [Test No] = " + hasta.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                testadi.Text = dr["Test Adi"].ToString();
                cost.Text = dr["Masraf"].ToString();
            }

            conn.Close();
        }
        private void GetTestId()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select [Test No] from TestTbl", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("[Test No]", typeof(int));
            dt.Load(rdr);
            test.ValueMember = "Test No";
            test.DataSource = dt;
            conn.Close();
        }
        private void ekle_Click(object sender, EventArgs e)
        {
            if (doctoradi.Text=="" ||hastaadi.Text=="" ||testadi.Text=="")
            {

                MessageBox.Show("Boş bırakılamaz");

            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into ReceteTbl([Doktor ID], [Doktor Adi], [Hasta ID], [Hasta Adi], [Test ID], [Test Adi], [Masraf], [ilaçlar]) values (@r1, @r2, @r3, @r4, @r5, @r6, @r7, @r8)", conn);
                    cmd.Parameters.AddWithValue("@r1", doktor.Text);
                    cmd.Parameters.AddWithValue("@r2", doctoradi.Text);
                    cmd.Parameters.AddWithValue("@r3", hasta.Text);
                    cmd.Parameters.AddWithValue("@r4", hastaadi.Text);
                    cmd.Parameters.AddWithValue("@r5", test.Text);
                    cmd.Parameters.AddWithValue("@r6", testadi.Text);
                    cmd.Parameters.AddWithValue("@r7", cost.Text);
                    cmd.Parameters.AddWithValue("@r8", ilac.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Recete eklendi");
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

        private void doktor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetDocAdi();
        }

        private void hasta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPatAdi();
        }

        private void test_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTestAdi();
        }

        private void receteDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = receteDGV.SelectedCells[0].RowIndex;
            recete.Text = "";
            recete.Text = "                                                              Hastane Yönetim Sistemi                                                                      " +
                          "\n                                                                 Recete                                                                               " +
                          "\n**********************************************************************************************************************" +
                          DateTime.Today.Date + "                                                                                                            " +
                          "\n     Doctor: " + receteDGV.Rows[secilen].Cells[2].Value.ToString() +
                          "\n     Hasta:" + receteDGV.Rows[secilen].Cells[4].Value.ToString() +
                          "\n     Test: " + receteDGV.Rows[secilen].Cells[6].Value.ToString() + 
                          "\n**********************************************************************************************************************" +
                          "\n     Ilaclar: " + receteDGV.Rows[secilen].Cells[7].Value.ToString();

         
        }



        private void print_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(recete.Text + "\n", new Font("Averia", 18, FontStyle.Regular), Brushes.Black, new Point(95, 80));
            e.Graphics.DrawString("\n\t" + "Thanks", new Font("Averia", 15, FontStyle.Regular), Brushes.Red, new Point(200, 300));
        }

        private void doctor_Click(object sender, EventArgs e)
        {
            Doctor obj = new Doctor();
            obj.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
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

        private void recete_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
