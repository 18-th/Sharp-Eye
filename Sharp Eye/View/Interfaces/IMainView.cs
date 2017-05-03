﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Interfaces
{
    public interface IMainView : IView
    {
        void AddVideoControl(IVideoView view);
        void SetCameraList(string[] cameras);
    }
}
