using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Windows.Forms;

namespace Example_1
{
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> img = null;
        private Image<Gray, byte> grayimg;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog open_dlg = new OpenFileDialog();
            if (open_dlg.ShowDialog() == DialogResult.OK)
            {
                img = new Image<Bgr, byte>(open_dlg.FileName);
            }
            if (img != null) imageBox1 = img.ToBitmap();*/
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dlg = new OpenFileDialog();
            if (open_dlg.ShowDialog() == DialogResult.OK)
            {
                img = new Image<Bgr, byte>(open_dlg.FileName);
            }
            if (img != null)
            {
                pictureBox1.Image = img.ToBitmap();
                imageBox1.Image = img;
            }
        }

        private void btn_gray_Click(object sender, EventArgs e)
        {
            grayimg = img.Convert<Gray, byte>();
            imageBox1.Image = grayimg;
        }

        private void btn_gray_2_Click(object sender, EventArgs e)
        {
            int h = img.Height;
            int w = img.Width;
            grayimg = new Image<Gray, byte>(w, h);
            imageBox1.Image = grayimg;
            int r, c;
            for (r = 0; r < h; r++)
            {
                for (c = 0; c < w; c++)
                {
                    grayimg.Data[r, c, 0] = (byte)(0.114 * img.Data[r, c, 0] //blue
                        + 0.578 * img.Data[r, c, 1]        //green
                        + 0.299 * img.Data[r, c, 2]);        //red        }
                }
            }
            imageBox1.Image = grayimg;
        }

        private void btn_thresholding1_Click(object sender, EventArgs e)
        {
            byte T = byte.Parse(textBox1.Text);
            Image<Gray, byte> binaryimg =
                grayimg.ThresholdBinary(new Gray(T), new Gray(255));
            imageBox1.Image = binaryimg;
        }

        private void btn_thresholding2_Click(object sender, EventArgs e)
        {
            int h = img.Height;
            int w = img.Width;
            Image<Gray, byte> binaryimg = new Image<Gray, byte>(w, h);

            int r, c;
            byte T = byte.Parse(textBox1.Text);

            for (r = 0; r < h; r++)
            {
                for (c = 0; c < w; c++)
                {
                    if (grayimg.Data[r, c, 0] > T)
                        binaryimg.Data[r, c, 0] = 255;
                    //else
                    //binaryimg.Data[r,c,0]=0;
                }
            }
            imageBox1.Image = binaryimg;
        }

        private void btn_otsu_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> binaryimg = grayimg.CopyBlank();
            CvInvoke.Threshold(grayimg, binaryimg, 0, 255, Emgu.CV.CvEnum.ThresholdType.Otsu);
            CvInvoke.AdaptiveThreshold(grayimg, binaryimg, 255, Emgu.CV.CvEnum.AdaptiveThresholdType.GaussianC, Emgu.CV.CvEnum.ThresholdType.Binary, 17, 0);
            imageBox1.Image = binaryimg;
        }

        private void btn_gaussianC_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> binaryimg = grayimg.CopyBlank();
            CvInvoke.AdaptiveThreshold(grayimg, binaryimg, 255, Emgu.CV.CvEnum.AdaptiveThresholdType.GaussianC, Emgu.CV.CvEnum.ThresholdType.Binary, 17, 0);
            imageBox1.Image = binaryimg;
        }
    }
}