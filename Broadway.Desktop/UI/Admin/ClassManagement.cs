using Broadway.Desktop.Service;
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
    public partial class ClassManagement : Form
    {
        private ClassService classService = new ClassService();

        public ClassManagement()
        {
            InitializeComponent();
        }

        private void ClassManagement_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            classGrid.DataSource = classService.GetAllClass();
            classGrid.Refresh();
        }

        private void classGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selected = classGrid.SelectedRows.Count;
            if (selected > 0)
            {
                var selectedrow = classGrid.SelectedRows[0];
                var selectedId = Convert.ToInt32(selectedrow.Cells["Id"].Value.ToString());

                studentGrid.DataSource = classService.GetAllStudentByClassId(selectedId);
                studentGrid.Refresh();
            }
        }
    }
}