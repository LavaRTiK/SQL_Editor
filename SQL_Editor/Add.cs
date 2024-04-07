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
    public partial class Add : Form
    {
        private int countButton;
        public Add()
        {
            InitializeComponent();
        }
        public Add(DataGridViewColumnCollection columnCollection)
        {
            InitializeComponent();
            for(int i = 0; i < columnCollection.Count; i++)
            {
                MessageBox.Show($"{columnCollection[i].HeaderText} --- ");
            }
            this.countButton = columnCollection.Count;
            int sizelabel = 40;
            int lastpositon = 20;
            for (int i = 0; i < columnCollection.Count; i++)
            {
                Label label = new Label();
                label.Text = columnCollection[i].HeaderText;
                label.Location = new Point(10, lastpositon);
                Controls.Add(label);
                //MessageBox.Show($"create label{i}");
                TextBox tb = new TextBox();
                tb.Text = "text" + i;
                tb.Location = new Point(100, lastpositon);//перенести все єто в метод  добавить name и найти как его нходить лучше знаести все это в колекцию и отуда доставать 
                Controls.Add(tb);
                lastpositon += sizelabel;
            }
            MessageBox.Show(countButton.ToString());
        }


    }
}
