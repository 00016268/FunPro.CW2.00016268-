namespace FunPro.CW2._00016268
{
    partial class SwipeListForm
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
            this.swipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spid16268DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spempid16268DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spdate16268DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spin16268DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spout16268DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swipeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.spid16268DataGridViewTextBoxColumn,
            this.spempid16268DataGridViewTextBoxColumn,
            this.spdate16268DataGridViewTextBoxColumn,
            this.spin16268DataGridViewTextBoxColumn,
            this.spout16268DataGridViewTextBoxColumn});
            this.dgv.DataSource = this.swipeBindingSource;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(676, 379);
            this.dgv.TabIndex = 0;
            // 
            // swipeBindingSource
            // 
            this.swipeBindingSource.DataSource = typeof(Synergy.DAL.Swipe);
            // 
            // spid16268DataGridViewTextBoxColumn
            // 
            this.spid16268DataGridViewTextBoxColumn.DataPropertyName = "sp_id_16268";
            this.spid16268DataGridViewTextBoxColumn.HeaderText = "sp_id_16268";
            this.spid16268DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.spid16268DataGridViewTextBoxColumn.Name = "spid16268DataGridViewTextBoxColumn";
            this.spid16268DataGridViewTextBoxColumn.ReadOnly = true;
            this.spid16268DataGridViewTextBoxColumn.Width = 125;
            // 
            // spempid16268DataGridViewTextBoxColumn
            // 
            this.spempid16268DataGridViewTextBoxColumn.DataPropertyName = "sp_emp_id_16268";
            this.spempid16268DataGridViewTextBoxColumn.HeaderText = "sp_emp_id_16268";
            this.spempid16268DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.spempid16268DataGridViewTextBoxColumn.Name = "spempid16268DataGridViewTextBoxColumn";
            this.spempid16268DataGridViewTextBoxColumn.ReadOnly = true;
            this.spempid16268DataGridViewTextBoxColumn.Width = 125;
            // 
            // spdate16268DataGridViewTextBoxColumn
            // 
            this.spdate16268DataGridViewTextBoxColumn.DataPropertyName = "sp_date_16268";
            this.spdate16268DataGridViewTextBoxColumn.HeaderText = "sp_date_16268";
            this.spdate16268DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.spdate16268DataGridViewTextBoxColumn.Name = "spdate16268DataGridViewTextBoxColumn";
            this.spdate16268DataGridViewTextBoxColumn.ReadOnly = true;
            this.spdate16268DataGridViewTextBoxColumn.Width = 125;
            // 
            // spin16268DataGridViewTextBoxColumn
            // 
            this.spin16268DataGridViewTextBoxColumn.DataPropertyName = "sp_in_16268";
            this.spin16268DataGridViewTextBoxColumn.HeaderText = "sp_in_16268";
            this.spin16268DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.spin16268DataGridViewTextBoxColumn.Name = "spin16268DataGridViewTextBoxColumn";
            this.spin16268DataGridViewTextBoxColumn.ReadOnly = true;
            this.spin16268DataGridViewTextBoxColumn.Width = 125;
            // 
            // spout16268DataGridViewTextBoxColumn
            // 
            this.spout16268DataGridViewTextBoxColumn.DataPropertyName = "sp_out_16268";
            this.spout16268DataGridViewTextBoxColumn.HeaderText = "sp_out_16268";
            this.spout16268DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.spout16268DataGridViewTextBoxColumn.Name = "spout16268DataGridViewTextBoxColumn";
            this.spout16268DataGridViewTextBoxColumn.ReadOnly = true;
            this.spout16268DataGridViewTextBoxColumn.Width = 125;
            // 
            // SwipeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv);
            this.Name = "SwipeListForm";
            this.Text = "Swipes";
            this.Load += new System.EventHandler(this.SwipeListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swipeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn spid16268DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spempid16268DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spdate16268DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spin16268DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spout16268DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource swipeBindingSource;
    }
}