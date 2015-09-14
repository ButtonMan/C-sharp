using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingMessageBox
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Запуск обработчика событий приложения, создание окна приложения
            //и установка пользовательского имени заголовка окна
            MyForm UserForm = new MyForm("User form");
            Application.Run(UserForm);


        }
    }
}
