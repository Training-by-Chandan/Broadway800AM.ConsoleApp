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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username cannot be blank");
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password cannot be blank");
            }
            if (txtUsername.Text == "Chandan" && txtPassword.Text == "Test@123")
            {
                ANewForm newform = new ANewForm();
                newform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password did not match");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtPassword.Text = "";
            this.txtUsername.Text = "";
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = ConfigurationManager.AppSettings["AppName"];
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            this.lblMove.Text = $"X={this.Location.X}, Y={this.Location.Y}";
        }
    }
}