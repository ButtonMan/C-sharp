using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingMouseEvents
{
    //КЛАСС MyForm
    //+-----------------------------------------------------------------------+

    /// <summary>
    /// Класс MyForm, отвечает за взаимодействие окна приложения 
    /// с мышью
    /// </summary>
    class MyForm : Form
    {
        //КОНСТРУКТОРЫ КЛАССА:
        //+-------------------------------------------------------------------+
        public MyForm()
        {
            this.Text = "Обработка мышиных событий!";
            MouseDown += new MouseEventHandler(MouseButtonsOn);
            
        }



        //МЕТОДЫ КЛАССА:
        //+-------------------------------------------------------------------+
        public void MouseButtonsOn(Object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                MessageBox.Show(text: "Зажата ЛЕВАЯ кнопкая мыши",
                                caption: "Уведомления");
            }

            if(e.Button == MouseButtons.Right)
            {
                MessageBox.Show(text: "Зажата ПРАВАЯ кнопкая мыши",
                caption: "Уведомления");
            }

            if(e.Button == MouseButtons.Middle)
            {
                MessageBox.Show(text: "Зажата СРЕДНАЯЯ кнопкая мыши",
                caption: "Уведомления");
            }
        }
    }
}
