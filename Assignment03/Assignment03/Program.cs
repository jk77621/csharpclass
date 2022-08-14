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

            /*
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
            */

            //1. 이름 나열
            string[] ourClassNames = new string[]
            {
                "김동록", "김소원", "김시현",
                "김지원", "박현웅", "프로도", "유승호",
                "윤식", "이도경", "인뚝이", "전지수", "정진경",
                "조재광", "준겸", "최유민", "태욱", "현정", "황수연", "황지후"
            };

            //2. 이름 섞기
            Random rand = new Random();
            int random1, random2;
            string temp;
            for (int i = 0; i < ourClassNames.Length; ++i)
            {
                random1 = rand.Next(0, ourClassNames.Length);
                random2 = rand.Next(0, ourClassNames.Length);

                temp = ourClassNames[random1];
                ourClassNames[random1] = ourClassNames[random2];
                ourClassNames[random2] = temp;
            }

            //3. 섞인 이름 출력
            WriteLine("섞인 이름들");
            foreach (var name in ourClassNames)
            {
                Write(name + ", ");
            }

            //4. 이름 순서 나열하기
            //4-1. 첫번째 이름부터 비교 시작
            for (int i = 0; i < ourClassNames.Length; i++)
            {
                //4-2. 해당 값을 최소값이라고 가정하고 시작한다.
                int minStringNumber = i;

                //4-3. 해당 값이후 값들과 비교를 한다.
                for (int j = i + 1; j < ourClassNames.Length; j++)
                {
                    //4-4. 이름은 3글자이기 때문에 3번 비교를 진행한다.
                    for (int k = 0; k < 3; k++)
                    {
                        //4-5. 이름이 2글자일 수도 있기 때문에, 만약 2번째 글자까지 같다면 패스한다.
                        if (ourClassNames[j].Length < k + 1 || ourClassNames[minStringNumber].Length < k + 1)
                        {
                            break;
                        }

                        int k1 = ourClassNames[j][k];
                        int k2 = ourClassNames[minStringNumber][k];
                        //4-6. k번째의 글자 값을 비교한다(k가 0이라면 성의 수치값을 비교한다)
                        if (ourClassNames[j][k] < ourClassNames[minStringNumber][k])
                        {
                            //4-7. 만약, 최소값이라고 생각했던 값보다 더 작은 수치가 나오면 해당 번째를 최소값으로 지정한다.
                            minStringNumber = j;
                            break;
                        }

                        //4-8. 같은 성씨(또는 해당번째의 같은 글자)가 아닌경우는 작다고 판단하기 때문에 넘긴다. (다음글자를 볼 필요가 없으니 넘긴다)
                        if (ourClassNames[j][k] != ourClassNames[minStringNumber][k])
                        {
                            break;
                        }
                    }
                }

                //4-9. 값을 바꾼다.
                string temp2;
                temp2 = ourClassNames[i];
                ourClassNames[i] = ourClassNames[minStringNumber];
                ourClassNames[minStringNumber] = temp2;
            }

            WriteLine("\n\n\n\n\n최종결과 :");
            foreach (var name in ourClassNames)
            {
                Write(name + ", ");
            }

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
