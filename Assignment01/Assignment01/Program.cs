using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World");
            // Console.ReadKey();

            string string1;
            string string2;
            char string3;
            int number1;

            Console.Write("Enter String1: ");
            string1 = Console.ReadLine();

            Console.Write("Enter String2: ");
            string2 = Console.ReadLine();

            Console.WriteLine("1. " + string1 + "\n" + string2);
            Console.WriteLine("2. " + $"{string1}\n{string2}");
            Console.WriteLine("3. {1}\n{0}", string2, string1);
            Console.WriteLine($"4. " + string1 + "\n" + string2);

            Console.WriteLine("Enter Number1: ");
            number1 = Console.Read();
            string3 = (char)number1;
            Console.Write(string3);

            Console.ReadKey();
        }
    }
}
