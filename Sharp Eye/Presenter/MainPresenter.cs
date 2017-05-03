using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Interfaces;
using Presenter.Interfaces;
using View;
using View.Interfaces;

namespace Presenter
{
    /// <summary>
    /// Этот класс
    /// управляет всеми презентерами в приложении.
    /// </summary>
    class MainPresenter : IMainPresenter
    {

        private IMainView _view;
        private ICameraManagerModel _cameraManager;
        private int _countVideoView; 

        public MainPresenter(IMainView view)
        {
            if(view != null)
            {
                this._view = view;
                _countVideoView = 1;
                _cameraManager = EntityCreator.CameraManagerBuild();
                _view.SetCameraList(CameraNames());

            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public IMainView GetView()
        {
            return this._view;
        }

        public void Run()
        {
            // временный код
            IVideoPresenter videoPresenter = new VideoPresenter( new VideoControl());
            _view.AddVideoControl(videoPresenter.GetView());
        }

        #region array camera names
        private string[] CameraNames()
        {

            return null;
        }
        #endregion

        #region Video live
        private void VideoLive()
        {

        }
        #endregion

        #region Video playback
        private void VideoPlayback()
        {

        }
        #endregion
    }
}
