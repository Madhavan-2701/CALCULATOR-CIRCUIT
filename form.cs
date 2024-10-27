using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v2iCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == null)
            {
                textBox1.Text = (int.Parse(textBox2.Text) * int.Parse(textBox3.Text)).ToString();
            }
            else if (textBox2.Text == "" || textBox2.Text == null)
            {
                textBox2.Text = (int.Parse(textBox1.Text) / int.Parse(textBox3.Text)).ToString();
            }
            else if (textBox3.Text == "" || textBox3.Text == null)
            {
                textBox3.Text = (int.Parse(textBox1.Text) / int.Parse(textBox2.Text)).ToString();
            }

        }
    }
}
