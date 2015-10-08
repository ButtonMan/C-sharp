//+---------------------------------------------------------------------------+
//УСЛОВИЕ ЗАДАЧИ:
/*
Создать меню программы (MenuStrip) включающее в себя несколько пунктов.
В меню создать по одному объекту для каждого из следующих классов: 
- ToolStripMenuItem;
- ToolStripTextBox;
- ToolStripComboBox;
*/
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicWorks_AppMenuStrip
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
