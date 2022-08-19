using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class ReadandWrite
    {
        //读写整个文档的所有内容
        public string ReadAll()
        {
            FileStream fs = new FileStream("./history.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string all = sr.ReadToEnd();
            fs.Close();
            return all;
        }
        //写入内容
        public void Write(string addstr)
        {
            FileStream fs = new FileStream("./history.txt", FileMode.Create);
            byte[] byteData = Encoding.Default.GetBytes(addstr);
            fs.Write(byteData, 0, byteData.Length);
            fs.Flush();
            fs.Close();
        }
    }
}
