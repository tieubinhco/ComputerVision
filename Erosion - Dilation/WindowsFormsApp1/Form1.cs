using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    using Emgu.CV;
    using Emgu.CV.Structure;
    using System;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        private Image<Gray, byte> grayimg;
        private Image<Bgr, byte> img = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dlg = new OpenFileDialog();
            if (open_dlg.ShowDialog() == DialogResult.OK)
            {
                img = new Image<Bgr, byte>(open_dlg.FileName);
            }
            if (img != null)
            {
                pictureBox1.Image = img.ToBitmap();
            }
        }

        private void btn_gray_Click(object sender, EventArgs e)
        {
            grayimg = img.Convert<Gray, byte>();
            pictureBox2.Image = grayimg.ToBitmap();
        }
    }
}
