﻿//+-------------------------------------------------------------------+
//УСЛОВИЕ ЗАДАЧИ:
/*
Написать приложение, которое отображает количество текста,
прочитанного из файла с помощью ProgressBar.
*/
//+-------------------------------------------------------------------+

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometask_1
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
