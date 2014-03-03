using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DirectShowLib;

namespace DirectShow
{
    internal class Filters
    {
        //Получение списка устройств (Фильтров)
        /*В качестве параметра метод принимает
         * индетефикатор категории запрашиваемых фильтров.
         * Для получения списка устройств(фильтров), захватывать видеосигнал,
         * В качестве параметра надо передавать категорию FilterCategory.VideoInputDevice.
         */

        public static List<IBaseFilter> GetDevices(Guid filterCategory)
        {
            DsDevice[] devices = null;
            var sources = new List<IBaseFilter>();

            try
            {
                devices = DsDevice.GetDevicesOfCat(filterCategory);
                foreach (var device in devices)
                {
                    if (device.Mon != null)
                    {
                        object source;
                        var iid = typeof (IBaseFilter).GUID;
                        device.Mon.BindToObject(null, null, ref iid, out source);
                        if (source != null)
                        {
                            sources.Add((IBaseFilter) source);
                        }
                    }
                }
            }
            finally
            {
                if (devices != null)
                {
                    foreach (var device in devices)
                    {
                        device.Dispose();
                    }
                }
            }
            return sources;
        }

        private IBaseFilter _baseFilter = null;
        private IGraphBuilder _graphBuilder = null;
        private ICaptureGraphBuilder2 _captureGraphBuilder = null;
        private IVideoWindow _videoWindow = null;
        private IMediaControl _mediaControl = null;

        private Panel _Panel;

        private string Name;
        //Настройка окна захвата
        public void Connect(IBaseFilter baseFilter)
        {
            _baseFilter = baseFilter;
            _graphBuilder = (IGraphBuilder) new FilterGraph();
            _captureGraphBuilder = (ICaptureGraphBuilder2) new CaptureGraphBuilder2();
            _videoWindow = (IVideoWindow) _graphBuilder;
            _mediaControl = (IMediaControl) _graphBuilder;

            int hr = _captureGraphBuilder.SetFiltergraph(_graphBuilder);
            DsError.ThrowExceptionForHR(hr);

            hr = _graphBuilder.AddFilter(_baseFilter, Name);
            DsError.ThrowExceptionForHR(hr);

            hr = _captureGraphBuilder.RenderStream(
                PinCategory.Preview, MediaType.Video, _baseFilter, null, null);
            DsError.ThrowExceptionForHR(hr);

            SetPreviewVisible(true);
        }

        /*В методе SetPrevievVisible окно захвата привязывается к
        родительскому окну, на котором и будет отображаться сигнал.
        При желании окно можно скрыть.*/

        public void SetPreviewVisible(bool isVivible)
        {
            if (isVivible)
            {
                int hr = _videoWindow.put_Owner(_Panel.Handle);
                DsError.ThrowExceptionForHR(hr);

                hr = _videoWindow.put_WindowStyle(
                    WindowStyle.Child | WindowStyle.ClipChildren);
                DsError.ThrowExceptionForHR(hr);

                hr = _videoWindow.put_Visible(OABool.True);
                DsError.ThrowExceptionForHR(hr);
            }
            else
            {
                int hr = _videoWindow.put_Visible(OABool.False);
                DsError.ThrowExceptionForHR(hr);

                hr = _videoWindow.put_Owner(IntPtr.Zero);
                DsError.ThrowExceptionForHR(hr);
            }
        }

        // Метод для скрытия окна захвата и
        // освобождения используемых COM объектов
        public void Disconnect()
        {
            int hr = _mediaControl.Stop();
            DsError.ThrowExceptionForHR(hr);
            SetPreviewVisible(false);

            Marshal.ReleaseComObject(_baseFilter);
            Marshal.ReleaseComObject(_mediaControl);
            Marshal.ReleaseComObject(_videoWindow);
            Marshal.ReleaseComObject(_captureGraphBuilder);
            Marshal.ReleaseComObject(_graphBuilder);
        }

        /*Метод ConnectFilterToFilter связывает контакты вывода одного фильтра 
        с контактами ввода другого. 
        Связываемые контакты должны поддерживать переданный в виде параметра
        тип медиаинформации, это условие проверяется при помощи метода PinHasMediaType.*/
        /*В методе ConnectFilterToFilter выполняется итерация по контактам фильтра-источника,
         * для контактов вывода выполняется метод связывания
         * с фильтром-приемником ConnectPinToFilter*/

