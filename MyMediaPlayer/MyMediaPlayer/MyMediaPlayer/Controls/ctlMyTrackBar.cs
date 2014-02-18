using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyMediaPlayer;
using QuartzTypeLib;

namespace TestTrackBar.Controls
{
    public partial class ctlMyTrackBar : UserControl
    {
        
        public ctlMyTrackBar()
        {
            InitializeComponent();
            
        }
        public int locX = 0;
        public int locY = 0;
        public int seconds = 0;
        public int mediaPosition = 0;
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (button1.Location.X != pnlTrack.Size.Width)
            {
                if (mediaPosition != seconds)
                {
                    locX = mediaPosition * (int)pnlTrack.Size.Width / seconds;
                    button1.Location = new Point(locX, locY);
                    mediaPosition += 1;
                    this.Refresh();
                }
                
            }
            else
            {
                locX = 0;
                locY = 0;
                button1.Location = new Point(locX, locY);
                timer1.Stop();

            }
            
        }

        public void timerStart(bool status)
        {
            if (status == true)
            {
                timer1.Start();
                
            }
            else
            {
                timer1.Stop();
                locX = 0;
                locY = 0;
                button1.Location = new Point(locX, locY);
            }

        }

        public void ObtainData(int allSecond)
        {
            seconds = allSecond;
        }
    }
}
