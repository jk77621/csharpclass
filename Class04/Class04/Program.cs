using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Class04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < i + 1; ++j)
                {
                    Write("*");
                }
                WriteLine();
            }

            WriteLine();

            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 5 - i; ++j)
                {
                    Write("*");
                }
                WriteLine();
            }

            WriteLine();

            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 4 - i; ++j)
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

            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    Write(" ");
                }

                for (int j = 0; j < 5 - i; ++j)
                {
                    Write("*");
                }

                WriteLine();
            }

            WriteLine();

            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 4 - i; ++j)
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

            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    Write(" ");
                }

                for (int j = 0; j < 7 - (i * 2); ++j)
                {
                    Write(j % 2 == 1 ? " " : "*");
                }

                WriteLine();
            }

            for (int i = 1; i < 4; ++i)
            {
                for (int j = 0; j < 3 - i; ++j)
                {
                    Write(" ");
                }

                for (int j = 0; j < (i * 2) + 1; ++j)
                {
                    Write(j % 2 == 1 ? " " : "*");
                }

                WriteLine();
            }

            WriteLine();

            WriteLine(byte.MaxValue);
            WriteLine(byte.MinValue);
            WriteLine(short.MaxValue);
            WriteLine(short.MinValue);
            WriteLine(int.MaxValue);
            WriteLine(int.MinValue);
            WriteLine(long.MaxValue);
            WriteLine(long.MinValue);
            WriteLine(float.MaxValue);
            WriteLine(float.MinValue);
            WriteLine(double.MaxValue);
            WriteLine(double.MinValue);
            WriteLine(decimal.MaxValue);
            WriteLine(decimal.MinValue);

            bool b;
            b = false;
            WriteLine(b);

            int a = 3;
            WriteLine(++a);
            WriteLine(a++);
            WriteLine(a);

            WriteLine(11 % 2 == 1 ? "홀수" : "짝수");

            ReadKey();
            */

            /*
            List<string> myList = new List<string>();
            myList.Add("사과");
            myList.Add("배");
            myList.Add("수박");
            myList.Add("복숭아");
            myList.Add("포도");

            myList.Add("사과");
            myList.RemoveAt(3);

            WriteLine(myList[3]);
            WriteLine(myList.Count);

            ReadKey();
            */

            /*
            Dictionary<string, int> myDic = new Dictionary<string, int>();
            myDic["수박"] = 2;

            WriteLine(myDic["수박"]);

            ReadKey();
            */

            List<string> myList = new List<string>();
            myList.Add("조재광");
            myList.Add("김소원");
            myList.Add("유승호");
            myList.Add("유승민");
            myList.Add("유승재");
            myList.Add("이승호");
            myList.Add("이호승");

            string temp = "";
            for (int i = 0; i < myList.Count; ++i)
            {
                char[] arr1 = myList[i].ToCharArray();

                for (int j = 0; j < myList.Count; ++j)
                {
                    char[] arr2 = myList[j].ToCharArray();

                    if ((int)arr1[0] < (int)arr2[0] && i != j)
                    {
                        temp = myList[i];
                        myList[i] = myList[j];
                        myList[j] = temp;

                        continue;
                    }
                }
            }

            temp = "";
            for (int i = 0; i < myList.Count; ++i)
            {
                char[] arr1 = myList[i].ToCharArray();

                for (int j = 0; j < myList.Count; ++j)
                {
                    char[] arr2 = myList[j].ToCharArray();

                    if ((int)arr1[0] == (int)arr2[0] && (int)arr1[1] < (int)arr2[1] && i != j)
                    {
                        temp = myList[i];
                        myList[i] = myList[j];
                        myList[j] = temp;

                        continue;
                    }
                }
            }

            temp = "";
            for (int i = 0; i < myList.Count; ++i)
            {
                char[] arr1 = myList[i].ToCharArray();

                for (int j = 0; j < myList.Count; ++j)
                {
                    char[] arr2 = myList[j].ToCharArray();

                    if ((int)arr1[0] == (int)arr2[0] && (int)arr1[1] == (int)arr2[1] && (int)arr1[2] < (int)arr2[2] && i != j)
                    {
                        temp = myList[i];
                        myList[i] = myList[j];
                        myList[j] = temp;

                        continue;
                    }
                }
            }

            WriteLine(myList[0] + " " + myList[1] + " " + myList[2] + " " + myList[3] + " " + myList[4] + " " + myList[5] + " " + myList[6]);

            ReadKey();
        }
    }
}

/* 리스트
 * 배열보단 무겁고, 쓰기 쉽다.
 * 배열과 가장 큰 차이점은 자동으로 늘리고, 임의적으로 줄일 수도 있다.
 * 
 * List<string> list = new List<string>
 * 
 * list.Add();
 * .Clear();
 * .Find();
 * .Insert();
 * .Remove();
 * .Count();
 * .Sort();
 */

/* 딕셔너리
 * 키값을 통해 가지고 온다.
 * Dictionary<string> dic = new Dictionary<string>
 */