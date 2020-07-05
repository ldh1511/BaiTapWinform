using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF01_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void mnstr_Color_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                bt_1.BackColor = color.Color;
                bt_2.BackColor = color.Color;
                bt_3.BackColor = color.Color;
                bt_4.BackColor = color.Color;
                bt_5.BackColor = color.Color;
                bt_6.BackColor = color.Color;
                bt_7.BackColor = color.Color;
                bt_8.BackColor = color.Color;
                bt_9.BackColor = color.Color;
                bt_0.BackColor = color.Color;
                bt_Plus.BackColor = color.Color;
                bt_Minus.BackColor = color.Color;
                bt_Divide.BackColor = color.Color;
                bt_multi.BackColor = color.Color;
                bt_equal.BackColor = color.Color;
                bt_C.BackColor = color.Color;
            }
        }

        private void mnstr_Font_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                mnstr_Change.Font = fd.Font;
                tb_Kq.Font = fd.Font;
                tb_Nhap.Font = fd.Font;
                bt_1.Font = fd.Font;
                bt_2.Font = fd.Font;
                bt_3.Font = fd.Font;
                bt_4.Font = fd.Font;
                bt_5.Font = fd.Font;
                bt_6.Font = fd.Font;
                bt_7.Font = fd.Font;
                bt_8.Font = fd.Font;
                bt_9.Font = fd.Font;
                bt_0.Font = fd.Font;
                bt_Plus.Font = fd.Font;
                bt_Minus.Font = fd.Font;
                bt_Divide.Font = fd.Font;
                bt_multi.Font = fd.Font;
                bt_equal.Font = fd.Font;
                bt_C.Font = fd.Font;
            }
        }
        int count;
        float s1, s2;
        private void bt_1_Click(object sender, EventArgs e)
        {
            
            tb_Nhap.Text += 1;
            tb_Kq.Text += 1;
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            
            tb_Nhap.Text += 2;
            tb_Kq.Text += 2;
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            
            tb_Nhap.Text += 3;
            tb_Kq.Text += 3;
        }


        private void bt_4_Click(object sender, EventArgs e)
        {
            tb_Nhap.Text += 4;
            tb_Kq.Text += 4;
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            tb_Nhap.Text += 5;
            tb_Kq.Text += 5;
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            tb_Nhap.Text += 6;
            tb_Kq.Text += 6;
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            tb_Nhap.Text += 7;
            tb_Kq.Text += 7;
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            tb_Nhap.Text += 8;
            tb_Kq.Text += 8;
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            tb_Nhap.Text += 9;
            tb_Kq.Text += 9;
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            tb_Nhap.Text += 0;
            tb_Kq.Text += 0;
        }

        private void bt_Plus_Click(object sender, EventArgs e)
        {
            count = 1;
            s1 = int.Parse(tb_Kq.Text);
            tb_Kq.Text = " ";
            tb_Nhap.Text += " + ";
        }

        private void bt_Minus_Click(object sender, EventArgs e)
        {
            count = 2;
            s1 = float.Parse(tb_Kq.Text);
            tb_Kq.Text = " ";
            tb_Nhap.Text += " - ";
        }

        private void bt_multi_Click(object sender, EventArgs e)
        {
            
            count = 3;
            s1 = float.Parse(tb_Kq.Text);
            tb_Kq.Text = " ";
            tb_Nhap.Text += " * ";
        }

        private void bt_Divide_Click(object sender, EventArgs e)
        {
            count = 4;
            s1 = float.Parse(tb_Kq.Text);
            tb_Kq.Text = " ";
            tb_Nhap.Text += " / ";
        }

        private void bt_C_Click(object sender, EventArgs e)
        {
            tb_Nhap.Clear();
            tb_Kq.Clear();
            s1 = 0;
        }

        private void bt_equal_Click(object sender, EventArgs e)
        {
            s2 = float.Parse(tb_Kq.Text);
            float ketqua;
            switch (count)
            {
                case 1:
                    ketqua = s1 + s2;
                    tb_Kq.Text = ketqua.ToString();
                    break;
                case 2:
                    ketqua = s1 - s2;
                    tb_Kq.Text = ketqua.ToString();
                    break;
                case 3:
                    ketqua = s1 * s2;
                    tb_Kq.Text = ketqua.ToString();
                    break;
                case 4:
                    ketqua = s1 / s2;
                    tb_Kq.Text = ketqua.ToString();
                    break;
            }

        }
    }
}
