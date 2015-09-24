using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometask_7
{
    public partial class FormMain : Form
    {
        //КОНСТРУКТОРЫ КЛАССА
        //+-------------------------------------------------------------------+
        public FormMain()
        {
            InitializeComponent();
            this.DateTimePickerInitialize();
            this.ButtonConfirmInitialize();
        }



        //МЕТОДЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Настройка параметров контроллера DateTimePicker
        /// </summary>
        private void DateTimePickerInitialize()
        {
            this.dateTimePicker.MinDate = DateTime.Today;
            this.dateTimePicker.Select();
        }
        /// <summary>
        /// Настройка параметров контроллера RadioButtonYears
        /// </summary>
        private void RadioButtonYearsInitialize()
        {
            this.radioButtonYears.Checked = true;
        }
        /// <summary>
        /// Настройка параметров кнопки ButtonConfirm
        /// </summary>
        private void ButtonConfirmInitialize()
        {
            this.buttonConfirm.Enabled = false;
        }
        /// <summary>
        /// Расчет количества Milliseconds в году
        /// </summary>
        /// <param name="year">год</param>
        /// <returns>количества Milliseconds в году в выбранном пользователем
        /// году</returns>
        private double TotalMilliseconds(int year)
        {
            return (DateTime.IsLeapYear(year) ? 365D : 364D) *
                        24D * 60D * 60D * 1000D;
        }

        /// <summary>
        /// Расчет разницы между двумя датами.
        /// Результат расчитывается в годах.
        /// </summary>
        /// <param name="start">Начальная дата</param>
        /// <param name="end">Конечная дата</param>
        /// <returns>количество лет</returns>
        private double GetDifferenceInYears(DateTime start, DateTime end)
        {


            if (start.Year == end.Year)
            {
                return ((end - start).Duration()).TotalMilliseconds /
                        this.TotalMilliseconds(start.Year);
            }
            else
            {
                double msTotalStartYear = TotalMilliseconds(start.Year);
                double msTotalEndYear = TotalMilliseconds(end.Year);
                DateTime endYearDate = new DateTime(start.Year + 1, 1, 1, 0, 0, 0, 0);
                DateTime startYearDate = new DateTime(end.Year, 1, 1, 0, 0, 0, 0);
                if (Math.Abs(end.Year - start.Year) == 1)
                {
                    return ((end - startYearDate).Duration()).TotalMilliseconds /
                        msTotalStartYear + ((endYearDate - start).Duration()).TotalMilliseconds /
                        msTotalEndYear;
                }
                else
                {
                    return Math.Abs(end.Year - start.Year) - 1 +
                        ((end - startYearDate).Duration()).TotalMilliseconds /
                        msTotalStartYear + ((endYearDate - start).Duration()).TotalMilliseconds /
                        msTotalEndYear;
                }
            }
        }
        /// <summary>
        /// Расчет разницы между двумя датами.
        /// Результат расчитывается в месяцах.
        /// </summary>
        /// <param name="start">Начальная дата</param>
        /// <param name="end">Конечная дата</param>
        /// <returns>количество месяцев</returns>
        private double GetDifferenceInMonths(DateTime start, DateTime end)
        {
            if(start.Year == end.Year)
            {
                if(start.Month == end.Month)
                {
                    return (double)(Math.Abs(end.Day - start.Day)) /
                        DateTime.DaysInMonth(start.Year, start.Month);
                }
                else
                {
                    if(start.Month + 1 == end.Month)
                    {
                        return (double)(DateTime.DaysInMonth(start.Year, start.Month) -
                            start.Day) / DateTime.DaysInMonth(start.Year, start.Month)
                            + ((double)end.Day / DateTime.DaysInMonth(end.Year, end.Month));
                    }
                    else
                    {
                        return (double)(DateTime.DaysInMonth(start.Year, start.Month) -
                            start.Day) / DateTime.DaysInMonth(start.Year, start.Month)
                            + ((double)end.Day / DateTime.DaysInMonth(end.Year, end.Month)) + 
                            (end.Month - start.Month) - 1;
                    }
                }
            }
            else
            {
                if(start.Year + 1 == end.Year)
                {
                    return (double)(DateTime.DaysInMonth(start.Year, start.Month) -
                        start.Day) / DateTime.DaysInMonth(start.Year, start.Month) +
                        (12 - start.Month - 1) + (end.Month - 1) + 
                        ((double)end.Day / DateTime.DaysInMonth(end.Year, end.Month));
                }
                else
                {
                    return (double)(DateTime.DaysInMonth(start.Year, start.Month) -
                        start.Day) / DateTime.DaysInMonth(start.Year, start.Month) +
                        (12 - start.Month - 1) + ((end.Year - start.Year - 1) * 12) + 
                        (end.Month - 1) + ((double)end.Day / DateTime.DaysInMonth(end.Year, 
                        end.Month));
                }
            }
        }
        /// <summary>
        /// Расчет разницы между двумя датами.
        /// Результат расчитывается в днях.
        /// </summary>
        /// <param name="start">Начальная дата</param>
        /// <param name="end">Конечная дата</param>
        /// <returns>количество дней</returns>
        private double GetDifferenceInDays(DateTime start, DateTime end)
        { 
                return Math.Abs((end - start).TotalDays);
        }
        /// <summary>
        /// Расчет разницы между двумя датами.
        /// Результат расчитывается в минутах.
        /// </summary>
        /// <param name="start">Начальная дата</param>
        /// <param name="end">Конечная дата</param>
        /// <returns>количество минут</returns>
        private double GetDifferevnceInMinutes(DateTime start, DateTime end)
        {
            return Math.Abs((end - start).TotalMinutes);
        }
        /// <summary>
        /// Расчет разницы между двумя датами.
        /// Результат расчитывается в секундах.
        /// </summary>
        /// <param name="start">Начальная дата</param>
        /// <param name="end">Конечная дата</param>
        /// <returns>количество секунд</returns>
        private double GetDifferenceInSeconds(DateTime start, DateTime end)
        {
            return Math.Abs((end - start).TotalSeconds);
        }
        /// <summary>
        /// Расчет разницы между двумя датами.
        /// С учетом выбранных пользователем параметров:
        /// - дата в контроллере MonthCalendar
        /// - масштаб времен, выбранный в контроллере GroupBox
        /// </summary>
        /// <param name="radioButton">объект класса RadioButton</param>
        /// <param name="date">дата выбранная в контроллере MonthCalendar</param>
        /// <returns>оставшееся количество времени до указанной пользователем 
        /// даты</returns>
        private string GetResidueTime(RadioButton radioButton, DateTime date)
        {
            string result = null;
            if (radioButton != null)
            {
                switch (radioButton.Name)
                {
                    case "radioButtonYears":
                        result = this.GetDifferenceInYears(DateTime.Now, date).ToString();
                        break;
                    case "radioButtonMonths":
                        result = this.GetDifferenceInMonths(DateTime.Now, date).ToString();
                        break;
                    case "radioButtonDays":
                        result = this.GetDifferenceInDays(DateTime.Now, date).ToString();
                        break;
                    case "radioButtonMinutes":
                        result = this.GetDifferevnceInMinutes(DateTime.Now, date).ToString();
                        break;
                    case "radioButtonSeconds":
                        result = this.GetDifferenceInSeconds(DateTime.Now, date).ToString();
                        break;
                }
            }
            return result;
        }
        /// <summary>
        /// Определяет нажатую пользователем кнопку RadioButton
        /// </summary>
        /// <returns>объект класса RadioButton в котором свойство 
        /// Checked = true</returns>
        private RadioButton GetCheckedRadioButton()
        {
            RadioButton result = null;
            Control.ControlCollection controls = this.groupBoxTimeStyle.Controls;
            for (int i = 0; i < this.groupBoxTimeStyle.Controls.Count; ++i)
            {
                result = controls[i] as RadioButton;
                if (result != null)
                {
                    if (result.Checked)
                    {
                        return result;
                    }
                }
            }
            return null;
        }


        //ОБРАБОТЧИКИ СОБЫТИЙ
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Обработка нажатия кнопки "Подтвердить"
        /// </summary>
        private void HandlerButtonConfirmClick(Object sender, EventArgs e)
        {
            RadioButton radioButton = null; //нажатый переключатель
            DateTime dateTime;              //введенная пользователем дата
            string residueTime = null;      //остаток времени
            Control.ControlCollection controlCollection = null;
            
            radioButton = this.GetCheckedRadioButton();
            dateTime = this.dateTimePicker.Value;
            residueTime = GetResidueTime(radioButton, dateTime);

            if (residueTime != null)
            {
                controlCollection = this.panelTimeLeftInfo.Controls;
                for (int i = 0; i < controlCollection.Count; ++i)
                {
                    if (controlCollection[i].Name == "labelTimeLeft")
                    {
                        controlCollection[i].Text = residueTime;
                    }
                }
            }
            else
            {
                MessageBox.Show("Не выбранно значение формата времени!");
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Выйти"
        /// </summary>
        private void HandlerButtonCanselClick(Object sender, EventArgs e)
        {
            this.Dispose();
        }
        /// <summary>
        /// Обработка события закрытия объекта календарь
        /// </summary>
        private void DateTimePickeCloseUp(Object sender, EventArgs e)
        {
            this.buttonConfirm.Enabled = true;
        }
        /// <summary>
        /// Обработка события изменения значения в объекте календарь
        /// </summary>
        private void DateTimePickeValueChenged(Object sender, EventArgs e)
        {
            this.buttonConfirm.Enabled = true;
        }
    }
}
