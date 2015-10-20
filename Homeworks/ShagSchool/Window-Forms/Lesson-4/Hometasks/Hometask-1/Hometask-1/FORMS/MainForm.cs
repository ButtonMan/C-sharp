using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using Hometask_1.Entity;
using System.IO;

namespace Hometask_1.Forms
{
    class FormMain : Form
    {

        //+-----------------------------------------------------------------------------+
        //ПОЛЯ КЛАССА: 
        //+-----------------------------------------------------------------------------+

        MenuStrip menuStrip = null;                     //блок меню главного окна
        
        ToolStripMenuItem menuStripItemFile = null;     //пункт меню "Файл"
        ToolStripMenuItem itemFileCreate = null;        //меню "Файл" -> пункт "Создать"
        ToolStripMenuItem itemFileOpen = null;          //меню "Файл" -> пункт "Открыть"        
        ToolStripMenuItem itemFileSave = null;          //меню "Файл" -> пункт "Сохранить"
        ToolStripMenuItem itemFileSaveAs = null;        //меню "Файл" -> пункт "Сохранить как"
        ToolStripMenuItem itemFileClose = null;         //меню "Файл" -> пункт "Закрыть"

        ToolStripMenuItem menuStripItemEdit = null;     //пункт меню "Правка"
        ToolStripMenuItem itemEditUndo = null;          //меню "Правка" -> пункт "Отменить"
        ToolStripMenuItem itemEditCopy = null;          //меню "Правка" -> пункт "Копировать"
        ToolStripMenuItem itemEditCut = null;           //меню "Правка" -> пункт "Вырезать"
        ToolStripMenuItem itemEditPast = null;          //меню "Правка" -> пункт "Вставить"
        ToolStripSeparator itemSeparator = null;        //меню "Правка" -> разденлитель
        ToolStripMenuItem itemSelectAll = null;         //меню "Правка" -> пункт "выделить все"        

        ToolStripMenuItem menuStripItemFormat = null;   //пункт меню "Формат"
        ToolStripMenuItem itemFormatFont = null;        //меню "Формат" -> пункт "шрифт"

        ToolStripContainer toolStripContainer = null;   //конткейнер для панели инструкментов

        ToolStrip toolStripFile = null;                 //панель инструментов "Файл"
        ImageList toolStripFileImgList = null;          //изобр. кнопок панели инстр.
        ToolStripButton buttonFileCreate = null;        //панель "Файл" -> кнопка создать
        ToolStripButton buttonFileOpen = null;          //панель "Файл" -> кнопка открыть
        ToolStripButton buttonFileSave = null;          //панель "Файл" -> кнопка сохранить
        ToolStripButton buttonFileClose = null;         //панель "Файл" -> кнопка закрыть

        ToolStrip toolStripEdite = null;                //панель инструментов "Редактирование"
        ImageList toolStripEditImgList = null;          //изобр. кнопок панели инстр.
        ToolStripButton buttonEditUndo = null;          //панель "Редакт." -> кнопка "отменить"
        ToolStripButton buttonEditCopy = null;          //панель "Редакт." -> кнопка "копировать"
        ToolStripButton buttonEditCut = null;           //панель "Редакт." -> кнопка "вырезать"
        ToolStripButton buttonEditPust = null;          //панель "Редакт." -> кнопка "вставить"

        ToolStrip toolStripFont= null;                  //панель инструментов "Шрифт"
        ToolStripComboBox comboBoxFont = null;          //панель "Шрифт" -> кнопка "шрифт"
        ToolStripComboBox comboBoxSize = null;          //панель "Шрифт" -> кнопка "размер"
        ToolStripButton buttonColor = null;             //панель "Шрифт" -> кнопка "цвет"

        ContextMenuStrip contextMenu = null;            //контекстное меню объекта richTextBox
        ToolStripMenuItem contextItemCopy = null;       //копирование выделенного текста
        ToolStripMenuItem contextItemCut = null;        //вырезание выделенного текста
        ToolStripMenuItem contextItemPast = null;       //вставка текста в указанно место
        ToolStripMenuItem contextItemUndo = null;       //отмена действия

        RichTextBox richTextBox = null;                 //текстовый блок
        string originalTxt = null;                      //содержание файла до редактирования
        string path = null;                             //путь к текстовому файлу

        //+-----------------------------------------------------------------------------+
        //КОНСТРУКТОРЫ КЛАССА: 
        //+-----------------------------------------------------------------------------+

        /// <summary>
        /// Конструктор по умолчанию. Созданает окно и его контроллеры.
        /// </summary>
        public FormMain()
        {          
            this.FormMainInitializtion();
            this.ToolStripContainerInitialization();
            this.MenuStripInitializtion();
            this.RichTextBoxInitialization();
            this.ContextMenuStripInitialization();
            this.EventsSubscription();
        }

