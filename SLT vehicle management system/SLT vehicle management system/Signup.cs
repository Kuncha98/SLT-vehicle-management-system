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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (fnametxt.Text != null && lnametxt.Text != null && emailtxt.Text != null && passwordtxt.Text != null && cpasswordtxt.Text != null)
            {
                try
                {
                    connect obj = new connect();
                    obj.conn.ConnectionString = obj.locate;
                    obj.conn.Open();
                    string insertuser = "insert into Employee_Table values ('"+ fnametxt.Text+"' , '"+lnametxt.Text+"' , '"+addresstxt.Text+"' , '"+gendertxt.Text+"' , '"+contacttxt.Text+"' , '"+emailtxt.Text+"' , '"+passwordtxt.Text+"')";
                    obj.cmd.Connection = obj.conn;
                    obj.cmd.CommandText = insertuser;
                    obj.cmd.ExecuteNonQuery();

                    obj.conn.Close();
                    MessageBox.Show("Sign UP is successfull");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }

            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            passwordtxt.PasswordChar = '*';
            cpasswordtxt.PasswordChar = '*';
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Contacttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.Show();
        }
    }
}
