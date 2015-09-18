//+---------------------------------------------------------------------------+
//УСЛОВИЕ ЗАДАЧИ:
/*
    Представьте, что у вас на форме есть прямоугольник, границы которого 
    на 10 пикселей отстоят от границ рабочей области формы. Необходимо 
    создать следующие обработчики: 

    b. Обработчик нажатия правой кнопки мыши, который выводит в заголовок 
    окна информацию о размере клиентской (рабочей) области окна в виде: 
    Ширина = x, Высота = y, где x и y соответствующие параметры вышего окна. 
*/
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hometasks_3b
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
