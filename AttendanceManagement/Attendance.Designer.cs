namespace AttendanceManagement
{
    partial class Attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet13 = new AttendanceManagement.DataSet1();
            this.statusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceDBDataSet5 = new AttendanceManagement.AttendanceDBDataSet5();
            this.attendanceBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AttendanceManagement.DataSet1();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.ApplyAll = new System.Windows.Forms.Button();
            this.UpdateSelect = new System.Windows.Forms.Button();
            this.removeSelect = new System.Windows.Forms.Button();
            this.labelSearchId = new System.Windows.Forms.Label();
            this.labelselectDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxSearchID = new System.Windows.Forms.TextBox();
            this.buttonSearchID = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.aIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet12 = new AttendanceManagement.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceTableAdapter = new AttendanceManagement.DataSet1TableAdapters.AttendanceTableAdapter();
            this.attendanceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new AttendanceManagement.DataSet1();
            this.attendanceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new AttendanceManagement.DataSet1TableAdapters.DepartmentTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.attendanceDBDataSet4 = new AttendanceManagement.AttendanceDBDataSet4();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTableAdapter = new AttendanceManagement.AttendanceDBDataSet4TableAdapters.StatusTableAdapter();
            this.statusTableAdapter1 = new AttendanceManagement.AttendanceDBDataSet5TableAdapters.StatusTableAdapter();
            this.insertQr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aIDDataGridViewTextBoxColumn1,
            this.depIDDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.Date,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.attendanceBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(26, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(620, 432);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // aIDDataGridViewTextBoxColumn1
            // 
            this.aIDDataGridViewTextBoxColumn1.DataPropertyName = "A_ID";
            this.aIDDataGridViewTextBoxColumn1.HeaderText = "A_ID";
            this.aIDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.aIDDataGridViewTextBoxColumn1.Name = "aIDDataGridViewTextBoxColumn1";
            this.aIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.aIDDataGridViewTextBoxColumn1.Width = 82;
            // 
            // depIDDataGridViewTextBoxColumn
            // 
            this.depIDDataGridViewTextBoxColumn.DataPropertyName = "Dep_ID";
            this.depIDDataGridViewTextBoxColumn.HeaderText = "Dep_ID";
            this.depIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.depIDDataGridViewTextBoxColumn.Name = "depIDDataGridViewTextBoxColumn";
            this.depIDDataGridViewTextBoxColumn.Width = 101;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "Employee Name";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "Employee Name";
            this.employeeNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            this.employeeNameDataGridViewTextBoxColumn.Width = 148;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.Width = 80;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.Width = 92;
            // 
            // attendanceBindingSource5
            // 
            this.attendanceBindingSource5.DataMember = "Attendance";
            this.attendanceBindingSource5.DataSource = this.dataSet13;
            // 
            // dataSet13
            // 
            this.dataSet13.DataSetName = "DataSet1";
            this.dataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusBindingSource1
            // 
            this.statusBindingSource1.DataMember = "Status";
            this.statusBindingSource1.DataSource = this.attendanceDBDataSet5;
            // 
            // attendanceDBDataSet5
            // 
            this.attendanceDBDataSet5.DataSetName = "AttendanceDBDataSet5";
            this.attendanceDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceBindingSource4
            // 
            this.attendanceBindingSource4.DataMember = "Attendance";
            this.attendanceBindingSource4.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Window;
            this.monthCalendar1.Location = new System.Drawing.Point(708, 129);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.Gray;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // ApplyAll
            // 
            this.ApplyAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyAll.BackColor = System.Drawing.Color.Wheat;
            this.ApplyAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ApplyAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ApplyAll.Location = new System.Drawing.Point(708, 451);
            this.ApplyAll.Name = "ApplyAll";
            this.ApplyAll.Size = new System.Drawing.Size(148, 34);
            this.ApplyAll.TabIndex = 2;
            this.ApplyAll.Text = "Apply All";
            this.ApplyAll.UseVisualStyleBackColor = false;
            this.ApplyAll.Click += new System.EventHandler(this.ApplyAll_Click);
            // 
            // UpdateSelect
            // 
            this.UpdateSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateSelect.BackColor = System.Drawing.Color.Wheat;
            this.UpdateSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateSelect.Location = new System.Drawing.Point(891, 451);
            this.UpdateSelect.Name = "UpdateSelect";
            this.UpdateSelect.Size = new System.Drawing.Size(148, 34);
            this.UpdateSelect.TabIndex = 3;
            this.UpdateSelect.Text = "Update Selected";
            this.UpdateSelect.UseVisualStyleBackColor = false;
            this.UpdateSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeSelect
            // 
            this.removeSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeSelect.BackColor = System.Drawing.Color.Tomato;
            this.removeSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeSelect.Location = new System.Drawing.Point(800, 509);
            this.removeSelect.Name = "removeSelect";
            this.removeSelect.Size = new System.Drawing.Size(148, 34);
            this.removeSelect.TabIndex = 4;
            this.removeSelect.Text = "Remove Selected";
            this.removeSelect.UseVisualStyleBackColor = false;
            this.removeSelect.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelSearchId
            // 
            this.labelSearchId.AutoSize = true;
            this.labelSearchId.BackColor = System.Drawing.Color.Transparent;
            this.labelSearchId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSearchId.Location = new System.Drawing.Point(28, 49);
            this.labelSearchId.Name = "labelSearchId";
            this.labelSearchId.Size = new System.Drawing.Size(60, 20);
            this.labelSearchId.TabIndex = 5;
            this.labelSearchId.Text = "Search";
            // 
            // labelselectDate
            // 
            this.labelselectDate.AutoSize = true;
            this.labelselectDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelselectDate.Location = new System.Drawing.Point(292, 49);
            this.labelselectDate.Name = "labelselectDate";
            this.labelselectDate.Size = new System.Drawing.Size(99, 20);
            this.labelselectDate.TabIndex = 6;
            this.labelselectDate.Text = "Select Date*";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(296, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(292, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // textBoxSearchID
            // 
            this.textBoxSearchID.Location = new System.Drawing.Point(30, 75);
            this.textBoxSearchID.Name = "textBoxSearchID";
            this.textBoxSearchID.Size = new System.Drawing.Size(136, 26);
            this.textBoxSearchID.TabIndex = 8;
            this.textBoxSearchID.TextChanged += new System.EventHandler(this.textBoxSearchID_TextChanged);
            // 
            // buttonSearchID
            // 
            this.buttonSearchID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSearchID.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSearchID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearchID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSearchID.Location = new System.Drawing.Point(172, 72);
            this.buttonSearchID.Name = "buttonSearchID";
            this.buttonSearchID.Size = new System.Drawing.Size(86, 35);
            this.buttonSearchID.TabIndex = 9;
            this.buttonSearchID.Text = "Search";
            this.buttonSearchID.UseVisualStyleBackColor = false;
            this.buttonSearchID.Click += new System.EventHandler(this.buttonSearchID_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(734, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Get Value";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // aIDDataGridViewTextBoxColumn
            // 
            this.aIDDataGridViewTextBoxColumn.DataPropertyName = "A_ID";
            this.aIDDataGridViewTextBoxColumn.HeaderText = "A_ID";
            this.aIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aIDDataGridViewTextBoxColumn.Name = "aIDDataGridViewTextBoxColumn";
            this.aIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.aIDDataGridViewTextBoxColumn.Width = 82;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.departmentBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(594, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "D_ID";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.dataSet12;
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet1";
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Department";
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataMember = "Attendance";
            this.attendanceBindingSource.DataSource = this.dataSet1;
            // 
            // attendanceBindingSource3
            // 
            this.attendanceBindingSource3.DataMember = "Attendance";
            this.attendanceBindingSource3.DataSource = this.dataSet12;
            // 
            // attendanceTableAdapter
            // 
            this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // attendanceBindingSource1
            // 
            this.attendanceBindingSource1.DataMember = "Attendance";
            this.attendanceBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceBindingSource2
            // 
            this.attendanceBindingSource2.DataMember = "Attendance";
            this.attendanceBindingSource2.DataSource = this.dataSet11;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(800, 558);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 34);
            this.button2.TabIndex = 13;
            this.button2.Text = "View All";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // attendanceDBDataSet4
            // 
            this.attendanceDBDataSet4.DataSetName = "AttendanceDBDataSet4";
            this.attendanceDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.attendanceDBDataSet4;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // statusTableAdapter1
            // 
            this.statusTableAdapter1.ClearBeforeFill = true;
            // 
            // insertQr
            // 
            this.insertQr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.insertQr.BackColor = System.Drawing.Color.GreenYellow;
            this.insertQr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insertQr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.insertQr.Location = new System.Drawing.Point(800, 395);
            this.insertQr.Name = "insertQr";
            this.insertQr.Size = new System.Drawing.Size(148, 34);
            this.insertQr.TabIndex = 14;
            this.insertQr.Text = "Get Attendance";
            this.insertQr.UseVisualStyleBackColor = false;
            this.insertQr.Click += new System.EventHandler(this.insertQr_Click);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(1078, 645);
            this.Controls.Add(this.insertQr);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSearchID);
            this.Controls.Add(this.textBoxSearchID);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelselectDate);
            this.Controls.Add(this.labelSearchId);
            this.Controls.Add(this.removeSelect);
            this.Controls.Add(this.UpdateSelect);
            this.Controls.Add(this.ApplyAll);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.Activated += new System.EventHandler(this.Attendance_Activated);
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button ApplyAll;
        private System.Windows.Forms.Button UpdateSelect;
        private System.Windows.Forms.Button removeSelect;
        private System.Windows.Forms.Label labelSearchId;
        private System.Windows.Forms.Label labelselectDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxSearchID;
        private System.Windows.Forms.Button buttonSearchID;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private DataSet1TableAdapters.AttendanceTableAdapter attendanceTableAdapter;
        private System.Windows.Forms.BindingSource attendanceBindingSource1;
        private System.Windows.Forms.Button button1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource attendanceBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIDDataGridViewTextBoxColumn;
        private DataSet1 dataSet12;
        private System.Windows.Forms.BindingSource attendanceBindingSource3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DataSet1TableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource attendanceBindingSource4;
        private DataSet1 dataSet13;
        private System.Windows.Forms.BindingSource attendanceBindingSource5;
        private System.Windows.Forms.Button button2;
        private AttendanceDBDataSet4 attendanceDBDataSet4;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private AttendanceDBDataSet4TableAdapters.StatusTableAdapter statusTableAdapter;
        private AttendanceDBDataSet5 attendanceDBDataSet5;
        private System.Windows.Forms.BindingSource statusBindingSource1;
        private AttendanceDBDataSet5TableAdapters.StatusTableAdapter statusTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn depIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button insertQr;
    }
}