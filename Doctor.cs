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
using System.Data.SqlClient;

namespace hospital_management_system
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
            display();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=AHMED\SQLEXPRESS;Initial Catalog=hastaneDB;Integrated Security=True");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneDBDataSet.DoktorTbl' table. You can move, or remove it, as needed.
            this.doktorTblTableAdapter.Fill(this.hastaneDBDataSet.DoktorTbl);

        }

        private void display()
        {
            conn.Open();
            string query = "select * from DoktorTbl";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var show = new DataSet();
            sqlDataAdapter.Fill(show);
            DGVdoctor.DataSource = show.Tables[0];
            conn.Close();
        }

        private void clear()
        {
            doktoradi.Text = "";
            kimlik.Text = "";
            cinsiyet.Text = "";
            tecrube.Text = "";
            telefon.Text = "";
            sifre.Text = "";
            uzman.Text = "";
            key = 0;

        }
        private void Ekle_Click(object sender, EventArgs e)
        {
            if (doktoradi.Text == "" || cinsiyet.Text == "" || uzman.Text == "" || tecrube.Text == "" || kimlik.Text == "" || telefon.Text == "" || sifre.Text == "")
            {

                MessageBox.Show("Boş bırakılamaz");

            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into DoktorTbl([Doktor Adi], [Kimlik No], [Cinsiyet], [Doğum Tarihi], [Uzmanlık Alanı], [Tecrübe], [Telefon], [Şifre]) values (@r1, @r2, @r3, @r4, @r5, @r6, @r7, @r8)", conn);
                    cmd.Parameters.AddWithValue("@r1", doktoradi.Text);
                    cmd.Parameters.AddWithValue("@r2", kimlik.Text);
                    cmd.Parameters.AddWithValue("@r3", cinsiyet.Text);
                    cmd.Parameters.AddWithValue("@r4", dogum.Value.Date);
                    cmd.Parameters.AddWithValue("@r5", uzman.Text);
                    cmd.Parameters.AddWithValue("@r6", exp.Text);
                    cmd.Parameters.AddWithValue("@r7", telefon.Text);
                    cmd.Parameters.AddWithValue("@r8", sifre.Text);
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
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        int key = 0;

        private void DGVdoctor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = DGVdoctor.SelectedCells[0].RowIndex;

            doktoradi.Text = DGVdoctor.Rows[secilen].Cells[1].Value.ToString();
            kimlik.Text = DGVdoctor.Rows[secilen].Cells[2].Value.ToString();
            cinsiyet.Text = DGVdoctor.Rows[secilen].Cells[3].Value.ToString();
            dogum.Text = DGVdoctor.Rows[secilen].Cells[4].Value.ToString();
            uzman.Text = DGVdoctor.Rows[secilen].Cells[5].Value.ToString();
            exp.Text = DGVdoctor.Rows[secilen].Cells[6].Value.ToString();
            telefon.Text = DGVdoctor.Rows[secilen].Cells[7].Value.ToString();
            sifre.Text = DGVdoctor.Rows[secilen].Cells[8].Value.ToString();

            if (doktoradi.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DGVdoctor.Rows[secilen].Cells[0].Value.ToString());
            }
        }

        private void duzenle_Click(object sender, EventArgs e)
        {
            if (doktoradi.Text == "" || cinsiyet.Text == "" || uzman.Text == "" || tecrube.Text == "" || kimlik.Text == "" || telefon.Text == "" || sifre.Text == "")
            {

                MessageBox.Show("Boş bırakılamaz");

            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Update DoktorTbl set [Doktor Adi] = @r1, [Kimlik No] = @r2, [Cinsiyet] = @r3, [Doğum Tarihi] = @r4, [Uzmanlık Alanı] = @r5, [Tecrübe] = @r6, [Telefon] = @r7, [Şifre] = @r8 where [Doktor ID]=@r0", conn);
                    cmd.Parameters.AddWithValue("@r1", doktoradi.Text);
                    cmd.Parameters.AddWithValue("@r2", kimlik.Text);
                    cmd.Parameters.AddWithValue("@r3", cinsiyet.Text);
                    cmd.Parameters.AddWithValue("@r4", dogum.Value.Date);
                    cmd.Parameters.AddWithValue("@r5", uzman.Text);
                    cmd.Parameters.AddWithValue("@r6", exp.Text);
                    cmd.Parameters.AddWithValue("@r7", telefon.Text);
                    cmd.Parameters.AddWithValue("@r8", sifre.Text);
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
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
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
                    SqlCommand cmd = new SqlCommand("Delete from DoktorTbl where [Doktor ID]=@r0", conn);
                    cmd.Parameters.AddWithValue("@r0", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doktor Silindi");
                    conn.Close();
                    display();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void lab_Click(object sender, EventArgs e)
        {
            Laboratory obj = new Laboratory();
            obj.Show();
            this.Hide();
        }

        private void recep_Click(object sender, EventArgs e)
        {
            Receptionist obj = new Receptionist();
            obj.Show();
            this.Hide();
        }

        private void hasta_Click(object sender, EventArgs e)
        {
            Hasta obj = new Hasta();
            obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
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
    }
}
