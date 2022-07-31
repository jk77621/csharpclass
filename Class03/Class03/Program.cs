using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Class03
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("hello world");
            WriteLine();
            WriteLine();

            int number = 3;
            string word = "Hi";

            WriteLine("1. " + number +  word);
            WriteLine("2. " + $"{number}{word}");
            WriteLine("3. {0}{1}", number, word);
            ReadKey();
        }
    }
}

/* 생성자
 * 가비지 콜렉터가 없기 때문에 생성자 사용x, 소멸자 사용x
 */


