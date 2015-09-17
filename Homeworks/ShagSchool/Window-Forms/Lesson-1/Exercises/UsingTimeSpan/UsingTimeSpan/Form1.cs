using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingTimeSpan
{
    public partial class MyDay : Form
    {

        StringBuilder value;            //текстовая строка для хранения
                                        //значений текущего времени

        /// <summary>
        /// Конструктор создающий окно и контроллеры Label
        /// </summary>
        public MyDay()
        {
            InitializeComponent();
            this.timer.Start();
            this.value = new StringBuilder(2);
            this.minutes.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Обработка события timer. При наступлении события,
        /// на экране отображается оставшееся до конца дня время.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ShowTime(Object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day + 1;
            DateTime newDate = new DateTime(year, month, day);
            TimeSpan span = newDate - DateTime.Now;
            this.value.Clear();
            this.hours.Text = value.Append(span.Hours).ToString();
            this.value.Clear();
            this.minutes.Text = value.Append(span.Minutes).ToString();
            this.value.Clear();
            this.seconds.Text = value.Append(span.Seconds).ToString();            
        }
    }
}
