namespace Coursework
{
    partial class StudentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.fName = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.Gender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.errorTxt = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridStudents = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSortRegDateD = new System.Windows.Forms.Button();
            this.btnSortNameD = new System.Windows.Forms.Button();
            this.dtpRDate = new System.Windows.Forms.DateTimePicker();
            this.lblsort2 = new System.Windows.Forms.Label();
            this.lblsort1 = new System.Windows.Forms.Label();
            this.btnSortRegDate = new System.Windows.Forms.Button();
            this.btnSortName = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridStudents2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.weeklyDateTime = new System.Windows.Forms.DateTimePicker();
            this.dgWeekly = new System.Windows.Forms.DataGridView();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWeekly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Location = new System.Drawing.Point(96, 64);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(76, 17);
            this.fName.TabIndex = 0;
            this.fName.Text = "First Name";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(583, 209);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(89, 30);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(179, 64);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(441, 100);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 6;
            this.Email.Text = "Email";
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Location = new System.Drawing.Point(441, 137);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(38, 17);
            this.DOB.TabIndex = 7;
            this.DOB.Text = "DOB";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(96, 137);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(75, 17);
            this.Phone.TabIndex = 8;
            this.Phone.Text = "Phone No.";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(524, 100);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(179, 137);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 22);
            this.txtPhone.TabIndex = 5;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(441, 61);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(76, 17);
            this.lName.TabIndex = 13;
            this.lName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(525, 61);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(199, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(96, 99);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(60, 17);
            this.address.TabIndex = 15;
            this.address.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(179, 100);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 22);
            this.txtAddress.TabIndex = 3;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarTrailingForeColor = System.Drawing.SystemColors.Highlight;
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpDOB.Location = new System.Drawing.Point(524, 137);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 22);
            this.dtpDOB.TabIndex = 6;
            this.dtpDOB.Value = new System.DateTime(1998, 6, 9, 0, 0, 0, 0);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(96, 174);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(56, 17);
            this.Gender.TabIndex = 18;
            this.Gender.Text = "Gender";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cbGender.Location = new System.Drawing.Point(179, 172);
            this.cbGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(121, 24);
            this.cbGender.TabIndex = 7;
            // 
            // errorTxt
            // 
            this.errorTxt.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Student Registration";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(460, 209);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 30);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(415, 252);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 30);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(878, 61);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(90, 22);
            this.txtID.TabIndex = 25;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(635, 252);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 30);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(797, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "ID";
            // 
            // dataGridStudents
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dataGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridStudents.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridStudents.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridStudents.Location = new System.Drawing.Point(0, 296);
            this.dataGridStudents.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.RowHeadersWidth = 51;
            this.dataGridStudents.Size = new System.Drawing.Size(1156, 344);
            this.dataGridStudents.TabIndex = 21;
            this.dataGridStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStudents_CellClick);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(527, 252);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(89, 30);
            this.btnNew.TabIndex = 29;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cbCourse
            // 
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Items.AddRange(new object[] {
            "Computing",
            "Networking",
            "Multimedia"});
            this.cbCourse.Location = new System.Drawing.Point(878, 137);
            this.cbCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(137, 24);
            this.cbCourse.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(795, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Course";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(2, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1168, 665);
            this.tabControl.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbStatus);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnSortRegDateD);
            this.tabPage1.Controls.Add(this.btnSortNameD);
            this.tabPage1.Controls.Add(this.dtpRDate);
            this.tabPage1.Controls.Add(this.lblsort2);
            this.tabPage1.Controls.Add(this.lblsort1);
            this.tabPage1.Controls.Add(this.btnSortRegDate);
            this.tabPage1.Controls.Add(this.btnSortName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbCourse);
            this.tabPage1.Controls.Add(this.dataGridStudents);
            this.tabPage1.Controls.Add(this.fName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnSubmit);
            this.tabPage1.Controls.Add(this.btnNew);
            this.tabPage1.Controls.Add(this.txtFirstName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Email);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.DOB);
            this.tabPage1.Controls.Add(this.Phone);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.txtPhone);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.lName);
            this.tabPage1.Controls.Add(this.txtLastName);
            this.tabPage1.Controls.Add(this.address);
            this.tabPage1.Controls.Add(this.cbGender);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.Gender);
            this.tabPage1.Controls.Add(this.dtpDOB);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1160, 636);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registration";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Enrolled",
            "Pending"});
            this.cbStatus.Location = new System.Drawing.Point(878, 96);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 24);
            this.cbStatus.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(795, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Status";
            // 
            // btnSortRegDateD
            // 
            this.btnSortRegDateD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortRegDateD.Location = new System.Drawing.Point(960, 249);
            this.btnSortRegDateD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortRegDateD.Name = "btnSortRegDateD";
            this.btnSortRegDateD.Size = new System.Drawing.Size(89, 30);
            this.btnSortRegDateD.TabIndex = 39;
            this.btnSortRegDateD.Text = "RegDate";
            this.btnSortRegDateD.UseVisualStyleBackColor = true;
            this.btnSortRegDateD.Click += new System.EventHandler(this.btnSortRegDateD_Click);
            // 
            // btnSortNameD
            // 
            this.btnSortNameD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortNameD.Location = new System.Drawing.Point(67, 248);
            this.btnSortNameD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortNameD.Name = "btnSortNameD";
            this.btnSortNameD.Size = new System.Drawing.Size(89, 30);
            this.btnSortNameD.TabIndex = 38;
            this.btnSortNameD.Text = "Name";
            this.btnSortNameD.UseVisualStyleBackColor = true;
            this.btnSortNameD.Click += new System.EventHandler(this.btnSortNameD_Click);
            // 
            // dtpRDate
            // 
            this.dtpRDate.CalendarTrailingForeColor = System.Drawing.SystemColors.Highlight;
            this.dtpRDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpRDate.Location = new System.Drawing.Point(878, 174);
            this.dtpRDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpRDate.Name = "dtpRDate";
            this.dtpRDate.Size = new System.Drawing.Size(137, 22);
            this.dtpRDate.TabIndex = 37;
            this.dtpRDate.Value = new System.DateTime(1998, 6, 9, 0, 0, 0, 0);
            // 
            // lblsort2
            // 
            this.lblsort2.AutoSize = true;
            this.lblsort2.Location = new System.Drawing.Point(916, 256);
            this.lblsort2.Name = "lblsort2";
            this.lblsort2.Size = new System.Drawing.Size(38, 17);
            this.lblsort2.TabIndex = 36;
            this.lblsort2.Text = "Sort:";
            // 
            // lblsort1
            // 
            this.lblsort1.AutoSize = true;
            this.lblsort1.Location = new System.Drawing.Point(23, 256);
            this.lblsort1.Name = "lblsort1";
            this.lblsort1.Size = new System.Drawing.Size(38, 17);
            this.lblsort1.TabIndex = 35;
            this.lblsort1.Text = "Sort:";
            // 
            // btnSortRegDate
            // 
            this.btnSortRegDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortRegDate.Location = new System.Drawing.Point(960, 248);
            this.btnSortRegDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortRegDate.Name = "btnSortRegDate";
            this.btnSortRegDate.Size = new System.Drawing.Size(89, 30);
            this.btnSortRegDate.TabIndex = 34;
            this.btnSortRegDate.Text = "RegDate";
            this.btnSortRegDate.UseVisualStyleBackColor = true;
            this.btnSortRegDate.Click += new System.EventHandler(this.btnSortRegDate_Click);
            // 
            // btnSortName
            // 
            this.btnSortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortName.Location = new System.Drawing.Point(67, 248);
            this.btnSortName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Size = new System.Drawing.Size(89, 30);
            this.btnSortName.TabIndex = 33;
            this.btnSortName.Text = "Name";
            this.btnSortName.UseVisualStyleBackColor = true;
            this.btnSortName.Click += new System.EventHandler(this.btnSortName_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(797, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Reg Date:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.chart);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1160, 636);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Courses Enrolled";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridStudents2);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.weeklyDateTime);
            this.tabPage3.Controls.Add(this.dgWeekly);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1160, 636);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Weekly Enrolled";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridStudents2
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.dataGridStudents2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridStudents2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudents2.Location = new System.Drawing.Point(0, 310);
            this.dataGridStudents2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridStudents2.Name = "dataGridStudents2";
            this.dataGridStudents2.RowHeadersWidth = 51;
            this.dataGridStudents2.Size = new System.Drawing.Size(1156, 318);
            this.dataGridStudents2.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(386, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Select the date to view the weekly report";
            // 
            // weeklyDateTime
            // 
            this.weeklyDateTime.Location = new System.Drawing.Point(162, 78);
            this.weeklyDateTime.Name = "weeklyDateTime";
            this.weeklyDateTime.Size = new System.Drawing.Size(200, 22);
            this.weeklyDateTime.TabIndex = 1;
            this.weeklyDateTime.ValueChanged += new System.EventHandler(this.weeklyDateTime_ValueChanged);
            // 
            // dgWeekly
            // 
            this.dgWeekly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWeekly.Location = new System.Drawing.Point(162, 125);
            this.dgWeekly.Name = "dgWeekly";
            this.dgWeekly.RowHeadersWidth = 51;
            this.dgWeekly.RowTemplate.Height = 24;
            this.dgWeekly.Size = new System.Drawing.Size(807, 152);
            this.dgWeekly.TabIndex = 0;
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.AutoFitMinFontSize = 14;
            legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            legend3.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(6, 92);
            this.chart.Name = "chart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(1164, 548);
            this.chart.TabIndex = 26;
            this.chart.Text = "chart";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(426, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 29);
            this.label7.TabIndex = 27;
            this.label7.Text = "Total Students Enrolled";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 666);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWeekly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.ErrorProvider errorTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSortRegDate;
        private System.Windows.Forms.Button btnSortName;
        private System.Windows.Forms.Label lblsort2;
        private System.Windows.Forms.Label lblsort1;
        private System.Windows.Forms.DateTimePicker dtpRDate;
        private System.Windows.Forms.Button btnSortRegDateD;
        private System.Windows.Forms.Button btnSortNameD;
        private System.Windows.Forms.DataGridView dgWeekly;
        private System.Windows.Forms.DateTimePicker weeklyDateTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridStudents2;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataGridView dataGridStudents;
        private System.Windows.Forms.Label label7;
    }
}