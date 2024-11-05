using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    static class BasicDIP
    {
        public static void pixelCopy(ref Bitmap ImageA, ref Bitmap ImageB)
        {
            ImageB = new Bitmap(ImageA.Width, ImageA.Height);
            for (int x = 0; x < ImageA.Width; x++)
            {
                for (int y = 0; y < ImageA.Height; y++)
                {
                    Color pix = ImageA.GetPixel(x, y);
                    ImageB.SetPixel(x, y, pix);
                }
            }

        }

        public static void greyscale(ref Bitmap ImageA, ref Bitmap ImageB)
        {
            ImageB = new Bitmap(ImageA.Width, ImageA.Height);

            for (int x = 0; x < ImageA.Width; x++)
            {
                for (int y = 0; y < ImageA.Height; y++)
                {
                    Color pix = ImageA.GetPixel(x, y);
                    int avg = (pix.R + pix.G + pix.B) / 3;
                    Color newpix = Color.FromArgb(avg, avg, avg);
                    ImageB.SetPixel(x, y, newpix);
                }
            }
        }

        public static void invert(ref Bitmap ImageA, ref Bitmap ImageB)
        {
            ImageB = new Bitmap(ImageA.Width, ImageA.Height);

            for (int x = 0; x < ImageA.Width; x++)
            {
                for (int y = 0; y < ImageA.Height; y++)
                {
                    Color pix = ImageA.GetPixel(x, y);

                    Color newpix = Color.FromArgb(255 - pix.R, 255 - pix.G, 255 - pix.B);
                    ImageB.SetPixel(x, y, newpix);
                }
            }
        }

        public static void histogram(ref Bitmap ImageA, ref Bitmap ImageB)
        {
            Bitmap temp = new Bitmap(ImageA.Width, ImageA.Height);
            for (int x = 0; x < ImageA.Width; x++)
            {
                for (int y = 0; y < ImageA.Height; y++)
                {
                    Color sample = ImageA.GetPixel(x, y);
                    Byte graydata = (byte)((sample.R + sample.G + sample.B) / 3);
                    Color gray = Color.FromArgb(graydata, graydata, graydata);
                    temp.SetPixel(x, y, gray);
                }
            }

            int[] histData = new int[256];
            for (int x = 0; x < temp.Width; x++)
            {
                for (int y = 0; y < temp.Height; y++)
                {
                    Color sample = temp.GetPixel(x, y);
                    histData[sample.R]++;
                }
            }

            ImageB = new Bitmap(256, 5000);
            for (int x = 0; x < ImageB.Width; x++)
            {
                for (int y = 0; y < ImageB.Height; y++)
                {
                    ImageB.SetPixel(x, y, Color.White);
                }
            }

            for (int x = 0; x < ImageB.Width; x++)
            {
                for (int y = 0; y < Math.Min(histData[x], ImageB.Height - 1); y++)
                {
                    ImageB.SetPixel(x, (ImageB.Height - 1) - y, Color.Black);
                }
            }
        }

        public static void sepia(ref Bitmap ImageA, ref Bitmap ImageB)
        {
            ImageB = new Bitmap(ImageA.Width, ImageA.Height);
            for (int x = 0; x < ImageA.Width; x++)
            {
                for (int y = 0; y < ImageA.Height; y++)
                {
                    Color pix = ImageA.GetPixel(x, y);
                    int tr, tg, tb;
                    int R = pix.R, G = pix.G, B = pix.B;
                    tr = Math.Min(255, (int)(0.393 * R + 0.769 * G + 0.189 * B));
                    tg = Math.Min(255, (int)(0.349 * R + 0.686 * G + 0.168 * B));
                    tb = Math.Min(255, (int)(0.272 * R + 0.534 * G + 0.131 * B));


                    Color newpix = Color.FromArgb(tr, tg, tb);
                    ImageB.SetPixel(x, y, newpix);

                }
            }
        }

        public static void subtract(ref Bitmap ImageA, ref Bitmap ImageB, ref Bitmap result, int threshold)
        {
            int width = ImageB.Width;
            int height = ImageB.Height;

            result = new Bitmap(width, height);
            Color green = Color.FromArgb(0, 0, 255);
            int greygreen = (green.R + green.G + green.B) / 3;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color pixel, backpixel;
                    if (x < ImageB.Width && y < ImageB.Height) pixel = ImageB.GetPixel(x, y);
                    else pixel = Color.White;
                    if (x < ImageA.Width && y < ImageA.Height) backpixel = ImageA.GetPixel(x, y);
                    else backpixel = Color.White;

                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractvalue = Math.Abs(grey - greygreen);
                    if (subtractvalue >= 0 && subtractvalue <= threshold)
                    {
                        result.SetPixel(x, y, backpixel);
                    }
                    else
                    {
                        result.SetPixel(x, y, pixel);
                    }

                }
            }
        }
    }
}
