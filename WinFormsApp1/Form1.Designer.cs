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
            menuStrip2 = new MenuStrip();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog2 = new OpenFileDialog();
            openFileDialog3 = new OpenFileDialog();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            menuStrip3 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            dIPToolStripMenuItem = new ToolStripMenuItem();
            pixelCopyToolStripMenuItem = new ToolStripMenuItem();
            greyscaleToolStripMenuItem = new ToolStripMenuItem();
            inversionToolStripMenuItem = new ToolStripMenuItem();
            histogramToolStripMenuItem = new ToolStripMenuItem();
            sepiaToolStripMenuItem = new ToolStripMenuItem();
            convolutionToolStripMenuItem = new ToolStripMenuItem();
            sharpenToolStripMenuItem = new ToolStripMenuItem();
            blurToolStripMenuItem = new ToolStripMenuItem();
            edgeEnhanceToolStripMenuItem = new ToolStripMenuItem();
            edgeDetectToolStripMenuItem = new ToolStripMenuItem();
            kIRSHToolStripMenuItem = new ToolStripMenuItem();
            pREWITTToolStripMenuItem = new ToolStripMenuItem();
            sOBELToolStripMenuItem = new ToolStripMenuItem();
            meanRemovalToolStripMenuItem = new ToolStripMenuItem();
            embossToolStripMenuItem = new ToolStripMenuItem();
            laplascianToolStripMenuItem = new ToolStripMenuItem();
            horzVerticalToolStripMenuItem = new ToolStripMenuItem();
            lossyToolStripMenuItem = new ToolStripMenuItem();
            horizontalOnlyToolStripMenuItem = new ToolStripMenuItem();
            verticalOnlyToolStripMenuItem = new ToolStripMenuItem();
            allDirectionsToolStripMenuItem = new ToolStripMenuItem();
            smoothToolStripMenuItem = new ToolStripMenuItem();
            tabPage2 = new TabPage();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            tabPage4 = new TabPage();
            openFileDialog4 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip3.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1282, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1282, 24);
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
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            openFileDialog2.FileOk += openFileDialog2_FileOk;
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog3";
            openFileDialog3.FileOk += openFileDialog3_FileOk;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1282, 650);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(menuStrip3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1274, 617);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Basic Image Processing";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(671, 60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(500, 500);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(56, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // menuStrip3
            // 
            menuStrip3.ImageScalingSize = new Size(20, 20);
            menuStrip3.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, dIPToolStripMenuItem, convolutionToolStripMenuItem });
            menuStrip3.Location = new Point(3, 3);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(1268, 28);
            menuStrip3.TabIndex = 0;
            menuStrip3.Text = "menuStrip3";
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
            openToolStripMenuItem.Click += openToolStripMenuItem_Click_1;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(128, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click_1;
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
            pixelCopyToolStripMenuItem.Click += pixelCopyToolStripMenuItem_Click_1;
            // 
            // greyscaleToolStripMenuItem
            // 
            greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            greyscaleToolStripMenuItem.Size = new Size(162, 26);
            greyscaleToolStripMenuItem.Text = "Greyscale";
            greyscaleToolStripMenuItem.Click += greyscaleToolStripMenuItem_Click_1;
            // 
            // inversionToolStripMenuItem
            // 
            inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            inversionToolStripMenuItem.Size = new Size(162, 26);
            inversionToolStripMenuItem.Text = "Inversion";
            inversionToolStripMenuItem.Click += inversionToolStripMenuItem_Click_1;
            // 
            // histogramToolStripMenuItem
            // 
            histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            histogramToolStripMenuItem.Size = new Size(162, 26);
            histogramToolStripMenuItem.Text = "Histogram";
            histogramToolStripMenuItem.Click += histogramToolStripMenuItem_Click_1;
            // 
            // sepiaToolStripMenuItem
            // 
            sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            sepiaToolStripMenuItem.Size = new Size(162, 26);
            sepiaToolStripMenuItem.Text = "Sepia";
            sepiaToolStripMenuItem.Click += sepiaToolStripMenuItem_Click_1;
            // 
            // convolutionToolStripMenuItem
            // 
            convolutionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sharpenToolStripMenuItem, blurToolStripMenuItem, edgeEnhanceToolStripMenuItem, edgeDetectToolStripMenuItem, meanRemovalToolStripMenuItem, embossToolStripMenuItem, smoothToolStripMenuItem });
            convolutionToolStripMenuItem.Name = "convolutionToolStripMenuItem";
            convolutionToolStripMenuItem.Size = new Size(103, 24);
            convolutionToolStripMenuItem.Text = "Convolution";
            // 
            // sharpenToolStripMenuItem
            // 
            sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            sharpenToolStripMenuItem.Size = new Size(191, 26);
            sharpenToolStripMenuItem.Text = "Sharpen";
            sharpenToolStripMenuItem.Click += sharpenToolStripMenuItem_Click_1;
            // 
            // blurToolStripMenuItem
            // 
            blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            blurToolStripMenuItem.Size = new Size(191, 26);
            blurToolStripMenuItem.Text = "Gaussian Blur";
            blurToolStripMenuItem.Click += blurToolStripMenuItem_Click;
            // 
            // edgeEnhanceToolStripMenuItem
            // 
            edgeEnhanceToolStripMenuItem.Name = "edgeEnhanceToolStripMenuItem";
            edgeEnhanceToolStripMenuItem.Size = new Size(191, 26);
            edgeEnhanceToolStripMenuItem.Text = "Edge Enhance";
            edgeEnhanceToolStripMenuItem.Click += edgeEnhanceToolStripMenuItem_Click;
            // 
            // edgeDetectToolStripMenuItem
            // 
            edgeDetectToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kIRSHToolStripMenuItem, pREWITTToolStripMenuItem, sOBELToolStripMenuItem });
            edgeDetectToolStripMenuItem.Name = "edgeDetectToolStripMenuItem";
            edgeDetectToolStripMenuItem.Size = new Size(191, 26);
            edgeDetectToolStripMenuItem.Text = "Edge Detect";
            // 
            // kIRSHToolStripMenuItem
            // 
            kIRSHToolStripMenuItem.Name = "kIRSHToolStripMenuItem";
            kIRSHToolStripMenuItem.Size = new Size(151, 26);
            kIRSHToolStripMenuItem.Text = "KIRSH";
            kIRSHToolStripMenuItem.Click += kIRSHToolStripMenuItem_Click_1;
            // 
            // pREWITTToolStripMenuItem
            // 
            pREWITTToolStripMenuItem.Name = "pREWITTToolStripMenuItem";
            pREWITTToolStripMenuItem.Size = new Size(151, 26);
            pREWITTToolStripMenuItem.Text = "PREWITT\t";
            pREWITTToolStripMenuItem.Click += pREWITTToolStripMenuItem_Click_1;
            // 
            // sOBELToolStripMenuItem
            // 
            sOBELToolStripMenuItem.Name = "sOBELToolStripMenuItem";
            sOBELToolStripMenuItem.Size = new Size(151, 26);
            sOBELToolStripMenuItem.Text = "SOBEL";
            sOBELToolStripMenuItem.Click += sOBELToolStripMenuItem_Click_1;
            // 
            // meanRemovalToolStripMenuItem
            // 
            meanRemovalToolStripMenuItem.Name = "meanRemovalToolStripMenuItem";
            meanRemovalToolStripMenuItem.Size = new Size(191, 26);
            meanRemovalToolStripMenuItem.Text = "Mean Removal";
            meanRemovalToolStripMenuItem.Click += meanRemovalToolStripMenuItem_Click_1;
            // 
            // embossToolStripMenuItem
            // 
            embossToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { laplascianToolStripMenuItem, horzVerticalToolStripMenuItem, lossyToolStripMenuItem, horizontalOnlyToolStripMenuItem, verticalOnlyToolStripMenuItem, allDirectionsToolStripMenuItem });
            embossToolStripMenuItem.Name = "embossToolStripMenuItem";
            embossToolStripMenuItem.Size = new Size(191, 26);
            embossToolStripMenuItem.Text = "Emboss";
            // 
            // laplascianToolStripMenuItem
            // 
            laplascianToolStripMenuItem.Name = "laplascianToolStripMenuItem";
            laplascianToolStripMenuItem.Size = new Size(200, 26);
            laplascianToolStripMenuItem.Text = "Laplascian";
            laplascianToolStripMenuItem.Click += laplascianToolStripMenuItem_Click;
            // 
            // horzVerticalToolStripMenuItem
            // 
            horzVerticalToolStripMenuItem.Name = "horzVerticalToolStripMenuItem";
            horzVerticalToolStripMenuItem.Size = new Size(200, 26);
            horzVerticalToolStripMenuItem.Text = "Horz/Vertical ";
            horzVerticalToolStripMenuItem.Click += horzVerticalToolStripMenuItem_Click_1;
            // 
            // lossyToolStripMenuItem
            // 
            lossyToolStripMenuItem.Name = "lossyToolStripMenuItem";
            lossyToolStripMenuItem.Size = new Size(200, 26);
            lossyToolStripMenuItem.Text = "Lossy";
            lossyToolStripMenuItem.Click += lossyToolStripMenuItem_Click_1;
            // 
            // horizontalOnlyToolStripMenuItem
            // 
            horizontalOnlyToolStripMenuItem.Name = "horizontalOnlyToolStripMenuItem";
            horizontalOnlyToolStripMenuItem.Size = new Size(200, 26);
            horizontalOnlyToolStripMenuItem.Text = "Horizontal Only ";
            horizontalOnlyToolStripMenuItem.Click += horizontalOnlyToolStripMenuItem_Click;
            // 
            // verticalOnlyToolStripMenuItem
            // 
            verticalOnlyToolStripMenuItem.Name = "verticalOnlyToolStripMenuItem";
            verticalOnlyToolStripMenuItem.Size = new Size(200, 26);
            verticalOnlyToolStripMenuItem.Text = "Vertical Only ";
            verticalOnlyToolStripMenuItem.Click += verticalOnlyToolStripMenuItem_Click;
            // 
            // allDirectionsToolStripMenuItem
            // 
            allDirectionsToolStripMenuItem.Name = "allDirectionsToolStripMenuItem";
            allDirectionsToolStripMenuItem.Size = new Size(200, 26);
            allDirectionsToolStripMenuItem.Text = "All Directions ";
            allDirectionsToolStripMenuItem.Click += allDirectionsToolStripMenuItem_Click;
            // 
            // smoothToolStripMenuItem
            // 
            smoothToolStripMenuItem.Name = "smoothToolStripMenuItem";
            smoothToolStripMenuItem.Size = new Size(191, 26);
            smoothToolStripMenuItem.Text = "Smooth";
            smoothToolStripMenuItem.Click += smoothToolStripMenuItem_Click_1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(pictureBox5);
            tabPage2.Controls.Add(pictureBox4);
            tabPage2.Controls.Add(pictureBox3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1274, 617);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Subtraction";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(864, 532);
            button4.Name = "button4";
            button4.Size = new Size(400, 29);
            button4.TabIndex = 6;
            button4.Text = "save";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(864, 497);
            button3.Name = "button3";
            button3.Size = new Size(400, 29);
            button3.TabIndex = 5;
            button3.Text = "subtract";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(439, 497);
            button2.Name = "button2";
            button2.Size = new Size(400, 29);
            button2.TabIndex = 4;
            button2.Text = "load background";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(8, 497);
            button1.Name = "button1";
            button1.Size = new Size(400, 29);
            button1.TabIndex = 3;
            button1.Text = "load image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(864, 73);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(400, 400);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(439, 73);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(400, 400);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(8, 73);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(400, 400);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1274, 617);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Coin Count";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // openFileDialog4
            // 
            openFileDialog4.FileName = "openFileDialog4";
            openFileDialog4.FileOk += openFileDialog4_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 653);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog2;
        private OpenFileDialog openFileDialog3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private MenuStrip menuStrip3;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ToolStripMenuItem dIPToolStripMenuItem;
        private ToolStripMenuItem pixelCopyToolStripMenuItem;
        private ToolStripMenuItem greyscaleToolStripMenuItem;
        private ToolStripMenuItem inversionToolStripMenuItem;
        private ToolStripMenuItem histogramToolStripMenuItem;
        private ToolStripMenuItem sepiaToolStripMenuItem;
        private ToolStripMenuItem convolutionToolStripMenuItem;
        private ToolStripMenuItem sharpenToolStripMenuItem;
        private ToolStripMenuItem blurToolStripMenuItem;
        private ToolStripMenuItem edgeEnhanceToolStripMenuItem;
        private ToolStripMenuItem edgeDetectToolStripMenuItem;
        private ToolStripMenuItem meanRemovalToolStripMenuItem;
        private ToolStripMenuItem embossToolStripMenuItem;
        private ToolStripMenuItem laplascianToolStripMenuItem;
        private ToolStripMenuItem horzVerticalToolStripMenuItem;
        private ToolStripMenuItem lossyToolStripMenuItem;
        private ToolStripMenuItem horizontalOnlyToolStripMenuItem;
        private ToolStripMenuItem verticalOnlyToolStripMenuItem;
        private ToolStripMenuItem allDirectionsToolStripMenuItem;
        private ToolStripMenuItem smoothToolStripMenuItem;
        private ToolStripMenuItem kIRSHToolStripMenuItem;
        private ToolStripMenuItem pREWITTToolStripMenuItem;
        private ToolStripMenuItem sOBELToolStripMenuItem;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private OpenFileDialog openFileDialog4;
    }
}
