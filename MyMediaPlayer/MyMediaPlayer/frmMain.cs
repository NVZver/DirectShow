using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using TestTrackBar.Controls;

namespace MyMediaPlayer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            btnPlay.Enabled = false;
            btnPlay.Visible = false;

            btnPause.Enabled = false;
            btnPause.Visible = false;

            btnStop.Enabled = false;
            btnStop.Visible = false;                     

        }
        
        OpenFileDialog openFileDialog = new OpenFileDialog();
        Media mMedia = new Media();
        public int locX = 0;
        public int locY = 0;
        public int mediaPosition = 0;
       
        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Text = openFileDialog + "[Play]";
            tmrVideo.Start();
            mMedia.playMedia();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            this.Text = openFileDialog + "[Pause]";
            tmrVideo.Stop();
            mMedia.pauseMedia();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Text = openFileDialog + "[Stop]";
            tmrVideo.Stop();
            label1.Text = "00:00:00";
            mMedia.stopMedia();
        }
        
        private void tmrVideo_Tick(object sender, EventArgs e)
        {
            mMedia.TimeManager(label1);
            mMedia.trbMedia(trackBar1);
        }

        

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                
                btnPlay.Enabled = true;
                btnPlay.Visible = true;

                btnPause.Enabled = true;
                btnPause.Visible = true;

                btnStop.Enabled = true;
                btnStop.Visible = true;

                this.Text = openFileDialog + "[Play]";
                mMedia.loadFile(openFileDialog.FileName, this.pnlMedia);
                tmrVideo.Start();
             }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            mMedia.trbScrollMedia((double)trackBar1.Value);
        }

       }
}
