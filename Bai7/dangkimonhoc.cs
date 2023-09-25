using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class dangkimonhoc : Form
    {
        public dangkimonhoc()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string thongtin;
            thongtin = "MSSV: "+textBox1.Text;
            thongtin += "\nHỌ Và Tên: "+ textBox2.Text;
            thongtin += "\nNiên KHóa: "+ comboBox1.Text;
            thongtin += "\nLỚp: "+ comboBox2.Text;
            thongtin += "\nHọc KÌ:  "+ radioButton1.Text+ radioButton2.Text+  radioButton3.Text+ radioButton4.Text;
            thongtin += "\nMÔn học "+ checkedListBox1;
          
            MessageBox.Show(thongtin,"Chú Ý");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}