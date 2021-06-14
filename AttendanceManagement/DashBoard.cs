using AttendanceManagement.DataSet1TableAdapters;
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

namespace AttendanceManagement
{
    public partial class DashBoard : Form
    {
        string con_string = @"Data Source=LAPTOP-AMG7EJML;Initial Catalog=AttendanceDB;Integrated Security=True";

        public DashBoard()
        {
            InitializeComponent();
            
            SqlConnection con = new SqlConnection(con_string);
            con.Open();

            string sqlSelectQuery = "SELECT COUNT(*) AS count FROM Employee";
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TotEmp.Text = (dr["count"].ToString());
            }
            con.Close();
            con.Open();
            string sqlSelectPresent = "SELECT COUNT(Status) AS pres FROM Attendance WHERE Status LIKE 'p%' AND Date=@todayDate";

            SqlCommand cmd1 = new SqlCommand(sqlSelectPresent, con);
            cmd1.Parameters.AddWithValue("@todayDate",DateTime.Today);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                label5.Text = (dr1["pres"].ToString());
            }
            con.Close();
            con.Open();
            string sqlSelectAbsent = "SELECT COUNT(Status) AS pres FROM Attendance WHERE Status LIKE 'a%' AND Date=@todayDate";
            SqlCommand cmd2 = new SqlCommand(sqlSelectAbsent, con);
            cmd2.Parameters.AddWithValue("@todayDate", DateTime.Today);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                label7.Text = (dr2["pres"].ToString());
            }
            con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.FillByEmpIDAndName(this.dataSet1.Employee);
            // TODO: This line of code loads data into the 'attendanceDBDataSet3.Percentage' table. You can move, or remove it, as needed.
            this.percentageTableAdapter2.Fill(this.attendanceDBDataSet3.Percentage);
           
            this.attendanceTableAdapter1.Fill(this.attendanceDBDataSet.Attendance);
            // TODO: This line of code loads data into the 'dataSet1.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.FillByAttend(this.dataSet1.Attendance);

        }

       

        private void fillByCountToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeeTableAdapter.FillByCount(this.dataSet1.Employee);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        private void TotEmp_Click(object sender, EventArgs e)
        {
            //EmployeeTableAdapter employee_adapter = new EmployeeTableAdapter();
           
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
