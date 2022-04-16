using System;

namespace Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class ACode");
            ACode aCode = new ACode();
            string encodeStr = aCode.Encode("ABCD");
            Console.WriteLine(encodeStr);
            Console.WriteLine(aCode.Decode(encodeStr));

            Console.WriteLine("Class BCode");
            BCode bCode = new BCode();
            encodeStr = bCode.Encode("ABYZ");
            Console.WriteLine(encodeStr);
            Console.WriteLine(bCode.Decode(encodeStr));
        }
    }
}
