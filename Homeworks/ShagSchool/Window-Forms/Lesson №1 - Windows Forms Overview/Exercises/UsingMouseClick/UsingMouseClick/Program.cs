//+---------------------------------------------------------------------------+
//  УСЛОВИЕ:
/*  Создать форму, при щелчке левой мышью на которой, будет выведено сообщение
    с информацией о нажатой кнопке мыши и координаты положения мыши в момент
    нажатия клавиши .*/
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingMouseClick
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Создание экземпляра класса MyForm и запуск работы
            //обработчика событий приложения.
            Application.Run(new MyForm());
        }
    }
}
