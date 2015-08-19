//+---------------------------------------------------------------------------+
/*  УСЛОВИЕ ЗАДАЧИ:
 *  Дана строка, в которой содержится осмысленное текстовое сообщение. Слова 
 *  сообщения разделяются пробелами и знаками препинания. Вывести слова 
 *  сообщения в порядке возрастания их длин. При решении задач из данного пункта 
 *  использовать тип string или StringBuilder. Свой выбор обосновать.
 */
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_3_9
{
    class Program
    {
        static void Main()
        {
            //ОБЪЯВЛЕНИЕ ПЕРЕМЕННЫХ
            //+---------------------------------------------------------------+
            string text = String.Empty;     //текстовая строка



            //ВВОД ДАННЫХ
            //+---------------------------------------------------------------+

            //::ввод пользователем строки произвольного содержания
            Console.Write("Input any string" + Environment.NewLine + "--> ");
            text = Console.ReadLine();



            //РЕШЕНИЕ ЗАДАЧИ
            //+---------------------------------------------------------------+

            //::сортировка слов строки по их длинне. Вывод полученного 
            //  результата на экран
            Console.WriteLine(Environment.NewLine + "RESULT: " +
                Environment.NewLine + "Sorted string --> {0}",
                SortByLength(text));


        }



        //ОБЪЯВЛЕНИЕ МЕТОДОВ
        //+-------------------------------------------------------------------+

        /// <summary>Сортирует слова сообщения в порядке возрастания их длин.
        /// </summary>
        /// <param name="text"> произвольная текстовая строке</param>
        /// <returns>текстовая строка содержащая в себе отсортированные
        /// по возрастсанию длинны подстроки</returns>
        public static string SortByLength(string text)
        {
            string[] substrings = text.Split();
            StringBuilder sortedText = new StringBuilder();
            string tmpBuffer = null;

            if(substrings != null)
            {
                int arrayLength = substrings.GetLength(0) - 1;
                for (int z = 0; z < arrayLength; ++z)
                {
                    for (int i = 0; i < arrayLength; ++i)
                    {
                        if (substrings[i].Length > substrings[i + 1].Length)
                        {
                            tmpBuffer = substrings[i];
                            substrings[i] = substrings[i + 1];
                            substrings[i + 1] = tmpBuffer;
                        }
                    }
                }
            }
            return String.Join(" ", substrings);
        }
    }
}