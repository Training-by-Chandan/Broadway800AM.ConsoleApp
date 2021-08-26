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

        void ClearTextFields()
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
                }
                MessageBox.Show(res.Message);
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
    }
}