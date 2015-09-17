using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace UsingTimer
{
    //КЛАСС MyForm
    //+-----------------------------------------------------------------------+

    /// <summary>
    /// Класс MyForm
    /// Отвечает за звамодействие пользователя с таймером обработного
    /// отсчета через формы.
    /// </summary>
    class MyForm : Form
    {
        //ПОЛЯ КЛАССА:
        //+-------------------------------------------------------------------+

        private Timer timer = new Timer();          // таймер приложения
        private Label info;                         // текстовая инструкция
        private Button buttonStart;                 // кнопка старт         
        private Button buttonStop;                  // кнопка стоп 
        private NumericUpDown numSeconds;           // количество секунд



        //КОНСТРУКТОРЫ КЛАССА:
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Создает объект класса MyForm и его котроллеры.
        /// </summary>
        public MyForm()
        {
            this.SetMyForm();
            this.SetButtonStart();
            this.SetButtonStop();
            this.SetInfo();
            this.SetNumeric();
            this.SetTimer();
        }



        //МЕТОДЫ КЛАССА:
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Создание форму MyForm
        /// </summary>
        public void SetMyForm()
        {
            this.Text = "Работа с таймером";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightGray;
            this.Size = new Size(400, 400);
        }

        /// <summary>
        /// Создает в форме инфо. надпись
        /// </summary>
        public void SetInfo()
        {
            this.info = new Label();
            this.Controls.Add(this.info);
            this.info.AutoSize = true;
            this.info.Location = new Point(50,115);
            this.info.Text = "Количество секунд работы таймера";
            this.info.Name = "info";
        }

        /// <summary>
        /// Создает кнопку "Старт"
        /// </summary>
        public void SetButtonStart()
        {
            this.buttonStart = new Button();
            buttonStart.Text = "Start";
            buttonStart.Location = new Point(100, 250);
            this.Controls.Add(buttonStart);
            this.buttonStart.Click += new EventHandler(PushButtonStart);
        }

        /// <summary>
        /// Создает кнопку "Стоп"
        /// </summary>
        public void SetButtonStop()
        {
            this.buttonStop = new Button();
            this.Controls.Add(buttonStop);
            this.buttonStop.Text = "Stop";
            this.buttonStop.Location = new Point(200, 250);
            this.buttonStop.Enabled = false;
            this.buttonStop.Click += new EventHandler(PushButtonStop);
        }

        /// <summary>
        /// Создание объекта таймера и подиска на его событие
        /// </summary>
        public void SetTimer()
        {
            this.timer = new Timer();
            this.timer.Tick += new EventHandler(this.GetTimerMessage);
        }

        /// <summary>
        /// Создание контроллера NumericUpDown
        /// </summary>
        public void SetNumeric()
        {
            numSeconds = new NumericUpDown();
            this.numSeconds.Location = new System.Drawing.Point(260, 112);
            this.numSeconds.Name = "numSeconds";
            this.numSeconds.Size = new System.Drawing.Size(74, 20);
            this.numSeconds.TabIndex = 3;
            this.Controls.Add(this.numSeconds);
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Старт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PushButtonStart(Object sender, EventArgs e)
        {
            if(this.numSeconds.Value == 0)
            {
                MessageBox.Show("Количество секунд должно быть больше 0!");
            }
            else
            {
                this.buttonStart.Enabled = false;
                this.buttonStop.Enabled = true;
                this.timer.Interval = decimal.ToInt32(this.numSeconds.Value) * 
                    1000;
                this.timer.Start();
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Стоп"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PushButtonStop(Object sender, EventArgs e)
        {
            this.buttonStop.Enabled = false;
            MessageBox.Show("Таймер не успел отработать!", "Таймер");
            this.timer.Stop();

        }

        /// <summary>
        /// Обработчик события окончания времения таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void GetTimerMessage(Object sender, EventArgs e)
        {
            this.timer.Stop();
            this.buttonStart.Enabled = true;
            this.buttonStop.Enabled = false;
            MessageBox.Show("Таймер отработал!","Таймер");
        }



        //ДЕСТРУКТОР КЛАССА:
        //+-------------------------------------------------------------------+

        ~MyForm()
        {
            if (timer != null)
            {
                timer.Stop();
            }
        }
    }
}
