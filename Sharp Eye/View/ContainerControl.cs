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
    }
}
