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
    public partial class EmployeeListForm : Form
    {
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }


        private void LoadData()
        {
            dgv.DataMember = "";
            dgv.DataSource = null;
            dgv.DataSource = new EmployeeManager().GetAll();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbxSort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {

            if (cbxSort.SelectedIndex < 0)
                MessageBox.Show("Select an attribute to sort by");
            else
            {
                ByAttribute selectedAttribute;
                if (cbxSort.SelectedIndex == 0)
                    selectedAttribute = ByAttribute.Name;
                else if (cbxSort.SelectedIndex == 1)
                    selectedAttribute = ByAttribute.Active;
                else if (cbxSort.SelectedIndex == 2)
                    selectedAttribute = ByAttribute.StartDate;
                else
                    selectedAttribute = ByAttribute.DischargeDate;

                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new EmployeeManager().Sort(selectedAttribute);
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbxSearch.SelectedIndex < 0)
                MessageBox.Show("Select an attribute to search by");
            else if (string.IsNullOrWhiteSpace(tbxSearch.Text))
                MessageBox.Show("Provide the search term");
            else
            {
                var selectedAttribute = cbxSearch.SelectedIndex == 0 ? ByAttribute.Name : ByAttribute.Active;

                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new EmployeeManager().Search(tbxSearch.Text, selectedAttribute);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new EmployeeEditForm();
            form.CreateNewEmployee();
        }
    }
    }





