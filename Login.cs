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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=AHMED\SQLEXPRESS;Initial Catalog=hastaneDB;Integrated Security=True");
        private void sil_Click(object sender, EventArgs e)
        {
            use.SelectedIndex = 0;
            user.Text = "";
            pass.Text = "";
        }

        public static string role;
        private void giris_Click(object sender, EventArgs e)
        {
            if (use.SelectedIndex == -1)
            {
                MessageBox.Show("Select Your Position");
            }
            else if (use.SelectedIndex == 0)
            {
                if (user.Text == "" || pass.Text == "")
                {
                    MessageBox.Show("Enter Admin Name and Password");
                } else if (user.Text == "Admin" && pass.Text == "Password")
                {
                    role = "Admin";
                    Hasta obj = new Hasta();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Admin Name or Password");
                }
            }
            else if (use.SelectedIndex == 1)
            {
                if (user.Text == "" || pass.Text == "")
                {
                    MessageBox.Show("Enter Doctor Name and Password");
                }
                else
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from DoktorTbl where [Doktor Adi]= '"+user.Text+ "' and [Şifre] = '"+pass.Text+"'", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        role = "Doktor";
                        Prescription obj = new Prescription();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Doctor Not found");
                    }
                    conn.Close();
                }
            }
            else
            {
                if (user.Text == "" || pass.Text == "")
                {
                    MessageBox.Show("Enter Receptionist Name and Password");
                }
                else
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from ResepsiyonistTbl where [Resepsiyonist Adi]= '" + user.Text + "' and [Şifre] = '" + pass.Text + "'", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        role = "Resepsiyonist";
                        Home obj = new Home();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Receptionist Not found");
                    }
                    conn.Close();
                }
            }
        }
    }
}
