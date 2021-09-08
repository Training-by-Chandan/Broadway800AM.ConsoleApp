using Broadway.Desktop.UI.Admin;
using Broadway.Desktop.UI.Student;
using Broadway.Desktop.UI.Teacher;
using Broadway.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broadway.Desktop
{
    public partial class Form1 : Form
    {
        private Service.UserService user = new Service.UserService();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            var login = new LoginViewModel() { Username = this.txtUsername.Text, Password = this.txtPassword.Text };
            var result = user.Login(login);
            if (result.Status)
            {
                switch (result.Role)
                {
                    case Data.Models.Roles.Student:
                        StudentParent student = new StudentParent();
                        student.Show();
                        break;

                    case Data.Models.Roles.Teacher:
                        TeacherParent teacher = new TeacherParent();
                        teacher.Show();
                        break;

                    case Data.Models.Roles.Admin:
                        AdminParent admin = new AdminParent();
                        admin.Show();
                        break;

                    default:
                        break;
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtPassword.Text = "";
            this.txtUsername.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = ConfigurationManager.AppSettings["AppName"];
        }

        private int secretCount = 0;

        private void label1_Click(object sender, EventArgs e)
        {
            secretCount++;
            if (secretCount == 5)
            {
                SecretForm s = new SecretForm();
                s.Show();
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            secretCount = 0;
        }
    }
}