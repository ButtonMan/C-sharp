//+---------------------------------------------------------------------------+
/*  КЛАСС Rectangle
 *  
 *  Предназначение: Хранение характеристик прямоугольника. Обеспечение 
 *  возможности редактирования и извлечения значений характеристик 
 *  треугольника. Выполнение расчетов характеристик треугольника.
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
namespace Hometask_3
{



    //ОБЪЯВЛЕНИЕ КЛАССА
    //+-----------------------------------------------------------------------+
    class Rectangle
    {




        //ЧЛЕНЫ-ДАННЫX КЛАССА
        //+-------------------------------------------------------------------+

        private uint a;                  //сторона прямоугольника А
        private uint b;                  //сторона прямоугольника В



        //КОНСТРУКТОРЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary> инициализация значений сторон прямоугольника 
        /// А и В </summary>
        /// <param name="a">сторона А</param>
        /// <param name="b">сторона В</param>
        public Rectangle(uint a, uint b)
        {
            this.a = a;
            this.b = b;
        }



        //СВОЙСТВА КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary> Получение значения и редактирование значения стороны 
        /// прямоугольника - А </summary>
        public uint A
        {
            get 
            { 
                return this.a; 
            }
            set 
            {
                if (value > 0 && this.b != value)
                {
                    this.a = value;
                }
                else
                {
                    throw new ArgumentException("***VALUE IS LESS OR EQUAL" +
                        "\"0\"***");
                }
            }
        }

        /// <summary> Получение значения и редактирование значения стороны 
        /// прямоугольника - B </summary>
        public uint B
        {
            get
            {
                return this.b;
            }
            set
            {
                if (value > 0 && this.a != value)
                {
                    this.b = value;
                }
                else
                {
                        throw new ArgumentException("***VALUE IS LESS OR EQUAL" +
                                "\"0\"***");
                }
            }
        }

        /// <summary> Проверка, является ли фигура с текущими значениями 
        /// есторон A и B прямоугольником</summary>
        public bool IsRectangle
        {
           get
            {
                if(a > 0 && b > 0 && this.a != this.b)
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

        /// <summary> Индексатор, представляющий доступ к просмотру и 
        /// редактироварованию значений сторон прямоугольника. </summary>
        /// <param name="id">индекс стороны прямоугольник значение которого
        /// нужно получить или отредактировать</param>
        /// <returns>размер стороны прямоугольника</returns>
        public uint this[uint id]
        {
            get
            {
                switch (id)
                {
                    case 0:
                        return this.a;
                    case 1:
                        return this.b;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch(id)
                {
                    case 0:
                        this.A = value;
                        break;
                    case 1:
                        this.B = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }



        //МЕТОДЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>Предоставляет информацию о размерах сторон прямоугольника
        /// в виде текстовой строки</summary>
        /// <returns>текстовая строка, содержащая в себе размеры сторон 
        /// прямоугольника</returns>
        public string GetInfo()
        {
            return string.Format("Rectangle: side A = {0:D}, side B = {1:D}",
                this.a, this.b);
        }

        /// <summary>Расчет периметра прямоугольника</summary>
        /// <returns>периметр прямоугольника</returns>
        public uint Perimeter()
        {
            return 2 * (this.a + this.b);
        }

        /// <summary>Расчет площали прямоугольника</summary>
        /// <returns>площадь прямоугольника</returns>
        public uint Square()
        {
            return this.a * this.b;
        }



        //ПЕРЕГРУЖЕННЫЕ ОПЕРАТОРЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>перегруженная операция инкремента</summary>
        /// <param name="ABCD">объект класса прямоугольник</param>
        /// <returns>объект класса прямоугольник значения сторон которого 
        /// были увеличенны на еденицу</returns>
        public static Rectangle operator ++ (Rectangle ABCD)
        {
            ++ABCD.A;
            ++ABCD.B;
            return ABCD;
        }

        /// <summary>перегруженная операция декремента</summary>
        /// <param name="ABCD">объект класса прямоугольник</param>
        /// <returns>объект класса прямоугольник значения сторон которого 
        /// были уменьшенны на еденицу</returns>
        public static Rectangle operator -- (Rectangle ABCD)
        {
            --ABCD.A;
            --ABCD.B;
            return ABCD;
        }

        /// <summary>прегрузка логического оператора true</summary>
        /// <param name="ABCD">объект класса прямоугольник</param>
        /// <returns>логическое значение</returns>
        public static bool operator true (Rectangle ABCD)
        {
            if (ABCD.a == ABCD.b)
            {
                return true;
            }
            else
	        {
                return false;
	        }
        }

        /// <summary>прегрузка логического оператора false</summary>
        /// <param name="ABCD">объект класса прямоугольник</param>
        /// <returns>логическое значение</returns>
        public static bool operator false (Rectangle ABCD)
        {
            if(ABCD.a != ABCD.b)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>перегрузка оператора умножения </summary>
        /// <param name="ABCD">объект класса прямоугольник</param>
        /// <param name="scalar">скаляр</param>
        /// <returns>объект класса прямоугольник</returns>
        public static Rectangle operator *(Rectangle ABCD, uint scalar)
        {
            if(scalar < 0 ) throw new ArgumentException ();

            Rectangle tmpABCD = new Rectangle(ABCD.a, ABCD.b);

            tmpABCD.a *= scalar;
            tmpABCD.b *= scalar;

            return tmpABCD;
        }

        /// <summary>перегрузка оператора умножения </summary>
        /// <param name="ABCD">объект класса прямоугольник</param>
        /// <param name="scalar">скаляр</param>
        /// <returns>объект класса прямоугольник</returns>
        public static Rectangle operator *(uint scalar, Rectangle ABCD)
        {
            if (scalar < 0) throw new ArgumentException();

            Rectangle tmpABCD = new Rectangle(ABCD.a, ABCD.b);

            tmpABCD.a *= scalar;
            tmpABCD.b *= scalar;

            return tmpABCD;
        }
    }
}
