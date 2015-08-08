// ==================================================================
// Module:      Histogram
//
// Description: - create/write image histogram and look up table
//              - look up table for tone correction
// ==================================================================
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.IO;

namespace RawOutputConverter
{
    public class Histogram
    {
        public string error;
        public const int MAX_PIXEL_DEPTH = 4096;
        public int[] records;               // the actual histogram
        public int[] lut;                   // look up table

        protected int _numShades = 0;
        protected int _min = MAX_PIXEL_DEPTH;
        protected int _max = 0;
        protected int _modeValue = 0;
        protected int _modeIndex = -1;

        public Histogram()
        {
            clear();
        }

        public int numShades
        {
            get { return _numShades; }
        }

        public int min
        {
            get { return _min; }
        }

        public int max
        {
            get { return _max; }
        }

        public int modeIndex
        {
            get { return _modeIndex; }
        }

        public int modeValue
        {
            get { return _modeValue; }
        }

        /*
         * Clear histogram and info
         */
        public void clear()
        {
            _min = -1;
            _max = -1;
            _numShades = -1;
            _modeValue = -1;
            _modeIndex = -1;
            records = new int[MAX_PIXEL_DEPTH];
            lut = new int[MAX_PIXEL_DEPTH];
        }

        /*
         * Add/process one line of pixels into histogram
         */
        public bool append(string[] lineOfPixels)
        {
            try
            {
                for (int y = 0; y < lineOfPixels.Length; y++)
                {
                    int value = int.Parse(lineOfPixels[y]);
                    records[value]++;
                }
                return true;
            }
            catch(Exception ex)
            {
                error = "Histogram.append() failed: " + ex.Message;
                return false;
            }
        }

        /*
         * File basic histogram info
         */
        public bool statistics ()
        {
            try
            {
                _min = 4096;
                _max = 0;
                _numShades = 0;
                for (int i = 0; i < records.Length; i++)
                {
                    if (records[i] > 0)
                    {
                        _numShades++;

                        if (i < _min)
                            _min = i;

                        if (i > _max)
                            _max = i;

                        if (records[i] > _modeValue)
                        {
                            _modeValue = records[i];
                            _modeIndex = i;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                error = "Histogram.statistics() failed: " + ex.Message;
                return false;
            }
        }

        /*
         * Create look up table
         * - simple histogram equalization look up table by min/max.
         * ** someday ** expand this for png16
         * ** maybe ** add gamma or curve adjustmens ?
         */
        public bool createLUT(int min, int max)
        {
            try
            {
                if (min < max)
                {
                    double range = max - min;
                    double scale = range / 255.0;

                    lut = new int[MAX_PIXEL_DEPTH];
                    // clipped dark values -- requantize to 0
                    for (int i = 0; i < min; i++)
                        lut[i] = 0;
                    
                    // clipped white values -- requantize to 255
                    for (int i = max; i < MAX_PIXEL_DEPTH; i++)
                        lut[i] = 255;

                    // offset DC value and scale amplitude from range -> 8 bpp (255 shades)
                    for (int i = (min + 1); i < (max - 1); i++)
                        lut[i] = (int)((double)(i - min) / scale);

                    return true;
                }
            }
            catch (Exception ex)
            {
                error = "Histogram.createLUT() failed: " + ex.Message;
            }
            return false;
        }

        /*
         * Write histogram to file
         */
        public bool save(string filename)
        {
            try
            {
                using (StreamWriter outfile = new StreamWriter("@"+filename))
                {
                    for (int i = 0; i < records.Length; i++)
                    {
                        string line = i.ToString() + "\t" + records[i].ToString();
                        outfile.WriteLine(line);
                    }

                    string minStr = "min\t" + min.ToString();
                    outfile.WriteLine(minStr);

                    string maxStr = "max\t" + max.ToString();
                    outfile.WriteLine(maxStr);

                    string numShadesStr = "num of shades\t" + numShades.ToString();
                    outfile.WriteLine(numShadesStr);
                }
                return true;
            }
            catch (Exception ex)
            {
                error = "Histogram.save() failed: " + ex.Message;
                return false;
            }
        }

    }
}
