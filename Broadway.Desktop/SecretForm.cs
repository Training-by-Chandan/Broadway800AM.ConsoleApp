using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broadway.Desktop
{
    public partial class SecretForm : Form
    {
        public SecretForm()
        {
            InitializeComponent();
        }

        private void SecretForm_Load(object sender, EventArgs e)
        {
            NameText.Text = Properties.Settings.Default.Name;
            EmailText.Text = Properties.Settings.Default.Email;
            ConnectionText.Text = Properties.Settings.Default.DefaultConnectionString;

            TestStringText.Text = Properties.Resources.TestString;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Name = NameText.Text;
            Properties.Settings.Default.Email = EmailText.Text;
            Properties.Settings.Default.DefaultConnectionString = ConnectionText.Text;

            Properties.Settings.Default.Save();
        }
    }
}