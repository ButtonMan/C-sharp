//+---------------------------------------------------------------------------+
//УСЛОВИЕ ЗАДАЧИ:
/*
    Представьте, что у вас на форме есть прямоугольник, границы которого 
    на 10 пикселей отстоят от границ рабочей области формы. Необходимо 
    создать следующие обработчики: 

    c. Обработчик перемещения указателя мыши в пределах рабочей области, 
    который должен выводить в заголовок окна текущие координаты мыши x и y. 
*/
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometasks_3с
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
            Application.Run(new Form1());
        }
    }
}
