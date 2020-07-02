using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF01_4
{
    public partial class Form2 : Form
    {
        public delegate void SendImage(Bitmap a);
        public event SendImage SdImg;
        public Form2()
        {
            InitializeComponent();
            LoadImageName();
        }
        string extension = ".jpg";
        Bitmap b;
        void LoadImageName()
        {
            List<string> ListImage = new List<string>() { "1", "2", "3", "4" };
            cmb_1.DataSource = ListImage;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(Application.StartupPath + "\\Resource\\" + cmb_1.SelectedValue.ToString() +
                     extension);
            b = bm;
            SdImg(b);
        }
    }
}
