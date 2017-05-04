using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenter.Interfaces;
using View;
using View.Interfaces;
using Model;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Presenter
{
    /// <summary>
    /// Класс управляет логикой вызоовов презентеров и отображением контролов
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("F76C845A-8114-48FD-871C-24513812E17E")]
    public class ApplicationManager
    {

        private IContainerView _containerView;
        private ILoginPresenter _loginPresenter;
        private IMainPresenter _mainPresenter;

        public ApplicationManager()
        {
            EntityCreator.Initialize();

            _containerView = new AppContainerControl();
            _containerView.Show();

            _loginPresenter = new LoginPresenter(new LoginControl(),
                                                EntityCreator.ConnectionModelBuild());
            _loginPresenter.Connected += () => ConnectionCompleted();

            _containerView.LoadLoginView(_loginPresenter.GetView());

            _loginPresenter.Connect();

        }

        /// <summary>
        /// 
        /// </summary>
        private void ConnectionCompleted()
        {
            _mainPresenter = new MainPresenter(new MainControl());
            _containerView.LoadMainView(_mainPresenter.GetView());

            _mainPresenter.Run();
        }

        #region ComReg

        [ComRegisterFunction]
        public static void RegisterClass(string key)
        {
            var trimedkey = TrimRegKey(key);
            RegistryKey k = null;
            try
            {
                // Открываем ключ CLSID\{guid} в режиме записи
                k = Registry.ClassesRoot.OpenSubKey(trimedkey, true);
                if (k == null)
                {
                    MessageBox.Show(@"Error HKEY_CLASSES_ROOT\CLSID\" + key);
                    return;
                }

                // Создаем ключ элемента управления ActiveX – это позволяет ему появиться
                //в контейнере элемента управления ActiveX
                RegistryKey ctrl = k.CreateSubKey("Control");
                ctrl.Close();

                RegistryKey insertb = k.CreateSubKey("Insertable");
                insertb.Close();

                // Создаем запись CodeBase
                RegistryKey inprocServer32 = k.OpenSubKey("InprocServer32", true);
                inprocServer32.SetValue("CodeBase", Assembly.GetExecutingAssembly().CodeBase);
                inprocServer32.Close();

                MessageBox.Show(key + "\r\n Reg OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show(key + "\r\nUnReg Error\r\n" + ex);
                throw;
            }
            finally
            {
                if (k != null) k.Close();
            }
        }

        [ComVisible(false)]
        private static string TrimRegKey(string key)
        {
            // Удаляем HKEY_CLASSES_ROOT\ из переданного ключа
            return key.Replace(@"HKEY_CLASSES_ROOT\", "");
        }

        [ComUnregisterFunction]
        public static void UnregisterClass(string key)
        {
            var trimedkey = TrimRegKey(key);

            RegistryKey k = null;
            try
            {
                // Открываем ключ HKCR\CLSID\{guid} в режиме записи
                k = Registry.ClassesRoot.OpenSubKey(trimedkey, true);

                if (k == null)
                {
                    MessageBox.Show(@"Error HKEY_CLASSES_ROOT\CLSID\" + key);
                    return;
                }

                k.DeleteSubKey("Control", false);
                k.DeleteSubKey("Insertable", false);
                // Затем открываем ключ InprocServer32
                RegistryKey inprocServer32 = k.OpenSubKey("InprocServer32", true);

                // Удаляем ключ CodeBase
                k.DeleteSubKey("CodeBase", false);
                inprocServer32.Close();

                MessageBox.Show(key + "\r\nUnReg OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show(key + "\r\nUnReg Error\r\n" + ex);
                throw;
            }
            finally
            {
                if (k != null) k.Close();
            }
        }

        #endregion


    }
}
