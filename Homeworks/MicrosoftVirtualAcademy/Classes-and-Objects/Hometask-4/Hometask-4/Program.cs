//+---------------------------------------------------------------------------+
/*  Задание 4. Создать класс Money, содержащий следующие члены класса:
 *  1. Поля:
 *  - int first;//номинал купюры
 *  - int second; //количество купюр
 *  2. Конструктор, позволяющий создать экземпляр класса с заданными значениям
 *  полей.
 *  3. Методы, позволяющие:
 *  - вывести номинал и количество купюр;
 *  - определить, хватит ли денежных средств на покупку товара на сумму N 
 *  рублей.
 *  - определить, сколько штук товара стоимости n рублей можно купить на
 *  - имеющиеся денежные средства.
 *  4. Свойство:
 *  - позволяющее получить-установить значение полей (доступное для чтения и
 *  записи);
 *  - позволяющее расчитатать сумму денег (доступное только для чтения).
 *  5. Индексатор, позволяющий по индексу 0 обращаться к полю first, по 
 *  индексу 1 – к полю second, при других значениях индекса выдается сообщение 
 *  об ошибке.
 *  6. Перегрузку:
 *  - операции ++ (--): одновременно увеличивает (уменьшает) значение полей 
 *  first и second;
 *  - операции !: возвращает значение true, если поле second не нулевое, 
 *  иначе false;
 *  - операции бинарный +: добавляет к значению поля second значение скаляра.
 *  Продемонстрировать работу класса.
 */
//+---------------------------------------------------------------------------+

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_4
{
    class Program
    {
        static void Main(string[] args)
        {

            //РЕШЕНИЕ ЗАДАЧИ
            //+---------------------------------------------------------------+

            //:: 1. Cоздание объекта класса Money, с использованием
            //      конструктора с параметрами
            Money grn = new Money(1, 100);


            //:: 2. Вывод на экран номинала и количества купюр;
            Console.WriteLine(Environment.NewLine + "1. Информация о" +
                "стосятнии объекта класса Money " + Environment.NewLine +
                "{0}", grn.GetInfo());


            //:: 3. Проверка, хватит ли денежных средств на покупку товара на 
            //      сумму N рублей.
            Console.WriteLine(Environment.NewLine + "2. Проверка, хватит ли " +
            "денежных средств на покупку товара на сумму N рублей");
            Console.WriteLine("Item Price: {0} grn", 2);
            Console.WriteLine("Amount of money: {0}", grn.GetInfo());
            Console.WriteLine("Is enough money: {0}", grn.IsEnoughMoney(2));


            //:: 4. Расчет, количества товара стоимости n рублей которое можно
            //      купить на имеющиеся денежные средства.
            Console.WriteLine(Environment.NewLine + "3. Расчет, количества " +
            "товара стоимости n рублей которое можно купить на имеющиеся" +
            "денежные средства");
            Console.WriteLine("Item Price: {0} grn", 2);
            Console.WriteLine("Amount of money: {0}", grn.GetInfo());
            Console.WriteLine("Munber of items: {0}", grn.Count(2));


            //:: 5. Извлечение информации о состоянии денежных средств при 
            //      помощи свойств класса
            Console.WriteLine(Environment.NewLine + "4. Извлечение " +
            "информации о состоянии денежных средств при помощи свойств " +
            "класса: ");
            Console.WriteLine("grn.First = {0:D}", grn.First);
            Console.WriteLine("grn.Second = {0:D}", grn.Second);


            //:: 6. Редактирование информации о состоянии денежных средств при 
            //      помощи свойств класса
            Console.WriteLine(Environment.NewLine + "5. Редактирование " +
            "информации о состоянии денежных средств при помощи свойств" +
            "класса: ");
            Console.WriteLine("grn.First = {0:D} " , grn.First = 100);
            Console.WriteLine("grn.Second = {0:D}", grn.Second = 1000);

            //:: 7. Расчет денежной суммы имеющихся денег при помощи свойства
            //      класса.
            Console.WriteLine(Environment.NewLine + "6. Расчет денежной " +
                "уммы имеющихся денег при помощи свойства класса");
            Console.WriteLine("Sum of money = {0:D} ", grn.Sum);


            //:: 8. Извлечение значений полей объекта класса Money при помощи 
            //      индексатора
            Console.WriteLine(Environment.NewLine + "7. Извлечение значений " +
                "полей объекта класса Money при помощи индексатора: ");
            Console.WriteLine("grn[0] = nominal: {0:D}", grn[0]);
            Console.WriteLine("grn[1] = number: {0:D}", grn[1]);


            //:: 9. Редактирование значений полей объекта класса Money при 
            //      помощи  индексатора
            Console.WriteLine(Environment.NewLine + "8. Редактирование" +
                "значений полей объекта класса Money при помощи " +
                "индексатора: ");
            Console.WriteLine("grn[0] = nominal: {0:D}", grn[0] = 50);
            Console.WriteLine("grn[1] = number: {0:D}", grn[1] = 60);


            //:: 10. Тестирование работы перегруженного оператора "++" и "--"
            Console.WriteLine(Environment.NewLine + "9. Тестирование " +
                "работы перегруженного оператора \"++\" и \"--\": ");
            Console.WriteLine("++grn = {0}", (++grn).GetInfo());
            Console.WriteLine("--grn = {0}", (--grn).GetInfo());


            //:: 11. Тестирование работы перегруженного оператора "!"
            Console.WriteLine(Environment.NewLine + "10. Тестирование " +
                "работы перегруженного оператора \"!\": ");
            Console.WriteLine("{0} => (!grn)? true : false => {1}", 
                grn.GetInfo(), (!grn) ? "true" : "false");

            //:: 12. Тестирование работы перегруженного оператора "+"
            Console.WriteLine(Environment.NewLine + "11. Тестирование " +
                "работы перегруженного оператора \"+\": ");
            Console.WriteLine("{0} => grn + 1 => {1}",
                grn.GetInfo(), (grn + 1).GetInfo());
            Console.WriteLine("{0} => 1 + grn => {1}",
                grn.GetInfo(), (1 + grn).GetInfo());
        }
    }
}
