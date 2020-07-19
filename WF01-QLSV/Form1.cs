using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF01_QLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string consTr = "Data Source = DESKTOP-13DJ6LQ\\SQLEXPRESS; Initial Catalog=QLSV_C#; Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daKhoa, daLop, daQue, daSV;
        DataTable dtKhoa, dtLop, dtQue, dtSV;
        int index;
        string gt;
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(consTr);
            conn.Open();
            string sql = "SELECT * FROM KHOA";
            daKhoa = new SqlDataAdapter(sql, conn);
            dtKhoa = new DataTable();
            dtKhoa.Rows.Clear();
            daKhoa.Fill(dtKhoa);
            dataKhoa.DataSource = dtKhoa;
            cb_ChonKhoa.DataSource = dtKhoa;
            cb_ChonKhoa.DisplayMember = "Makhoa";
            cb_Khoa.DataSource = dtKhoa;
            cb_Khoa.DisplayMember = "Makhoa";

            sql = "SELECT * FROM LOP";
            daLop = new SqlDataAdapter(sql, conn);
            dtLop = new DataTable();
            daLop.Fill(dtLop);
            dataLOP.DataSource = dtLop;
            cb_Lop_SV.DataSource = dtLop;
            cb_Lop_SV.DisplayMember = "Malop";

            sql = "SELECT * FROM QUE";
            daQue = new SqlDataAdapter(sql, conn);
            dtQue = new DataTable();
            daQue.Fill(dtQue);
            dataQue.DataSource = dtQue;
            cb_Que_SV.DataSource = dtQue;
            cb_Que_SV.DisplayMember = "Maque";

            sql = "SELECT * FROM SINHVIEN";
            daSV = new SqlDataAdapter(sql, conn);
            dtSV = new DataTable();
            daSV.Fill(dtSV);
            dataSV.DataSource = dtSV;
        }
        // Khoa
        private void bt_ThemK_Click(object sender, EventArgs e)
        {
            string sql = "Insert into KHOA values(@Makhoa,@Tenkhoa)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@Makhoa", SqlDbType.VarChar).Value = tb_Makhoa.Text;
            cmd.Parameters.Add("@Tenkhoa", SqlDbType.VarChar).Value = tb_Tenkhoa.Text;
            cmd.ExecuteNonQuery();
            dtKhoa.Rows.Clear();
            daKhoa.Fill(dtKhoa);
            dataKhoa.DataSource = dtKhoa;
        }
        private void bt_SuaK_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE KHOA SET Makhoa=@Makhoa, Tenkhoa=@Tenkhoa where Makhoa=@Makhoa";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@Makhoa", SqlDbType.VarChar).Value = tb_Makhoa.Text;
            cmd.Parameters.Add("@Tenkhoa", SqlDbType.NVarChar).Value = tb_Tenkhoa.Text;
            cmd.ExecuteNonQuery();
            dtKhoa.Rows.Clear();
            daKhoa.Fill(dtKhoa);
            dataKhoa.DataSource = dtKhoa;
        }

        private void bt_XoaK_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM KHOA WHERE Makhoa=@Makhoa";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@Makhoa", SqlDbType.VarChar).Value = tb_Makhoa.Text;
            cmd.ExecuteNonQuery();
            dtKhoa.Rows.Clear();
            daKhoa.Fill(dtKhoa);
            dataKhoa.DataSource = dtKhoa;
        }

        private void dataKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                tb_Makhoa.Text = dataKhoa.Rows[index].Cells["Makhoa"].Value.ToString();
                tb_Tenkhoa.Text = dataKhoa.Rows[index].Cells["Tenkhoa"].Value.ToString();
            }
        }
        //Lop
        private void bt_ThemLop_Click(object sender, EventArgs e)
        {
            string sql = "insert into LOP values(@Malop,@Tenlop,@Makhoa)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@Malop", SqlDbType.VarChar).Value = tb_Malop.Text;
            cmd.Parameters.Add("@Tenlop", SqlDbType.VarChar).Value =tb_Tenlop.Text;
            cmd.Parameters.Add("@Makhoa", SqlDbType.VarChar).Value = cb_ChonKhoa.Text;
            cmd.ExecuteNonQuery();
            dtLop.Rows.Clear();
            daLop.Fill(dtLop);
            dataLOP.DataSource = dtLop;
        }
        private void bt_SuaLop_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE LOP set Malop=@Malop, Tenlop=@Tenlop, Makhoa=@Makhoa where Makhoa=@Makhoa";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@Malop", SqlDbType.VarChar).Value = tb_Malop.Text;
            cmd.Parameters.Add("@Tenlop", SqlDbType.VarChar).Value = tb_Tenlop.Text;
            cmd.Parameters.Add("@Makhoa", SqlDbType.VarChar).Value = cb_ChonKhoa.Text;
            cmd.ExecuteNonQuery();
            dtLop.Rows.Clear();
            daLop.Fill(dtLop);
            dataLOP.DataSource = dtLop;
        }

        private void bt_XoaLop_Click(object sender, EventArgs e)
        {
            string sql = "DELETE from LOP where Malop=@Malop";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@Malop", SqlDbType.VarChar).Value = tb_Malop.Text;
            cmd.ExecuteNonQuery();
            dtLop.Rows.Clear();
            daLop.Fill(dtLop);
            dataLOP.DataSource = dtLop;
        }
        //Quê

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into QUE values(@Maque,@Tenque)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@Maque", SqlDbType.VarChar).Value = tb_Maque.Text;
            cmd.Parameters.Add("@Tenque", SqlDbType.VarChar).Value = tb_Tenque.Text;
            cmd.ExecuteNonQuery();
            dtQue.Rows.Clear();
            daQue.Fill(dtQue);
            dataQue.DataSource = dtQue;
        }

        private void bt_SuaQue_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE QUE set Maque=@Maque, Tenque=@Tenque where Maque=@Maque";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@Maque", SqlDbType.VarChar).Value = tb_Maque.Text;
            cmd.Parameters.Add("@Tenque", SqlDbType.VarChar).Value = tb_Tenque.Text;
            cmd.ExecuteNonQuery();
            dtQue.Rows.Clear();
            daQue.Fill(dtQue);
            dataQue.DataSource = dtQue;
        }
        private void bt_XoaQue_Click(object sender, EventArgs e)
        {
            string sql = "DELETE from QUE where Maque=@Maque";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@Maque", SqlDbType.VarChar).Value = tb_Maque.Text;
            cmd.ExecuteNonQuery();
            dtQue.Rows.Clear();
            daQue.Fill(dtQue);
            dataQue.DataSource = dtQue;
        }

        private void dataQue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                tb_Maque.Text = dataQue.Rows[index].Cells[0].Value.ToString();
                tb_Tenque.Text= dataQue.Rows[index].Cells[1].Value.ToString();
            }
        }
        // Sinh viên

        private void bt_ThemSV_Click(object sender, EventArgs e)
        {
            string sql = "insert into SINHVIEN values(@MaSV, @TenSV, @Ngaysinh, @gioitinh, @Maque, @Malop, @Makhoa)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = tb_MaSV.Text;
            cmd.Parameters.Add("@TenSV", SqlDbType.NVarChar).Value = tb_TenSV.Text;
            cmd.Parameters.Add("@Ngaysinh", SqlDbType.Date).Value = dtp_Ngaysinh.Value;
            if (rd_Nam.Checked == true)
            {
                gt = "Nam";
            }
            else
            {
                gt = "Nữ";
            }
            cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = gt;
            cmd.Parameters.Add("@Maque", SqlDbType.VarChar).Value = cb_Que_SV.Text;
            cmd.Parameters.Add("@Malop", SqlDbType.VarChar).Value = cb_Lop_SV.Text;
            cmd.Parameters.Add("@Makhoa", SqlDbType.VarChar).Value = cb_Khoa.Text;
            cmd.ExecuteNonQuery();
            dtSV.Rows.Clear();
            daSV.Fill(dtSV);
            dataSV.DataSource = dtSV;
        }

        private void bt_SuaSV_Click(object sender, EventArgs e)
        {
            string sql = "update SINHVIEN set MaSV=@MaSV, TenSV=@TenSV, Ngaysinh=@Ngaysinh, gioitinh=@gioitinh, Maque=@Maque, Malop=@Malop, Makhoa=@Makhoa where MaSV=@MaSV";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = tb_MaSV.Text;
            cmd.Parameters.Add("@TenSV", SqlDbType.NVarChar).Value = tb_TenSV.Text;
            cmd.Parameters.Add("@Ngaysinh", SqlDbType.Date).Value = dtp_Ngaysinh.Value;
            if (rd_Nam.Checked == true)
            {
                gt = "Nam";
            }
            else
            {
                gt = "Nữ";
            }
            cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = gt;
            cmd.Parameters.Add("@Maque", SqlDbType.VarChar).Value = cb_Que_SV.Text;
            cmd.Parameters.Add("@Malop", SqlDbType.VarChar).Value = cb_Lop_SV.Text;
            cmd.Parameters.Add("@Makhoa", SqlDbType.VarChar).Value = cb_Khoa.Text;
            cmd.ExecuteNonQuery();
            dtSV.Rows.Clear();
            daSV.Fill(dtSV);
            dataSV.DataSource = dtSV;
        }

        private void bt_XoaSV_Click(object sender, EventArgs e)
        {
            string sql = "delete from SINHVIEN where MaSV=@MaSV";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = tb_MaSV.Text;
            cmd.ExecuteNonQuery();
            dtSV.Rows.Clear();
            daSV.Fill(dtSV);
            dataSV.DataSource = dtSV;
        }

        private void dataSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                tb_MaSV.Text = dataSV.Rows[index].Cells[0].Value.ToString();
                tb_TenSV.Text= dataSV.Rows[index].Cells[1].Value.ToString();
                dtp_Ngaysinh.Value = Convert.ToDateTime(dataSV.Rows[index].Cells[2].Value.ToString());
                gt= dataSV.Rows[index].Cells[3].Value.ToString();
                if (gt == "Nam")
                {
                    rd_Nam.Checked = true;
                }
                else
                {
                    rd_Nu.Checked = true;
                }
                cb_Que_SV.Text= dataSV.Rows[index].Cells[4].Value.ToString();
                cb_Lop_SV.Text= dataSV.Rows[index].Cells[5].Value.ToString();
                cb_Khoa.Text= dataSV.Rows[index].Cells[6].Value.ToString();
            }
        }

    }
}
