//+---------------------------------------------------------------------------+
//УСЛОВИЕ ЗАДАЧИ:
/*
Написать программу, вычисляющую сколько осталось времени до
указанной даты (дата вводится с клавиатуры в Edit). Предусмотреть 
возможность выдачи результата в годах, месяцах, днях, минутах, 
секундах (для первых двух вариантов ответ дробный). Для переключения 
между вариантами желательно использовать переключатели (RadioButton). 
*/
//+---------------------------------------------------------------------------+

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometask_7
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
            Application.Run(new FormMain());
        }
    }
}
