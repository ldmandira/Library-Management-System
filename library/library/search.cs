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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            update up = new update();
            up.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\library.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "select * from  book where id='"+txtbid.Text+"' ";
            

            SqlDataAdapter da = new SqlDataAdapter(query,con);
            DataSet ds = new DataSet();
            da.Fill(ds, "book");

            dgv1.DataSource = ds.Tables["book"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\library.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "select * from  book where name='" + txtbname.Text + "' ";


            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "book");

            dgv1.DataSource = ds.Tables["book"];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtbname.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtbid.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*dashboard db = new dashboard();
            db.Show();
            this.Hide();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete del = new delete();
            del.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\library.mdf;Integrated Security=True;Connect Timeout=30";
            string query="Select * from book";

            SqlDataAdapter da = new SqlDataAdapter(query,con);
            DataSet ds = new DataSet();
            da.Fill(ds, "book");

            dgv1.DataSource = ds.Tables["book"];

            

        }
    }
}
