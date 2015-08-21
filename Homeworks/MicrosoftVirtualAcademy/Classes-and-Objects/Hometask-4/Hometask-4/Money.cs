
//+---------------------------------------------------------------------------+
/*  КЛАСС Money
 *  
 *  Предназначение: Хранение характеристик денежной ендиницы а) номинал купюры;
 *  б) количество купюр. Обеспечение возможности редактирования и извлечения 
 *  значений характеристик денежной единицы. Выполнение расчетов характеристик 
 *  купюры  а) вывести номинал и количество купюр; б) определить, хватит ли 
 *  денежных средств на покупку товара на сумму N рублей ц) определить, сколько
 *  штук товара стоимости n рублей можно купить на имеющиеся денежные средства.
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
namespace Hometask_4
{



    //ОБЪЯВЛЕНИЕ КЛАССА
    //+-----------------------------------------------------------------------+
    class Money
    {



        //ЧЛЕНЫ-ДАННЫX КЛАССА
        //+-------------------------------------------------------------------+

        private int first;              //номинал купюры
        private int second;             //количество купюр



        //КОНСТРУКТОРЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>конструктор с параметрами инициализирующий значения 
        /// свойств денежной единицы</summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        public Money(int first, int second)
        {
            this.First = first;
            this.Second = second;
        }



        //СВОЙСТВА КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary> Получение значения и редактирование значения номинала 
        /// купюры</summary>    
        public int First
        {
            get
            {
                return this.first;
            }
            set
            {
                if(value > 0)
                {
                    this.first = value;
                }
                else
                {
                    throw new ArgumentException("***!!!First <= 0 !!!***");
                }
            }
        }

        /// <summary> Получение значения и редактирование значения 
        /// количества купюр</summary>
        public int Second
        {
            get
            {
                return this.second;
            }
            set
            {
                if(value >= 0)
                {
                    this.second = value;
                }
                else
                {
                    throw new ArgumentException("***!!!Second < 0!!!***");
                }

            }
        }

        /// <summary>расчет суммы денеге (не редактируемой свойство 
        /// класса</summary>
        public int Sum
        {
            get
            {
                return this.first * this.second;
            }
        }



        //ИНДЕКСАТОРЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary> Индексатор, представляющий доступ к просмотру и 
        /// редактироварованию характеристик денежной единицы. </summary>
        /// <param name="id">индекс характеристики денежной единицы, которая
        /// подлежит редактированию</param>
        /// <returns>характеристика денежной единицы</returns
        public int this[int id]
        {
            get
            {
                switch(id)
                {
                    case 0:
                        return this.first;
                    case 1:
                        return this.second;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (id)
                {
                    case 0:
                        this.First = value;
                        break;
                    case 1:
                        this.Second = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }



        //МЕТОДЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>Предоставление информации и денежной единице</summary>
        /// <returns>Текстовая строка содержащая в себе информаци о номинале
        /// и количестве денежной единицы</returns>
        public string GetInfo()
        {
            return string.Format("Nominal = {0:D}, Number of bills = {1:D}",
                this.first, this.second);
        }

        /// <summary>Осуществление проверки, достаточно ли денег для 
        /// приобретения товара по указанной пользователем цене</summary>
        /// <param name="sum">стоимость товара</param>
        /// <returns>true в случае если денег достаточно для покупки товара,
        /// false если не достаточно </returns>
        public bool IsEnoughMoney(decimal sum)
        {
            return (this.Sum >= sum) ? true : false;
        }
        
        /// <summary>расчет того, какое количество товара стоимостью n 
        /// рублей можно купить на имеющиеся денежные средства.</summary>
        /// <param name="price">цена приобретаемого товара за одну
        /// ед.</param>
        /// <returns>количество товара указанной пользователем стоимости
        /// которое можно приобрести на имеющуюся сумму дене</returns>
        public int Count(int price)
        {
            return (this.Sum) / price;
        }



        //ПЕРЕГРУЖЕННЫЕ ОПЕРАТОРЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>перегруженная операция инкремента объекта класса 
        /// Money "денежная единица"</summary>
        /// <param name="obj">объект класса Money</param>
        /// <returns>объект класса Money</returns>
        public static Money operator ++ (Money obj)
        {
            ++obj.First;
            ++obj.Second;
            return obj;
        }

        /// <summary>перегруженная операция декремента объекта класса 
        /// Money "денежная единица"</summary>
        /// <param name="obj">объект класса Money</param>
        /// <returns>объект класса Money</returns>
        public static Money operator -- (Money obj)
        {
            --obj.First;
            --obj.Second;
            return obj;
        }

        /// <summary>перегруженный оператор "не равно" для работы с
        /// объектами класса Money-"денежная единица </summary>
        /// <param name="obj">объект класса Money</param>
        /// <returns>объект класса Money</returns>
        public static bool operator ! (Money obj)
        {
            if(obj.Second != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>перегруженный унарный оператор "+" для работы с
        /// объектом класса Money</summary>
        /// <param name="obj">объект класса Money</param>
        /// <param name="scalar">целочисленное значение</param>
        /// <returns>объект класса Money</returns>
        public static Money operator + (Money obj, int scalar)
        {
            obj.First += 1;
            obj.Second += 1;
            return obj;
        }

        /// <summary>перегруженный унарный оператор "+" для работы с
        /// объектом класса Money</summary>
        /// <param name="obj">объект класса Money</param>
        /// <param name="scalar">целочисленное значение</param>
        /// <returns>объект класса Money</returns>
        public static Money operator +(int scalar, Money obj)
        {
            obj.First += 1;
            obj.Second += 1;
            return obj;
        }
    }
}
