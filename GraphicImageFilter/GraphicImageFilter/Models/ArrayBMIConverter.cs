using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace GraphicImageFilter.Models
{
    internal static class ArrayBMIConverter
    {
        public static int blue = 0xFF;
        public static int green = 0xFF00;
        public static int red = 0xFF0000;
        public static bool colourFolder = false;

        #region BitmapImage to 2D array
        public static int[,] BitmapImageToArray2D(BitmapImage src)
        {
            int[,] array2D = new int[src.PixelHeight, src.PixelWidth];

            WriteableBitmap wb = new WriteableBitmap(src);
            int width = wb.PixelWidth;
            int height = wb.PixelHeight;
            int bytesPerPixel = (wb.Format.BitsPerPixel + 7) / 8;
            int stride = wb.BackBufferStride;
            wb.Lock();
            unsafe
            {
                byte* pImgData = (byte*)wb.BackBuffer;
                int cRowStart = 0;
                int cColStart = 0;
                for (int row = 0; row < height; row++)
                {
                    cColStart = cRowStart;
                    for (int col = 0; col < width; col++)
                    {
                        byte* bPixel = pImgData + cColStart;

                        if (colourFolder == true)
                        {
                            bPixel[0] = (byte)blue; // Blue
                            bPixel[1] = (byte)ColourIntHexConverter.ConvertGreen(green); // Green
                            bPixel[2] = (byte)ColourIntHexConverter.ConvertRed(red); // Red
                        }

                        int pixel = bPixel[2]; //Red
                        pixel = (pixel << 8) + bPixel[1]; //Green
                        pixel = (pixel << 8) + bPixel[0]; //Blue
                        array2D[row, col] = pixel;

                        cColStart += bytesPerPixel;
                    }
                    cRowStart += stride;
                }
            }
            wb.Unlock();
            wb.Freeze();

            return array2D;
        }
        #endregion

        #region 2D array to BitmapImage
        public static WriteableBitmap Array2DToWriteableBitmap(int[,] array2D, BitmapImage src)
        {
            WriteableBitmap wb = new WriteableBitmap(src);
            int width = wb.PixelWidth;
            int height = wb.PixelHeight;
            int bytesPerPixel = (wb.Format.BitsPerPixel + 7) / 8;
            int stride = wb.BackBufferStride;
            wb.Lock();
            unsafe
            {
                byte* pImgData = (byte*)wb.BackBuffer;
                int cRowStart = 0;
                int cColStart = 0;
                for (int row = 0; row < height; row++)
                {
                    cColStart = cRowStart;
                    for (int col = 0; col < width; col++)
                    {
                        byte* bPixel = pImgData + cColStart;

                        if (colourFolder == true)
                        {
                            bPixel[0] = (byte)((array2D[row, col] & 0xFF)); // Blue
                            bPixel[1] = (byte)((array2D[row, col] & 0xFF00) >> 8); // Green
                            bPixel[2] = (byte)((array2D[row, col] & 0xFF0000) >> 16); // Red
                        }

                        else
                        {
                            bPixel[0] = (byte)((array2D[row, col] & blue)); // Blue
                            bPixel[1] = (byte)((array2D[row, col] & green) >> 8); // Green
                            bPixel[2] = (byte)((array2D[row, col] & red) >> 16); // Red
                        }

                        cColStart += bytesPerPixel;
                    }
                    cRowStart += stride;
                }
            }
            wb.Unlock();
            wb.Freeze();

            return wb;
        }

        public static BitmapImage ConvertWriteableBitmapToBitmapImage(WriteableBitmap wbm)
        {
            BitmapImage bmImage = new BitmapImage();
            using (MemoryStream stream = new MemoryStream())
            {
                PngBitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(wbm));
                encoder.Save(stream);
                bmImage.BeginInit();
                bmImage.CacheOption = BitmapCacheOption.OnLoad;
                bmImage.StreamSource = stream;
                bmImage.EndInit();
                bmImage.Freeze();
            }

            return bmImage;
        }
        #endregion
    }
}