        //+-----------------------------------------------------------------------------+
        //ГЛАВНОЕ ОКНО ТЕКСТОВОГО РЕДАКТОРА: 
        //+-----------------------------------------------------------------------------+

        /*
          Создание формы главного окна
        */private void FormMainInitializtion()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.DimGray;
            this.ForeColor = Color.White;
        }

        //+-----------------------------------------------------------------------------+
        //МЕНЮ ФОРМЫ: 
        //+-----------------------------------------------------------------------------+

        /*
          Создание панели меню окна
        */private void MenuStripInitializtion()
        {
            this.menuStrip = new MenuStrip();
            this.MainMenuStrip = this.menuStrip;
            this.Controls.Add(this.menuStrip);
            this.menuStrip.Dock = DockStyle.Top;

            this.menuStrip.BackColor = Color.DimGray;
            this.menuStrip.ForeColor = Color.LightSkyBlue;

            this.MenuStripItemFileInitialipation();
            this.MenuStripItemEditInitialipation();
            this.MenuStripItemFormatInitialipation();

            this.menuStrip.Show();
        }
        /*
          Создание раздела меню "Файл". Предназначен для работы с файлом.
        */private void MenuStripItemFileInitialipation()
        {
            this.menuStripItemFile = (ToolStripMenuItem)this.menuStrip.Items.Add("&Файл");

            this.itemFileCreate = (ToolStripMenuItem)this.menuStripItemFile.DropDownItems.Add("Создать");
            this.itemFileOpen = (ToolStripMenuItem)this.menuStripItemFile.DropDownItems.Add("Открыть");
            this.itemFileSave = (ToolStripMenuItem)this.menuStripItemFile.DropDownItems.Add("Сохранить");
            this.itemFileSaveAs = (ToolStripMenuItem)this.menuStripItemFile.DropDownItems.Add("Сохранить как...");
            this.itemFileClose = (ToolStripMenuItem)this.menuStripItemFile.DropDownItems.Add("Закрыть");

            this.itemFileCreate.ShortcutKeys = Keys.Control | Keys.N;
            this.itemFileOpen.ShortcutKeys = Keys.Control | Keys.O;
            this.itemFileSave.ShortcutKeys = Keys.Control | Keys.S;
            this.itemFileClose.ShortcutKeys = Keys.Control | Keys.Escape;

            this.itemFileCreate.ShowShortcutKeys = true;
            this.itemFileOpen.ShowShortcutKeys = true;
            this.itemFileSave.ShowShortcutKeys = true;
            this.itemFileClose.ShowShortcutKeys = true;
        }
        /*
           Создание раздела меню "Правка". Предназначен для редактирования текста.
        */private void MenuStripItemEditInitialipation()
        {
            this.menuStripItemEdit = (ToolStripMenuItem)this.menuStrip.Items.Add("&Правка");

            this.itemEditUndo = (ToolStripMenuItem)this.menuStripItemEdit.DropDownItems.Add("Отменить");
            this.itemEditCopy = (ToolStripMenuItem)this.menuStripItemEdit.DropDownItems.Add("Копировать");
            this.itemEditCut = (ToolStripMenuItem)this.menuStripItemEdit.DropDownItems.Add("Вырезать");
            this.itemEditPast = (ToolStripMenuItem)this.menuStripItemEdit.DropDownItems.Add("Вставить");
            this.itemSeparator = new ToolStripSeparator();
            this.menuStripItemEdit.DropDownItems.Add(this.itemSeparator);
            this.itemSelectAll = (ToolStripMenuItem)this.menuStripItemEdit.DropDownItems.Add("Выделить все");

            this.itemEditUndo.ShortcutKeys = Keys.Control | Keys.U;
            this.itemEditCopy.ShortcutKeys = Keys.Control | Keys.C;
            this.itemEditCut.ShortcutKeys = Keys.Control | Keys.X;
            this.itemEditPast.ShortcutKeys = Keys.Control | Keys.V;

            this.itemEditUndo.ShowShortcutKeys = true;
            this.itemEditCopy.ShowShortcutKeys = true;
            this.itemEditCut.ShowShortcutKeys = true;
            this.itemEditPast.ShowShortcutKeys = true;
        }
        /*
          Создание раздела меню "Шрифт". Предназначен для форматирования текста.
        */private void MenuStripItemFormatInitialipation()
        {
            this.menuStripItemFormat = (ToolStripMenuItem)this.menuStrip.Items.Add("&Формат");
            this.itemFormatFont = (ToolStripMenuItem)this.menuStripItemFormat.DropDownItems.Add("Шрифт...");
            this.itemFormatFont.ShortcutKeys = Keys.Control | Keys.F;
        }

        //+-----------------------------------------------------------------------------+
        //КОНТЕКСТНЫЕ МЕНЮ ФОРМЫ: 
        //+-----------------------------------------------------------------------------+

