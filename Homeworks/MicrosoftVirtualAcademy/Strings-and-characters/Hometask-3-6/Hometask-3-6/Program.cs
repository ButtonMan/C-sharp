//+---------------------------------------------------------------------------+
/*  УСЛОВИЕ ЗАДАЧИ:
 *  Дана строка, в которой содержится осмысленное текстовое сообщение. Слова 
 *  сообщения разделяются пробелами и знаками препинания. Найти самое длинное 
 *  слово сообщения. При решении задач из данного пункта использовать тип 
 *  string или StringBuilder. Свой выбор обосновать.
 */
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_3_6
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

            //:: поиск самого длинного слова в текстовой строке. Вывод 
            //  полученного результата на экран
            Console.WriteLine(Environment.NewLine + "RESULT: " +
                Environment.NewLine + "Longest word(s): {0}",
                LongestWord(text));
        }



        //ОБЪЯВЛЕНИЕ МЕТОДОВ
        //+-------------------------------------------------------------------+

        /// <summary> поиск самого длинного слова в текстовой строке</summary>
        /// <param name="text">произвольная строка текста</param>
        /// <returns>самое длинной слово входящее в состав строки </returns>
        public static string LongestWord(string text)
        {
            string[] buffer = text.Split();
            StringBuilder longestWords = new StringBuilder();
            int maxLength = 0;
            int length = 0;

            foreach (string value in buffer)
            {
                length = value.Length;
                if (maxLength < length)
                {
                    maxLength = length;
                    longestWords.Clear();
                    longestWords.Append(((longestWords.Length > 0) ? " " : "") +
                        value);
                }
                else
                {
                    if (maxLength == length)
                    {
                        if (!(longestWords.ToString().Contains(value)))
                        {
                            longestWords.Append(((longestWords.Length > 0) ? " " :
                                "") + value);
                        }
                    }
                }

            }

            return longestWords.ToString();
        }
    }
}