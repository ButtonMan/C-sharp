//+---------------------------------------------------------------------------+
//УСЛОВИЕ ЗАДАЧИ:
/*
    Представьте, что у вас на форме есть прямоугольник, границы которого 
    на 10 пикселей отстоят от границ рабочей области формы. Необходимо 
    создать следующие обработчики: 

    a.Обработчик нажатия левой кнопки мыши , который выводит сообщение о 
    том, где находится текущая точка: внутри прямоугольника, снаружи, на 
    границе прямоугольника. Если при нажатии левой кнопки мыши была 
    нажата кнопка Control(Ctrl), то приложение должно закрываться. 
*/
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Hometasks_3a
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
