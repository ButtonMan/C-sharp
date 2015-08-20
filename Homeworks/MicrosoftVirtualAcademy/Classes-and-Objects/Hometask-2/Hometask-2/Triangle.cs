//+---------------------------------------------------------------------------+
/*  КЛАСС Triangle
 *  
 *  Предназначение: Хранение характеристик треугольник. Обеспечение возможности
 *  редактирования и извличения значений характеристик треугольника. Выполнение
 *  расчетов характеристик треугольника.
 *  
 */
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//ОБЪЯВЛЕНИЕ ПРОСТРАНСТВА ИМЕН
//+---------------------------------------------------------------------------+
namespace Hometask_2
{



    //ОБЪЯВЛЕНИЕ КЛАССА
    //+-----------------------------------------------------------------------+
    class Triangle
    {


        //ЧЛЕНЫ-ДАННЫЗ КЛАССА
        //+-------------------------------------------------------------------+

        int a;                      //сторона А
        int b;                      //сторона B
        int c;                      //сторона C



        //КОНСТРУКТОРЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary> инициализация размеров сторон треугольника </summary>
        /// <param name="a">размер сторона треугольника А</param>
        /// <param name="b">размер сторона треугольника B</param>
        /// <param name="c">размер сторона треугольника C</param>
        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }



        //СВОЙСТВА КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary> инициализация размера стороны треугольника А </summary>
        public int A
        {
            get { return this.a;  }
            set { this.a = value; }
        }

        /// <summary> инициализация размера стороны треугольника B </summary>
        public int B
        {
            get { return this.b;  }
            set { this.b = value; }
        }

        /// <summary> инициализация размера стороны треугольника C </summary>
        public int C
        {
            get { return this.c;  }
            set { this.c = value; }
        }

        /// <summary> проверка, является ли фигура с сторонами A, B, C
        /// треугольником </summary>
        public bool IsTriangle
        {
            get
            {
                if (a + b > c && b + c > a && c + a > b) 
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }



        //ИНДЕКСАТОРЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>редактирование значений сторон треугольника 
        /// ABC</summary>
        /// <param name="id">индекс стороны треугольника</param>
        /// <returns>размер выбранной пользователем стороны 
        /// треугольника</returns>
        public int this[int id]
        {
            get
            {
                try
                {
                    switch (id)
                    {
                        case 0:
                            return this.a;
                        case 1:
                            return this.b;
                        case 2:
                            return this.c;
                        default:
                            throw new IndexOutOfRangeException();
                    }
                }
                catch (IndexOutOfRangeException obj)
                {
                    Console.WriteLine(obj.GetType());
                    return 0;
                }
            }
            set
            {
                try
                {
                    switch (id)
                    {
                        case 0:
                            this.a = value;
                            break;
                        case 1:
                            this.b = value;
                            break;
                        case 2:
                            this.c = value;
                            break;
                        default:
                            throw new IndexOutOfRangeException();
                    }
                }
                catch (IndexOutOfRangeException obj)
                {
                    Console.WriteLine(obj.GetType());
                }
            }
        }



        //МЕТОДЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>информация о размерх сторон треугольника ABC</summary>
        /// <returns>текстовая строка содержащая описание размеров сторон
        /// треугольника </returns>
        /// ***!!!вместо пункта в условии залачи:  "вывести длины сторон 
        /// треугольника на экран". Поскольку размещение внутри методов
        /// команд по выводу текста на экран, не является распространенной 
        /// практикой и не рекомендуется к использованию.!!!***
        public string Info()
        {
            return string.Format("ABC: A = {0}, B = {1}, C = {2}", this.a, 
                this.b, this.c);
        }

        /// <summary>вычисление периметра треугольника ABC</summary>
        /// <returns>периметр треугольника</returns>
        public int Perimeter()
        {
            return this.a + this.b + this.c;
        }

        /// <summary>вычисление площади треугольника ABC</summary>
        /// <returns>площадь тругольника</returns>
        public double Square()
        {
            int perimeter = this.Perimeter();

            return Math.Sqrt(perimeter * (perimeter - this.a) * (perimeter - 
                this.b) * (perimeter - this.c));
        }



        //ПЕРЕГРУЖЕННЫЕ ОПЕРАТОРЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary> перегрузка унарного оператора "++", выполняющего,
        /// одновременное увеличение значений сторон треугольника 
        /// на 1.</summary>
        /// <param name="ABC"> объект класса Triangle (Треугольник) </param>
        /// <returns> объект класса Triangle (Треугольник) с увеличенными на 1
        /// значениями сторон треугольника</returns>
        public static Triangle operator++(Triangle ABC)
        {
            ++ABC.A;
            ++ABC.B;
            ++ABC.C;
            return ABC;
        }

        /// <summary> перегрузка унарного оператора "--", выполняющего,
        /// одновременное уменьшение значений сторон треугольника 
        /// на 1</summary>
        /// <param name="ABC"> объект класса Triangle (Треугольник) </param>
        /// <returns> объект класса Triangle (Треугольник) с увеличенными на 1
        /// значениями сторон треугольника</returns>
        public static Triangle operator--(Triangle ABC)
        {
            --ABC.A;
            --ABC.B;
            --ABC.C;
            return ABC;
        }

        /// <summary> перегрузка оператор true</summary>
        /// <param name="ABC"> объект класса Triangle (Треугольник)</param>
        /// <returns> оператор true, в случае если заданные размеры сторон 
        /// фигуры образуют собой треугольник, если нет - false </returns>
        public static bool operator true(Triangle ABC)
        {
            return ABC.IsTriangle;
        }

        /// <summary> перегрузка оператор false</summary>
        /// <param name="ABC"> объект класса Triangle (Треугольник)</param>
        /// <returns> оператор true, в случае если заданные размеры сторон 
        /// фигуры образуют собой треугольник, если нет - false </returns>
        public static bool operator false(Triangle ABC)
        {
            return ABC.IsTriangle;
        }
    }
}
