namespace Practice
{
    partial class InfTable
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
            this.tablenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservedKBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataKBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indexsizeKBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unusedKBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tool_storageDataSet3 = new Practice.Tool_storageDataSet3();
            this.tablTableAdapter = new Practice.Tool_storageDataSet3TableAdapters.TablTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tool_storageDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tablenameDataGridViewTextBoxColumn,
            this.rowsDataGridViewTextBoxColumn,
            this.reservedKBDataGridViewTextBoxColumn,
            this.dataKBDataGridViewTextBoxColumn,
            this.indexsizeKBDataGridViewTextBoxColumn,
            this.unusedKBDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tablenameDataGridViewTextBoxColumn
            // 
            this.tablenameDataGridViewTextBoxColumn.DataPropertyName = "table_name";
            this.tablenameDataGridViewTextBoxColumn.HeaderText = "table_name";
            this.tablenameDataGridViewTextBoxColumn.Name = "tablenameDataGridViewTextBoxColumn";
            this.tablenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rowsDataGridViewTextBoxColumn
            // 
            this.rowsDataGridViewTextBoxColumn.DataPropertyName = "rows";
            this.rowsDataGridViewTextBoxColumn.HeaderText = "rows";
            this.rowsDataGridViewTextBoxColumn.Name = "rowsDataGridViewTextBoxColumn";
            // 
            // reservedKBDataGridViewTextBoxColumn
            // 
            this.reservedKBDataGridViewTextBoxColumn.DataPropertyName = "reservedKB";
            this.reservedKBDataGridViewTextBoxColumn.HeaderText = "reservedKB";
            this.reservedKBDataGridViewTextBoxColumn.Name = "reservedKBDataGridViewTextBoxColumn";
            this.reservedKBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataKBDataGridViewTextBoxColumn
            // 
            this.dataKBDataGridViewTextBoxColumn.DataPropertyName = "dataKB";
            this.dataKBDataGridViewTextBoxColumn.HeaderText = "dataKB";
            this.dataKBDataGridViewTextBoxColumn.Name = "dataKBDataGridViewTextBoxColumn";
            this.dataKBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // indexsizeKBDataGridViewTextBoxColumn
            // 
            this.indexsizeKBDataGridViewTextBoxColumn.DataPropertyName = "index_sizeKB";
            this.indexsizeKBDataGridViewTextBoxColumn.HeaderText = "index_sizeKB";
            this.indexsizeKBDataGridViewTextBoxColumn.Name = "indexsizeKBDataGridViewTextBoxColumn";
            this.indexsizeKBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unusedKBDataGridViewTextBoxColumn
            // 
            this.unusedKBDataGridViewTextBoxColumn.DataPropertyName = "unusedKB";
            this.unusedKBDataGridViewTextBoxColumn.HeaderText = "unusedKB";
            this.unusedKBDataGridViewTextBoxColumn.Name = "unusedKBDataGridViewTextBoxColumn";
            this.unusedKBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tablBindingSource
            // 
            this.tablBindingSource.DataMember = "Tabl";
            this.tablBindingSource.DataSource = this.tool_storageDataSet3;
            // 
            // tool_storageDataSet3
            // 
            this.tool_storageDataSet3.DataSetName = "Tool_storageDataSet3";
            this.tool_storageDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablTableAdapter
            // 
            this.tablTableAdapter.ClearBeforeFill = true;
            // 
            // InfTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 168);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InfTable";
            this.Text = "Информация о таблицах";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tool_storageDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Tool_storageDataSet3 tool_storageDataSet3;
        private System.Windows.Forms.BindingSource tablBindingSource;
        private Tool_storageDataSet3TableAdapters.TablTableAdapter tablTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservedKBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataKBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexsizeKBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unusedKBDataGridViewTextBoxColumn;
    }
}