        private static void ConnectFilterToFilter(
            IGraphBuilder graphBuilder, IBaseFilter srcFilter,
            IBaseFilter dstFilter, Guid mediaType)
        {
            IEnumPins srcPins;
            int hr = srcFilter.EnumPins(out srcPins);
            DsError.ThrowExceptionForHR(hr);

            var srcPin = new IPin[1];
            while (srcPins.Next(1, srcPin, IntPtr.Zero) == 0)
            {
                IPin connectedTo;
                if (srcPin[0].ConnectedTo(out connectedTo) != 0)
                {
                    if (PinHasMediaType(srcPin[0], mediaType))
                    {
                        PinDirection pd;
                        hr = srcPin[0].QueryDirection(out pd);
                        DsError.ThrowExceptionForHR(hr);

                        if (pd == PinDirection.Output)
                        {
                            ConnectPinToFilter(graphBuilder, srcPin[0], dstFilter);
                        }
                    }
                }
            }
        }

        /*котором выполняется итерация по всем 
         * онтактам ввода и установление связи между контактами*/

        private static void ConnectPinToFilter(
            IGraphBuilder graphBuilder, IPin srcPin, IBaseFilter dstFilter)
        {
            IEnumPins dstPins;
            int hr = dstFilter.EnumPins(out dstPins);
            DsError.ThrowExceptionForHR(hr);

            var dstPin = new IPin[1];
            while (dstPins.Next(1, dstPin, IntPtr.Zero) == 0)
            {
                IPin connectedTo;
                if (dstPin[0].ConnectedTo(out connectedTo) != 0)
                {
                    PinDirection pd;
                    hr = dstPin[0].QueryDirection(out pd);
                    DsError.ThrowExceptionForHR(hr);

                    if (pd == PinDirection.Input)
                    {
                        hr = graphBuilder.Connect(srcPin, dstPin[0]);
                        DsError.ThrowExceptionForHR(hr);
                    }
                }
            }
        }

        private static bool PinHasMediaType(IPin pin, Guid mediaType)
        {
            IEnumMediaTypes mt;
            var amt = new AMMediaType[1];
            int hr = pin.EnumMediaTypes(out mt);
            DsError.ThrowExceptionForHR(hr);
            if (mt != null)
            {
                while (mt.Next(1, amt, IntPtr.Zero) == 0)
                {
                    if (amt[0].majorType == mediaType)
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        private IFilterGraph _filterGraph;
        private ISampleGrabber _sampleGrabber;
        private SampleGrabber _sampleGrabberObj;
        private IBaseFilter _sampleGrabberFilter;
        private SampleGrabberCB _sampleGrabberCb;
        
        public void Connect()
        {
            try
            {
                _filterGraph = (IGraphBuilder) new FilterGraph();
                _graphBuilder = (IGraphBuilder) _filterGraph;
                _mediaControl = (IMediaControl) _filterGraph;
                _sampleGrabberObj = new SampleGrabber();
                _sampleGrabber = (ISampleGrabber) _sampleGrabberObj;
                _sampleGrabberFilter = (IBaseFilter) _sampleGrabberObj;

                if (_graphBuilder != null)
                {
                    int hr = _graphBuilder.AddFilter(_baseFilter, Name);
                    DsError.ThrowExceptionForHR(hr);

                    hr = _graphBuilder.AddFilter(
                        _sampleGrabberFilter, "SampleGrabberFilter");
                    DsError.ThrowExceptionForHR(hr);

                    var mediaType = new AMMediaType();
                    mediaType.majorType = MediaType.Video;
                    mediaType.subType = MediaSubType.ARGB32;
                    _sampleGrabber.SetMediaType(mediaType);

                    ConnectFilterToFilter(
                        _graphBuilder, _baseFilter, _sampleGrabberFilter, MediaType.Video);

                    //Add null renderer
                    var nullRender = new NullRenderer();
                    var nullRenderFilter = (IBaseFilter) nullRender;
                    _graphBuilder.AddFilter(nullRenderFilter, "NullRendererFilter");
                    ConnectFilterToFilter(
                        _graphBuilder, _sampleGrabberFilter,
                        nullRenderFilter, MediaType.Video);

                    _sampleGrabberCb = new SampleGrabberCB(
                        _sampleGrabber, PixelFormat.Format32bppArgb);
                }
            }
            catch
            {
                Disconnect();
            }
        }
        
    }

    
}
