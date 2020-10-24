namespace Example_1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Open = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.btn_gray = new System.Windows.Forms.Button();
            this.btn_gray_2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_thresholding1 = new System.Windows.Forms.Button();
            this.btn_thresholding2 = new System.Windows.Forms.Button();
            this.btn_otsu = new System.Windows.Forms.Button();
            this.btn_gaussianC = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 389);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 383);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(817, 15);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(90, 23);
            this.btn_Open.TabIndex = 1;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.imageBox1);
            this.panel2.Location = new System.Drawing.Point(459, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 293);
            this.panel2.TabIndex = 2;
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(0, 3);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(330, 290);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // btn_gray
            // 
            this.btn_gray.Location = new System.Drawing.Point(817, 64);
            this.btn_gray.Name = "btn_gray";
            this.btn_gray.Size = new System.Drawing.Size(90, 23);
            this.btn_gray.TabIndex = 3;
            this.btn_gray.Text = "Gray button";
            this.btn_gray.UseVisualStyleBackColor = true;
            this.btn_gray.Click += new System.EventHandler(this.btn_gray_Click);
            // 
            // btn_gray_2
            // 
            this.btn_gray_2.Location = new System.Drawing.Point(817, 107);
            this.btn_gray_2.Name = "btn_gray_2";
            this.btn_gray_2.Size = new System.Drawing.Size(90, 23);
            this.btn_gray_2.TabIndex = 3;
            this.btn_gray_2.Text = "Gray button 2";
            this.btn_gray_2.UseVisualStyleBackColor = true;
            this.btn_gray_2.Click += new System.EventHandler(this.btn_gray_2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(817, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "120";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItem2.Text = "120";
            // 
            // btn_thresholding1
            // 
            this.btn_thresholding1.Location = new System.Drawing.Point(817, 164);
            this.btn_thresholding1.Name = "btn_thresholding1";
            this.btn_thresholding1.Size = new System.Drawing.Size(90, 23);
            this.btn_thresholding1.TabIndex = 6;
            this.btn_thresholding1.Text = "Theshold 1";
            this.btn_thresholding1.UseVisualStyleBackColor = true;
            this.btn_thresholding1.Click += new System.EventHandler(this.btn_thresholding1_Click);
            // 
            // btn_thresholding2
            // 
            this.btn_thresholding2.Location = new System.Drawing.Point(817, 193);
            this.btn_thresholding2.Name = "btn_thresholding2";
            this.btn_thresholding2.Size = new System.Drawing.Size(90, 23);
            this.btn_thresholding2.TabIndex = 6;
            this.btn_thresholding2.Text = "Theshold 2";
            this.btn_thresholding2.UseVisualStyleBackColor = true;
            this.btn_thresholding2.Click += new System.EventHandler(this.btn_thresholding2_Click);
            // 
            // btn_otsu
            // 
            this.btn_otsu.Location = new System.Drawing.Point(817, 222);
            this.btn_otsu.Name = "btn_otsu";
            this.btn_otsu.Size = new System.Drawing.Size(90, 23);
            this.btn_otsu.TabIndex = 6;
            this.btn_otsu.Text = "Otsu";
            this.btn_otsu.UseVisualStyleBackColor = true;
            this.btn_otsu.Click += new System.EventHandler(this.btn_otsu_Click);
            // 
            // btn_gaussianC
            // 
            this.btn_gaussianC.Location = new System.Drawing.Point(817, 251);
            this.btn_gaussianC.Name = "btn_gaussianC";
            this.btn_gaussianC.Size = new System.Drawing.Size(90, 23);
            this.btn_gaussianC.TabIndex = 6;
            this.btn_gaussianC.Text = "Gaussian C";
            this.btn_gaussianC.UseVisualStyleBackColor = true;
            this.btn_gaussianC.Click += new System.EventHandler(this.btn_gaussianC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 479);
            this.Controls.Add(this.btn_gaussianC);
            this.Controls.Add(this.btn_otsu);
            this.Controls.Add(this.btn_thresholding2);
            this.Controls.Add(this.btn_thresholding1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_gray_2);
            this.Controls.Add(this.btn_gray);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Panel panel2;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button btn_gray;
        private System.Windows.Forms.Button btn_gray_2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button btn_thresholding1;
        private System.Windows.Forms.Button btn_thresholding2;
        private System.Windows.Forms.Button btn_otsu;
        private System.Windows.Forms.Button btn_gaussianC;
    }
}

