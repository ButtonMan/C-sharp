//+-------------------------------------------------------------------+
//УСЛОВИЕ ЗАДАЧИ:
/*
Разработать приложение "убегающий статик" :). Суть приложения:
на форме расположен статический элемент управления ("статик").
Пользователь пытается подвести курсор мыши к "статику", и, если
курсор находиться близко со статиком, элемент управления "убега
ет". Предусмотреть перемещение "статика" только в пределах формы. 
*/
//+-------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometask_5
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
            Application.Run(new Hometask_5.FORMS.FormMain());
        }
    }
}
