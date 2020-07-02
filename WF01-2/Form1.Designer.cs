namespace WF01_2
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
            this.lb_Nhap = new System.Windows.Forms.Label();
            this.tb_NhapSo = new System.Windows.Forms.TextBox();
            this.bt_Tinh = new System.Windows.Forms.Button();
            this.lb_SNT = new System.Windows.Forms.Label();
            this.lb_SCP = new System.Windows.Forms.Label();
            this.lb_SHC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Nhap
            // 
            this.lb_Nhap.AutoSize = true;
            this.lb_Nhap.Location = new System.Drawing.Point(32, 37);
            this.lb_Nhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Nhap.Name = "lb_Nhap";
            this.lb_Nhap.Size = new System.Drawing.Size(72, 16);
            this.lb_Nhap.TabIndex = 0;
            this.lb_Nhap.Text = "Nhập số n:";
            // 
            // tb_NhapSo
            // 
            this.tb_NhapSo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_NhapSo.Location = new System.Drawing.Point(111, 34);
            this.tb_NhapSo.Name = "tb_NhapSo";
            this.tb_NhapSo.Size = new System.Drawing.Size(244, 22);
            this.tb_NhapSo.TabIndex = 1;
            this.tb_NhapSo.Leave += new System.EventHandler(this.tb_NhapSo_Leave);
            // 
            // bt_Tinh
            // 
            this.bt_Tinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Tinh.Location = new System.Drawing.Point(384, 21);
            this.bt_Tinh.Name = "bt_Tinh";
            this.bt_Tinh.Size = new System.Drawing.Size(88, 49);
            this.bt_Tinh.TabIndex = 2;
            this.bt_Tinh.Text = "Hiển thị";
            this.bt_Tinh.UseVisualStyleBackColor = true;
            this.bt_Tinh.Click += new System.EventHandler(this.bt_Tinh_Click);
            // 
            // lb_SNT
            // 
            this.lb_SNT.AutoSize = true;
            this.lb_SNT.Location = new System.Drawing.Point(32, 103);
            this.lb_SNT.Name = "lb_SNT";
            this.lb_SNT.Size = new System.Drawing.Size(174, 16);
            this.lb_SNT.TabIndex = 3;
            this.lb_SNT.Text = "Các số nguyên tố nhỏ hơn n:";
            // 
            // lb_SCP
            // 
            this.lb_SCP.AutoSize = true;
            this.lb_SCP.Location = new System.Drawing.Point(32, 140);
            this.lb_SCP.Name = "lb_SCP";
            this.lb_SCP.Size = new System.Drawing.Size(195, 16);
            this.lb_SCP.TabIndex = 4;
            this.lb_SCP.Text = "Các số chính phương nhỏ hơn n:";
            // 
            // lb_SHC
            // 
            this.lb_SHC.AutoSize = true;
            this.lb_SHC.Location = new System.Drawing.Point(32, 177);
            this.lb_SHC.Name = "lb_SHC";
            this.lb_SHC.Size = new System.Drawing.Size(180, 16);
            this.lb_SHC.TabIndex = 5;
            this.lb_SHC.Text = "Các số hoàn chỉnh nhỏ hơn n:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 235);
            this.Controls.Add(this.lb_SHC);
            this.Controls.Add(this.lb_SCP);
            this.Controls.Add(this.lb_SNT);
            this.Controls.Add(this.bt_Tinh);
            this.Controls.Add(this.tb_NhapSo);
            this.Controls.Add(this.lb_Nhap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình nhập số";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Nhap;
        private System.Windows.Forms.TextBox tb_NhapSo;
        private System.Windows.Forms.Button bt_Tinh;
        private System.Windows.Forms.Label lb_SNT;
        private System.Windows.Forms.Label lb_SCP;
        private System.Windows.Forms.Label lb_SHC;
    }
}

