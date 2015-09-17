using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingFormStartPosition
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //создание объекта класса MyForm
            MyForm wnd = new MyForm();

            //присваивание нового заголовка окна
            wnd.Text = "Using StartPosition Method";

            //запуск стандартного цикла обработки сообщений приложения,
            //отображение окна на экране
            Application.Run(wnd);
        }
    }
}
