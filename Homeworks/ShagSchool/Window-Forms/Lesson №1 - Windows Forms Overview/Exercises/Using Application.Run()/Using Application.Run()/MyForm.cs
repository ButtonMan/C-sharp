//+---------------------------------------------------------------------------+
/*  КЛАСС MyForm:
 *  Ползовательский класс, создающий форму с заданным пользователем 
 *  заголовком. */
//+---------------------------------------------------------------------------+

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunMethod
{
    class MyForm : Form
    {
        /// <summary>
        /// Конструктор, создающий форму с заданным 
        /// пользователем заголовком
        /// </summary>
        /// <param name="caption">текст заголовка формы</param>
        public MyForm(string caption)
        {
            this.Text = caption;
        }
    }
}
