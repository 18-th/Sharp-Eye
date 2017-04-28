using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Utils;

namespace Presenter.Interfaces
{
    interface IConnectionEvent
    {
        void ConStatus(ConnectStatus status); 
    }
}
