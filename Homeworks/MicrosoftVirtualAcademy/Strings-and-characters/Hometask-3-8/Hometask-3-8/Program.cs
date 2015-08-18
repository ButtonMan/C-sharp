//+---------------------------------------------------------------------------+
/*  УСЛОВИЕ ЗАДАЧИ:
 *  Дана строка, в которой содержится осмысленное текстовое сообщение. Слова 
 *  сообщения разделяются пробелами и знаками препинания. Вывести на экран все 
 *  слова-палиндромы, содержащиеся в сообщении. При решении задач из данного 
 *  пункта использовать тип string или StringBuilder. Свой выбор обосновать.
 */
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_3_8
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

            //::вывод на экран всех слов-палиндромов, содержащихся в сообщении
            Console.WriteLine(Environment.NewLine + "RESULT: " +
                Environment.NewLine + "Palindromes - {0}", 
                GetPalindromes(text));
        }



        //ОБЪЯВЛЕНИЕ МЕТОДОВ
        //+-------------------------------------------------------------------+

        /// <summary>поиск в текстовой строке слов-палиндромов</summary>
        /// <param name="text">произвольная текстовая строка</param>
        /// <returns>список слов-полиндромов, оторбранных в текстовой строке
        /// </returns>
        public static string GetPalindromes(string text)
        {
            StringBuilder palindromes = new StringBuilder();
            string[] subStrings = text.Split();
            int length = 0;
            bool isEqual;
            foreach(string value in subStrings)
            {
                isEqual = true;
                length = value.Length;
                for(int i = 0, z = length - 1; i < length / 2; ++ i, --z)
                {
                    if (value[i] != value[z])
                    {
                        isEqual = false;
                        break;
                    }
                }
                if(isEqual)
                {
                    if (!palindromes.ToString().Contains(value))
                    {
                        palindromes.Append(((palindromes.Length > 0)? " " : 
                            "") + value);
                    }
                }
            }
            return palindromes.ToString();
        }
    }
}