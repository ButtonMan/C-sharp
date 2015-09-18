//+---------------------------------------------------------------------------+
//УСЛОВИЕ:
/*
    -   Создать окно с двумя контроллерами ListBox. 
    -   Cоздать текстовое поле Text. Реализовать добавление новых данных
        в ListBox из тектового поля, при нажатии кнопки "Добавить". 
    -   Создать кнопку "Копировать", выполняющую копированию, элементов одного
        списка в другой список
    -   Реализовать кнопку "Убрать" выполняющую удаление выделенных элементов
        из списка "копий"
*/
//+---------------------------------------------------------------------------+

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingListBox
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
