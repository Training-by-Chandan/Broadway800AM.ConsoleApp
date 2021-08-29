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
                    Password = PasswordText.Text
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

                //remove the create and clear and add edit and delete button
                CreateBtn.Visible = false;
                ClearBtn.Visible = false;
                EditBtn.Visible = true;
                DeleteBtn.Visible = true;
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
                EditBtn.Visible = false;
                DeleteBtn.Visible = false;
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
    }
}