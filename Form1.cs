using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenVanTruong_21_ThíCharp
{
    public partial class Form1 : Form
    {
        private object lbl1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string hovaten = " Nguyễn Văn Trường";
            string mssv = "123456789";
            string monthi = "Lập Trình Windows 2- C#";

            lblIfon.Text = "Họ và tên " + hovaten;
            lblIfon.Text += "\n MSSV: " + mssv;
            lblIfon.Text += "\n Ngày thi: " + System.DateTime.Now.ToString();
            lblIfon.Text += "\n môn thi:" + monthi;
        }
    }
}
