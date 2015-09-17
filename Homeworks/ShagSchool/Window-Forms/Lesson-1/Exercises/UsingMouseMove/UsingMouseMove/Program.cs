//+---------------------------------------------------------------------------+
//  УСЛОВИЕ:
/*  Создать форму, при наведении мушью на которую, будет изменен цвет фона.*/
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingMouseMove
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Создание формы приложения и запуск работы обработчика событий
            //приложения
            Application.Run(new MyForm());
        }
    }
}
