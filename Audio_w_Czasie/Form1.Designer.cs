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
            tabFft = new TabPage();
            tabWindowTime = new TabPage();
            tabCepstrum = new TabPage();
            formsPlotFft = new ScottPlot.WinForms.FormsPlot();
            formsPlotWindowTime = new ScottPlot.WinForms.FormsPlot();
            formsPlotCepstrum = new ScottPlot.WinForms.FormsPlot();
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
            bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackFrame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFrameMs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudOverlapPercent).BeginInit();
            tabFft.SuspendLayout();
            tabWindowTime.SuspendLayout();
            tabCepstrum.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(944, 28);
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
            tabControl1.Location = new Point(12, 210);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(900, 300);
            tabControl1.TabIndex = 6;
            // 
            // tabWave
            // 
            tabWave.Controls.Add(formsPlotWave);
            tabWave.Location = new Point(4, 29);
            tabWave.Name = "tabWave";
            tabWave.Padding = new Padding(3);
            tabWave.Size = new Size(892, 267);
            tabWave.TabIndex = 0;
            tabWave.Text = "Waveform";
            tabWave.UseVisualStyleBackColor = true;
            // 
            // formsPlotWave
            // 
            formsPlotWave.Dock = DockStyle.Fill;
            formsPlotWave.Location = new Point(3, 3);
            formsPlotWave.Name = "formsPlotWave";
            formsPlotWave.Size = new Size(886, 261);
            formsPlotWave.TabIndex = 0;
            // 
            // tabFeat
            // 
            tabFeat.Controls.Add(formsPlotFeat);
            tabFeat.Location = new Point(4, 29);
            tabFeat.Name = "tabFeat";
            tabFeat.Padding = new Padding(3);
            tabFeat.Size = new Size(892, 267);
            tabFeat.TabIndex = 1;
            tabFeat.Text = "Frame features";
            tabFeat.UseVisualStyleBackColor = true;
            // 
            // formsPlotFeat
            // 
            formsPlotFeat.Dock = DockStyle.Fill;
            formsPlotFeat.Location = new Point(3, 3);
            formsPlotFeat.Name = "formsPlotFeat";
            formsPlotFeat.Size = new Size(886, 261);
            formsPlotFeat.TabIndex = 0;
            // 
            // tabAcf
            // 
            tabAcf.Controls.Add(formsPlotAcf);
            tabAcf.Location = new Point(4, 29);
            tabAcf.Name = "tabAcf";
            tabAcf.Padding = new Padding(3);
            tabAcf.Size = new Size(892, 267);
            tabAcf.TabIndex = 2;
            tabAcf.Text = "Pitch ACF";
            tabAcf.UseVisualStyleBackColor = true;
            // 
            // formsPlotAcf
            // 
            formsPlotAcf.Dock = DockStyle.Fill;
            formsPlotAcf.Location = new Point(3, 3);
            formsPlotAcf.Name = "formsPlotAcf";
            formsPlotAcf.Size = new Size(886, 261);
            formsPlotAcf.TabIndex = 0;
            // 
            // tabAmdf
            // 
            tabAmdf.Controls.Add(formsPlotAmdf);
            tabAmdf.Location = new Point(4, 29);
            tabAmdf.Name = "tabAmdf";
            tabAmdf.Padding = new Padding(3);
            tabAmdf.Size = new Size(892, 267);
            tabAmdf.TabIndex = 3;
            tabAmdf.Text = "Pitch AMDF";
            tabAmdf.UseVisualStyleBackColor = true;
            // 
            // formsPlotAmdf
            // 
            formsPlotAmdf.Dock = DockStyle.Fill;
            formsPlotAmdf.Location = new Point(3, 3);
            formsPlotAmdf.Name = "formsPlotAmdf";
            formsPlotAmdf.Size = new Size(886, 261);
            formsPlotAmdf.TabIndex = 0;
            // 
            // bottomPanel
            // 
            bottomPanel.Controls.Add(lblFramePos);
            bottomPanel.Controls.Add(lblFrameDetails);
            bottomPanel.Controls.Add(trackFrame);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 541);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(944, 84);
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
            lblFrameDetails.Size = new Size(944, 25);
            lblFrameDetails.TabIndex = 1;
            lblFrameDetails.Text = "No frame selected";
            // 
            // trackFrame
            // 
            trackFrame.Dock = DockStyle.Top;
            trackFrame.Location = new Point(0, 0);
            trackFrame.Name = "trackFrame";
            trackFrame.Size = new Size(944, 56);
            trackFrame.TabIndex = 0;
            trackFrame.Scroll += trackFrame_Scroll;
            // 
            // cmbWindowType
            // 
            cmbWindowType.FormattingEnabled = true;
            cmbWindowType.Items.AddRange(new object[] { "Rectangular", "Triangular", "Hamming", "Hann", "Blackman" });
            cmbWindowType.Location = new Point(758, 44);
            cmbWindowType.Name = "cmbWindowType";
            cmbWindowType.Size = new Size(151, 28);
            cmbWindowType.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(653, 49);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 9;
            label1.Text = "Window Type";
            // 
            // nudFrameMs
            // 
            nudFrameMs.Location = new Point(758, 78);
            nudFrameMs.Name = "nudFrameMs";
            nudFrameMs.Size = new Size(150, 27);
            nudFrameMs.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(653, 81);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 11;
            label2.Text = "Window Type";
            // 
            // nudOverlapPercent
            // 
            nudOverlapPercent.Location = new Point(758, 114);
            nudOverlapPercent.Name = "nudOverlapPercent";
            nudOverlapPercent.Size = new Size(150, 27);
            nudOverlapPercent.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(653, 116);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 13;
            label3.Text = "Window Type";
            // 
            // chkUseWholeSignalFft
            // 
            chkUseWholeSignalFft.AutoSize = true;
            chkUseWholeSignalFft.Location = new Point(640, 166);
            chkUseWholeSignalFft.Name = "chkUseWholeSignalFft";
            chkUseWholeSignalFft.Size = new Size(168, 24);
            chkUseWholeSignalFft.TabIndex = 14;
            chkUseWholeSignalFft.Text = "Use Whole Signal Fft";
            chkUseWholeSignalFft.UseVisualStyleBackColor = true;
            // 
            // btnComputeSpectrogram
            // 
            btnComputeSpectrogram.Location = new Point(815, 151);
            btnComputeSpectrogram.Name = "btnComputeSpectrogram";
            btnComputeSpectrogram.Size = new Size(117, 53);
            btnComputeSpectrogram.TabIndex = 15;
            btnComputeSpectrogram.Text = "Compute Spectrogram";
            btnComputeSpectrogram.UseVisualStyleBackColor = true;
            // 
            // tabFft
            // 
            tabFft.Controls.Add(formsPlotFft);
            tabFft.Location = new Point(4, 29);
            tabFft.Name = "tabFft";
            tabFft.Size = new Size(892, 267);
            tabFft.TabIndex = 4;
            tabFft.Text = "Plot FFT";
            tabFft.UseVisualStyleBackColor = true;
            // 
            // tabWindowTime
            // 
            tabWindowTime.Controls.Add(formsPlotWindowTime);
            tabWindowTime.Location = new Point(4, 29);
            tabWindowTime.Name = "tabWindowTime";
            tabWindowTime.Size = new Size(892, 267);
            tabWindowTime.TabIndex = 5;
            tabWindowTime.Text = "Plot Window Time";
            tabWindowTime.UseVisualStyleBackColor = true;
            // 
            // tabCepstrum
            // 
            tabCepstrum.Controls.Add(formsPlotCepstrum);
            tabCepstrum.Location = new Point(4, 29);
            tabCepstrum.Name = "tabCepstrum";
            tabCepstrum.Size = new Size(892, 267);
            tabCepstrum.TabIndex = 6;
            tabCepstrum.Text = "Plot Cepstrum";
            tabCepstrum.UseVisualStyleBackColor = true;
            // 
            // formsPlotFft
            // 
            formsPlotFft.Dock = DockStyle.Fill;
            formsPlotFft.Location = new Point(0, 0);
            formsPlotFft.Name = "formsPlotFft";
            formsPlotFft.Size = new Size(892, 267);
            formsPlotFft.TabIndex = 1;
            // 
            // formsPlotWindowTime
            // 
            formsPlotWindowTime.Dock = DockStyle.Fill;
            formsPlotWindowTime.Location = new Point(0, 0);
            formsPlotWindowTime.Name = "formsPlotWindowTime";
            formsPlotWindowTime.Size = new Size(892, 267);
            formsPlotWindowTime.TabIndex = 2;
            // 
            // formsPlotCepstrum
            // 
            formsPlotCepstrum.Dock = DockStyle.Fill;
            formsPlotCepstrum.Location = new Point(0, 0);
            formsPlotCepstrum.Name = "formsPlotCepstrum";
            formsPlotCepstrum.Size = new Size(892, 267);
            formsPlotCepstrum.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 625);
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
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackFrame).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFrameMs).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudOverlapPercent).EndInit();
            tabFft.ResumeLayout(false);
            tabWindowTime.ResumeLayout(false);
            tabCepstrum.ResumeLayout(false);
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
    }
}
