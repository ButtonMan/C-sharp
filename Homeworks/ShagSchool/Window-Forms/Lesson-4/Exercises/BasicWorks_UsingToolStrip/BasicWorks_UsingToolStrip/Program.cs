//+---------------------------------------------------------------------------+
//УСЛОВИЕ ЗАДАЧИ:
/*
Создать панель инструментов. Разместить на ней по одному элементу из следующих
классов:
• ToolStripButton
• ToolStripSeparator
• ToolStripLabel
• ToolStripDropDownButton
• ToolStripSplitButton
• ToolStripTextBox
• ToolStripComboBox
*/
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicWorks_UsingToolStrip
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
