using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hometask_6.FORMS
{
    class FormMain : Form
    {
        System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("ru-RU");

        //ДОЧЕРНИЕ КОНТРОЛЛЕРЫ КЛАССА
        //+-------------------------------------------------------------------+
        private Label labelDayWeekInfo = null;
        private Label labelDayWeekResult = null;
        private Label labelMonthCalendar = null;
        private MonthCalendar monthCalendar = null;



        //КОНСТРУКТОРЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Cоздание окна и всех его дочерних контроллеров.
        /// Подкиска обработчиков на события.
        /// </summary>
        public FormMain()
        {
            this.FormMainInitialization();
            this.MonthCalendarInitialization();
            this.LabelMonthCalendarInitialization();
            this.LabelDayWeekInfoInitialization();
            this.LabelDayWeekResultInitialization();
            this.SetControls();
            this.SetEvents();
        }



        //МЕТОДЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Создание главного окна программы
        /// </summary>
        private void FormMainInitialization()
        {
            this.ClientSize = new Size(400, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackColor = Color.DarkSlateGray;
            this.ForeColor = Color.White;
            this.Text = "Домашенее задание №6";
        }

        /// <summary>
        /// Создание котноллера MonthCalendar
        /// </summary>
        private void MonthCalendarInitialization()
        {
            this.monthCalendar = new MonthCalendar();
            this.monthCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Right |
                AnchorStyles.Bottom | AnchorStyles.Left;
            int x = (this.ClientRectangle.Width - this.monthCalendar.Width) / 2;
            int y = (this.ClientRectangle.Height - this.monthCalendar.Height) / 2;
            this.monthCalendar.Location = new Point(x, y);
        }

        /// <summary>
        /// Создание текстовой метки с сопроводительным текстом к контроллеру
        /// MonthCalendar
        /// </summary>
        private void LabelMonthCalendarInitialization()
        {
            this.labelMonthCalendar = new Label();
            this.labelMonthCalendar.AutoSize = true;
            this.labelMonthCalendar.Text = "Выберите дату:";
            int x = this.monthCalendar.Location.X;
            int y = this.monthCalendar.Location.Y - 20;
            this.labelMonthCalendar.Location = new Point(x, y);
        }

        /// <summary>
        /// Создание текстовой метки с сопроводительным текстом к отображаемому названию дня недели
        /// в метке  LabelDayWeekResul
        /// </summary>
        private void LabelDayWeekInfoInitialization()
        {
            this.labelDayWeekInfo = new Label();
            int x = this.monthCalendar.Location.X;
            int y = this.monthCalendar.Location.Y - 77;
            this.labelDayWeekInfo.Location = new Point(x, y);
            this.labelDayWeekInfo.Text = "День недели: ";
            this.labelDayWeekInfo.Visible = false;
            this.labelDayWeekInfo.Padding = new Padding(0);
            this.labelDayWeekInfo.Margin = new Padding(0);
        }

        /// <summary>
        /// Создание текстовой метки содержащей название дня недели выбранного 
        /// пользователем с помощью контроллера MonthCalendar
        /// </summary>
        private void LabelDayWeekResultInitialization()
        {
            this.labelDayWeekResult = new Label();
            this.labelDayWeekResult.AutoSize = true;
            int x = this.monthCalendar.Left;
            int y = this.monthCalendar.Top - 60;
            this.labelDayWeekResult.Location = new Point(x, y);
            this.labelDayWeekResult.Text = "СУББОТА";
            this.labelDayWeekResult.Font = new Font(FontFamily.GenericSansSerif, 
                20);
            this.labelDayWeekResult.Visible = false;
        }

        /// <summary>
        /// Присоединяет к главному окну программы контроллеры
        /// </summary>
        private void SetControls()
        {
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.labelMonthCalendar);
            this.Controls.Add(this.labelDayWeekInfo);
            this.Controls.Add(this.labelDayWeekResult);
        }

        /// <summary>
        /// Подписка на события обработчиков событий
        /// </summary>
        private void SetEvents()
        {
            this.monthCalendar.DateSelected += new DateRangeEventHandler(
                MonthCalendarDateSelected);
        }



        //ОБРАБОТЧИК СОБЫТИЯ
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Обработка события "выбор даты" в календаре объекта класса 
        /// MonthCalendar.
        /// </summary>
        private void MonthCalendarDateSelected(Object sender, EventArgs e)
        {
            this.labelDayWeekInfo.Visible = true;
            this.labelDayWeekResult.Text = this.culture.DateTimeFormat.
                GetDayName(this.monthCalendar.SelectionStart.DayOfWeek);
            this.labelDayWeekResult.Visible = true;
        }
    }
}
