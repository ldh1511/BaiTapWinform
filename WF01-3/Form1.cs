using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF01_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int s1=100000, s2=1200000, s3=150000, s4=100000, s5=90000;
        
        private void bt_Tinh_Click(object sender, EventArgs e)
        {

            TongTien();
;        }
        private void bt_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void TongTien()
        {
            int sl, sum = 0;
            if (cb_Dv1.CheckState == CheckState.Checked)
            {
                sum += s1;
            }
            if (cb_Dv2.CheckState == CheckState.Checked)
            {
                sum += s2;
            }
            if (cb_Dv3.CheckState == CheckState.Checked)
            {
                sum += s3;
            }
            if (cb_Dv4.CheckState == CheckState.Checked)
            {
                sum += s4;
            }
            sl = Convert.ToInt32(numericUpDown1.Value);
            sum += sl * s5;
            tb_HoaDon.Text = Convert.ToString(sum);
        }
    }
}
