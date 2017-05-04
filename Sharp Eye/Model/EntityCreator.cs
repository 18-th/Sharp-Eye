using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Interfaces;

namespace Model
{
    /// <summary>
    /// Класс выполняет внедрение зависимости в слои презентера и вью.
    /// </summary>
    public class EntityCreator
    {
        /// <summary>
        /// Метод вызывается во время загрузки приложения.
        /// Испорльзуйте его если вам необходимо выполнить инициаллизацию ваших
        /// компонентов.
        /// </summary>
        public static void Initialize()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Объек, выполняющий соединение с сервером</returns>
        public static IConnectionModel ConnectionModelBuild()
        {
            throw new Exception();
        }

        public static ICameraManagerModel CameraManagerBuild()
        {
            throw new Exception();
        }

        public static IVideoModel VideoModelBuild()
        {
            throw new Exception();
        }
    }
}
