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
            /* assignment07
            Random random = new Random();
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int[] list = ReturnIntArray1(random);
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
            */

            /* assignment08
            Random random = new Random();
            int[] arr = new int[5];
            int count1 = 0;
            int count2 = 0;
            string[] input = new string[5];

            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = random.Next(1, 49);

                for (int j = 0; j < i; ++j)
                {
                    if (arr[i] == arr[j])
                    {
                        i--;
                        break;
                    }
                }
            }

            WriteLine("숫자를 입력해주세요! (단, 중복x 띄어쓰기x)");

            for (int i = 0; i < 5; ++i)
            {
                Write((count1 + 1) + "번째 숫자 : ");
                input[i] = ReadLine();
                count1++;
            }

            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 5; ++j)
                {
                    if (arr[i].ToString() == input[j])
                    {
                        count2++;
                        break;
                    }
                }
            }

            switch (count2) {
                case 0:
                    WriteLine("꼴등!");
                    break;
                case 1:
                    WriteLine("5등!");
                    break;
                case 2:
                    WriteLine("4등!");
                    break;
                case 3:
                    WriteLine("3등!");
                    break;
                case 4:
                    WriteLine("2등!");
                    break;
                case 5:
                    WriteLine("1등!");
                    break;

            }

            ReadKey();4
            */

            Random random = new Random();
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;

            string input1 = "";
            string input2 = "";

            WriteLine("게임을 시작합니다!");
            Write("게임에서 사용할 숫자 개수를 입력해주세요.(2~8) : ");
            input1 = ReadLine();
            count4 = int.Parse(input1);
            WriteLine();

            int[] arr = ReturnIntArray2(random, count4);

            while (true)
            {
                count2 = 0;
                count3 = 0;

                WriteLine("라운드  : " + (count1 + 1));
                Write("확인하고 싶은 숫자 " + count4 + "개를 써주세요.(띄어쓰기 없음, 안적기 없음) : ");
                input2 = ReadLine();

                for (int i = 0; i < count4; ++i)
                {
                    for (int j = 0; j < count4; ++j)
                    {
                        if (arr[i].ToString() == input2[j].ToString())
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
                if (count2 == count4)
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
            Write("고생하셨습니다! 총 플레이 " + (count1 + 1) + "라운드 하셨습니다.");

            ReadKey();
        }

        static int[] ReturnIntArray1(Random _rand)
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

        static int[] ReturnIntArray2(Random _rand, int _length)
        {
            int[] intArray = new int[_length];
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
