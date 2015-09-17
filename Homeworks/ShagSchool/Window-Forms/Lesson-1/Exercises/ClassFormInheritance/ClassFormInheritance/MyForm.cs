//+---------------------------------------------------------------------------+
/*  КЛАСС MyForm:
 *  Класс отвечающий за создание пользовательской формы с заданным
 *  пользователем заголовком.
 */
//+---------------------------------------------------------------------------+

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassFormInheritance
{
    class MyForm : Form
    {

        /// <summary>
        /// Конструктор задающий заголовок окна
        /// </summary>
        /// <param name="caption">название заголовка окна</param>
        public MyForm(string caption)
        {
            this.Text = caption;
        }

    }
}
