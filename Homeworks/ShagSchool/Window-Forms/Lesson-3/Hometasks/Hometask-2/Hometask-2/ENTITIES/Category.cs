using Hometask_2.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_2.Entities
{
    public class Category
    {
        //ПОЛЯ КЛАССА
        //+-------------------------------------------------------------------+
        private static List<string> names = null;   //список названий товарных 
                                                    //категорий


        //КОНСТРУКТОРЫ КЛАССА
        //+-------------------------------------------------------------------+
        static Category()
        {
            names = new List<string>();
        }



        //СВОЙСТВА КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Возвращает количество зарегестрированных пользователем категорий
        /// товаров
        /// </summary>
        public int Count
        {
            get
            {
                return names.Count;
            }
        }



        //СВОЙСТВА КЛАССА
        //+-------------------------------------------------------------------+
        /// <summary>
        /// Добавление названия новой категрии в список категорий
        /// </summary>
        /// <param name="categoryName">название новой товарной категории</param>
        public bool Add(string categoryName)
        {
            if(names.Contains(categoryName))
            {
                throw new ArgumentException("Данное имя товарной категории" +
                    "уже существует в списке товарных категорий. Имя " + 
                    "товарной категории должно быть уникальным.");
            }
            else
            {
                names.Add(categoryName);
                names.Sort();
                return true;
            }
        }
        /// <summary>
        /// Проверка наличия в списке названий товарных категорий 
        /// заданного пользователем имени
        /// </summary>
        /// <param name="categoryName">имя товарной категории</param>
        /// <returns>true - в случае если имя товарной категории уже 
        /// существует в списке имен товарных категорий</returns>
        public bool Contains(string categoryName)
        {
            return names.Contains(categoryName);
        }



        //СВОЙСТВА КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Предоставляет доступ к имени товарной категории по индексу
        /// </summary>
        /// <param name="id">индекс</param>
        /// <returns>название товарной категории</returns>
        public string this[int id]
        {
            get
            {
                if (names == null)
                {
                    throw new NullReferenceException("Нельзя приступить к " +
                        "работе с названиями товарных категорий, поскольку " +
                        "пользователем небыло зарегестрированно ни одного " +
                        "названия товарной категори. Пожалуйста создайте " +
                        "надлежащие товарные категории");
                }
                else
                {
                    if (id < 0 || id >= names.Count)
                    {
                        throw new ArgumentOutOfRangeException("Заданный " +
                            "индекс элемента товарной категории выходит за " +
                            "пределы допустимого диапазона значений");
                    }
                    else
                    {
                        return names.ElementAt(id);
                    }
                }
            }
        }
    }
}
