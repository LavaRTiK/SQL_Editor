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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.button4 = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
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
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1028, 393);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
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
            this.button1.Location = new System.Drawing.Point(700, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(781, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(863, 474);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(944, 474);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 7;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 474);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Check_Focus";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 526);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Create;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button button4;
    }
}

