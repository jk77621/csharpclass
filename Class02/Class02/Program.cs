using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Class02
{
    class Program
    {
        static void Main(string[] args)
        {
            /* for
            string string1;
            string string2;
            string string3 = "5";

            string1 = ReadLine();
            string2 = ReadLine();

            int count = int.Parse(string1);
            for (int i = 0; i < count; ++i)
            {
                if (i == 5) WriteLine(string3);

                WriteLine(string2);
            }

            ReadKey();
            */

            /* list, array, foreach
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };

            foreach (int i in list)
            {
                WriteLine(i);
            }

            foreach (int i in arr)
            {
                WriteLine(i);
            }

            ReadKey();
            */

            /* switch, return, continue, break
            string string1;
            bool bFlag = true;

            string1 = ReadLine();

            switch (string1)
            {
                case "1":
                    WriteLine("hello");
                    break;
                case "2":
                    WriteLine("my");
                    break;
                case "3":
                    WriteLine("world");
                    break;
                case "4":
                    WriteLine("SBS");
                    break;
                case "5":
                    WriteLine("academy");
                    break;
                default:
                    WriteLine("error");
                    break;
            }

            while (bFlag)
            {
                if (string1 == "2")
                {
                    return;
                }
                else if (string1 == "3")
                {
                    continue;
                }
                else if (string1 == "4")
                {
                    break;
                }

                bFlag = false;
            }

            ReadKey();
            */

            /* method
            string string1;
            string string2;
            string string3;
            int int1;
            int int2;
            int result;

            Write("input input1 : ");
            string1 = ReadLine();

            Write("input input2 : ");
            string2 = ReadLine();

            Write("input calcu : ");
            string3 = ReadLine();

            int1 = int.Parse(string1);
            int2 = int.Parse(string2);

            result = Calculator(int1, int2, string3);
            WriteLine("result : " + result);

            ReadKey();
            */

            /* hanoitower
            int floor = 2;
            int from = 0;
            int via = 1;
            int to = 2;

            HanoiTower(floor, from, via, to);
            ReadKey();
            */

            /* Class
            Tree cTree = new Tree();
            cTree.Name = "pine tree";
            */

            /* Inheritance
            Food myFood = new Food();
            myFood.HowMuchIsIt();
            // myFood.ThisFoodNameisThis();

            KoreanFood myKoreanFood = new KoreanFood();
            myKoreanFood.Guest();
            myKoreanFood.HowMuchIsIt();

            ReadKey();
            */

            MainCharacter myMainCharacter = new MainCharacter();
            Zombie zombie = new Zombie();
            Ghost ghost = new Ghost();

            myMainCharacter.Init();
            zombie.Init();
            ghost.Init();

            myMainCharacter.Attack(zombie);
            zombie.Attack( myMainCharacter);
            ghost.Attack( myMainCharacter);
            myMainCharacter.Attack(zombie);

            ReadKey();
        }

        static int Calculator(int int1, int int2, string string3)
        {
            int result;
            switch (string3)
            {
                case "+":
                    result = int1 + int2;
                    break;
                case "-":
                    result = int1 - int2;
                    break;
                case "/":
                    result = int1 / int2;
                    break;
                case "*":
                    result = int1 * int2;
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }

        static void HanoiTower(int floor, int from, int via, int to)
        {
            if (floor == 0)
            {
                WriteLine(from + " -> " + to);
            }
            else
            {
                HanoiTower(floor - 1, from, to, via);
                WriteLine(from + " -> " + to);
                HanoiTower(floor - 1, via, from, to);
            }
        }

        public class Tree
        {
            public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    name = value;
                }
            }

            private string name;
        }
    }
}
