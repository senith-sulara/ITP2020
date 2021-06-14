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

namespace AttendanceManagement
{
    public partial class Attendance : Form
    {
        
        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendanceDBDataSet5.Status' table. You can move, or remove it, as needed.
            this.statusTableAdapter1.Fill(this.attendanceDBDataSet5.Status);
            // TODO: This line of code loads data into the 'attendanceDBDataSet4.Status' table. You can move, or remove it, as needed.
            this.statusTableAdapter.Fill(this.attendanceDBDataSet4.Status);
            // TODO: This line of code loads data into the 'dataSet13.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.FillByAttend(this.dataSet13.Attendance);
            // TODO: This line of code loads data into the 'dataSet12.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.FillByDepIdAndName(this.dataSet12.Department);
            this.attendanceTableAdapter.FillByAttend(this.dataSet1.Attendance);

        }
        //get data by depart ment & date then update all
        private void ApplyAll_Click(object sender, EventArgs e)
        {
            
            AttendanceTableAdapter ada = new AttendanceTableAdapter();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
               if (row.Cells[0].Value != null)
                {
                    ada.UpdateQuery(row.Cells[4].Value.ToString(), (int)row.Cells[0].Value, (int)comboBox1.SelectedValue, dateTimePicker1.Text);
                }
            }
            DataTable dt_new = ada.GetDataBy2((int)comboBox1.SelectedValue, dateTimePicker1.Text);
            dataGridView1.DataSource = dt_new;
        }
        //get data by search and update selected
        private void button1_Click(object sender, EventArgs e)
        {
           
            AttendanceTableAdapter ada = new AttendanceTableAdapter();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                   ada.UpdateQueryEmpSearch(row.Cells[4].Value.ToString(), textBoxSearchID.Text,(int)dataGridView1.CurrentRow.Cells[0].Value);
                }
            }
            DataTable dt_update = ada.GetDataByEmpNameSearch(textBoxSearchID.Text);
            dataGridView1.DataSource = dt_update;
          

        }
        //Search and delete
        private void button2_Click(object sender, EventArgs e)
        {
            AttendanceTableAdapter ada = new AttendanceTableAdapter();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Cells[0].Value != null)
                {
                    ada.DeleteQuery((int)dataGridView1.CurrentRow.Cells[0].Value);
                }
            }
            DataTable dt_delete = ada.GetDataByEmpNameSearch(textBoxSearchID.Text);
            dataGridView1.DataSource = dt_delete;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        //insert data to table
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            AttendanceTableAdapter ada = new AttendanceTableAdapter(); 
            DataTable dt = ada.GetDataBy2((int)comboBox1.SelectedValue,dateTimePicker1.Text); //when the date and dep is selected then data will be add to the table

            if (dt.Rows.Count > 0)//data is already add to the table
            {
                DataTable dt_new = ada.GetDataBy2((int)comboBox1.SelectedValue, dateTimePicker1.Text);
                dataGridView1.DataSource = dt_new;
            }
            else
            {
                //table is empty 
                EmployeeTableAdapter employee_adapter = new EmployeeTableAdapter();
                DataTable dt_Emp = employee_adapter.GetDataByEmpAndDepID((int)comboBox1.SelectedValue);
               
               foreach(DataRow row in dt_Emp.Rows)
                {
                    ada.InsertQuerynew((int)row[0], (int)comboBox1.SelectedValue, dateTimePicker1.Text, "",row[1].ToString());

                }

                DataTable dt_new = ada.GetDataBy2((int)comboBox1.SelectedValue, dateTimePicker1.Text);
                dataGridView1.DataSource = dt_new;

            }
           
        }

        private void Attendance_Activated(object sender, EventArgs e)
        {
            
           
        }
        //search button
        private void buttonSearchID_Click(object sender, EventArgs e)
        {
            AttendanceTableAdapter ada = new AttendanceTableAdapter();
            DataTable dt = ada.GetDataByEmpNameSearch(textBoxSearchID.Text);
            dataGridView1.DataSource = dt;


        }
        //view all button
        private void button2_Click_1(object sender, EventArgs e)
        {
            AttendanceTableAdapter ada = new AttendanceTableAdapter();
            DataTable dt = ada.GetDataByAttend();
            dataGridView1.DataSource = dt;
        }
        //Get attendance button
        private void insertQr_Click(object sender, EventArgs e)
        {
            QRScanner  qRScannser = new QRScanner();
            qRScannser.ShowDialog();

        }

        private void textBoxSearchID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 