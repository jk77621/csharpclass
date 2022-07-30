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
            /* Assignment05
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
                        result2 = Calculator(float.Parse(list[i][0]), list[i][1], float.Parse(list[i][2]));
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
            */

            /* Assignment06
            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < i + 1; ++j)
                {
                    Write("*");
                }
                WriteLine();
            }

            WriteLine();
            WriteLine();

            int k = 4;
            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < k - i; ++j)
                {
                    Write(" ");
                }
                for (int j = 0; j < i + 1; ++j)
                {
                    Write("*");
                }
                WriteLine();
            }

            WriteLine();
            WriteLine();

            int l = 4;
            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < l - i; ++j)
                {
                    Write(" ");
                }
                for (int j = 0; j < (i * 2) + 1; ++j)
                {
                    Write("*");
                }
                WriteLine();
            }

            WriteLine();
            WriteLine();

            int p = 4;
            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < p - i; ++j)
                {
                    Write(" ");
                }
                for (int j = 0; j < (i * 2) + 1; ++j)
                {
                    Write("*");
                }
                WriteLine();
            }

            int t = 7;
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < i + 1; ++j)
                {
                    Write(" ");
                }
                for (int j = 0; j < t - (i * 2); ++j)
                {
                    Write("*");
                }
                WriteLine();
            }

            ReadKey();
            */

            string name = "";
            int carbohydrate = 0;
            int spandrel = 0;
            int calorie = 0;
            int happiness = 0;

            PotatoRice pr = new PotatoRice();
            SweetPotatoRice sr = new SweetPotatoRice();
            MeatSideDish ms = new MeatSideDish();
            KimchiSideDish ks = new KimchiSideDish();

            pr.Init();
            sr.Init();
            ms.Init();
            ks.Init();

            WriteLine($"{pr.name}, 탄수화물 : {pr.carbohydrate}, 공복 : {pr.spandrel}");
            WriteLine($"{sr.name}, 탄수화물 : {sr.carbohydrate}, 공복 : {sr.spandrel}");
            WriteLine($"{ms.name}, 행복도 : {ms.happiness}, 칼로리 : {ms.calorie}");
            WriteLine($"{ks.name}, 행복도 : {ks.happiness}, 칼로리 : {ks.calorie}");
            WriteLine();

            name = "조재광";
            carbohydrate = pr.Eat() + sr.Eat();
            spandrel = pr.NotEat() + sr.NotEat();
            calorie = ms.Eat() + ks.Eat();
            happiness = ms.NotEat() + ks.NotEat();

            WriteLine();
            WriteLine($"{name}, 탄수화물 : {carbohydrate}, 공복 : {spandrel}, 칼로리 : {calorie}, 행복도 : {happiness}");

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
