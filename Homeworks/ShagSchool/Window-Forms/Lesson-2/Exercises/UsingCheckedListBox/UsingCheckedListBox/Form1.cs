using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingCheckedListBox
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Конструктор без параметров.
        /// Создает окно и все контроллеры расположенные в окне
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку Add to CheckedBoxList.
        /// Добавляет новой имя в список имен CheckedBoxList.
        /// </summary>
        private void ButtonAddToCheckedBoxClickOn(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.textBoxNewItem.Text))
            {
                String newItemName = String.Copy(this.textBoxNewItem.Text);
                newItemName = newItemName.Trim();
                if (!this.checkedListBoxUsers.Items.Contains(newItemName))
                {
                    this.checkedListBoxUsers.Items.Add(newItemName);
                    this.textBoxNewItem.Text = null;
                }
                else
                {
                    MessageBox.Show("Данное имя уже существует!" +
                        Environment.NewLine + "Имена не могут быть одинаковыми!",
                        "Уведомление", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    this.textBoxNewItem.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Попытка присвоить полю пустое значение!",
                    "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddSelectedClickOn(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection selected = 
                this.checkedListBoxUsers.CheckedItems;
            if (selected.Count > 0)
            {
                for (int i = 0; i < selected.Count; ++i)
                {
                    if (!this.checkedListBoxUsersSelected.Items.Contains(selected[i]))
                    {
                        this.checkedListBoxUsersSelected.Items.Add(selected[i]);
                    }
                }
                for (int i = 0; i < this.checkedListBoxUsers.Items.Count; ++i)
                {
                    this.checkedListBoxUsers.SetItemChecked(i, false);
                }
            }
            else
            {
                MessageBox.Show("Не выбрано ни одно из значений!" +
                    Environment.NewLine + "Пожалуйста сделайте ваш выбор!", 
                    "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
