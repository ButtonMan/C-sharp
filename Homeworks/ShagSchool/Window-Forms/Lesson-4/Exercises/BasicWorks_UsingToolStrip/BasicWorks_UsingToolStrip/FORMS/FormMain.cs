using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BasicWorks_UsingToolStrip.Forms
{
    class FormMain : Form
    {

        //ПОЛЯ КЛАССА:
        //+-------------------------------------------------------------------+

        ToolStrip toolStrip = null;                  //панель инструментов
        ToolStripButton toolStripButton = null;      //кнопка панели инстр.
        ToolStripSeparator toolStripSeparator = null;//разделитель панели инстр.
        ToolStripLabel toolStripLabel = null;        //метка панели инстр.
        ToolStripDropDownButton toolStripDropDownButton = null;//список панели
        ToolStripSplitButton toolStripSplitButton = null;//кнопка разделитель
        ToolStripTextBox toolStripTextBox = null;    //текстовое полек панели
        ToolStripComboBox toolStripComboBox = null;  //выпадающий список



        //КОНСТРУКТОРЫ КЛАССА:
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Создает главное окно программы и его контролы
        /// </summary>
        public FormMain()
        {
            this.FormMainInitialization();
            this.ToolStripInitialization();
        }



        //МЕТОДЫ КЛАССА:
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Создает главное окно программы
        /// </summary>
        private void FormMainInitialization()
        {
            this.ClientSize = new Size(700, 350);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.DimGray;
            this.ForeColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        /// <summary>
        /// Создает панель инструментов в главном окне программы
        /// </summary>
        private void ToolStripInitialization()
        {
            this.toolStrip = new ToolStrip();
            this.Controls.Add(this.toolStrip);
            this.toolStrip.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            this.toolStrip.BackColor = Color.LightSkyBlue;

            this.toolStripButton = new ToolStripButton();
            this.toolStripButton.Text = "Button";
            this.toolStripButton.Image = Image.FromFile(
                @"D:\Женя\ДИЗАЙНЫ\22e2e5b92a06606b25d13a904cc52e9e.jpg");
            this.toolStripSeparator = new ToolStripSeparator();
            this.toolStripLabel = new ToolStripLabel();
            this.toolStripLabel.Text = "Teкстовая метка: ";
            this.toolStripDropDownButton = new ToolStripDropDownButton();
            this.toolStripDropDownButton.DropDownItems.Add("кнопка \"а\"");
            this.toolStripDropDownButton.DropDownItems.Add("кнопка \"б\"");
            this.toolStripDropDownButton.DropDownItems.Add("кнопка \"c\"");
            this.toolStripDropDownButton.Text = "DropDownButton";
            this.toolStripSplitButton = new ToolStripSplitButton();
            this.toolStripSplitButton.DropDownItems.Add("кнопка \"а\"");
            this.toolStripSplitButton.DropDownItems.Add("кнопка \"б\"");
            this.toolStripSplitButton.DropDownItems.Add("кнопка \"c\"");
            this.toolStripSplitButton.Text = "SplitButton";
            this.toolStripTextBox = new ToolStripTextBox();
            this.toolStripTextBox.Text = "TextBox";
            this.toolStripComboBox = new ToolStripComboBox();
            this.toolStripComboBox.Text = "ComboBox";

            this.toolStrip.Items.Add(this.toolStripButton);
            this.toolStrip.Items.Add(new ToolStripSeparator());
            this.toolStrip.Items.Add(this.toolStripLabel);
            this.toolStrip.Items.Add(new ToolStripSeparator());
            this.toolStrip.Items.Add(this.toolStripDropDownButton);
            this.toolStrip.Items.Add(new ToolStripSeparator());
            this.toolStrip.Items.Add(this.toolStripSplitButton);
            this.toolStrip.Items.Add(this.toolStripTextBox);
            this.toolStrip.Items.Add(this.toolStripComboBox);

            this.toolStrip.Show();
        }
    }
}
