using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingEventHandlerClick
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Запуск обработчика событий приложения, создание объекта
            //пользовательской формы и отображение формы
            Application.Run(new MyForm("Hello Word"));


        }
    }
}
