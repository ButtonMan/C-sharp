//+---------------------------------------------------------------------------+
//УСЛОВИЕ ЗАДАЧИ:
/*
Написать программу, которая по введенной дате определяет день недели. 
Результат выводить в текстовое поле (желательно по-русски). 
*/
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometask_6
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
            Application.Run(new Hometask_6.FORMS.FormMain());
        }
    }
}
