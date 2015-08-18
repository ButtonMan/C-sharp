//+---------------------------------------------------------------------------+
/*  УСЛОВИЕ ЗАДАЧИ:
 *  Дана строка, в которой содержится осмысленное текстовое сообщение. Слова 
 *  сообщения разделяются пробелами и знаками препинания. Найти все самые 
 *  короткие слова сообщения. При решении задач из данного пункта использовать 
 *  тип string или StringBuilder. Свой выбор обосновать.
 */
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_3_7
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

            //::поиск самого короткого слова в текстовой строке. Вывод 
            //  полученного результата на экран
            Console.WriteLine(Environment.NewLine + "RESULT: " +
                Environment.NewLine + "Smallest word(s): {0}",
                SmallestWords(text));
        }



        //ОБЪЯВЛЕНИЕ МЕТОДОВ
        //+-------------------------------------------------------------------+

        public static string SmallestWords(string text)
        {
            StringBuilder smallestWords = new StringBuilder();
            char[] Splitters = {',','.','!','?','(',')','%','#','=', ' '};
            string[] subStrings = text.Split(Splitters);
            int minLength = subStrings[0].Length;
            int length = 0;
            foreach(string value in subStrings)
            {
                length = value.Length;
                if(minLength > length)
                {
                    minLength = length;
                    smallestWords.Clear();
                    smallestWords.Append(value);
                }
                else
                {
                    if(minLength == length)
                    {
                        if (!(smallestWords.ToString().Contains(value)))
                        {
                            smallestWords.Append(((smallestWords.Length > 0) ? 
                                " " : "") + value);
                        }
                    }
                }
            }

            return smallestWords.ToString();
        }
    }
}
