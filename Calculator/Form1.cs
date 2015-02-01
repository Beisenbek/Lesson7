using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void engineerViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox1.Text += btn.Text;
        }

        int a = 0;
        int b = 0;

        private void button11_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            b = int.Parse(textBox1.Text);
            textBox1.Text = (a + b).ToString();
        }
    }
}
