using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenter.Interfaces;
using View;
using View.Interfaces;
using Model;

namespace Presenter
{
    /// <summary>
    /// Класс управляет логикой вызоовов презентеров и отображением контролов
    /// </summary>
    public class ApplicationManager
    {
        private IContainerView _containerView;
        private ILoginPresenter _loginPresenter;
        private IMainPresenter _mainPresenter;

        public ApplicationManager()
        {
            EntityCreator.Initialize();

            _containerView = new ContainerControl();
            _containerView.Show();

            _loginPresenter = new LoginPresenter(new LoginControl(),
                                                EntityCreator.ConnectionModelBuild());
        }

        /// <summary>
        /// 
        /// </summary>
        private void ConnectionCompleted()
        {

        }
    }
}
