using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BasicWorks_AppMenuStrip.Forms
{
    /// <summary>
    /// Класс FormMain.
    /// Предназначен для создания главного окна программы.
    /// </summary>
    public partial class FormMain : Form
    {
        //ПОЛЯ КЛАССА: 
        //+-------------------------------------------------------------------+

        private TextBox textBoxDocument = null;           //дочернее текст. поле
        private MenuStrip menu = null;                    //меню главн. окна
        private ToolStripMenuItem menuItemFile = null;    //пункт меню File
        private ToolStripMenuItem menuItemEdit = null;    //пункт меню Edit
        private ToolStripComboBox menuItemComboBox = null;//пункт меню-вып. спис.
        private ToolStripTextBox menuItemSearch = null;   //пункт меню-текст.пол.
        private ToolStripItem fileItemOpen = null;        //меню File-пункт Open 
        private ToolStripItem fileItemSave = null;        //меню File-пункт Save 
        private ToolStripItem fileItemClose = null;       //меню File-пункт Close 
        private ToolStripItem editItemUndo = null;        //меню Edit-пункт Undo
        private ToolStripItem editItemRedo = null;        //меню Edit-пункт Redo
        private ToolStripItem editItemCopy = null;        //меню Edit-пункт Copy
        private ToolStripItem editItemPast = null;        //меню Edit-пункт Past


        //КОНСТРУКТОРЫ КЛАССА: 
        //+-------------------------------------------------------------------+
        /// <summary>
        /// Создание главного окна и его дочерних контролов
        /// </summary>
        public FormMain()
        {
            this.FormMainInitialization();
            this.MenuInitialization();
            this.TextBoxDocumentInitialization();
        }


        //МЕТОДЫ КЛАССА: 
        //+-------------------------------------------------------------------+
        /// <summary>
        /// Создание главного окна
        /// </summary>
        private void FormMainInitialization()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(700, 400);
            this.BackColor = Color.DimGray;
            this.ForeColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        /// <summary>
        /// Создание меню главного окна программы
        /// </summary>
        private void MenuInitialization()
        {
            this.menu = new MenuStrip();
            this.MainMenuStrip = menu;
            this.Controls.Add(this.menu);
            this.menu.BackColor = Color.DimGray;
            this.menu.ForeColor = Color.LightSkyBlue;
            this.menu.Dock = DockStyle.Top;

            this.menuItemFile = (ToolStripMenuItem)this.menu.Items.Add("&File");
            this.menuItemEdit = (ToolStripMenuItem)this.menu.Items.Add("&Edit");

            this.menuItemComboBox = new ToolStripComboBox();
            this.menuItemComboBox.Items.Add("connect");
            this.menuItemComboBox.Items.Add("disconnect");
            this.menuItemComboBox.SelectedItem = "connect";
            this.menu.Items.Add(this.menuItemComboBox);

            this.menuItemSearch = new ToolStripTextBox();
            this.menuItemSearch.Text = "Поиск";
            this.menuItemSearch.ForeColor = Color.DimGray;
            this.menu.Items.Add(this.menuItemSearch);

            this.fileItemOpen = this.menuItemFile.DropDownItems.Add("Open");
            this.fileItemSave = this.menuItemFile.DropDownItems.Add("Save");
            this.fileItemClose = this.menuItemFile.DropDownItems.Add("Close");

            this.editItemUndo = this.menuItemEdit.DropDownItems.Add("Undo");
            this.editItemRedo = this.menuItemEdit.DropDownItems.Add("Redo");
            this.menuItemEdit.DropDownItems.Add(new ToolStripSeparator());
            this.editItemCopy = this.menuItemEdit.DropDownItems.Add("Copy");
            this.editItemPast = this.menuItemEdit.DropDownItems.Add("Past");

            this.menu.Show();
        }

        /// <summary>
        /// создание текстового поля в главном окне
        /// </summary>
        private void TextBoxDocumentInitialization()
        {
            int margin = 10;
            int x = margin;
            int y = this.menu.Height;
            int width = this.ClientSize.Width - margin * 2;
            int height = this.ClientSize.Height - this.menu.Height - 
                margin * 2;

            this.textBoxDocument = new TextBox();
            this.textBoxDocument.Parent = this;
            this.textBoxDocument.Multiline = true;
            this.textBoxDocument.Enabled = true;
            this.textBoxDocument.ReadOnly = false;

            this.textBoxDocument.Size = new Size(width, height);
            this.textBoxDocument.Location = new Point(x, y);
            this.textBoxDocument.AutoSize = true;
            this.textBoxDocument.Anchor = AnchorStyles.Left | AnchorStyles.Top |
                AnchorStyles.Right;
            this.textBoxDocument.Show();
        }

    }
}
