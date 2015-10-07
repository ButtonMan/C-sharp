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
    public partial class FormTextEdit : Form
    {
        //СВОЙТСТВА КЛАССА:
        //+-------------------------------------------------------------------+

        RichTextBox richTextBoxDocument = null;

        /// <summary>
        /// Предоставляет и редактирует значение текстового поля контролера 
        /// "richTextBoxEdit"
        /// </summary>
        public string richTextBoxText
        {
            set
            {
                this.richTextBoxEdit.Text = value;
            }
            get
            {
                return this.richTextBoxEdit.Text;
            }
        }



        //КОНСТРУКТОРЫ КЛАССА:
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Создает форму предназначенную для редактирования текста
        /// </summary>
        /// <param name="form">ссылочная переменная указывающая на 
        /// родительскую форму "главное окно программы"</param>
        /// <param name="text">текст подлежащий редактированию</param>
        public FormTextEdit(RichTextBox richTextBoxDocument)
        {
            this.InitializeComponent();
            this.EventSubscription();
            this.richTextBoxDocument = richTextBoxDocument;
            this.richTextBoxEdit.Text = this.richTextBoxDocument.Text;
        }


        //МЕТОДЫ КЛАССА:
        //+-------------------------------------------------------------------+

        //Подписка на события//

        /// <summary>
        /// Подписка контроллеров формы на события
        /// </summary>
        public void EventSubscription()
        {
            this.buttonSave.Click += new EventHandler(ButtonSaveClick);
            this.buttonCansel.Click += new EventHandler(ButtonCanselClick);
        }



        //ОБАБОТЧИКИ СОБЫТИЙ:
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Уведомление главной формы приложение о том, что отредактированный
        /// текст необходимо перенести в главное окно программы
        /// </summary>
        private void ButtonSaveClick(Object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.richTextBoxDocument.Text = this.richTextBoxEdit.Text;
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// Закрывает окно для редактирования текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCanselClick(Object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }
    }
}