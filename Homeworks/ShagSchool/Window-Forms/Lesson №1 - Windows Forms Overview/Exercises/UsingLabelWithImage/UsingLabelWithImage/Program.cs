//+---------------------------------------------------------------------------+
//УСЛОВИЕ:
/*
    Создать окно в котром применить контроллер Label. В контроллере задать
    фоновое изображение.
*/
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingLabelWithImage
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new MyForm());
        }
    }
}
