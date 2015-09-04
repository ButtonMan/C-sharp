//+---------------------------------------------------------------------------+
/*  Задание 5. Создать класс для работы с одномерным массивом целых чисел.
 *  Разработать следующие члены класса:
 *  1. Поля:
 *  -int [] IntArray;
 *  2. Конструктор, позволяющий создать массив размерности n.
 *  3. Методы, позволяющие:
 *  -ввести элементы массива с клавиатуры;
 *  -вывести элементы массива на экран;
 *  -отсортировать элементы массива в порядке возрастания.
 *  4. Свойство:
 *  -возвращающее размерность массива (доступное только для чтения);
 *  -позволяющее домножить все элементы массива на скаляр (доступное только 
 *  для записи).
 *  5. Индексатор, позволяющий по индексу обращаться к соответствующему 
 *  элементу массива.
 *  6. Перегрузку:
 *  -операции ++ (--): одновременно увеличивает (уменьшает) значение всех
 *  элементов массива на 1;
 *  -операции !: возвращает значение true, если элементы массива не 
 *  упорядочены по возрастанию, иначе false;
 *  -операции бинарный *: домножить все элементы массива на скаляр;
 *  -операции преобразования класса массив в одномерный массив (и наоборот).
 *  -Продемонстрировать работу класса.
 */
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_5
{
    class Program
    {
        static void Main(string[] args)
        {

            //РЕШЕНИЕ ЗАДАЧИ
            //+---------------------------------------------------------------+


            //ТЕСТИРОВАНИЕ:

            //:: 1. конструктора
            MyArray myArray = new MyArray(5);

            //:: 2. метод Set
            //      позволяет инициализировать массив, 
            //      множеством целочисленных значений
            myArray.Set(1, 5, 3, 2, 4);

            //:: 3. метод GetInfo 
            //      преобразует числовой массив в текстовую 
            //      строку
            Console.WriteLine(Environment.NewLine + "1. Вывод на экран " +
                "значений элементов массива " + Environment.NewLine +
                "{0}", myArray.GetInfo());

            //:: 4. метод Sort
            //      выполненяет сортровку массива чисел
            myArray.Sort();
            Console.WriteLine(Environment.NewLine + "2. Вывод на экран " +
                "результатов сортировки массива " + Environment.NewLine +
                "{0}" + Environment.NewLine, myArray.GetInfo());

            //:: 5. оператор ++
            //      Увеличивает значение всех элементов на 1
            Console.WriteLine(Environment.NewLine + "3. Вывод на экран " +
                "результатов вычисление операции: ++myArray " + 
                Environment.NewLine + "{0}" + Environment.NewLine, 
                (++myArray).GetInfo());

            //:: 6. оператор ++
            //      Увеличивает значение всех элементов на 1
            Console.WriteLine(Environment.NewLine + "4. Вывод на экран " +
                "результатов вычисление операции: myArray++ " +
                Environment.NewLine + "{0}" + Environment.NewLine,
                (myArray++).GetInfo());

            //:: 7. оператор --
            //      Уменьшает значение всех элементов на 1
            Console.WriteLine(Environment.NewLine + "5. Вывод на экран " +
                "результатов вычисление операции: myArray-- " +
                Environment.NewLine + "{0}" + Environment.NewLine,
                (--myArray).GetInfo());

            //:: 8. оператор --
            //      Уменьшает значение всех элементов на 1
            Console.WriteLine(Environment.NewLine + "6. Вывод на экран " +
                "результатов вычисление операции: myArray-- " +
                Environment.NewLine + "{0}" + Environment.NewLine,
                (myArray--).GetInfo());

            //:: 9. оператор !
            //      Проверятет отсортирован ли массив в каком либо порядке
            Console.WriteLine(Environment.NewLine + "7. Вывод на экран " +
                "результатов применения оператора \"!\": (!myArray)?" + 
                "отсортирован:не отсартирован" + Environment.NewLine + 
                "{0}" + Environment.NewLine,(!myArray)?"отсортирован":
                "не отсартирован");

            //::10. оператор *
            //      Умножает значения всех элементов массива на скаляр
            Console.WriteLine(Environment.NewLine + "8. Вывод на экран " +
                "результатов применения оператора \"*\": myArray * 2"
                + Environment.NewLine + "{0}" + Environment.NewLine, 
                (myArray * 2).GetInfo());

            //::11. оператор *
            //      Умножает значения всех элементов массива на скаляр
            Console.WriteLine(Environment.NewLine + "9. Вывод на экран " +
                "результатов применения оператора \"*\": 2 * myArray"
                + Environment.NewLine + "{0}" + Environment.NewLine,
                (2 * myArray).GetInfo());

            //::12.явное преобразование объекта класса MyArray в массив
            //      целых чисел
            Console.WriteLine(Environment.NewLine + "10. Вывод на экран " +
                "результатов применения операции явного преобразования" +
                "объекта класса MyArray в массив целых чисел" +
                Environment.NewLine + "{0}" + Environment.NewLine, 
                string.Join("", (int[])myArray));
                
            //::13. свойство Length
            //      Возвращает количество элементов в массиве
            Console.WriteLine("11. Количество элементов в массиве определенное" +
                "при помощи свойства myArray."
                + "Length" + Environment.NewLine + "{0}", myArray.Length);

            //::14. свойство Length
            //      Возвращает количество элементов в массиве
            myArray.Multiply = 2;
            Console.WriteLine("12. Тестирования работы свойства Multiply: "
                + "Multiply = 2" + Environment.NewLine + "{0}",
                myArray.GetInfo());

            //::15. свойство Length
            //      Возвращает количество элементов в массиве
            myArray[0] = 10;
            Console.WriteLine("13. Тестирования работы индексатора: "
                + "myArray[0] = 10" + Environment.NewLine + "{0}",
                myArray.GetInfo());
        }
    }
}
