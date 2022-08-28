namespace ЛР08
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TaskMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Task1Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Task2Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Task3Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 171);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaskMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TaskMenu
            // 
            this.TaskMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Task1Menu,
            this.Task2Menu,
            this.Task3Menu});
            this.TaskMenu.Name = "TaskMenu";
            this.TaskMenu.Size = new System.Drawing.Size(64, 20);
            this.TaskMenu.Text = "Задания";
            // 
            // Task1Menu
            // 
            this.Task1Menu.Name = "Task1Menu";
            this.Task1Menu.Size = new System.Drawing.Size(172, 22);
            this.Task1Menu.Text = "1. ArrayVector";
            this.Task1Menu.Click += new System.EventHandler(this.Task1Menu_Click);
            // 
            // Task2Menu
            // 
            this.Task2Menu.Name = "Task2Menu";
            this.Task2Menu.Size = new System.Drawing.Size(172, 22);
            this.Task2Menu.Text = "2. LinkedListVector";
            this.Task2Menu.Click += new System.EventHandler(this.Task2Menu_Click);
            // 
            // Task3Menu
            // 
            this.Task3Menu.Name = "Task3Menu";
            this.Task3Menu.Size = new System.Drawing.Size(172, 22);
            this.Task3Menu.Text = "3. Vectors";
            this.Task3Menu.Click += new System.EventHandler(this.Task3Menu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Лабораторная работа №8";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TaskMenu;
        private System.Windows.Forms.ToolStripMenuItem Task1Menu;
        private System.Windows.Forms.ToolStripMenuItem Task2Menu;
        private System.Windows.Forms.ToolStripMenuItem Task3Menu;
    }
}

