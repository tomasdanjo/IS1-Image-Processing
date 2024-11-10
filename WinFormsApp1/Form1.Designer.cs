namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            dIPToolStripMenuItem = new ToolStripMenuItem();
            pixelCopyToolStripMenuItem = new ToolStripMenuItem();
            greyscaleToolStripMenuItem = new ToolStripMenuItem();
            inversionToolStripMenuItem = new ToolStripMenuItem();
            histogramToolStripMenuItem = new ToolStripMenuItem();
            sepiaToolStripMenuItem = new ToolStripMenuItem();
            cameraToolStripMenuItem = new ToolStripMenuItem();
            onToolStripMenuItem = new ToolStripMenuItem();
            offToolStripMenuItem = new ToolStripMenuItem();
            videoToolStripMenuItem = new ToolStripMenuItem();
            pixelCopyToolStripMenuItem1 = new ToolStripMenuItem();
            greyscaleToolStripMenuItem1 = new ToolStripMenuItem();
            inversionToolStripMenuItem1 = new ToolStripMenuItem();
            sepiaToolStripMenuItem1 = new ToolStripMenuItem();
            subtractToolStripMenuItem = new ToolStripMenuItem();
            filtersToolStripMenuItem = new ToolStripMenuItem();
            gaussianBlurToolStripMenuItem = new ToolStripMenuItem();
            smoothToolStripMenuItem = new ToolStripMenuItem();
            meanRemovalToolStripMenuItem = new ToolStripMenuItem();
            sharpenToolStripMenuItem = new ToolStripMenuItem();
            edgeDetectConvolutionToolStripMenuItem = new ToolStripMenuItem();
            kIRSHToolStripMenuItem = new ToolStripMenuItem();
            pREWITTToolStripMenuItem = new ToolStripMenuItem();
            sOBELToolStripMenuItem = new ToolStripMenuItem();
            embossToolStripMenuItem = new ToolStripMenuItem();
            laplacianToolStripMenuItem = new ToolStripMenuItem();
            horizontalToolStripMenuItem = new ToolStripMenuItem();
            verticalToolStripMenuItem = new ToolStripMenuItem();
            allDirectionToolStripMenuItem = new ToolStripMenuItem();
            lossyToolStripMenuItem = new ToolStripMenuItem();
            horzVerticalToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            openFileDialog2 = new OpenFileDialog();
            pictureBox3 = new PictureBox();
            openFileDialog3 = new OpenFileDialog();
            loadImageBtn = new Button();
            loadBacgroundBtn = new Button();
            subtractBtn = new Button();
            label1 = new Label();
            leftPBBasicIP = new PictureBox();
            rightPBBasicIP = new PictureBox();
            label2 = new Label();
            trackBar1 = new TrackBar();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftPBBasicIP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightPBBasicIP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, dIPToolStripMenuItem, cameraToolStripMenuItem, videoToolStripMenuItem, filtersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1482, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(128, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // dIPToolStripMenuItem
            // 
            dIPToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pixelCopyToolStripMenuItem, greyscaleToolStripMenuItem, inversionToolStripMenuItem, histogramToolStripMenuItem, sepiaToolStripMenuItem });
            dIPToolStripMenuItem.Name = "dIPToolStripMenuItem";
            dIPToolStripMenuItem.Size = new Size(46, 24);
            dIPToolStripMenuItem.Text = "DIP";
            // 
            // pixelCopyToolStripMenuItem
            // 
            pixelCopyToolStripMenuItem.Name = "pixelCopyToolStripMenuItem";
            pixelCopyToolStripMenuItem.Size = new Size(162, 26);
            pixelCopyToolStripMenuItem.Text = "Pixel Copy";
            pixelCopyToolStripMenuItem.Click += pixelCopyToolStripMenuItem_Click;
            // 
            // greyscaleToolStripMenuItem
            // 
            greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            greyscaleToolStripMenuItem.Size = new Size(162, 26);
            greyscaleToolStripMenuItem.Text = "Greyscale";
            greyscaleToolStripMenuItem.Click += greyscaleToolStripMenuItem_Click;
            // 
            // inversionToolStripMenuItem
            // 
            inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            inversionToolStripMenuItem.Size = new Size(162, 26);
            inversionToolStripMenuItem.Text = "Inversion";
            inversionToolStripMenuItem.Click += inversionToolStripMenuItem_Click;
            // 
            // histogramToolStripMenuItem
            // 
            histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            histogramToolStripMenuItem.Size = new Size(162, 26);
            histogramToolStripMenuItem.Text = "Histogram";
            histogramToolStripMenuItem.Click += histogramToolStripMenuItem_Click;
            // 
            // sepiaToolStripMenuItem
            // 
            sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            sepiaToolStripMenuItem.Size = new Size(162, 26);
            sepiaToolStripMenuItem.Text = "Sepia";
            sepiaToolStripMenuItem.Click += sepiaToolStripMenuItem_Click;
            // 
            // cameraToolStripMenuItem
            // 
            cameraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { onToolStripMenuItem, offToolStripMenuItem });
            cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            cameraToolStripMenuItem.Size = new Size(74, 24);
            cameraToolStripMenuItem.Text = "Camera";
            // 
            // onToolStripMenuItem
            // 
            onToolStripMenuItem.Name = "onToolStripMenuItem";
            onToolStripMenuItem.Size = new Size(113, 26);
            onToolStripMenuItem.Text = "On";
            onToolStripMenuItem.Click += onToolStripMenuItem_Click;
            // 
            // offToolStripMenuItem
            // 
            offToolStripMenuItem.Name = "offToolStripMenuItem";
            offToolStripMenuItem.Size = new Size(113, 26);
            offToolStripMenuItem.Text = "Off";
            offToolStripMenuItem.Click += offToolStripMenuItem_Click;
            // 
            // videoToolStripMenuItem
            // 
            videoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pixelCopyToolStripMenuItem1, greyscaleToolStripMenuItem1, inversionToolStripMenuItem1, sepiaToolStripMenuItem1, subtractToolStripMenuItem });
            videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            videoToolStripMenuItem.Size = new Size(62, 24);
            videoToolStripMenuItem.Text = "Video";
            // 
            // pixelCopyToolStripMenuItem1
            // 
            pixelCopyToolStripMenuItem1.Name = "pixelCopyToolStripMenuItem1";
            pixelCopyToolStripMenuItem1.Size = new Size(161, 26);
            pixelCopyToolStripMenuItem1.Text = "Pixel Copy";
            // 
            // greyscaleToolStripMenuItem1
            // 
            greyscaleToolStripMenuItem1.Name = "greyscaleToolStripMenuItem1";
            greyscaleToolStripMenuItem1.Size = new Size(161, 26);
            greyscaleToolStripMenuItem1.Text = "Greyscale";
            greyscaleToolStripMenuItem1.Click += greyscaleToolStripMenuItem1_Click;
            // 
            // inversionToolStripMenuItem1
            // 
            inversionToolStripMenuItem1.Name = "inversionToolStripMenuItem1";
            inversionToolStripMenuItem1.Size = new Size(161, 26);
            inversionToolStripMenuItem1.Text = "Inversion";
            // 
            // sepiaToolStripMenuItem1
            // 
            sepiaToolStripMenuItem1.Name = "sepiaToolStripMenuItem1";
            sepiaToolStripMenuItem1.Size = new Size(161, 26);
            sepiaToolStripMenuItem1.Text = "Sepia";
            // 
            // subtractToolStripMenuItem
            // 
            subtractToolStripMenuItem.Name = "subtractToolStripMenuItem";
            subtractToolStripMenuItem.Size = new Size(161, 26);
            subtractToolStripMenuItem.Text = "Subtract";
            // 
            // filtersToolStripMenuItem
            // 
            filtersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gaussianBlurToolStripMenuItem, smoothToolStripMenuItem, meanRemovalToolStripMenuItem, sharpenToolStripMenuItem, edgeDetectConvolutionToolStripMenuItem, embossToolStripMenuItem });
            filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            filtersToolStripMenuItem.Size = new Size(62, 24);
            filtersToolStripMenuItem.Text = "Filters";
            // 
            // gaussianBlurToolStripMenuItem
            // 
            gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            gaussianBlurToolStripMenuItem.Size = new Size(250, 26);
            gaussianBlurToolStripMenuItem.Text = "Gaussian Blur";
            gaussianBlurToolStripMenuItem.Click += gaussianBlurToolStripMenuItem_Click;
            // 
            // smoothToolStripMenuItem
            // 
            smoothToolStripMenuItem.Name = "smoothToolStripMenuItem";
            smoothToolStripMenuItem.Size = new Size(250, 26);
            smoothToolStripMenuItem.Text = "Smooth";
            smoothToolStripMenuItem.Click += smoothToolStripMenuItem_Click;
            // 
            // meanRemovalToolStripMenuItem
            // 
            meanRemovalToolStripMenuItem.Name = "meanRemovalToolStripMenuItem";
            meanRemovalToolStripMenuItem.Size = new Size(250, 26);
            meanRemovalToolStripMenuItem.Text = "Mean Removal";
            meanRemovalToolStripMenuItem.Click += meanRemovalToolStripMenuItem_Click;
            // 
            // sharpenToolStripMenuItem
            // 
            sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            sharpenToolStripMenuItem.Size = new Size(250, 26);
            sharpenToolStripMenuItem.Text = "Sharpen";
            sharpenToolStripMenuItem.Click += sharpenToolStripMenuItem_Click;
            // 
            // edgeDetectConvolutionToolStripMenuItem
            // 
            edgeDetectConvolutionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kIRSHToolStripMenuItem, pREWITTToolStripMenuItem, sOBELToolStripMenuItem });
            edgeDetectConvolutionToolStripMenuItem.Name = "edgeDetectConvolutionToolStripMenuItem";
            edgeDetectConvolutionToolStripMenuItem.Size = new Size(250, 26);
            edgeDetectConvolutionToolStripMenuItem.Text = "EdgeDetectConvolution";
            // 
            // kIRSHToolStripMenuItem
            // 
            kIRSHToolStripMenuItem.Name = "kIRSHToolStripMenuItem";
            kIRSHToolStripMenuItem.Size = new Size(151, 26);
            kIRSHToolStripMenuItem.Text = "KIRSH";
            kIRSHToolStripMenuItem.Click += kIRSHToolStripMenuItem_Click;
            // 
            // pREWITTToolStripMenuItem
            // 
            pREWITTToolStripMenuItem.Name = "pREWITTToolStripMenuItem";
            pREWITTToolStripMenuItem.Size = new Size(151, 26);
            pREWITTToolStripMenuItem.Text = "PREWITT";
            pREWITTToolStripMenuItem.Click += pREWITTToolStripMenuItem_Click;
            // 
            // sOBELToolStripMenuItem
            // 
            sOBELToolStripMenuItem.Name = "sOBELToolStripMenuItem";
            sOBELToolStripMenuItem.Size = new Size(151, 26);
            sOBELToolStripMenuItem.Text = "SOBEL";
            sOBELToolStripMenuItem.Click += sOBELToolStripMenuItem_Click;
            // 
            // embossToolStripMenuItem
            // 
            embossToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { laplacianToolStripMenuItem, horizontalToolStripMenuItem, verticalToolStripMenuItem, allDirectionToolStripMenuItem, lossyToolStripMenuItem, horzVerticalToolStripMenuItem });
            embossToolStripMenuItem.Name = "embossToolStripMenuItem";
            embossToolStripMenuItem.Size = new Size(250, 26);
            embossToolStripMenuItem.Text = "Emboss";
            // 
            // laplacianToolStripMenuItem
            // 
            laplacianToolStripMenuItem.Name = "laplacianToolStripMenuItem";
            laplacianToolStripMenuItem.Size = new Size(224, 26);
            laplacianToolStripMenuItem.Text = "Laplacian";
            laplacianToolStripMenuItem.Click += laplacianToolStripMenuItem_Click;
            // 
            // horizontalToolStripMenuItem
            // 
            horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            horizontalToolStripMenuItem.Size = new Size(224, 26);
            horizontalToolStripMenuItem.Text = "Horizontal";
            horizontalToolStripMenuItem.Click += horizontalToolStripMenuItem_Click;
            // 
            // verticalToolStripMenuItem
            // 
            verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            verticalToolStripMenuItem.Size = new Size(224, 26);
            verticalToolStripMenuItem.Text = "Vertical";
            verticalToolStripMenuItem.Click += verticalToolStripMenuItem_Click;
            // 
            // allDirectionToolStripMenuItem
            // 
            allDirectionToolStripMenuItem.Name = "allDirectionToolStripMenuItem";
            allDirectionToolStripMenuItem.Size = new Size(224, 26);
            allDirectionToolStripMenuItem.Text = "All Direction";
            allDirectionToolStripMenuItem.Click += allDirectionToolStripMenuItem_Click;
            // 
            // lossyToolStripMenuItem
            // 
            lossyToolStripMenuItem.Name = "lossyToolStripMenuItem";
            lossyToolStripMenuItem.Size = new Size(224, 26);
            lossyToolStripMenuItem.Text = "Lossy";
            lossyToolStripMenuItem.Click += lossyToolStripMenuItem_Click;
            // 
            // horzVerticalToolStripMenuItem
            // 
            horzVerticalToolStripMenuItem.Name = "horzVerticalToolStripMenuItem";
            horzVerticalToolStripMenuItem.Size = new Size(224, 26);
            horzVerticalToolStripMenuItem.Text = "Horz/Vertical";
            horzVerticalToolStripMenuItem.Click += horzVerticalToolStripMenuItem_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1482, 24);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(21, 721);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(504, 721);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(400, 400);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            openFileDialog2.FileOk += openFileDialog2_FileOk;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(976, 721);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(400, 400);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog3";
            openFileDialog3.FileOk += openFileDialog3_FileOk;
            // 
            // loadImageBtn
            // 
            loadImageBtn.Location = new Point(94, 686);
            loadImageBtn.Name = "loadImageBtn";
            loadImageBtn.Size = new Size(185, 29);
            loadImageBtn.TabIndex = 5;
            loadImageBtn.Text = "Load Image";
            loadImageBtn.UseVisualStyleBackColor = true;
            loadImageBtn.Click += loadImageBtn_Click;
            // 
            // loadBacgroundBtn
            // 
            loadBacgroundBtn.Location = new Point(609, 686);
            loadBacgroundBtn.Name = "loadBacgroundBtn";
            loadBacgroundBtn.Size = new Size(185, 29);
            loadBacgroundBtn.TabIndex = 6;
            loadBacgroundBtn.Text = "Load Background";
            loadBacgroundBtn.UseVisualStyleBackColor = true;
            loadBacgroundBtn.Click += loadBacgroundBtn_Click;
            // 
            // subtractBtn
            // 
            subtractBtn.Location = new Point(1102, 686);
            subtractBtn.Name = "subtractBtn";
            subtractBtn.Size = new Size(185, 29);
            subtractBtn.TabIndex = 7;
            subtractBtn.Text = "Subtract";
            subtractBtn.UseVisualStyleBackColor = true;
            subtractBtn.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(635, 654);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 8;
            label1.Text = "Image Subtraction";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // leftPBBasicIP
            // 
            leftPBBasicIP.Location = new Point(208, 115);
            leftPBBasicIP.Name = "leftPBBasicIP";
            leftPBBasicIP.Size = new Size(400, 400);
            leftPBBasicIP.SizeMode = PictureBoxSizeMode.StretchImage;
            leftPBBasicIP.TabIndex = 9;
            leftPBBasicIP.TabStop = false;
            // 
            // rightPBBasicIP
            // 
            rightPBBasicIP.Location = new Point(776, 115);
            rightPBBasicIP.Name = "rightPBBasicIP";
            rightPBBasicIP.Size = new Size(400, 400);
            rightPBBasicIP.SizeMode = PictureBoxSizeMode.StretchImage;
            rightPBBasicIP.TabIndex = 10;
            rightPBBasicIP.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(609, 52);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 11;
            label2.Text = "Basic Image Processing";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(247, 558);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(795, 56);
            trackBar1.TabIndex = 12;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 1175);
            Controls.Add(trackBar1);
            Controls.Add(label2);
            Controls.Add(rightPBBasicIP);
            Controls.Add(leftPBBasicIP);
            Controls.Add(label1);
            Controls.Add(subtractBtn);
            Controls.Add(loadBacgroundBtn);
            Controls.Add(loadImageBtn);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftPBBasicIP).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightPBBasicIP).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem dIPToolStripMenuItem;
        private ToolStripMenuItem pixelCopyToolStripMenuItem;
        private ToolStripMenuItem greyscaleToolStripMenuItem;
        private ToolStripMenuItem inversionToolStripMenuItem;
        private MenuStrip menuStrip2;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ToolStripMenuItem histogramToolStripMenuItem;
        private ToolStripMenuItem sepiaToolStripMenuItem;
        private ToolStripMenuItem cameraToolStripMenuItem;
        private ToolStripMenuItem onToolStripMenuItem;
        private ToolStripMenuItem offToolStripMenuItem;
        private OpenFileDialog openFileDialog2;
        private PictureBox pictureBox3;
        private OpenFileDialog openFileDialog3;
        private Button loadImageBtn;
        private Button loadBacgroundBtn;
        private Button subtractBtn;
        private Label label1;
        private PictureBox leftPBBasicIP;
        private PictureBox rightPBBasicIP;
        private Label label2;
        private ToolStripMenuItem videoToolStripMenuItem;
        private ToolStripMenuItem pixelCopyToolStripMenuItem1;
        private ToolStripMenuItem greyscaleToolStripMenuItem1;
        private ToolStripMenuItem inversionToolStripMenuItem1;
        private ToolStripMenuItem sepiaToolStripMenuItem1;
        private ToolStripMenuItem subtractToolStripMenuItem;
        private ToolStripMenuItem filtersToolStripMenuItem;
        private ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private ToolStripMenuItem smoothToolStripMenuItem;
        private TrackBar trackBar1;
        private ToolStripMenuItem meanRemovalToolStripMenuItem;
        private ToolStripMenuItem sharpenToolStripMenuItem;
        private ToolStripMenuItem edgeDetectConvolutionToolStripMenuItem;
        private ToolStripMenuItem kIRSHToolStripMenuItem;
        private ToolStripMenuItem pREWITTToolStripMenuItem;
        private ToolStripMenuItem sOBELToolStripMenuItem;
        private ToolStripMenuItem embossToolStripMenuItem;
        private ToolStripMenuItem laplacianToolStripMenuItem;
        private ToolStripMenuItem horizontalToolStripMenuItem;
        private ToolStripMenuItem verticalToolStripMenuItem;
        private ToolStripMenuItem allDirectionToolStripMenuItem;
        private ToolStripMenuItem lossyToolStripMenuItem;
        private ToolStripMenuItem horzVerticalToolStripMenuItem;
    }
}
