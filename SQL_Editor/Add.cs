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
        public Add(int cout)
        {
            InitializeComponent();
            this.countButton = cout;
            int sizelabel = 30;
            int lastpositon = 10;
            for (int i = 0; i < 10; i++)
            {
                Label label = new Label();
                label.Text = "label" + i;
                label.Location = new Point(2, lastpositon);
                Controls.Add(label);
                //MessageBox.Show($"create label{i}");
                TextBox tb = new TextBox();
                tb.Text = "text" + i;
                tb.Location = new Point(110, lastpositon);
                Controls.Add(tb);
                lastpositon += sizelabel;
            }
            MessageBox.Show(countButton.ToString());
        }


    }
}
