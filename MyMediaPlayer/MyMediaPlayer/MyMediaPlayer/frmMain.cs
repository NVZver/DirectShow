using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using TestTrackBar.Controls;

namespace MyMediaPlayer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            mMedia.currentStatus = Media.mStatus.Empty;
            tSBPause.Enabled = false;
            tSBStop.Enabled  = false;
            tSBPlay.Enabled  = false;

            hScrollBarVPanel.Visible = false;
            vScrollBarVPanel.Visible = false;
        }
        
        OpenFileDialog openFileDialog = new OpenFileDialog();
        Media mMedia = new Media();
       
        public int locX = 0;
        public int locY = 0;
        public int mediaPosition = 0;
     
        private void tmrVideo_Tick(object sender, EventArgs e)
        {
            mMedia.TimeManager(tSLRemainedTime);
            mMedia.trbMedia(trackBar1);
        }
        
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.Text = openFileDialog + "[Play]";
                mMedia.loadFile(openFileDialog.FileName, this.pnlMedia);
                tmrVideo.Start();
                tSBPause.Enabled = true;
                tSBStop.Enabled = true;
                tSBPlay.Enabled = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            mMedia.trbScrollMedia((double)trackBar1.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (trackBar2.Value == 0)
            {
                hScrollBarVPanel.Visible = false;
                hScrollBarVPanel.Value = 0;
                vScrollBarVPanel.Visible = false;
                vScrollBarVPanel.Value = 0;

            }
            else
            {
                hScrollBarVPanel.Visible = true;
                vScrollBarVPanel.Visible = true;
            }
            mMedia.trbZoom(this.trackBar2, pnlMedia);
            
        }

        private void tSBPlay_Click(object sender, EventArgs e)
        {
            if (mMedia.currentStatus == Media.mStatus.Empty)
            {
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    this.Text = openFileDialog + "[Play]";
                    mMedia.loadFile(openFileDialog.FileName, this.pnlMedia);
                    
                    tmrVideo.Start();

                }
            }
            else
            {
                this.Text = openFileDialog + "[Play]";
                tmrVideo.Start();
                mMedia.playMedia();
            }
            
        }

        private void tSBPause_Click(object sender, EventArgs e)
        {
            this.Text = openFileDialog + "[Pause]";
            tmrVideo.Stop();
            mMedia.pauseMedia();
        }

        private void tSBStop_Click(object sender, EventArgs e)
        {
            this.Text = openFileDialog + "[Stop]";
            tmrVideo.Stop();
            tSLRemainedTime.Text = "00:00:00";
            mMedia.stopMedia();
            
        }

        private void tSBOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.Text = openFileDialog + "[Play]";
                mMedia.loadFile(openFileDialog.FileName, this.pnlMedia);
                tmrVideo.Start();
                tSBPause.Enabled = true;
                tSBStop.Enabled  = true;
                tSBPlay.Enabled  = true;

            }

        }

        private void hScrollBarVPanel_Scroll(object sender, ScrollEventArgs e)
        {
            mMedia.ScrollZoomMedia(trackBar2, hScrollBarVPanel, vScrollBarVPanel,this.pnlMedia);
        }

        private void vScrollBarVPanel_Scroll(object sender, ScrollEventArgs e)
        {
            mMedia.ScrollZoomMedia(trackBar2, hScrollBarVPanel, vScrollBarVPanel, this.pnlMedia);
        }

        
        
       }
}
