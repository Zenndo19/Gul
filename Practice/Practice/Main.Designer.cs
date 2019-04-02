namespace Practice
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.электроинструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ручныеИнструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОТалицахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОФункцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПроцедурToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наименованияИнструментовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(713, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "Меню";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.электроинструментыToolStripMenuItem,
            this.ручныеИнструментыToolStripMenuItem,
            this.информацияОТалицахToolStripMenuItem,
            this.информацияОФункцияToolStripMenuItem,
            this.списокПроцедурToolStripMenuItem,
            this.наименованияИнструментовToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItem1.Text = "Меню";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // электроинструментыToolStripMenuItem
            // 
            this.электроинструментыToolStripMenuItem.Name = "электроинструментыToolStripMenuItem";
            this.электроинструментыToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.электроинструментыToolStripMenuItem.Text = "Электроинструменты";
            this.электроинструментыToolStripMenuItem.Click += new System.EventHandler(this.электроинструментыToolStripMenuItem_Click);
            // 
            // ручныеИнструментыToolStripMenuItem
            // 
            this.ручныеИнструментыToolStripMenuItem.Name = "ручныеИнструментыToolStripMenuItem";
            this.ручныеИнструментыToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.ручныеИнструментыToolStripMenuItem.Text = "Ручные инструменты";
            this.ручныеИнструментыToolStripMenuItem.Click += new System.EventHandler(this.ручныеИнструментыToolStripMenuItem_Click);
            // 
            // информацияОТалицахToolStripMenuItem
            // 
            this.информацияОТалицахToolStripMenuItem.Name = "информацияОТалицахToolStripMenuItem";
            this.информацияОТалицахToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.информацияОТалицахToolStripMenuItem.Text = "Информация о таблицах";
            this.информацияОТалицахToolStripMenuItem.Click += new System.EventHandler(this.информацияОТалицахToolStripMenuItem_Click);
            // 
            // информацияОФункцияToolStripMenuItem
            // 
            this.информацияОФункцияToolStripMenuItem.Name = "информацияОФункцияToolStripMenuItem";
            this.информацияОФункцияToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.информацияОФункцияToolStripMenuItem.Text = "Список функций";
            this.информацияОФункцияToolStripMenuItem.Click += new System.EventHandler(this.информацияОФункцияToolStripMenuItem_Click);
            // 
            // списокПроцедурToolStripMenuItem
            // 
            this.списокПроцедурToolStripMenuItem.Name = "списокПроцедурToolStripMenuItem";
            this.списокПроцедурToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.списокПроцедурToolStripMenuItem.Text = "Список процедур";
            this.списокПроцедурToolStripMenuItem.Click += new System.EventHandler(this.списокПроцедурToolStripMenuItem_Click);
            // 
            // наименованияИнструментовToolStripMenuItem
            // 
            this.наименованияИнструментовToolStripMenuItem.Name = "наименованияИнструментовToolStripMenuItem";
            this.наименованияИнструментовToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.наименованияИнструментовToolStripMenuItem.Text = "Наименования инструментов";
            this.наименованияИнструментовToolStripMenuItem.Click += new System.EventHandler(this.наименованияИнструментовToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 321);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "Main";
            this.Text = "Главная";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem электроинструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ручныеИнструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОТалицахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОФункцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПроцедурToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наименованияИнструментовToolStripMenuItem;
    }
}

