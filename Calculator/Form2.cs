using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

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

        private void button1_Click(object sender, EventArgs e)
        {


            string sqlStr = "select value from jieguo";
            DataSet ds = MySqlHelper.ExecSqlQuery(sqlStr);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string str = ds.Tables[0].Rows[i][0].ToString();//第I排第一列的值   
                listBox1.Items.Add(str);

            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        public void AutoSizeColumn(DataGridView DGVFiles)
        {
            int width = 0;
            //使列自适应宽度
            //对于每一列都调整
            for (int i = 0; i < DGVFiles.Columns.Count; i++)
            {
                //将每一列都调整为自动适应模式
                DGVFiles.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);
                //记录整个的宽度
                width += DGVFiles.Columns[i].Width;
            }
            //判断调整后的宽度与原来设定的宽度的关系，如果是调整后的宽度大于原来设定的宽度
            //则将每列都自动调整模式设置为显示的列即可
            //如果是小于原来设定的宽度，将模式改为填充
            if (width > DGVFiles.Size.Width)
            {
                DGVFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else
            {
                DGVFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            //冻结某列从左开始
            DGVFiles.Columns[0].Frozen = true;
        }
    }
}
