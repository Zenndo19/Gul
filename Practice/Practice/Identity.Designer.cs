namespace Practice
{
    partial class Identity
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serv = new System.Windows.Forms.TextBox();
            this.bd = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сервер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "База данных";
            // 
            // serv
            // 
            this.serv.Location = new System.Drawing.Point(82, 25);
            this.serv.Name = "serv";
            this.serv.Size = new System.Drawing.Size(125, 20);
            this.serv.TabIndex = 2;
            this.serv.TextChanged += new System.EventHandler(this.serv_TextChanged);
            // 
            // bd
            // 
            this.bd.Location = new System.Drawing.Point(82, 64);
            this.bd.Name = "bd";
            this.bd.Size = new System.Drawing.Size(125, 20);
            this.bd.TabIndex = 3;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(82, 90);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(125, 23);
            this.save.TabIndex = 4;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Identity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 130);
            this.Controls.Add(this.save);
            this.Controls.Add(this.bd);
            this.Controls.Add(this.serv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Identity";
            this.Text = "Идентификация";
            this.Load += new System.EventHandler(this.Identity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serv;
        private System.Windows.Forms.TextBox bd;
        private System.Windows.Forms.Button save;
    }
}