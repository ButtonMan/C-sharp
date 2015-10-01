using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hometask_1
{
    public partial class FormMain : Form
    {
        //ПОЛЯ КЛАССА
        //+-------------------------------------------------------------------+

        string pathToFile = null;       //путь к оригиналу файла
        string pathToFolder = null;     //путь для сохранения нового файла


        //КОНСТРУКТРЫ КЛАССА
        //+-------------------------------------------------------------------+

        public FormMain()
        {
            InitializeComponent();
        }


        //ОБРАБОТЧИКИ СОБЫТИЙ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Обработка события клика на поле "Путь к файлу"
        /// </summary>
        private void TextBoxFileDirectoryOpenClick(Object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                if (this.pathToFile != null) this.pathToFile = null;
                this.pathToFile = this.openFileDialog.FileName;
                this.textBoxFileDirectoryOpen.Text = this.openFileDialog.FileName;
            }
            else
            {
                this.pathToFile = null;
                this.openFileDialog.Dispose();
            }
        }
        /// <summary>
        /// Обработка события клика на поле "Путь сохранения файла"
        /// </summary>
        private void TextBoxFileDirectorySaveClick(Object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                if (this.pathToFolder != null) this.pathToFolder = null;
                this.pathToFolder = this.folderBrowserDialog.SelectedPath;
                this.textBoxFileDirectorySave.Text = this.folderBrowserDialog.SelectedPath;
            }
            else
            {
                this.pathToFolder = null;
                this.folderBrowserDialog.Dispose();
            }
        }

        /// <summary>
        /// Обработка события нажатия кнопки "копировать"
        /// </summary>
        private void buttonCopyClick(Object sender, EventArgs e)
        {
            this.CopyFile();
            MessageBox.Show("Копирования завершено");
            this.SetProgressBarDefault();
            this.SetTextBoxsDefault();
        }
        /// <summary>
        /// Обработка события нажатия кнопки "выйти"
        /// </summary>
        private void buttonExitClick(Object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }


        //МЕТОДЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Копирование файла в указанную пользователем директорию.
        /// Процесс копирования отображается в прогресс баре окна.
        /// </summary>
        private void CopyFile()
        {
            string originalFileName = Path.GetFileName(this.pathToFile);
            string fileSaveDirectory = Path.Combine(this.pathToFolder, originalFileName);
            FileStream originalFile = new FileStream(this.pathToFile, FileMode.Open, FileAccess.Read);
            FileStream copiedFile = new FileStream(fileSaveDirectory, FileMode.CreateNew, FileAccess.Write);
            this.progressBarFileCoping.Minimum = 0;
            this.progressBarFileCoping.Maximum = (int)originalFile.Length - 1;
            while (originalFile.Position < originalFile.Length)
            {
                this.progressBarFileCoping.Value = (int)originalFile.Position;
                copiedFile.WriteByte((Byte)originalFile.ReadByte());
            }
            if (originalFile != null) originalFile.Close();
            if (copiedFile != null) copiedFile.Close();
        }
        /// <summary>
        /// Сброс значения прогресс бара
        /// </summary>
        void SetProgressBarDefault()
        {
            this.progressBarFileCoping.Value = 0;
            this.progressBarFileCoping.Minimum = 0;
            this.progressBarFileCoping.Maximum = 0;
        }
        /// <summary>
        /// Сброс значений полей для ввода текста
        /// </summary>
        void SetTextBoxsDefault()
        {
            this.textBoxFileDirectoryOpen.Text = null;
            this.textBoxFileDirectorySave.Text = null;
        }
    }
}
