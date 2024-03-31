namespace SQL_Editor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.базаДанихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.підключенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відключенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідВідключенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базаДанихToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // базаДанихToolStripMenuItem
            // 
            this.базаДанихToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.підключенняToolStripMenuItem,
            this.відключенняToolStripMenuItem,
            this.вихідВідключенняToolStripMenuItem});
            this.базаДанихToolStripMenuItem.Name = "базаДанихToolStripMenuItem";
            this.базаДанихToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.базаДанихToolStripMenuItem.Text = "База даних";
            // 
            // підключенняToolStripMenuItem
            // 
            this.підключенняToolStripMenuItem.Name = "підключенняToolStripMenuItem";
            this.підключенняToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.підключенняToolStripMenuItem.Text = "Підключення";
            this.підключенняToolStripMenuItem.Click += new System.EventHandler(this.підключенняToolStripMenuItem_Click);
            // 
            // відключенняToolStripMenuItem
            // 
            this.відключенняToolStripMenuItem.Name = "відключенняToolStripMenuItem";
            this.відключенняToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.відключенняToolStripMenuItem.Text = "Відключення";
            // 
            // вихідВідключенняToolStripMenuItem
            // 
            this.вихідВідключенняToolStripMenuItem.Name = "вихідВідключенняToolStripMenuItem";
            this.вихідВідключенняToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.вихідВідключенняToolStripMenuItem.Text = "Вихід - Відключення";
            this.вихідВідключенняToolStripMenuItem.Click += new System.EventHandler(this.вихідВідключенняToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem базаДанихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem підключенняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відключенняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідВідключенняToolStripMenuItem;
    }
}

