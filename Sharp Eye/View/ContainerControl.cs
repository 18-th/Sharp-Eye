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
    /// <summary>
    /// Служит контайнером для всех контролов
    /// </summary>
    public partial class ContainerControl : UserControl, IContainerView
    {
        public ContainerControl()
        {
            InitializeComponent();
        }

        private void ContainerControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        public void LoadLoginView(ILoginView view)
        {
            UserControl loginView = (UserControl)view;
            // Устанавливаем контрол по центру
            loginView.Left = (this.ClientSize.Width - loginView.Width) / 2;
            loginView.Top = (this.ClientSize.Height - loginView.Height) / 2;
            this.Controls.Clear();
            this.Controls.Add(loginView);
        }

       
    }
}
