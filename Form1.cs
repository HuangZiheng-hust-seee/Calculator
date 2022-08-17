using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        int number=0;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            inputbox.Text = number.ToString();
        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }
        private void Num0_Click(object sender, EventArgs e)
        {
            number = number * 10 + 0;
            inputbox.Text = number.ToString();
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            number = number * 10 + 1;
            inputbox.Text = number.ToString();

        }
        private void Num2_Click(object sender, EventArgs e)
        {
            number = number * 10 + 2;
            inputbox.Text = number.ToString();
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            number = number * 10 + 3;
            inputbox.Text = number.ToString();
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            number = number * 10 + 4;
            inputbox.Text = number.ToString();
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            number = number * 10 + 5;
            inputbox.Text = number.ToString();
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            number = number * 10 + 6;
            inputbox.Text = number.ToString();
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            number = number * 10 + 7;
            inputbox.Text = number.ToString();
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            number = number * 10 + 8;
            inputbox.Text = number.ToString();
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            number = number * 10 + 9;
            inputbox.Text = number.ToString();
        }

        private void inputbox_TextChanged(object sender, EventArgs e)
        {
            inputbox.Text = number.ToString();
        }

        private void C_Click(object sender, EventArgs e)
        {
            number = 0;
            inputbox.Text = number.ToString();
        }

        private void del_Click(object sender, EventArgs e)
        {
            number = number / 10;
            inputbox.Text = number.ToString();
        }

        private void plus_Click(object sender, EventArgs e)
        {

        }

        private void minus_Click(object sender, EventArgs e)
        {

        }

        private void multiply_Click(object sender, EventArgs e)
        {

        }

        private void divide_Click(object sender, EventArgs e)
        {

        }
    }
}
