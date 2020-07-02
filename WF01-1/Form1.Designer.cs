namespace WF01_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_SoA = new System.Windows.Forms.TextBox();
            this.tb_SoB = new System.Windows.Forms.TextBox();
            this.bt_Tinh = new System.Windows.Forms.Button();
            this.lbTong = new System.Windows.Forms.Label();
            this.lbHieu = new System.Windows.Forms.Label();
            this.lbTich = new System.Windows.Forms.Label();
            this.lbThuong = new System.Windows.Forms.Label();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số b:";
            // 
            // tb_SoA
            // 
            this.tb_SoA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_SoA.Location = new System.Drawing.Point(93, 27);
            this.tb_SoA.Name = "tb_SoA";
            this.tb_SoA.Size = new System.Drawing.Size(357, 20);
            this.tb_SoA.TabIndex = 1;
            this.tb_SoA.TextChanged += new System.EventHandler(this.tb_SoA_TextChanged);
            // 
            // tb_SoB
            // 
            this.tb_SoB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_SoB.Location = new System.Drawing.Point(93, 59);
            this.tb_SoB.Name = "tb_SoB";
            this.tb_SoB.Size = new System.Drawing.Size(357, 20);
            this.tb_SoB.TabIndex = 2;
            this.tb_SoB.TextChanged += new System.EventHandler(this.tb_SoB_TextChanged);
            // 
            // bt_Tinh
            // 
            this.bt_Tinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Tinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Tinh.Location = new System.Drawing.Point(465, 25);
            this.bt_Tinh.Name = "bt_Tinh";
            this.bt_Tinh.Size = new System.Drawing.Size(97, 54);
            this.bt_Tinh.TabIndex = 3;
            this.bt_Tinh.Text = "Tính";
            this.bt_Tinh.UseVisualStyleBackColor = true;
            this.bt_Tinh.Click += new System.EventHandler(this.bt_Tinh_Click_1);
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTong.Location = new System.Drawing.Point(31, 109);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(97, 20);
            this.lbTong.TabIndex = 5;
            this.lbTong.Text = "Tổng a + b =";
            // 
            // lbHieu
            // 
            this.lbHieu.AutoSize = true;
            this.lbHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHieu.Location = new System.Drawing.Point(31, 151);
            this.lbHieu.Name = "lbHieu";
            this.lbHieu.Size = new System.Drawing.Size(90, 20);
            this.lbHieu.TabIndex = 6;
            this.lbHieu.Text = "Hiệu a - b =";
            // 
            // lbTich
            // 
            this.lbTich.AutoSize = true;
            this.lbTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTich.Location = new System.Drawing.Point(31, 194);
            this.lbTich.Name = "lbTich";
            this.lbTich.Size = new System.Drawing.Size(87, 20);
            this.lbTich.TabIndex = 7;
            this.lbTich.Text = "Tích a * b =";
            // 
            // lbThuong
            // 
            this.lbThuong.AutoSize = true;
            this.lbThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThuong.Location = new System.Drawing.Point(31, 237);
            this.lbThuong.Name = "lbThuong";
            this.lbThuong.Size = new System.Drawing.Size(110, 20);
            this.lbThuong.TabIndex = 8;
            this.lbThuong.Text = "Thương a / b =";
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Thoat.Location = new System.Drawing.Point(465, 255);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(97, 54);
            this.bt_Thoat.TabIndex = 4;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(152, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 12;
            // 
            // Form1
            // 
            this.AcceptButton = this.bt_Tinh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelButton = this.bt_Thoat;
            this.ClientSize = new System.Drawing.Size(586, 332);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.lbThuong);
            this.Controls.Add(this.lbTich);
            this.Controls.Add(this.lbHieu);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.bt_Tinh);
            this.Controls.Add(this.tb_SoB);
            this.Controls.Add(this.tb_SoA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cộng trừ nhân chia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_SoA;
        private System.Windows.Forms.TextBox tb_SoB;
        private System.Windows.Forms.Button bt_Tinh;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label lbHieu;
        private System.Windows.Forms.Label lbTich;
        private System.Windows.Forms.Label lbThuong;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

