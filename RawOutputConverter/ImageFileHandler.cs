// ==================================================================
// Module:      ImageFileHandler
//
// Description: - Load ASCII files for image line.
//              - create/manipulate bitmap (8bpp)
//              - save image to file
//              ** specific to TCE 1209-U (2048 pixels line)
// ==================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RawOutputConverter
{
    public class ImageFileHandler
    {
        public string error;
        public const int LINE_WIDTH = 2048;
        public string[] aLine;
        public Bitmap bmp;

        public ImageFileHandler()
        {
            aLine = new string[LINE_WIDTH];
        }

        public void clear()
        {
            aLine = null;
            if(null!=bmp)
                bmp.Dispose();
            bmp = null;
        }

        /*
         * Load one line of pixels (ascii - text file)
         * - each pixel is carriage delimited
         */
        public string[] loadAscii(string filepath)
        {
            try
            {
                int index = 0;
                System.IO.StreamReader file = new System.IO.StreamReader(filepath);
                while (index < LINE_WIDTH && (aLine[index] = file.ReadLine()) != null)
                {
                    index++;
                }
                return aLine;
            }
            catch (Exception ex)
            {
                error = "ImageFileHandler.loadAscii() failed: " + ex.Message;
                return null;
            }
        }

        /*
         * Allocate an intermediate 8bpp bitmap in memory
         */
        public bool allocBitmap(int width)
        {
            try
            {
                // create a bmp instance -- consider 8bpp only 
                bmp = new Bitmap(width, LINE_WIDTH);
                return true;
            }
            catch (Exception ex)
            {
                error = "ImageFileHandler.allocBitmap() failed: " + ex.Message;
                return false;
            }
        }

        /*
         * 1) Convert string to int
         * 2) Apply look up table to produce byte bound value
         * 3) append to bitmap
         */
        public bool ascii2Bytes(int x,
                                string[] linePixels,
                                int[] lut)
        {
            try
            {
                if (null != bmp)
                {
                    byte[] pixels = new byte[LINE_WIDTH];
                    for (int y = 0; y < LINE_WIDTH; y++)
                    {
                        Int16 p = Int16.Parse(linePixels[y]);
                        int c = lut[p];
                        Color color = Color.FromArgb(c, c, c);
                        bmp.SetPixel(x, y, color);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                error = "ImageFileHandler.ascii2Bytes() failed: " + ex.Message;
                return false;
            }
        }
    }
}
