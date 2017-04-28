using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Interfaces
{
    //<summary>
    //Сожержит базовые методы для всех контролов
    //</summary>
    public interface IView
    {
        void Show();
        void Close();
    }
}
