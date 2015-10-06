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
using Hometask_2.Entities;



namespace Hometask_2.Forms
{
    public partial class FormOrder : Form
    {
        //ПОЛЯ КЛАССА
        //+-------------------------------------------------------------------+
        private FormCreateAndEdit formCreateAndEdit;//Форма для редактирования
                                                    //инфо. о новых товарах и 
                                                    //редактирвания данных о
                                                    //уже существующих
        private Category categories = null;         //названия тов. категорий
        private Assortment assortment = null;       //описание товаров
        private Product selectedProduct = null;     //выбранный продукт
        private static double totalOrderPrice = 0.0;//сумма заказа



        //КОНСТРУКТОРЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public FormOrder()
        {
            this.InitializeComponent();
        }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="categories">информация о существующих товарных
        /// категориях, представленная объектом класса Category</param>
        /// <param name="assortment">Информация об ассортименте товаров,
        /// представленная объектом класса Аssortment</param>
        public FormOrder(Category categories = null, Assortment assortment = 
            null) : this()
        {
            this.categories = categories;
            this.assortment = assortment;
            this.ComboBoxProductsInitialization();
        }



        //МЕТОДЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Создание формы для редактирования информации о товаре
        /// </summary>
        /// <returns>объект класса DialogResult</returns>
        private DialogResult FormCreateAndEditInitialization()
        {
            if(this.formCreateAndEdit != null)
            {
                this.formCreateAndEdit.Close();
                this.formCreateAndEdit.Dispose();
                this.formCreateAndEdit = null;
            }
            else
            {
                this.formCreateAndEdit = new FormCreateAndEdit(this.categories,
                    this.assortment, this.selectedProduct);
                this.formCreateAndEdit.Owner = this;
            }
            return this.formCreateAndEdit.ShowDialog(this);   
        }
        /// <summary>
        /// Создание контроллера "ComboBox". В качестве подписей для 
        /// пунктов выпадающего списка, используются названия продуктов
        /// добавленные ранее в ассортимент товаров.
        /// </summary>
        private void ComboBoxProductsInitialization()
        {
            if (this.categories == null || this.assortment == null)
            {
                this.comboBoxProducts.Items.Add("не заданы");
            }
            else
            {
                foreach(string key in this.assortment.GetKeyCollection())
                {
                    if (!String.IsNullOrEmpty(key) && !String.IsNullOrWhiteSpace(key))
                    {
                        Dictionary<string, Product> subDictionary = assortment[key];
                        foreach (Product prodact in subDictionary.Values)
                        {
                            this.comboBoxProducts.Items.Add(prodact.Name);
                        }
                    }
                }
            }
        }



        //ОБРАБОТЧИКИ СОБЫТИЙ
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Обработка нажатия кнопки "Добавить". Добавляет выбранный товар 
        /// в заказ.
        /// </summary>
        private void ButtonAddClick(Object sender, EventArgs e)
        {
            if (this.selectedProduct == null)
            {
                MessageBox.Show(
                    text: "Операция добавления товара в заказ " +
                    "не может быть выполнена. Не выбрано имя товара, " +
                    "который необходимо добавить в заказ. " +
                    "Выберите необходимый товар и повторите попытку.",
                    caption: "Уведомление",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Exclamation);
            }
            else
            {
                this.listBoxOrderInfo.Items.Add(selectedProduct.Name);
                totalOrderPrice += selectedProduct.Price;
                this.textBoxTotalPrice.Text = totalOrderPrice.ToString();
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Редактировать". Создает окно
        /// предоставляющее возможность редактировать информацию о выбранном
        /// товаре.
        /// </summary>
        private void ButtonEditClick(Object sender, EventArgs e)
        {
            if(this.selectedProduct == null )
            {
                MessageBox.Show(
                    text: "Операция редактирования " +
                    "не может быть выполнена. Не выбрано имя товара, " +
                    "информацию о котором необходимо отредактировать. " +
                    "Выберите имя товара и повторите попытку.",
                    caption: "Уведомление",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Exclamation);
            }
            else
            {
                this.FormCreateAndEditInitialization();
                if (this.formCreateAndEdit.DialogResult == DialogResult.OK)
                {
                    this.selectedProduct = this.formCreateAndEdit.SelectedProduct;
                    this.assortment = this.formCreateAndEdit.Assortment;
                    this.categories = this.formCreateAndEdit.Categoties;

                    this.comboBoxProducts.Items.Clear();
                    this.ComboBoxProductsInitialization();
                    this.comboBoxProducts.SelectedItem = this.selectedProduct.Name;
                    this.textBoxPrice.Text = this.selectedProduct.Price.ToString();
                    this.textBoxTotalPrice.Text = "0.00";
                    totalOrderPrice = 0.00;
                    this.listBoxOrderInfo.Items.Clear();
                }
                if (this.formCreateAndEdit != null)
                {
                    this.formCreateAndEdit.Close();
                    this.formCreateAndEdit.Dispose();
                    this.formCreateAndEdit = null;
                }
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Создать". Добавляет информацию о 
        /// новом товаре в ассортимент товаров.
        /// </summary>
        private void ButtonCreate(Object sender, EventArgs e)
        {
            this.formCreateAndEdit = new FormCreateAndEdit(this.categories, this.assortment);
            this.formCreateAndEdit.Owner = this;
            this.formCreateAndEdit.StartPosition = FormStartPosition.CenterParent;
            this.formCreateAndEdit.ShowDialog(this);

            if (this.formCreateAndEdit.DialogResult == DialogResult.OK)
            {
                this.selectedProduct = this.formCreateAndEdit.SelectedProduct;
                this.assortment = this.formCreateAndEdit.Assortment;
                this.categories = this.formCreateAndEdit.Categoties;

                this.comboBoxProducts.Items.Clear();
                this.ComboBoxProductsInitialization();
                this.comboBoxProducts.SelectedItem = this.selectedProduct.Name;
                this.textBoxPrice.Text = this.selectedProduct.Price.ToString();
            }
            if (this.formCreateAndEdit != null)
            {
                this.formCreateAndEdit.Close();
                this.formCreateAndEdit.Dispose();
                this.formCreateAndEdit = null;
            }
        }
        /// <summary>
        /// Обрабатывает событие выбора одного из пунков выподающего меню 
        /// ComboBoxProducts. Присваивет полю  this.selectedProduct 
        /// выбранный пользователем объект класса Product.
        /// </summary>
        private void ComboBoxProductsSelectesIndexChanged(object sender, 
            EventArgs e)
        {
            String productName = (sender as ComboBox).SelectedItem.ToString();
            this.selectedProduct = this.assortment.GetProduct(productName);
            this.textBoxPrice.Text = this.selectedProduct.Price.ToString();
        }
    }
}
