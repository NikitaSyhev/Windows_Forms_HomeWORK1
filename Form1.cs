using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int n1;
        public int n2;
        public string action;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            action = button.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            action = button.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int n2 = int.Parse(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            action = button.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            action = button.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            action = button.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int result = 0;
            if (action == "+")
            {
                result = n1 + n2;
            }
            else if (action == "-")
            {
                result = n1 - n2;
            }
            else if (action == "*")
            {
                result = n1 * n2;
            }
            else if (action == "/")
            {
                result = n1 / n2;
            }
            if (action == "=")
            {
                textBox3.Text = result.ToString();
            }
            
            
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox2.Text);

            
        }
    }
}
