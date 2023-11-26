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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            counthasta();
            countdoctor();
            countres();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=AHMED\SQLEXPRESS;Initial Catalog=hastaneDB;Integrated Security=True");

        private void counthasta()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from HastaTbl", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            pat.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }

        private void countdoctor()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from DoktorTbl", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            doc.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }

        private void countres()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from ResepsiyonistTbl", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            rec.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }
        private void logout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void hastalbl_Click(object sender, EventArgs e)
        {
            Hasta obj = new Hasta();
            obj.Show(); 
            this.Hide();
        }

        private void doktorlbl_Click(object sender, EventArgs e)
        {
            Doctor obj = new Doctor();
            obj.Show();
            this.Hide();
        }

        private void receplbl_Click(object sender, EventArgs e)
        {
            Receptionist obj = new Receptionist();
            obj.Show();
            this.Hide();
        }

        private void lablbl_Click(object sender, EventArgs e)
        {
            Laboratory obj = new Laboratory();
            obj.Show();
            this.Hide();
        }

        private void pat_Click(object sender, EventArgs e)
        {

        }
    }
}
