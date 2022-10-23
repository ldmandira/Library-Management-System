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
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bname = txtbname.Text;
            string bid = txtbid.Text;
            string au = txtau.Text;
            string pub = txtpub.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\library.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "update book set name='" + bname + "' ,  author='" + au + "' , publisher='" + pub + "' where id='" + bid + "'  ";

            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update record sucessfully");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbid.Text = "";
            txtbname.Text = "";
            txtau.Text = "";
            txtpub.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            string name = txtname.Text;
            string mail = txtmail.Text;
             
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\library.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "update student set name='" + name + "' ,  email='" + mail + "' where sid='" + id + "'  ";

            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update record successfully");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtname.Text = "";
            txtmail.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            search se = new search();
            se.Show();
            this.Hide();
        }
    }
}
