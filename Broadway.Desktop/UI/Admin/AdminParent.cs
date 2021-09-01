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
    }
}