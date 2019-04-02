namespace Practice
{
    partial class Hand
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
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handtoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tool_storageDataSet = new Practice.Tool_storageDataSet();
            this.hand_toolTableAdapter = new Practice.Tool_storageDataSetTableAdapters.hand_toolTableAdapter();
            this.but = new System.Windows.Forms.Button();
            this.tbmp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handtoolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tool_storageDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.articleDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.presenceDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.handtoolBindingSource;
            this.dgv.Location = new System.Drawing.Point(12, 39);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(654, 269);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "Article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "Article";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // presenceDataGridViewTextBoxColumn
            // 
            this.presenceDataGridViewTextBoxColumn.DataPropertyName = "Presence";
            this.presenceDataGridViewTextBoxColumn.HeaderText = "Presence";
            this.presenceDataGridViewTextBoxColumn.Name = "presenceDataGridViewTextBoxColumn";
            // 
            // handtoolBindingSource
            // 
            this.handtoolBindingSource.DataMember = "hand_tool";
            this.handtoolBindingSource.DataSource = this.tool_storageDataSet;
            // 
            // tool_storageDataSet
            // 
            this.tool_storageDataSet.DataSetName = "Tool_storageDataSet";
            this.tool_storageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hand_toolTableAdapter
            // 
            this.hand_toolTableAdapter.ClearBeforeFill = true;
            // 
            // but
            // 
            this.but.Location = new System.Drawing.Point(591, 10);
            this.but.Name = "but";
            this.but.Size = new System.Drawing.Size(75, 23);
            this.but.TabIndex = 1;
            this.but.Text = "Поиск";
            this.but.UseVisualStyleBackColor = true;
            this.but.Click += new System.EventHandler(this.but_Click);
            // 
            // tbmp
            // 
            this.tbmp.Location = new System.Drawing.Point(12, 10);
            this.tbmp.Name = "tbmp";
            this.tbmp.Size = new System.Drawing.Size(573, 20);
            this.tbmp.TabIndex = 2;
            // 
            // Hand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.but;
            this.ClientSize = new System.Drawing.Size(678, 320);
            this.Controls.Add(this.tbmp);
            this.Controls.Add(this.but);
            this.Controls.Add(this.dgv);
            this.Name = "Hand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ручные инструменты";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handtoolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tool_storageDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private Tool_storageDataSet tool_storageDataSet;
        private System.Windows.Forms.BindingSource handtoolBindingSource;
        private Tool_storageDataSetTableAdapters.hand_toolTableAdapter hand_toolTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button but;
        private System.Windows.Forms.TextBox tbmp;
    }
}