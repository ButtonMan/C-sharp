using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingDateTimePicker
{
    class MyForm : Form
    {
        DateTimePicker dateTimePicker;

        /// <summary>
        /// Конструктор окна приложения
        /// </summary>
        public MyForm()
        {
            FormInitialization();
            DateTimePickerInitialization();
        }
        
        /// <summary>
        /// Создает главную форму приложения
        /// </summary>
        public void FormInitialization()
        {
            this.ClientSize = new Size(500, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Using DateTimePicker";
            this.BackColor = Color.Aquamarine;
        }

        /// <summary>
        /// Создает контроллер DateTimePicker
        /// </summary>
        public void DateTimePickerInitialization()
        {
            this.dateTimePicker = new DateTimePicker();
            int Y = (this.ClientSize.Height - this.dateTimePicker.Height) / 2;
            int X = (this.ClientSize.Width - this.dateTimePicker.Width) / 2;
            this.dateTimePicker.Location = new Point(X,Y);
            this.dateTimePicker.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker.ShowCheckBox = false;
            this.dateTimePicker.ShowUpDown = true;
            this.Controls.Add(dateTimePicker);
        }
    }
}
