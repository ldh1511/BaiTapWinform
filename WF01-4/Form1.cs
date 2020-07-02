using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF01_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnstr_BackColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = color.Color;
                
            }
           
        }
        private void mnstr_BackImage_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.SdImg += F2_SdImg;
            f2.ShowDialog();
        }

        private void F2_SdImg(Bitmap a)
        {
            pictureBox1.Image = a;
        }

        private void mnstr_Font_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                menuStrip1.Font = fd.Font;
            }
        }

        private void changeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if(openfile.ShowDialog()== DialogResult.OK)
            {
                string a;
                a = openfile.FileName;
                pictureBox1.Image = Image.FromFile(a);
            }
        }
    }
}
