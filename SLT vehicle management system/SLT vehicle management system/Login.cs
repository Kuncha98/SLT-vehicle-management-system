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

namespace SLT_vehicle_management_system
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection();
        public Login()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\C# work\SLT vehicle management.mdf';Integrated Security=True;Connect Timeout=30";

            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\C# work\SLT vehicle management.mdf';Integrated Security=True;Connect Timeout=30";
            con.Open();
            string userid = username.Text;
            string password = pw.Text;
            SqlCommand cmd = new SqlCommand("Select First_Name, Password From Employee_Table Where First_Name='" + username.Text + "'and Password='" + pw.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess");
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Signup f = new Signup();
            this.Hide();
            f.Show();

        }
    }
}
