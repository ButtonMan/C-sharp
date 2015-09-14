using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_Form_ShowDialog
{
    /// <summary>
    /// Класс MyForm.
    /// Реазлизует пример модального окна.
    /// </summary>
    class MyForm : Form
    {
        /// <summary>
        /// Конструктор класса, создающий главное оконо программы
        /// </summary>
        public MyForm()
        {
            this.Text = "Главное окно";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.Size = new Size(500, 500);
            Click += new EventHandler(ClickOn);
        }

        /// <summary>
        /// Метод выполняется после осуществление клика мыши в пределах
        /// рабочей области окна. В ответ, метод создает модальное
        /// и немодальное оконоб
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">объект класса EventArgs</param>
        public void ClickOn(Object sender, EventArgs e)
        {
            //создание примера модального окна всплывающего
            //после клика мышью в теле главного окна программы
            MyForm Modalwnd = new MyForm();
            Modalwnd.Text = "Пример Модального Окна";
            Modalwnd.BackColor = Color.Red;
            Modalwnd.Size = new Size(250, 250);
            Modalwnd.ShowDialog();
            Modalwnd.Dispose();

            //создание примера модального окна всплывающего
            //после клика мышью в теле главного окна программы
            MyForm NotModalWnd = new MyForm();
            NotModalWnd.Text = "Пример Модального Окна";
            NotModalWnd.BackColor = Color.Green;
            NotModalWnd.Size = new Size(250, 250);
            NotModalWnd.Show();

        }
    }
}
