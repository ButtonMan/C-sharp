using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingFormBackColor
{
    /// <summary>
    /// Класс MyForm. 
    /// Экземпляр объекта класса окна изменяет цвет, в случае осущствления пользователем клика
    /// в пределах рабочей области окна приложения
    /// </summary>
    class MyForm : Form
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public MyForm()
        {
            Click += new EventHandler(ClickOnForm);
        }

        /// <summary>
        /// Изменяет цвет фона при наступлении события Click
        /// в рабочей области окна приложения.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Объект класса EventArgs</param>
        public void ClickOnForm(Object sender, EventArgs e)
        {
            //создание генератора случайных чисел
            Random rnd = new Random();
            int red = rnd.Next(0, 255);
            int green = rnd.Next(0, 255);
            int blue = rnd.Next(0, 255);

            //изменение цвета фона
            this.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
