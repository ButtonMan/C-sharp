using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometasks_3c
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
            this.Text = "Задание №3c";
            this.BackColor = Color.DarkSlateGray;
            this.ForeColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MouseMove += new MouseEventHandler(FormMainMouseMove);
        }

        /// <summary>
        /// Обработчик события "движение мыши".
        /// Выводит в заголовок координаты мыши.
        /// </summary>
        private void FormMainMouseMove(Object sender, MouseEventArgs e)
        {
            this.Text = "Координаты мыши: X =  " + e.X + " Y = " + e.Y;
        }
    }
}
