using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y, max;
            max = (int)Math.Pow(2, 31);
            string s = textBox1.Text;
            x = Int32.Parse(s);
            s = textBox2.Text;
            y = Int32.Parse(s);
            if ((x * y > 0 && x * y < max - 1 && x * 1.0 / max * y / max > 0)
                || (x * y < 0 && x * y > -max && x * 1.0 / max * y / max < 0))//判断是否超出范围
            {
                s = Convert.ToString(x * y);
                label4.Text = "";
            }
            else
            {
                label4.Text = ("超出计算范围！");
                s = "";
            }
            label1.Text = (s);
        }
    }
}
