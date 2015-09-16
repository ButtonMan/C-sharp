using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingDateTime
{
    public partial class FormWatch : Form
    {
        private Timer timer;        //таймер

        /// <summary>
        /// Конструктор окна FormWatch
        /// </summary>
        public FormWatch()
        {
            InitializeComponent();
            this.timer = new Timer();
            timer.Interval = 500;
            this.timer.Tick += new EventHandler(this.ShowTime);
            this.timer.Start();
        }

        /// <summary>
        /// Обработчик события таймера "timer"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ShowTime(Object sender, EventArgs e)
        {
            this.labelWatch.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
