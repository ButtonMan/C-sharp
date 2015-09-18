using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingListBox
{
    class FormMain : Form
    {
        //ПОЛЯ КЛАССА
        //+-------------------------------------------------------------------+

        private ListBox listBoxCars;
        private ListBox listBoxCarsCopy;
        private TextBox textBoxNewListItem;
        private Label   labelCars;
        private Label   labelCarsCopy;
        private Label   labelCarAddNew;
        private Button  buttonAdd;
        private Button  buttonCopy;
        private Button  buttonRemove;
        private Button  buttonOk;
        private Button  buttonCanсel;



        //КОНСТРУКТОР КЛАССА
        //+-------------------------------------------------------------------+
        public FormMain()
        {
            this.FormMainInitialization();

            this.ListBoxCarsInitialization();
            this.ListBoxCarsCopyInitialization();

            this.TextBoxNewListItemInitialization();

            this.LabelCarsInitialization();
            this.LabelCarAddNewInitialization();
            this.LabelCarsCopyInitialization();

            this.ButtonAddInitialization();
            this.ButtonCopyInitialization();
            this.ButtonRemoveInitialization();

            this.ButtonOkInitialization();
            this.ButtonCanсelInitialization();
        }



        //МЕТОДЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Создание главного окна программы
        /// </summary>
        private void FormMainInitialization()
        {
            this.ClientSize = new Size(400, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.DarkSlateGray;
            this.Text = "Применение контроллера ListBox";
            this.ForeColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }


        /// <summary>
        /// Создание списка машин
        /// </summary>
        private void ListBoxCarsInitialization()
        {
            this.listBoxCars = new ListBox();
            this.Controls.Add(this.listBoxCars);
            this.listBoxCars.Size = new Size(100, 150);
            this.listBoxCars.Location = new Point(50, 50);
            this.listBoxCars.SelectionMode = SelectionMode.MultiExtended;
        }
        /// <summary>
        /// Создание списка копий названий
        /// </summary>
        private void ListBoxCarsCopyInitialization()
        {
            this.listBoxCarsCopy = new ListBox();
            this.Controls.Add(this.listBoxCarsCopy);
            this.listBoxCarsCopy.Size = new Size(100, 150);
            this.listBoxCarsCopy.Location = new Point(250, 50);
        }
        /// <summary>
        /// Создание текстового поля для ввода новых названий
        /// </summary>
        private void TextBoxNewListItemInitialization()
        {
            this.textBoxNewListItem = new TextBox();
            this.Controls.Add(this.textBoxNewListItem);
            this.textBoxNewListItem.Location = new Point(50, 250);
            this.textBoxNewListItem.Multiline = false;
        }

        
        /// <summary>
        /// Создание инфо подписи к списку названий
        /// </summary>
        private void LabelCarsInitialization()
        {
            this.labelCars = new Label();
            this.Controls.Add(this.labelCars);
            this.labelCars.Size = new Size(105, 28);
            this.labelCars.Location = new Point(50, 25);
            this.labelCars.Text = "Выберите марку авто:";
        }
        /// <summary>
        /// Создание инфо подписи к списку с копиями названий
        /// </summary>
        private void LabelCarsCopyInitialization()
        {
            this.labelCarsCopy = new Label();
            this.Controls.Add(this.labelCarsCopy);
            this.labelCarsCopy.Size = new Size(105, 28);
            this.labelCarsCopy.Location = new Point(250, 25);
            this.labelCarsCopy.Text = "Выбранные марки авто:";
        }
        /// <summary>
        /// Создание инфо подписи текстовому поля для ввода новых 
        /// названий
        /// </summary>
        private void LabelCarAddNewInitialization()
        {
            this.labelCarAddNew = new Label();
            this.Controls.Add(this.labelCarAddNew);
            this.labelCarAddNew.Size = new Size(105, 14);
            this.labelCarAddNew.Location = new Point(50, 235);
            this.labelCarAddNew.Text = "Новая марка авто:";
        }


        /// <summary>
        /// Создание кнопки "Добавить".
        /// </summary>
        private void ButtonAddInitialization()
        {
            this.buttonAdd = new Button();
            this.Controls.Add(this.buttonAdd);
            this.buttonAdd.Click += new EventHandler(this.ButtonAddClickOn);
            int x = this.textBoxNewListItem.Location.X +
                this.textBoxNewListItem.Width + 10;
            int y = this.textBoxNewListItem.Location.Y - 1;
            this.buttonAdd.Location = new Point(x, y);
            this.buttonAdd.Text = "Add";
        }
        /// <summary>
        /// Создание кнопки "Копировать"
        /// </summary>
        private void ButtonCopyInitialization()
        {
            this.buttonCopy = new Button();
            this.Controls.Add(this.buttonCopy);
            this.buttonCopy.Click += new EventHandler(ButtonCopyClickOn);
            int x = this.listBoxCars.Location.X +
                this.listBoxCars.Width + 10;
            int y = this.listBoxCars.Location.Y;
            this.buttonCopy.Location = new Point(x, y);
            this.buttonCopy.Text = "Copy >>";
        }
        /// <summary>
        /// Создание кнопки "Убрать"
        /// </summary>
        private void ButtonRemoveInitialization()
        {
            this.buttonRemove = new Button();
            this.Controls.Add(this.buttonRemove);
            this.buttonRemove.Click += new EventHandler(ButtonRemoveClickOn);
            int x = this.listBoxCars.Location.X +
                this.listBoxCars.Width + 10;
            int y = this.listBoxCars.Location.Y +
                this.buttonRemove.Height + 10; ;
            this.buttonRemove.Location = new Point(x, y);
            this.buttonRemove.Text = "<< Remove <<";
        }
        /// <summary>
        /// Создание кнопки "Ок"
        /// </summary>
        private void ButtonOkInitialization()
        {
            this.buttonOk = new Button();
            this.Controls.Add(this.buttonOk);
            this.buttonOk.Click += new EventHandler(ButtonOkClickOn);
            this.buttonOk.DialogResult = DialogResult.OK;
            this.buttonOk.Location = new Point(190, 325);
            this.buttonOk.Text = "Ok";
        }
        /// <summary>
        /// Создание кнопки "Отмена"
        /// </summary>
        private void ButtonCanсelInitialization()
        {
            this.buttonCanсel = new Button();
            this.Controls.Add(this.buttonCanсel);
            this.buttonCanсel.Click += new EventHandler(ButtonCanсelClickOn);
            this.buttonCanсel.DialogResult = DialogResult.Cancel;
            int x = this.buttonOk.Location.X +
                this.buttonOk.Width + 10;
            int y = 325;
            this.buttonCanсel.Location = new Point(x, y);
            this.buttonCanсel.Text = "Canсel";
        }


        /// <summary>
        /// Обработчик события нажатия кнопки "Добавть".
        /// Добавляет в список названий, новый элемент.
        /// </summary>
        private void ButtonAddClickOn(Object sender, EventArgs e)
        {
            if (this.textBoxNewListItem.Text != "")
            {
                StringBuilder newName = new StringBuilder(this.textBoxNewListItem.Text.Trim().ToLower());
                newName[0] = Char.ToUpper(newName[0]);
                this.listBoxCars.Items.Add(newName);
                this.textBoxNewListItem.Text = "";
            }
        }
        /// <summary>
        /// Обработчик события нажатия кнопки "Копировать".
        /// Копирует название элемента списка в другой список
        /// </summary>
        private void ButtonCopyClickOn(Object sender, EventArgs e)
        {
            for (int i = 0; i < this.listBoxCars.SelectedItems.Count; ++i)
            {
                this.listBoxCarsCopy.Items.Add(this.listBoxCars.SelectedItems[i]);
            }
        }
        /// <summary>
        /// Обработчик события нажатия кнопки "Убрать".
        /// Убирает название элемента из списка с копиями названий.
        /// </summary>
        private void ButtonRemoveClickOn(Object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selected = this.listBoxCarsCopy.SelectedItems;
            for (int i = 0; i < selected.Count; ++i)
            {
                this.listBoxCarsCopy.Items.Remove(selected[i]);
            }
        }
        /// <summary>
        /// Обработчик события нажатия кнопки "Ок".
        /// Закрывает окно программы.
        /// </summary>
        private void ButtonOkClickOn(Object sender, EventArgs e)
        {
            this.Dispose();
        }
        /// <summary>
        /// Обработчик события нажатия кнопки "Отмена".
        /// Закрывает окно программы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCanсelClickOn(Object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
