using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometasks_2
{
    class MyForm : Form
    {
        private Button buttonPlay;              //кнопка "начать игру"
        private Button buttonExit;              //кнопка "выйти из игры"
        private MyMessageBox messageBoxSetValue;//диалоговое окно
        private int maxNum = 2001;              //макс. число вводимое пользователем
        private int minNum = 1;                 //мин. число вводимое пользователем
        Label labelResult;                      //количество попыток на угадывание числа

        /// <summary>
        /// Конструктор главного окна программы
        /// </summary>
        public MyForm()
        {
            this.MyFormInitialization();
            this.ButtonPlayInitialization();
            this.ButtonExitInitialization();
        }

        /// <summary>
        /// Создает главное окно программы
        /// </summary>
        private void MyFormInitialization()
        {
            this.Size = new Size(400, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightSlateGray;
            this.Text = "Игра c ПК \"Угадай число\"";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        /// <summary>
        /// Создает кнопку "Играть" в главное окне программы
        /// </summary>
        private void ButtonPlayInitialization()
        {
            buttonPlay = new Button();
            this.buttonPlay.Size = new Size(100, 100);
            this.buttonPlay.Text = "Play";
            this.buttonPlay.Font = new Font(FontFamily.GenericSansSerif, 12, 
                FontStyle.Bold);
            this.buttonPlay.ForeColor = Color.White;
            this.buttonPlay.BackColor = Color.DarkSlateGray;
            int X = 80;
            int Y = (this.ClientSize.Height - this.buttonPlay.Height) / 2;
            this.buttonPlay.Location = new Point(X,Y);
            this.buttonPlay.Select();
            this.buttonPlay.TabIndex = 0;
            this.Controls.Add(this.buttonPlay);
            this.buttonPlay.Click += new EventHandler(ButtonPlayClickOn);
        }

        /// <summary>
        /// Создает кнопку "Выйход" в главном окне программы
        /// </summary>
        private void ButtonExitInitialization()
        {
            buttonExit = new Button();
            this.buttonExit.Size = new Size(100, 100);
            this.buttonExit.Text = "Exit";
            this.buttonExit.Font = new Font(FontFamily.GenericSansSerif, 12,
                FontStyle.Bold);
            this.buttonExit.ForeColor = Color.White;
            this.buttonExit.BackColor = Color.DarkSlateGray;
            int X = 220;
            int Y = (this.ClientSize.Height - this.buttonPlay.Height) / 2;
            this.buttonExit.Location = new Point(X, Y);
            this.buttonExit.TabIndex = 1;
            this.Controls.Add(this.buttonExit);
            this.buttonExit.Click += new EventHandler(ButtonExitClickOn);
        }

        /// <summary>
        /// Выводит инфо. сообщение в окне программы с результатом
        /// </summary>
        /// <param name="result"></param>
        private void LabelResult(string result)
        {
            this.labelResult = new Label();
            this.Controls.Add(this.labelResult);
            this.labelResult.Text = "УГАДАЛ!" + Environment.NewLine +
                "Кол-во попыток ПК: " + Environment.NewLine + result;
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new Font(FontFamily.GenericSansSerif,
                12);
            this.labelResult.TextAlign = ContentAlignment.MiddleCenter;
            this.labelResult.ForeColor = Color.White;
            int X = (this.Width - this.labelResult.Width) / 2;
            int Y = 20;
            this.labelResult.Location = new Point(X, Y);
            this.labelResult.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Обработчик события "нажатие кнопки "Играть""
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPlayClickOn(Object sender, EventArgs e)
        {
            this.messageBoxSetValue = new MyMessageBox();
            DialogResult dialogResult = this.messageBoxSetValue.ShowDialog(this);
            if (dialogResult != DialogResult.Cancel)
            {
                int userNum = messageBoxSetValue.Number;
                this.Validate(ref userNum);
                this.messageBoxSetValue.Dispose();

                int counter;
                if (this.labelResult != null)
                {
                    this.labelResult.Dispose();
                }
                if (this.Guess(userNum, out counter))
                {
                    this.LabelResult(counter.ToString());
                }
                else
                {
                    this.LabelResult("Не угаданно");
                }
            }
        }

        /// <summary>
        /// Обработчик события "нажатие кнопки "Выход""
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExitClickOn(Object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Генерирует случайные числа
        /// </summary>
        /// <param name="rnd">Генерато случайных чисел</param>
        /// <returns>Случайное целое число</returns>
        private int GetRundomIntValue(Random rnd)
        {
            if(rnd == null)
            {
                return new Random().Next(this.minNum, this.maxNum);
            }
            return rnd.Next(this.minNum, this.maxNum);
        }

        /// <summary>
        /// Угадывает число загаданное пользователем
        /// </summary>
        /// <param name="userNum">Число загаданное пользователем</param>
        /// <param name="counter">Счетчик попыток</param>
        /// <returns>Если число угадано, возвращает true</returns>
        private bool Guess(int userNum, out int counter)
        {
            Random rnd;             //генератор случайных чисел
            int rndNum;             //случайное число
            counter = 0;            //cчетчик попыток
            int[] array = new int[2000];
            int id = 0;
            rnd = new Random();
            while (true)
            {
                while (true)
                {
                    rndNum = GetRundomIntValue(rnd);
                    if (Array.IndexOf(array, rndNum) == -1)
                    {
                        array[id++] = rndNum;
                        break;
                    }
                }
                ++counter;
                if (rndNum == userNum)
                {
                    return true;
                }
            }    
        }

        /// <summary>
        /// Проверка значения загаданного пользователем числа
        /// </summary>
        /// <param name="userNum">загаданное пользователем число</param>
        private void Validate(ref int userNum)
        {
            while(userNum > 2000 || userNum < 1)
            {
                string message = "Неверное значение!!!" + Environment.NewLine +
                    "Допустимый диапазон чисел от 1 до 2000!!";
                MessageBox.Show(message, "ОШИБКА", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                this.messageBoxSetValue.Close();
                this.messageBoxSetValue = new MyMessageBox();
                this.messageBoxSetValue.ShowDialog(this);
                userNum = this.messageBoxSetValue.Number;
            }
        }
    }
}
