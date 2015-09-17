//+---------------------------------------------------------------------------+
/*  Создание пользовательской формы с использование собственных классов 
 *  производных от класса FORM */
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace ClassFormInheritance
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Создание объекта пользовательской формы MyForm с 
            //вызовом конструктора в который передается текст заголовка
            MyForm myForm = new MyForm("Hello World!!! That`s my form!");


            //Отображение формы на экране.
            //Для этого используем метод для отображения модальных диалогов
            myForm.ShowDialog();

        }
    }
}
