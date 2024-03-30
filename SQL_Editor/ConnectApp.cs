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
    public partial class ConnectApp : Form
    {
        public ConnectApp()
        {
            InitializeComponent();
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text);

            db.Connect();


            #region oldCode
            /*try
            {
                MySqlConnection connection = new MySqlConnection($"server={textBox1.Text};port={textBox2.Text};username={textBox3.Text};password={textBox4.Text};database={textBox5.Text}");
                connection.Open();
                label6.Text = "Connect Succes";
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} return try");
            } */
            #endregion

            //вызов метода проверки подключения
            //перенести всю эту белеберду в класс db после доставать отуда подключения через getconection (return connection)
        }
    }
}