        /*
          Создание контекстного меню для объекта RichTextBox
        */private void ContextMenuStripInitialization()
        {
            this.contextMenu = new ContextMenuStrip();
            this.contextItemCopy = contextMenu.Items.Add("Копировать") as ToolStripMenuItem;
            this.contextItemCut = contextMenu.Items.Add("Вырезать") as ToolStripMenuItem;
            this.contextItemPast = contextMenu.Items.Add("Вставить") as ToolStripMenuItem;
            this.contextItemUndo = contextMenu.Items.Add("Отменить") as ToolStripMenuItem;
            this.richTextBox.ContextMenuStrip = this.contextMenu;
        }

        //+-----------------------------------------------------------------------------+
        //ПАНЕЛИ ИНСТРУМЕНТОВ ФОРМЫ: 
        //+-----------------------------------------------------------------------------+

        /*
          Создание контейнера для панелей инструментов
        */private void ToolStripContainerInitialization()
        {
            this.ToolStripFontInitializtion();
            this.ToolStripFileInitializtion();
            this.ToolStripEditInitializtion();

            this.toolStripContainer = new ToolStripContainer();
            this.toolStripContainer.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            this.toolStripContainer.Dock = DockStyle.Fill;
            this.toolStripContainer.ContentPanel.BackColor = Color.Thistle;
            this.toolStripContainer.TopToolStripPanel.BackColor = Color.DimGray;
            this.toolStripContainer.LeftToolStripPanel.BackColor = Color.DimGray;
            this.toolStripContainer.RightToolStripPanel.BackColor = Color.DimGray;
            this.toolStripContainer.BottomToolStripPanel.BackColor = Color.DimGray;

            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStripFont);
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStripEdite);
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStripFile);
            
            

            this.Controls.Add(this.toolStripContainer);
        }
        /*
           Создание панели инструментов "Файл".
        */private void ToolStripFileInitializtion()
        {
            this.toolStripFileImgList = new ImageList();

            this.toolStripFileImgList.Images.Add(new Bitmap(@".\ImgButtons\" +
                "NewFile.bmp"), Color.Black);
            this.toolStripFileImgList.Images.Add(new Bitmap(@".\ImgButtons\" +
                "OpenFile.bmp"), Color.Black);
            this.toolStripFileImgList.Images.Add(new Bitmap(@".\ImgButtons\" +
                 "SaveFile.bmp"), Color.Black);
            this.toolStripFileImgList.Images.Add(new Bitmap(@".\ImgButtons\" +
                "CloseFile.bmp"), Color.Black);

            this.buttonFileCreate = new ToolStripButton();
            this.buttonFileOpen = new ToolStripButton();
            this.buttonFileSave = new ToolStripButton();
            this.buttonFileClose = new ToolStripButton();

            this.buttonFileCreate.ImageIndex = 0;   //Create file
            this.buttonFileOpen.ImageIndex = 1;     //Open file
            this.buttonFileSave.ImageIndex = 2;     //Save file
            this.buttonFileClose.ImageIndex = 3;    //Close file

            this.buttonFileCreate.ToolTipText = "Создать файл";
            this.buttonFileOpen.ToolTipText = "Открыть файл";
            this.buttonFileSave.ToolTipText = "Сохранить файл";
            this.buttonFileClose.ToolTipText = "Закрыть файл";

            this.toolStripFile = new ToolStrip();
            this.toolStripFile.Renderer = new ToolStripOverride();
            this.toolStripFile.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            this.toolStripFile.BackColor = Color.DimGray;
            this.toolStripFile.ForeColor = Color.LightSkyBlue;
            this.toolStripFile.CanOverflow = true;
            this.toolStripFile.ImageList = this.toolStripFileImgList;

            this.toolStripFile.Items.Add(this.buttonFileCreate);
            this.toolStripFile.Items.Add(this.buttonFileOpen);
            this.toolStripFile.Items.Add(this.buttonFileSave);
            this.toolStripFile.Items.Add(this.buttonFileClose);
        }
        /*
          Создание панели инструментов "Правка".
        */private void ToolStripEditInitializtion()
        {
            this.toolStripEditImgList = new ImageList();
            this.toolStripEditImgList.Images.Add(new Bitmap(@".\ImgButtons\"+
                "Undo.bmp"), Color.Black);
            this.toolStripEditImgList.Images.Add(new Bitmap(@".\ImgButtons\"+
                "Copy.bmp"), Color.Black);
            this.toolStripEditImgList.Images.Add(new Bitmap(@".\ImgButtons\" +
                "Cut.bmp"), Color.Black);
            this.toolStripEditImgList.Images.Add(new Bitmap(@".\ImgButtons\" +
                "Paste.bmp"), Color.Black);

            this.buttonEditUndo = new ToolStripButton();
            this.buttonEditCopy = new ToolStripButton();
            this.buttonEditCut = new ToolStripButton();
            this.buttonEditPust = new ToolStripButton();

            this.buttonEditUndo.ImageIndex = 0;
            this.buttonEditCopy.ImageIndex = 1;
            this.buttonEditCut.ImageIndex = 2;
            this.buttonEditPust.ImageIndex = 3;

            this.buttonEditUndo.ToolTipText = "Отмена";
            this.buttonEditCopy.ToolTipText = "Копировать";
            this.buttonEditCut.ToolTipText = "Вырезать";
            this.buttonEditPust.ToolTipText = "Вставить";

            this.toolStripEdite = new ToolStrip();
            this.toolStripEdite.Renderer = new ToolStripOverride();
            this.toolStripEdite.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            this.toolStripEdite.BackColor = Color.DimGray;
            this.toolStripEdite.ForeColor = Color.White;
            this.toolStripFile.CanOverflow = true;
            this.toolStripEdite.ImageList = this.toolStripEditImgList;

            this.toolStripEdite.Items.Add(this.buttonEditUndo);
            this.toolStripEdite.Items.Add(this.buttonEditCopy);
            this.toolStripEdite.Items.Add(this.buttonEditCut);
            this.toolStripEdite.Items.Add(this.buttonEditPust);
        }
        /*           
          Создание панели инструментов "Шрифт".
        */private void ToolStripFontInitializtion()
        {
            this.ComboBoxFontInitialaization();
            this.ComboBoxFontSizeInitialization();
            this.ToolStripButtonColorInitialization();

            this.toolStripFont = new ToolStrip();
            this.toolStripFont.Renderer = new ToolStripOverride();
            this.toolStripFont.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.toolStripFont.BackColor = Color.DimGray;
            this.toolStripFont.ForeColor = Color.White;
            this.toolStripFont.CanOverflow = true;

            this.toolStripFont.Items.Add(this.comboBoxFont);
            this.toolStripFont.Items.Add(this.comboBoxSize);
            this.toolStripFont.Items.Add(this.buttonColor);
        }

        /*
          Создание выпадающего списка со шрифтами для панели инструментов "Шрифт"
        */private void ComboBoxFontInitialaization()
        {
            this.comboBoxFont = new ToolStripComboBox();
            this.comboBoxFont.MaxDropDownItems = 10;
            this.comboBoxFont.Sorted = true;
            this.comboBoxFont.ToolTipText = "Выбор шрифта";
            
            //TODO: Установить дэфолтное значение шрифта равное шрифту открываемого текстового файла
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                this.comboBoxFont.Items.Add(font.Name);
            }
        }
        /*
          Создание выподающего меню на панели инструментов "Файл", для управления 
          размером текста.
        */private void ComboBoxFontSizeInitialization()
        {
            this.comboBoxSize = new ToolStripComboBox();
            this.comboBoxSize.MaxDropDownItems = 10;
            this.comboBoxSize.MaxLength = 2;
            this.comboBoxSize.AutoSize = true; //TODO: Изменить размер ComboBox
            this.comboBoxSize.ToolTipText = "Размер шрифта";

            int minFontSize = 8;
            int maxFontSize = 72;
            
            //TODO: Установить дэфолтное значение шрифта равное шрифту открываемого текстового файла
            for(int i = minFontSize; i <= maxFontSize; ++i)
            {
                this.comboBoxSize.Items.Add(i);
            }
        }
        /*
          Создание кнопки на панели инструментов "Шрифт". 
          Предназначена для управления цветом шрифта
        */private void ToolStripButtonColorInitialization()
        {
            this.buttonColor = new ToolStripButton();
            this.buttonColor.Image = new Bitmap(@".\ImgButtons\FontColor.bmp");
            this.buttonColor.ImageTransparentColor = Color.Black;
            this.buttonColor.ToolTipText = "Цвет шрифта";

        }

        //+-----------------------------------------------------------------------------+
        //ТЕКСТОВЫЙ БЛОК ФОРМЫ: 
        //+-----------------------------------------------------------------------------+

        /*
          Создает текстовое поле для работы с текстом.
        */private void RichTextBoxInitialization()
        {
            this.richTextBox = new RichTextBox();
            this.richTextBox.BackColor = Color.LightGray;
            this.richTextBox.ForeColor = Color.Black;
            this.richTextBox.WordWrap = true;
            this.richTextBox.AutoWordSelection = true;
            this.richTextBox.Dock = DockStyle.Fill;
            this.richTextBox.HideSelection = false;
            this.richTextBox.Parent = this.toolStripContainer.ContentPanel;
        }

        //+-----------------------------------------------------------------------------+
        //МЕТОДЫ ДЛЯ РАБОТЫ С RTF ФАЙЛОМ: 
        //+-----------------------------------------------------------------------------+

        /*
          Открывает диалоговое окно "Открытие файла"
        */private void OpenFileDialog()
        {
            OpenFileDialog openFileDialog = null;
            openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "rtf files (*.rtf) | *rtf";

            DialogResult dialogResult;
            dialogResult = openFileDialog.ShowDialog(this);

            if (dialogResult == DialogResult.OK)
            {
                if (openFileDialog.CheckPathExists)
                {
                    this.path = openFileDialog.FileName;
                    this.Text = this.path;
                    this.richTextBox.LoadFile(this.path);
                    this.originalTxt = this.richTextBox.Text;
                }
            }
            openFileDialog.Dispose();
        }
        /*
          Открывает диалоговое окно "Сохранить файл"
        */private DialogResult OpenSaveFileDialog()
        {
            SaveFileDialog saveFileDialog = null;
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.SupportMultiDottedExtensions = false;
            saveFileDialog.Filter = "rtf files (*.rtf) | *.rtf";
            saveFileDialog.DefaultExt = "rtf";

            DialogResult dialogRisult;
            dialogRisult = saveFileDialog.ShowDialog(this);

            if(dialogRisult == DialogResult.OK)
            {
                if(saveFileDialog.CheckPathExists)
                {
                    this.path = saveFileDialog.FileName;
                    this.Text = this.path;
                    this.richTextBox.SaveFile(this.path);
                    this.originalTxt = this.richTextBox.Text;
                }
            }
            saveFileDialog.Dispose();
            return dialogRisult;
        }
        /*
          Открывает диалоговое окно "Форматировани шрифта"
        */private DialogResult FontFormattingDialog()
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.AllowScriptChange = true;
            fontDialog.AllowSimulations = true;
            fontDialog.AllowVectorFonts = true;
            fontDialog.AllowVerticalFonts = true;
            fontDialog.FontMustExist = true;
            fontDialog.ShowEffects = true;
            fontDialog.ShowColor = true;
            
            if(!String.IsNullOrEmpty(this.richTextBox.SelectedRtf))
            {
                fontDialog.Font = this.richTextBox.SelectionFont;
                fontDialog.Color = this.richTextBox.SelectionColor;
            }
            else
            {
                fontDialog.Font = this.richTextBox.Font;
                fontDialog.Color = this.richTextBox.SelectionColor;
            }

            DialogResult dialogResult;
            dialogResult = fontDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                this.richTextBox.SelectionFont = fontDialog.Font;
                this.richTextBox.SelectionColor = fontDialog.Color;
            }

            fontDialog.Dispose();

            return dialogResult;
        }
        /*
          Создание диалогового окна "выбора цвета шрифта"
        */private DialogResult OpenColorDialog()
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.AnyColor = true;
            colorDialog.FullOpen = true;

            DialogResult dialogResult;
            dialogResult = colorDialog.ShowDialog(this);

            if(dialogResult == DialogResult.OK)
            {
                this.richTextBox.SelectionColor = colorDialog.Color;
            }

            colorDialog.Dispose();
            return dialogResult;
        }

        /*
          Создает в окне текстового редактора новое текстовое поле для 
          редактирования текста.
        */private void CreateFile()
        {
            DialogResult dialogResult;
            if (!String.IsNullOrEmpty(this.richTextBox.Text) && this.path == null)
            {
                dialogResult = MessageBox.Show(this, "Сохранить документ?",
                    "Уведомление:", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    dialogResult = this.OpenSaveFileDialog();
                }
            }
            else
            {
                if ((!String.IsNullOrEmpty(this.richTextBox.Text) ||
                    !String.Equals(this.originalTxt, this.richTextBox))
                    && this.path != null)
                {
                    if (!String.Equals(this.originalTxt, this.richTextBox.Text))
                    {
                        dialogResult = MessageBox.Show(this, "Сохранить изменения?",
                            "Уведомление:", MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.OK)
                        {
                            this.SaveFile();
                        }
                    }
                }
            }
            this.path = null;
            this.Text = "путь хранения документа не задан";
            this.richTextBox.Clear();
            this.originalTxt = this.richTextBox.Text;
        }
        /*
          Сохраняет открытй документ в окне текстового редактора
        */private void SaveFile()
        {
            if (this.path != null)
            {
                this.richTextBox.SaveFile(this.path);
                this.originalTxt = this.richTextBox.Text;
            }
            else
            {
                this.OpenSaveFileDialog();
            }
        }
        /*
          Закрывает окно текстового редактора
        */private void CloseFile()
        {
            DialogResult dialogResult;
            if (!String.IsNullOrEmpty(this.richTextBox.Text) && this.path == null)
            {
                dialogResult = MessageBox.Show(this, "Сохранить документ?",
                    "Уведомление:", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    dialogResult = this.OpenSaveFileDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        this.Dispose();
                    }
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(this.richTextBox.Text) && this.path != null)
                {
                    if (!String.Equals(this.originalTxt, this.richTextBox.Text))
                    {
                        dialogResult = MessageBox.Show(this, "Сохранить документ?",
                            "Уведомление:", MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.OK)
                        {
                            this.richTextBox.SaveFile(this.path);
                        }
                    }
                    this.Dispose();
                }
                else
                {
                    this.Dispose();
                }
            }
        }

        /*
          Уставнока значения по умолчания для объекта ComboBox, являющегося 
          частью панели инструментов "Шрифт" и отвечающего за редактирование
          типа шрифта в выделенной пользователем части текста.
        */private void SetDefaultComboBoxFontValue()
        {
            this.richTextBox.SelectAll();
            this.comboBoxFont.SelectedItem = this.richTextBox.SelectionFont.Name;
            this.richTextBox.DeselectAll();
        }
        /*
          Устанавливает выбранный пользователем шрифт для выделенного пользователем
          текстового фрагмента.
        */private void SetFontOfSelectedText()
        {
            Font oldFont = null;
            oldFont = this.richTextBox.SelectionFont;

            float emSize; 
            emSize = oldFont.SizeInPoints;

            FontStyle fontStyle;
            fontStyle = this.richTextBox.Font.Style;

            string fontFamilyName = null;
            fontFamilyName = this.comboBoxFont.SelectedItem.ToString();

            FontFamily fontFamily;
            fontFamily = new FontFamily(fontFamilyName);

            Font font = null;
            font = new Font(fontFamily, emSize, fontStyle);

            this.richTextBox.SelectionFont = font;
        }
        /*
          Уставнока значения по умолчания для объекта ComboBox, являющегося 
          частью панели инструментов "Шрифт" и отвечающего за редактирование
          размера шрифта в выделенном пользователем фрагменте текста.
        */private void SetDefaultComboBoxSizeValue()
        {
            this.richTextBox.SelectAll();
            float size;

            if (String.IsNullOrEmpty(this.richTextBox.Text))
            {
                size = this.richTextBox.Font.Size;
            }
            else
            {
                size = this.richTextBox.SelectionFont.Size;
            }
            this.comboBoxSize.Text = size.ToString();
        }
        /*
          Устанавливает выбранный пользователем размер шрифта для выделенного 
          пользователем текстового фрагмента.
        */private void SetSizeOfSelectesText()
        {
            int size = 0;
            try
            {
                size = int.Parse(this.comboBoxSize.SelectedItem.ToString());
            }
            catch (OverflowException)
            {
                String message = String.Format("Размер шрифта не может быть меньше " +
                    "1 и больше 72");
                MessageBox.Show(message, "Уведомление: ", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                String message = String.Format("Указан неверный формат значения " +
                    "размера шрифта. Данное значение поддерживает работу " +
                    "только с числовыми значениями");
                MessageBox.Show(message, "Уведомление: ", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            Font oldFont = null;
            oldFont = this.richTextBox.SelectionFont;

            FontFamily fontFamily = null;
            fontFamily = oldFont.FontFamily;

            Font newFont = null;
            newFont = new Font(fontFamily, size);

            this.richTextBox.SelectionFont = newFont;
        }

        //+-----------------------------------------------------------------------------+
        //ОБРАБОТЧИКИ СОБЫТИЙ: 
        //+-----------------------------------------------------------------------------+

        /*
          Подкиски на события окна и его дочерних элементов.
        */private void EventsSubscription()
        {
            //Подписка на событие выбора одного из пунктов в меню "Файл"
            this.itemFileCreate.Click   += new EventHandler (this.ItemFileCreateClick   );
            this.itemFileOpen.Click     += new EventHandler (this.ItemFileOpenClick     );
            this.itemFileSave.Click     += new EventHandler (this.ItemFileSaveClick     );
            this.itemFileSaveAs.Click   += new EventHandler (this.ItemFileSaveAsClick   );
            this.itemFileClose.Click    += new EventHandler (this.ItemFileCloseClick    );

            //Подписка на событие выбора одного из пунктов в меню "Правка"
            this.itemEditUndo.Click     += new EventHandler (this.ItemEditUndoClick     );
            this.itemEditCopy.Click     += new EventHandler (this.ItemEditCopyClick     );
            this.itemEditCut.Click      += new EventHandler (this.ItemEditCutClick      );
            this.itemEditPast.Click     += new EventHandler (this.ItemEditPastClick     );
            this.itemSelectAll.Click    += new EventHandler (this.ItemSelectAllClick    );

            //Подписка на событие выбора одного из пунктов в меню "Формат"
            this.itemFormatFont.Click += new EventHandler   (this.ItemFormatFontClick   );

            //Подписка на событие нажатия одной из кнопок панели инструментов
            //отвечающей за работу с файлом
            this.buttonFileCreate.Click += new EventHandler (this.ButtonFileCreateClick );
            this.buttonFileOpen.Click   += new EventHandler (this.ButtonFileOpenClick   );
            this.buttonFileSave.Click   += new EventHandler (this.ButtonFileSaveClick   );
            this.buttonFileClose.Click  += new EventHandler (this.ButtonFileCloseClick  );

            //Подписка на событие нажатия одной из кнопок панели инструментов
            //отвечающей за редактирование файла
            this.buttonEditUndo.Click   += new EventHandler (this.ButtonEditUndoClick   );
            this.buttonEditCopy.Click   += new EventHandler (this.ButtonEditCopyClick   );
            this.buttonEditCut.Click    += new EventHandler (this.ButtonEditCutClick    );
            this.buttonEditPust.Click   += new EventHandler (this.ButtonEditPastClick   );

            //Подписка на событие нажатия одного из пунктов контекстного меню объекта
            //RichTextBox
            this.contextItemCopy.Click  += new EventHandler (this.ContextItemCopyClick  );
            this.contextItemCut.Click   += new EventHandler (this.ContextItemCutClick   );
            this.contextItemPast.Click  += new EventHandler (this.ContextItemPastClick  );
            this.contextItemUndo.Click  += new EventHandler (this.ContextItemUndoClick  );

            //Подписка на событие нажатия одной из кнопок панели инструментов
            //отвечающей за работу с форматом текста
            this.comboBoxFont.SelectedIndexChanged += 
                new EventHandler(this.ComboBoxFontChanged);
            this.comboBoxSize.SelectedIndexChanged += 
                new EventHandler(this.ComboBoxSizeChanged);
            this.buttonColor.Click      += new EventHandler (this.ButtonColorClick      );

            //Обработка событий принадлежащих объекту RichTextBox
            this.richTextBox.HandleCreated+=new EventHandler(this.RichTextBoxCreated    );
            this.richTextBox.MouseClick+=new MouseEventHandler(this.RichTextBoxMouseClick);

            this.FormClosing += new FormClosingEventHandler (this.FormClosingClick      );
        }

        /*
          Нажатие кнопки мыши в меню - "Файл" на пункте меню - "Создать" 
        */private void ItemFileCreateClick(Object sender, EventArgs e)
        {
            this.CreateFile();
        }
        /*
          Нажатие кнопки мыши в меню - "Файл" на пункте меню - "Открыть"
        */private void ItemFileOpenClick  (Object sender, EventArgs e)
        {
            this.OpenFileDialog();
        }
        /*
          Нажатие кнопки мыши в меню - "Файл" на пункте меню - "Сохранить"
        */private void ItemFileSaveClick  (Object sender, EventArgs e)
        {
            this.SaveFile();
        }
        /*
           Нажатие кнопки мыши в меню - "Файл" на пункте меню - "Сохранить как..."
        */private void ItemFileSaveAsClick(Object sender, EventArgs e)
        {
            this.OpenSaveFileDialog();
        }
        /*
          Нажатие кнопки мыши в меню - "Файл" на пункте меню - "Закрыть"
        */private void ItemFileCloseClick (Object sender, EventArgs e)
        {
            this.CloseFile();
        }

        /*
        Нажатие кнопки мыши в меню - "Правка" на пункте меню - "Отмена"
        */private void ItemEditUndoClick  (Object sender, EventArgs e)
        {
            if(this.richTextBox.CanUndo)
            {
                this.richTextBox.Undo();
            }
        }
        /*
          Нажатие кнопки мыши в меню - "Правка" на пункте меню - "Копировать"
        */private void ItemEditCopyClick  (Object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.richTextBox.SelectedRtf))
            {
                this.richTextBox.Copy();
            }
        }
        /*
          Нажатие кнопки мыши в меню - "Правка" на пункте меню - "Вырезать"
        */private void ItemEditCutClick   (Object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(this.richTextBox.Text))
            {
                this.richTextBox.Cut();
            }
        }
        /*
          Нажатие кнопки мыши в меню - "Правка" на пункте меню - "Вставить"
        */private void ItemEditPastClick  (Object sender, EventArgs e)
        {
            this.richTextBox.Paste();
        }
        /*
          Нажатие кнопки мыши в меню - "Правка" на пункте меню - "Выделить все"
        */private void ItemSelectAllClick (Object sender, EventArgs e)
        {
            this.richTextBox.SelectAll();
        }

        /*
          Нажатие кнопки мыши в меню - "Форма" на пункте меню - "Шрифт"
        */private void ItemFormatFontClick(Object sender, EventArgs e)
        {
            this.FontFormattingDialog();
        }

        /*
          Нажатие кнопки "Создать" на панели инструментов "Файл"
        */private void ButtonFileCreateClick(Object sender, EventArgs e)
        {
            this.CreateFile();
        }
        /*
          Нажатие кнопки "Открыть" на панели инструментов "Файл"
        */private void ButtonFileOpenClick(Object sender, EventArgs e)
        {
            this.OpenFileDialog();
        }
        /*
          Нажатие кнопки "Сохранить" на панели инструментов "Файл"
        */private void ButtonFileSaveClick(Object sender, EventArgs e)
        {
            this.SaveFile();
        }
        /*
          Нажатие кнопки "Закрыть" на панели инструментов "Файл"
        */private void ButtonFileCloseClick(Object sender, EventArgs e)
        {
            this.CloseFile();
        }

        /*
          Нажатие кнопки "Отменить" на панели инструментов "Правка"
        */private void ButtonEditUndoClick(Object sender, EventArgs e)
        {
            if (this.richTextBox.CanUndo)
            {
                this.richTextBox.Undo();
            }
        }
        /*
          Нажатие кнопки "Копировать" на панели инструментов "Правка"
        */private void ButtonEditCopyClick(Object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.richTextBox.SelectedRtf))
            {
                this.richTextBox.Copy();
            }
        }
        /*
          Нажатие кнопки "Вырезать" на панели инструментов "Правка"
        */private void ButtonEditCutClick (Object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.richTextBox.Text))
            {
                this.richTextBox.Cut();
            }
        }
        /*
          Нажатие кнопки "Вставить" на панели инструментов "Правка"
        */private void ButtonEditPastClick(Object sender, EventArgs e)
        {
            this.richTextBox.Paste();
        }

        /*
          Нажатие кнопки "Копировать" в контекстном меню текстового поля
        */private void ContextItemCopyClick(Object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.richTextBox.SelectedRtf))
            {
                this.richTextBox.Copy();
            }
        }
        /*
          Нажатие кнопки "Вырезать" в контекстном меню текстового поля
        */private void ContextItemCutClick(Object sender, EventArgs e )
        {
            if (!String.IsNullOrEmpty(this.richTextBox.Text))
            {
                this.richTextBox.Cut();
            }
        }
        /*
          Нажатие кнопки "Вставить" в контекстном меню текстового поля
        */private void ContextItemPastClick(Object sender, EventArgs e)
        {
            this.richTextBox.Paste();
        }
        /*
          Нажатие кнопки "Отмена" в контекстном меню текстового поля
        */private void ContextItemUndoClick(Object sender, EventArgs e)
        {
            if (this.richTextBox.CanUndo)
            {
                this.richTextBox.Undo();
            }
        }

        /*
          Обработка события выбора вользователем нового типа шрифта для заданного
          фрагмента текста, в выпадающем меню на панели инструментов "Шрифт"
        */private void ComboBoxFontChanged(Object sender, EventArgs e)
        {
            this.SetFontOfSelectedText();
        }
        /*
          Обработка события выбора вользователем нового размера шрифта для заданного
          фрагмента текста, в выпадающем меню на панели инструментов "Шрифт"
        */private void ComboBoxSizeChanged(Object sender, EventArgs e)
        {
            this.SetSizeOfSelectesText();
        }
        /*
          Обработка события выбора вользователем нового цвета шрифта для заданного
          фрагмента текста, в выпадающем меню на панели инструментов "Шрифт"
        */private void ButtonColorClick   (Object sender, EventArgs e)
        {
            this.OpenColorDialog();
        }

        /*
          Устанвка дэфолтных значение выпадающих меню "Тип шрифта" и 
          "Размер шрифта" расколоженных на панели инструментов "Шрифт"
        */private void RichTextBoxCreated (Object sender, EventArgs e)
        {
            this.SetDefaultComboBoxFontValue();
            this.SetDefaultComboBoxSizeValue();
        }
        /*
          Определяет и устанавливает во время работы с файлом соответствующие значения 
          выпадающих меню "Тип шрифта" и "Размер шрифта" расколоженных на панели 
          инструментов "Шрифт"
        */private void RichTextBoxMouseClick(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                string fontName = null;
                if (this.richTextBox.SelectionFont != null)
                {
                    fontName = this.richTextBox.SelectionFont.Name;
                    this.comboBoxFont.Text = fontName;
                    this.comboBoxFont.SelectedItem = fontName;

                    float fontSize;
                    fontSize = this.richTextBox.SelectionFont.Size;
                    this.comboBoxSize.Text = fontSize.ToString();
                }
                else
                {
                    this.comboBoxFont.Text = "";
                    this.comboBoxSize.Text = "";
                }
            }
        }

        /*
            Обработка события нажатия кнопки "Закрыть окно".
            Закрывает окно редактора. Перед закрытием пользователю предлагается
            сохранить отредактированный документ.
        */private void FormClosingClick(Object sender, FormClosingEventArgs e)
        {
            this.CloseFile();
        }
    }
}
