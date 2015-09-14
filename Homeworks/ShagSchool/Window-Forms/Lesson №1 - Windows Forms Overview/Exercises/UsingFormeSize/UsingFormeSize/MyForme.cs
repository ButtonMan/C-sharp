using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingFormeSize
{
    class MyForme : Form
    {
        /// <summary>
        /// Конструктор пользовательского окна программы
        /// </summary>
        public MyForme()
        {
            //подписка на событие клика
            Click += new EventHandler(ClickOnForm);
        }

        /// <summary>
        /// Обработка события Click
        /// </summary>
        /// <param name="sender">источник события</param>
        /// <param name="e">объект EventArgs, не содержащий, 
        /// данных события </param>
        public void ClickOnForm(Object sender, EventArgs e)
        {
            int x, y;
            x = y = (new Random()).Next(150, 800);
            Size newSize = new Size(x, y);
            this.Size = newSize;
        }
    }
}
