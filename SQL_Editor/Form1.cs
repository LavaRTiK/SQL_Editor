using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Editor
{
    public partial class Form1 : Form
    {
        public static DB database;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void вихідВідключенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Відключення бд
            Close();
        }

        private void підключенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectApp app = new ConnectApp();
            app.ShowDialog();
            if(database != null)
            {
                dbstatus.Text = $"Online datebase to {database.GetConnection().Database}";
                dbstatus.ForeColor = System.Drawing.Color.Green;
                підключенняToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
                підключенняToolStripMenuItem.Enabled = false;
            }
        }
        private void відключенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            database.CloseConnection();
            database = null;
            dbstatus.Text = "Disconnect databes";
            dbstatus.ForeColor = System.Drawing.Color.Red;
            підключенняToolStripMenuItem.ForeColor=System.Drawing.Color.Black;
            підключенняToolStripMenuItem.Enabled=true;
            //Очистака таблицы.
            MessageBox.Show("Database discconect");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(database == null)
            {
                MessageBox.Show("Need to Connect db");
                return;
            }
            database.OpenConection();
            dataGridView1.DataSource = database.View("SELECT * FROM users").Tables[0];
            database.CloseConnection();
        }
    }
}
