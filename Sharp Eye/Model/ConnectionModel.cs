using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Interfaces;
using Model.Utils;

namespace View
{
    public class ConnectionModel : IConnectionModel
    {
        public ConnectStatus Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public event Action Done;

        public void Connect(string server, string login, string password)
        {
            throw new NotImplementedException();
        }
    }
}
