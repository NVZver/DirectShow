using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DirectShow;
using DirectShowLib;

namespace DirectShow
{
    class Media
    {
        public Media()
        {
        }
        //Перечисления
        public enum mStatus{Empty, Play, Pause, Stop}
        public mStatus CurrentStatus = mStatus.Empty;
        //Интерфейсы
        private IGraphBuilder  graphBuilder  = null;
        private IMediaControl  mediaControl  = null;
        private IVideoWindow   videoWindow   = null;
        private IMediaPosition mediaPosition = null;
        private IBasicAudio    basicAudio    = null;
        private IMediaEvent    mediaEvent    = null;
        private IMediaEventEx  mediaEventEx  = null;
        //Переменные
        private double mediaTimeSeconds; //Количество секунд в видео;
        private int allSeconds;          // Количество секунд для таймера;
        
        //Мотод для загрузки видео файла.
        public void FileLoad(string sfile, Panel vPanel)
        {
            CleanUp();
            
            graphBuilder  = (IGraphBuilder) new FilterGraph();
            mediaControl  = graphBuilder as IMediaControl;
            mediaPosition = graphBuilder as IMediaPosition;
            videoWindow   = graphBuilder as IVideoWindow;
            basicAudio    = graphBuilder as IBasicAudio;

            graphBuilder.RenderFile(sfile, null);
            videoWindow.put_Owner(vPanel.Handle);
            videoWindow.put_WindowStyle(WindowStyle.Child 
                                      | WindowStyle.ClipSiblings 
                                      | WindowStyle.ClipChildren);
            videoWindow.SetWindowPosition(vPanel.ClientRectangle.Left,
                                          vPanel.ClientRectangle.Top,
                                          vPanel.ClientRectangle.Width,
                                          vPanel.ClientRectangle.Height);
            
            mediaControl.Run();
            mediaPosition.get_Duration(out mediaTimeSeconds);
            allSeconds = (int)mediaTimeSeconds;
        }

        //Метод CleanUp (Зачистка графов)
        public void CleanUp()
        {
            if (mediaControl != null) mediaControl.Stop();
            CurrentStatus = mStatus.Stop;
            
            if (videoWindow != null)
            {
                videoWindow.put_Visible(0);
                videoWindow.put_Owner(new IntPtr(0));
            }
            if (mediaControl != null)  mediaControl  = null;
            if (mediaPosition != null) mediaPosition = null;
            if (mediaEventEx != null)  mediaEventEx  = null;
            if (mediaEvent != null)    mediaEvent    = null;
            if (videoWindow != null)   videoWindow   = null;
            if (basicAudio != null)    basicAudio    = null;
            if (graphBuilder != null)  graphBuilder  = null;

        }

        //Метод расчета и отображения времени видео
        public void TimeManager(ToolStripLabel tsLabel, Timer timer)
        {
            if (tsLabel.Text == "00:00:00")
            {
                allSeconds = (int)mediaTimeSeconds;
            }
            
            int hour = allSeconds / 3600;
            int minute = (allSeconds - (hour * 3600)) / 60;
            int seconds = allSeconds - (hour*3600 + minute*60);
            tsLabel.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", hour, minute, seconds);
            allSeconds -= 1;
        }

        //Методы управления видео (Play, Pause, Stop)
        public void MediaPlay()
        {
            mediaControl.Run();
        }

        public void MediaPause()
        {
            mediaControl.Pause();
        }

        public void MediaStop()
        {
            mediaControl.Stop();
            mediaPosition.put_CurrentPosition(0);
        }
        
        //Изменение позиции ползунка trbScrollMedia относительно
        //пройденного видео.
        public void trbMediaPosition(TrackBar trackBar)
        {
            double mTimeNow;
            mediaPosition.get_CurrentPosition(out mTimeNow);
            trackBar.Value = (int)mTimeNow * 100 / (int)mediaTimeSeconds;
        }

        //Метод перемотки видео с помощю элемента trackBar
        public void ScrollMedia(double trbValue)
        {
            mediaPosition.put_CurrentPosition(mediaTimeSeconds*trbValue/100);
        }

        // Zoom
        public void trbMediaZoom(TrackBar zoomTrackBar, Panel vPanel)
        {
            videoWindow.SetWindowPosition(vPanel.ClientRectangle.Left,
                                          vPanel.ClientRectangle.Top,
                                          vPanel.ClientRectangle.Width + zoomTrackBar.Value,
                                          vPanel.ClientRectangle.Height + zoomTrackBar.Value);


        }

        //Метод для прокрутки увеличенного видео
        public void ScrollMediaZoom(TrackBar zoomTrackBar, HScrollBar hScroll, VScrollBar vScroll, Panel vPanel)
        {
            videoWindow.SetWindowPosition(vPanel.ClientRectangle.Left - hScroll.Value,
                                          vPanel.ClientRectangle.Top - vScroll.Value,
                                          vPanel.ClientRectangle.Width + zoomTrackBar.Value,
                                          vPanel.ClientRectangle.Height + zoomTrackBar.Value);
        }
    }
}
