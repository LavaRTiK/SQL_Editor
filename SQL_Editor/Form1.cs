﻿using MySqlConnector;
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
            app.Show();
            MySqlConnection connection;

        }
    }
}