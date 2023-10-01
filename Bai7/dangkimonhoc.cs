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
          foreach (var item in checkedListBox2.CheckedItems)
{
    thongtin += "\nHoc Ky " + item.ToString();
}
          
foreach (var item in checkedListBox1.CheckedItems)
{
    thongtin += "\nMon Hoc " + item.ToString();
}


MessageBox.Show(thongtin, thongtin1, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
