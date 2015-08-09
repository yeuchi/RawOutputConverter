using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace RawOutputConverter
{
    public class HistogramView
    {
        public string error;
        public Bitmap bmp;
        public Graphics g;
        public Rectangle rect;

        protected double yScale;
        protected double xScale;
        protected double lineScale; 

        protected PictureBox picHist;
        protected Histogram histogram;

        public HistogramView(PictureBox picBox,
                             Histogram histogram)
        {
            this.picHist = picBox;
            this.histogram = histogram;
            bmp = new Bitmap(picHist.Width, picHist.Height);
            g = Graphics.FromImage(bmp);
            rect = new Rectangle(0, 0, picHist.Width, picHist.Height);
            xScale = (double)Histogram.MAX_PIXEL_DEPTH / (double)picHist.Width;
            lineScale = (double)picHist.Width/(double)Histogram.MAX_PIXEL_DEPTH;
        }


        private double getYScale()
        {
            return (histogram.modeValue>0)?
                picHist.Height / (double)histogram.modeValue:1;
        }

        public bool draw(int min, int max)
        {
            try
            {
                bool success = drawData();
                if (false == success)
                    return false;

                drawMin(min);
                drawMax(max);
                drawMode();
                picHist.Image = (Image)bmp;
                return true;
            }
            catch (Exception ex)
            {
                error = "HistogramView draw() failed: " + ex.Message;
                return false;
            }
        }

        /*
         * Draw histogram content
         */
        protected bool drawData()
        {
            try
            {
                g.FillRectangle(Brushes.White, 0, 0, bmp.Width, bmp.Height);

                // pens
                Pen p = new Pen(Color.Gray, 1);

                // scaling
                double yScale = getYScale();

                // draw a scaled histogram 
                for (int i = 0; i < picHist.Width; i++)
                {
                    // sum up values
                    double sum = 0;
                    int xStart = (int)((double)i * xScale);
                    int xEnd = (int)((double)i * xScale + xScale);
                    for (int j = xStart; j < xEnd; j++)
                        sum += histogram.records[j];

                    
                    int h = (int)(sum/xScale * yScale);
                    if (h > picHist.Height)
                        h = picHist.Height;

                    if(h>0)
                        g.DrawLine(p, i, picHist.Height, i, picHist.Height-h);
                }
                return true;
            }
            catch (Exception ex)
            {
                error = "HistogramView.drawData() failed: " + ex.Message;
            }
            return false;
        }

        protected bool drawMin(decimal value)
        {
            try
            {
                if (histogram.min <=0)
                    throw new Exception("Histogram has not been rendered");

                Pen p = new Pen(Color.Green, 1);       // min - black
                int i = (int)((double)value * lineScale);
                g.DrawLine(p, i, 0, i, picHist.Height);

                return true;
            }
            catch (Exception ex)
            {
                error = "HistogramView.drawMin() failed: " + ex.Message;
            }
            return false;
        }

        protected bool drawMax(decimal value)
        {
            try
            {
                if (histogram.max <= 0)
                    throw new Exception("Histogram has not been rendered");

                Pen p = new Pen(Color.Green, 1);       // max - black
                int i = (int)((double)value * lineScale);
                g.DrawLine(p, i, 0, i, picHist.Height);

                return true;
            }
            catch (Exception ex)
            {
                error = "HistogramView.drawMax() failed: " + ex.Message;
            }
            return false;
        }

        protected bool drawMode()
        {
            try
            {
                if (histogram.modeIndex <= 0)
                    throw new Exception("Histogram has not been rendered");

                Pen p = new Pen(Color.Blue, 1);       // max - black
                int i = (int)((double)histogram.modeIndex * lineScale);
                g.DrawLine(p, i, 0, i, picHist.Height);

                return true;
            }
            catch (Exception ex)
            {
                error = "HistogramView.drawMode() failed: " + ex.Message;
            }
            return false;
        }
    }
}
