using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometask_4.FORMS
{
    /// <summary>
    /// Класс FormMain
    /// Предназначение:
    /// Обеспечить возможность создания пользователем в окне, объектов  label
    /// производного размера, определяемого пользователем путем манипулирования
    /// мышью, а также получение информации о созданных объектах label и  
    /// возможность их удаления.
    /// </summary>
    class FormMain : Form
    {
        //ПОЛЯ КЛАССА
        //+-------------------------------------------------------------------+
        private static int labelCounter = 0; //счетчик созданных объектов Label
        private const string labelStandardName ="MainFormLabel-";//стандарт имя 
                                                                  //Label
        private Point labelStartPoint;       //данные о положении создаваемого
                                             //пользователем Label



        //КОНСТРУКТОРЫ КЛАССА
        //+-------------------------------------------------------------------+
        public FormMain()
        {
            this.FormeMainInitialization();
        }



        //МЕТОДЫ КЛАССА
        //+-------------------------------------------------------------------+
        /// <summary>
        /// Создает главное окно программы.
        /// </summary>
        private void FormeMainInitialization()
        {
            this.Size = new Size(500, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.DarkSlateGray;
            this.ForeColor = Color.White;
            this.Text = "Домашнее задание №4 (a,b,c,d)";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.DoubleBuffered = true;
            this.MouseDown += new MouseEventHandler(this.HandlerMouseDown);
            this.MouseMove += new MouseEventHandler(this.HandlerMouseMove);
            this.MouseUp += new MouseEventHandler(this.HandlerMouseUp);
        }
        /// <summary>
        /// Создает объект Label являющийся дочерним для главного окна
        /// FormeMain
        /// </summary>
        /// <param name="e">информация о мышином событии</param>
        private void LabelInitialization(MouseEventArgs e)
        {
            Label label = new Label();
            this.Controls.Add(label);
            label.MouseClick += new MouseEventHandler(this.HandlerMouseDown);
            label.MouseDoubleClick += new MouseEventHandler(
                this.HandlerMouseDoubleClick);
            label.Location = new Point(e.X, e.Y);
            label.Width = 0;
            label.Height = 0;
            labelStartPoint.X = label.Location.X;
            labelStartPoint.Y = label.Location.Y;
            label.Name = labelStandardName + (++labelCounter);
            label.BackColor = Color.FromArgb(this.BackColor.ToArgb() - 60);
        }
        /// <summary>
        /// Редактирует размер объекта Label отображаемого в главном окне 
        /// программы FormeMain
        /// </summary>
        /// <param name="e">информация о мыщином событии</param>
        private void LabelEditeSize(MouseEventArgs e)
        {
            Control[] labelControls = null;
            labelControls = this.Controls.Find(labelStandardName +
                labelCounter, true);
            if (labelControls != null)
            {
                if (e.X > labelStartPoint.X ||
                    e.Y > labelStartPoint.Y)
                {
                    labelControls[0].Width = e.X - labelStartPoint.X;
                    labelControls[0].Height = e.Y - labelStartPoint.Y;
                }
                if (e.X > labelStartPoint.X &&
                    e.Y < labelStartPoint.Y)
                {
                    labelControls[0].Left = labelStartPoint.X;
                    labelControls[0].Top = e.Y;
                    labelControls[0].Width = e.X - labelStartPoint.X;
                    labelControls[0].Height = labelStartPoint.Y - e.Y;   
                }
                if (e.X < labelStartPoint.X &&
                    e.Y > labelStartPoint.Y)
                {
                    labelControls[0].Left = e.X;
                    labelControls[0].Top = labelStartPoint.Y;
                    labelControls[0].Width = labelStartPoint.X - e.X;
                    labelControls[0].Height = e.Y - labelStartPoint.Y;
                }
                if (e.X < labelStartPoint.X &&
                    e.Y < labelStartPoint.Y)
                {
                    labelControls[0].Left = e.X;
                    labelControls[0].Top = e.Y;
                    labelControls[0].Width = labelStartPoint.X - e.X;
                    labelControls[0].Height = labelStartPoint.Y - e.Y;
                }
                labelControls[0].Refresh();
            }
        }
        /// <summary>
        /// Устанавливает размеры объекта Label равными минимальным размерам
        /// заданным пользователем (min Width = 10px; min Height = 10px)
        /// </summary>
        private void LabelSetMinSize()
        {
            Control[] labelControls = null;
            labelControls = this.Controls.Find(labelStandardName + labelCounter,
                true);
            if (labelControls != null)
            {
                if (labelControls[0].Width < 10 || labelControls[0].Height < 10)
                {
                    MessageBox.Show(text: "Минимальный допустимый размер " +
                                          "объекта 10*10 px ",
                                    caption: "Уведомление!",
                                    buttons: MessageBoxButtons.OK,
                                    icon: MessageBoxIcon.Exclamation,
                                    defaultButton: MessageBoxDefaultButton.Button1
                                    );
                    if (labelControls[0].Width < 10)
                    {
                        labelControls[0].Width = 10;
                    }
                    if (labelControls[0].Height < 10)
                    {
                        labelControls[0].Height = 10;
                    }
                }
            }
        }



        //ОБРАБОТЧИКИ СОБЫТИЙ КЛАССА
        //+-------------------------------------------------------------------+
        /// <summary>
        /// Обработка нажатия кнопки мыши вниз
        /// </summary>
        /// <param name="sender">информаия об объекте отправителе</param>
        /// <param name="e">информация о мышинос событии</param>
        private void HandlerMouseDown       (Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.LabelInitialization(e);
            }
            if (e.Button == MouseButtons.Right)
            {
                Label labelSelected = sender as Label;
                if (labelSelected != null)
                {
                    this.Text = "Площадь: " +
                        labelSelected.Width * labelSelected.Height +
                        " px " + Environment.NewLine + "Координаты : " +
                        "Х= " + labelSelected.Location.X + " " +
                        "Y= " + labelSelected.Location.Y;
                    Color colorNew = Color.FromArgb(this.BackColor.ToArgb() -
                        30);
                    labelSelected.BackColor = colorNew;
                }
            }
        }
        /// <summary>
        /// Обработка удержания кнопки мыши в нажатом состоянии
        /// </summary>
        /// <param name="sender">информаия об объекте отправителе</param>
        /// <param name="e">информация о мышинос событии</param>
        private void HandlerMouseMove       (Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.LabelEditeSize(e);
            }
        }
        /// <summary>
        /// Обработка отжатия кнопки мыши
        /// </summary>
        /// <param name="sender">информаия об объекте отправителе</param>
        /// <param name="e">информация о мышинос событии</param>
        private void HandlerMouseUp         (Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.LabelSetMinSize();
            }
        }
        /// <summary>
        /// Обработка двойного клика
        /// </summary>
        /// <param name="sender">информаия об объекте отправителе</param>
        /// <param name="e">информация о мышинос событии</param>
        private void HandlerMouseDoubleClick(Object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Label labelSelected = sender as Label;
                labelSelected.Dispose();
            }
        }

    }
}
