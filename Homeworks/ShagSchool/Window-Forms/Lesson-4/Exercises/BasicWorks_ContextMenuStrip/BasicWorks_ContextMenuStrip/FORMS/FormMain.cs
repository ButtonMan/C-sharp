using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BasicWorks_ContextMenuStrip.Forms
{
    class FormMain : Form
    {
        //ПОЛЯ КЛАССА:
        //+-------------------------------------------------------------------+

        MenuStrip menu = null;                               //меню приложения
        ToolStripItem menuItemFile = null;                   //пункт меню - Файл
        ToolStripItem menuItemEdit = null;                   //пункт меню - Правка
        ToolStripItem menuItemHelp = null;                   //пункт меню - помощь
        ToolStripTextBox menuItemSearch = null;              //пункт меню - поиск
        ContextMenuStrip contextMenuClientBlock = null;      //конт. меню раб. обл.
        ToolStripItem contextMenuClientBlockCopy = null;     //пунт конт.меню - Копировать
        ToolStripItem contextMenuClientBlockPast = null;     //пунт конт.меню - Вставить
        ToolStripItem contextMenuClientBlockCut = null;      //пунт конт.меню - Вырезать
        ToolStripItem contextMenuClientBlockTranslate = null;//конт. меню раб. обл.
        ContextMenuStrip contextMenuMenuBlock = null;        //конт. меню  раб. обл. меню
        ToolStripItem contextMenuMenuBlockHide = null;       //пунт конт.меню - Спрятать
        ToolStripItem contextMenuMenuBlockShow = null;       //пунт конт.меню - Показать



        //КОНСТРУКТОРЫ КЛАССА:
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Создание окна главного окна приложения и всех его контроллов.
        /// </summary>
        public FormMain()
        {
            this.FormMainInitialization();
            this.MenuInitialization();
            this.ContextMenuClientBlockInitialization();
            this.ContextMenuMenuBlockInitialization();
        }



        //МЕТОДЫ КЛАССА:
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Создание главного окна программы
        /// </summary>
        private void FormMainInitialization()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(700, 375);
            this.BackColor = Color.DimGray;
            this.ForeColor = Color.LightSkyBlue;
        }

        /// <summary>
        /// Создание блока меню главного окна программы
        /// </summary>
        private void MenuInitialization()
        {
            this.menu = new MenuStrip();
            this.MainMenuStrip = menu;
            this.Controls.Add(this.menu);
            this.Dock = DockStyle.Top;
            this.menu.BackColor = Color.LightSkyBlue;
            this.menu.ForeColor = Color.White;

            this.menuItemFile = (ToolStripItem)this.menu.Items.Add("Файл");
            this.menuItemEdit = (ToolStripItem)this.menu.Items.Add("Правка");
            this.menuItemHelp = (ToolStripItem)this.menu.Items.Add("Справка");

            this.menuItemSearch = new ToolStripTextBox();
            this.menu.Items.Add(this.menuItemSearch);
            this.menuItemSearch.ForeColor = Color.DimGray;
            this.menuItemSearch.Text = "поиск";

            this.menu.Show();
        }

        /// <summary>
        /// Создание контекстного меню рабочей области окна
        /// </summary>
        private void ContextMenuClientBlockInitialization()
        {
            this.contextMenuClientBlock = new ContextMenuStrip();
            this.ContextMenuStrip = this.contextMenuClientBlock;
            this.contextMenuClientBlockCopy = 
                this.contextMenuClientBlock.Items.Add("Копировать");
            this.contextMenuClientBlockPast = 
                this.contextMenuClientBlock.Items.Add("Вставить");
            this.contextMenuClientBlockCut = 
                this.contextMenuClientBlock.Items.Add("Вырезать");
            this.contextMenuClientBlock.Items.Add(new ToolStripSeparator());
            this.contextMenuClientBlockTranslate = 
                this.contextMenuClientBlock.Items.Add("Перевести");
        }

        /// <summary>
        /// Создание контекстного меню действующего в рабочей области 
        /// меню окна.
        /// </summary>
        private void ContextMenuMenuBlockInitialization()
        {
            this.contextMenuMenuBlock = new ContextMenuStrip();
            this.menu.ContextMenuStrip = this.contextMenuMenuBlock;
            this.contextMenuMenuBlockHide = 
                this.contextMenuMenuBlock.Items.Add("Скрыть");
            this.contextMenuMenuBlockShow =
                this.contextMenuMenuBlock.Items.Add("Отобразить");
        }
    }
}
