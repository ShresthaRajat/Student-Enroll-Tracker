using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Coursework
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            BindGrid();
            dtpDOB.Format = DateTimePickerFormat.Custom;
            dtpRDate.Format = DateTimePickerFormat.Custom;
            dtpDOB.CustomFormat = "dd MMM yyyy";
            dtpRDate.CustomFormat = "dd MMM yyyy";
            dtpDOB.Value = DateTime.Parse("1/1/2000");
            dtpRDate.Value = DateTime.Now;
            dtpRDate.Enabled = false;
            txtID.Enabled = false;                                   
            btnSortNameD.Enabled = false;
            btnSortRegDateD.Enabled = false;
            cbGender.SelectedItem = null;
            cbGender.SelectedText = "--select--";
            cbStatus.SelectedItem = "Pending";
            cbStatus.Enabled = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnNew.Visible = false;
            btnSortRegDateD.Visible = false;
            lblsort1.Visible = true;
            lblsort2.Visible = true;
            btnSortName.Visible = true;
            btnSortRegDate.Visible = true;
            btnSortNameD.Visible = false;
            dataGridStudents.RowHeadersVisible = false;
            dataGridStudents2.RowHeadersVisible = false;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                Student obj = new Student();
                string fName = txtFirstName.Text;
                string lName = txtLastName.Text;
                obj.Name = fName + " " + lName;
                obj.Address = txtAddress.Text;
                obj.Email = txtEmail.Text;
                obj.BirthDate = dtpDOB.Value.Date;
                obj.ContactNo = txtPhone.Text;
                obj.Gender = cbGender.SelectedItem.ToString();
                obj.RDate = dtpRDate.Value.Date;
                obj.Course = cbCourse.SelectedItem.ToString();
                obj.Status = cbStatus.SelectedItem.ToString();
                lblsort1.Visible = true;
                lblsort2.Visible = true;
                btnSortName.Visible = true;
                btnSortRegDate.Visible = true;

                obj.Add(obj);
                Clear();
                BindGrid();
            }
        }
                
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                Student obj = new Student();
                obj.Id = int.Parse(txtID.Text);
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                obj.Name = firstName + " " + lastName;
                obj.Address = txtAddress.Text;
                obj.Email = txtEmail.Text;
                obj.BirthDate = dtpDOB.Value.Date;
                obj.ContactNo = txtPhone.Text;
                obj.Gender = cbGender.SelectedItem.ToString();
                obj.RDate = dtpRDate.Value.Date;
                obj.Course = cbCourse.SelectedItem.ToString();
                obj.Status = cbStatus.SelectedItem.ToString();
                obj.Edit(obj);
                BindGrid();
                Clear();
                btnSubmit.Visible = true;
                btnClear.Visible = true;
                txtID.Enabled = false;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
                btnNew.Visible = false;
                dtpRDate.Enabled = true;
                lblsort1.Visible = true;
                lblsort2.Visible = true;
                btnSortName.Visible = true;
                btnSortRegDate.Visible = true;
                cbStatus.Enabled = false;
            }
            
        }

        private void dataGridStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string value = dataGridStudents[0, e.RowIndex].Value.ToString();
                if (String.IsNullOrEmpty(value))
                {
                    btnSubmit.Visible = true;
                    btnClear.Visible = true;
                    btnEdit.Visible = false;
                    btnDelete.Visible = false;
                    Clear();
                }
                else
                {
                    btnSubmit.Visible = false;
                    btnClear.Visible = false;
                    txtID.Enabled = true;
                    btnEdit.Visible = true;
                    btnDelete.Visible = true;
                    btnNew.Visible = true;
                    dtpRDate.Enabled = true;
                    cbStatus.Enabled = true;

                    int indexRow;
                    indexRow = e.RowIndex;

                    DataGridViewRow row = dataGridStudents.Rows[indexRow];
                    List<String> tempName = (row.Cells[1].Value.ToString()).Split().ToList();
                    txtFirstName.Text = tempName[0];
                    txtLastName.Text = tempName[1];
                    txtID.Text = row.Cells[0].Value.ToString();
                    txtAddress.Text = row.Cells[2].Value.ToString();
                    txtEmail.Text = row.Cells[3].Value.ToString();
                    dtpDOB.Value = DateTime.Parse(row.Cells[4].Value.ToString());
                    txtPhone.Text = row.Cells[5].Value.ToString();
                    cbGender.Text = row.Cells[6].Value.ToString();
                    dtpRDate.Value = DateTime.Parse(row.Cells[7].Value.ToString());
                    cbCourse.Text = row.Cells[8].Value.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Try using the sort button insted of this!");
            }

        }
            
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            Student obj = new Student();
            obj.Id = int.Parse(txtID.Text);
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string name = firstName + " " + lastName;
            string word = "Do you want to Delete the Record of " + name + "?";
            string title = "Are you sure that you want to Delete the Record?";
            MessageBoxButtons btn = MessageBoxButtons.OKCancel;
            DialogResult outcome = MessageBox.Show(word, title, btn);
            if (outcome == DialogResult.OK)
            {
                obj.Delete(obj);
                BindGrid();
                Clear();
            }
            
        } 

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
            btnSubmit.Visible = true;
            btnClear.Visible = true;
            txtID.Enabled = false;
            dtpRDate.Enabled = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnNew.Visible = false;
        } 

        private void btnSortName_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            List<Student> student_list = obj.List();
            int total_Students = student_list.Count();
            int right, left;

            for (right = 1; right < total_Students; right++)
            {
                Student right_student = student_list[right];
                left = right - 1;

                while (left >= 0 && string.Compare(student_list[left].Name, right_student.Name) > 0)
                {
                    student_list[left + 1] = student_list[left];
                    left = left - 1;
                }
                student_list[left + 1] = right_student;
            }
            DataTable dt = Utility.ConvertToDataTable(student_list);
            dataGridStudents.DataSource = dt;
            btnSortName.Visible = false;
            btnSortName.Enabled = false;
            btnSortNameD.Visible = true;
            btnSortNameD.Enabled = true;
        }

        private void btnSortRegDate_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            List<Student> student_list = obj.List();
            int total_Students = student_list.Count();
            int right, left;

            for (right = 1; right < total_Students; right++)
            {
                Student right_student = student_list[right];
                left = right - 1;

                while (left >= 0 && DateTime.Compare(student_list[left].RDate, right_student.RDate) > 0)
                {
                    student_list[left + 1] = student_list[left];
                    left = left - 1;
                }
                student_list[left + 1] = right_student;
            }
            DataTable dt = Utility.ConvertToDataTable(student_list);
            dataGridStudents.DataSource = dt;
            btnSortRegDate.Enabled = false;
            btnSortRegDate.Visible = false;
            btnSortRegDateD.Enabled = true;
            btnSortRegDateD.Visible = true;
        }

        private void btnSortNameD_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            List<Student> student_list = obj.List();
            int total_Students = student_list.Count();
            int right, left;

            for (right = 1; right < total_Students; right++)
            {
                Student right_student = student_list[right];
                left = right - 1;

                while (left >= 0 && string.Compare(student_list[left].Name, right_student.Name) < 0)
                {
                    student_list[left + 1] = student_list[left];
                    left = left - 1;
                }
                student_list[left + 1] = right_student;
            }
            DataTable dt = Utility.ConvertToDataTable(student_list);
            dataGridStudents.DataSource = dt;
            btnSortName.Visible = true;
            btnSortName.Enabled = true;
            btnSortNameD.Visible = false;
            btnSortNameD.Enabled = false;
        }

        private void btnSortRegDateD_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            List<Student> student_list = obj.List();
            int total_Students = student_list.Count();
            int right, left;

            for (right = 1; right < total_Students; right++)
            {
                Student right_student = student_list[right];
                left = right - 1;

                while (left >= 0 && DateTime.Compare(student_list[left].RDate, right_student.RDate) < 0)
                {
                    student_list[left + 1] = student_list[left];
                    left = left - 1;
                }
                student_list[left + 1] = right_student;
            }
            DataTable dt = Utility.ConvertToDataTable(student_list);
            dataGridStudents.DataSource = dt;
            btnSortRegDate.Enabled = true;
            btnSortRegDate.Visible = true;
            btnSortRegDateD.Enabled = false;
            btnSortRegDateD.Visible = false;
        }

        private void weeklyDateTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime start = weeklyDateTime.Value.Date;
            DateTime end = start.AddDays(7);
            Student obj = new Student();
            List<Student> listStudents = obj.List(); 
            try
            {
                List<Student> stu = listStudents.Where(x => x.RDate >= start).Where(x => x.RDate <= end).ToList();
                DataTable tableData = Utility.ConvertToDataTable(stu);
                dataGridStudents2.DataSource = tableData;

                var weeklyEnrolled = listStudents
                    .Where(reg => reg.RDate >= start && reg.RDate <= end)
                    .GroupBy(course => course.Course)
                    .Select(x => new
                    {
                        Program = x.First().Course,
                        Count = x.Count().ToString()
                    }).ToList();
                DataTable dt = Utility.ConvertToDataTable(weeklyEnrolled);
                dgWeekly.DataSource = dt;

                foreach (DataGridViewColumn c in dgWeekly.Columns)
                {
                    c.DefaultCellStyle.Font = new Font("Arial", 22F, GraphicsUnit.Pixel);
                }
                dgWeekly.Columns[0].Width = 400;
                dgWeekly.Columns[1].Width = 150;

                dataGridStudents2.Columns[0].Width = 40;
                dataGridStudents2.Columns[1].Width = 100;
                dataGridStudents2.Columns[2].Width = 80;
                dataGridStudents2.Columns[3].Width = 150;
                dataGridStudents2.Columns[4].Width = 80;
                dataGridStudents2.Columns[5].Width = 90;
                dataGridStudents2.Columns[6].Width = 78;
                dataGridStudents2.Columns[7].Width = 73;
                dataGridStudents2.Columns[8].Width = 70;
                dataGridStudents2.Columns[9].Width = 85;
            }
            catch
            {
                MessageBox.Show("No Data to view!");
            }
        }

        private void BindChart(List<Student> lst)
        {
            try
            {
                var result = lst
               .GroupBy(l => l.Course)
               .Select(cl => new
               {
                   Course = cl.First().Course,
                   count = cl.Count().ToString()
               }).ToList();

                DataTable dt = Utility.ConvertToDataTable(result);
                chart.DataSource = dt;
                chart.Name = "Course";
                chart.Series["Series1"].XValueMember = "Course";
                chart.Series["Series1"].YValueMembers = "Count";
                chart.Series["Series1"].IsValueShownAsLabel = true;
                chart.Series["Series1"].Font = new Font("Arial", 30F, GraphicsUnit.Pixel);
            }
            catch
            {
                MessageBox.Show("No Data to view!");
            }
        }

        private void BindGrid()
        {
            Student obj = new Student();
            List<Student> listStudents = obj.List();
            DataTable dt = Utility.ConvertToDataTable(listStudents);
            dataGridStudents.DataSource = dt;
            dataGridStudents.Columns[0].Width = 40;
            dataGridStudents.Columns[1].Width = 100;
            dataGridStudents.Columns[2].Width = 80;
            dataGridStudents.Columns[3].Width = 150;
            dataGridStudents.Columns[4].Width = 80;
            dataGridStudents.Columns[5].Width = 90;
            dataGridStudents.Columns[6].Width = 78;
            dataGridStudents.Columns[7].Width = 73;
            dataGridStudents.Columns[8].Width = 70;
            dataGridStudents.Columns[9].Width = 85;

            BindChart(listStudents);
        }

        private void Clear()
        {
            txtFirstName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtID.Text = String.Empty;
            cbGender.SelectedItem = null;
            lblsort1.Visible = true;
            lblsort2.Visible = true;
            btnSortName.Visible = true;
            btnSortName.Enabled = true;
            btnSortRegDate.Visible = true;
            btnSortNameD.Visible = false;
            btnSortNameD.Enabled = false;
            btnSortRegDateD.Enabled = false;
            btnSortRegDateD.Visible = false;
            cbGender.SelectedText = "--select--";
            dtpDOB.Value = DateTime.Parse("1/1/2000");
            dtpRDate.Value = DateTime.Now;
            cbStatus.Enabled = false;
        }

        private Boolean Validation()
        {
            if (txtFirstName.Text != "")
            {
                if (txtLastName.Text != "")
                {
                    if (txtAddress.Text != "")
                    {
                        if (txtEmail.Text != "")
                        {
                            if (txtPhone.Text != "")
                            {
                                if (cbGender.SelectedItem != null)
                                {
                                    if (cbCourse.SelectedItem != null)
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Select Gender", "No gender ERROR");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Select Gender", "No gender ERROR");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter your Phone Number", "No phone number ERROR");
                            }
                        }
                        else
                        {
                            MessageBox.Show(txtFirstName.Text + "Please enter your Email", "No email ERROR");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter your address", "No address ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter your last name", "No name ERROR");
                }
            }
            else
            {
                MessageBox.Show("Please enter your first name", "No name ERROR");
            }
            return false;
        }
    }
 }
