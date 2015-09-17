using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingMouseMove
{
    //КЛАСС MyForm
    //+-----------------------------------------------------------------------+

    /// <summary>
    /// Класс обспечивающий взаимодействия пользователя с формой,
    /// при наведении мышью на которую, должен быть изменен цвет
    /// основы формы.
    /// </summary>
    class MyForm : Form
    {

        //КОНСТРУКТОРЫ КЛАССА:
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public MyForm()
        {
            this.Text = "Работа с событием MouseMove";
            this.Size = new Size(400, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            MouseMove += new MouseEventHandler(MouseOn);
        }




        //МЕТОДЫ КЛАССА:
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Метод вызываемый при наступлении события MouseMove.
        /// При движении мыши над окном рабочей области программы метод,
        /// меняет цвет основы окна. Цвет выбирается случайным образом.
        /// </summary>
        /// <param name="sender">источник события</param>
        /// <param name="e">объект класса MouseEventArgs</param>
        public void MouseOn(Object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            int r, g, b;
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            this.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
