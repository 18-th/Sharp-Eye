using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Interfaces;

namespace View
{
    public partial class LoginControl : UserControl, ILoginView
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        public string Server { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool RememberPassword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AutoLogin { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event Action Login;

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void ShowConError(string message)
        {
            throw new NotImplementedException();
        }
    }
}
