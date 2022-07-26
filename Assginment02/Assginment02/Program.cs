using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assginment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number1 = "";
            string number2 = "";
            string type = "";
            float result1 = 0;
            float result2 = 0;
            string answer = "";
            int count = 0;
            List<List<string>> list = new List<List<string>>();

            Write("input number1 : ");
            number1 = ReadLine();

            while (true)
            {
                Write("input type : ");
                type = ReadLine();

                Write("input number2 : ");
                number2 = ReadLine();

                list.Add(new List<string>());
                list[count].Add(number1);
                list[count].Add(type);
                list[count].Add(number2);

                result1 = Calculator(float.Parse(list[count][0]), list[count][1], float.Parse(list[count][2]));
                WriteLine("result : " + list[count][0] + " " + list[count][1] + " " + list[count][2] + " = " + result1.ToString());
                WriteLine();
                WriteLine();

                Write("continue?(y/n) : ");
                answer = ReadLine();
                WriteLine();
                WriteLine();

                if (answer == "y" || answer == "Y")
                {
                    number1 = result1.ToString();
                    count++;
                    continue;
                }
                else if (answer == "n" || answer == "N")
                {
                    for (int i = 0; i < list.Count; ++i)
                    {
                        result2 = Calculator(float.Parse(list[i][0]), list[i][1], float.Parse(list[count][2]));
                        WriteLine("result : " + list[i][0] + " " + list[i][1] + " " + list[i][2] + " = " + result2.ToString());
                    }
                    break;
                }
                else
                {
                    WriteLine("error");
                    return;
                }
            }

            WriteLine("finish");
            ReadKey();
        }

        static float Calculator(float number1, string type, float number2)
        {
            float result;
            switch (type)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }
    }
}
