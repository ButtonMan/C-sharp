using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometask_3.Forms
{



    /// <summary>
    /// Клас "FormProgressBar" предназначен для создания окна с индикатором 
    /// ProgressBar. Окно информирует пользователя о состоянии процесса 
    /// считывания данных из файла в текстовое поле формы главного окна.
    /// </summary>



    public partial class FormProgressBar : Form
    {
        //ПОЛЯ КЛАССА:
        //+-------------------------------------------------------------------+
        private FileStream    file = null;               //байтовый поток
        private StreamReader  streamTxtRdr = null;       //чтение текста из файла
        private StreamWriter  streamTxtWrt = null;       //запись текста в файл
        private RichTextBox   richTextBoxDocument = null;//контейнер для текста
        private StringBuilder txtContainer = null;       //временное хранилише



        //КОНСТРУКТОРЫ КЛАСС
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Конструктор класса с параметрами
        /// </summary>
        /// <param name="fileTxtRdr">текстовый поток для чтения из файла</param>
        /// <param name="fileTxtWrt">текстовый поток для записи в поле</param>
        public FormProgressBar(FileStream file, RichTextBox richTextBox)
        {
            InitializeComponent();
            this.StreamsInitialization(file, richTextBox);
            this.ProgressBarInitialization();
            this.EventsSubscriptions();
        }

        /// <summary>
        /// Присвоение значений полям класса.
        /// Используется в конструкторе.
        /// </summary>
        /// <param name="file">поток для работы с файлом</param>
        /// <param name="richTextBox">объект "текстовое поле"</param>
        private void StreamsInitialization(FileStream file, 
            RichTextBox richTextBox)
        {
            this.file = file;
            this.streamTxtRdr = new StreamReader(this.file, System.Text.Encoding.Default);
            this.streamTxtWrt = new StreamWriter(this.file, System.Text.Encoding.Default);
            this.richTextBoxDocument = richTextBox;
        }

        /// <summary>
        /// Подписывает методы обрабатывающие события на события.
        /// </summary>
        private void EventsSubscriptions()
        {
            this.Shown += new EventHandler(ProgressBarShowProcess);
        }

        /// <summary>
        /// Создает контроллер ProgressBar с заданными характеристиками
        /// </summary>
        private void ProgressBarInitialization()
        {
            this.progressBarOpenFile.Minimum = 0;
            this.progressBarOpenFile.Maximum = (int)this.file.Length;
            this.progressBarOpenFile.Value = 0;
        }

        /// <summary>
        /// Отображает процесс считывания фала, на иднекторе контроллера ProgressBar
        /// </summary>
        private void ProgressBarShowProcess(Object sender, EventArgs e)
        {
            this.txtContainer = new StringBuilder();
            this.DoubleBuffered = true;
            int counter = 1;       
            this.file.Position = 0;
            int max = this.progressBarOpenFile.Maximum;
            int step = (int)(max * 0.05);
            while(!this.streamTxtRdr.EndOfStream)
            {
                this.txtContainer.Append(((char)this.streamTxtRdr.Read()));
                if(counter >= step || txtContainer.Length + 1 == max)
                {
                    this.progressBarOpenFile.Value = txtContainer.Length;
                    this.progressBarOpenFile.Refresh();
                    this.Refresh();
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(50);
                    counter = 1;
                }
                counter++;
            }
            System.Threading.Thread.Sleep(500);
            this.progressBarOpenFile.Value = max;
            this.progressBarOpenFile.Refresh();
            this.Refresh();
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);
            this.richTextBoxDocument.Text = this.txtContainer.ToString();
            this.Close();
        }



        //ДЕСТРУКТОР КЛАСС
        //+-------------------------------------------------------------------+
        /// <summary>
        /// Закрывает потоки для работы с текстом StreamReader и StreamWriter.
        /// Перемещает позицию потока файла в начало документа.
        /// </summary>
        ~FormProgressBar()
        {
            if (this.streamTxtRdr != null) this.streamTxtRdr.Close();
            if (this.streamTxtWrt != null) this.streamTxtWrt.Close();
            if (this.file.Position != 0) this.file.Position = 0;
        }
    }
}
