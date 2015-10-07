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
    public partial class FormMain : Form
    {
        //ПОЛЯ КЛАССА:
        //+-------------------------------------------------------------------+

        private string path = null;                     //путь к файлу
        private FileStream file = null;                 //байтовый поток
        private StreamReader streamTxtRdr = null;       //чтение текста из файла
        private FormProgressBar formProgressBar = null; //окно с прогресс баром
        private OpenFileDialog openFileDialog = null;   //окно для откр. файла
        private FormTextEdit formTextEdit = null;       //форма для ред. текста 


        
        //КОНСТРУКТОРЫ КЛАССА:
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public FormMain()
        {
            this.InitializeComponent();
            this.EventSubscription();
        }



        //МЕТОДЫ КЛАССА:
        //+-------------------------------------------------------------------+
        
        //Создание дочерних форм//
        
        /// <summary>
        /// Создание формы содержащей в себе ProgressBar.
        /// Данная форма отслеживает загрузку данных в приложение.
        /// </summary>
        private void FormProgressBarInitialization()
        {
            this.formProgressBar = new FormProgressBar(this.file,
                this.richTextBoxDocument);
            this.formProgressBar.StartPosition = FormStartPosition.CenterParent;
            this.formProgressBar.Owner = this;
            this.formProgressBar.ShowDialog(this);
        }
        
        /// <summary>
        /// Создание диалогового окна для открытия пользователем, произвольного
        /// текстового файла
        /// </summary>
        private void OpenFileDialogInitialization()
        {
            this.openFileDialog = new OpenFileDialog();
            this.openFileDialog.Multiselect = false;
            this.openFileDialog.Title = "Открыть текстовый файл";
            this.openFileDialog.AddExtension = true;
            this.openFileDialog.CheckFileExists = true;
            this.openFileDialog.CheckPathExists = true;
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.DereferenceLinks = true;
            this.openFileDialog.Filter = "txt files (*.txt)|*.txt";
            this.openFileDialog.ShowDialog(this);
        }
        
        /// <summary>
        /// Создание формы для редактирования заданного пользователем текста
        /// </summary>
        private void FormTextEditInitialization()
        {
            this.formTextEdit = new FormTextEdit(this.richTextBoxDocument);
            this.formTextEdit.Owner = this;
            this.formTextEdit.Show(this);
        }

        //Подписка на события//

        /// <summary>
        /// Подписка контроллеров формы на события
        /// </summary>
        private void EventSubscription()
        {
            this.buttonDownload.Click += new EventHandler(this.ButtonDownloadClick);
            this.buttonEdite.Click += new EventHandler(this.ButtonEditClick);
        }



        //ОБАБОТЧИКИ СОБЫТИЙ:
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Открывает диалоговое окно "открытия файла", после чего, загружет 
        /// выбранные файл в текстовый контроллер "RichTextBox" расположенный
        /// в главном окне приложения.
        /// </summary>
        private void ButtonDownloadClick(Object sender, EventArgs e)
        {
            this.OpenFileDialogInitialization();
            this.path = this.openFileDialog.FileName;
            if (!String.IsNullOrEmpty(this.path) ||
                !String.IsNullOrWhiteSpace(this.path))
            {
                this.file = new FileStream(this.path, FileMode.Open,
                    FileAccess.ReadWrite);
                this.streamTxtRdr = new StreamReader(this.file);
                this.FormProgressBarInitialization();
                if (this.formProgressBar != null) this.formProgressBar.Dispose();
                this.buttonEdite.Enabled = true;
                if (this.streamTxtRdr != null)
                {
                    this.streamTxtRdr.Close();
                    this.streamTxtRdr = null;
                }
                if (this.file != null)
                {
                    this.file.Close();
                    this.file = null;
                }
            }
            if (this.openFileDialog != null)
            {
                this.openFileDialog.Dispose();
                this.openFileDialog = null;
            }
        }

        /// <summary>
        /// Открывает окно для редактирования загруженного пользователем
        ///  из файла текста.
        /// </summary>
        private void ButtonEditClick(Object sender, EventArgs e)
        {
            this.FormTextEditInitialization();
        }



        //ДЕСТРУКТОР КЛАССА:
        //+-------------------------------------------------------------------+
        ~FormMain()
        {
            if (this.formProgressBar != null) this.formProgressBar.Dispose();
            if (this.streamTxtRdr != null) this.streamTxtRdr.Close();
            if (this.file != null) this.file.Close();
            if (this.formTextEdit != null) this.formTextEdit.Dispose();
        }
    }
}
