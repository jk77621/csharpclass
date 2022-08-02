using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int[] list = ReturnIntArray(random);
            string input = "";

            WriteLine("게임을 시작합니다!");

            while (true)
            {
                count2 = 0;
                count3 = 0;

                WriteLine("라운드  : " + count1);
                Write("확인하고 싶은 숫자 3개를 써주세요(띄어쓰기 없음, 안적기 없음) : ");
                input = ReadLine();

                for (int i = 0; i < 3; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        if (list[i].ToString() == input[j].ToString())
                        {
                            if (i == j)
                            {
                                count2++;
                            }
                            else
                            {
                                count3++;
                            }
                        }
                    }
                }

                Write("result : ");
                if (count2 == 3)
                {
                    WriteLine("정답입니다!");
                    break;
                }
                else if (count2 == 0 && count3 == 0)
                {
                    WriteLine("아웃입니다!");
                }
                else
                {
                    WriteLine("S = " + count2 + ", B = " + count3);
                }
                WriteLine();

                count1++;
            }

            WriteLine();
            Write("고생하셨습니다! 총 플레이 " + count1 + "라운드 하셨습니다.");

            ReadKey();
        }

        static int[] ReturnIntArray(Random _rand)
        {
            int[] intArray = new int[3];
            for (int num = 0; num < intArray.Length; num++)
            {
                intArray[num] = _rand.Next(0, 9);

                for (int num2 = 0; num2 < num; num2++)
                {
                    if (intArray[num] == intArray[num2])
                    {
                        num--;
                        break;
                    }
                }
            }
            return intArray;
        }
    }
}
