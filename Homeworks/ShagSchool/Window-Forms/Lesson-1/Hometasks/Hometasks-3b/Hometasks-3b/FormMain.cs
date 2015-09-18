using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometasks_3b
{
    /// <summary>
    /// Главное окно программы
    /// </summary>
    class FormMain : Form
    {
        /// <summary>
        /// Конструкто главного окна программы
        /// </summary>
        public FormMain()
        {
            this.FormMainInitialization();
        }

        /// <summary>
        /// Создает главное окно программы 
        /// </summary>
        private void FormMainInitialization()
        {
            this.ClientSize = new Size(400, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Задание №3b";
            this.BackColor = Color.DarkSlateGray;
            this.ForeColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MouseClick += new MouseEventHandler(FormMainClickOn);
        }

        /// <summary>
        /// Обработчик события "Нажатие правой кнопки мыши".
        /// Выводит в заголовок окна, размеры, рабочей области окна.
        /// </summary>
        private void FormMainClickOn(Object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                this.Text = "Высота: " + this.ClientSize.Height + " " +
                    "Ширина: " + this.ClientSize.Width;
            }
        }
    }
}
