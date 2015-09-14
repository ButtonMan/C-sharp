using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingMouseClick
{
    //КЛАСС MyForm
    //+-----------------------------------------------------------------------+

    /// <summary>
    /// Класс обспечивающий взаимодействия пользователя с формой.
    /// При нажатии на левую кнопку мыши, должно появиться диалоговое окно,
    /// с информацией о нажатой клавише и координатах курсора.
    /// </summary>
    class MyForm : Form
    {

        //КОНСТРУКТОРЫ КЛАССА:
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public MyForm()
        {
            this.Text = "Обработка события  MouseClick";
            this.Size = new System.Drawing.Size(400, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.SlateGray;
            MouseClick += new MouseEventHandler(this.MouseClickOn);
        }



        //МЕТОДЫ КЛАССА:
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Метод обрабатывающий событие нажатия левой кнопки мыши
        /// </summary>
        /// <param name="sender">источник события</param>
        /// <param name="e">объект класса MouseEventArgs</param>
        public void MouseClickOn(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                string mouseCoord = "X: " + e.X.ToString() + "  " +
                    "Y: " + e.Y.ToString();
                MessageBox.Show(
                    text: "Была нажата: " + e.Button.ToString() + 
                    " кнопка мыши " + Environment.NewLine + mouseCoord,
                    caption: "Уведомление!", 
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Information, 
                    defaultButton: MessageBoxDefaultButton.Button1);
            }
        }
    }
}
