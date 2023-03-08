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
            try
            {
                GrabUserInput();
                var manager = new EmployeeManager();
                if (Mode == FormMode.CreateNew)
                    manager.Create(Emp);
                else
                    manager.Update(Emp);

                MyForms.GetForm<EmployeeListForm>().LoadData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        public Employee Emp { get; set; }

        public FormMode Mode { get; set; }

        public void CreateNewEmployee()
        {
            Mode = FormMode.CreateNew;
            Emp = new Employee();
            InitializeControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        public void UpdateEmployee(Employee employee)
        {
            Mode = FormMode.Update;
            Emp = employee;
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
            tbxName.Text = Emp.em_name_16268;
            cbxActive.Text = Emp.em_is_active_16268;
            dtpStartDate.MaxDate = Emp.em_start_date_16268;
            dtpDischargeDate.MaxDate = Emp.em_discharge_date_16268;

        }

        private void GrabUserInput()
        {
            Emp.em_name_16268 = tbxName.Text;
            Emp.em_is_active_16268 = cbxActive.Text;
            Emp.em_start_date_16268 = dtpStartDate.MaxDate;
            Emp.em_discharge_date_16268 = dtpDischargeDate.MaxDate;
        }

        private void EmployeeEditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
