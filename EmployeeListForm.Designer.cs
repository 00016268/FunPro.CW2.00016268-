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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbxSort = new System.Windows.Forms.ComboBox();
            this.cbxSearch = new System.Windows.Forms.ComboBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
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
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgv.Location = new System.Drawing.Point(12, 2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(747, 263);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(805, 33);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(805, 81);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(805, 191);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(805, 138);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbxSort
            // 
            this.cbxSort.FormattingEnabled = true;
            this.cbxSort.Items.AddRange(new object[] {
            "Name"});
            this.cbxSort.Location = new System.Drawing.Point(29, 299);
            this.cbxSort.Name = "cbxSort";
            this.cbxSort.Size = new System.Drawing.Size(211, 24);
            this.cbxSort.TabIndex = 5;
            this.cbxSort.SelectedIndexChanged += new System.EventHandler(this.cbxSort_SelectedIndexChanged);
            // 
            // cbxSearch
            // 
            this.cbxSearch.FormattingEnabled = true;
            this.cbxSearch.Items.AddRange(new object[] {
            "Name"});
            this.cbxSearch.Location = new System.Drawing.Point(29, 344);
            this.cbxSearch.Name = "cbxSearch";
            this.cbxSearch.Size = new System.Drawing.Size(121, 24);
            this.cbxSearch.TabIndex = 6;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(165, 344);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 22);
            this.tbxSearch.TabIndex = 7;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(275, 299);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 10;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(275, 345);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.ClientSize = new System.Drawing.Size(1023, 482);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.cbxSearch);
            this.Controls.Add(this.cbxSort);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgv);
            this.Name = "EmployeeListForm";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.EmployeeListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbxSort;
        private System.Windows.Forms.ComboBox cbxSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSearch;
    }
}