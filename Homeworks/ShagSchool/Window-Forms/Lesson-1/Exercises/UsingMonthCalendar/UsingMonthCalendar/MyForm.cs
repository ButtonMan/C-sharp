using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingMonthCalendar
{
    class MyForm : Form
    {
        MonthCalendar monthCalendar;

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public MyForm()
        {
            this.FormInitialization();
            this.MonthCalendarInitialization();
        }

        /// <summary>
        /// Создает Форму окна приложения 
        /// с заданными характеристиками
        /// </summary>
        private void FormInitialization()
        {
            this.ClientSize = new Size(400,400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Bisque;
            this.Text = "Использование контроллера MonthCalendar";
        }

        /// <summary>
        /// Создает контроллер MonthCalendar с заданными характеристиками
        /// </summary>
        private void MonthCalendarInitialization()
        {
            this.monthCalendar = new MonthCalendar();
            int X = (this.ClientSize.Width - this.monthCalendar.Width) / 2;
            int Y = (this.ClientSize.Height - this.monthCalendar.Height) / 2;
            this.monthCalendar.Location = new Point(X, Y);
            this.monthCalendar.ShowToday = true;
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.ShowWeekNumbers = true;
            this.Controls.Add(this.monthCalendar);
        }
    }
}
