using System.ComponentModel;
using WebCamLib;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Diagnostics;
using HNUDIP;
using ImageProcess2;
using OpenCvSharp;
using System.Drawing;
using System.Drawing.Imaging;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed;
        Device[] devices;
        Bitmap imageA, imageB, colorGreen, result;
        private IVideoSource _videoSource;
        FilterInfoCollection fic;
        Bitmap coinpic, coinresult;


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
            BasicDIP.subtract(ref imageB, ref imageA, ref result, 5);
            pictureBox5.Image = result;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog5.ShowDialog();
        }

        private void openFileDialog5_FileOk(object sender, CancelEventArgs e)
        {
            coinpic = new Bitmap(openFileDialog5.FileName);

            pictureBox6.Image = coinpic;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //
            //gausian blur
            //edge enhance
            //meanRemoval
            //edge detect sobel
            //draw contours
            //coinresult = coinpic;
            coinresult = BitmapFilter.Sharpen(coinpic, 10);
            coinresult = BitmapFilter.GaussianBlur(coinpic, 10);
            coinresult = BitmapFilter.EdgeEnhance(coinpic, 15);
            coinresult = BitmapFilter.MeanRemoval(coinpic, 15);
            coinresult = BitmapFilter.EdgeDetectConvolution(coinpic, BitmapFilter.EDGE_DETECT_SOBEL, 10);

            BasicDIP.contours(ref coinpic, ref coinresult);
            pictureBox6.Image = coinresult;







        }

        private Dictionary<string, int> CountAndClassifyCoins(Bitmap binaryImage)
        {
            // Result: Dictionary to hold coin classifications
            Dictionary<string, int> coinCounts = new Dictionary<string, int>
    {
        { "5-cent", 0 },
        { "10-cent", 0 },
        { "25-cent", 0 },
        {"1-peso",0 },
        {"5-peso",0 }
    };

            bool[,] visited = new bool[binaryImage.Width, binaryImage.Height];
            int numcoins = 0;
            List<int> numbers = new List<int>();

            // Loop through the image to find contours
            for (int y = 0; y < binaryImage.Height; y++)
            {
                for (int x = 0; x < binaryImage.Width; x++)
                {
                    // If the pixel is white (part of a coin) and not visited
                    if (binaryImage.GetPixel(x, y).R == 255 && !visited[x, y])
                    {
                        // Measure the area of the contour using flood-fill
                        int contourArea = MeasureContourArea(binaryImage, x, y, visited);

                        // Classify based on area thresholds
                        if (contourArea > 450)
                        {
                            coinCounts["5-peso"]++;
                        }
                        else if (contourArea > 335)
                        {
                            coinCounts["1-peso"]++;
                        }
                        else if (contourArea > 260)
                        {
                            coinCounts["25-cent"]++;
                        }
                        else if (contourArea > 225)
                        {
                            coinCounts["10-cent"]++;
                        }
                        else if (contourArea > 200)
                        {
                            coinCounts["5-cent"]++;
                        }

                        //if (contourArea < 500) // Example threshold
                        //    //coinCounts["Small"]++;
                        //    Debug.wri
                        //else if (contourArea < 1500) // Example threshold
                        //    //coinCounts["Medium"]++;
                        //else
                        //    //coinCounts["Large"]++;

                    }
                }
            }

            //Debug.WriteLine(string.Join(", ", numbers));


            return coinCounts;
        }

        private int MeasureContourArea(Bitmap image, int startX, int startY, bool[,] visited)
        {
            int width = image.Width;
            int height = image.Height;

            Stack<System.Drawing.Point> stack = new Stack<System.Drawing.Point>();
            stack.Push(new System.Drawing.Point(startX, startY));

            int area = 0;

            while (stack.Count > 0)
            {
                System.Drawing.Point p = stack.Pop();
                int x = p.X;
                int y = p.Y;

                // Check bounds and if pixel is already visited
                if (x < 0 || x >= width || y < 0 || y >= height || visited[x, y])
                    continue;

                // Check if the pixel is part of a coin
                if (image.GetPixel(x, y).R == 255)
                {
                    visited[x, y] = true;
                    area++; // Increment area count

                    // Push neighboring pixels
                    stack.Push(new System.Drawing.Point(x + 1, y));
                    stack.Push(new System.Drawing.Point(x - 1, y));
                    stack.Push(new System.Drawing.Point(x, y + 1));
                    stack.Push(new System.Drawing.Point(x, y - 1));
                }
            }

            return area;
        }


        private void button7_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("Clicked");

            Dictionary<string, int> coinCounts = CountAndClassifyCoins(coinresult);
            int peso = 0, cent = 0;
            peso += coinCounts["5-peso"] * 5;
            peso += coinCounts["1-peso"];

            cent += coinCounts["25-cent"] * 25;
            cent += coinCounts["10-cent"] * 10;
            cent += coinCounts["5-cent"] * 5;
            peso += cent / 100;
            cent %= 100;
            Debug.WriteLine("Peso: " + peso);
            Debug.WriteLine("Cent: " + cent);
            label5Peso.Text = coinCounts["5-peso"].ToString();
            label1Peso.Text = coinCounts["1-peso"].ToString();
            label25Cent.Text = coinCounts["25-cent"].ToString();
            label10Cent.Text = coinCounts["10-cent"].ToString();
            label5Cent.Text = coinCounts["5-cent"].ToString();
            labeltotal.Text = "P" + peso + "." + cent;



        }

    }
}
