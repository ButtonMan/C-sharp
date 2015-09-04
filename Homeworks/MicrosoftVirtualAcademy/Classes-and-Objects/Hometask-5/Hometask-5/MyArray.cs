//+---------------------------------------------------------------------------+
/*  КЛАСС Array
 *  
 *  Предназначение: Класс для хранения одномерного массива целых чисел и 
 *  работы с ним.
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
namespace Hometask_5
{



    //ОБЪЯВЛЕНИЕ КЛАССА
    //+-----------------------------------------------------------------------+
    class MyArray
    {

        //ЧЛЕНЫ-ДАННЫX КЛАССА
        //+-------------------------------------------------------------------+

        int[] myArray;          //массив целых чисел



        //КОНСТРУКТОРЫ КЛАССА
        //+-------------------------------------------------------------------+
        
        /// <summary>конструктор с параметрами, создающий массив 
        /// целочисленных элементов заданного пользователем размера</summary>
        /// <param name="size">размер создаваемого массива целых 
        /// чисел </param>
        public MyArray(int size)
        {
            myArray = new int[size];
        }



        //СВОЙСТВА КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>Свойство возвращающее размер массива. Доступно только 
        /// для чтения.</summary>
        public int Length
        {
            get
            {
                return this.myArray.Length;
            }
        }

        /// <summary>Свойство позволяющее домножить все элементы массива на
        /// скаляр (доступное только для записи).</summary>
        public int Multiply
        {
            set
            {
                for(int i = 0; i < this.myArray.Length; ++i)
                {
                    this.myArray[i] *= value;
                }
            }
        }



        //ИНДЕКСАТОРЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>Индексатор, позволяющий по индексу обращаться к 
        /// соответствующему элементу массива </summary>
        /// <param name="id">номер элемента массива</param>
        /// <returns>целочисленное значение элемента массива</returns>
        public int this[int id]
        {
            get
            {
                return this.myArray[id];
            }
            set
            {
                this.myArray.SetValue(value,id);
            }
        }


        //МЕТОДЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>редактирование заданного пользователем значения
        /// элемента массива</summary>
        /// <param name="id">номер элемента массива</param>
        /// <param name="value">новое значение элемента массива</param>
        public void Set(int id, int value)
        {
            try
            {
                this.myArray.SetValue(value, id);
            }
            catch (IndexOutOfRangeException)
            {
                Console.Error.WriteLine(Environment.NewLine + "ОШИБКА: " + 
                    "обращение к элементу массива с индексом, значение " + 
                    "которого лежит вне границ массива" + 
                    Environment.NewLine);
            }
        }

        /// <summary>инициализация массива новым массивом целочисленных 
        /// значений. Существующие значения массива при этом будут удалены
        /// </summary>
        /// <param name="value">набор целочисленных значений, 
        /// перечисленных через запятую</param>
        public void Set(params int[] value)
        {

            this.myArray = new int[value.Length];
            for (int i = 0; i < this.myArray.Length; ++i )
            {
                try
                {
                    this.myArray[i] = value[i];
                }
                catch(IndexOutOfRangeException)
                {
                    Console.Error.WriteLine(Environment.NewLine + "ОШИБКА: " + 
                    "обращение к элементу массива с индексом, значение " + 
                    "которого лежит вне границ массива" + 
                    Environment.NewLine);
                }
            }
        }

        /// <summary>Предоставление информации о значениях элементов хранящихся
        /// в массиве целых чисел, в виде строки</summary>
        /// <returns>строка символов содержащая в себе значения элементов 
        /// целочисленного массива разделенных между собой символом пробела
        /// </returns>
        public string GetInfo()
        {
            StringBuilder tmpString = new StringBuilder();
            foreach(int value in this.myArray)
            {
                tmpString.AppendFormat("{0} ", value);
            }
            return tmpString.ToString();
        }

        /// <summary>сортировка значение целочисленного 
        /// массива</summary>
        public void Sort()
        {
            Array.Sort(this.myArray);
        }



        //ПЕРЕГРУЖЕННЫЕ ОПЕРАТОРЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>перегруженный оператор декремента ++ </summary>
        /// <param name="obj">объект класса MyArray</param>
        /// <returns>объект класса MyArray значения элемента которого 
        /// увеличенны на единицу</returns>
        public static MyArray operator ++(MyArray obj)
        {
            for(int i = 0; i < obj.Length; ++i)
            {
                ++obj[i];
            }
            return obj;
        }

        /// <summary>перегруженный оператор инкремента -- </summary>
        /// <param name="obj">объект класса MyArray</param>
        /// <returns>объект класса MyArray значения элемента которого 
        /// увеличенны на единицу</returns>
        public static MyArray operator --(MyArray obj)
        {
            for(int i = 0; i < obj.Length; ++i)
            {
                --obj[i];
            }
            return obj;
        }

        /// <summary>проверка, отсортирован массив в каком либо порядке
        /// (по возрастанию или по убыванию) или нет</summary>
        /// <param name="obj">объект класса MyArray</param>
        /// <returns>true если массив отсортирован по убыванию или 
        /// возрастаниь, в противном случае false</returns>
        public static bool operator !(MyArray obj)
        {
            bool sorted = true;
            int length = obj.Length - 1;
            for (int i = 0; i < length; ++i)
            {
                if (obj[i] < obj[i + 1])
                {
                    sorted = false;
                }
            }
            return sorted;
        }

        /// <summary>перегруженная операция "*", перемножает все 
        /// значения элементов массива на скалярную величину</summary>
        /// <param name="obj">объект класса MyArray</param>
        /// <param name="scalar">целочисленное значение</param>
        /// <returns>объект класса MyArray</returns>
        public static MyArray operator *(MyArray obj, int scalar)
        {
            MyArray tmpObj = new MyArray(obj.Length);
            for (int i = 0; i < tmpObj.Length; ++i )
            {
                tmpObj[i] = obj[i];
            }

            for (int i = 0; i < obj.Length; ++i)
            {
                tmpObj[i] *= scalar;
            }
            return tmpObj;
        }

        /// <summary>перегруженная операция "*", перемножает все 
        /// значения элементов массива на скалярную величину</summary>
        /// <param name="obj">объект класса MyArray</param>
        /// <param name="scalar">целочисленное значение</param>
        /// <returns>объект класса MyArray</returns>
        public static MyArray operator *(int scalar, MyArray obj)
        {
            MyArray tmpObj = new MyArray(obj.Length);
            for (int i = 0; i < tmpObj.Length; ++i)
            {
                tmpObj[i] = obj[i];
            }
            for (int i = 0; i < tmpObj.Length; ++i)
            {
                tmpObj[i] *= scalar;
            }
            return tmpObj;
        }

        /// <summary> явное преобразование типа MyArray в массив int</summary>
        /// <param name="obj">объект класса MyArray</param>
        /// <returns>массив int</returns>
        public static explicit operator int[](MyArray obj)
        {
            int[] tmpArray = new int [obj.Length];
            for(int i = 0; i < obj.Length; ++i)
            {
                tmpArray[i] = obj[i];
            }
            return tmpArray;
        }

        /// <summary> явное преобразование массива типа int в объект класса 
        /// MyArray</summary>
        /// <param name="obj">>массив int</param>
        /// <returns>объект класса MyArray</returns>
        public static explicit operator MyArray(int [] array)
        {
            MyArray obj = new MyArray(array.Length);
            for(int i = 0; i < array.Length; ++i)
            {
                obj[i] = array[i];
            }
            return obj;
        }
    }
}