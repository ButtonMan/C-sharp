using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingMessageBox
{
    /// <summary>
    /// ПРОИЗВОДНЫЙ КЛАСС MyForm. 
    /// Управляет пользовательским окном приложения.
    /// </summary>
    class MyForm : Form 
    {
        /// <summary>
        /// Конструктор, объекта окна приложения. Создает объект окна с
        /// использованием заданного пользователем заголовка.
        /// </summary>
        /// <param name="caption">текстовый заголовок окна </param>
        public MyForm(string caption)
        {
            this.Text = caption;
            this.Click += new EventHandler (this.ClickHandler);
        }

        public void ClickHandler(Object sender, EventArgs e)
        {
            
            string message = null;  //идентификатор текстового сообщения
            DialogResult result;    //перечисление доступных в MessageBox кнопок
            string button = null;   //описание нажатой пользователем кнопки

            //показ окна, отображающего текстовое сообщение и кнопку ОК
            message = "Была нажата кнопка мыши";
            MessageBox.Show(message);

            //показ окна, отображающего текстовое сообщение и имеющего 
            //кнопки OK и CANSEL
            message = "Продолжить хаотичное кликанье в окне?";
            result = MessageBox.Show(text: message, caption: "Сделайте ваш выбор!",
                buttons: MessageBoxButtons.OKCancel);
            button = result.ToString();

            if (result == DialogResult.OK)
            {
                //показ окна отображающего текстовое сообщение и имеющего две
                //кнопки OK, CANSEL
                message = "Вы нажали кнопку " + button + "!. Вы уверенны что хотите повторить это веселье?)";
                result = MessageBox.Show(text: message, caption: "Запрос подтверждения",
                    buttons: MessageBoxButtons.OKCancel, icon: MessageBoxIcon.Warning);
            }

            //выход из приложения в случае если пользователь нажал кнопку CANSEL
            if (result == DialogResult.Cancel)
            {
                //освобождение ресурсов приложения
                this.Dispose();
            }
        }
    }
}
