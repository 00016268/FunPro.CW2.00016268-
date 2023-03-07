namespace FunPro.CW2._00016268
{
    partial class EmployeeListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.emid16268DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emname16268DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emisactive16268DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emstartdate16268DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emdischargedate16268DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.swipeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emid16268DataGridViewTextBoxColumn,
            this.emname16268DataGridViewTextBoxColumn,
            this.emisactive16268DataGridViewTextBoxColumn,
            this.emstartdate16268DataGridViewTextBoxColumn,
            this.emdischargedate16268DataGridViewTextBoxColumn,
            this.swipeDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.employeeBindingSource;
            this.dgv.Location = new System.Drawing.Point(1, 1);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(870, 403);
            this.dgv.TabIndex = 0;
            
            // 
            // emid16268DataGridViewTextBoxColumn
            // 
            this.emid16268DataGridViewTextBoxColumn.DataPropertyName = "em_id_16268";
            this.emid16268DataGridViewTextBoxColumn.HeaderText = "em_id_16268";
            this.emid16268DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emid16268DataGridViewTextBoxColumn.Name = "emid16268DataGridViewTextBoxColumn";
            this.emid16268DataGridViewTextBoxColumn.ReadOnly = true;
            this.emid16268DataGridViewTextBoxColumn.Width = 125;
            // 
            // emname16268DataGridViewTextBoxColumn
            // 
            this.emname16268DataGridViewTextBoxColumn.DataPropertyName = "em_name_16268";
            this.emname16268DataGridViewTextBoxColumn.HeaderText = "em_name_16268";
            this.emname16268DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emname16268DataGridViewTextBoxColumn.Name = "emname16268DataGridViewTextBoxColumn";
            this.emname16268DataGridViewTextBoxColumn.ReadOnly = true;
            this.emname16268DataGridViewTextBoxColumn.Width = 140;
            // 
            // emisactive16268DataGridViewTextBoxColumn
            // 
            this.emisactive16268DataGridViewTextBoxColumn.DataPropertyName = "em_is_active_16268";
            this.emisactive16268DataGridViewTextBoxColumn.HeaderText = "em_is_active_16268";
            this.emisactive16268DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emisactive16268DataGridViewTextBoxColumn.Name = "emisactive16268DataGridViewTextBoxColumn";
            this.emisactive16268DataGridViewTextBoxColumn.ReadOnly = true;
            this.emisactive16268DataGridViewTextBoxColumn.Width = 140;
            // 
            // emstartdate16268DataGridViewTextBoxColumn
            // 
            this.emstartdate16268DataGridViewTextBoxColumn.DataPropertyName = "em_start_date_16268";
            this.emstartdate16268DataGridViewTextBoxColumn.HeaderText = "em_start_date_16268";
            this.emstartdate16268DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emstartdate16268DataGridViewTextBoxColumn.Name = "emstartdate16268DataGridViewTextBoxColumn";
            this.emstartdate16268DataGridViewTextBoxColumn.ReadOnly = true;
            this.emstartdate16268DataGridViewTextBoxColumn.Width = 140;
            // 
            // emdischargedate16268DataGridViewTextBoxColumn
            // 
            this.emdischargedate16268DataGridViewTextBoxColumn.DataPropertyName = "em_discharge_date_16268";
            this.emdischargedate16268DataGridViewTextBoxColumn.HeaderText = "em_discharge_date_16268";
            this.emdischargedate16268DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emdischargedate16268DataGridViewTextBoxColumn.Name = "emdischargedate16268DataGridViewTextBoxColumn";
            this.emdischargedate16268DataGridViewTextBoxColumn.ReadOnly = true;
            this.emdischargedate16268DataGridViewTextBoxColumn.Width = 150;
            // 
            // swipeDataGridViewTextBoxColumn
            // 
            this.swipeDataGridViewTextBoxColumn.DataPropertyName = "Swipe";
            this.swipeDataGridViewTextBoxColumn.HeaderText = "Swipe";
            this.swipeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.swipeDataGridViewTextBoxColumn.Name = "swipeDataGridViewTextBoxColumn";
            this.swipeDataGridViewTextBoxColumn.ReadOnly = true;
            this.swipeDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Synergy.DAL.Employee);
            // 
            // EmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.dgv);
            this.Name = "EmployeeListForm";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.EmployeeListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn emid16268DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emname16268DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emisactive16268DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emstartdate16268DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emdischargedate16268DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn swipeDataGridViewTextBoxColumn;
    }
}