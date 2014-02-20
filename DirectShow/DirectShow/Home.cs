using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DirectShow
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent(); 
            tsButtonPlay.Enabled  = false;
            tsButtonPause.Enabled = false;
            tsButtonStop.Enabled  = false;

            hSBMedia.Visible = false;
            vSBMedia.Visible = false;
        }
        OpenFileDialog openFileDialog = new OpenFileDialog();
        Media mMedia = new Media();

        private void tsmItemOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.Text = openFileDialog.ToString();
                mMedia.FileLoad(openFileDialog.FileName, this.pnlMedia);
                tmrMedia.Start();
                tsButtonPlay.Enabled  = true;
                tsButtonPause.Enabled = true;
                tsButtonStop.Enabled  = true;
            }
        }
            // Open...(LoadFile)
        private void tsButtonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.Text = openFileDialog.ToString();
                mMedia.FileLoad(openFileDialog.FileName, this.pnlMedia);
                tmrMedia.Start();
                tsButtonPlay.Enabled = true;
                tsButtonPause.Enabled = true;
                tsButtonStop.Enabled = true;
            }
        }
            //Play
        private void tsButtonPlay_Click(object sender, EventArgs e)
        {
            mMedia.MediaPlay();
            tmrMedia.Start();
        }
            //Pause
        private void tsButtonPause_Click(object sender, EventArgs e)
        {
            mMedia.MediaPause();
            tmrMedia.Stop();
            
        }
            //Stop
        private void tsButtonStop_Click(object sender, EventArgs e)
        {
            this.tsLabelMediaTime.Text = "00:00:00";
            this.trbScrollMedia.Value = 0;
            tmrMedia.Stop();
            mMedia.MediaStop();
        }
            //Таймер видео
        private void tmrMedia_Tick(object sender, EventArgs e)
        {
           mMedia.trbMediaPosition(this.trbScrollMedia);
           mMedia.TimeManager(this.tsLabelMediaTime, tmrMedia);
        }
            //Полоса прокрутки видео
        private void trbScrollMedia_Scroll(object sender, EventArgs e)
        {
            mMedia.ScrollMedia((double)this.trbScrollMedia.Value);
        }
            //Zoom
        private void trbZoomMedia_Scroll(object sender, EventArgs e)
        {
            if (trbZoomMedia.Value == 0)
            {
                hSBMedia.Visible = false;
                hSBMedia.Value = 0;
                vSBMedia.Visible = false;
                vSBMedia.Value = 0;

            }
            else
            {
                hSBMedia.Visible = true;
                vSBMedia.Visible = true;
            }
            mMedia.trbMediaZoom(this.trbZoomMedia, pnlMedia);
            hSBMedia.Maximum = trbZoomMedia.Value;
            vSBMedia.Maximum = trbZoomMedia.Value;
        }
            //Горизонтальная полоса прокрутки изображения при увеличении
        private void hSBMedia_Scroll(object sender, ScrollEventArgs e)
        {
            mMedia.ScrollMediaZoom(this.trbZoomMedia, hSBMedia, vSBMedia, pnlMedia);
        }
            //Вертикальная полоса прокрутки изображения при увеличении
        private void vSBMedia_Scroll(object sender, ScrollEventArgs e)
        {
            mMedia.ScrollMediaZoom(this.trbZoomMedia,hSBMedia,vSBMedia,pnlMedia);
        }
        
    }
}
