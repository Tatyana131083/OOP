using System;
using System.IO;
using System.Text;


namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Строка - Hello World!");
            Console.WriteLine(ReverseString("Hello World!"));
            Console.WriteLine();

            string inputFile = "mail.txt";
            string outputFile = "result.txt";
            if (File.Exists(inputFile))
            {
                using (StreamWriter sw = File.CreateText(outputFile))
                using (StreamReader sr = File.OpenText(inputFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        SearchMail(ref line);
                        Console.WriteLine(line);
                        sw.WriteLine(line);
                    }
                }
            }



            /// <summary>
            /// Выделение из строки  адреса почты, e-mail возвращается в той же строке str
            /// </summary>
            /// <param name="str">Строка</param>
            static void SearchMail(ref string str)
            {
                str = str.Substring(str.IndexOf('&') + 1).Trim();
            }

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
