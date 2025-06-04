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
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            label1.Text = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Enabled == false)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible == false)
            {
                button4.Text = "Hide Text Box 1";
                textBox1.Visible = true;
            }
            else
            {
                button4.Text = "Show Text Box 1";
                textBox1.Visible = false;

            }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                textBox1.BackColor = Color.Red;
            }
            else if(numericUpDown1.Value == 1)
            {
                textBox1.BackColor = Color.Aqua;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "RFK_solution";
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
