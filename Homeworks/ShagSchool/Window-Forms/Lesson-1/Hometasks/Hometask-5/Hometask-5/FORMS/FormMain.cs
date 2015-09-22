using Hometask_5.ENUMS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometask_5.FORMS
{
    class FormMain : Form
    {
        //ПОЛЯ КЛАССА
        //+-------------------------------------------------------------------+
        private Label FormMainLabel = null;     //текстовая метка
        private Random rnd = new Random();      //генератор случайных чисел
        private delegate int GetX(int i);       //делегат, осуществляющий
                                                //расчет координаты X



        //КОНСТРУКТОРЫ КЛАССА
        //+-------------------------------------------------------------------+
        public FormMain()
        {
            this.FormMainInitialization();
            this.LabelInitialization();
            this.SetControls();
            this.SetEvents();
        }



        //МЕТОДЫ КЛАССА
        //+-------------------------------------------------------------------+       
        /// <summary>
        /// Создание дизайна главного окна программы
        /// </summary>
        private void FormMainInitialization()
        {
            this.ClientSize = new Size(600, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.DarkSlateGray;
            this.ForeColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Домашнее задание №5";
            this.DoubleBuffered = true;
        }

        /// <summary>
        /// Создание дизайне объекта "Label"
        /// </summary>
        private void LabelInitialization()
        {
            this.FormMainLabel = new Label();
            this.FormMainLabel.Size = new Size(100, 100);
            int x = (this.ClientSize.Width - this.FormMainLabel.Width) / 2;
            int y = (this.ClientSize.Height - this.FormMainLabel.Height) / 2;
            this.FormMainLabel.Location = new Point(x, y);
            this.FormMainLabel.BackColor = Color.FromArgb(this.BackColor.ToArgb() -
                30);
            this.FormMainLabel.Text = "(-.-)"; //смайл;
            this.FormMainLabel.Font = new Font(FontFamily.GenericSansSerif, 18, FontStyle.Bold);
            this.FormMainLabel.TextAlign = ContentAlignment.MiddleCenter;
        }

        /// <summary>
        /// Подключение к главному окну дочерних контроллеров
        /// </summary>
        private void SetControls()
        {
            this.Controls.Add(this.FormMainLabel);
        }

        /// <summary>
        /// Подключение событий
        /// </summary>
        private void SetEvents()
        {
            this.MouseMove += new MouseEventHandler(this.HandlerMouseMove);
        }

        /// <summary>
        /// Гнерирует эмоции убегающего объекта в виде смайликов.
        /// Эмоция зависит от расстояния от мыши до объекта Label
        /// </summary>
        /// <param name="e">информация о стостянии курсора</param>
        private void GetEmotions(MouseEventArgs e)
        {
            int left, top, right, bottom;
            left = this.FormMainLabel.Left;
            top = this.FormMainLabel.Top;
            right = this.FormMainLabel.Right;
            bottom = this.FormMainLabel.Bottom;
            if (e.X >= left - 50 && e.X <= right + 50 &&
                e.Y <= bottom + 50 && e.Y > top - 50)
            {
                this.FormMainLabel.Text = "(@.@)";
            }
            else
            {
                if (e.X >= left - 100 && e.X <= right + 100 &&
                    e.Y <= bottom + 100 && e.Y > top - 100)
                {
                    this.FormMainLabel.Text = "(O.O)";
                }
                else
                {
                    if (e.X >= left - 200 && e.X <= right + 200 &&
                    e.Y <= bottom + 200 && e.Y > top - 200)
                    {
                        this.FormMainLabel.Text = "(=.=)";
                    }
                    else
                    {
                        this.FormMainLabel.Text = "(-.-)";
                    }
                }
            }
        }

        /// <summary>
        /// Генерирует случайную точку в пределах рабочей области
        /// главного окна программы
        /// </summary>
        /// <returns>сгенерированный случайным образом объект класса
        ///  Point</returns>
        private Point GetRandomPoint()
        {
            int minX = this.ClientRectangle.Left;
            int maxX = this.ClientRectangle.Right - this.FormMainLabel.Width;
            int minY = this.ClientRectangle.Top;
            int maxY = this.ClientRectangle.Bottom - this.FormMainLabel.Height;
            int X = this.rnd.Next(minX, maxX);
            int Y = this.rnd.Next(minY, maxY);
            Point Result = new Point(X, Y);
            return Result;
        }

        /// <summary>
        /// Вычисляет координаты точек лежащих не линии соеденяющей между 
        /// собой две произвольные точки.
        /// </summary>
        /// <param name="oldPoint">произвольная точка рабочей области окна</param>
        /// <param name="newPoint">произвольная точка рабочей области окна</param>
        /// <param name="i">смещение по оси Х от точки oldPoint в сторону точки
        /// newPoint</param>
        /// <returns></returns>
        private Point PredictPointAtLine(Point oldPoint, Point newPoint, int i)
        {

            Point Result = new Point();
            GetX X;
            if (newPoint.X < oldPoint.X)
            {
                X = delegate (int value)
                {
                    return oldPoint.X - i;
                };
            }
            else
            {
                X = delegate (int value)
                {
                    return oldPoint.X + i;
                };
            }
            Result.X = X(i);
            Result.Y = (((Result.X - oldPoint.X) * (newPoint.Y - oldPoint.Y)) /
                    (newPoint.X - oldPoint.X)) + oldPoint.Y;
            return Result;
        }

        /// <summary>
        /// Выполняет перемещение объекта Label в приделах рабочей
        /// области окна
        /// </summary>
        /// <param name="e">информация о стостоянии курсора</param>
        private void GetMove(MouseEventArgs e)
        {
            Point newPoint = GetRandomPoint();            //цель перемещения
            Point oldPoint = this.FormMainLabel.Location; //текущее положение
            Point prePoint;                               //точка лежащая на 
                                                          //линии между 
                                                          //oldPoint и newPoint
            int distanсe;                              //размер проекции между
                                                          //точками oldPoint и 
                                                          //newPoint на оси Х
            distanсe = Math.Abs(newPoint.X - oldPoint.X);

            for(int i = 1; i < distanсe; ++i)
            {
                System.Threading.Thread.Sleep(5);
                prePoint = PredictPointAtLine(oldPoint, newPoint, i);
                this.FormMainLabel.Left = prePoint.X;
                this.FormMainLabel.Top = prePoint.Y;
                this.Refresh();
            }
        }



        //ОБРАБОТЧИКИ СОБЫТИЙ
        //+-------------------------------------------------------------------+
        /// <summary>
        /// Обрабатывает событие движения мыши по рабочей области главного
        /// окна. В случае если мышь приближается к объекту Label, достаточно
        /// близко, перемещает его в случайным образом сгенерированную точку,
        /// лежащую в пределах рабочей области главного окна программы.
        /// </summary>
        private void HandlerMouseMove(Object sender, MouseEventArgs e)
        {
            this.GetEmotions(e);
            Point labelCenter = new Point();
            labelCenter.X = this.FormMainLabel.Left + this.FormMainLabel.Width / 2;
            labelCenter.Y = this.FormMainLabel.Top + this.FormMainLabel.Height / 2;
            if (Math.Abs(labelCenter.X - e.X) <= 100 &&
                Math.Abs(labelCenter.Y - e.Y) <= 100)
            {
                this.GetMove(e);
            }
        }

    }
}
