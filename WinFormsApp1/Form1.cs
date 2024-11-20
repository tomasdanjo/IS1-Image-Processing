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
        Bitmap imageA, imageB, colorGreen, result;
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
                _currentDevice = dev;


            }

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
            pictureBox1.Image = loaded;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            processed.Save(saveFileDialog1.FileName);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            devices = DeviceManager.GetAllDevices();
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartCamera();
        }

        Bitmap a;
        private void video_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            try
            {
                // Clone the current frame
                imageB = (Bitmap)eventArgs.Frame.Clone();


                if (imageA != null)
                {
                    BasicDIP.subtract(ref imageA, ref imageB, ref processed, 5);

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
            pictureBox3.Image = imageA;
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

        }

        private void greyscaleToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void smoothToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void meanRemovalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kIRSHToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pREWITTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sOBELToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void allDirectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lossyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void horzVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void pixelCopyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ImageProcess.copyImage(ref loaded, ref processed);
            pictureBox2.Image = processed;
        }

        private void greyscaleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BasicDIP.greyscale(ref loaded, ref processed);
            pictureBox2.Image = processed;
        }

        private void inversionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BasicDIP.invert(ref loaded, ref processed);
            pictureBox2.Image = processed;
        }

        private void histogramToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BasicDIP.histogram(ref loaded, ref processed);
            pictureBox2.Image = processed;

        }

        private void sepiaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BasicDIP.sepia(ref loaded, ref processed);
            pictureBox2.Image = processed;
        }


        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void sharpenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            processed = BitmapFilter.Smooth(loaded, weight);
            pictureBox2.Image = processed;

        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = BitmapFilter.GaussianBlur(loaded, weight);
            pictureBox2.Image = processed;
        }

        private void edgeEnhanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = BitmapFilter.EdgeEnhance(loaded, (byte)weight);
            pictureBox2.Image = processed;
        }

        private void kIRSHToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            processed = BitmapFilter.EdgeDetectConvolution(loaded, BitmapFilter.EDGE_DETECT_KIRSH, (byte)weight);
            pictureBox2.Image = processed;
        }

        private void pREWITTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            processed = BitmapFilter.EdgeDetectConvolution(loaded, BitmapFilter.EDGE_DETECT_PREWITT, (byte)weight);
            pictureBox2.Image = processed;
        }

        private void sOBELToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            processed = BitmapFilter.EdgeDetectConvolution(loaded, BitmapFilter.EDGE_DETECT_SOBEL, (byte)weight);
            pictureBox2.Image = processed;
        }

        private void meanRemovalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            processed = BitmapFilter.MeanRemoval(loaded, (byte)weight);
            pictureBox2.Image = processed;
        }

        private void laplascianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = BitmapFilter.EmbossLaplacian(loaded);
            pictureBox2.Image = processed;
        }

        private void horzVerticalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            processed = BitmapFilter.HorizontalEmboss(loaded);
            pictureBox2.Image = processed;
        }

        private void lossyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            processed = BitmapFilter.LossyEmboss(loaded);
            pictureBox2.Image = processed;
        }

        private void horizontalOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = BitmapFilter.HorizontalEmboss(loaded);
            pictureBox2.Image = processed;
        }

        private void verticalOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = BitmapFilter.VerticalEmboss(loaded);
            pictureBox2.Image = processed;
        }

        private void allDirectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = BitmapFilter.AllDirectionsEmboss(loaded);
            pictureBox2.Image = processed;
        }

        private void smoothToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            processed = BitmapFilter.Smooth(loaded, weight);
            pictureBox2.Image = processed;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog4.ShowDialog();
        }

        private void openFileDialog4_FileOk(object sender, CancelEventArgs e)
        {
            imageB = new Bitmap(openFileDialog4.FileName);
            pictureBox4.Image = imageB;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BasicDIP.subtract(ref imageB,  ref imageA, ref result, 5);
            pictureBox5.Image = result;
        }
    }
}
