using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculatorApp
{
    public partial class Form1 : Form
    {
        bool plus = false;
        bool min = false;
        bool star = false;
        bool delenie = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button_delenie_Click(object sender, EventArgs e)
        {
            delenie = true;
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            plus = true;
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
        }

        private void button_min_Click(object sender, EventArgs e)
        {
            min = true;
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
        }

        private void button_star_Click(object sender, EventArgs e)
        {
            star = true;
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Tag = "";
        }

        private void button_res_Click(object sender, EventArgs e)
        {
            if (plus)
            {
                decimal p1 = Convert.ToDecimal(textBox1.Text) + Convert.ToDecimal(textBox1.Tag);
                textBox1.Text = p1.ToString();
            }
            if (min)
            {
                decimal p1 = Convert.ToDecimal(textBox1.Text) - Convert.ToDecimal(textBox1.Tag);
                textBox1.Text = p1.ToString();
            }
            if (delenie)
            {
                decimal p1 = Convert.ToDecimal(textBox1.Text) / Convert.ToDecimal(textBox1.Tag);
                textBox1.Text = p1.ToString();
            }
            if (star)
            {
                decimal p1 = Convert.ToDecimal(textBox1.Text) * Convert.ToDecimal(textBox1.Tag);
                textBox1.Text = p1.ToString();
            }
        }
    }
}
