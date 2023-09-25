using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai7
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblinfo_Click(object sender, EventArgs e)
        {
            string HoTen= " Nguyễn Bính";
            string mssv = "412323423" ;
            string monthi = "Lập Trình";
            lblinfo.Text = "Họ Tên :" + HoTen;
            lblinfo.Text += "\nmã Sinh viên :" + mssv;
            lblinfo.Text += "\nNgày thi: " + System.DateTime.Now.ToString();
            lblinfo.Text += "\nMôn thi: :" + monthi;

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tínhCănBậcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canbac gtp = new canbac();
            gtp.Show();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xin Chào Bạn Nhé ");
        }

        private void đăngKíMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangkimonhoc gtp = new dangkimonhoc();  
            gtp.Show(); 
        }
    }
}
