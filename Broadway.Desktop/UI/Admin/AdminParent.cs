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
    public partial class AdminParent : Form
    {
        public AdminParent()
        {
            InitializeComponent();
            var name = Properties.Settings.Default.Name;
        }

        private void manageStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentCreate sc = new StudentCreate();
            sc.MdiParent = this;
            sc.Show();
        }

        private void classManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassManagement sc = new ClassManagement();
            sc.MdiParent = this;
            sc.Show();
        }

        private void subjectManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubjectManagement sc = new SubjectManagement();
            sc.MdiParent = this;
            sc.Show();
        }

        private void AdminParent_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Settings.Default.Name + " - " + Properties.Settings.Default.Email;
        }
    }
}