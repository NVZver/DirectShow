namespace DirectShow
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.mSpHome = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsButtonPlay = new System.Windows.Forms.ToolStripButton();
            this.tsButtonPause = new System.Windows.Forms.ToolStripButton();
            this.tsButtonStop = new System.Windows.Forms.ToolStripButton();
            this.tsButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.tsLabelMediaTime = new System.Windows.Forms.ToolStripLabel();
            this.tsLabelMediaTime1 = new System.Windows.Forms.ToolStripLabel();
            this.pnlMedia = new System.Windows.Forms.Panel();
            this.trbScrollMedia = new System.Windows.Forms.TrackBar();
            this.trbZoomMedia = new System.Windows.Forms.TrackBar();
            this.vSBMedia = new System.Windows.Forms.VScrollBar();
            this.hSBMedia = new System.Windows.Forms.HScrollBar();
            this.tmrMedia = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.mSpHome.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbScrollMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbZoomMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // mSpHome
            // 
            this.mSpHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile});
            this.mSpHome.Location = new System.Drawing.Point(0, 0);
            this.mSpHome.Name = "mSpHome";
            this.mSpHome.Size = new System.Drawing.Size(919, 24);
            this.mSpHome.TabIndex = 0;
            this.mSpHome.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItemOpen,
            this.tsmItemExit});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(35, 20);
            this.tsmFile.Text = "File";
            // 
            // tsmItemOpen
            // 
            this.tsmItemOpen.Name = "tsmItemOpen";
            this.tsmItemOpen.Size = new System.Drawing.Size(112, 22);
            this.tsmItemOpen.Text = "Open...";
            this.tsmItemOpen.Click += new System.EventHandler(this.tsmItemOpen_Click);
            // 
            // tsmItemExit
            // 
            this.tsmItemExit.Name = "tsmItemExit";
            this.tsmItemExit.Size = new System.Drawing.Size(112, 22);
            this.tsmItemExit.Text = "Exit";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsButtonPlay,
            this.tsButtonPause,
            this.tsButtonStop,
            this.tsButtonOpen,
            this.tsLabelMediaTime,
            this.tsLabelMediaTime1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(919, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsButtonPlay
            // 
            this.tsButtonPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonPlay.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonPlay.Image")));
            this.tsButtonPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonPlay.Name = "tsButtonPlay";
            this.tsButtonPlay.Size = new System.Drawing.Size(23, 22);
            this.tsButtonPlay.Text = "Play";
            this.tsButtonPlay.Click += new System.EventHandler(this.tsButtonPlay_Click);
            // 
            // tsButtonPause
            // 
            this.tsButtonPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonPause.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonPause.Image")));
            this.tsButtonPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonPause.Name = "tsButtonPause";
            this.tsButtonPause.Size = new System.Drawing.Size(23, 22);
            this.tsButtonPause.Text = "Pause";
            this.tsButtonPause.Click += new System.EventHandler(this.tsButtonPause_Click);
            // 
            // tsButtonStop
            // 
            this.tsButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonStop.Image")));
            this.tsButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonStop.Name = "tsButtonStop";
            this.tsButtonStop.Size = new System.Drawing.Size(23, 22);
            this.tsButtonStop.Text = "Stop";
            this.tsButtonStop.Click += new System.EventHandler(this.tsButtonStop_Click);
            // 
            // tsButtonOpen
            // 
            this.tsButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonOpen.Image")));
            this.tsButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonOpen.Name = "tsButtonOpen";
            this.tsButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.tsButtonOpen.Text = "Open...";
            this.tsButtonOpen.Click += new System.EventHandler(this.tsButtonOpen_Click);
            // 
            // tsLabelMediaTime
            // 
            this.tsLabelMediaTime.Name = "tsLabelMediaTime";
            this.tsLabelMediaTime.Size = new System.Drawing.Size(10, 22);
            this.tsLabelMediaTime.Text = " ";
            // 
            // tsLabelMediaTime1
            // 
            this.tsLabelMediaTime1.Name = "tsLabelMediaTime1";
            this.tsLabelMediaTime1.Size = new System.Drawing.Size(10, 22);
            this.tsLabelMediaTime1.Text = " ";
            // 
            // pnlMedia
            // 
            this.pnlMedia.Location = new System.Drawing.Point(0, 52);
            this.pnlMedia.Name = "pnlMedia";
            this.pnlMedia.Size = new System.Drawing.Size(400, 380);
            this.pnlMedia.TabIndex = 2;
            // 
            // trbScrollMedia
            // 
            this.trbScrollMedia.Location = new System.Drawing.Point(0, 531);
            this.trbScrollMedia.Maximum = 100;
            this.trbScrollMedia.Name = "trbScrollMedia";
            this.trbScrollMedia.Size = new System.Drawing.Size(404, 42);
            this.trbScrollMedia.TabIndex = 0;
            this.trbScrollMedia.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbScrollMedia.Scroll += new System.EventHandler(this.trbScrollMedia_Scroll);
            // 
            // trbZoomMedia
            // 
            this.trbZoomMedia.Location = new System.Drawing.Point(0, 483);
            this.trbZoomMedia.Maximum = 1000;
            this.trbZoomMedia.Name = "trbZoomMedia";
            this.trbZoomMedia.Size = new System.Drawing.Size(297, 42);
            this.trbZoomMedia.TabIndex = 1;
            this.trbZoomMedia.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbZoomMedia.Scroll += new System.EventHandler(this.trbZoomMedia_Scroll);
            // 
            // vSBMedia
            // 
            this.vSBMedia.LargeChange = 1;
            this.vSBMedia.Location = new System.Drawing.Point(403, 52);
            this.vSBMedia.Maximum = 0;
            this.vSBMedia.Name = "vSBMedia";
            this.vSBMedia.Size = new System.Drawing.Size(20, 385);
            this.vSBMedia.TabIndex = 3;
            this.vSBMedia.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vSBMedia_Scroll);
            // 
            // hSBMedia
            // 
            this.hSBMedia.LargeChange = 1;
            this.hSBMedia.Location = new System.Drawing.Point(-3, 435);
            this.hSBMedia.Maximum = 0;
            this.hSBMedia.Name = "hSBMedia";
            this.hSBMedia.Size = new System.Drawing.Size(407, 20);
            this.hSBMedia.TabIndex = 4;
            this.hSBMedia.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hSBMedia_Scroll);
            // 
            // tmrMedia
            // 
            this.tmrMedia.Interval = 1000;
            this.tmrMedia.Tick += new System.EventHandler(this.tmrMedia_Tick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(426, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 380);
            this.panel1.TabIndex = 5;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 573);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hSBMedia);
            this.Controls.Add(this.vSBMedia);
            this.Controls.Add(this.trbScrollMedia);
            this.Controls.Add(this.trbZoomMedia);
            this.Controls.Add(this.pnlMedia);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mSpHome);
            this.MainMenuStrip = this.mSpHome;
            this.Name = "Home";
            this.Text = "Home";
            this.mSpHome.ResumeLayout(false);
            this.mSpHome.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbScrollMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbZoomMedia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mSpHome;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmItemOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmItemExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsButtonPlay;
        private System.Windows.Forms.ToolStripButton tsButtonPause;
        private System.Windows.Forms.ToolStripButton tsButtonStop;
        private System.Windows.Forms.ToolStripButton tsButtonOpen;
        private System.Windows.Forms.ToolStripLabel tsLabelMediaTime;
        private System.Windows.Forms.Panel pnlMedia;
        private System.Windows.Forms.TrackBar trbZoomMedia;
        private System.Windows.Forms.VScrollBar vSBMedia;
        private System.Windows.Forms.HScrollBar hSBMedia;
        private System.Windows.Forms.Timer tmrMedia;
        private System.Windows.Forms.ToolStripLabel tsLabelMediaTime1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trbScrollMedia;
    }
}

