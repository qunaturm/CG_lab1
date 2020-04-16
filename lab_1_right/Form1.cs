using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace lab_1_right
{
    public partial class Form1 : Form
    {
        Bitmap image;

        float[,] elem = new float[3, 3]{ {1, 1, 1}, {1, 1, 1}, {1, 1, 1} }; //struct element

        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files |*.png;*.jpg;*.bmp|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
            {
                image = newImage;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCopmleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void gaussToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GaussFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void grayScaleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScale();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void sepiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new Sepia();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Brightness();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new фильтры.Sobel();
            backgroundWorker1.RunWorkerAsync(filter);

        }

        private void sharpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Sharp();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void reflectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Reflector();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void medianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Median();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void linearStretchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new LinearStretch();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void topHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new TopHat(elem);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void waveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Wave();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void wave2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Wave_2();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void glassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Glass();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void mathMorfologyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Dilation(elem);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Erosion(elem);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Opening(elem);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Closing(elem);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void embosingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Embosing();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void motionBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MotionBlur();
            backgroundWorker1.RunWorkerAsync(filter);
        }
    }
}

