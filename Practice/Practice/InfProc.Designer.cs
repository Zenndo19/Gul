namespace Practice
{
    partial class InfProc
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tool_storageDataSet5 = new Practice.Tool_storageDataSet5();
            this.prTableAdapter = new Practice.Tool_storageDataSet5TableAdapters.PrTableAdapter();
            this.tool_storageDataSet6 = new Practice.Tool_storageDataSet6();
            this.prBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prTableAdapter1 = new Practice.Tool_storageDataSet6TableAdapters.PrTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tool_storageDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tool_storageDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xtypeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(269, 245);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // xtypeDataGridViewTextBoxColumn
            // 
            this.xtypeDataGridViewTextBoxColumn.DataPropertyName = "xtype";
            this.xtypeDataGridViewTextBoxColumn.HeaderText = "xtype";
            this.xtypeDataGridViewTextBoxColumn.Name = "xtypeDataGridViewTextBoxColumn";
            this.xtypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // prBindingSource
            // 
            this.prBindingSource.DataMember = "Pr";
            this.prBindingSource.DataSource = this.tool_storageDataSet5;
            // 
            // tool_storageDataSet5
            // 
            this.tool_storageDataSet5.DataSetName = "Tool_storageDataSet5";
            this.tool_storageDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prTableAdapter
            // 
            this.prTableAdapter.ClearBeforeFill = true;
            // 
            // tool_storageDataSet6
            // 
            this.tool_storageDataSet6.DataSetName = "Tool_storageDataSet6";
            this.tool_storageDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prBindingSource1
            // 
            this.prBindingSource1.DataMember = "Pr";
            this.prBindingSource1.DataSource = this.tool_storageDataSet6;
            // 
            // prTableAdapter1
            // 
            this.prTableAdapter1.ClearBeforeFill = true;
            // 
            // InfProc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 269);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InfProc";
            this.Text = "Список процедур";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tool_storageDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tool_storageDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource prBindingSource;
        private Tool_storageDataSet5 tool_storageDataSet5;
        private Tool_storageDataSet5TableAdapters.PrTableAdapter prTableAdapter;
        private System.Windows.Forms.BindingSource prBindingSource1;
        private Tool_storageDataSet6 tool_storageDataSet6;
        private Tool_storageDataSet6TableAdapters.PrTableAdapter prTableAdapter1;
    }
}