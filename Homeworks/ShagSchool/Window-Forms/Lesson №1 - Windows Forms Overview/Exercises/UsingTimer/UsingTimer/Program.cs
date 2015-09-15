//+---------------------------------------------------------------------------+
//  УСЛОВИЕ:
/*  
    Создать форму, предпологающую работу пользователя с таймером обратного
    отсчета времени. Таймер должен задаваться пользователем в ручную (в 
    секундах). По завершении указанного времени таймер должен выдать 
    соответствующее уведомление.
*/
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingTimer
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new MyForm());
        }
    }
}
