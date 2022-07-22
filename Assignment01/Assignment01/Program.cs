using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string string1;
            string string2;
            string string3;
            string string4;
            */

            string string5;
            string string6;

            /*
            int int1;
            float float1;
            */

            float float2;
            float float3;
            float float4;
            float float5;
            float float6;
            float float7;
            float float8;

            /* Assignment01
            Console.WriteLine("Hello World");
            */

            /* Assignment02
            Console.Write("Write String1 : ");
            string1 = Console.ReadLine();

            Console.Write("Write String2 : ");
            string2 = Console.ReadLine();

            Console.WriteLine("1. " + string1 + "\n" + string2);
            Console.WriteLine("2. " + $"{string1}\n{string2}");
            Console.WriteLine("3. {1}\n{0}", string2, string1);
            Console.WriteLine(@"4. " + string1 + "\n" + string2);
            */

            /*
            Console.Write("Write Number : ");
            string3 = Console.ReadLine();

            int1 = int.Parse(string3);
            Console.WriteLine("int : " + int1);

            float1 = (float)int1;
            Console.WriteLine("float : " + float1);

            string4 = float1.ToString();
            Console.WriteLine("string : " + string4);
            */

            Console.Write("Input Float : ");
            string5 = Console.ReadLine();
            float2 = float.Parse(string5);

            Console.Write("Input Float : ");
            string6 = Console.ReadLine();
            float3 = float.Parse(string6);

            float4 = float2 + float3;
            Console.WriteLine("+ : " + float4);

            float5 = float2 - float3;
            Console.WriteLine("- : " + float5);

            float6 = float2 % float3;
            Console.WriteLine("% : " + float6);

            float7 = float2 / float3;
            Console.WriteLine("/ : " + float7);

            float8 = float2 * float3;
            Console.WriteLine("* : " + float8);

            Console.ReadKey();
        }
    }
}
