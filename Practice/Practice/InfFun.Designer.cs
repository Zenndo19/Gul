namespace Practice
{
    partial class InfFun
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
            this.objectidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typedescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.definitionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usesansinullsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usesquotedidentifierDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isschemaboundDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.executeasprincipalidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tool_storageDataSet4 = new Practice.Tool_storageDataSet4();
            this.proTableAdapter = new Practice.Tool_storageDataSet4TableAdapters.proTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tool_storageDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.objectidDataGridViewTextBoxColumn,
            this.objectnameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.typedescDataGridViewTextBoxColumn,
            this.definitionDataGridViewTextBoxColumn,
            this.usesansinullsDataGridViewCheckBoxColumn,
            this.usesquotedidentifierDataGridViewCheckBoxColumn,
            this.isschemaboundDataGridViewCheckBoxColumn,
            this.executeasprincipalidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1000, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // objectidDataGridViewTextBoxColumn
            // 
            this.objectidDataGridViewTextBoxColumn.DataPropertyName = "object_id";
            this.objectidDataGridViewTextBoxColumn.HeaderText = "object_id";
            this.objectidDataGridViewTextBoxColumn.Name = "objectidDataGridViewTextBoxColumn";
            // 
            // objectnameDataGridViewTextBoxColumn
            // 
            this.objectnameDataGridViewTextBoxColumn.DataPropertyName = "object_name";
            this.objectnameDataGridViewTextBoxColumn.HeaderText = "object_name";
            this.objectnameDataGridViewTextBoxColumn.Name = "objectnameDataGridViewTextBoxColumn";
            this.objectnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // typedescDataGridViewTextBoxColumn
            // 
            this.typedescDataGridViewTextBoxColumn.DataPropertyName = "type_desc";
            this.typedescDataGridViewTextBoxColumn.HeaderText = "type_desc";
            this.typedescDataGridViewTextBoxColumn.Name = "typedescDataGridViewTextBoxColumn";
            // 
            // definitionDataGridViewTextBoxColumn
            // 
            this.definitionDataGridViewTextBoxColumn.DataPropertyName = "definition";
            this.definitionDataGridViewTextBoxColumn.HeaderText = "definition";
            this.definitionDataGridViewTextBoxColumn.Name = "definitionDataGridViewTextBoxColumn";
            this.definitionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usesansinullsDataGridViewCheckBoxColumn
            // 
            this.usesansinullsDataGridViewCheckBoxColumn.DataPropertyName = "uses_ansi_nulls";
            this.usesansinullsDataGridViewCheckBoxColumn.HeaderText = "uses_ansi_nulls";
            this.usesansinullsDataGridViewCheckBoxColumn.Name = "usesansinullsDataGridViewCheckBoxColumn";
            this.usesansinullsDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // usesquotedidentifierDataGridViewCheckBoxColumn
            // 
            this.usesquotedidentifierDataGridViewCheckBoxColumn.DataPropertyName = "uses_quoted_identifier";
            this.usesquotedidentifierDataGridViewCheckBoxColumn.HeaderText = "uses_quoted_identifier";
            this.usesquotedidentifierDataGridViewCheckBoxColumn.Name = "usesquotedidentifierDataGridViewCheckBoxColumn";
            this.usesquotedidentifierDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isschemaboundDataGridViewCheckBoxColumn
            // 
            this.isschemaboundDataGridViewCheckBoxColumn.DataPropertyName = "is_schema_bound";
            this.isschemaboundDataGridViewCheckBoxColumn.HeaderText = "is_schema_bound";
            this.isschemaboundDataGridViewCheckBoxColumn.Name = "isschemaboundDataGridViewCheckBoxColumn";
            this.isschemaboundDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // executeasprincipalidDataGridViewTextBoxColumn
            // 
            this.executeasprincipalidDataGridViewTextBoxColumn.DataPropertyName = "execute_as_principal_id";
            this.executeasprincipalidDataGridViewTextBoxColumn.HeaderText = "execute_as_principal_id";
            this.executeasprincipalidDataGridViewTextBoxColumn.Name = "executeasprincipalidDataGridViewTextBoxColumn";
            // 
            // proBindingSource
            // 
            this.proBindingSource.DataMember = "pro";
            this.proBindingSource.DataSource = this.tool_storageDataSet4;
            // 
            // tool_storageDataSet4
            // 
            this.tool_storageDataSet4.DataSetName = "Tool_storageDataSet4";
            this.tool_storageDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proTableAdapter
            // 
            this.proTableAdapter.ClearBeforeFill = true;
            // 
            // InfFun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 198);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InfFun";
            this.Text = "Информация о функциях";
            this.Load += new System.EventHandler(this.InfFun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tool_storageDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Tool_storageDataSet4 tool_storageDataSet4;
        private System.Windows.Forms.BindingSource proBindingSource;
        private Tool_storageDataSet4TableAdapters.proTableAdapter proTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typedescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn definitionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn usesansinullsDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn usesquotedidentifierDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isschemaboundDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn executeasprincipalidDataGridViewTextBoxColumn;
    }
}