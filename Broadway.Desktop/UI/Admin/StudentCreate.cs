using Broadway.Desktop.Data.Models;
using Broadway.Desktop.Service;
using Broadway.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broadway.Desktop.UI.Admin
{
    public partial class StudentCreate : Form
    {
        private StudentService student = new StudentService();
        private UserService user = new UserService();
        private ClassService classService = new ClassService();

        public StudentCreate()
        {
            InitializeComponent();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }

        private void ClearTextFields()
        {
            NameText.Text = string.Empty;
            DOBDate.Value = DateTime.Now;
            AddressText.Text = string.Empty;
            EmailText.Text = string.Empty;
            PasswordText.Text = string.Empty;
            ConfirmText.Text = string.Empty;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                var studentModel = new StudentCreateViewModel()
                {
                    Address = AddressText.Text,
                    Dob = DOBDate.Value,
                    Email = EmailText.Text,
                    Name = NameText.Text,
                    Password = PasswordText.Text,
                    Gender = maleGender.Checked ? Gender.Male : femaleGender.Checked ? Gender.Female : Gender.Others,
                    ClassName = ClassCmb.SelectedItem.ToString()
                };

                var res = student.CreateStudent(studentModel);
                if (res.Status)
                {
                    ClearTextFields();
                    LoadData();
                }
                else
                {
                    MessageBox.Show(res.Message);
                }
            }
        }

        private bool ValidateFields()
        {
            if (PasswordText.Text == ConfirmText.Text)
            {
                return true;
            }
            return false;
        }

        private void LoadData(string searchstr = "")
        {
            studentDataGrid.DataSource = student.GetAllStudentList(searchstr);
            studentDataGrid.Refresh();

            ClassCmb.DataSource = classService.GetAllClassName();
            ClassCmb.Refresh();
        }

        private void StudentCreate_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            LoadData(SearchText.Text);
        }

        private void studentDataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (studentDataGrid.SelectedRows.Count > 0)
            {
                //loaded the data in text fields
                var selectedRow = studentDataGrid.SelectedRows[0];
                labelid.Text = selectedRow.Cells["Id"].Value.ToString();
                NameText.Text = selectedRow.Cells["Name"].Value.ToString();
                AddressText.Text = selectedRow.Cells["Address"].Value.ToString();
                DOBDate.Value = Convert.ToDateTime(selectedRow.Cells["Dob"].Value.ToString());
                EmailText.Text = selectedRow.Cells["Email"].Value.ToString();

                //remove the create and clear and add edit and delete button
                CreateBtn.Visible = false;
                ClearBtn.Visible = false;
                EmailText.Visible = false;
                PasswordText.Visible = false;
                ConfirmText.Visible = false;
                Emaillbl.Visible = false;
                Passwordlbl.Visible = false;
                Confirmlbl.Visible = false;

                EditBtn.Visible = true;
                DeleteBtn.Visible = true;
                ResetBtn.Visible = true;
            }
        }

        private void studentDataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (studentDataGrid.SelectedRows.Count == 0)
            {
                ClearTextFields();

                //remove the edit and delete button and addd create and clear button
                CreateBtn.Visible = true;
                ClearBtn.Visible = true;
                EmailText.Visible = true;
                PasswordText.Visible = true;
                ConfirmText.Visible = true;
                Emaillbl.Visible = true;
                Passwordlbl.Visible = true;
                Confirmlbl.Visible = true;

                EditBtn.Visible = false;
                DeleteBtn.Visible = false;
                ResetBtn.Visible = false;
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(labelid.Text);
            var res = student.DeleteStudent(id);
            if (res.Status)
            {
                LoadData();
                studentDataGrid_MouseClick(null, null);
            }
            else
            {
                MessageBox.Show(res.Message);
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure?", "Reset Password", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                var result = user.ResetPassword(EmailText.Text);

                MessageBox.Show(result.Message);

                //call reset password
            }
        }
    }
}