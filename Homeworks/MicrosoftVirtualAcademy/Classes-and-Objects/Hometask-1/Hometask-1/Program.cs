//+---------------------------------------------------------------------------+
/*Задание 1. Создать класс Point, содержащий следующие члены класса:
 * 1. Поля:
 * int x, y;
 * 2. Конструкторы, позволяющие создать экземпляр класса: 
 * с нулевыми координатами;
 * с заданными координатами.
 * 3. Методы, позволяющие:
 * вывести координаты точки на экран;
 * рассчитать расстояние от начала координат до точки;
 * переместить точку на плоскости на вектор (a, b).
 * 4. Свойство:
 * позволяющее получить-установить координаты точки (доступное для чтения и
 * записи);
 * позволяющее умножить координаты точки на скаляр (доступное только для
 * записи).
 * 5. Индексатор, позволяющий по индексу 0 обращаться к полю x, по индексу 1 – к
 * полю y, при других значениях индекса выдается сообщение об ошибке.
 * 6. Перегрузку:
 * операции ++ (--): одновременно увеличивает (уменьшает) значение полей х и у
на 1;
 * констант true и false: обращение к экземпляру класса дает значение true, если
значение полей x и у совпадает, иначе false;
 * операции бинарный +: одновременно добавляет к полям х и у значение скаляра.
 * Продемонстрировать работу класса.
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


    class Program
    {

        //ТОЧКА ВХОДА В ПРОГРАММУ
        //+-----------------------------------------------------------------------+
        static void Main(string[] args)
        {



            //::создание объекта Point с использованием конструктора без параметров
            Point pointA = new Point();
            Console.Write("1. Разультат работы конструктора без параметров " +
                Environment.NewLine + "--> pointA");
            pointA.Show();
            Console.WriteLine();



            //::создание объекта Point с использованием конструктора с параметрами
            Point pointB = new Point(1, 2);
            Console.Write("2. Результат работы конструктора с параметрами " +
                Environment.NewLine + "--> pointB");
            pointB.Show();
            Console.WriteLine();



            //::тестирование свойства позволяющего редактировать и извлекать 
            //  положение точки по Х 
            Console.WriteLine("3. Tестирование свойств позволяющих редактировать"
                + " и извлекать положение точки по оси Х, Y");
            pointA.X = 2;
            Console.WriteLine("pointA.X = {0}", pointA.X);
            pointA.Y = 4;
            Console.WriteLine("pointA.Y = {0}", pointA.Y);
            Console.Write("pointA");
            pointA.Show();
            Console.WriteLine();



            //::Тестирование свойства выполняющего умножать  координату 
            //  точки на  скаляр
            Console.WriteLine("4. Тестирование свойств выполняющих " +
                "умножение координаты точки на скаляр");
            Console.WriteLine("pointA.MultiplyScalX = {0}", 2);
            Console.WriteLine("pointA.MultiplyScalY = {0}", 2);
            pointA.MultiplyScalX = 2;
            pointA.MultiplyScalY = 2;
            Console.Write("pointA");
            pointA.Show();
            Console.WriteLine();



            //::расчет расстояния от точки до начала координат
            Console.WriteLine("5. Расчет расстояния от точки до начала " +
                "координат");
            Console.WriteLine("pointA.VectorDistance --> {0}", 
                pointA.VectorDistance());
            Console.WriteLine();



            //::выполнение суммирования векторов
            Console.WriteLine("6. Тестирование операции суммирования векторов");
            Point pointC = new Point(2, 4);
            Console.Write("pointC({0},{1}) + pointA({2},{3}) =",pointC.X,
                pointC.Y, pointA.X, pointA.Y);
            pointA.VectorSum(pointC.X, pointC.Y);
            pointA.Show();
            Console.WriteLine();



            //::Тестирование работы индексатора, позволяющего по индексу 0 
            //  обращаться к полю x, по индексу 1 – к полю y, при других 
            //  значениях индекса выдается сообщение об ошибке
            Console.WriteLine("7. Тестирование работы индексатора, " +
                "позволяющего по индексу 0 обращаться к полю x, по индексу 1" +
                "– к полю y, при других значениях индекса выдается сообщение" +
                "об ошибке");
            Console.WriteLine("pointA[0] = {0}", pointA[0] = 1);
            Console.WriteLine("pointA[1] = {0}", pointA[1] = 2);
            Console.Write("pointA");
            pointA.Show();
            Console.WriteLine();



            //::Тестирование перегруженного унарного оператора ++
            Console.WriteLine("8. Тестирование перегруженного унарного " +
                "оператора ++");
            ++pointA;
            Console.WriteLine("++pointA = ({0},{1})", pointA.X, pointA.Y);
            Console.WriteLine();




            //::Тестирование перегруженного унарного оператора ++
            Console.WriteLine("9. Тестирование перегруженного унарного " +
                "оператора ++");
            --pointA;
            Console.WriteLine("++pointA = ({0},{1})", pointA.X, pointA.Y);
            Console.WriteLine();



            //::Тестирование перегруженных констант true и false
            Console.WriteLine("10. Тестирование перегруженных констант" +
                "true и false");
            Console.WriteLine("(pointA({0},{1})? true : false = {2}", pointA.X, 
                pointA.Y, (pointA)? true : false);
            Console.WriteLine();


            //::Тестирование работы перегруженного бинарного оператора +
            Console.WriteLine("11. Тестирование работы перегруженного " +
            "бинарного оператора \"+\"");
            Console.Write("a) pointA({0},{1}) + 1 = ", pointA.X, pointA.Y);
            pointA = pointA + 1;
            Console.WriteLine("pointA({0},{1})", pointA.X, pointA.Y);
            Console.Write("b) 1 + pointA({0},{1}) = ", pointA.X, pointA.Y);
            Point A = 1 + pointA;
            Console.WriteLine("pointA({0},{1})", pointA.X, pointA.Y);
            Console.WriteLine();
        }
    }
}
