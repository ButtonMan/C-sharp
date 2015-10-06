using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hometask_2.Entities;

namespace Hometask_2.Entities
{
    /// <summary>
    /// Класс "Screen":
    /// - производный от интерфеса IProduct;
    /// - хранит, редактирует информацию о компьютерных экранах;
    /// </summary>
    public class Product
    {
        //ПОЛЯ КЛАССА
        //+-------------------------------------------------------------------+
        private string category;                //название категории товара
        private string characteristics;         //характеристики экрана
        private string description;             //описание экрана
        private string name;                    //наименование экрана
        private double price;                   //цена экрана



        //КОНСТРУКТОРЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Инициализирует поля класса значениями по умолчанию
        /// </summary>
        public Product()
        {
            this.category = "isn't specified";
            this.characteristics = "isn't specified";
            this.description = "isn't specified";
            this.name = "isn't specified";
            this.price = 0.00;
        }

        /// <summary>
        /// Инициализация полей класса значениями заданными пользователем
        /// </summary>
        /// <param name="category">название категории</param>
        /// <param name="characteristic">характеристика товара</param>
        /// <param name="description">описание товара</param>
        /// <param name="name">наименование товара</param>
        /// <param name="price">цена товара</param>
        public Product( string category, 
                        string characteristic, 
                        string description,
                        string name,
                        double price)
        {
            this.category = category;
            this.characteristics = characteristic;
            this.description = description;
            this.name = name;
            this.price = price;
        }


        //СВОЙСТВА КЛАССА
        //+-------------------------------------------------------------------+
        
        /// <summary>
        /// Предоставляет название категории к которой относится товар
        /// </summary>
        public string Category
        {
            get
            {
                return this.category;
            }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    this.category = "isn't specified";
                }
                else
                {
                    this.category = value;
                }
            }
        }

        /// <summary>
        /// Редактирование характеристик товара
        /// </summary>
        public string Characteristics
        {
            get
            {
                return this.characteristics;  
            }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    this.characteristics = "isn't specified";
                }
                else
                {
                    this.characteristics = value;
                }
            }
        }

        /// <summary>
        /// Редактирование описания товара
        /// </summary>
        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    this.description = "isn't specified";
                }
                else
                {
                    this.description = value;
                }
            }
        }

        /// <summary>
        /// Редактирование наименования товара
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    this.name = "isn't specified";
                }
                else
                {
                    this.name = value;
                }
            }
        }

        /// <summary>
        /// Редактирование цены товара
        /// </summary>
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (this.price < 0)
                {
                    this.price = 0;
                }
                else
                {
                    this.price = value;
                }
            }
        }
    }
}
