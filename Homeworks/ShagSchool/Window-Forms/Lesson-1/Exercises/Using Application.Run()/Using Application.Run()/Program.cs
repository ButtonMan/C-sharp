//+---------------------------------------------------------------------------+
//  ЗАДАНИЕ:
/*  
    - Создать пользовательский класс формы
    - Использовать класс Application для запуска обработки очереди сообщений
      прилоржения и отображения пользовательской формы.
      Воспользуйтесь методом: Application.Run()
 */
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunMethod
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Создание объекта пользовательского класса формы
            //Запуск обработки очереди сообшений и отображение формы
            Application.Run(new MyForm("Hello world!!!"));
        }
    }
}
