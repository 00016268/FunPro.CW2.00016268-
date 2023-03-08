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
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();

            aboutForm.ShowDialog();
        }

        private void allManagersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<EmployeeListForm>().Show();
        }

        private void allSwipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<SwipeListForm>().Show();
        }

        private void newManagersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new EmployeeEditForm();
            form.CreateNewEmployee();
        }
    }
}
