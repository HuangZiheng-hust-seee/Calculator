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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 FormLocation = new Form4();//创建新窗体
            this.Hide();
            FormLocation.ShowDialog();
            Application.ExitThread();//退出当前窗体
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //窗口跳转
            Form1 FormCalculator = new Form1();//创建新窗体
            this.Hide();
            FormCalculator.ShowDialog();
            Application.ExitThread();//退出当前窗体
        }
    }
}
