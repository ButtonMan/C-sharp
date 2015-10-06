using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hometask_2.Entities;



namespace Hometask_2.Forms
{
    public partial class FormCreateAndEdit : Form
    {
        //ПОЛЯ КЛАССА
        //+-------------------------------------------------------------------+
        private Category categories = null;         //названия тов. категорий
        private Assortment assortment = null;       //описание товаров
        private Product selectedProduct = null;     //выбранный продукт



        //КОНСТРУКТОРЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Конструктор формы с параметрами
        /// </summary>
        /// <param name="categories">объект класса "товарные категории"</param>
        /// <param name="assortment">объект класса "ассортимент товаров"</param>
        public FormCreateAndEdit(Category categories, Assortment assortment)
        {
            this.InitializeComponent();
            this.categories = categories;
            this.assortment = assortment;
            this.ComboBoxCategoryInitialization();
        }

        /// <summary>
        /// Конструктор формы с параметрами
        /// </summary>
        /// <param name="categories">объект класса "товарные категории"</param>
        /// <param name="assortment">объект класса "ассортимент товаров"</param>
        /// <param name="product">продукт, информацию о котором необходимо
        /// откорректировать</param>
        public FormCreateAndEdit(Category categories, Assortment assortment,
             Product product) : this(categories, assortment)
        {
            this.selectedProduct = product;
            this.SetComboBoxCategoryStartIteam();
            this.TextBoxNameInitialization();
            this.TextBoxCharacteristicsInitialization();
            this.TextBoxDescriptionInitialization();
            this.TextBoxPriceInitialization();
        }



        //СВОЙСТВА КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Редактирование поля Categoties (товарные категории)
        /// </summary>
        public Category Categoties
        {
            get
            {
                return this.categories;
            }
            set
            {
                this.categories = value;
            }
        }

        /// <summary>
        /// редактирование поля Assortment (ассортимент товаров)
        /// </summary>
        public Assortment Assortment
        {
            get
            {
                return this.assortment;
            }
            set
            {
                this.assortment = value;
            }
        }

        /// <summary>
        /// Редактирование информации о продует выбранном пользователем в 
        /// главной форме "Заказ".
        /// </summary>
        public Product SelectedProduct
        {
            get
            {
                return this.selectedProduct;
            }
            set
            {
                this.selectedProduct = value;
            }
        }



        //МЕТОДЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Инициализация значений выпадающего списка контроллера 
        /// ComboBoxCategory
        /// </summary>
        private void ComboBoxCategoryInitialization()
        {
            //загрузка в контроллер названий товарных категорий
            if (this.categories == null)
            {
                this.comboBoxCategory.Items.Add("не заданны");
            }
            else
            {
                for (int i = 0; i < this.categories.Count; ++i)
                {
                    this.comboBoxCategory.Items.Add(this.categories[i]);
                }
            }
        }

        /// <summary>
        /// Инициализация поля "наименование товара"
        /// </summary>
        private void TextBoxNameInitialization()
        {
            if (this.selectedProduct == null)
            {
                this.textBoxName.Text = String.Empty;
            }
            else
            {
                this.textBoxName.Text = this.selectedProduct.Name;
            }
        }

        /// <summary>
        /// Инициализация поля "характеристики товара"
        /// </summary>
        private void TextBoxCharacteristicsInitialization()
        {
            if (this.selectedProduct == null)
            {
                this.textBoxCharacteristics.Text = String.Empty;
            }
            else
            {
                this.textBoxCharacteristics.Text =
                    this.selectedProduct.Characteristics;
            }
        }

        /// <summary>
        /// Инициализация поля "описание товара"
        /// </summary>
        private void TextBoxDescriptionInitialization()
        {
            if (this.selectedProduct == null)
            {
                this.textBoxDescription.Text = String.Empty;
            }
            else
            {
                this.textBoxDescription.Text = this.selectedProduct.Description;
            }
        }

        /// <summary>
        /// Инициализация поля "Цена"
        /// </summary>
        private void TextBoxPriceInitialization()
        {
            if (this.selectedProduct == null)
            {
                this.textBoxPrice.Text = String.Empty;
            }
            else
            {
                this.textBoxPrice.Text = this.selectedProduct.Price.ToString();
            }
        }

        /// <summary>
        /// Устанавливает дэфолтное значение выпадающего списка.
        /// </summary>
        private void SetComboBoxCategoryStartIteam()
        {
            //уставнока дэфолтного значения контроллера comboBoxCategory
            if (this.selectedProduct != null)
            {
                int id = 0;
                id = this.comboBoxCategory.Items.IndexOf(this.selectedProduct.Category);
                this.comboBoxCategory.SelectedIndex = id;
            }
        }

        /// <summary>
        /// Проверяет, было ли выбранно одно из названий товарных категорий,
        /// к которым относится новый продукт.
        /// Проверка осущесталяется по значению индекса, выбранного 
        /// пользователем значения в контроллере "comboBoxCategory"
        /// </summary>
        /// <param name="id">индекс</param>
        /// <returns>true - если было выбранно одно из значений контроллера
        /// "comboBoxCategory"</returns>
        private bool ValidateCategory(int id)
        {
            if (id == -1)
            {
                this.selectedProduct = null;
                MessageBox.Show("Не выбранно название товарной категории." +
                    "Данное поле является обязательным");
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Проверка, правильности формата введенного значения цены.
        /// </summary>
        /// <param name="value">строка, содержащая цену продукта</param>
        /// <returns>true - если цена имеет верный формат</returns>
        private bool ValidatePriceValue(string value)
        {
            double price;
            if (Double.TryParse(value, out price) && price >= 0)
            {
                return true;
            }
            else
            {
                this.selectedProduct = null;
                MessageBox.Show("Ошбика сохранения данных. Значение цены имеет " +
                    "неверный формат. Исправьте значение цены и попробуйте " +
                    "еще раз.");
                return false;
            }
        }



        //ОБРАБОТЧИКИ СОБЫТИЙ
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Обработка события нажатия кнопки "Сохранить".
        /// Вносит изменения в существующее описание товара, после чего
        /// закрывает окно редактирования.
        /// </summary>
        private void ButtonSaveClick(Object sender, EventArgs e)
        {
            Product newProductInfo = new Product();
            int id = this.comboBoxCategory.SelectedIndex;
            if (!this.ValidateCategory(id)) return;
            newProductInfo.Category = this.comboBoxCategory.SelectedItem.ToString();
            newProductInfo.Name = this.textBoxName.Text;
            newProductInfo.Characteristics = this.textBoxCharacteristics.Text;
            newProductInfo.Description = this.textBoxDescription.Text;
            if (!this.ValidatePriceValue(this.textBoxPrice.Text)) return;
            if (this.selectedProduct != null)
            {
                this.assortment.ReplaceProduct(this.selectedProduct, newProductInfo);
            }
            else
            {
                this.assortment.AddProduct(newProductInfo);
            }
            this.selectedProduct = newProductInfo;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Обработка события нажатия кнопки "Отмена".
        /// Закрывает окно редактирования информации о товаре.
        /// </summary>
        private void ButtonCancelClick(Object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            this.Dispose();
        }

    }
}
