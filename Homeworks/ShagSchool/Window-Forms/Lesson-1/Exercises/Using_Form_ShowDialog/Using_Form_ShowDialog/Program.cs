//+---------------------------------------------------------------------------+
//  ЗАДАЧА:
/*  Создать программу, демонстирующую работу, модальных и немодальных форм
    пользовательского приложения. */
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_Form_ShowDialog
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //создание экземпляра класса
            MyForm wnd = new MyForm();

            //запуск обработчика событий приложения
            //отображение формы на экране монитора
            Application.Run(wnd);
        }
    }
}
