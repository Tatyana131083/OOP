using System;
using System.Text;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Строка - Hello World!");
            Console.WriteLine(ReverseString("Hello World!"));





            /// <summary>
            /// Строка в обратном порядке
            /// </summary>
            /// <param name="str">Строка</param>
            /// <returns>Строка, буквы которой идут в обратном порядке</returns>
            static string ReverseString(string str)
            {
                StringBuilder strBuilder = new StringBuilder();
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    strBuilder.Append(str[i]); 
                }
                return strBuilder.ToString();
            }
        }
    }
}
