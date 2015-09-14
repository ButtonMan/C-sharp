using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingEventHandlerClick
{
    /// <summary>
    /// Класс пользовательской формы, производной от класса Form
    /// </summary>
    class MyForm : Form
    {
        /// <summary>
        /// Конструктор класса, устанавливающий произволное название 
        /// заголовка
        /// </summary>
        /// <param name="caption">заголовок формы</param>
        public MyForm(string caption)
        {
            //установка заголовка окна
            this.Text = caption;

            //закрепление обработчика события
            Click += new EventHandler(ClickHandler);

        }

        /// <summary>
        /// Обработчик события Click
        /// </summary>
        /// <param name="sender">источник события</param>
        /// <param name="e">объект EventArgs, не содержащий данных события</param>
        public void ClickHandler(Object sender, EventArgs e)
        {
            MessageBox.Show("CLICK");
        }
    }
}
