using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Interfaces;
using Model.Interfaces;
using Presenter.Interfaces;


namespace Presenter
{
    /// <summary>
    ///  Презентер авторизации. 
    ///  Управляет контролом авторизации и объектом соединения.
    /// </summary>
    public class LoginPresenter : ILoginPresenter
    {
        private ILoginView _view;
        private IConnectionModel _connectModel;
        public event Action Connected;

        public LoginPresenter(ILoginView view, IConnectionModel connectModel)
        {
            if (view != null && connectModel != null)
            {
                this._view = view;
                this._connectModel = connectModel;
                _view.Login += () => login();
                _connectModel.Done += () => done();
                //Инициализация
                VideoOS.Platform.SDK.Environment.Initialize(); //Пусть временно будет тут
                //Инициализация
            }
            else
            {
                throw new Exception("Null point");
            }
            
        }


        private void login()
        {
            if (_view.Server != null)
                Connect();
        }


        private void done()
        {
            if (_connectModel.Status != Model.Utils.ConnectStatus.Ok)
            {
                _view.Show();
            }
            else
            {
                Connected();
            }    
        }

        public void Connect()
        {
            _connectModel.Connect(_view.Server,_view.UserName,_view.Password);
        }
    }
}
