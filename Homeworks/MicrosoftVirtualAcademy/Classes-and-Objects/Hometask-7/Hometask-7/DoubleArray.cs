//+---------------------------------------------------------------------------+
/*  КЛАСС IntArray
 *  Класс для работы c двумерным массивом вещественных чисел.  
 */
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//ОБЪЯВЛЕНИЕ ПРОСТРАНСТВА ИМЕН
//+---------------------------------------------------------------------------+
namespace Hometask_7
{



    //ОБЪЯВЛЕНИЕ КЛАССА
    //+-----------------------------------------------------------------------+
    class DoubleArray
    {

        //ЧЛЕНЫ-ДАННЫХ КЛАССА
        //+-------------------------------------------------------------------+
        private double[][] doubleArray;         //массив вещественных чисел



        //КОНСТРУКТОРЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>Конструктор, позволяющий создать ступенчатый массив.
        /// </summary>
        /// <param name="n">Количество строк</param>
        /// <param name="m">Количество стоблцов. Указывается для каждой
        /// отедльно взятой строки массива. Значения перечисляются через
        /// запятую.</param>
        public DoubleArray(int n, params int[] m)
        {
            this.doubleArray = new double[n][];

            for(int i = 0; i < n; ++i)
            {
                this.doubleArray[i] = new double [m[i]];
            }
        }



