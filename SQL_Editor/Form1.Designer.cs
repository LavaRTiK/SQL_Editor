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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbstatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базаДанихToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
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
            this.відключенняToolStripMenuItem.Click += new System.EventHandler(this.відключенняToolStripMenuItem_Click);
            // 
            // вихідВідключенняToolStripMenuItem
            // 
            this.вихідВідключенняToolStripMenuItem.Name = "вихідВідключенняToolStripMenuItem";
            this.вихідВідключенняToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.вихідВідключенняToolStripMenuItem.Text = "Вихід - Відключення";
            this.вихідВідключенняToolStripMenuItem.Click += new System.EventHandler(this.вихідВідключенняToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(808, 393);
            this.dataGridView1.TabIndex = 1;
            // 
            // dbstatus
            // 
            this.dbstatus.AutoSize = true;
            this.dbstatus.ForeColor = System.Drawing.Color.Red;
            this.dbstatus.Location = new System.Drawing.Point(677, 5);
            this.dbstatus.Name = "dbstatus";
            this.dbstatus.Size = new System.Drawing.Size(111, 13);
            this.dbstatus.TabIndex = 2;
            this.dbstatus.Text = "Disconnect databese ";
            this.dbstatus.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(631, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dbstatus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem базаДанихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem підключенняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відключенняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідВідключенняToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label dbstatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

