namespace AttendanceManagement
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.percentageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceDBDataSet1 = new AttendanceManagement.AttendanceDBDataSet1();
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AttendanceManagement.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.attendanceTableAdapter = new AttendanceManagement.DataSet1TableAdapters.AttendanceTableAdapter();
            this.attendanceDBDataSet = new AttendanceManagement.AttendanceDBDataSet();
            this.attendanceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceTableAdapter1 = new AttendanceManagement.AttendanceDBDataSetTableAdapters.AttendanceTableAdapter();
            this.percentageTableAdapter = new AttendanceManagement.AttendanceDBDataSet1TableAdapters.PercentageTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.percentageBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceDBDataSet3 = new AttendanceManagement.AttendanceDBDataSet3();
            this.attendanceDBDataSet2 = new AttendanceManagement.AttendanceDBDataSet2();
            this.percentageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.percentageTableAdapter1 = new AttendanceManagement.AttendanceDBDataSet2TableAdapters.PercentageTableAdapter();
            this.percentageTableAdapter2 = new AttendanceManagement.AttendanceDBDataSet3TableAdapters.PercentageTableAdapter();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new AttendanceManagement.DataSet1TableAdapters.EmployeeTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TotEmp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.percentageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentageBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentageBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // percentageBindingSource
            // 
            this.percentageBindingSource.DataMember = "Percentage";
            this.percentageBindingSource.DataSource = this.attendanceDBDataSet1;
            // 
            // attendanceDBDataSet1
            // 
            this.attendanceDBDataSet1.DataSetName = "AttendanceDBDataSet1";
            this.attendanceDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataMember = "Attendance";
            this.attendanceBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(72, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Daily Attendance Summary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(72, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Monthly Attendance Summary";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // attendanceTableAdapter
            // 
            this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // attendanceDBDataSet
            // 
            this.attendanceDBDataSet.DataSetName = "AttendanceDBDataSet";
            this.attendanceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceBindingSource1
            // 
            this.attendanceBindingSource1.DataMember = "Attendance";
            this.attendanceBindingSource1.DataSource = this.attendanceDBDataSet;
            // 
            // attendanceTableAdapter1
            // 
            this.attendanceTableAdapter1.ClearBeforeFill = true;
            // 
            // percentageTableAdapter
            // 
            this.percentageTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.NavajoWhite;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.DataSource = this.percentageBindingSource2;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(67, 263);
            this.chart1.Name = "chart1";
            this.chart1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Attendance";
            series3.XValueMember = "Month & Year";
            series3.YValueMembers = "Percentage %";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(859, 332);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "Attendance";
            this.chart1.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // percentageBindingSource2
            // 
            this.percentageBindingSource2.DataMember = "Percentage";
            this.percentageBindingSource2.DataSource = this.attendanceDBDataSet3;
            // 
            // attendanceDBDataSet3
            // 
            this.attendanceDBDataSet3.DataSetName = "AttendanceDBDataSet3";
            this.attendanceDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceDBDataSet2
            // 
            this.attendanceDBDataSet2.DataSetName = "AttendanceDBDataSet2";
            this.attendanceDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // percentageBindingSource1
            // 
            this.percentageBindingSource1.DataMember = "Percentage";
            this.percentageBindingSource1.DataSource = this.attendanceDBDataSet2;
            // 
            // percentageTableAdapter1
            // 
            this.percentageTableAdapter1.ClearBeforeFill = true;
            // 
            // percentageTableAdapter2
            // 
            this.percentageTableAdapter2.ClearBeforeFill = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.dataSet1;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TotEmp);
            this.panel1.Location = new System.Drawing.Point(167, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 103);
            this.panel1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Total Employees";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotEmp
            // 
            this.TotEmp.AutoSize = true;
            this.TotEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotEmp.ForeColor = System.Drawing.Color.Snow;
            this.TotEmp.Location = new System.Drawing.Point(41, 12);
            this.TotEmp.Name = "TotEmp";
            this.TotEmp.Size = new System.Drawing.Size(64, 46);
            this.TotEmp.TabIndex = 16;
            this.TotEmp.Text = "04";
            this.TotEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TotEmp.Click += new System.EventHandler(this.TotEmp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Present";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(431, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 103);
            this.panel2.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 46);
            this.label5.TabIndex = 16;
            this.label5.Text = "03";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(703, 94);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panel3.Size = new System.Drawing.Size(146, 103);
            this.panel3.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(44, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Absent";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(43, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 46);
            this.label7.TabIndex = 16;
            this.label7.Text = "01";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(1085, 662);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.percentageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentageBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentageBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private DataSet1TableAdapters.AttendanceTableAdapter attendanceTableAdapter;
        private AttendanceDBDataSet attendanceDBDataSet;
        private System.Windows.Forms.BindingSource attendanceBindingSource1;
        private AttendanceDBDataSetTableAdapters.AttendanceTableAdapter attendanceTableAdapter1;
        private AttendanceDBDataSet1 attendanceDBDataSet1;
        private System.Windows.Forms.BindingSource percentageBindingSource;
        private AttendanceDBDataSet1TableAdapters.PercentageTableAdapter percentageTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private AttendanceDBDataSet2 attendanceDBDataSet2;
        private System.Windows.Forms.BindingSource percentageBindingSource1;
        private AttendanceDBDataSet2TableAdapters.PercentageTableAdapter percentageTableAdapter1;
        private AttendanceDBDataSet3 attendanceDBDataSet3;
        private System.Windows.Forms.BindingSource percentageBindingSource2;
        private AttendanceDBDataSet3TableAdapters.PercentageTableAdapter percentageTableAdapter2;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TotEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}