        //МЕТОДЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>Инициализация элементов ступенчатого массива</summary>
        /// <param name="value">значения, перечисленные через запятую</param>
        public void Set(params int[] value)
        {
            if (NumberOfElements >= value.Length)
            {
                if (this.doubleArray != null)
                {
                    int n = this.doubleArray.GetLength(0);
                    int id = 0;

                    for (int row = 0; row < n; ++row)
                    {
                        int m = this.doubleArray[row].GetLength(1);
                        for (int col = 0; col < m; ++col, ++id)
                        {
                            this.doubleArray[row][col] = value[id];
                        }
                    }
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }

        /// <summary>Ввод элементов массива с клавиатуры;
        /// </summary>
        public void Set()
        {
            if(this.doubleArray != null)
            {
                int n = this.doubleArray.GetLength(0);
                int counter = 0;
                for(int row = 0; row < n; ++row)
                {
                    int m = this.doubleArray[row].Length;
                    for(int col = 0; col < m; ++col)
                    {
                        Console.Write("{0}) ", ++counter);
                        this.doubleArray[row][col] = Double.Parse(Console.ReadLine());
                    }
                }
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        /// <summary>Вывод элементов массива на экран
        /// </summary>
        public void Show()
        {
            int n = this.doubleArray.GetLength(0);
            for (int row = 0; row < n; ++row)
            {
                int m = this.doubleArray[row].Length;
                for(int col = 0; col < m; ++col)
                {
                    Console.Write("{0,-2}", this.doubleArray[row][col]);
                }
                Console.WriteLine();
            }
        }

        /// <summary>Сортировка элементов каждой строки массива в порядке 
        /// убывания</summary>
        public void Sort()
        {
            int n = this.doubleArray.GetLength(0);
            for (int r = 0; r < n*2; ++r)
            {
                for (int row = 0; row < n; ++row)
                {
                    int m = this.doubleArray[row].Length - 1;
                    for (int col = 0; col < m; ++col)
                    {
                        if (row >= 1 && col == 0)
                        {
                            if (this.doubleArray[row - 1]
                                [this.doubleArray[row - 1].Length - 1] <
                                    this.doubleArray[row][col])
                            {
                                double tmpValue = this.doubleArray[row - 1]
                                    [this.doubleArray[row - 1].Length - 1];

                                this.doubleArray[row - 1][this.doubleArray[row -
                                    1].Length - 1] = this.doubleArray[row]
                                    [col];

                                this.doubleArray[row][col] = tmpValue;  
                            }
                        }
                            if (this.doubleArray[row][col] < this.doubleArray[row]
                                [col + 1])
                            {
                                double tmpValue = this.doubleArray[row][col];
                                this.doubleArray[row][col] = this.doubleArray[row]
                                    [col + 1];
                                this.doubleArray[row][col + 1] = tmpValue;
                            }
                    }
                }
            }
        }



        //СВОЙСТВА КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>Определяет общее количество элементов в массиве 
        /// (доступное только для чтения)</summary>
        public int NumberOfElements
        {
            get
            {
                int result = 0;
                if (this.doubleArray != null)
                {
                    int n = this.doubleArray.GetLength(0);
                    for (int row = 0; row < n; ++row)
                    {
                        result += this.doubleArray[row].Length;
                    }
                }
                return result;
            }
        }
        
        /// <summary> Увеличивает значение всех элементов массива на 
        /// скаляр (доступное только для записи).
        /// </summary>
        public double Scalar
        {
            set
            {
                int n = this.doubleArray.GetLength(0);
                for(int row = 0; row < n; ++row)
                {
                    int m = this.doubleArray[row].Length;
                    for(int col = 0; col < m; ++col)
                    {
                        this.doubleArray[row][col] += value; 
                    }
                }
            }
        }



        //ИНДЕКСАТОРЫ
        //+-------------------------------------------------------------------+

        /// <summary>Двумерный индексатор, позволяющий обращаться к 
        /// соответствующему элементу массива.
        /// </summary>
        /// <param name="n">индекс строкеи</param>
        /// <param name="m">индекс столбца</param>
        /// <returns></returns>
        public double this[int n, int m]
        {
            get
            {
                if (this.doubleArray != null)
                {
                    return this.doubleArray[n][m];
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
            set
            {
                if(this.doubleArray != null)
                {
                    this.doubleArray[n][m] = value;
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
        }



        //ПЕРЕГРУЖЕННЫЕ ОПЕРАТОРЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary> Увеличивает значение всех элементов массива на 1
        /// </summary>
        /// <param name="obj">объект класса DoubleArray</param>
        /// <returns>объект класса DoubleArray</returns>
        public static DoubleArray operator++(DoubleArray obj)
        {
            if(obj.doubleArray != null)
            {
                obj.Scalar = 1;
                return obj;
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        /// <summary> Уменьшает значение всех элементов массива на 1
        /// </summary>
        /// <param name="obj">объект класса DoubleArray</param>
        /// <returns>объект класса DoubleArray</returns>
        public static DoubleArray operator--(DoubleArray obj)
        {
            if (obj.doubleArray != null)
            {
                obj.Scalar = -1;
                return obj;
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        /// <summary>Обращение к экземпляру класса дает значение true, если
        /// каждая строка массива упорядочена по возрастанию, иначе false
        /// </summary>
        /// <param name="obj">объект класса DoubleArray</param>
        /// <returns>логическое значение</returns>
        public static bool operator true(DoubleArray obj)
        {
            if(obj.doubleArray != null)
            {
                int n = obj.doubleArray.GetLength(0);
                for(int row = 0; row < n; ++row)
                {
                    int m = obj.doubleArray.Length - 1;
                    for(int col = 0; col < m; ++col)
                    {
                        if(row >= 1 && col == 0)
                        {
                            if(obj.doubleArray[row - 1][obj.doubleArray[row - 
                                1].Length - 1] < obj.doubleArray[row][col])
                            {
                                return false;
                            }
                        }
                        if(obj.doubleArray[row][col] < obj.doubleArray[row][col + 1])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        /// <summary>Обращение к экземпляру класса дает значение true, если
        /// каждая строка массива упорядочена по возрастанию, иначе false
        /// </summary>
        /// <param name="obj">объект класса DoubleArray</param>
        /// <returns>логическое значение</returns>
        public static bool operator false(DoubleArray obj)
        {
            if (obj.doubleArray != null)
            {
                int n = obj.doubleArray.GetLength(0);
                for (int row = 0; row < n; ++row)
                {
                    int m = obj.doubleArray.Length - 1;
                    for (int col = 0; col < m; ++col)
                    {
                        if (row >= 1 && col == 0)
                        {
                            if (obj.doubleArray[row - 1][obj.doubleArray[row -
                                1].Length - 1] > obj.doubleArray[row][col])
                            {
                                return false;
                            }
                        }
                        if (obj.doubleArray[row][col] > obj.doubleArray[row][col + 1])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}
