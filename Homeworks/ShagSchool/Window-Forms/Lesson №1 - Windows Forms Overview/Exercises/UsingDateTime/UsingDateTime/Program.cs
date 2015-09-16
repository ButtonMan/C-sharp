//+---------------------------------------------------------------------------+
//УСЛОВИЕ:
/*
    Создать окно, в центральной части которого должно отображатся текущее 
    системное время ПК пользователя.
*/
//+---------------------------------------------------------------------------+


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingDateTime
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
            Application.Run(new FormWatch());
        }
    }
}
