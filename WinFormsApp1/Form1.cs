using System.ComponentModel;
using WebCamLib;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Diagnostics;
using HNUDIP;
using ImageProcess2;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed;
        Device[] devices;
        Bitmap imageA, imageB, colorGreen;
        private IVideoSource _videoSource;
        FilterInfoCollection fic;

        private FilterInfo _currentDevice;

        public event PropertyChangedEventHandler PropertyChanged;
        int weight;


        public Form1()
        {
            InitializeComponent();

            VideoCaptureDevice vcd;

            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo dev in fic)
            {
                //comboBox1.Items.Add(dev.Name);
                _currentDevice = dev;


            }

            //comboBox1.SelectedIndex = 0;
            //vcd = new VideoCaptureDevice(fic[comboBox1.SelectedIndex].MonikerString);
        }

        public FilterInfo CurrentDevice
        {
            get { return _currentDevice; }
            set { _currentDevice = value; this.OnPropertyChanged("CurrentDevice"); }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            StopCamera();
            base.OnFormClosing(e);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            leftPBBasicIP.Image = loaded;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void pixelCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageProcess.copyImage(ref loaded, ref processed);
            rightPBBasicIP.Image = processed;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            processed.Save(saveFileDialog1.FileName);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            BasicDIP.greyscale(ref loaded, ref processed);
            rightPBBasicIP.Image = processed;

        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.invert(ref loaded, ref processed);
            rightPBBasicIP.Image = processed;
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.histogram(ref loaded, ref processed);
            rightPBBasicIP.Image = processed;
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.sepia(ref loaded, ref processed);
            rightPBBasicIP.Image = processed;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            devices = DeviceManager.GetAllDevices();
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rightPBBasicIP.Image = null;
            //pictureBox2.Image = null;
            pictureBox3.Image = null;
            StartCamera();


        }
        Bitmap a;
        private void video_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            try
            {
                // Clone the current frame
                imageB = (Bitmap)eventArgs.Frame.Clone();
                pictureBox1.Image = imageB;

                if (imageA != null)
                {
                    BasicDIP.subtract(ref imageA, ref imageB, ref processed, 5);
                    pictureBox3.Image = processed;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error in video_NewFrame: " + ex.Message);
            }

        }



        private void StartCamera()
        {
            if (CurrentDevice != null)
            {
                _videoSource = new VideoCaptureDevice(CurrentDevice.MonikerString);
                _videoSource.NewFrame += video_NewFrame;
                _videoSource.Start();
            }
        }



        private void StopCamera()
        {
            if (_videoSource != null && _videoSource.IsRunning)
            {
                _videoSource.SignalToStop();
                _videoSource.NewFrame -= new NewFrameEventHandler(video_NewFrame);
            }
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leftPBBasicIP.Image = null;
            pictureBox1.Image = null;
            rightPBBasicIP.Image = null;
            pictureBox3.Image = null;
            StopCamera();
        }



        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            imageB = new Bitmap(openFileDialog2.FileName);
            pictureBox1.Image = imageB;
        }

        private void openFileDialog3_FileOk(object sender, CancelEventArgs e)
        {
            imageA = new Bitmap(openFileDialog3.FileName);
            pictureBox2.Image = imageA;
        }

        private void loadImageBtn_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void loadBacgroundBtn_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            BasicDIP.subtract(ref imageA, ref imageB, ref processed, 5);
            pictureBox3.Image = processed;

        }

        private void greyscaleToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (leftPBBasicIP.Image != null)
            {
                //Bitmap bmp = (Bitmap)loaded.Clone();
                processed = BitmapFilter.GaussianBlur((Bitmap)leftPBBasicIP.Image, weight);

                if (processed != null)
                {
                    // Display the blurred image in the PictureBox
                    rightPBBasicIP.Image = processed;
                    leftPBBasicIP.Image = loaded;
                }
                else
                {
                    MessageBox.Show("Failed to apply Gaussian Blur.");
                }
            }
        }



        private void smoothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (leftPBBasicIP.Image != null)
            {
                //Bitmap bmp = (Bitmap)loaded.Clone();
                processed = BitmapFilter.Smooth((Bitmap)leftPBBasicIP.Image, weight);

                if (processed != null)
                {
                    // Display the blurred image in the PictureBox
                    rightPBBasicIP.Image = processed;
                    leftPBBasicIP.Image = loaded;
                }
                else
                {
                    MessageBox.Show("Failed to apply Gaussian Blur.");
                }
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            weight = trackBar1.Maximum - trackBar1.Value;
        }

        private void meanRemovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (leftPBBasicIP.Image != null)
            {
                Bitmap bmp = (Bitmap)leftPBBasicIP.Image.Clone();
                processed = BitmapFilter.MeanRemoval(bmp, weight);

                if (processed != null)
                {
                    // Display the blurred image in the PictureBox
                    rightPBBasicIP.Image = processed;
                    leftPBBasicIP.Image = loaded;
                }
                else
                {
                    MessageBox.Show("Failed to apply Gaussian Blur.");
                }
            }
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded != null)
            {
                //Bitmap bmp = (Bitmap)loaded.Clone();
                processed = BitmapFilter.Sharpen(loaded, weight);

                if (processed != null)
                {
                    // Display the blurred image in the PictureBox
                    rightPBBasicIP.Image = processed;
                    leftPBBasicIP.Image = loaded;
                }
                else
                {
                    MessageBox.Show("Failed to apply Gaussian Blur.");
                }
            }
        }

        private void kIRSHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (leftPBBasicIP.Image != null)
            {
                Bitmap bmp = (Bitmap)leftPBBasicIP.Image.Clone();

                processed = BitmapFilter.EdgeDetectConvolution(bmp, BitmapFilter.EDGE_DETECT_KIRSH, (byte)weight);

                if (processed != null)
                {
                    // Display the blurred image in the PictureBox
                    rightPBBasicIP.Image = processed;
                    leftPBBasicIP.Image = loaded;
                }
                else
                {
                    MessageBox.Show("Failed to apply Gaussian Blur.");
                }
            }
        }

        private void pREWITTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (leftPBBasicIP.Image != null)
            {
                Bitmap bmp = (Bitmap)leftPBBasicIP.Image.Clone();

                processed = BitmapFilter.EdgeDetectConvolution(bmp, BitmapFilter.EDGE_DETECT_PREWITT, (byte)weight);

                if (processed != null)
                {
                    // Display the blurred image in the PictureBox
                    rightPBBasicIP.Image = processed;
                    leftPBBasicIP.Image = loaded;
                }
                else
                {
                    MessageBox.Show("Failed to apply Gaussian Blur.");
                }
            }
        }

        private void sOBELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (leftPBBasicIP.Image != null)
            {
                Bitmap bmp = (Bitmap)leftPBBasicIP.Image.Clone();

                processed = BitmapFilter.EdgeDetectConvolution(bmp, BitmapFilter.EDGE_DETECT_SOBEL, (byte)weight);

                if (processed != null)
                {
                    // Display the blurred image in the PictureBox
                    rightPBBasicIP.Image = processed;
                    leftPBBasicIP.Image = loaded;
                }
                else
                {
                    MessageBox.Show("Failed to apply Gaussian Blur.");
                }
            }
        }

        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (leftPBBasicIP.Image != null)
            {
                Bitmap bmp = (Bitmap)leftPBBasicIP.Image.Clone();

                processed = BitmapFilter.EmbossLaplacian(bmp);

                if (processed != null)
                {
                    // Display the blurred image in the PictureBox
                    rightPBBasicIP.Image = processed;
                    leftPBBasicIP.Image = loaded;
                }
                else
                {
                    MessageBox.Show("Failed to apply Gaussian Blur.");
                }
            }
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (leftPBBasicIP.Image != null)
            {
                Bitmap bmp = (Bitmap)leftPBBasicIP.Image.Clone();

                processed = BitmapFilter.HorizontalEmboss(bmp);

                if (processed != null)
                {
                    // Display the blurred image in the PictureBox
                    rightPBBasicIP.Image = processed;
                    leftPBBasicIP.Image = loaded;
                }
                else
                {
                    MessageBox.Show("Failed to apply Gaussian Blur.");
                }
            }
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (leftPBBasicIP.Image != null)
            {
                Bitmap bmp = (Bitmap)leftPBBasicIP.Image.Clone();

                processed = BitmapFilter.VerticalEmboss(bmp);

                if (processed != null)
                {
                    // Display the blurred image in the PictureBox
                    rightPBBasicIP.Image = processed;
                    leftPBBasicIP.Image = loaded;
                }
                else
                {
                    MessageBox.Show("Failed to apply Gaussian Blur.");
                }
            }
        }

        private void allDirectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (leftPBBasicIP.Image != null)
            {
                Bitmap bmp = (Bitmap)leftPBBasicIP.Image.Clone();

                processed = BitmapFilter.AllDirectionsEmboss(bmp);

                if (processed != null)
                {
                    // Display the blurred image in the PictureBox
                    rightPBBasicIP.Image = processed;
                    leftPBBasicIP.Image = loaded;
                }
                else
                {
                    MessageBox.Show("Failed to apply Gaussian Blur.");
                }
            }
        }

        private void lossyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (leftPBBasicIP.Image != null)
            {
                Bitmap bmp = (Bitmap)leftPBBasicIP.Image.Clone();

                processed = BitmapFilter.LossyEmboss(bmp);

                if (processed != null)
                {
                    // Display the blurred image in the PictureBox
                    rightPBBasicIP.Image = processed;
                    leftPBBasicIP.Image = loaded;
                }
                else
                {
                    MessageBox.Show("Failed to apply Gaussian Blur.");
                }
            }
        }

        private void horzVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (leftPBBasicIP.Image != null)
            {
                Bitmap bmp = (Bitmap)leftPBBasicIP.Image.Clone();

                processed = BitmapFilter.Horz_Vert_Emboss(bmp);

                if (processed != null)
                {
                    // Display the blurred image in the PictureBox
                    rightPBBasicIP.Image = processed;
                    leftPBBasicIP.Image = loaded;
                }
                else
                {
                    MessageBox.Show("Failed to apply Gaussian Blur.");
                }
            }
        }
    }
}
