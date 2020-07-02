namespace WF01_4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstr_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstr_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstr_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnstr_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstr_BackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.changeImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstr_Font = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstr_BackImage = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.changeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnstr_Open,
            this.mnstr_Edit,
            this.mnstr_Print,
            this.toolStripSeparator1,
            this.mnstr_Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnstr_Open
            // 
            this.mnstr_Open.Name = "mnstr_Open";
            this.mnstr_Open.Size = new System.Drawing.Size(149, 36);
            this.mnstr_Open.Text = "Open";
            // 
            // mnstr_Edit
            // 
            this.mnstr_Edit.Name = "mnstr_Edit";
            this.mnstr_Edit.Size = new System.Drawing.Size(149, 36);
            this.mnstr_Edit.Text = "Edit";
            // 
            // mnstr_Print
            // 
            this.mnstr_Print.Name = "mnstr_Print";
            this.mnstr_Print.Size = new System.Drawing.Size(149, 36);
            this.mnstr_Print.Text = "Print";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // mnstr_Exit
            // 
            this.mnstr_Exit.Name = "mnstr_Exit";
            this.mnstr_Exit.Size = new System.Drawing.Size(149, 36);
            this.mnstr_Exit.Text = "Exit";
            this.mnstr_Exit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnstr_BackColor,
            this.changeImageToolStripMenuItem,
            this.mnstr_Font,
            this.mnstr_BackImage});
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(109, 36);
            this.changeToolStripMenuItem.Text = "Change";
            // 
            // mnstr_BackColor
            // 
            this.mnstr_BackColor.Name = "mnstr_BackColor";
            this.mnstr_BackColor.Size = new System.Drawing.Size(245, 36);
            this.mnstr_BackColor.Text = "Back Color";
            this.mnstr_BackColor.Click += new System.EventHandler(this.mnstr_BackColor_Click);
            // 
            // changeImageToolStripMenuItem
            // 
            this.changeImageToolStripMenuItem.Name = "changeImageToolStripMenuItem";
            this.changeImageToolStripMenuItem.Size = new System.Drawing.Size(245, 36);
            this.changeImageToolStripMenuItem.Text = "Back Image";
            this.changeImageToolStripMenuItem.Click += new System.EventHandler(this.changeImageToolStripMenuItem_Click);
            // 
            // mnstr_Font
            // 
            this.mnstr_Font.Name = "mnstr_Font";
            this.mnstr_Font.Size = new System.Drawing.Size(245, 36);
            this.mnstr_Font.Text = "Font";
            this.mnstr_Font.Click += new System.EventHandler(this.mnstr_Font_Click);
            // 
            // mnstr_BackImage
            // 
            this.mnstr_BackImage.Name = "mnstr_BackImage";
            this.mnstr_BackImage.Size = new System.Drawing.Size(245, 36);
            this.mnstr_BackImage.Text = "Change Image";
            this.mnstr_BackImage.Click += new System.EventHandler(this.mnstr_BackImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(642, 382);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 441);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lê Dương Hùng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnstr_Open;
        private System.Windows.Forms.ToolStripMenuItem mnstr_Edit;
        private System.Windows.Forms.ToolStripMenuItem mnstr_Print;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnstr_Exit;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnstr_BackColor;
        private System.Windows.Forms.ToolStripMenuItem mnstr_BackImage;
        private System.Windows.Forms.ToolStripMenuItem mnstr_Font;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem changeImageToolStripMenuItem;
    }
}

