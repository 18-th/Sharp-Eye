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
    public partial class VideoControl : UserControl, IVideoView
    {
        public VideoControl()
        {
            InitializeComponent();
        }
    }
}
