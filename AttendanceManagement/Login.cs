using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceManagement
{
    public partial class Login : Form
    {
        public bool loginFlag { get; set; }
        public String Username { get; set; }

        public String Password { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //login Button
        private void button1_Click(object sender, EventArgs e)
        {
           
             DataSet1TableAdapters.userPTableAdapter userAda = new DataSet1TableAdapters.userPTableAdapter();
             DataTable dt = userAda.GetDataByuser(textBoxUser.Text, textBoxPassword.Text);

                if (dt.Rows.Count > 0)
                {
                    //valid
                    MessageBox.Show("Login Success");
                    Username = (string)dt.Rows[0]["UserName"];
                    Password = (string)dt.Rows[0]["Password"];

                    loginFlag = true;
                    Close();

                }
                else
                {
                    //Invalid
                    MessageBox.Show("Login Fail");
                    loginFlag = false;
                } 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        //forget password label
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPw fgp = new ForgetPw();
            fgp.Show();
        }
        //password character hide
        private void button4con_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar == '\0')
            {
                button5con.BringToFront();
                textBoxPassword.PasswordChar = '*';
            }
        }
        //password character view
        private void button5con_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar == '*')
            {
                button4con.BringToFront();
                textBoxPassword.PasswordChar = '\0';
            }
        }
        //back button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Home hm = new Home();
            hm.Show();
        }
    }
}
