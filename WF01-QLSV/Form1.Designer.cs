namespace WF01_QLSV
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataKhoa = new System.Windows.Forms.DataGridView();
            this.bt_XoaK = new System.Windows.Forms.Button();
            this.bt_SuaK = new System.Windows.Forms.Button();
            this.bt_ThemK = new System.Windows.Forms.Button();
            this.tb_Tenkhoa = new System.Windows.Forms.TextBox();
            this.tb_Makhoa = new System.Windows.Forms.TextBox();
            this.lb_Tenkhoa = new System.Windows.Forms.Label();
            this.lb_Makhoa = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataLOP = new System.Windows.Forms.DataGridView();
            this.bt_XoaLop = new System.Windows.Forms.Button();
            this.bt_SuaLop = new System.Windows.Forms.Button();
            this.bt_ThemLop = new System.Windows.Forms.Button();
            this.cb_ChonKhoa = new System.Windows.Forms.ComboBox();
            this.lb_Makhoa_Lop = new System.Windows.Forms.Label();
            this.lb_Tenlop = new System.Windows.Forms.Label();
            this.tb_Tenlop = new System.Windows.Forms.TextBox();
            this.tb_Malop = new System.Windows.Forms.TextBox();
            this.lb_Malop = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lb_Maque = new System.Windows.Forms.Label();
            this.lb_Tenque = new System.Windows.Forms.Label();
            this.tb_Maque = new System.Windows.Forms.TextBox();
            this.tb_Tenque = new System.Windows.Forms.TextBox();
            this.bt_ThemQue = new System.Windows.Forms.Button();
            this.bt_SuaQue = new System.Windows.Forms.Button();
            this.bt_XoaQue = new System.Windows.Forms.Button();
            this.dataQue = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lb_MaSV = new System.Windows.Forms.Label();
            this.lb_TenSV = new System.Windows.Forms.Label();
            this.tb_MaSV = new System.Windows.Forms.TextBox();
            this.tb_TenSV = new System.Windows.Forms.TextBox();
            this.lb_Ngaysinh = new System.Windows.Forms.Label();
            this.dtp_Ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.lb_Gioitinh = new System.Windows.Forms.Label();
            this.rd_Nam = new System.Windows.Forms.RadioButton();
            this.rd_Nu = new System.Windows.Forms.RadioButton();
            this.lb_Que = new System.Windows.Forms.Label();
            this.cb_Que_SV = new System.Windows.Forms.ComboBox();
            this.lb_Lop = new System.Windows.Forms.Label();
            this.cb_Lop_SV = new System.Windows.Forms.ComboBox();
            this.lb_Khoa = new System.Windows.Forms.Label();
            this.cb_Khoa = new System.Windows.Forms.ComboBox();
            this.bt_ThemSV = new System.Windows.Forms.Button();
            this.bt_SuaSV = new System.Windows.Forms.Button();
            this.bt_XoaSV = new System.Windows.Forms.Button();
            this.dataSV = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKhoa)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLOP)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataQue)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(644, 383);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.dataKhoa);
            this.tabPage1.Controls.Add(this.bt_XoaK);
            this.tabPage1.Controls.Add(this.bt_SuaK);
            this.tabPage1.Controls.Add(this.bt_ThemK);
            this.tabPage1.Controls.Add(this.tb_Tenkhoa);
            this.tabPage1.Controls.Add(this.tb_Makhoa);
            this.tabPage1.Controls.Add(this.lb_Tenkhoa);
            this.tabPage1.Controls.Add(this.lb_Makhoa);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(636, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "KHOA";
            // 
            // dataKhoa
            // 
            this.dataKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKhoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataKhoa.Location = new System.Drawing.Point(3, 76);
            this.dataKhoa.Name = "dataKhoa";
            this.dataKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataKhoa.Size = new System.Drawing.Size(630, 278);
            this.dataKhoa.TabIndex = 7;
            this.dataKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKhoa_CellClick);
            // 
            // bt_XoaK
            // 
            this.bt_XoaK.Location = new System.Drawing.Point(507, 14);
            this.bt_XoaK.Name = "bt_XoaK";
            this.bt_XoaK.Size = new System.Drawing.Size(121, 33);
            this.bt_XoaK.TabIndex = 6;
            this.bt_XoaK.Text = "Xóa";
            this.bt_XoaK.UseVisualStyleBackColor = true;
            this.bt_XoaK.Click += new System.EventHandler(this.bt_XoaK_Click);
            // 
            // bt_SuaK
            // 
            this.bt_SuaK.Location = new System.Drawing.Point(380, 14);
            this.bt_SuaK.Name = "bt_SuaK";
            this.bt_SuaK.Size = new System.Drawing.Size(121, 33);
            this.bt_SuaK.TabIndex = 5;
            this.bt_SuaK.Text = "Sửa";
            this.bt_SuaK.UseVisualStyleBackColor = true;
            this.bt_SuaK.Click += new System.EventHandler(this.bt_SuaK_Click);
            // 
            // bt_ThemK
            // 
            this.bt_ThemK.Location = new System.Drawing.Point(253, 14);
            this.bt_ThemK.Name = "bt_ThemK";
            this.bt_ThemK.Size = new System.Drawing.Size(121, 33);
            this.bt_ThemK.TabIndex = 4;
            this.bt_ThemK.Text = "Thêm";
            this.bt_ThemK.UseVisualStyleBackColor = true;
            this.bt_ThemK.Click += new System.EventHandler(this.bt_ThemK_Click);
            // 
            // tb_Tenkhoa
            // 
            this.tb_Tenkhoa.Location = new System.Drawing.Point(98, 50);
            this.tb_Tenkhoa.Name = "tb_Tenkhoa";
            this.tb_Tenkhoa.Size = new System.Drawing.Size(119, 20);
            this.tb_Tenkhoa.TabIndex = 3;
            // 
            // tb_Makhoa
            // 
            this.tb_Makhoa.Location = new System.Drawing.Point(98, 14);
            this.tb_Makhoa.Name = "tb_Makhoa";
            this.tb_Makhoa.Size = new System.Drawing.Size(119, 20);
            this.tb_Makhoa.TabIndex = 2;
            // 
            // lb_Tenkhoa
            // 
            this.lb_Tenkhoa.AutoSize = true;
            this.lb_Tenkhoa.Location = new System.Drawing.Point(8, 53);
            this.lb_Tenkhoa.Name = "lb_Tenkhoa";
            this.lb_Tenkhoa.Size = new System.Drawing.Size(53, 13);
            this.lb_Tenkhoa.TabIndex = 1;
            this.lb_Tenkhoa.Text = "Tên khoa";
            // 
            // lb_Makhoa
            // 
            this.lb_Makhoa.AutoSize = true;
            this.lb_Makhoa.Location = new System.Drawing.Point(8, 17);
            this.lb_Makhoa.Name = "lb_Makhoa";
            this.lb_Makhoa.Size = new System.Drawing.Size(49, 13);
            this.lb_Makhoa.TabIndex = 0;
            this.lb_Makhoa.Text = "Mã khoa";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.dataLOP);
            this.tabPage2.Controls.Add(this.bt_XoaLop);
            this.tabPage2.Controls.Add(this.bt_SuaLop);
            this.tabPage2.Controls.Add(this.bt_ThemLop);
            this.tabPage2.Controls.Add(this.cb_ChonKhoa);
            this.tabPage2.Controls.Add(this.lb_Makhoa_Lop);
            this.tabPage2.Controls.Add(this.lb_Tenlop);
            this.tabPage2.Controls.Add(this.tb_Tenlop);
            this.tabPage2.Controls.Add(this.tb_Malop);
            this.tabPage2.Controls.Add(this.lb_Malop);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(636, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LỚP";
            // 
            // dataLOP
            // 
            this.dataLOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLOP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataLOP.Location = new System.Drawing.Point(3, 80);
            this.dataLOP.Name = "dataLOP";
            this.dataLOP.Size = new System.Drawing.Size(630, 274);
            this.dataLOP.TabIndex = 11;
            // 
            // bt_XoaLop
            // 
            this.bt_XoaLop.Location = new System.Drawing.Point(515, 41);
            this.bt_XoaLop.Name = "bt_XoaLop";
            this.bt_XoaLop.Size = new System.Drawing.Size(121, 33);
            this.bt_XoaLop.TabIndex = 10;
            this.bt_XoaLop.Text = "Xóa";
            this.bt_XoaLop.UseVisualStyleBackColor = true;
            this.bt_XoaLop.Click += new System.EventHandler(this.bt_XoaLop_Click);
            // 
            // bt_SuaLop
            // 
            this.bt_SuaLop.Location = new System.Drawing.Point(372, 41);
            this.bt_SuaLop.Name = "bt_SuaLop";
            this.bt_SuaLop.Size = new System.Drawing.Size(121, 33);
            this.bt_SuaLop.TabIndex = 9;
            this.bt_SuaLop.Text = "Sửa";
            this.bt_SuaLop.UseVisualStyleBackColor = true;
            this.bt_SuaLop.Click += new System.EventHandler(this.bt_SuaLop_Click);
            // 
            // bt_ThemLop
            // 
            this.bt_ThemLop.Location = new System.Drawing.Point(221, 41);
            this.bt_ThemLop.Name = "bt_ThemLop";
            this.bt_ThemLop.Size = new System.Drawing.Size(121, 33);
            this.bt_ThemLop.TabIndex = 8;
            this.bt_ThemLop.Text = "Thêm";
            this.bt_ThemLop.UseVisualStyleBackColor = true;
            this.bt_ThemLop.Click += new System.EventHandler(this.bt_ThemLop_Click);
            // 
            // cb_ChonKhoa
            // 
            this.cb_ChonKhoa.FormattingEnabled = true;
            this.cb_ChonKhoa.Location = new System.Drawing.Point(273, 12);
            this.cb_ChonKhoa.Name = "cb_ChonKhoa";
            this.cb_ChonKhoa.Size = new System.Drawing.Size(121, 21);
            this.cb_ChonKhoa.TabIndex = 7;
            // 
            // lb_Makhoa_Lop
            // 
            this.lb_Makhoa_Lop.AutoSize = true;
            this.lb_Makhoa_Lop.Location = new System.Drawing.Point(218, 15);
            this.lb_Makhoa_Lop.Name = "lb_Makhoa_Lop";
            this.lb_Makhoa_Lop.Size = new System.Drawing.Size(49, 13);
            this.lb_Makhoa_Lop.TabIndex = 6;
            this.lb_Makhoa_Lop.Text = "Mã khoa";
            // 
            // lb_Tenlop
            // 
            this.lb_Tenlop.AutoSize = true;
            this.lb_Tenlop.Location = new System.Drawing.Point(8, 57);
            this.lb_Tenlop.Name = "lb_Tenlop";
            this.lb_Tenlop.Size = new System.Drawing.Size(43, 13);
            this.lb_Tenlop.TabIndex = 5;
            this.lb_Tenlop.Text = "Tên lớp";
            // 
            // tb_Tenlop
            // 
            this.tb_Tenlop.Location = new System.Drawing.Point(53, 54);
            this.tb_Tenlop.Name = "tb_Tenlop";
            this.tb_Tenlop.Size = new System.Drawing.Size(119, 20);
            this.tb_Tenlop.TabIndex = 4;
            // 
            // tb_Malop
            // 
            this.tb_Malop.Location = new System.Drawing.Point(53, 15);
            this.tb_Malop.Name = "tb_Malop";
            this.tb_Malop.Size = new System.Drawing.Size(119, 20);
            this.tb_Malop.TabIndex = 3;
            // 
            // lb_Malop
            // 
            this.lb_Malop.AutoSize = true;
            this.lb_Malop.Location = new System.Drawing.Point(8, 18);
            this.lb_Malop.Name = "lb_Malop";
            this.lb_Malop.Size = new System.Drawing.Size(39, 13);
            this.lb_Malop.TabIndex = 1;
            this.lb_Malop.Text = "Mã lớp";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.dataQue);
            this.tabPage3.Controls.Add(this.bt_XoaQue);
            this.tabPage3.Controls.Add(this.bt_SuaQue);
            this.tabPage3.Controls.Add(this.bt_ThemQue);
            this.tabPage3.Controls.Add(this.tb_Tenque);
            this.tabPage3.Controls.Add(this.tb_Maque);
            this.tabPage3.Controls.Add(this.lb_Tenque);
            this.tabPage3.Controls.Add(this.lb_Maque);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(636, 357);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "QUÊ";
            // 
            // lb_Maque
            // 
            this.lb_Maque.AutoSize = true;
            this.lb_Maque.Location = new System.Drawing.Point(8, 20);
            this.lb_Maque.Name = "lb_Maque";
            this.lb_Maque.Size = new System.Drawing.Size(43, 13);
            this.lb_Maque.TabIndex = 2;
            this.lb_Maque.Text = "Mã quê";
            // 
            // lb_Tenque
            // 
            this.lb_Tenque.AutoSize = true;
            this.lb_Tenque.Location = new System.Drawing.Point(8, 54);
            this.lb_Tenque.Name = "lb_Tenque";
            this.lb_Tenque.Size = new System.Drawing.Size(47, 13);
            this.lb_Tenque.TabIndex = 3;
            this.lb_Tenque.Text = "Tên quê";
            // 
            // tb_Maque
            // 
            this.tb_Maque.Location = new System.Drawing.Point(77, 17);
            this.tb_Maque.Name = "tb_Maque";
            this.tb_Maque.Size = new System.Drawing.Size(119, 20);
            this.tb_Maque.TabIndex = 4;
            // 
            // tb_Tenque
            // 
            this.tb_Tenque.Location = new System.Drawing.Point(77, 51);
            this.tb_Tenque.Name = "tb_Tenque";
            this.tb_Tenque.Size = new System.Drawing.Size(119, 20);
            this.tb_Tenque.TabIndex = 5;
            // 
            // bt_ThemQue
            // 
            this.bt_ThemQue.Location = new System.Drawing.Point(258, 10);
            this.bt_ThemQue.Name = "bt_ThemQue";
            this.bt_ThemQue.Size = new System.Drawing.Size(121, 33);
            this.bt_ThemQue.TabIndex = 9;
            this.bt_ThemQue.Text = "Thêm";
            this.bt_ThemQue.UseVisualStyleBackColor = true;
            this.bt_ThemQue.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_SuaQue
            // 
            this.bt_SuaQue.Location = new System.Drawing.Point(385, 10);
            this.bt_SuaQue.Name = "bt_SuaQue";
            this.bt_SuaQue.Size = new System.Drawing.Size(121, 33);
            this.bt_SuaQue.TabIndex = 10;
            this.bt_SuaQue.Text = "Sửa";
            this.bt_SuaQue.UseVisualStyleBackColor = true;
            this.bt_SuaQue.Click += new System.EventHandler(this.bt_SuaQue_Click);
            // 
            // bt_XoaQue
            // 
            this.bt_XoaQue.Location = new System.Drawing.Point(512, 10);
            this.bt_XoaQue.Name = "bt_XoaQue";
            this.bt_XoaQue.Size = new System.Drawing.Size(121, 33);
            this.bt_XoaQue.TabIndex = 11;
            this.bt_XoaQue.Text = "Xóa";
            this.bt_XoaQue.UseVisualStyleBackColor = true;
            this.bt_XoaQue.Click += new System.EventHandler(this.bt_XoaQue_Click);
            // 
            // dataQue
            // 
            this.dataQue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataQue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataQue.Location = new System.Drawing.Point(3, 77);
            this.dataQue.Name = "dataQue";
            this.dataQue.Size = new System.Drawing.Size(630, 277);
            this.dataQue.TabIndex = 12;
            this.dataQue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataQue_CellClick);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.dataSV);
            this.tabPage4.Controls.Add(this.bt_XoaSV);
            this.tabPage4.Controls.Add(this.bt_SuaSV);
            this.tabPage4.Controls.Add(this.bt_ThemSV);
            this.tabPage4.Controls.Add(this.cb_Khoa);
            this.tabPage4.Controls.Add(this.lb_Khoa);
            this.tabPage4.Controls.Add(this.cb_Lop_SV);
            this.tabPage4.Controls.Add(this.lb_Lop);
            this.tabPage4.Controls.Add(this.cb_Que_SV);
            this.tabPage4.Controls.Add(this.lb_Que);
            this.tabPage4.Controls.Add(this.rd_Nu);
            this.tabPage4.Controls.Add(this.rd_Nam);
            this.tabPage4.Controls.Add(this.lb_Gioitinh);
            this.tabPage4.Controls.Add(this.dtp_Ngaysinh);
            this.tabPage4.Controls.Add(this.lb_Ngaysinh);
            this.tabPage4.Controls.Add(this.tb_TenSV);
            this.tabPage4.Controls.Add(this.tb_MaSV);
            this.tabPage4.Controls.Add(this.lb_TenSV);
            this.tabPage4.Controls.Add(this.lb_MaSV);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(636, 357);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "SINH VIÊN";
            // 
            // lb_MaSV
            // 
            this.lb_MaSV.AutoSize = true;
            this.lb_MaSV.Location = new System.Drawing.Point(8, 21);
            this.lb_MaSV.Name = "lb_MaSV";
            this.lb_MaSV.Size = new System.Drawing.Size(39, 13);
            this.lb_MaSV.TabIndex = 3;
            this.lb_MaSV.Text = "Mã SV";
            // 
            // lb_TenSV
            // 
            this.lb_TenSV.AutoSize = true;
            this.lb_TenSV.Location = new System.Drawing.Point(8, 55);
            this.lb_TenSV.Name = "lb_TenSV";
            this.lb_TenSV.Size = new System.Drawing.Size(43, 13);
            this.lb_TenSV.TabIndex = 4;
            this.lb_TenSV.Text = "Tên SV";
            // 
            // tb_MaSV
            // 
            this.tb_MaSV.Location = new System.Drawing.Point(80, 18);
            this.tb_MaSV.Name = "tb_MaSV";
            this.tb_MaSV.Size = new System.Drawing.Size(119, 20);
            this.tb_MaSV.TabIndex = 5;
            // 
            // tb_TenSV
            // 
            this.tb_TenSV.Location = new System.Drawing.Point(80, 52);
            this.tb_TenSV.Name = "tb_TenSV";
            this.tb_TenSV.Size = new System.Drawing.Size(119, 20);
            this.tb_TenSV.TabIndex = 6;
            // 
            // lb_Ngaysinh
            // 
            this.lb_Ngaysinh.AutoSize = true;
            this.lb_Ngaysinh.Location = new System.Drawing.Point(8, 90);
            this.lb_Ngaysinh.Name = "lb_Ngaysinh";
            this.lb_Ngaysinh.Size = new System.Drawing.Size(54, 13);
            this.lb_Ngaysinh.TabIndex = 7;
            this.lb_Ngaysinh.Text = "Ngày sinh";
            // 
            // dtp_Ngaysinh
            // 
            this.dtp_Ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Ngaysinh.Location = new System.Drawing.Point(81, 87);
            this.dtp_Ngaysinh.Name = "dtp_Ngaysinh";
            this.dtp_Ngaysinh.Size = new System.Drawing.Size(117, 20);
            this.dtp_Ngaysinh.TabIndex = 8;
            // 
            // lb_Gioitinh
            // 
            this.lb_Gioitinh.AutoSize = true;
            this.lb_Gioitinh.Location = new System.Drawing.Point(8, 124);
            this.lb_Gioitinh.Name = "lb_Gioitinh";
            this.lb_Gioitinh.Size = new System.Drawing.Size(47, 13);
            this.lb_Gioitinh.TabIndex = 9;
            this.lb_Gioitinh.Text = "Giới tính";
            // 
            // rd_Nam
            // 
            this.rd_Nam.AutoSize = true;
            this.rd_Nam.Location = new System.Drawing.Point(81, 124);
            this.rd_Nam.Name = "rd_Nam";
            this.rd_Nam.Size = new System.Drawing.Size(47, 17);
            this.rd_Nam.TabIndex = 10;
            this.rd_Nam.TabStop = true;
            this.rd_Nam.Text = "Nam";
            this.rd_Nam.UseVisualStyleBackColor = true;
            // 
            // rd_Nu
            // 
            this.rd_Nu.AutoSize = true;
            this.rd_Nu.Location = new System.Drawing.Point(134, 124);
            this.rd_Nu.Name = "rd_Nu";
            this.rd_Nu.Size = new System.Drawing.Size(39, 17);
            this.rd_Nu.TabIndex = 11;
            this.rd_Nu.TabStop = true;
            this.rd_Nu.Text = "Nữ";
            this.rd_Nu.UseVisualStyleBackColor = true;
            // 
            // lb_Que
            // 
            this.lb_Que.AutoSize = true;
            this.lb_Que.Location = new System.Drawing.Point(257, 21);
            this.lb_Que.Name = "lb_Que";
            this.lb_Que.Size = new System.Drawing.Size(54, 13);
            this.lb_Que.TabIndex = 12;
            this.lb_Que.Text = "Quê quán";
            // 
            // cb_Que_SV
            // 
            this.cb_Que_SV.FormattingEnabled = true;
            this.cb_Que_SV.Location = new System.Drawing.Point(348, 17);
            this.cb_Que_SV.Name = "cb_Que_SV";
            this.cb_Que_SV.Size = new System.Drawing.Size(152, 21);
            this.cb_Que_SV.TabIndex = 13;
            // 
            // lb_Lop
            // 
            this.lb_Lop.AutoSize = true;
            this.lb_Lop.Location = new System.Drawing.Point(257, 55);
            this.lb_Lop.Name = "lb_Lop";
            this.lb_Lop.Size = new System.Drawing.Size(25, 13);
            this.lb_Lop.TabIndex = 14;
            this.lb_Lop.Text = "Lớp";
            // 
            // cb_Lop_SV
            // 
            this.cb_Lop_SV.FormattingEnabled = true;
            this.cb_Lop_SV.Location = new System.Drawing.Point(348, 52);
            this.cb_Lop_SV.Name = "cb_Lop_SV";
            this.cb_Lop_SV.Size = new System.Drawing.Size(152, 21);
            this.cb_Lop_SV.TabIndex = 15;
            // 
            // lb_Khoa
            // 
            this.lb_Khoa.AutoSize = true;
            this.lb_Khoa.Location = new System.Drawing.Point(257, 93);
            this.lb_Khoa.Name = "lb_Khoa";
            this.lb_Khoa.Size = new System.Drawing.Size(32, 13);
            this.lb_Khoa.TabIndex = 16;
            this.lb_Khoa.Text = "Khoa";
            // 
            // cb_Khoa
            // 
            this.cb_Khoa.FormattingEnabled = true;
            this.cb_Khoa.Location = new System.Drawing.Point(348, 87);
            this.cb_Khoa.Name = "cb_Khoa";
            this.cb_Khoa.Size = new System.Drawing.Size(152, 21);
            this.cb_Khoa.TabIndex = 17;
            // 
            // bt_ThemSV
            // 
            this.bt_ThemSV.Location = new System.Drawing.Point(260, 114);
            this.bt_ThemSV.Name = "bt_ThemSV";
            this.bt_ThemSV.Size = new System.Drawing.Size(121, 33);
            this.bt_ThemSV.TabIndex = 18;
            this.bt_ThemSV.Text = "Thêm";
            this.bt_ThemSV.UseVisualStyleBackColor = true;
            this.bt_ThemSV.Click += new System.EventHandler(this.bt_ThemSV_Click);
            // 
            // bt_SuaSV
            // 
            this.bt_SuaSV.Location = new System.Drawing.Point(387, 114);
            this.bt_SuaSV.Name = "bt_SuaSV";
            this.bt_SuaSV.Size = new System.Drawing.Size(121, 33);
            this.bt_SuaSV.TabIndex = 19;
            this.bt_SuaSV.Text = "Sửa";
            this.bt_SuaSV.UseVisualStyleBackColor = true;
            this.bt_SuaSV.Click += new System.EventHandler(this.bt_SuaSV_Click);
            // 
            // bt_XoaSV
            // 
            this.bt_XoaSV.Location = new System.Drawing.Point(512, 114);
            this.bt_XoaSV.Name = "bt_XoaSV";
            this.bt_XoaSV.Size = new System.Drawing.Size(121, 33);
            this.bt_XoaSV.TabIndex = 20;
            this.bt_XoaSV.Text = "Xóa";
            this.bt_XoaSV.UseVisualStyleBackColor = true;
            this.bt_XoaSV.Click += new System.EventHandler(this.bt_XoaSV_Click);
            // 
            // dataSV
            // 
            this.dataSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataSV.Location = new System.Drawing.Point(3, 153);
            this.dataSV.Name = "dataSV";
            this.dataSV.Size = new System.Drawing.Size(630, 201);
            this.dataSV.TabIndex = 21;
            this.dataSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSV_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 383);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKhoa)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLOP)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataQue)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataKhoa;
        private System.Windows.Forms.Button bt_XoaK;
        private System.Windows.Forms.Button bt_SuaK;
        private System.Windows.Forms.Button bt_ThemK;
        private System.Windows.Forms.TextBox tb_Tenkhoa;
        private System.Windows.Forms.TextBox tb_Makhoa;
        private System.Windows.Forms.Label lb_Tenkhoa;
        private System.Windows.Forms.Label lb_Makhoa;
        private System.Windows.Forms.ComboBox cb_ChonKhoa;
        private System.Windows.Forms.Label lb_Makhoa_Lop;
        private System.Windows.Forms.Label lb_Tenlop;
        private System.Windows.Forms.TextBox tb_Tenlop;
        private System.Windows.Forms.TextBox tb_Malop;
        private System.Windows.Forms.Label lb_Malop;
        private System.Windows.Forms.Button bt_XoaLop;
        private System.Windows.Forms.Button bt_SuaLop;
        private System.Windows.Forms.Button bt_ThemLop;
        private System.Windows.Forms.DataGridView dataLOP;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataQue;
        private System.Windows.Forms.Button bt_XoaQue;
        private System.Windows.Forms.Button bt_SuaQue;
        private System.Windows.Forms.Button bt_ThemQue;
        private System.Windows.Forms.TextBox tb_Tenque;
        private System.Windows.Forms.TextBox tb_Maque;
        private System.Windows.Forms.Label lb_Tenque;
        private System.Windows.Forms.Label lb_Maque;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button bt_SuaSV;
        private System.Windows.Forms.Button bt_ThemSV;
        private System.Windows.Forms.ComboBox cb_Khoa;
        private System.Windows.Forms.Label lb_Khoa;
        private System.Windows.Forms.ComboBox cb_Lop_SV;
        private System.Windows.Forms.Label lb_Lop;
        private System.Windows.Forms.ComboBox cb_Que_SV;
        private System.Windows.Forms.Label lb_Que;
        private System.Windows.Forms.RadioButton rd_Nu;
        private System.Windows.Forms.RadioButton rd_Nam;
        private System.Windows.Forms.Label lb_Gioitinh;
        private System.Windows.Forms.DateTimePicker dtp_Ngaysinh;
        private System.Windows.Forms.Label lb_Ngaysinh;
        private System.Windows.Forms.TextBox tb_TenSV;
        private System.Windows.Forms.TextBox tb_MaSV;
        private System.Windows.Forms.Label lb_TenSV;
        private System.Windows.Forms.Label lb_MaSV;
        private System.Windows.Forms.Button bt_XoaSV;
        private System.Windows.Forms.DataGridView dataSV;
    }
}

