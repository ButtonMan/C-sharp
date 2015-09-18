//+---------------------------------------------------------------------------+
//УСЛОВИЕ:
/*
    - Создать окно содержащееся в себе два CheckedListBox.
    - Предусмотреть возможность добавления в один из CheckedListBox новых
    значений. Использовать для этого поле TextBox и кнопку подтверждения действия
    "добавить". 
    - Предусмотреть возможность копирования выбранных значений из одного 
    CheckedListBox в другой CheckedListBox. Для подтверждения выполнения 
    операции копирования использовать соответстующею кнопку
*/
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingCheckedListBox
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
