//+---------------------------------------------------------------------------+
//УСЛОВИЕ ЗАДАЧИ:
/*
Разработайте программу, которая позволяет пользователю осуществлять поиск
файлов по заданному критерию. Приложение состоит из двух форм - главное окно
и окно поиска. Пользователь можеть открыть сколько угодно окон поиска. Окно
поиска запускается немодально. В окне поиска пользователь выбирает папку, в
которой будет идти поиск и вводит маску поиска, например "*.doc". Найденные 
файлы отображаются в списке.
*/
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometask_1
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
            Application.Run(new Forms.FormMain());
        }
    }
}
