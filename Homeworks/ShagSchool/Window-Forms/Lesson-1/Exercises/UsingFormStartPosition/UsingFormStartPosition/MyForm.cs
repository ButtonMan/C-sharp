using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingFormStartPosition
{
    class MyForm : Form
    {
        /// <summary>
        /// Конструктор подписывающий объект класса на событие 
        /// Click
        /// </summary>
        public MyForm()
        {
            Click += new EventHandler(ClickOnForme);
        }

        /// <summary>
        /// Метод обрабатывающий событие Click. Меняет позицию окна,
        /// координаты окна задаются случайным образом.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">объект EventArgs, не содержащий
        /// данных события</param>
        public void ClickOnForme(Object sender, EventArgs e)
        {
            int x, y;
            this.StartPosition = FormStartPosition.Manual;           
            x = new Random().Next(0, 1000);
            y = new Random().Next(0, 500);
            this.Location = new System.Drawing.Point(x,y);
        }
    }
}
