using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Hometask_2.Entities
{
    public class Assortment
    {
        //ПОЛЯ КЛАССА
        //+-------------------------------------------------------------------+
  
        /// <summary>
        /// ассортимент товара
        /// </summary>
        private static Dictionary<string,
            Dictionary<string, Product>> assortment = null;
        /// <summary>
        /// Перечень зарегестрированных в программе товарных категорий
        /// </summary>
        private Category categories = null;




        //КОНСТРУКТОРЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Инициализирует поле categories и заполняет данными объект
        /// assortment
        /// </summary>
        /// <param name="categories"></param>
        public Assortment(Category categories)
        {
            assortment = new Dictionary<string, Dictionary<string, Product>>();
            if (categories == null)
            {
                throw new ArgumentNullException("Нельзя приступить к работе " +
                    "с ассортиментом, поскольку не создана ни одна товарная " +
                    "категория. Для того что бы иметь возможность " +
                    "создавать товары, создайте надлежащие им категории");
            }
            this.categories = categories;
            for(int i = 0; i < this.categories.Count; ++i)
            {
                assortment.Add(this.categories[i], new Dictionary<string, 
                    Product>());
            }
        }




        //ИНДЕКСАТОРЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>
        /// возвращает значение Value объекта Dictionary
        /// </summary>
        /// <param name="key">название товарной категории</param>
        /// <returns>объект Dictionary<string, Product></returns>
        public Dictionary<string, Product> this[string key]
        {
            get
            {
                return assortment[key];
            }
        }




        //МЕТОДЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Добавление нового товара в ассортимент
        /// </summary>
        /// <param name="newProduct"></param>
        public void AddProduct(Product newProduct)
        {
            if(assortment == null)
            {
                throw new NullReferenceException("Не создан объект класса " +
                    "assortment предназначенный для хранения данных об " + 
                    "ассортименте товаров.");
            }
            else
            {
                if(this.categories == null)
                {
                    throw new ArgumentNullException("Нельзя приступить к " +
                        "работе с ассортиментом, поскольку не создана ни " +
                        "одна товарная категория. Для того что бы иметь " + 
                        "возможность создавать товары, создайте надлежащие " +
                        "им категории");
                }
                else
                {
                    if (!this.categories.Contains(newProduct.Category))
                    {
                        throw new ArgumentException("Указанная товарная " + 
                            "категория отсутствует или название категории" +
                            "товара указанно неверно");
                    }
                    else
                    {
                        if (assortment[newProduct.Category].ContainsKey(newProduct.Name))
                        {
                            throw new ArgumentException("Указанное имя товара " +
                                "уже существует в базе данных. Товар не может " +
                                "быть внесен в базу данных. Присвойте товару " +
                                "уникальное имя.");
                        }
                        else
                        {
                            assortment[newProduct.Category].Add(newProduct.Name,
                                newProduct);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Предоставление информации о продукте (имя, характеристики и т.п.)
        /// </summary>
        /// <param name="categotyName">Имя товарной категории</param>
        /// <param name="productName">Имя продукта</param>
        /// <returns>объект класса Product</returns>
        public Product GetProduct(string categotyName, string productName)
        {
            if (assortment == null)
            {
                throw new NullReferenceException("Не создан объект класса " +
                    "assortment предназначенный для хранения данных об " +
                    "ассортименте товаров.");
            }
            else
            {
                if (this.categories == null)
                {
                    throw new ArgumentNullException("Нельзя приступить к " +
                        "работе с ассортиментом, поскольку не создана ни " +
                        "одна товарная категория. Для того что бы иметь " +
                        "возможность создавать товары, создайте надлежащие " +
                        "им категории");
                }
                else
                {
                    if (!assortment[categotyName].ContainsKey(productName))
                    {
                        return null;
                    }
                    else
                    {
                        Dictionary<string, Product> product = 
                            assortment[categotyName];
                        return product[productName];
                    }
                }
            }
        }

        /// <summary>
        /// Предоставление информации о продукте (имя, характеристики и т.п.)
        /// </summary>
        /// <param name="productName">Имя продукта</param>
        /// <returns>бъект класса Product</returns>
        public Product GetProduct(string productName)
        {
            if (assortment == null)
            {
                throw new NullReferenceException("Не создан объект класса " +
                    "assortment предназначенный для хранения данных об " +
                    "ассортименте товаров.");
            }
            else
            {
                if (this.categories == null)
                {
                    throw new ArgumentNullException("Нельзя приступить к " +
                        "работе с ассортиментом, поскольку не создана ни " +
                        "одна товарная категория. Для того что бы иметь " +
                        "возможность создавать товары, создайте надлежащие " +
                        "им категории");
                }
                else
                {
                    Product productInfo = null;
                    for(int i = 0; i < this.categories.Count; ++i)
                    {
                        Dictionary<string, Product> subDictionary = 
                            assortment[categories[i]];
                        if (subDictionary.TryGetValue(productName,
                            out productInfo))
                            break;
                    }
                    return productInfo;
                }
            }
        }

        /// <summary>
        /// Замена информации об одном продукте, информацией о другом продукте
        /// </summary>
        /// <param name="oldProductInfo">старая информация о продукте
        /// хранимая в объекте Product</param>
        /// <param name="newProductInfo">новая информация о продукте
        /// хранимая в объекте Product</param>
        /// <returns>true - в случае если быа выполнена заена объектов</returns>
        public void ReplaceProduct(Product oldProductInfo, Product newProductInfo)
        {
            if (assortment == null)
            {
                throw new NullReferenceException("Не создан объект класса " +
                    "assortment предназначенный для хранения данных об " +
                    "ассортименте товаров.");
            }
            else
            {
                if (this.categories == null)
                {
                    throw new ArgumentNullException("Нельзя приступить к " +
                        "работе с ассортиментом, поскольку не создана ни " +
                        "одна товарная категория. Для того что бы иметь " +
                        "возможность создавать товары, создайте надлежащие " +
                        "им категории");
                }
                else
                {
                    if (assortment.ContainsKey(oldProductInfo.Category))
                    {
                        Dictionary<string, Product> subDictionary =
                            assortment[oldProductInfo.Category];
                        if (subDictionary.ContainsKey(oldProductInfo.Name))
                        {
                            subDictionary.Remove(oldProductInfo.Name);
                            if (oldProductInfo.Category == newProductInfo.Category)
                            {
                                subDictionary.Add(newProductInfo.Name, newProductInfo);
                            }
                            else
                            {
                                if (assortment.ContainsKey(newProductInfo.Category))
                                {
                                    subDictionary = assortment[newProductInfo.Category];
                                    if(!subDictionary.ContainsKey(newProductInfo.Name))
                                    {
                                        subDictionary.Add(newProductInfo.Name, newProductInfo);
                                    }
                                    else
                                    {
                                        throw new ArgumentException("При выполнении редактирования " +
                                        "информации о товаре, возникла ошибка. Выбранная для товара" +
                                        "новая товарня категория, уже содержит в себе товар с " +
                                        "аналогичным именем");
                                    }
                                }
                                else
                                {
                                    throw new ArgumentException("При выполнении редактирования " +
                                        "информации о товаре, возникла ошибка. Выбранная " +
                                        "пользователем товарная категория не существует");
                                }
                            }
                        }
                        else
                        {
                            throw new ArgumentException("В ассортименте магазина, " +
                                "не существует имени товара, выбранного для редактирования");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("В ассортименте нет товарной категории," + 
                            "указанной в описанни выбранного для редактирования товара");
                    }
                }
            }
        }

        /// <summary>
        /// Предоставляет список продуктов в виде объекта Dictionary<string, Product>
        /// </summary>
        /// <returns>колллекция значений Value</returns>
        public Dictionary<string, Dictionary<string, Product>>.ValueCollection GetValueCollection()
        {
            return assortment.Values;
        }

        /// <summary>
        /// Предоставляет колдекцию значений Key поля assortment 
        /// (тип данных: Dictionary<string, Dictionary<string, Product>>)
        /// </summary>
        /// <returns>колллекция значений Key</returns>
        public Dictionary<string, Dictionary<string, Product>>.KeyCollection GetKeyCollection()
        {
            return assortment.Keys;
        }
    }
}
