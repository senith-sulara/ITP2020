using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceManagement.DataSet1TableAdapters;
using System.Data.SqlClient;

namespace AttendanceManagement
{
    public partial class UserProfile : Form
    {
        public String Username { get; set; }
        public String Password { get; set; }

        
        public UserProfile(string strUser)
        {
            InitializeComponent();
           // textBox1.Text = strUser;
            //int pres = 2;
            string con_string = @"Data Source=.;Initial Catalog=AttendanceDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(con_string);
            con.Open();
            String sqlSelectUser = "SELECT * FROM Employee WHERE Emp_ID =100";
            
            SqlCommand cmd = new SqlCommand(sqlSelectUser, con);
           // cmd.Parameters.AddWithValue("@UserName", strUser);
            //cmd.Parameters.AddWithValue("@Password", strPass);
            SqlDataReader dr3 = cmd.ExecuteReader();
            if (dr3.Read())
            {
                textBox1.Text = (dr3["Emp_ID"].ToString());
                textBox2.Text = (dr3["F_name"].ToString());
                textBox3.Text = (dr3["L_name"].ToString());
                textBox4.Text = (dr3["Phone"].ToString());
                textBox5.Text = (dr3["Address"].ToString());
            }
            con.Close();
           
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con_string = @"Data Source=.;Initial Catalog=AttendanceDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(con_string);
            con.Open();
            String sqlUpdateUser = "UPDATE Employee SET F_name='"+this.textBox2.Text+"',L_name='"+this.textBox3.Text+"',Phone='"+this.textBox4.Text+"',Address='"+this.textBox5.Text+ "' WHERE Emp_ID='" + this.textBox1.Text + "'";

            SqlCommand cmd = new SqlCommand(sqlUpdateUser, con);
            SqlDataReader dr = cmd.ExecuteReader();
            MessageBox.Show("Saved");
            while (dr.Read()) {
            }
            con.Close();
        }
    }
}
