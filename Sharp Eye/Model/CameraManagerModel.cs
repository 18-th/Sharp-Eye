using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Interfaces;
using VideoOS.Platform;

namespace Model
{
    class CameraManagerModel : ICameraManagerModel
    {
        public List<ICameraModel> GetCameras()
        {
            List<Item> list = Configuration.Instance.GetItemsByKind(Kind.Camera);
            List<ICameraModel> listCam = new List<ICameraModel>();
            foreach (var i in list)
            {
                Camera c = new Camera(i.FQID, i.Name);
                listCam.Add(c);
            }

            return listCam;
        }
    }
}
