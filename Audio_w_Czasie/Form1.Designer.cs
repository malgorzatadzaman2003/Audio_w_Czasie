namespace Audio_w_Czasie
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openWAVToolStripMenuItem = new ToolStripMenuItem();
            exportCSVToolStripMenuItem = new ToolStripMenuItem();
            pnlTop = new Panel();
            grpInfo = new GroupBox();
            tblInfo = new TableLayoutPanel();
            lblLenVal = new Label();
            labelLenTitle = new Label();
            lblBitsVal = new Label();
            labelBitsTitle = new Label();
            lblChVal = new Label();
            lblFsVal = new Label();
            lblFileVal = new Label();
            labelFileTitle = new Label();
            labelFsTitle = new Label();
            labelChTitle = new Label();
            optionsPanel = new FlowLayoutPanel();
            chkSilence = new CheckBox();
            chkNormalizeVolume = new CheckBox();
            lblFeature = new Label();
            cmbFeature = new ComboBox();
            lblGender = new Label();
            tabControl1 = new TabControl();
            tabWave = new TabPage();
            formsPlotWave = new ScottPlot.WinForms.FormsPlot();
            tabFeat = new TabPage();
            formsPlotFeat = new ScottPlot.WinForms.FormsPlot();
            tabAcf = new TabPage();
            formsPlotAcf = new ScottPlot.WinForms.FormsPlot();
            tabAmdf = new TabPage();
            formsPlotAmdf = new ScottPlot.WinForms.FormsPlot();
            tabFft = new TabPage();
            formsPlotFft = new ScottPlot.WinForms.FormsPlot();
            tabWindowTime = new TabPage();
            formsPlotWindowTime = new ScottPlot.WinForms.FormsPlot();
            tabCepstrum = new TabPage();
            formsPlotCepstrum = new ScottPlot.WinForms.FormsPlot();
            tabSpectogram = new TabPage();
            formsPlotSpectrogram = new ScottPlot.WinForms.FormsPlot();
            bottomPanel = new Panel();
            lblFramePos = new Label();
            lblFrameDetails = new Label();
            trackFrame = new TrackBar();
            cmbWindowType = new ComboBox();
            label1 = new Label();
            nudFrameMs = new NumericUpDown();
            label2 = new Label();
            nudOverlapPercent = new NumericUpDown();
            label3 = new Label();
            chkUseWholeSignalFft = new CheckBox();
            btnComputeSpectrogram = new Button();
            label4 = new Label();
            labell = new Label();
            labelll = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            lblSpectralVolumeVal = new Label();
            lblCentroidVal = new Label();
            lblBandwidthVal = new Label();
            lblFlatnessVal = new Label();
            lblCrestVal = new Label();
            lblBand1Val = new Label();
            lblBand2Val = new Label();
            lblBand3Val = new Label();
            lblBand4Val = new Label();
            lblCepstrumF0Val = new Label();
            menuStrip1.SuspendLayout();
            pnlTop.SuspendLayout();
            grpInfo.SuspendLayout();
            tblInfo.SuspendLayout();
            optionsPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            tabWave.SuspendLayout();
            tabFeat.SuspendLayout();
            tabAcf.SuspendLayout();
            tabAmdf.SuspendLayout();
            tabFft.SuspendLayout();
            tabWindowTime.SuspendLayout();
            tabCepstrum.SuspendLayout();
            tabSpectogram.SuspendLayout();
            bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackFrame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFrameMs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudOverlapPercent).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1254, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openWAVToolStripMenuItem, exportCSVToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openWAVToolStripMenuItem
            // 
            openWAVToolStripMenuItem.Name = "openWAVToolStripMenuItem";
            openWAVToolStripMenuItem.Size = new Size(165, 26);
            openWAVToolStripMenuItem.Text = "Open WAV";
            openWAVToolStripMenuItem.Click += openWAVToolStripMenuItem_Click;
            // 
            // exportCSVToolStripMenuItem
            // 
            exportCSVToolStripMenuItem.Name = "exportCSVToolStripMenuItem";
            exportCSVToolStripMenuItem.Size = new Size(165, 26);
            exportCSVToolStripMenuItem.Text = "Export CSV";
            exportCSVToolStripMenuItem.Click += exportCSVToolStripMenuItem_Click;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(grpInfo);
            pnlTop.Location = new Point(12, 31);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(285, 139);
            pnlTop.TabIndex = 4;
            // 
            // grpInfo
            // 
            grpInfo.Controls.Add(tblInfo);
            grpInfo.Dock = DockStyle.Fill;
            grpInfo.Location = new Point(0, 0);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(285, 139);
            grpInfo.TabIndex = 5;
            grpInfo.TabStop = false;
            grpInfo.Text = "Audio file information";
            // 
            // tblInfo
            // 
            tblInfo.ColumnCount = 2;
            tblInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblInfo.Controls.Add(lblLenVal, 1, 4);
            tblInfo.Controls.Add(labelLenTitle, 0, 4);
            tblInfo.Controls.Add(lblBitsVal, 1, 3);
            tblInfo.Controls.Add(labelBitsTitle, 0, 3);
            tblInfo.Controls.Add(lblChVal, 1, 2);
            tblInfo.Controls.Add(lblFsVal, 1, 1);
            tblInfo.Controls.Add(lblFileVal, 1, 0);
            tblInfo.Controls.Add(labelFileTitle, 0, 0);
            tblInfo.Controls.Add(labelFsTitle, 0, 1);
            tblInfo.Controls.Add(labelChTitle, 0, 2);
            tblInfo.Dock = DockStyle.Fill;
            tblInfo.Location = new Point(3, 23);
            tblInfo.Name = "tblInfo";
            tblInfo.RowCount = 5;
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 47.727272F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 52.272728F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tblInfo.Size = new Size(279, 113);
            tblInfo.TabIndex = 0;
            // 
            // lblLenVal
            // 
            lblLenVal.AutoSize = true;
            lblLenVal.Location = new Point(142, 90);
            lblLenVal.Name = "lblLenVal";
            lblLenVal.Size = new Size(0, 20);
            lblLenVal.TabIndex = 9;
            // 
            // labelLenTitle
            // 
            labelLenTitle.AutoSize = true;
            labelLenTitle.Location = new Point(3, 90);
            labelLenTitle.Name = "labelLenTitle";
            labelLenTitle.Size = new Size(70, 20);
            labelLenTitle.TabIndex = 8;
            labelLenTitle.Text = "Duration:";
            // 
            // lblBitsVal
            // 
            lblBitsVal.AutoSize = true;
            lblBitsVal.Location = new Point(142, 67);
            lblBitsVal.Name = "lblBitsVal";
            lblBitsVal.Size = new Size(0, 20);
            lblBitsVal.TabIndex = 7;
            // 
            // labelBitsTitle
            // 
            labelBitsTitle.AutoSize = true;
            labelBitsTitle.Location = new Point(3, 67);
            labelBitsTitle.Name = "labelBitsTitle";
            labelBitsTitle.Size = new Size(73, 20);
            labelBitsTitle.TabIndex = 6;
            labelBitsTitle.Text = "Bit depth:";
            // 
            // lblChVal
            // 
            lblChVal.AutoSize = true;
            lblChVal.Location = new Point(142, 44);
            lblChVal.Name = "lblChVal";
            lblChVal.Size = new Size(0, 20);
            lblChVal.TabIndex = 5;
            // 
            // lblFsVal
            // 
            lblFsVal.AutoSize = true;
            lblFsVal.Location = new Point(142, 21);
            lblFsVal.Name = "lblFsVal";
            lblFsVal.Size = new Size(0, 20);
            lblFsVal.TabIndex = 4;
            // 
            // lblFileVal
            // 
            lblFileVal.AutoSize = true;
            lblFileVal.Location = new Point(142, 0);
            lblFileVal.Name = "lblFileVal";
            lblFileVal.Size = new Size(0, 20);
            lblFileVal.TabIndex = 3;
            // 
            // labelFileTitle
            // 
            labelFileTitle.AutoSize = true;
            labelFileTitle.Location = new Point(3, 0);
            labelFileTitle.Name = "labelFileTitle";
            labelFileTitle.Size = new Size(35, 20);
            labelFileTitle.TabIndex = 0;
            labelFileTitle.Text = "File:";
            // 
            // labelFsTitle
            // 
            labelFsTitle.AutoSize = true;
            labelFsTitle.Location = new Point(3, 21);
            labelFsTitle.Name = "labelFsTitle";
            labelFsTitle.Size = new Size(92, 20);
            labelFsTitle.TabIndex = 1;
            labelFsTitle.Text = "Sample rate:";
            // 
            // labelChTitle
            // 
            labelChTitle.AutoSize = true;
            labelChTitle.Location = new Point(3, 44);
            labelChTitle.Name = "labelChTitle";
            labelChTitle.Size = new Size(71, 20);
            labelChTitle.TabIndex = 2;
            labelChTitle.Text = "Channels:";
            // 
            // optionsPanel
            // 
            optionsPanel.Controls.Add(chkSilence);
            optionsPanel.Controls.Add(chkNormalizeVolume);
            optionsPanel.Controls.Add(lblFeature);
            optionsPanel.Controls.Add(cmbFeature);
            optionsPanel.Controls.Add(lblGender);
            optionsPanel.Location = new Point(312, 45);
            optionsPanel.Name = "optionsPanel";
            optionsPanel.Size = new Size(322, 125);
            optionsPanel.TabIndex = 5;
            // 
            // chkSilence
            // 
            chkSilence.AutoSize = true;
            chkSilence.Location = new Point(3, 3);
            chkSilence.Name = "chkSilence";
            chkSilence.Size = new Size(116, 24);
            chkSilence.TabIndex = 7;
            chkSilence.Text = "Show silence";
            chkSilence.UseVisualStyleBackColor = true;
            chkSilence.CheckedChanged += chkSilence_CheckedChanged;
            // 
            // chkNormalizeVolume
            // 
            chkNormalizeVolume.AutoSize = true;
            chkNormalizeVolume.Location = new Point(125, 3);
            chkNormalizeVolume.Name = "chkNormalizeVolume";
            chkNormalizeVolume.Size = new Size(153, 24);
            chkNormalizeVolume.TabIndex = 6;
            chkNormalizeVolume.Text = "Normalize volume";
            chkNormalizeVolume.UseVisualStyleBackColor = true;
            chkNormalizeVolume.CheckedChanged += chkNormalizeVolume_CheckedChanged;
            // 
            // lblFeature
            // 
            lblFeature.AutoSize = true;
            lblFeature.Location = new Point(3, 30);
            lblFeature.Name = "lblFeature";
            lblFeature.Size = new Size(61, 20);
            lblFeature.TabIndex = 10;
            lblFeature.Text = "Feature:";
            // 
            // cmbFeature
            // 
            cmbFeature.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFeature.FormattingEnabled = true;
            cmbFeature.Items.AddRange(new object[] { "Volume RMS", "STE", "ZCR" });
            cmbFeature.Location = new Point(70, 33);
            cmbFeature.Name = "cmbFeature";
            cmbFeature.Size = new Size(151, 28);
            cmbFeature.TabIndex = 6;
            cmbFeature.SelectedIndexChanged += cmbFeature_SelectedIndexChanged;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(227, 30);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(0, 23);
            lblGender.TabIndex = 11;
            lblGender.UseCompatibleTextRendering = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabWave);
            tabControl1.Controls.Add(tabFeat);
            tabControl1.Controls.Add(tabAcf);
            tabControl1.Controls.Add(tabAmdf);
            tabControl1.Controls.Add(tabFft);
            tabControl1.Controls.Add(tabWindowTime);
            tabControl1.Controls.Add(tabCepstrum);
            tabControl1.Controls.Add(tabSpectogram);
            tabControl1.Location = new Point(12, 210);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(920, 300);
            tabControl1.TabIndex = 6;
            // 
            // tabWave
            // 
            tabWave.Controls.Add(formsPlotWave);
            tabWave.Location = new Point(4, 29);
            tabWave.Name = "tabWave";
            tabWave.Padding = new Padding(3);
            tabWave.Size = new Size(912, 267);
            tabWave.TabIndex = 0;
            tabWave.Text = "Waveform";
            tabWave.UseVisualStyleBackColor = true;
            // 
            // formsPlotWave
            // 
            formsPlotWave.Dock = DockStyle.Fill;
            formsPlotWave.Location = new Point(3, 3);
            formsPlotWave.Name = "formsPlotWave";
            formsPlotWave.Size = new Size(906, 261);
            formsPlotWave.TabIndex = 0;
            // 
            // tabFeat
            // 
            tabFeat.Controls.Add(formsPlotFeat);
            tabFeat.Location = new Point(4, 29);
            tabFeat.Name = "tabFeat";
            tabFeat.Padding = new Padding(3);
            tabFeat.Size = new Size(912, 267);
            tabFeat.TabIndex = 1;
            tabFeat.Text = "Frame features";
            tabFeat.UseVisualStyleBackColor = true;
            // 
            // formsPlotFeat
            // 
            formsPlotFeat.Dock = DockStyle.Fill;
            formsPlotFeat.Location = new Point(3, 3);
            formsPlotFeat.Name = "formsPlotFeat";
            formsPlotFeat.Size = new Size(906, 261);
            formsPlotFeat.TabIndex = 0;
            // 
            // tabAcf
            // 
            tabAcf.Controls.Add(formsPlotAcf);
            tabAcf.Location = new Point(4, 29);
            tabAcf.Name = "tabAcf";
            tabAcf.Padding = new Padding(3);
            tabAcf.Size = new Size(912, 267);
            tabAcf.TabIndex = 2;
            tabAcf.Text = "Pitch ACF";
            tabAcf.UseVisualStyleBackColor = true;
            // 
            // formsPlotAcf
            // 
            formsPlotAcf.Dock = DockStyle.Fill;
            formsPlotAcf.Location = new Point(3, 3);
            formsPlotAcf.Name = "formsPlotAcf";
            formsPlotAcf.Size = new Size(906, 261);
            formsPlotAcf.TabIndex = 0;
            // 
            // tabAmdf
            // 
            tabAmdf.Controls.Add(formsPlotAmdf);
            tabAmdf.Location = new Point(4, 29);
            tabAmdf.Name = "tabAmdf";
            tabAmdf.Padding = new Padding(3);
            tabAmdf.Size = new Size(912, 267);
            tabAmdf.TabIndex = 3;
            tabAmdf.Text = "Pitch AMDF";
            tabAmdf.UseVisualStyleBackColor = true;
            // 
            // formsPlotAmdf
            // 
            formsPlotAmdf.Dock = DockStyle.Fill;
            formsPlotAmdf.Location = new Point(3, 3);
            formsPlotAmdf.Name = "formsPlotAmdf";
            formsPlotAmdf.Size = new Size(906, 261);
            formsPlotAmdf.TabIndex = 0;
            // 
            // tabFft
            // 
            tabFft.Controls.Add(formsPlotFft);
            tabFft.Location = new Point(4, 29);
            tabFft.Name = "tabFft";
            tabFft.Size = new Size(912, 267);
            tabFft.TabIndex = 4;
            tabFft.Text = "Plot FFT";
            tabFft.UseVisualStyleBackColor = true;
            // 
            // formsPlotFft
            // 
            formsPlotFft.Dock = DockStyle.Fill;
            formsPlotFft.Location = new Point(0, 0);
            formsPlotFft.Name = "formsPlotFft";
            formsPlotFft.Size = new Size(912, 267);
            formsPlotFft.TabIndex = 1;
            // 
            // tabWindowTime
            // 
            tabWindowTime.Controls.Add(formsPlotWindowTime);
            tabWindowTime.Location = new Point(4, 29);
            tabWindowTime.Name = "tabWindowTime";
            tabWindowTime.Size = new Size(912, 267);
            tabWindowTime.TabIndex = 5;
            tabWindowTime.Text = "Plot Window Time";
            tabWindowTime.UseVisualStyleBackColor = true;
            // 
            // formsPlotWindowTime
            // 
            formsPlotWindowTime.Dock = DockStyle.Fill;
            formsPlotWindowTime.Location = new Point(0, 0);
            formsPlotWindowTime.Name = "formsPlotWindowTime";
            formsPlotWindowTime.Size = new Size(912, 267);
            formsPlotWindowTime.TabIndex = 2;
            // 
            // tabCepstrum
            // 
            tabCepstrum.Controls.Add(formsPlotCepstrum);
            tabCepstrum.Location = new Point(4, 29);
            tabCepstrum.Name = "tabCepstrum";
            tabCepstrum.Size = new Size(912, 267);
            tabCepstrum.TabIndex = 6;
            tabCepstrum.Text = "Plot Cepstrum";
            tabCepstrum.UseVisualStyleBackColor = true;
            // 
            // formsPlotCepstrum
            // 
            formsPlotCepstrum.Dock = DockStyle.Fill;
            formsPlotCepstrum.Location = new Point(0, 0);
            formsPlotCepstrum.Name = "formsPlotCepstrum";
            formsPlotCepstrum.Size = new Size(912, 267);
            formsPlotCepstrum.TabIndex = 3;
            // 
            // tabSpectogram
            // 
            tabSpectogram.Controls.Add(formsPlotSpectrogram);
            tabSpectogram.Location = new Point(4, 29);
            tabSpectogram.Name = "tabSpectogram";
            tabSpectogram.Size = new Size(912, 267);
            tabSpectogram.TabIndex = 7;
            tabSpectogram.Text = "Plot Spectogram";
            tabSpectogram.UseVisualStyleBackColor = true;
            // 
            // formsPlotSpectrogram
            // 
            formsPlotSpectrogram.Dock = DockStyle.Fill;
            formsPlotSpectrogram.Location = new Point(0, 0);
            formsPlotSpectrogram.Name = "formsPlotSpectrogram";
            formsPlotSpectrogram.Size = new Size(912, 267);
            formsPlotSpectrogram.TabIndex = 1;
            // 
            // bottomPanel
            // 
            bottomPanel.Controls.Add(lblFramePos);
            bottomPanel.Controls.Add(lblFrameDetails);
            bottomPanel.Controls.Add(trackFrame);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 541);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(1254, 84);
            bottomPanel.TabIndex = 7;
            // 
            // lblFramePos
            // 
            lblFramePos.AutoSize = true;
            lblFramePos.Location = new Point(0, 36);
            lblFramePos.Name = "lblFramePos";
            lblFramePos.Size = new Size(164, 20);
            lblFramePos.TabIndex = 2;
            lblFramePos.Text = "Frame: 0 / Time: 0.000 s";
            // 
            // lblFrameDetails
            // 
            lblFrameDetails.Dock = DockStyle.Bottom;
            lblFrameDetails.Location = new Point(0, 59);
            lblFrameDetails.Name = "lblFrameDetails";
            lblFrameDetails.Size = new Size(1254, 25);
            lblFrameDetails.TabIndex = 1;
            lblFrameDetails.Text = "No frame selected";
            // 
            // trackFrame
            // 
            trackFrame.Dock = DockStyle.Top;
            trackFrame.Location = new Point(0, 0);
            trackFrame.Name = "trackFrame";
            trackFrame.Size = new Size(1254, 56);
            trackFrame.TabIndex = 0;
            trackFrame.Scroll += trackFrame_Scroll;
            // 
            // cmbWindowType
            // 
            cmbWindowType.FormattingEnabled = true;
            cmbWindowType.Items.AddRange(new object[] { "Rectangular", "Triangular", "Hamming", "Hann", "Blackman" });
            cmbWindowType.Location = new Point(758, 44);
            cmbWindowType.Name = "cmbWindowType";
            cmbWindowType.Size = new Size(186, 28);
            cmbWindowType.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(643, 49);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 9;
            label1.Text = "WindowType";
            // 
            // nudFrameMs
            // 
            nudFrameMs.Location = new Point(758, 78);
            nudFrameMs.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nudFrameMs.Name = "nudFrameMs";
            nudFrameMs.Size = new Size(186, 27);
            nudFrameMs.TabIndex = 10;
            nudFrameMs.Value = new decimal(new int[] { 20, 0, 0, 0 });
            nudFrameMs.ValueChanged += nudFrameMs_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(643, 81);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 11;
            label2.Text = "FrameMs";
            // 
            // nudOverlapPercent
            // 
            nudOverlapPercent.Location = new Point(758, 114);
            nudOverlapPercent.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            nudOverlapPercent.Name = "nudOverlapPercent";
            nudOverlapPercent.Size = new Size(186, 27);
            nudOverlapPercent.TabIndex = 12;
            nudOverlapPercent.Value = new decimal(new int[] { 50, 0, 0, 0 });
            nudOverlapPercent.ValueChanged += nudOverlapPercent_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(643, 116);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 13;
            label3.Text = "OverlapPercent";
            // 
            // chkUseWholeSignalFft
            // 
            chkUseWholeSignalFft.AutoSize = true;
            chkUseWholeSignalFft.Location = new Point(643, 166);
            chkUseWholeSignalFft.Name = "chkUseWholeSignalFft";
            chkUseWholeSignalFft.Size = new Size(168, 24);
            chkUseWholeSignalFft.TabIndex = 14;
            chkUseWholeSignalFft.Text = "Use Whole Signal Fft";
            chkUseWholeSignalFft.UseVisualStyleBackColor = true;
            chkUseWholeSignalFft.CheckedChanged += chkUseWholeSignalFft_CheckedChanged;
            // 
            // btnComputeSpectrogram
            // 
            btnComputeSpectrogram.Location = new Point(827, 151);
            btnComputeSpectrogram.Name = "btnComputeSpectrogram";
            btnComputeSpectrogram.Size = new Size(117, 53);
            btnComputeSpectrogram.TabIndex = 15;
            btnComputeSpectrogram.Text = "Compute Spectrogram";
            btnComputeSpectrogram.UseVisualStyleBackColor = true;
            btnComputeSpectrogram.Click += btnComputeSpectrogram_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(968, 47);
            label4.Name = "label4";
            label4.Size = new Size(158, 28);
            label4.TabIndex = 16;
            label4.Text = "Cechy Widmowe";
            // 
            // labell
            // 
            labell.AutoSize = true;
            labell.Location = new Point(968, 86);
            labell.Name = "labell";
            labell.Size = new Size(133, 20);
            labell.TabIndex = 17;
            labell.Text = "SpectralVolumeVal";
            // 
            // labelll
            // 
            labelll.AutoSize = true;
            labelll.Location = new Point(968, 116);
            labelll.Name = "labelll";
            labelll.Size = new Size(86, 20);
            labelll.TabIndex = 18;
            labelll.Text = "CentroidVal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(968, 147);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 19;
            label5.Text = "BandwidthVal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(968, 184);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 20;
            label6.Text = "FlatnessVal";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(968, 210);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 21;
            label7.Text = "CrestVal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(968, 242);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 22;
            label8.Text = "Band1Val";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(968, 271);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 23;
            label9.Text = "Band2Val";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(968, 302);
            label10.Name = "label10";
            label10.Size = new Size(71, 20);
            label10.TabIndex = 24;
            label10.Text = "Band3Val";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(968, 332);
            label11.Name = "label11";
            label11.Size = new Size(71, 20);
            label11.TabIndex = 25;
            label11.Text = "Band4Val";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(968, 364);
            label12.Name = "label12";
            label12.Size = new Size(107, 20);
            label12.TabIndex = 26;
            label12.Text = "CepstrumF0Val";
            // 
            // lblSpectralVolumeVal
            // 
            lblSpectralVolumeVal.AutoSize = true;
            lblSpectralVolumeVal.Location = new Point(1107, 86);
            lblSpectralVolumeVal.Name = "lblSpectralVolumeVal";
            lblSpectralVolumeVal.Size = new Size(0, 20);
            lblSpectralVolumeVal.TabIndex = 27;
            // 
            // lblCentroidVal
            // 
            lblCentroidVal.AutoSize = true;
            lblCentroidVal.Location = new Point(1121, 121);
            lblCentroidVal.Name = "lblCentroidVal";
            lblCentroidVal.Size = new Size(0, 20);
            lblCentroidVal.TabIndex = 28;
            // 
            // lblBandwidthVal
            // 
            lblBandwidthVal.AutoSize = true;
            lblBandwidthVal.Location = new Point(1121, 147);
            lblBandwidthVal.Name = "lblBandwidthVal";
            lblBandwidthVal.Size = new Size(0, 20);
            lblBandwidthVal.TabIndex = 29;
            // 
            // lblFlatnessVal
            // 
            lblFlatnessVal.AutoSize = true;
            lblFlatnessVal.Location = new Point(1121, 184);
            lblFlatnessVal.Name = "lblFlatnessVal";
            lblFlatnessVal.Size = new Size(0, 20);
            lblFlatnessVal.TabIndex = 30;
            // 
            // lblCrestVal
            // 
            lblCrestVal.AutoSize = true;
            lblCrestVal.Location = new Point(1121, 210);
            lblCrestVal.Name = "lblCrestVal";
            lblCrestVal.Size = new Size(0, 20);
            lblCrestVal.TabIndex = 31;
            // 
            // lblBand1Val
            // 
            lblBand1Val.AutoSize = true;
            lblBand1Val.Location = new Point(1121, 242);
            lblBand1Val.Name = "lblBand1Val";
            lblBand1Val.Size = new Size(0, 20);
            lblBand1Val.TabIndex = 32;
            // 
            // lblBand2Val
            // 
            lblBand2Val.AutoSize = true;
            lblBand2Val.Location = new Point(1121, 271);
            lblBand2Val.Name = "lblBand2Val";
            lblBand2Val.Size = new Size(0, 20);
            lblBand2Val.TabIndex = 33;
            // 
            // lblBand3Val
            // 
            lblBand3Val.AutoSize = true;
            lblBand3Val.Location = new Point(1121, 302);
            lblBand3Val.Name = "lblBand3Val";
            lblBand3Val.Size = new Size(0, 20);
            lblBand3Val.TabIndex = 34;
            // 
            // lblBand4Val
            // 
            lblBand4Val.AutoSize = true;
            lblBand4Val.Location = new Point(1121, 332);
            lblBand4Val.Name = "lblBand4Val";
            lblBand4Val.Size = new Size(0, 20);
            lblBand4Val.TabIndex = 35;
            // 
            // lblCepstrumF0Val
            // 
            lblCepstrumF0Val.AutoSize = true;
            lblCepstrumF0Val.Location = new Point(1121, 364);
            lblCepstrumF0Val.Name = "lblCepstrumF0Val";
            lblCepstrumF0Val.Size = new Size(0, 20);
            lblCepstrumF0Val.TabIndex = 36;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 625);
            Controls.Add(lblCepstrumF0Val);
            Controls.Add(lblBand4Val);
            Controls.Add(lblBand3Val);
            Controls.Add(lblBand2Val);
            Controls.Add(lblBand1Val);
            Controls.Add(lblCrestVal);
            Controls.Add(lblFlatnessVal);
            Controls.Add(lblBandwidthVal);
            Controls.Add(lblCentroidVal);
            Controls.Add(lblSpectralVolumeVal);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(labelll);
            Controls.Add(labell);
            Controls.Add(label4);
            Controls.Add(btnComputeSpectrogram);
            Controls.Add(chkUseWholeSignalFft);
            Controls.Add(label3);
            Controls.Add(nudOverlapPercent);
            Controls.Add(label2);
            Controls.Add(nudFrameMs);
            Controls.Add(label1);
            Controls.Add(bottomPanel);
            Controls.Add(tabControl1);
            Controls.Add(optionsPanel);
            Controls.Add(pnlTop);
            Controls.Add(menuStrip1);
            Controls.Add(cmbWindowType);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Cechy Sygnału Audio w Czasie";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlTop.ResumeLayout(false);
            grpInfo.ResumeLayout(false);
            tblInfo.ResumeLayout(false);
            tblInfo.PerformLayout();
            optionsPanel.ResumeLayout(false);
            optionsPanel.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabWave.ResumeLayout(false);
            tabFeat.ResumeLayout(false);
            tabAcf.ResumeLayout(false);
            tabAmdf.ResumeLayout(false);
            tabFft.ResumeLayout(false);
            tabWindowTime.ResumeLayout(false);
            tabCepstrum.ResumeLayout(false);
            tabSpectogram.ResumeLayout(false);
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackFrame).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFrameMs).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudOverlapPercent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openWAVToolStripMenuItem;
        private ToolStripMenuItem exportCSVToolStripMenuItem;
        private Panel pnlTop;
        private GroupBox grpInfo;
        private TableLayoutPanel tblInfo;
        private Label labelFileTitle;
        private Label lblFileVal;
        private Label labelFsTitle;
        private Label labelChTitle;
        private Label labelLenTitle;
        private Label lblBitsVal;
        private Label labelBitsTitle;
        private Label lblChVal;
        private Label lblFsVal;
        private Label lblLenVal;
        private Label lblFeature;
        private FlowLayoutPanel optionsPanel;
        private CheckBox chkNormalizeVolume;
        private CheckBox chkSilence;
        private ComboBox cmbFeature;
        private TabControl tabControl1;
        private TabPage tabWave;
        private TabPage tabFeat;
        private TabPage tabAcf;
        private TabPage tabAmdf;
        private ScottPlot.WinForms.FormsPlot formsPlotWave;
        private ScottPlot.WinForms.FormsPlot formsPlotFeat;
        private ScottPlot.WinForms.FormsPlot formsPlotAcf;
        private ScottPlot.WinForms.FormsPlot formsPlotAmdf;
        private Panel bottomPanel;
        private Label lblFramePos;
        private Label lblFrameDetails;
        private TrackBar trackFrame;
        private Label lblGender;
        private ComboBox cmbWindowType;
        private Label label1;
        private NumericUpDown nudFrameMs;
        private Label label2;
        private NumericUpDown nudOverlapPercent;
        private Label label3;
        private CheckBox chkUseWholeSignalFft;
        private Button btnComputeSpectrogram;
        private TabPage tabFft;
        private ScottPlot.WinForms.FormsPlot formsPlotFft;
        private TabPage tabWindowTime;
        private ScottPlot.WinForms.FormsPlot formsPlotWindowTime;
        private TabPage tabCepstrum;
        private ScottPlot.WinForms.FormsPlot formsPlotCepstrum;
        private Label label4;
        private Label labell;
        private Label labelll;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label lblSpectralVolumeVal;
        private Label lblCentroidVal;
        private Label lblBandwidthVal;
        private Label lblFlatnessVal;
        private Label lblCrestVal;
        private Label lblBand1Val;
        private Label lblBand2Val;
        private Label lblBand3Val;
        private Label lblBand4Val;
        private Label lblCepstrumF0Val;
        private TabPage tabSpectogram;
        private ScottPlot.WinForms.FormsPlot formsPlotSpectrogram;
    }
}
