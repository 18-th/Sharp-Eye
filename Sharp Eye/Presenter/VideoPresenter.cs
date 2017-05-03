using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenter.Interfaces;
using View.Interfaces;

namespace Presenter
{
    class VideoPresenter: IVideoPresenter
    {
        private IVideoView _view;
        public VideoPresenter(IVideoView view)
        {
            if(view != null)
            {
                _view = view;
            }
        }

        public IVideoView GetView()
        {
            return _view;
        }
    }
}
