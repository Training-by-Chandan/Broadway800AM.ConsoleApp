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
    public partial class SubjectManagement : Form
    {
        private ClassService classService = new ClassService();
        private SubjectService subjectService = new SubjectService();

        public SubjectManagement()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            ClassCmb.DataSource = classService.GetAllClassName();
            ClassCmb.Refresh();

            SubjectGrid.DataSource = subjectService.GetAllSubjects();
            SubjectGrid.Refresh();
        }

        private void SubjectManagement_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ClearFields()
        {
            SubCodeText.Text = string.Empty;
            SubNameText.Text = string.Empty;
            ClassCmb.SelectedIndex = 0;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            var model = new SubjectCreateViewModel()
            {
                Code = SubCodeText.Text,
                Name = SubNameText.Text,
                Class = ClassCmb.SelectedItem.ToString()
            };
            var res = subjectService.CreateSubject(model);

            if (res.Status)
            {
                ClearFields();
                LoadData();
            }
            else
            {
                MessageBox.Show(res.Message);
            }
        }
    }
}