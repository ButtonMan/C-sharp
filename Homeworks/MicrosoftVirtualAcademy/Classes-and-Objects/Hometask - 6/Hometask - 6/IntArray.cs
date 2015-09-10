//+---------------------------------------------------------------------------+
/*  КЛАСС IntArray
 *  Класс для работы с двумерным массивом целых чисел.  
 */
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//ОБЪЯВЛЕНИЕ ПРОСТРАНСТВА ИМЕН
//+---------------------------------------------------------------------------+
namespace Hometask___6
{
    class IntArray
    {
        //ОБЪЯВЛЕНИЕ КЛАССА
        //+-------------------------------------------------------------------+
        int[,] intArray;            //двумерный массив целых чисел



        //КОНСТРУКТОРЫ КЛАССА
        //+-------------------------------------------------------------------+
        
        /// <summary>Конструктор, позволяющий создать массив размерности n×m
        /// </summary>
        /// <param name="nRows">количество строк</param>
        /// <param name="mCollumns">количество столбцов</param>
        public IntArray(int nRows, int mCollumns)
        {
            this.intArray = new int[nRows, mCollumns];
            this.intArray.Initialize();
        }




        //СВОЙСТВА КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>Вычисляет количество нулевых элементов в массиве 
        /// (доступное только для чтения) </summary>
        public int Zero
        {
            get
            {
                if (this.intArray != null)
                {
                    int counter = 0;
                    foreach (int v in this.intArray)
                    {
                        if(v == 0)
                        {
                            ++counter;
                        }
                    }
                    return counter;
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
        }

        /// <summary>Установливает значение всех элементов главной диагонали 
        /// массива равным скаляру (доступное только для записи) </summary>
        public int Scalar
        {
            set
            {
                if (this.intArray != null)
                {
                    for (int i = 0; i < this.intArray.GetLength(0); ++i)
                    {
                        this.intArray[i, i] = value;
                    }
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
        }



        //ИНДЕКСАТОРЫ
        //+-------------------------------------------------------------------+
        
        /// <summary>Двумерный индексатор, позволяющий обращаться к 
        /// соответствующему элементу массива</summary>
        /// <param name="n">номер строки</param>
        /// <param name="m">номер столбца</param>
        /// <returns></returns>
        public int this[int n, int m]
        {
            set
            {
                if (this.intArray != null)
                {
                    this.intArray[n, m] = value;
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
            get
            {
                if (this.intArray != null)
                {
                    return this.intArray[n, m];
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
        }



        //МЕТОДЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>Ввод элементов массива с клавиатуры
        /// </summary>
        /// <param name="value">значения єлементов массива перечисленные
        /// через запятую</param>
        public void Set(params int[] value)
        {
            if (this.intArray != null)
            {
                for (int n = 0; n < this.intArray.GetLength(0); ++n)
                {
                    for (int m = 0, v = 0; m < this.intArray.GetLength(1); ++m, ++v)
                    {
                        this.intArray[n, m] = value[v];
                    }
                }
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        /// <summary>Ввод элементов массива с клавиатуры
        /// </summary>
        /// <param name="index">порядковый номер элемента массива</param>
        /// <param name="value"></param>
        public void Set(int indexN, int IndexM, int value)
        {
            if (this.intArray != null)
            {
                this.intArray.SetValue(value, indexN, IndexM);
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        /// <summary>Ввод элементов массива с клавиатуры
        /// </summary>
        public void Set()
        {
            int counter = 0;
            for (int i = 0; i < this.intArray.GetLength(0); ++i)
            {
                for (int z = 0; z < this.intArray.GetLength(1); ++z)
                {
                    Console.Write("{0}) ", ++counter);
                    this.intArray[i, z] = int.Parse(Console.ReadLine());
                }
            }
        }

        /// <summary>Вывод элементов массива на экран 
        /// </summary>
        public void Show()
        {
            if (this.intArray != null)
            {
                for (int n = 0; n < this.intArray.GetLength(0); ++n)
                {
                    for (int m = 0; m < this.intArray.GetLength(1); ++m)
                    {
                        Console.Write("{0} ", this.intArray[n, m]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        /// <summary>Вычисление суммы элеметов i-того столбца.
        /// </summary>
        /// <param name="CollumnNum"></param>
        /// <returns></returns>
        public int Sum(int CollumnNum)
        {
            if(this.intArray != null)
            {
                int sum = 0;
                for (int n = 0; n < this.intArray.GetLength(0); ++n)
                {
                    sum += this.intArray[n, CollumnNum];
                }
                return sum;
            }
            else
            {
                throw new NullReferenceException();
            }
        }



        //ПЕРЕГРУЖЕННЫЕ ОПЕРАТОРЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>Перегрузка операции ++: одновременно увеличивает значение всех
        /// элементов массива на 1</summary>
        /// <param name="obj">объект класса IntArray</param>
        /// <returns>объект класса IntArray</returns>
        public static IntArray operator ++(IntArray obj)
        {
            if (obj.intArray != null)
            {
                for (int n = 0; n < obj.intArray.GetLength(0); ++n)
                {
                    for (int m = 0; m < obj.intArray.GetLength(1); ++m)
                    {
                        ++obj[n, m];
                    }
                }
                return obj;
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        /// <summary> обращение к экземпляру класса дает значение true, если
        /// двумерный массив является квадратным </summary>
        /// <param name="obj">объект класса IntArray</param>
        /// <returns>логическое значение true/false</returns>
        public static bool operator true(IntArray obj)
        {
            if (obj.intArray != null)
            {
                if (obj.intArray.GetLength(0) == obj.intArray.GetLength(1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        /// <summary>Обращение к экземпляру класса дает значение false, если
        /// двумерный массив не является квадратным </summary>
        /// <param name="obj">объект класса IntArray</param>
        /// <returns>логическое значение true/false</returns>
        public static bool operator false(IntArray obj)
        {
            if(obj.intArray != null)
            {
                if(obj.intArray.GetLength(0) != obj.intArray.GetLength(1))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        /// <summary>Складывает два массива соответсвующих размерностей 
        /// </summary>
        /// <param name="lftOperand">объект класса IntArray</param>
        /// <param name="rghOperand">объект класса IntArray</param>
        /// <returns>объект класса IntArray</returns>
        public static IntArray operator+(IntArray lftOperand,IntArray rghOperand)
        {
            IntArray Result = null;
            if(lftOperand != null && rghOperand != null)
            {
                if(lftOperand.intArray.GetLength(0) == rghOperand.intArray.GetLength(0))
                {
                    if(lftOperand.intArray.GetLength(1) == rghOperand.intArray.GetLength(1))
                    {
                        int n = lftOperand.intArray.GetLength(0);
                        int m = lftOperand.intArray.GetLength(1);

                        Result = new IntArray(n, m);

                        for(int i = 0; i < n; ++i)
                        {
                            for(int z = 0; z < m; ++z)
                            {
                                Result[i, z] = lftOperand[i, z] + rghOperand[i, z];
                            }
                        }

                        return Result;
                    }
                    else
                    {
                        throw new NullReferenceException();
                    }
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        /// <summary>Преобразования класса массив в двумерный массив
        /// </summary>
        /// <param name="obj">объект класса IntArray</param>
        /// <returns>целочисленный двумерный массив чисел</returns>
        public static explicit operator int[,](IntArray obj)
        {
            int[,] result = null;
            if(obj != null)
            {
                int n = obj.intArray.GetLength(0);
                int m = obj.intArray.GetLength(1);
                result = new int[n, m];
                for(int i = 0; i < n; ++i)
                {
                    for(int z = 0; z < m; ++z)
                    {
                        result[i, z] = obj[i, z];
                    }
                }
            }
            return result;
        }

        /// <summary>Преобразование двумерного массива целых чисел в объект 
        /// класса IntArray</summary>
        /// <param name="array">Двумерный массив целых чисел</param>
        /// <returns>объект класса IntArray</returns>
        public static explicit operator IntArray(int[,] array)
        {
            IntArray result = null;
            if(array != null)
            {
                int n = array.GetLength(0);
                int m = array.GetLength(1);
                result = new IntArray(n, m);

                for(int i = 0; i < n; ++i)
                {
                    for(int z = 0; z < m; ++z)
                    {
                        result[i, z] = array[i, z];
                    }
                }
            }
            return result;
        }
    }
}
