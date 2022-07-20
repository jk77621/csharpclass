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

            Console.WriteLine("Enter String1: ");
            string1 = Console.ReadLine();

            Console.WriteLine("Enter String2: ");
            string2 = Console.ReadLine();

            Console.Write("1. " + string1 + "\n");
            Console.Write("2. " + string2 + "\n");

            Console.WriteLine("3. " + string1);
            Console.WriteLine("4. " + string2);

            Console.WriteLine("5. " + string1 + "\n" + string2);
            Console.WriteLine("6. " + $"{string1}\n{string2}");
            Console.WriteLine("7. {1}, {0}" , string1, string2);

            Console.WriteLine("");
            Console.WriteLine("Enter Number1: ");
            number1 = System.Console.Read();
            string3 = (char)number1;
            System.Console.Write(string3);

            Console.ReadKey();
        }
    }
}
