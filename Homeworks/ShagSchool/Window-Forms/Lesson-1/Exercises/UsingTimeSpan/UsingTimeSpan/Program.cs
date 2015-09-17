//+---------------------------------------------------------------------------+
//УСЛОВИЕ:
/*
    Создать окно отображающее время, оставшееся до конца текущего дня.
*/
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingTimeSpan
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyDay());
        }
    }
}
