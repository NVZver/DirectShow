using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using DirectShowLib;


namespace DirectShow
{
    public class SampleGrabberCB
    {
        private int _width;
        private int _height;
        private PixelFormat _pixelFormat;
        private readonly ManualResetEvent _frameReadyEvent = new ManualResetEvent(false);
        private readonly object _currFrameLocker = new object();

        public SampleGrabberCB(ISampleGrabber sampleGrabber, PixelFormat pixelFormat)
        {
            var am = new AMMediaType();
            sampleGrabber.GetConnectedMediaType(am);
            var videoInfo = (VideoInfoHeader) Marshal.PtrToStructure(
                am.formatPtr, typeof (VideoInfoHeader));

            _width = videoInfo.BmiHeader.Width;
            _height = videoInfo.BmiHeader.Height;
            _pixelFormat = pixelFormat;

            var hr = sampleGrabber.SetCallback(this, 1);
            DsError.ThrowExceptionForHR(hr);

            _frameReadyEvent.Reset();
        }

        public int BufferCB(double sampleTime, IntPtr pBuffer, int bufferLen)
        {
            var newFrame = new Bitmap(_width, _height, _pixelFormat);
            CreateBitmapInversed(newFrame, pBuffer, bufferLen);
            
            lock (_currFrameLocker)
            {
                if (_currFrame != null)
                {
                    _currFrame.Dispose();
                }
                _currFrame = newFrame;
            }

            _frameReadyEvent.Set();
            return 0;
        }

        public Bitmap GetFrame()
        {
            Bitmap frame;
            _frameReadyEvent.WaitOne();
            lock (_currFrameLocker)
            {
                frame = _currFrame;
                _currFrame = null;
                _frameReadyEvent.Reset();
            }
            return frame;
        }
    }
}
