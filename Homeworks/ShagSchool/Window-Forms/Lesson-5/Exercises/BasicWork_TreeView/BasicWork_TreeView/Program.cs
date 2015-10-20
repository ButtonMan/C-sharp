//+-------------------------------------------------------------------------------------+
//УСЛОВИЕ ЗАДАЧИ:
/*
Создать программу, которая бы отражала содержимое выбранного пользователем каталога в 
виде дерева (используя объект TreeView). Главное окно программы должно содержать:

- поле объекта класса TreeView, с информаций о структуре сожержимого выбранной папки;
- а также кнопку, открывающую диалоговое окно выбора корневого каталога, содержимое которого
будет отображено в поле объекта класса TreeView
*/
//+-------------------------------------------------------------------------------------+
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicWork_TreeView
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
