using Synergy.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunPro.CW2._00016268
{
    public partial class EmployeeEditForm : Form
    {
        public EmployeeEditForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        public Employee Course { get; set; }

        public FormMode Mode { get; set; }

        public void CreateNewEmployee()
        {
            Mode = FormMode.CreateNew;
            Course = new Employee();
            InitializeControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        public void UpdateEmployee(Employee employee)
        {
            Mode = FormMode.Update;
            Course = employee;
            InitializeControls();
            ShowCourseInControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        private void InitializeControls()
        {
        }

        private void ShowCourseInControls()
        {
        }

        private void GrabUserInput()
        {
        }

    }
}
