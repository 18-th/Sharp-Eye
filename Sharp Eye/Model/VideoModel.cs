using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Interfaces;
using VideoOS.Platform.Client;
using VideoOS.Platform;

namespace Model
{
    class VideoModel : IVideoModel
    {
        public void SetVideoStreamInPanel(ICameraModel camera, Panel panel)
        {
            ImageViewerControl imageViewer = ClientControl.Instance.GenerateImageViewerControl();
            imageViewer.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(imageViewer);
            imageViewer.CameraFQID = (FQID)camera.Id;

            imageViewer.Initialize();
            imageViewer.Connect();
            imageViewer.EnableDigitalZoom = true;
        }
    }
}
