using AttendanceManagement.DataSet1TableAdapters;
using Microsoft.Office.Interop.Excel;
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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Clear();//Clear list
            }

            //Get Data From Employee table
            EmployeeTableAdapter employee_adapter = new EmployeeTableAdapter();
            System.Data.DataTable dt_Emp = employee_adapter.GetDataByEmpAndDepID((int)comboBox2.SelectedValue);
            //Get Data From Attendance table
            AttendanceTableAdapter ada = new AttendanceTableAdapter();

            int P, A, E = 0;

            foreach (DataRow row in dt_Emp.Rows)
            {
                //Count

                P = (int)ada.GetDataByReport(dateTimePicker2.Value.Month, row[1].ToString(), "Present").Rows[0][6];

                A = (int)ada.GetDataByReport(dateTimePicker2.Value.Month, row[1].ToString(), "Absent").Rows[0][6];

                E = (int)ada.GetDataByReport(dateTimePicker2.Value.Month, row[1].ToString(), "Excused").Rows[0][6];

                //Assign data to list
                ListViewItem litem = new ListViewItem();
                litem.Text = row[1].ToString();
                litem.SubItems.Add(P.ToString());
                litem.SubItems.Add(A.ToString());
                litem.SubItems.Add(E.ToString());
                listView1.Items.Add(litem);

            }

        }

        private void Report_load(object sender, EventArgs e)
        {
            this.departmentTableAdapter.FillByDepIdAndName(this.dataSet1.Department);//Data for combo box
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Export as a Excel file
            using(SaveFileDialog sfd = new SaveFileDialog() { Filter ="Excel WorkSheet|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Employee Name";
                    ws.Cells[1, 2] = "Present";
                    ws.Cells[1, 3] = "Absent";
                    ws.Cells[1, 4] = "Excused";
                    int i = 2;
                    foreach(ListViewItem item in listView1.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        ws.Cells[i, 3] = item.SubItems[2].Text;
                        ws.Cells[i, 4] = item.SubItems[3].Text;
                        i++;
                    }
                    wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Data has been successfully exported.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }    
    }
}
