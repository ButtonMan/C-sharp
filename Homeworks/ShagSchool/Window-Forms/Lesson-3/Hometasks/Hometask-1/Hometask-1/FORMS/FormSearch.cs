using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometask_1.Forms
{
    public partial class FormSearch : Form
    {
        //КОНСТРУКТОРЫ КЛАССА
        //+--------------------------------------------------------------------+
        public FormSearch()
        {
            this.InitializeComponent();
            this.FolderBrowserDialogInitialization();
            this.ToolTipsInitialization();
        }



        //ОБРАБОТЧИКИ СОБЫТИЙ
        //+--------------------------------------------------------------------+

        /// <summary>
        /// Обработка события нажатия кнопки "Выбор папки"
        /// </summary>
        private void ButtonFolderBrowserDialog(Object sender, EventArgs e)
        {
            if (this.folderBrowserDialog == null)
            {
                throw new NullReferenceException("Объект \"Диалоговое окно" + 
                    "выбора папки\" на созданн");
            }
            DialogResult dilogResult = this.folderBrowserDialog.ShowDialog();
            if(dilogResult == DialogResult.OK)
            {
                this.textBoxSearch.Text = this.folderBrowserDialog.SelectedPath;
            }
            else
            {
                this.folderBrowserDialog.Dispose();
            }
        }

        /// <summary>
        /// Обработка события нажатия кнопки "Подтвердить"
        /// </summary>
        private void ButtonConfirmClick(Object sender, EventArgs e)
        {
            DialogResult dialogResult;
            if (this.TextBoxSearchValidation(this.textBoxSearch.Text))
            {
                StringBuilder filesNames = this.GetDirectoryFilesNames();
                dialogResult = MessageBox.Show(
                    text: filesNames.ToString(),
                    caption: "Содержимое папки",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK) this.textBoxSearch.Clear();
            }
            else
            {
                dialogResult = MessageBox.Show(
                    text: "Не указан путь к папке.",
                    caption: "Предупреждние! ",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Exclamation
                    );
                if (dialogResult == DialogResult.OK) this.textBoxSearch.Clear();
            }

        }
        /// <summary>
        /// Обработка события нажатия кнопки "Отмена"
        /// </summary>
        private void ButtonCanselClick(Object sender, EventArgs e)
        {
            this.Dispose();
        }



        //МЕТОДЫ КЛАССА
        //+--------------------------------------------------------------------+

        /// <summary>
        /// Создание всплывающих подсказок к контроллерам дочерней формы
        /// FormSearch
        /// </summary>
        private void ToolTipsInitialization()
        {
            this.toolTipFolderBrowaerDialog.SetToolTip(this.buttonFolder,
                "Меню выбора дирректории/папки поиска");
            this.toolTipTextBoxSearch.SetToolTip(this.textBoxSearch,
                "Укажите путь к папке и имя искомого файла/маску");
        }

        /// <summary>
        /// Создание диалогового окна пользователя "выбор папки"
        /// </summary>
        private void FolderBrowserDialogInitialization()
        {
            folderBrowserDialog.ShowNewFolderButton = false;
            this.toolTipFolderBrowaerDialog.SetToolTip(this.buttonFolder,
                "Подсказка:");
            this.toolTipFolderBrowaerDialog.SetToolTip(this.buttonFolder,
                "Меню выбора дирректории/папки поиска");
            this.folderBrowserDialog.ShowNewFolderButton = false;
        }

        /// <summary>
        /// Определяет имена файлов, находящихся в выбраной пользователем
        /// директории и соответствующих заданной пользователем маске 
        /// имени файла
        /// </summary>
        /// <returns>перечень имен файлов соответствующих заданной 
        /// пользователем маске и находящихся в заданной пользователем 
        /// дирректории</returns>
        private StringBuilder GetDirectoryFilesNames()
        {
            StringBuilder filesNames = new StringBuilder();
            string path = this.textBoxSearch.Text;
            string fileName = Path.GetFileName(path);
            string directory = Path.GetDirectoryName(path);
            string[] filePath = Directory.GetFiles(directory, fileName,
                SearchOption.AllDirectories);
            foreach(string value in filePath)
            {
                filesNames.AppendLine(Path.GetFileName(value));
            }
            return filesNames;
        }

        /// <summary>
        /// Проверка, того, указана ли пользователем дирректория 
        /// в которой будет происходить поиск файла
        /// </summary>
        /// <param name="path">путь</param>
        /// <returns></returns>
        private bool TextBoxSearchValidation(String path)
        {
            if(String.IsNullOrEmpty(path) || String.IsNullOrWhiteSpace(path))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
