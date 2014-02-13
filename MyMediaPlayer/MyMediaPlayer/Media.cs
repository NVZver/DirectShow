using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using QuartzTypeLib;
using TestTrackBar.Controls;

namespace MyMediaPlayer
{
   public class Media
    {
        public Media()
        {
        }

        public enum mStatus{Play, Stop, Pause}
        public mStatus currentStatus;

        private const int WS_CHILD = 0x40000000;
        private const int WS_CLIPCHILDREN = 0x2000000;

        private FilgraphManager graphManager = new FilgraphManager();

        private IVideoWindow mWindow = null;
        private IMediaControl mControl = null;
        public IMediaPosition mPosition = null;
        private IMediaEvent mEvent;

       public int second1;
       public int ctlTrackPosition;

       public bool loadFile(string sfile, Panel vPanel)
        {
            graphManager.RenderFile(sfile);
            mWindow = graphManager as IVideoWindow;
            mControl = graphManager as IMediaControl;
            mPosition = graphManager as IMediaPosition;
            
            mWindow.Owner = (int) vPanel.Handle;
            mWindow.WindowStyle = WS_CHILD | WS_CLIPCHILDREN;
            mWindow.SetWindowPosition(vPanel.ClientRectangle.Left,
                                       vPanel.ClientRectangle.Top,
                                       vPanel.ClientRectangle.Width,
                                       vPanel.ClientRectangle.Height);
            //=====
            

            //=====
            currentStatus = mStatus.Play;
            second1 = (int) mPosition.Duration;
            ctlTrackPosition = second1;
            mControl.Run();

            return true;
        }

        public bool playMedia()
        {
           
            currentStatus = mStatus.Play;
            mControl.Run();
            return true;
        }

        public bool pauseMedia()
        {
            currentStatus = mStatus.Pause;
            mControl.Pause();
            return true;
        }

        public bool stopMedia()
        {
            currentStatus = mStatus.Stop;
            mControl.Stop();
            mPosition.CurrentPosition = 0;
            return true;
        }

        public void mVoilum()
        {
            
        }

       public void TimeManager(Label time1)
        {
           if (time1.Text == "00:00:00")
           {
               second1 = (int)mPosition.Duration;
           }

           if (mPosition!=null)
            {
            int hour = second1/3600;
            int minute = (second1 - (hour*3600))/60;
            int second = second1-(hour*3600+minute*60);
            time1.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", hour, minute, second);
            second1 -= 1;
            }
            else
            {
                time1.Text = "00:00:00";
            }
            
        }

       public void trbMedia(TrackBar trBar)
       {
          trBar.Value = ((int)mPosition.CurrentPosition * 100) / ctlTrackPosition;
       }

       public void trbScrollMedia(double sec)
       {
           mPosition.CurrentPosition = (double)(ctlTrackPosition*sec/100);
       }
    }
}
