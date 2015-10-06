using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometask_1.Forms
{
    public partial class FormMain : Form
    {
        //ПОЛЯ КЛАССА
        //+--------------------------------------------------------------------+
        private FormSearch formSearch = null;   //дочерняя форма содержащяя 
                                                //надстройки поиска



        //КОНСТРУКТОРЫ КЛАССА
        //+--------------------------------------------------------------------+
        public FormMain()
        {
            InitializeComponent();
        }



        //ОБРАБОТЧИКИ СОБЫТИЙ
        //+--------------------------------------------------------------------+

        /// <summary>
        /// Обработчик события нажатия кнопки "Поиск". Открывает форму настройки
        /// поиска.
        /// </summary>
        private void ButtonSearchClick(Object sender, EventArgs e)
        {
            this.FormSearchInitialaiz();
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Выход". Закрывает главное окно
        /// программы.
        /// </summary>
        private void ButtonExitClick(Object sender, EventArgs e)
        {
            this.Dispose();
        }



        //МЕТОДЫ КЛАССА
        //+--------------------------------------------------------------------+

        /// <summary>
        /// Создание дочернего окна для управления настройками поиска файла.
        /// </summary>
        private void FormSearchInitialaiz()
        {
            this.formSearch = new FormSearch();
            this.formSearch.Owner = this;
            this.formSearch.Show();
            this.formSearch.StartPosition = FormStartPosition.CenterParent;
        }
    }
}
