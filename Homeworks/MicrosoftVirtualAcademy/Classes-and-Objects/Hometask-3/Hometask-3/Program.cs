//+---------------------------------------------------------------------------+
/*  Задание 3. Создать класс Rectangle, содержащий следующие члены класса:
 *  1. Поля:
 *  - int a, b;
 *  2. Конструктор, позволяющий создать экземпляр класса с заданными длинами
 *  сторон.
 *  3. Методы, позволяющие:
 *  -вывести длины сторон прямоугольника на экран;
 *  -расчитать периметр прямоугольника;
 *  -расчитать площадь прямоугольника.
 *  4. Свойство:
 *  -позволяющее получить-установить длины сторон прямоугольника (доступное
 *  для чтения и записи);
 *  -позволяющее установить, является ли данный прямоугольник квадратом
 *  (доступное только для чтения).
 *  5. Индексатор, позволяющий по индексу 0 обращаться к полю a, по индексу 1 – к
 *  полю b, при других значениях индекса выдается сообщение об ошибке.
 *  6. Перегрузку:
 *  -операции ++ (--): одновременно увеличивает (уменьшает) значение полей a и b;
 *  -констант true и false: обращение к экземпляру класса дает значение true, если
 *  прямоугольник с заданными длинами сторон является квадратом, иначе false;
 *  -операции *: одновременно домножает поля a и b на скаляр.
 *  Продемонстрировать работу класса.
 */
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //:: 1. Cоздание объекта класса Rectangle, с использованием
            //      конструктора с параметрами
            Console.WriteLine("1. Cоздание объекта класса Rectangle, с " +
                "использованием конструктора с параметрами");
            Rectangle ABCD = new Rectangle(4, 2);


            //:: 2. Вывод длин сторон прямоугольника на экран
            Console.WriteLine(Environment.NewLine + ABCD.GetInfo());


            //:: 3. Расчет периметра прямоугольника
            Console.WriteLine(Environment.NewLine + "2. ABCD perimeter = {0:D}",
                ABCD.Perimeter());


            //:: 4. Расчет площади прямоугольника
            Console.WriteLine(Environment.NewLine + "3. ABCD square= {0:F2}",
                ABCD.Square());


            //:: 5. Извлечение значений сторон прямоугольника при помощи свойств
            Console.WriteLine(Environment.NewLine + "4. Извлечение значений " +
                "сторон прямоугольника при помощи свойств: ");
            Console.WriteLine("ABCD.A = {0:D}", ABCD.A);
            Console.WriteLine("ABCD.B = {0:D}", ABCD.B);


            //:: 6. Редактирование значений сторон прямоугольника при помощи 
            //      свойств
            Console.WriteLine(Environment.NewLine + "5. Редактирование " +
                "значений сторон прямоугольника при помощи свойств: ");
            Console.WriteLine("ABCD.A = {0:D}", ABCD.A = 5);
            Console.WriteLine("ABCD.B = {0:D}", ABCD.B = 3);


            //:: 7. Проверка, является ли фигура с сторонами A, B
            //      прямоугольником.
            Console.WriteLine(Environment.NewLine + "6. Проверка, является " +
                "ли фигура с заданными пользователем сторонами A, B, C " +
                "прямоугольником");
            Console.WriteLine("Is Rectangle: {0}", ABCD.IsRectangle);


            //:: 8. Извлечение значений сторон прямоугольника при помощи 
            //      индексатора
            Console.WriteLine(Environment.NewLine + "7. Извлечение значений " +
                "сторон прямоугольника при помощи индексатора: ");
            Console.WriteLine("ABCD[0] = {0:D}", ABCD[0]);
            Console.WriteLine("ABCD[1] = {0:D}", ABCD[1]);


            //:: 9. Редактирование значений сторон прямоугольника при помощи 
            //      индексатора
            Console.WriteLine(Environment.NewLine + "8. Редактирование " +
                "значений сторон прямоугольника при помощи индексатора: ");
            Console.WriteLine("ABCD[0] = {0:D}", ABCD[0] = 100);
            Console.WriteLine("ABCD[1] = {0:D}", ABCD[1] = 50);


            //:: 10.Проверка работы перегруженных операторов true, false
            Console.WriteLine(Environment.NewLine + "9. Проверка работы " +
                "перегруженных операторов true, false: ");
            Console.WriteLine("({0})? true : false => " +
                "Result = {1}", ABCD.GetInfo(), ((ABCD) ? "true" : "false"));


            //:: 11. Проверка работы перегруженных обператоров "++" и "--"
            Console.WriteLine(Environment.NewLine + "10. Проверка " +
                "работы перегруженных обператоров \"++\" и \"--\" ");
            Console.WriteLine("{0} => ++ABCD => {1:D}", ABCD.GetInfo(), 
                (++ABCD).GetInfo());
            Console.WriteLine("{0} => --ABCD => {1:D}", ABCD.GetInfo(),
                (--ABCD).GetInfo());


            //:: 12. Проверка работы перегруженного обператора "*"
            Console.WriteLine(Environment.NewLine + "11. Проверка " +
                "работы перегруженного обператора \"*\" ");
            Console.WriteLine("{0} => ABCD * 2 = {1:D}", ABCD.GetInfo(),
                (ABCD * 2).GetInfo());
            Console.WriteLine("{0} => 2 * ABCD = {1:D}", ABCD.GetInfo(),
                (2 * ABCD).GetInfo());
        }
    }
}
