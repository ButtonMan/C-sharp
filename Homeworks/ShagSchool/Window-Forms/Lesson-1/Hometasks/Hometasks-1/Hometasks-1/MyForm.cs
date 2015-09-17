using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometasks_1
{
    class MyForm : Form
    {
        Button ButtonStart;             ///кнопка Start

        /// <summary>
        /// Конструктор главного окна программы
        /// </summary>
        public MyForm()
        {
            this.FormInitialization();
            this.ButtonStartInitialization();
        }

        /// <summary>
        /// Создает окно главного окна программы
        /// </summary>
        public void FormInitialization()
        {
            this.Size = new Size(400, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = " Домашнее задание №1";
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        /// <summary>
        /// Создает кнопку Start расположенную в главном окне программы
        /// </summary>
        public void ButtonStartInitialization()
        {
            this.ButtonStart = new Button();
            this.ButtonStart.Size = new Size(100, 100);
            this.ButtonStart.Text = "START";
            this.ButtonStart.ForeColor = Color.White;
            this.ButtonStart.Font = new Font(FontFamily.GenericSansSerif, 
                12, FontStyle.Bold);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.BackColor = Color.LightPink;
            int X = (this.ClientSize.Width - this.ButtonStart.Width) / 2;
            int Y = (this.ClientSize.Height - this.ButtonStart.Height) / 2;
            this.ButtonStart.Location = new Point(X, Y);
            this.Controls.Add(this.ButtonStart);
            this.ButtonStart.Click += new EventHandler(ButtonStartClikOn);
        }

        /// <summary>
        /// Обработчик события нажатия кнопки Start.
        /// Выводит на экран инфо. сообщения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ButtonStartClikOn(Object sender, EventArgs e)
        {
            String fullName = "Мирошниченко Е.В.";
            String schoolName = "Шаг";
            String info = "пример испльзования контроллера MessageBox";
            int sumOfLetters = fullName.Length + schoolName.Length + 
                info.Length;
            MessageBox.Show(text: fullName, 
                            caption: "ФИО");
            MessageBox.Show(text: schoolName, 
                            caption: "НАЗВАНИЕ ШКОЛЫ");
            MessageBox.Show(text: info, 
                            caption: "ПРАКТИЧЕСКОЕ ЗАДАНИЕ");
            MessageBox.Show(text: "Задание выполнено", 
                            caption: "Среднее число символов - " + 
                            (sumOfLetters / 3).ToString());

        }


    }
}
