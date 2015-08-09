using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace RawOutputConverter
{
    public partial class Form1 : Form
    {
        Histogram histogram;
        HistogramView histView;
        ImageFileHandler imageHandler;
        FileSystemInfo[] listFileInfo;

        public Form1()
        {
            InitializeComponent();
            // set tab page titles
            tabPage1.Text = "Source";
            tabPage2.Text = "Preprocess";
            tabPage3.Text = "Destination";

            imageHandler = new ImageFileHandler();
            histogram = new Histogram();
            histView = new HistogramView(picHist, histogram);
        }

        // tab page 1
        /*
         * Select an image directory with raw image lines in ascii
         */
        private void btnOpen_Click(object sender, EventArgs e)
        {
            // dialog to set directory path
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtOpen.Text = folderBrowserDialog1.SelectedPath;
                btnScan_Click(null, null);
            }
        }

        /*
         * Update directory content info
         * - count number of files
         * - retrieve common file prefix name
         * - display filenames in listbox
         */
        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                DirectoryInfo directoryInfo = new DirectoryInfo(txtOpen.Text);
                FileSystemInfo[] filesInfo = directoryInfo.GetFileSystemInfos();
                var list = filesInfo.OrderBy(f => f.CreationTime);

                listFiles.Text = "";
                numFiles.Text = "Files count: " + filesInfo.Count();

                listFileInfo = new FileSystemInfo[filesInfo.Count()];
                for (int i = 0; i < list.Count(); i++)
                {
                    listFileInfo[i] = list.ElementAt(i);
                    listFiles.Text += i +") " + listFileInfo[i].Name + "\r\n";
                }
                this.Cursor = Cursors.Default;

            }
            catch (Exception ex)
            {
                string error = "DirectoryHandler failed: " + ex.Message;
                DisplayError(error);
            }
        }

        // tab page 2

        /*
         * Go build a histogram !
         */
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (null == listFileInfo)
                {
                    DisplayError("Please set Source Directory");
                    return;
                }
                this.Cursor = Cursors.WaitCursor;
                // build histogram from all files
                histogram.clear();
                for (int i = 0; i < listFileInfo.Count(); i++)
                {
                    string[] lineOfPixels = imageHandler.loadAscii(listFileInfo[i].FullName);
                    if (null == lineOfPixels)
                    {
                        DisplayError(imageHandler.error);
                        return;
                    }
                    histogram.append(lineOfPixels);
                }
                bool success = histogram.statistics();
                if (false == success)
                {
                    DisplayError(histogram.error);
                    return;
                }

                // publish min, max, mode, number of shades
                numMin.Value = histogram.min;
                numMax.Value = histogram.max;
                txtModeIndex.Text = histogram.modeIndex.ToString();
                txtNumShades.Text = histogram.numShades.ToString();

                // draw histogram on image
                DrawHistogram();

                // write histogram to file
                if (null!=txtSaveHist.Text && txtSaveHist.Text.Length > 0)
                {
                     success = histogram.save(txtSaveHist.Text);
                    if (false == success)
                        DisplayError(histogram.error);
                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                DisplayError("Histogram failed: " + ex.Message);
            }
        }

        /*
         * Set Destination file path for histogram 
         */
        private void btnSaveHist_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.FileName = "Histogram";

            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;

            // get image and write to disk
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSaveHist.Text = saveFileDialog1.FileName;
            }
        }

        /*
         * Manual override of image floor value
         * - go recalculate look up table
         */
        private void numMin_ValueChanged(object sender, EventArgs e)
        {
            //re-draw line
            histView.drawMin(numMin.Value);
        }

        /*
         * Manual override of image ceiling value
         * - go recalculate look up table
         */
        private void numMax_ValueChanged(object sender, EventArgs e)
        {
            // re-draw line
            histView.drawMax(numMin.Value);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // set destination file name prefix
                saveFileDialog1.InitialDirectory = "c:\\";
                saveFileDialog1.FileName = "Image";

                saveFileDialog1.Filter = "Multiple files (*)|*|JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png |TIFF files (*.tif)|*.tif|Bitmap files (*.bmp)|*.bmp|GIF files (*.gif)|*.gif";
                saveFileDialog1.FilterIndex = 1;

                // get image and write to disk
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtSave.Text = saveFileDialog1.FileName;
                    int pos = txtSave.Text.IndexOf(".");

                    if (pos > 0)
                    {
                        // file type selected
                        txtSave.Text = txtSave.Text.Substring(0, pos);
                        string filetype = txtSave.Text.Substring(pos + 1, 3);
                        chkBMP.Checked = chkJPG.Checked = chkPNG.Checked = chkTIF.Checked = chkGIF.Checked = false;
                        switch (filetype.ToLower())
                        {
                            case "jpg":
                                chkJPG.Checked = true;
                                break;
                            case "png":
                                chkPNG.Checked = true;
                                break;
                            case "tif":
                                chkTIF.Checked = true;
                                break;
                            case "gif":
                                chkGIF.Checked = true;
                                break;
                            case "bmp":
                                chkBMP.Checked = true;
                                break;
                        }
                    }
                    else
                    {
                        // at least 1 should be selected ?
                        if (false == chkBMP.Checked &&
                            false == chkPNG.Checked &&
                            false == chkJPG.Checked &&
                            false == chkGIF.Checked &&
                            false == chkTIF.Checked)
                            chkBMP.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayError("Set Destination failed: " + ex.Message);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                // load ascii files / look up table / save to bitmap in memory
                if (listFileInfo.Count() > 0 && txtSave.Text.Length > 0)
                {
                    this.Cursor = Cursors.WaitCursor;

                    bool success = histogram.createLUT((int)numMin.Value, (int)numMax.Value);
                    if (false == success)
                    {
                        DisplayError(histogram.error);
                        return;
                    }

                    int imageWidth = listFileInfo.Count();
                    success = imageHandler.allocBitmap(imageWidth);
                    if (false == success)
                    {
                        DisplayError(histogram.error);
                        return;
                    }

                    for (int x = 0; x < listFileInfo.Count(); x++)
                    {
                        // load ascii strings
                        string[] lineOfPixels = imageHandler.loadAscii(listFileInfo[x].FullName);
                        if (null == lineOfPixels)
                        {
                            DisplayError(imageHandler.error);
                            return;
                        }

                        // 12bpp -> 8bpp
                        success = imageHandler.ascii2Bytes(x, lineOfPixels, histogram.lut);
                        if (false == success)
                        {
                            DisplayError(histogram.error);
                            return;
                        }
                    }

                    // save bitmap to files
                    if (true == chkBMP.Checked)
                        imageHandler.bmp.Save(txtSave.Text + ".bmp", ImageFormat.Bmp);

                    if (true == chkPNG.Checked)
                        imageHandler.bmp.Save(txtSave.Text + ".png", ImageFormat.Png);

                    if (true == chkJPG.Checked)
                        imageHandler.bmp.Save(txtSave.Text + ".jpg", ImageFormat.Jpeg);

                    if (true == chkTIF.Checked)
                        imageHandler.bmp.Save(txtSave.Text + ".tif", ImageFormat.Tiff);

                    if (true == chkGIF.Checked)
                        imageHandler.bmp.Save(txtSave.Text + ".gif", ImageFormat.Gif);

                    this.Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                DisplayError("Conversion failed: " + ex.Message);
            }
        }

        private void DrawHistogram()
        {
            if (histogram.max <= 0)
            {
                DisplayError("Invalid histogram max value");
                return;
            }
            bool success = histView.drawData();
            if (false == success)
                DisplayError(histView.error);

             success = histView.drawMin(numMin.Value);
            if (false == success)
                DisplayError(histView.error);

             success = histView.drawMax(numMax.Value);
            if (false == success)
                DisplayError(histView.error);

             success = histView.drawMode();
            if (false == success)
                DisplayError(histView.error);
        }

        // Description:	Display an error box
        void DisplayError(string sError)
        {
            this.Cursor = Cursors.Default;
            MessageBox.Show(sError,
                "Caption", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
