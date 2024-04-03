using MySqlConnector;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SQL_Editor
{
    public class DB
    {
        string server;
        string port;
        string username;
        string password;
        string database;
        MySqlConnection connection;
        public DB(string server,string port, string username, string password, string database)
        {
            this.server = server;
            this.port = port;
            this.username = username;
            this.password = password;
            this.database = database;
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
        public void Connect()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection($"server={server};port={port};username={username};password={password};database={database}");
                this.connection = connection;
                connection.Open();
                connection.Close();
                ConnectApp connectApp = (ConnectApp)Application.OpenForms["ConnectApp"];
                connectApp.Close();
                MessageBox.Show("Connect Succes");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void OpenConection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if(connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public void Add(string sql)
        {
            //придумать
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql,connection);
        }
        public DataSet View(string sql)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql,connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            return dataset;
        }
        public void Delete(string sql)
        {

        }
        public void Update(string sql)
        {

        }
        public void RootInput(string sql)
        {

        }
        public bool CheackConnect()
        {
            //true
            //false =3
            return true;
        }

    }
}
