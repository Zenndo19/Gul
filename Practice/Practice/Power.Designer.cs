namespace Practice
{
    partial class Power
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
            this.powertoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tool_storageDataSet1 = new Practice.Tool_storageDataSet1();
            this.power_toolTableAdapter = new Practice.Tool_storageDataSet1TableAdapters.power_toolTableAdapter();
            this.but = new System.Windows.Forms.Button();
            this.tbmp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powertoolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tool_storageDataSet1)).BeginInit();
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
            this.dgv.DataSource = this.powertoolBindingSource;
            this.dgv.Location = new System.Drawing.Point(12, 41);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(776, 184);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
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
            // powertoolBindingSource
            // 
            this.powertoolBindingSource.DataMember = "power_tool";
            this.powertoolBindingSource.DataSource = this.tool_storageDataSet1;
            // 
            // tool_storageDataSet1
            // 
            this.tool_storageDataSet1.DataSetName = "Tool_storageDataSet1";
            this.tool_storageDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // power_toolTableAdapter
            // 
            this.power_toolTableAdapter.ClearBeforeFill = true;
            // 
            // but
            // 
            this.but.Location = new System.Drawing.Point(713, 9);
            this.but.Name = "but";
            this.but.Size = new System.Drawing.Size(75, 23);
            this.but.TabIndex = 1;
            this.but.Text = "Поиск";
            this.but.UseVisualStyleBackColor = true;
            this.but.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbmp
            // 
            this.tbmp.Location = new System.Drawing.Point(12, 12);
            this.tbmp.Name = "tbmp";
            this.tbmp.Size = new System.Drawing.Size(695, 20);
            this.tbmp.TabIndex = 2;
            // 
            // Power
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 241);
            this.Controls.Add(this.tbmp);
            this.Controls.Add(this.but);
            this.Controls.Add(this.dgv);
            this.Name = "Power";
            this.Text = "Электроинструменты";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powertoolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tool_storageDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private Tool_storageDataSet1 tool_storageDataSet1;
        private System.Windows.Forms.BindingSource powertoolBindingSource;
        private Tool_storageDataSet1TableAdapters.power_toolTableAdapter power_toolTableAdapter;
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