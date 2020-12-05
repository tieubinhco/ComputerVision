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
        private Image<Gray, byte> binaryimg;
        
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



        //Define dilation and erosion images
        private Image<Gray, byte> dilationimg;
        private Image<Gray, byte> erosionimg;

        private void row_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void column_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
 
        private void dilation_btn_Click(object sender, EventArgs e)
        {
            //Define kernel rows, columns
            int ker_row = Convert.ToInt16(row_txtbox.Text);
            int ker_column = Convert.ToInt16(column_txtbox.Text);

            int h = binaryimg.Height;
            int w = binaryimg.Width;
            dilationimg = binaryimg.CopyBlank();


            int i,j,k,l;

            for (i = 1; i < h-1; i++)
            {
                for (j = 1; j < w-1; j++)
                {
                    if (binaryimg.Data[i, j, 0] == 255)
                        for (k = -(ker_row-1)/2; k <= (ker_row-1)/2; k++)
                            for (l = -(ker_column-1)/2; l <= (ker_column - 1) / 2; l++)
                                if (k != 0 && l != 0)
                                    dilationimg.Data[i + k, j + l, 0] = 255;
                                else continue;
                    else continue;
                }
            }
            pictureBox2.Image = dilationimg.ToBitmap();
        }

        private void erosion_btn_Click(object sender, EventArgs e)
        {
            //Define kernel rows, columns
            int ker_row = Convert.ToInt16(row_txtbox.Text);
            int ker_column = Convert.ToInt16(column_txtbox.Text);

            int h = binaryimg.Height;
            int w = binaryimg.Width;
            
            erosionimg = binaryimg.CopyBlank();

            int i, j, k, l;
            for (i = 1; i < h - 1; i++)
            {
                for (j = 1; j < w - 1; j++)
                {
                    int count = 0; //variable to count number of forground elements under Bz
                    if (binaryimg.Data[i, j, 0] == 255)
                    {
                        for (k = -(ker_row - 1) / 2; k <= (ker_row - 1) / 2; k++)
                            for (l = -(ker_column - 1) / 2; l <= (ker_column - 1) / 2; l++)
                            {
                                if (k != 0 && l != 0)
                                    if (binaryimg.Data[i + k, j + l, 0] == 255) 
                                        count += 1;
                                    else continue;

                            }
                        if (count ==(ker_column * ker_row - 1)) erosionimg.Data[i, j, 0] = 255;
                        else erosionimg.Data[i, j, 0] = 0;
                    }
                    else continue;
                }
            }
            pictureBox2.Image = erosionimg.ToBitmap();
        }

        private void otsu_btn_Click(object sender, EventArgs e)
        {
            binaryimg = grayimg.CopyBlank();
            CvInvoke.Threshold(grayimg, binaryimg, 0, 255, Emgu.CV.CvEnum.ThresholdType.Otsu);
            CvInvoke.AdaptiveThreshold(grayimg, binaryimg, 255,
            Emgu.CV.CvEnum.AdaptiveThresholdType.GaussianC,
            Emgu.CV.CvEnum.ThresholdType.Binary, 17, 0);
            pictureBox2.Image = binaryimg.ToBitmap();
        }
    }
}
