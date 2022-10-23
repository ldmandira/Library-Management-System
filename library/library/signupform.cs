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

namespace library
{
    public partial class signupform : Form
    {
        
        public signupform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtfname.Text = "";
            txtlname.Text = "";
            txtuname.Text = "";
            txtemail.Text = "";
            txtpw.Text = "";
            txtconpw.Text = "";
            txtnic.Text = "";
        }

        private void signupform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtfname.Text == "" || txtlname.Text == "" || txtnic.Text == "" || txtuname.Text == "" || txtemail.Text == "" || txtpw.Text == "" || txtconpw.Text == "")
                {
                    MessageBox.Show("All fields are required");
                }

                else
                {
                    string fname = txtfname.Text;
                    string lname = txtlname.Text;
                    string uname = txtuname.Text;
                    string email = txtemail.Text;
                    string pw = txtpw.Text;
                    string conpw = txtconpw.Text;
                    string nic = txtnic.Text;

                    if (pw == conpw)
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\library.mdf;Integrated Security=True;Connect Timeout=30");

                        string query = "insert into signup values ('" + fname + "','" + lname + "','" + nic + "','" + uname + "','" + email + "','" + pw + "','" + conpw + "')";
                        SqlCommand cmd = new SqlCommand(query, con);

                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Sign up successfully");

                            dashboard db = new dashboard();
                            db.Show();
                            this.Hide();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("" + ex);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter correct password");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }
    }
}
