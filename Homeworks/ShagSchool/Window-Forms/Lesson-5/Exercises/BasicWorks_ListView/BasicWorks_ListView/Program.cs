//+-------------------------------------------------------------------------------------+
//УСЛОВИЕ ЗАДАЧИ:
/*
Отобразить в окне при помощи объекта класса ListView все вложенные папки в выбранной 
пользователем директории. Для этого в форме необходо создать:
- кнопку выбора директирии
- поле объекта класса ListView для отображения всех вложенных в выбранную директорию
папок.
*/
//+-------------------------------------------------------------------------------------+

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicWorks_ListView
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
            Application.Run(new FormMain());
        }
    }
}
