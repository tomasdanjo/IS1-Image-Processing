using System.ComponentModel;
using WebCamLib;
using AForge.Video;
using AForge.Video.DirectShow;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed;
        Device[] devices;
        Bitmap imageA, imageB, colorGreen;
        private IVideoSource _videoSource;

        private FilterInfo _currentDevice;

        public event PropertyChangedEventHandler PropertyChanged;


        public Form1()
        {
            InitializeComponent();
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
            BasicDIP.pixelCopy(ref loaded, ref processed);
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
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            StartCamera();


        }
        private void video_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            // Dispose the previous frame to free memory and avoid leaks
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
            }

            // Create a new bitmap from the frame and display it in pictureBox1
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = frame;
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
            leftPBBasicIP.Image= null;
            pictureBox1.Image= null;
            rightPBBasicIP.Image = null;
            pictureBox3.Image= null;
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




    }
}
