using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF01_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n;
        static bool NguyenTo(int n)
        {
            bool e = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    e = false;
            return e;
        }
        static bool SHC(int n)
        {
            int sum = 0;
            for(int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
            {
                return true;
            }
            return false;
        }
        private void bt_Tinh_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(tb_NhapSo.Text);
            for (int i = 2; i < n; i++)
            {
                if (NguyenTo(i))
                {
                    lb_SNT.Text +=" " + i.ToString();
                }
            }
            for (int i = 1; i <=n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    if (j * j == i)
                    {
                        lb_SCP.Text += " " + i.ToString();
                    }
                }
            }
            for(int i = 1; i <n; i++)
            {
                if (SHC(i))
                {
                    lb_SHC.Text += " " + i.ToString();
                }
            }
        }

        private void tb_NhapSo_Leave(object sender, EventArgs e)
        {
            n = Convert.ToInt32(tb_NhapSo.Text);
            if (n > 100 || n<0)
            {
                MessageBox.Show("Giá trị nhập vào phải lớn hơn 0 và nhỏ hơn 100");
                tb_NhapSo.Focus();
            }
        }
    }
}
