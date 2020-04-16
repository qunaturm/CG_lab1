namespace lab_1_right
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.sharpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reflectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linearStretchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topHatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wave2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mathMorfologyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(766, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.открытьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem1});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.файлToolStripMenuItem.Text = "file";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(101, 22);
            this.открытьToolStripMenuItem1.Text = "open";
            this.открытьToolStripMenuItem1.Click += new System.EventHandler(this.открытьToolStripMenuItem1_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem,
            this.mathMorfologyToolStripMenuItem,
            this.reflectionToolStripMenuItem,
            this.medianToolStripMenuItem,
            this.linearStretchToolStripMenuItem,
            this.topHatToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.открытьToolStripMenuItem.Text = "filters";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.grayScaleToolStripMenuItem1,
            this.sepiaToolStripMenuItem1,
            this.brightnessToolStripMenuItem,
            this.waveToolStripMenuItem,
            this.wave2ToolStripMenuItem,
            this.glassToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.точечныеToolStripMenuItem.Text = "pointed";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.инверсияToolStripMenuItem.Text = "invers";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // grayScaleToolStripMenuItem1
            // 
            this.grayScaleToolStripMenuItem1.Name = "grayScaleToolStripMenuItem1";
            this.grayScaleToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.grayScaleToolStripMenuItem1.Text = "gray scale";
            this.grayScaleToolStripMenuItem1.Click += new System.EventHandler(this.grayScaleToolStripMenuItem1_Click);
            // 
            // sepiaToolStripMenuItem1
            // 
            this.sepiaToolStripMenuItem1.Name = "sepiaToolStripMenuItem1";
            this.sepiaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.sepiaToolStripMenuItem1.Text = "sepia";
            this.sepiaToolStripMenuItem1.Click += new System.EventHandler(this.sepiaToolStripMenuItem1_Click);
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.brightnessToolStripMenuItem.Text = "brightness";
            this.brightnessToolStripMenuItem.Click += new System.EventHandler(this.brightnessToolStripMenuItem_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem,
            this.gaussToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.sharpToolStripMenuItem});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.матричныеToolStripMenuItem.Text = "matrix";
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blurToolStripMenuItem.Text = "blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
            // 
            // gaussToolStripMenuItem
            // 
            this.gaussToolStripMenuItem.Name = "gaussToolStripMenuItem";
            this.gaussToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gaussToolStripMenuItem.Text = "gauss";
            this.gaussToolStripMenuItem.Click += new System.EventHandler(this.gaussToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobelToolStripMenuItem.Text = "sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCopmleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(54, 482);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(621, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(681, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sharpToolStripMenuItem
            // 
            this.sharpToolStripMenuItem.Name = "sharpToolStripMenuItem";
            this.sharpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sharpToolStripMenuItem.Text = "sharp";
            this.sharpToolStripMenuItem.Click += new System.EventHandler(this.sharpToolStripMenuItem_Click);
            // 
            // reflectionToolStripMenuItem
            // 
            this.reflectionToolStripMenuItem.Name = "reflectionToolStripMenuItem";
            this.reflectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reflectionToolStripMenuItem.Text = "reflection";
            this.reflectionToolStripMenuItem.Click += new System.EventHandler(this.reflectionToolStripMenuItem_Click);
            // 
            // medianToolStripMenuItem
            // 
            this.medianToolStripMenuItem.Name = "medianToolStripMenuItem";
            this.medianToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.medianToolStripMenuItem.Text = "median";
            this.medianToolStripMenuItem.Click += new System.EventHandler(this.medianToolStripMenuItem_Click);
            // 
            // linearStretchToolStripMenuItem
            // 
            this.linearStretchToolStripMenuItem.Name = "linearStretchToolStripMenuItem";
            this.linearStretchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.linearStretchToolStripMenuItem.Text = "linear stretch";
            this.linearStretchToolStripMenuItem.Click += new System.EventHandler(this.linearStretchToolStripMenuItem_Click);
            // 
            // topHatToolStripMenuItem
            // 
            this.topHatToolStripMenuItem.Name = "topHatToolStripMenuItem";
            this.topHatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.topHatToolStripMenuItem.Text = "top hat";
            this.topHatToolStripMenuItem.Click += new System.EventHandler(this.topHatToolStripMenuItem_Click);
            // 
            // waveToolStripMenuItem
            // 
            this.waveToolStripMenuItem.Name = "waveToolStripMenuItem";
            this.waveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.waveToolStripMenuItem.Text = "wave";
            this.waveToolStripMenuItem.Click += new System.EventHandler(this.waveToolStripMenuItem_Click);
            // 
            // wave2ToolStripMenuItem
            // 
            this.wave2ToolStripMenuItem.Name = "wave2ToolStripMenuItem";
            this.wave2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wave2ToolStripMenuItem.Text = "wave 2";
            this.wave2ToolStripMenuItem.Click += new System.EventHandler(this.wave2ToolStripMenuItem_Click);
            // 
            // glassToolStripMenuItem
            // 
            this.glassToolStripMenuItem.Name = "glassToolStripMenuItem";
            this.glassToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.glassToolStripMenuItem.Text = "glass";
            this.glassToolStripMenuItem.Click += new System.EventHandler(this.glassToolStripMenuItem_Click);
            // 
            // mathMorfologyToolStripMenuItem
            // 
            this.mathMorfologyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dilationToolStripMenuItem,
            this.erosionToolStripMenuItem,
            this.openingToolStripMenuItem,
            this.closingToolStripMenuItem});
            this.mathMorfologyToolStripMenuItem.Name = "mathMorfologyToolStripMenuItem";
            this.mathMorfologyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mathMorfologyToolStripMenuItem.Text = "math morfology";
            this.mathMorfologyToolStripMenuItem.Click += new System.EventHandler(this.mathMorfologyToolStripMenuItem_Click);
            // 
            // dilationToolStripMenuItem
            // 
            this.dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
            this.dilationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dilationToolStripMenuItem.Text = "dilation";
            this.dilationToolStripMenuItem.Click += new System.EventHandler(this.dilationToolStripMenuItem_Click);
            // 
            // erosionToolStripMenuItem
            // 
            this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            this.erosionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.erosionToolStripMenuItem.Text = "erosion";
            this.erosionToolStripMenuItem.Click += new System.EventHandler(this.erosionToolStripMenuItem_Click);
            // 
            // openingToolStripMenuItem
            // 
            this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            this.openingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openingToolStripMenuItem.Text = "opening";
            this.openingToolStripMenuItem.Click += new System.EventHandler(this.openingToolStripMenuItem_Click);
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closingToolStripMenuItem.Text = "closing";
            this.closingToolStripMenuItem.Click += new System.EventHandler(this.closingToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reflectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linearStretchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topHatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wave2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem glassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mathMorfologyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
    }
}

