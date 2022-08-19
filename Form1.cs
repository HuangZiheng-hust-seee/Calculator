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
        
        public Form1()
        {
            InitializeComponent();
        }
       
       

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBox1.Text = "0";
        }
        private void rightbracket_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = ")";
            }
            else
            {
                TextBox1.Text += ")";
            }
            
        }
        private void leftbracket_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "(";
            }
            else
            TextBox1.Text += "(";
        }
        private void inputbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Num0_Click(object sender, EventArgs e)
        {
           if(TextBox1.Text == "0")
           TextBox1.Text = "0";
            else
            TextBox1.Text += "0";

        }

        private void Num1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
                TextBox1.Text = "1";
            else
            TextBox1.Text += "1";

        }
        private void Num2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
                TextBox1.Text = "2";
            else
            TextBox1.Text += "2";
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
                TextBox1.Text = "3";
            else
            TextBox1.Text += "3";
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
                TextBox1.Text = "4";
            else
            TextBox1.Text += "4";
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
                TextBox1.Text = "5";
            else
            TextBox1.Text += "5";
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
                TextBox1.Text = "6";
            else
            TextBox1.Text += "6";
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
                TextBox1.Text = "7";
            else
            TextBox1.Text += "7";
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
                TextBox1.Text = "8";
            else
            TextBox1.Text += "8";
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
                TextBox1.Text = "9";
            else
            TextBox1.Text += "9";
        }

       

        private void C_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "0";
        }

        private void del_Click(object sender, EventArgs e)
        {
            string s = TextBox1.Text;
            if (TextBox1.Text.Length != 1)
            {
                s = s.Substring(0, s.Length - 1);
                TextBox1.Text = s;
            }
            else
            {
                TextBox1.Text = "0";
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "-";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "×"; 
        }

        private void divide_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "÷";
        }
      

        private void equal_Click(object sender, EventArgs e)
        {
            Stack<double> num = new Stack<double>();
            Stack<char> op = new Stack<char>();


            try
            {
                String s = TextBox1.Text + "=";
                int p = 0; double n;
                /*如果是运算数num.push,如果是运算符判断与op栈顶的优先级*/
                while (p < s.Length - 1)
                {
                    string t = "";
                    while (s[p] >= '0' && s[p] <= '9' || s[p] == '.')
                    {
                        t += s[p];
                        p++;
                    }
                    if (t != "")
                    {
                        n = double.Parse(t);
                        num.Push(n);
                    }

                    if (s[p] == '+' || s[p] == '-' || s[p] == '×' || s[p] == '÷' || s[p] == '(' || s[p] == ')')
                    {
                        if (op.Count == 0)
                        {
                            op.Push(s[p]);
                            p++;
                        }
                        else
                        {
                            char oprt = op.Peek();
                            switch (precede(oprt, s[p]))
                            {
                                case '<':
                                    op.Push(s[p]); p++; break;
                                case '=':
                                    op.Pop(); p++; break;
                                case '>':
                                    double d2 = num.Pop();
                                    double d1 = num.Pop();
                                    char c1 = op.Pop();
                                    num.Push(Operate(d1, d2, c1)); break;

                            }
                            /*if (precede(s[p], oprt))
                            {
                                double d1 = num.Pop();
                                double d2 = num.Pop();
                                char c1 = op.Pop();
                                num.Push(Operate(d1, d2, c1));
                            }
                            else
                            {
                                op.Push(s[p]);
                                p++;
                            }*/
                        }

                    }
                    if (s[p] == '=')
                    {
                        while (op.Count != 0)
                        {
                            double d2 = num.Pop();
                            double d1 = num.Pop();
                            char c1 = op.Pop();
                            num.Push(Operate(d1, d2, c1));
                        }

                    }
                }//while
                if (num.Count == 1)
                {
                    TextBox1.Text = "" + num.Peek();
                    string addstr = DateTime.Now.ToString("G");//得到当前时间
                    string oldstr;
                    addstr = addstr + ";" + s + TextBox1.Text;
                    ReadandWrite readandWrite = new ReadandWrite();
                    oldstr = readandWrite.ReadAll();
                    readandWrite.Write(oldstr + "\n" + addstr);//将当前公式和时间写入txt文件
                }
                else
                {
                    MessageBox.Show("数学错误！");
                    TextBox1.Text = "0";
                }
            }
            catch
            {
                MessageBox.Show("数学错误！");
                TextBox1.Text = "0";
            }
          
            
                
        }//click
             //运算
            double Operate(double d1, double d2, char c1)
            {
                double result = 0;//用resul返回计算方法
                switch (c1)
                {
                    case '+':
                        result = d1 + d2; break;
                    case '-':
                        result = d1 - d2; break;
                    case '×':
                        result = d1 * d2; break;
                    case '÷':
                        result = d1 / d2; break;
                }
                return result;
            }
            //优先级;判断优先级还可以将上面的优先级表填入二维数组，通过查表的方法得到对应优先级
            char precede(char c1, char c2)
            {
                char result = '.';//用result返回优先级
                switch (c1)
                {
                    case '+':
                    case '-':
                        if (c2 == '+' || c2 == '-' || c2 == ')')
                            result = '>';
                        else
                            result = '<';
                        break;
                    case '×':
                    case '÷':
                        if (c2 == '(')
                            result = '<';
                        else
                            result = '>';
                        break;
                    case '(':
                        if (c2 == ')')
                            result = '=';
                        else
                            result = '<';
                        break;
                    case ')':
                        result = '<';
                        break;
                }
                return result;
            }

        private void dot_Click(object sender, EventArgs e)
        {
            TextBox1.Text += ".";
        }

        private void history_Click(object sender, EventArgs e)
        {
            //窗口跳转
            Form2 FormHistory = new Form2();//创建新窗体
            this.Hide();
            FormHistory.ShowDialog();
            Application.ExitThread();//退出当前窗体
        }
    }

     

       
    
}
