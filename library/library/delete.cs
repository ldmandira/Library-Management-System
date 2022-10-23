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
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bid = txtbid.Text;
           /* string bname = txtbname.Text;
            string au = txtau.Text;
            string pub = txtpub.Text;*/

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\library.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "delete  from book where id='" + bid + "' "; //, name='" + bname + "' , author='" + au + "' , publisher='" + pub + "' ";

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete record succefully");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("" + ex);
            }

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

        private void button4_Click(object sender, EventArgs e)
        {
            string id = txtsid.Text;
           /* string name = txtname.Text;
            string mail = txtmail.Text;*/

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\library.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "delete from student where sid='" + id + "' ";// , name='" + name + "'  ,  email='" + mail + "'  ";

            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete record sucessfully");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbid.Text = "";
            /*txtbname.Text = "";
            txtau.Text = "";
            txtpub.Text = "";*/

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtsid.Text = "";
            /*txtname.Text = "";
            txtmail.Text = "";*/
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
 