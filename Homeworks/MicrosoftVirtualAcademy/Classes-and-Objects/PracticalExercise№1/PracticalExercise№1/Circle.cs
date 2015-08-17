//+---------------------------------------------------------------------------+
/* КЛАСС "КРУГ"
 * Предназначение: хранение значений характеристик круга и методов выполняющих
 * - расчет площади круга;
 * - расчет длины окружности;
 */
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//ОБЪЯВЛЕНИЕ ОБЛАСТИ ИМЕН
//+---------------------------------------------------------------------------+
namespace PracticalExercise_1
{



    //ОБЪЯВЛЕНИЕ КЛАССА Circle
    //+-----------------------------------------------------------------------+
    internal class Circle
    {



        //ЧЛЕНЫ-ДЫННЫХ
        //+-------------------------------------------------------------------+
        private int radius;                         //радиус
        private const double pi = 3.14;             //число Пи



        //ПАРАМЕТРИЗИРОВАННЫЕ КОНСТРУКТОРЫ
        //+-------------------------------------------------------------------+
        
        /// <summary>
        /// Инициализация значения поля radius
        /// </summary>
        /// <param name="radius">фактическое значение радиуса круга</param>
        public Circle(int radius)
        {
            this.radius = radius;
        }



        //СВОЙСТВА
        //+-------------------------------------------------------------------+
        
        /// <summary>
        /// редактирование поля класса radius
        /// </summary>
        public int Radius
        {
            set { this.radius = value; }
            get { return this.radius; }
        }

        /// <summary>
        /// извлечение значения числа Пи
        /// </summary>
        public double Pi
        {
            get { return pi; }
        }



        //ФУНКЦИИ-ЧЛЕНЫ
        //+-------------------------------------------------------------------+

        /// <summary>
        /// расчет площади круга
        /// </summary>
        /// <returns>площадь круга</returns>
        public double Square()
        {
            return this.Pi * Math.Pow(this.radius, 2);
        }

        /// <summary>
        /// расчет длинны окружности
        /// </summary>
        /// <returns>длинна окружности</returns>
        public double Circumference()
        {
            return this.Pi * 2 * this.radius;
        }
    }
}
