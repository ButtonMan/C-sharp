//+---------------------------------------------------------------------------+
//УСЛОВИЕ:
/*
    Вывести на экран свое (краткое !!!) резюме с помощью последова
    тельности MessageBox'ов (числом не менее трех). Причем на заго
    ловке последнего должно отобразиться среднее число символов на
    странице (общее количество символов в резюме / количество
    MessageBox'ов). 
*/
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometasks_1
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
            Application.Run(new MyForm());
        }
    }
}
