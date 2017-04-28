using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using View.Interfaces;
using System.Windows.Forms;

namespace Sharp_Eye.Interfaces
{
    public interface IVideoView : IView
    {
        string CameraName { set; get; }
        event Action CameraSelected;
        event Action CreatePrintScreen;
        event Action CreateBookMarker;
        event Action CreateComment;
        
        // Продумывается
        event Action VolumeChanged;

        void SetVideoStream(Panel videoStream);
        void SetCameraList(string[] cameras);
    }
}