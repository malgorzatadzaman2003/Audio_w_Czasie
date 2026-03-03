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
            btnLoad = new Button();
            lblInfo = new Label();
            formsPlotWave = new ScottPlot.WinForms.FormsPlot();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openWAVToolStripMenuItem = new ToolStripMenuItem();
            exportCSVToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            formsPlotFeat = new ScottPlot.WinForms.FormsPlot();
            chkNormalizeVolume = new CheckBox();
            chkSilence = new CheckBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(622, 118);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Load File";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(622, 175);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(50, 20);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "label1";
            // 
            // formsPlotWave
            // 
            formsPlotWave.DisplayScale = 1.25F;
            formsPlotWave.Location = new Point(0, 52);
            formsPlotWave.Name = "formsPlotWave";
            formsPlotWave.Size = new Size(575, 188);
            formsPlotWave.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openWAVToolStripMenuItem, exportCSVToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openWAVToolStripMenuItem
            // 
            openWAVToolStripMenuItem.Name = "openWAVToolStripMenuItem";
            openWAVToolStripMenuItem.Size = new Size(224, 26);
            openWAVToolStripMenuItem.Text = "Open WAV";
            openWAVToolStripMenuItem.Click += openWAVToolStripMenuItem_Click;
            // 
            // exportCSVToolStripMenuItem
            // 
            exportCSVToolStripMenuItem.Name = "exportCSVToolStripMenuItem";
            exportCSVToolStripMenuItem.Size = new Size(224, 26);
            exportCSVToolStripMenuItem.Text = "Export CSV";
            exportCSVToolStripMenuItem.Click += exportCSVToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // formsPlotFeat
            // 
            formsPlotFeat.DisplayScale = 1.25F;
            formsPlotFeat.Location = new Point(0, 250);
            formsPlotFeat.Name = "formsPlotFeat";
            formsPlotFeat.Size = new Size(575, 188);
            formsPlotFeat.TabIndex = 4;
            // 
            // chkNormalizeVolume
            // 
            chkNormalizeVolume.AutoSize = true;
            chkNormalizeVolume.Location = new Point(615, 280);
            chkNormalizeVolume.Name = "chkNormalizeVolume";
            chkNormalizeVolume.Size = new Size(150, 24);
            chkNormalizeVolume.TabIndex = 5;
            chkNormalizeVolume.Text = "NormalizeVolume";
            chkNormalizeVolume.UseVisualStyleBackColor = true;
            // 
            // chkSilence
            // 
            chkSilence.AutoSize = true;
            chkSilence.Location = new Point(615, 322);
            chkSilence.Name = "chkSilence";
            chkSilence.Size = new Size(78, 24);
            chkSilence.TabIndex = 6;
            chkSilence.Text = "Silence";
            chkSilence.UseVisualStyleBackColor = true;
            chkSilence.CheckedChanged += chkSilence_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkSilence);
            Controls.Add(chkNormalizeVolume);
            Controls.Add(formsPlotFeat);
            Controls.Add(formsPlotWave);
            Controls.Add(lblInfo);
            Controls.Add(btnLoad);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Cechy Sygnału Audio w Czasie";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private Label lblInfo;
        private ScottPlot.WinForms.FormsPlot formsPlotWave;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openWAVToolStripMenuItem;
        private ToolStripMenuItem exportCSVToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ScottPlot.WinForms.FormsPlot formsPlotFeat;
        private CheckBox chkNormalizeVolume;
        private CheckBox chkSilence;
    }
}
