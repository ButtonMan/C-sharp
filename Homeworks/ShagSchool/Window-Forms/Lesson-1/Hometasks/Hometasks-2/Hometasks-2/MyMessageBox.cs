using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometasks_2
{
    class MyMessageBox : Form
    {
        private int number;                 //загаданное пользователем число
        private Button buttonSubmit;        //кнопка подтверждения выбранного числа
        private Button buttonExitToMenu;    //кнопка выхода в главное меню
        private Label label;                //текст с примечаниями
        private TextBox textBox;            //поле для ввод числа загаданного пользователем

        /// <summary>
        /// Возвращает значение поля number
        /// </summary>
        public int Number
        {
            get
            {
                return this.number;
            }
        }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public MyMessageBox()
        {
            this.number = 0;
            this.MyMessageBoxInitialization();
            this.ButtonSubmitnItialization();
            this.ButtonExitToMenuInitialization();
            this.LabelItialization();
            this.TextBoxItialization();
        }

        /// <summary>
        /// Создает диалоговое окно
        /// </summary>
        private void MyMessageBoxInitialization()
        {
            this.Size = new Size(300,170);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "ЗАГАДАЙ ЧИСЛО";
            this.BackColor = Color.LightSlateGray;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        /// <summary>
        /// Создает кнопку "Подтвердить"
        /// </summary>
        private void ButtonSubmitnItialization()
        {
            this.buttonSubmit = new Button();
            this.buttonSubmit.Text = "Подтвердить";
            this.buttonSubmit.BackColor = Color.DarkSlateGray;
            this.buttonSubmit.ForeColor = Color.White;
            this.buttonSubmit.Size = new Size(100, 50);
            this.buttonSubmit.Location = new Point(37, 70);
            this.Controls.Add(this.buttonSubmit);
            this.buttonSubmit.Click += new EventHandler(this.ButtonSubmitClickOn);
        }

        /// <summary>
        /// Создает кнопку "Выйти в меню"
        /// </summary>
        private void ButtonExitToMenuInitialization()
        {
            this.buttonExitToMenu = new Button();
            this.buttonExitToMenu.Text = "В главное меню";
            this.buttonExitToMenu.BackColor = Color.DarkSlateGray;
            this.buttonExitToMenu.ForeColor = Color.White;
            this.buttonExitToMenu.Size = new Size(100, 50);
            this.buttonExitToMenu.Location = new Point(150, 70);
            this.Controls.Add(this.buttonExitToMenu);
            this.buttonExitToMenu.Click += new EventHandler(ButtonExitToMenuClickOn);
        }

        /// <summary>
        /// Создает контроллер Label. Содержит в себе инструкции для пользователя.
        /// </summary>
        private void LabelItialization()
        {
            this.label = new Label();
            this.Controls.Add(this.label);
            this.label.Text = "Введите число:";
            this.label.ForeColor = Color.White;
            this.label.Location = new Point(37, 30);
        }

        /// <summary>
        /// Создает текстовое поле для ввод пользователем числа
        /// </summary>
        private void TextBoxItialization()
        {
            this.textBox = new TextBox();
            this.Controls.Add(textBox);
            this.textBox.Multiline = false;
            this.textBox.Location = new Point(this.label.Location.X +
                this.label.Width + 5, 21);
            this.textBox.Width = 105;
            this.textBox.Font = new Font(FontFamily.GenericSansSerif, 16);
        }

        /// <summary>
        /// Закрывает окно.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSubmitClickOn(Object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (this.textBox.Text != "")
            {
                this.number = int.Parse(this.textBox.Text);
            }
            else
            {
                this.number = -1;
            }
            this.Close();
        }

        /// <summary>
        /// Разрушает окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExitToMenuClickOn(Object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
