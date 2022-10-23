using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            student st = new student();
            st.Show();
           // this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            book bk = new book();
            bk.Show();
            //this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            search se = new search();
            se.Show();
           // this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            issue iss = new issue();
            iss.Show();
            //this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            retbook aa = new retbook();
            aa.Show();
            //this.Hide();
        }
    }
}
