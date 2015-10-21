//+-------------------------------------------------------------------------------------+
//УСЛОВИЕ ЗАДАЧИ:
/*
Создать окно взаимодействующее с сервисом DragAndDrop. В текстовом окне,, разместить
текстовый блок RichTextBox, при перетаскивании в который файлов формата Rtf, 
обеспечить копирование содержимого перетянутого файла в текстовый блок RichTextBox.
*/
//+-------------------------------------------------------------------------------------+


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicWorks_DrugAndDrop
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
