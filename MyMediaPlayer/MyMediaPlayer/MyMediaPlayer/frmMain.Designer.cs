namespace MyMediaPlayer
{
    partial class frmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tmrVideo = new System.Windows.Forms.Timer(this.components);
            this.pnlMedia = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.toolStpControls = new System.Windows.Forms.ToolStrip();
            this.tSBPlay = new System.Windows.Forms.ToolStripButton();
            this.tSBPause = new System.Windows.Forms.ToolStripButton();
            this.tSBStop = new System.Windows.Forms.ToolStripButton();
            this.tSBOpen = new System.Windows.Forms.ToolStripButton();
            this.tSLRemainedTime = new System.Windows.Forms.ToolStripLabel();
            this.vScrollBarVPanel = new System.Windows.Forms.VScrollBar();
            this.hScrollBarVPanel = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.toolStpControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrVideo
            // 
            this.tmrVideo.Interval = 1000;
            this.tmrVideo.Tick += new System.EventHandler(this.tmrVideo_Tick);
            // 
            // pnlMedia
            // 
            this.pnlMedia.AutoScroll = true;
            this.pnlMedia.AutoSize = true;
            this.pnlMedia.BackColor = System.Drawing.SystemColors.ControlText;
            this.pnlMedia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMedia.Location = new System.Drawing.Point(0, 45);
            this.pnlMedia.Name = "pnlMedia";
            this.pnlMedia.Size = new System.Drawing.Size(617, 427);
            this.pnlMedia.TabIndex = 17;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBar1.Location = new System.Drawing.Point(0, 539);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(641, 42);
            this.trackBar1.TabIndex = 19;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(0, 491);
            this.trackBar2.Maximum = 500;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(200, 42);
            this.trackBar2.TabIndex = 21;
            this.trackBar2.TickFrequency = 2;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // toolStpControls
            // 
            this.toolStpControls.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStpControls.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStpControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBPlay,
            this.tSBPause,
            this.tSBStop,
            this.tSBOpen,
            this.tSLRemainedTime});
            this.toolStpControls.Location = new System.Drawing.Point(0, 24);
            this.toolStpControls.Name = "toolStpControls";
            this.toolStpControls.Size = new System.Drawing.Size(641, 25);
            this.toolStpControls.TabIndex = 23;
            this.toolStpControls.Text = "toolStrip1";
            // 
            // tSBPlay
            // 
            this.tSBPlay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tSBPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBPlay.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tSBPlay.Image = ((System.Drawing.Image)(resources.GetObject("tSBPlay.Image")));
            this.tSBPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBPlay.Name = "tSBPlay";
            this.tSBPlay.Size = new System.Drawing.Size(23, 22);
            this.tSBPlay.Text = "toolStripButton1";
            this.tSBPlay.Click += new System.EventHandler(this.tSBPlay_Click);
            // 
            // tSBPause
            // 
            this.tSBPause.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tSBPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBPause.Image = ((System.Drawing.Image)(resources.GetObject("tSBPause.Image")));
            this.tSBPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBPause.Name = "tSBPause";
            this.tSBPause.Size = new System.Drawing.Size(23, 22);
            this.tSBPause.Text = "toolStripButton2";
            this.tSBPause.Click += new System.EventHandler(this.tSBPause_Click);
            // 
            // tSBStop
            // 
            this.tSBStop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tSBStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBStop.Image = ((System.Drawing.Image)(resources.GetObject("tSBStop.Image")));
            this.tSBStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBStop.Name = "tSBStop";
            this.tSBStop.Size = new System.Drawing.Size(23, 22);
            this.tSBStop.Text = "toolStripButton3";
            this.tSBStop.Click += new System.EventHandler(this.tSBStop_Click);
            // 
            // tSBOpen
            // 
            this.tSBOpen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tSBOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBOpen.Image = ((System.Drawing.Image)(resources.GetObject("tSBOpen.Image")));
            this.tSBOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBOpen.Name = "tSBOpen";
            this.tSBOpen.Size = new System.Drawing.Size(23, 22);
            this.tSBOpen.Text = "toolStripButton4";
            this.tSBOpen.Click += new System.EventHandler(this.tSBOpen_Click);
            // 
            // tSLRemainedTime
            // 
            this.tSLRemainedTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tSLRemainedTime.Name = "tSLRemainedTime";
            this.tSLRemainedTime.Size = new System.Drawing.Size(10, 22);
            this.tSLRemainedTime.Text = " ";
            // 
            // vScrollBarVPanel
            // 
            this.vScrollBarVPanel.Location = new System.Drawing.Point(620, 49);
            this.vScrollBarVPanel.Maximum = 500;
            this.vScrollBarVPanel.Name = "vScrollBarVPanel";
            this.vScrollBarVPanel.Size = new System.Drawing.Size(16, 423);
            this.vScrollBarVPanel.TabIndex = 0;
            this.vScrollBarVPanel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBarVPanel_Scroll);
            // 
            // hScrollBarVPanel
            // 
            this.hScrollBarVPanel.Location = new System.Drawing.Point(0, 470);
            this.hScrollBarVPanel.Maximum = 500;
            this.hScrollBarVPanel.Name = "hScrollBarVPanel";
            this.hScrollBarVPanel.Size = new System.Drawing.Size(615, 18);
            this.hScrollBarVPanel.TabIndex = 1;
            this.hScrollBarVPanel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarVPanel_Scroll);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(641, 581);
            this.Controls.Add(this.vScrollBarVPanel);
            this.Controls.Add(this.hScrollBarVPanel);
            this.Controls.Add(this.toolStpControls);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pnlMedia);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.toolStpControls.ResumeLayout(false);
            this.toolStpControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrVideo;
        private System.Windows.Forms.Panel pnlMedia;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.ToolStrip toolStpControls;
        private System.Windows.Forms.ToolStripButton tSBPlay;
        private System.Windows.Forms.ToolStripButton tSBPause;
        private System.Windows.Forms.ToolStripButton tSBStop;
        private System.Windows.Forms.ToolStripButton tSBOpen;
        private System.Windows.Forms.ToolStripLabel tSLRemainedTime;
        private System.Windows.Forms.HScrollBar hScrollBarVPanel;
        private System.Windows.Forms.VScrollBar vScrollBarVPanel;
    }
}

