//+---------------------------------------------------------------------------+
//Задача: 
/*  - создать форму приложения, при щелчке в рабочей области которой,
    меняется цвет фона рабочей области (цвет выбирается случайным образом);*/
//+---------------------------------------------------------------------------+

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingFormBackColor
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //создание экземпляра класса формы MyForm 
            MyForm wnd = new MyForm();

            //редактирование заголовка формы
            wnd.Text = "Using Form.BackColor";

            //редактирование начальной позиции формы
            wnd.StartPosition = FormStartPosition.CenterScreen;

            //запуск цыкла обработки событий
            wnd.Size = new Size(400, 400);

            //запуск обработчика событий приложения, 
            //визуальное отображение формы wnd
            Application.Run(wnd);
        }
    }
}
