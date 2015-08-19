//+---------------------------------------------------------------------------+
/*  КЛАСС Point
 *  
 *  Предназначение: Хранение значений координат точки. Обеспечение возможности
 *  редактирования и извличения значений координат точки. Выполнение некоторых
 *  расчетов связанных с координатой
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
namespace Hometask_1
{



    //ОБЪЯВЛЕНИЕ КЛАССА
    //+-----------------------------------------------------------------------+
    class Point
    {



        //ЧЛЕНЫ-ДАННЫЗ КЛАССА
        //+-------------------------------------------------------------------+
        private int x;          //значение по оси X
        private int y;          //значение по оси Y



        //КОНСТРУКТОРЫ КЛАССА
        //+-------------------------------------------------------------------+
       
        /// <summary>конструктор без параметров</summary>
        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        /// <summary>конструктор инициализирующий значение координат точки по 
        /// оси Х, У</summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }



        //СВОЙСТВА КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary> редактирования положения точки по оси Х </summary>
        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        /// <summary> редактирования положения точки по оси Y </summary>
        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        /// <summary> умножение координаты точки на скаляр </summary>
        public int MultiplyScalX
        {
            set
            {
                this.X *= value;
            }
        }

        /// <summary> умножение координаты точки на скаляр </summary>
        public int MultiplyScalY
        {
            set
            {
                this.Y *= value;
            }
        }



        //ИНДЕКСАТОРЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary> Индексатор, позволяющий по индексу 0 обращаться к 
        /// полю x, по индексу 1 – к полю y, при других значениях индекса 
        /// выдается сообщение об ошибке </summary>
        /// <param name="index">индекс элемента</param>
        public int this[int index]
        {
            set
            {
                switch(index)
                {
                    case 0:
                        this.X = value;
                        break;
                    case 1:
                        this.Y = value;
                        break;
                    default:
                        Console.WriteLine("!!!Wrong index!!!");
                        break;
                }
            }
        }



        //МЕТОДЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>вывод координаты точки на экран</summary>
        public void Show()
        {
            Console.WriteLine("({0},{1})", this.x, this.y);
        }

        /// <summary> расчет расстояния от точки до начала 
        /// координат</summary>
        /// <returns> расстояни от точки до начала координат </returns>
        public double VectorDistance()
        {
            return Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));
        }

        /// <summary> суммирование векторов </summary>
        /// <param name="a">координата по оси Х</param>
        /// <param name="b">координата по оси У</param>
        /// <returns>сумма векторов</returns>
        public Point VectorSum(int a, int b)
        {
            return new Point(this.x += a, this.y += b);
        }



        //ПЕРЕГРУЖЕННЫЕ ОПЕРАТОРЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary> перегруженный префиксный оператор ++ </summary>
        /// <param name="point">объект класса точка</param>
        /// <returns>объект класса точка с увеличенным на единицу значением
        /// координат</returns>
        public static Point operator++(Point point)
        {
            ++point.X;
            ++point.Y;
            return point;
        }

        /// <summary> перегруженный префиксный оператор -- </summary>
        /// <param name="point">объект класса точка</param>
        /// <returns>объект класса точка с уменьшенным на единицу значением
        /// координат</returns>
        public static Point operator--(Point point)
        {
            --point.X;
            --point.Y;
            return point;
        }

        /// <summary>перегрузка логической константы true. Обращение к 
        /// экземпляру класса дает значение true, если значение полей x и у 
        /// совпадает, иначе false</summary>
        /// <param name="point">объект класса точка</param>
        /// <returns>логическая константа true или false </returns>
        public static bool operator true(Point point)
        {
            if(point.X == point.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>перегрузка логической константы false. Обращение к 
        /// экземпляру класса дает значение true, если значение полей x и у 
        /// совпадает, иначе false</summary>
        /// <param name="point">объект класса точка</param>
        /// <returns>логическая константа true или false </returns>
        public static bool operator false(Point point)
        {
            if(point.X != point.Y)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>перегрузка бинарного оператора +, одновременно добавляет 
        /// к полям х и у значение скаляра </summary>
        /// <param name="obj">объект класса точка</param>
        /// <param name="scal">значение скаляра</param>
        /// <returns>объект класса точка</returns>
        public static Point operator +(Point point, int scal)
        {
            point.x += scal;
            point.y += scal;
            return point;
        }

        /// <summary>перегрузка бинарного оператора +, одновременно добавляет 
        /// к полям х и у значение скаляра </summary>
        /// <param name="scal">объект класса точка</param>
        /// <param name="obj">значение скаляра</param>
        /// <returns>объект класса точка</returns>
        public static Point operator +(int scal, Point point)
        {
            point.x += scal;
            point.y += scal;
            return point;
        }
    }
}
