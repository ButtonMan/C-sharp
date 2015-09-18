using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometasks_3a
{
    /// <summary>
    /// Описание положения мыши в момент клика
    /// по отношению к воображаемому прямоугольнику
    /// </summary>
    enum MousePosition : int
    {
        InRectangle = 0,
        OutRectangle,
        OnBorder,
        Unknown,
    }

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
            this.Text = "Задание №3";
            this.BackColor = Color.DarkSlateGray;
            this.ForeColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MouseClick += new MouseEventHandler(FormMainClickOn);
        }

        /// <summary>
        /// Обрабоботчик события "нажатие левой кнопки мыши".
        /// В зависимости от координат курсора, в момент нажатия мыши
        /// выводит сообщения о положении курсора по отношению к 
        /// воображаемому прямоугольнику, расположенному в рабочей области 
        /// окна
        /// </summary>
        private void FormMainClickOn(Object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys != Keys.Control)
            {
                if (MouseButtons.Left == e.Button)
                {
                    switch (GetMousePosition(e))
                    {
                        case Hometasks_3a.MousePosition.OnBorder:
                            MessageBox.Show("Клик мыши сделан - НА ГРАНИЦЕ " +
                                "прямоугольника!", "Уведомление!",
                                MessageBoxButtons.OK);
                            break;
                        case Hometasks_3a.MousePosition.InRectangle:
                            MessageBox.Show("Клик мыши сделан - ВНУТРИ " +
                                 "прямоугольника!", "Уведомление!",
                                 MessageBoxButtons.OK);
                            break;
                        case Hometasks_3a.MousePosition.OutRectangle:
                            MessageBox.Show("Клик мыши сделан - ВНЕ " +
                                "прямоугольника!", "Уведомление!",
                                MessageBoxButtons.OK);
                            break;
                        case Hometasks_3a.MousePosition.Unknown:
                            MessageBox.Show("Позиция курсора мыши," +
                                "НЕ ОПРЕДЕЛЕНА", "Уведомление!",
                                MessageBoxButtons.OK);
                            break;
                    }
                }
            }
            else
            {
                if (MouseButtons.Left == e.Button)
                {
                    this.Dispose();
                }
            }
        }

        /// <summary>
        /// Определяет положение курсора в момент нажатия левой кнопки мыши
        /// </summary>
        /// <param name="e">объект MouseEventArgs</param>
        /// <returns>перечисление MousePosition</returns>
        private Hometasks_3a.MousePosition GetMousePosition(MouseEventArgs e)
        {
            int top, right, bottom, left;
            top = this.ClientRectangle.Top + 10;
            right = this.ClientRectangle.Right - 10;
            bottom = this.ClientRectangle.Bottom - 10;
            left = this.ClientRectangle.Left + 10;
            if (e.Y < top || e.X > right || e.Y > bottom || e.X < left)
            {
                return Hometasks_3a.MousePosition.OutRectangle;
            }
            else
            {
                if (e.Y > top || e.X < right || e.Y < bottom || e.X > left)
                {
                    return Hometasks_3a.MousePosition.InRectangle;
                }
                else
                {
                    if (e.Y == top || e.X == right || e.Y == bottom || e.X == left)
                    {
                        return Hometasks_3a.MousePosition.OnBorder;
                    }
                    else
                    {
                        return Hometasks_3a.MousePosition.Unknown;
                    }
                }
            }
        }
    }
}