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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(285, 351);
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
            lblInfo.Location = new Point(56, 340);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(50, 20);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "label1";
            // 
            // formsPlotWave
            // 
            formsPlotWave.DisplayScale = 1.25F;
            formsPlotWave.Location = new Point(24, 127);
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
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(56, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(323, 125);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(315, 92);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(315, 92);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(formsPlotWave);
            Controls.Add(tabControl1);
            Controls.Add(lblInfo);
            Controls.Add(btnLoad);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Cechy Sygnału Audio w Czasie";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}
