using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF01_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b;
        private void tb_SoA_TextChanged(object sender, EventArgs e)
        {
            
            // rời khỏi tb_a thì phải kiểm tra dữ liệu
            // Nếu nhập sai thì thông báo lỗi và bắt nhập lại
            if (!int.TryParse(tb_SoA.Text, out a))
            {
                MessageBox.Show("Lỗi nhập sai dữ liệu");
                tb_SoA.Focus(); // đưa con trỏ trở lại tb_SoA để bắt nhập lại
            }
        }

        private void tb_SoB_TextChanged(object sender, EventArgs e)
        {
           
            // rời khỏi tb_a thì phải kiểm tra dữ liệu
            // Nếu nhập sai thì thông báo lỗi và bắt nhập lại
            if (!int.TryParse(tb_SoB.Text, out b))
            {
                MessageBox.Show("Lỗi nhập sai dữ liệu");
                tb_SoA.Focus(); // đưa con trỏ trở lại tb_SoA để bắt nhập lại
            }
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_Tinh_Click_1(object sender, EventArgs e)
        {
            a = Convert.ToInt32(tb_SoA.Text);
            b = Convert.ToInt32(tb_SoB.Text);
            lbTong.Text = string.Format("Tổng a + b= {0}", a + b);
            lbHieu.Text = string.Format("Hiệu a - b= {0}", a - b);
            lbTich.Text = string.Format("Tích a * b= {0}", a * b);
            try
            {

                lbThuong.Text = string.Format("Thương a/b={0}", a / b);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Lỗi chia cho 0");
            }
        }
    }
}
