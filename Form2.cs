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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            //窗体跳转
            Form1 FormMain = new Form1();//创建新窗体
            this.Hide();
            FormMain.ShowDialog();
            Application.ExitThread();//退出当前窗体
        }
    }
}
