using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF01_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string gioitinh;
        int index;
        private void bt_Them_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                if (rd_Nam.Checked == true)
                {
                    gioitinh = "Nam";
                    rd_Nu.Checked = false;
                }
                else
                {
                    gioitinh = "Nữ";
                }
                dataGridView1.Rows.Add(tb_MaSV.Text, tb_Hoten.Text, tb_Ngaysinh.Text, gioitinh, cb_Que.Text, cb_Lop.Text, cb_Khoa.Text);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                tb_MaSV.Text = dataGridView1.Rows[index].Cells["MaSV"].Value.ToString();
                tb_Hoten.Text= dataGridView1.Rows[index].Cells["HoTen"].Value.ToString();
                tb_Ngaysinh.Text= dataGridView1.Rows[index].Cells["NgaySinh"].Value.ToString();
                gioitinh= dataGridView1.Rows[index].Cells["Gioitinh"].Value.ToString();
                if (gioitinh == "Nam")
                {
                    rd_Nam.Checked = true;
                    rd_Nu.Checked = false;
                }
                else
                {
                    rd_Nu.Checked = true;
                    rd_Nam.Checked = false;
                }
                cb_Que.Text= dataGridView1.Rows[index].Cells["Quequan"].Value.ToString();
                cb_Lop.Text= dataGridView1.Rows[index].Cells["Lop"].Value.ToString();
                cb_Khoa.Text= dataGridView1.Rows[index].Cells["Khoa"].Value.ToString();
            }
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            DataGridViewRow newRow = dataGridView1.Rows[index];
            newRow.Cells["MaSV"].Value = tb_MaSV.Text;
            newRow.Cells["HoTen"].Value = tb_Hoten.Text;
            newRow.Cells["NgaySinh"].Value = tb_Ngaysinh.Text;
            newRow.Cells["Quequan"].Value = cb_Que.Text;
            newRow.Cells["Lop"].Value = cb_Lop.Text;
            newRow.Cells["Khoa"].Value = cb_Khoa.Text;
            if (rd_Nam.Checked == true)
            {
                gioitinh = "Nam";
                rd_Nu.Checked = false;
            }
            else
            {
                gioitinh = "Nữ";
            }
            newRow.Cells["Gioitinh"].Value = gioitinh;
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(tb_Hoten.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Thông báo");
                tb_Hoten.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_MaSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập Mã sinh viên", "Thông báo");
                tb_MaSV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_Ngaysinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh", "Thông báo");
                tb_Ngaysinh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cb_Khoa.Text))
            {
                MessageBox.Show("Bạn chưa chọn Khoa", "Thông báo");
                cb_Khoa.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cb_Que.Text))
            {
                MessageBox.Show("Bạn chưa chọn Quê quán", "Thông báo");
                cb_Que.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cb_Lop.Text))
            {
                MessageBox.Show("Bạn chưa chọn Lớp", "Thông báo");
                cb_Lop.Focus();
                return false;
            }
            if(rd_Nam.Checked==false && rd_Nu.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo");
                return false;
            }
            return true;
        }
    }
}
