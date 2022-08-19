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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globaldata.Passdata = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 InitialForm = new Form3();//创建新窗体
            this.Hide();
            InitialForm.ShowDialog();
            Application.ExitThread();//退出当前窗体
        }
    }
}
