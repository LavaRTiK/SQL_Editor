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
            //app.ReturnDB(); work method
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
            UpdateGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private async void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var idGrid = e.RowIndex;
            var sqlGridSelectCollection = dataGridView1.Rows[idGrid].Cells;//тут айди можно доставть sql
            var sqlId = sqlGridSelectCollection[0].Value.ToString();
            var sqlColumnName = dataGridView1.Columns[e.ColumnIndex].HeaderText; //имя стобца
            var sqlColumnNameId = dataGridView1.Columns[0].HeaderText;
            var currentName = dataGridView1.SelectedCells[0].Value.ToString(); // на что изменить
            var tablelName = "users";
            string sql = $"{tablelName} {sqlColumnName} {currentName} {sqlGridSelectCollection[0].Value}";
            //await bool upadete
            database.Update(tablelName, sqlColumnName, currentName, sqlColumnNameId,sqlId);
            UpdateGrid();
            MessageBox.Show($"edit {sql} ");
        }
        public void UpdateGrid()
        {
            database.OpenConection();
            dataGridView1.DataSource = database.View("SELECT * FROM users").Tables[0];
            database.CloseConnection();
        }
    }
}
