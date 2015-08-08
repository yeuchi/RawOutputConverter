namespace RawOutputConverter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listFiles = new System.Windows.Forms.TextBox();
            this.txtOpen = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkTIF = new System.Windows.Forms.CheckBox();
            this.chkPNG = new System.Windows.Forms.CheckBox();
            this.chkGIF = new System.Windows.Forms.CheckBox();
            this.chkJPG = new System.Windows.Forms.CheckBox();
            this.chkBMP = new System.Windows.Forms.CheckBox();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnScan = new System.Windows.Forms.Button();
            this.numFiles = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtNumShades = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picHist = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSaveHist = new System.Windows.Forms.Button();
            this.txtSaveHist = new System.Windows.Forms.TextBox();
            this.txtModeIndex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHist)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listFiles);
            this.groupBox1.Controls.Add(this.txtOpen);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source Directory (Raw)";
            // 
            // listFiles
            // 
            this.listFiles.Location = new System.Drawing.Point(7, 49);
            this.listFiles.Multiline = true;
            this.listFiles.Name = "listFiles";
            this.listFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listFiles.Size = new System.Drawing.Size(421, 97);
            this.listFiles.TabIndex = 2;
            // 
            // txtOpen
            // 
            this.txtOpen.Location = new System.Drawing.Point(89, 22);
            this.txtOpen.Name = "txtOpen";
            this.txtOpen.Size = new System.Drawing.Size(339, 20);
            this.txtOpen.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(7, 20);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkTIF);
            this.groupBox2.Controls.Add(this.chkPNG);
            this.groupBox2.Controls.Add(this.chkGIF);
            this.groupBox2.Controls.Add(this.chkJPG);
            this.groupBox2.Controls.Add(this.chkBMP);
            this.groupBox2.Controls.Add(this.txtSave);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination Image File ";
            // 
            // chkTIF
            // 
            this.chkTIF.AutoSize = true;
            this.chkTIF.Location = new System.Drawing.Point(262, 62);
            this.chkTIF.Name = "chkTIF";
            this.chkTIF.Size = new System.Drawing.Size(37, 17);
            this.chkTIF.TabIndex = 6;
            this.chkTIF.Text = "tiff";
            this.chkTIF.UseVisualStyleBackColor = true;
            // 
            // chkPNG
            // 
            this.chkPNG.AutoSize = true;
            this.chkPNG.Location = new System.Drawing.Point(183, 85);
            this.chkPNG.Name = "chkPNG";
            this.chkPNG.Size = new System.Drawing.Size(44, 17);
            this.chkPNG.TabIndex = 5;
            this.chkPNG.Text = "png";
            this.chkPNG.UseVisualStyleBackColor = true;
            // 
            // chkGIF
            // 
            this.chkGIF.AutoSize = true;
            this.chkGIF.Location = new System.Drawing.Point(183, 62);
            this.chkGIF.Name = "chkGIF";
            this.chkGIF.Size = new System.Drawing.Size(37, 17);
            this.chkGIF.TabIndex = 4;
            this.chkGIF.Text = "gif";
            this.chkGIF.UseVisualStyleBackColor = true;
            // 
            // chkJPG
            // 
            this.chkJPG.AutoSize = true;
            this.chkJPG.Location = new System.Drawing.Point(89, 85);
            this.chkJPG.Name = "chkJPG";
            this.chkJPG.Size = new System.Drawing.Size(46, 17);
            this.chkJPG.TabIndex = 3;
            this.chkJPG.Text = "jpeg";
            this.chkJPG.UseVisualStyleBackColor = true;
            // 
            // chkBMP
            // 
            this.chkBMP.AutoSize = true;
            this.chkBMP.Location = new System.Drawing.Point(89, 62);
            this.chkBMP.Name = "chkBMP";
            this.chkBMP.Size = new System.Drawing.Size(46, 17);
            this.chkBMP.TabIndex = 2;
            this.chkBMP.Text = "bmp";
            this.chkBMP.UseVisualStyleBackColor = true;
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(89, 22);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(339, 20);
            this.txtSave.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(7, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(376, 161);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Controls.Add(this.tabPage3);
            this.tab.Location = new System.Drawing.Point(12, 12);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(546, 298);
            this.tab.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnScan);
            this.tabPage1.Controls.Add(this.numFiles);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(538, 272);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(376, 171);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 2;
            this.btnScan.Text = "Re-Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // numFiles
            // 
            this.numFiles.AutoSize = true;
            this.numFiles.Location = new System.Drawing.Point(13, 176);
            this.numFiles.Name = "numFiles";
            this.numFiles.Size = new System.Drawing.Size(65, 13);
            this.numFiles.TabIndex = 1;
            this.numFiles.Text = "Total Count:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtModeIndex);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.btnLoad);
            this.tabPage2.Controls.Add(this.txtNumShades);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.numMax);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.numMin);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(538, 272);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(428, 230);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtNumShades
            // 
            this.txtNumShades.Enabled = false;
            this.txtNumShades.Location = new System.Drawing.Point(428, 191);
            this.txtNumShades.Name = "txtNumShades";
            this.txtNumShades.Size = new System.Drawing.Size(89, 20);
            this.txtNumShades.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Num Shades";
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(428, 83);
            this.numMax.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(89, 20);
            this.numMax.TabIndex = 4;
            this.numMax.Value = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numMax.ValueChanged += new System.EventHandler(this.numMax_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "maximum";
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(428, 27);
            this.numMin.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(89, 20);
            this.numMin.TabIndex = 2;
            this.numMin.ValueChanged += new System.EventHandler(this.numMin_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "minimum";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picHist);
            this.groupBox3.Location = new System.Drawing.Point(8, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(411, 179);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Histogram";
            // 
            // picHist
            // 
            this.picHist.Location = new System.Drawing.Point(6, 20);
            this.picHist.Name = "picHist";
            this.picHist.Size = new System.Drawing.Size(401, 150);
            this.picHist.TabIndex = 0;
            this.picHist.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnConvert);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(538, 221);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSaveHist);
            this.groupBox4.Controls.Add(this.btnSaveHist);
            this.groupBox4.Location = new System.Drawing.Point(8, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(411, 54);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Destination (.txt)";
            // 
            // btnSaveHist
            // 
            this.btnSaveHist.Location = new System.Drawing.Point(7, 20);
            this.btnSaveHist.Name = "btnSaveHist";
            this.btnSaveHist.Size = new System.Drawing.Size(75, 23);
            this.btnSaveHist.TabIndex = 0;
            this.btnSaveHist.Text = "Save";
            this.btnSaveHist.UseVisualStyleBackColor = true;
            this.btnSaveHist.Click += new System.EventHandler(this.btnSaveHist_Click);
            // 
            // txtSaveHist
            // 
            this.txtSaveHist.Location = new System.Drawing.Point(88, 22);
            this.txtSaveHist.Name = "txtSaveHist";
            this.txtSaveHist.Size = new System.Drawing.Size(317, 20);
            this.txtSaveHist.TabIndex = 1;
            // 
            // txtModeIndex
            // 
            this.txtModeIndex.Enabled = false;
            this.txtModeIndex.Location = new System.Drawing.Point(428, 147);
            this.txtModeIndex.Name = "txtModeIndex";
            this.txtModeIndex.Size = new System.Drawing.Size(89, 20);
            this.txtModeIndex.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mode Index";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 322);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.Text = "TCE 1209-U ASCII Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHist)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkJPG;
        private System.Windows.Forms.CheckBox chkBMP;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkTIF;
        private System.Windows.Forms.CheckBox chkPNG;
        private System.Windows.Forms.CheckBox chkGIF;
        private System.Windows.Forms.TextBox listFiles;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label numFiles;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNumShades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picHist;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSaveHist;
        private System.Windows.Forms.Button btnSaveHist;
        private System.Windows.Forms.TextBox txtModeIndex;
        private System.Windows.Forms.Label label4;
    }
}

