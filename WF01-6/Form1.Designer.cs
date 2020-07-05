namespace WF01_6
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
            this.lb_MaSV = new System.Windows.Forms.Label();
            this.tb_MaSV = new System.Windows.Forms.TextBox();
            this.lb_Hoten = new System.Windows.Forms.Label();
            this.tb_Hoten = new System.Windows.Forms.TextBox();
            this.lb_Ngaysinh = new System.Windows.Forms.Label();
            this.tb_Ngaysinh = new System.Windows.Forms.TextBox();
            this.lb_Que = new System.Windows.Forms.Label();
            this.cb_Que = new System.Windows.Forms.ComboBox();
            this.lb_Lop = new System.Windows.Forms.Label();
            this.cb_Lop = new System.Windows.Forms.ComboBox();
            this.lb_Khoa = new System.Windows.Forms.Label();
            this.cb_Khoa = new System.Windows.Forms.ComboBox();
            this.lb_Gt = new System.Windows.Forms.Label();
            this.rd_Nam = new System.Windows.Forms.RadioButton();
            this.rd_Nu = new System.Windows.Forms.RadioButton();
            this.bt_Them = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_MaSV
            // 
            this.lb_MaSV.AutoSize = true;
            this.lb_MaSV.Location = new System.Drawing.Point(28, 32);
            this.lb_MaSV.Name = "lb_MaSV";
            this.lb_MaSV.Size = new System.Drawing.Size(39, 13);
            this.lb_MaSV.TabIndex = 0;
            this.lb_MaSV.Text = "Mã SV";
            // 
            // tb_MaSV
            // 
            this.tb_MaSV.Location = new System.Drawing.Point(88, 29);
            this.tb_MaSV.Name = "tb_MaSV";
            this.tb_MaSV.Size = new System.Drawing.Size(211, 20);
            this.tb_MaSV.TabIndex = 1;
            // 
            // lb_Hoten
            // 
            this.lb_Hoten.AutoSize = true;
            this.lb_Hoten.Location = new System.Drawing.Point(28, 80);
            this.lb_Hoten.Name = "lb_Hoten";
            this.lb_Hoten.Size = new System.Drawing.Size(39, 13);
            this.lb_Hoten.TabIndex = 2;
            this.lb_Hoten.Text = "Họ tên";
            // 
            // tb_Hoten
            // 
            this.tb_Hoten.Location = new System.Drawing.Point(88, 77);
            this.tb_Hoten.Name = "tb_Hoten";
            this.tb_Hoten.Size = new System.Drawing.Size(211, 20);
            this.tb_Hoten.TabIndex = 3;
            // 
            // lb_Ngaysinh
            // 
            this.lb_Ngaysinh.AutoSize = true;
            this.lb_Ngaysinh.Location = new System.Drawing.Point(28, 126);
            this.lb_Ngaysinh.Name = "lb_Ngaysinh";
            this.lb_Ngaysinh.Size = new System.Drawing.Size(54, 13);
            this.lb_Ngaysinh.TabIndex = 4;
            this.lb_Ngaysinh.Text = "Ngày sinh";
            // 
            // tb_Ngaysinh
            // 
            this.tb_Ngaysinh.Location = new System.Drawing.Point(88, 123);
            this.tb_Ngaysinh.Name = "tb_Ngaysinh";
            this.tb_Ngaysinh.Size = new System.Drawing.Size(211, 20);
            this.tb_Ngaysinh.TabIndex = 5;
            // 
            // lb_Que
            // 
            this.lb_Que.AutoSize = true;
            this.lb_Que.Location = new System.Drawing.Point(428, 32);
            this.lb_Que.Name = "lb_Que";
            this.lb_Que.Size = new System.Drawing.Size(54, 13);
            this.lb_Que.TabIndex = 6;
            this.lb_Que.Text = "Quê quán";
            // 
            // cb_Que
            // 
            this.cb_Que.FormattingEnabled = true;
            this.cb_Que.Items.AddRange(new object[] {
            "Hà Nội",
            "Hải Phòng",
            "Quảng Ninh",
            "Hưng Yên",
            "Hồ Chí Minh",
            "Bình Dương"});
            this.cb_Que.Location = new System.Drawing.Point(507, 29);
            this.cb_Que.Name = "cb_Que";
            this.cb_Que.Size = new System.Drawing.Size(229, 21);
            this.cb_Que.TabIndex = 7;
            // 
            // lb_Lop
            // 
            this.lb_Lop.AutoSize = true;
            this.lb_Lop.Location = new System.Drawing.Point(428, 80);
            this.lb_Lop.Name = "lb_Lop";
            this.lb_Lop.Size = new System.Drawing.Size(25, 13);
            this.lb_Lop.TabIndex = 8;
            this.lb_Lop.Text = "Lớp";
            // 
            // cb_Lop
            // 
            this.cb_Lop.FormattingEnabled = true;
            this.cb_Lop.Items.AddRange(new object[] {
            "60TH1",
            "60TH2",
            "60TH3",
            "60TH4",
            "60PM1",
            "60PM2",
            "60TH1",
            "60KT1",
            "60KT2"});
            this.cb_Lop.Location = new System.Drawing.Point(507, 77);
            this.cb_Lop.Name = "cb_Lop";
            this.cb_Lop.Size = new System.Drawing.Size(229, 21);
            this.cb_Lop.TabIndex = 9;
            // 
            // lb_Khoa
            // 
            this.lb_Khoa.AutoSize = true;
            this.lb_Khoa.Location = new System.Drawing.Point(428, 126);
            this.lb_Khoa.Name = "lb_Khoa";
            this.lb_Khoa.Size = new System.Drawing.Size(32, 13);
            this.lb_Khoa.TabIndex = 10;
            this.lb_Khoa.Text = "Khoa";
            // 
            // cb_Khoa
            // 
            this.cb_Khoa.FormattingEnabled = true;
            this.cb_Khoa.Items.AddRange(new object[] {
            "Công nghệ Thông tin",
            "Kinh tế và Quản lý"});
            this.cb_Khoa.Location = new System.Drawing.Point(507, 122);
            this.cb_Khoa.Name = "cb_Khoa";
            this.cb_Khoa.Size = new System.Drawing.Size(229, 21);
            this.cb_Khoa.TabIndex = 11;
            // 
            // lb_Gt
            // 
            this.lb_Gt.AutoSize = true;
            this.lb_Gt.Location = new System.Drawing.Point(28, 167);
            this.lb_Gt.Name = "lb_Gt";
            this.lb_Gt.Size = new System.Drawing.Size(47, 13);
            this.lb_Gt.TabIndex = 12;
            this.lb_Gt.Text = "Giới tính";
            // 
            // rd_Nam
            // 
            this.rd_Nam.AutoSize = true;
            this.rd_Nam.Location = new System.Drawing.Point(88, 165);
            this.rd_Nam.Name = "rd_Nam";
            this.rd_Nam.Size = new System.Drawing.Size(47, 17);
            this.rd_Nam.TabIndex = 13;
            this.rd_Nam.TabStop = true;
            this.rd_Nam.Text = "Nam";
            this.rd_Nam.UseVisualStyleBackColor = true;
            // 
            // rd_Nu
            // 
            this.rd_Nu.AutoSize = true;
            this.rd_Nu.Location = new System.Drawing.Point(141, 165);
            this.rd_Nu.Name = "rd_Nu";
            this.rd_Nu.Size = new System.Drawing.Size(39, 17);
            this.rd_Nu.TabIndex = 14;
            this.rd_Nu.TabStop = true;
            this.rd_Nu.Text = "Nữ";
            this.rd_Nu.UseVisualStyleBackColor = true;
            // 
            // bt_Them
            // 
            this.bt_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Them.Location = new System.Drawing.Point(439, 159);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(95, 28);
            this.bt_Them.TabIndex = 15;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.NgaySinh,
            this.Gioitinh,
            this.Quequan,
            this.Lop,
            this.Khoa});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 228);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MaSV
            // 
            this.MaSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã SV";
            this.MaSV.Name = "MaSV";
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            // 
            // NgaySinh
            // 
            this.NgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // Gioitinh
            // 
            this.Gioitinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gioitinh.DataPropertyName = "Gioitinh";
            this.Gioitinh.HeaderText = "Giới tính";
            this.Gioitinh.Name = "Gioitinh";
            // 
            // Quequan
            // 
            this.Quequan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quequan.DataPropertyName = "Quequan";
            this.Quequan.HeaderText = "Quê quán";
            this.Quequan.Name = "Quequan";
            // 
            // Lop
            // 
            this.Lop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Lop.DataPropertyName = "Lop";
            this.Lop.HeaderText = "Lớp";
            this.Lop.Name = "Lop";
            // 
            // Khoa
            // 
            this.Khoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Khoa.DataPropertyName = "Khoa";
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.Name = "Khoa";
            // 
            // bt_Sua
            // 
            this.bt_Sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Sua.Location = new System.Drawing.Point(540, 159);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(95, 28);
            this.bt_Sua.TabIndex = 17;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = true;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Xoa.Location = new System.Drawing.Point(641, 159);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(95, 28);
            this.bt_Xoa.TabIndex = 18;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 421);
            this.Controls.Add(this.bt_Xoa);
            this.Controls.Add(this.bt_Sua);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_Them);
            this.Controls.Add(this.rd_Nu);
            this.Controls.Add(this.rd_Nam);
            this.Controls.Add(this.lb_Gt);
            this.Controls.Add(this.cb_Khoa);
            this.Controls.Add(this.lb_Khoa);
            this.Controls.Add(this.cb_Lop);
            this.Controls.Add(this.lb_Lop);
            this.Controls.Add(this.cb_Que);
            this.Controls.Add(this.lb_Que);
            this.Controls.Add(this.tb_Ngaysinh);
            this.Controls.Add(this.lb_Ngaysinh);
            this.Controls.Add(this.tb_Hoten);
            this.Controls.Add(this.lb_Hoten);
            this.Controls.Add(this.tb_MaSV);
            this.Controls.Add(this.lb_MaSV);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập thông tin sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_MaSV;
        private System.Windows.Forms.TextBox tb_MaSV;
        private System.Windows.Forms.Label lb_Hoten;
        private System.Windows.Forms.TextBox tb_Hoten;
        private System.Windows.Forms.Label lb_Ngaysinh;
        private System.Windows.Forms.TextBox tb_Ngaysinh;
        private System.Windows.Forms.Label lb_Que;
        private System.Windows.Forms.ComboBox cb_Que;
        private System.Windows.Forms.Label lb_Lop;
        private System.Windows.Forms.ComboBox cb_Lop;
        private System.Windows.Forms.Label lb_Khoa;
        private System.Windows.Forms.ComboBox cb_Khoa;
        private System.Windows.Forms.Label lb_Gt;
        private System.Windows.Forms.RadioButton rd_Nam;
        private System.Windows.Forms.RadioButton rd_Nu;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Xoa;
    }
}

