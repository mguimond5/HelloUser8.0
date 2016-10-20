/**

 *

 * Marsha

 * Mr.Hardman

 * Assignment 2, Program 2

 * Date Last Modified: 13, October, 2016 

 *

 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloUser8._0
{
    public partial class frmHelloUser : Form
    {
        public frmHelloUser()
        {
            InitializeComponent();
        }

        private void btnHelloUser_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Hello! Please fill in all questions.";
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDisplay2_Click(object sender, EventArgs e)
        {

        }

        private void txtUserNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUserNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplay3_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName;
            double userNumber;
            
            
            userName = txtUserName.Text;
            double number = Convert.ToDouble(txtUserNumber.Text);
            /* Here I just want to understand more about you and I really want to know your name
            * because if I do, we can be friends forever!
            */



            lblDisplay2.Text = txtUserName.Text;                          
            lblDisplay3.Text = txtUserNumber.Text;
            lblDisplay4.Text = "Whoa! Cool name and number!";
           



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
