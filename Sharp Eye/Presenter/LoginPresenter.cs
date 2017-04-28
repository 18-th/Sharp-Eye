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

        public LoginPresenter(ILoginView view, IConnectionModel connectModel)
        {
            if (view != null && connectModel != null)
            {
                this._view = view;
                this._connectModel = connectModel;
            }
            else
            {
                throw new Exception("Null point");
            }
            
        }

        public void Connect()
        {
            throw new NotImplementedException();
        }
    }
}
