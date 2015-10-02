//+---------------------------------------------------------------------------+
//УСЛОВИЕ ЗАДАЧИ:
/*
Написать приложение – анкету, которую предлагается заполнить пользователю, 
все данные отображаются на результирующем текстовом поле.
*/
//+---------------------------------------------------------------------------+



using Hometask_2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometask_2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            PersonData personData = new PersonData(); 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.FormMain(ref personData));
        }
    }
}
