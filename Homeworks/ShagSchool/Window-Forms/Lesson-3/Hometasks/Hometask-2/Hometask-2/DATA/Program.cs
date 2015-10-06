using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hometask_2.Entities;


namespace Hometask_2
{
    //
    //Набор исходных данных для тестирования работы приложения 
    //
    static partial class Program
    {
        //создание тестовых названий категорий товаров
        static Category SetCategoryTestData()
        {
            Category categories = new Category();
            categories.Add("Экраны");
            categories.Add("Мышки");
            categories.Add("Принтеры");
            return categories;
        }
        //создание товаров
        static Assortment SetAssortmentTestData(Category categories)
        {
            Assortment assortment = new Assortment(categories);
            // Категория №1: Экран
            Product screen1 = new Product("Экраны", "Очень хороший",
                "Супер характеристики","Экран Самсунг", 150);
            Product screen2 = new Product("Экраны", "нормальный",
                "неплохие характеристики", "Экран Филипс", 50);
            Product screen3 = new Product("Экраны", "плохой",
                "плохие характеристики", "Экран Хуавэй", 10);
            // Категория №2: Мышки
            Product mouse1 = new Product("Мышки", "Очень хорошая",
                "Супер характеристики", "Мышка Logitech", 150);
            Product mouse2 = new Product("Мышки", "нормальная",
                "неплохие характеристики", "Мышка Apple", 50);
            Product mouse3 = new Product("Мышки", "плохая",
                "плохие характеристики", "Мышка Corsair", 10);
            //добавление товаров в ассортмент магазина

            assortment.AddProduct(screen1);
            assortment.AddProduct(screen2);
            assortment.AddProduct(screen3);
            assortment.AddProduct(mouse1);
            assortment.AddProduct(mouse2);
            assortment.AddProduct(mouse3);
            return assortment;
        }
    }
}
