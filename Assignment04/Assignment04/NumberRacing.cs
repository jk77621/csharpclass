using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace Assignment04
{
    internal class NumberRacing
    {
        public NumberRacing()
        {
        }

        public void run()
        {
            Random rnd = new Random();
            const string LINE = "----------------------------------------------";
            const int END_LINE = 42;
            const int DELAY_TIME = 200; //0.2초마다 한번씩 실행
            int run0 = 0; //1번말
            int run1 = 0; //2번말
            int run2 = 0; //3번말
            int run3 = 0; //4번말

            while (true)
            {
                ++run0; //1번말 1칸앞으로
                ++run1; //2번말 1칸앞으로
                ++run2; //3번말 1칸앞으로
                ++run3; //4번말 1칸앞으로

                int rndNum = rnd.Next(0, 4); //랜덤으로 0~3의 숫자를 변수에 저장한다.
                switch (rndNum)
                {
                    case 0:
                        ++run0; //1번말 1칸앞으로
                        break;
                    case 1:
                        ++run1; //2번말 1칸앞으로
                        break;
                    case 2:
                        ++run2; //3번말 1칸앞으로
                        break;
                    case 3:
                        ++run3; //4번말 1칸앞으로
                        break;
                }

                Thread.Sleep(DELAY_TIME); //딜레이
                Clear(); //화면 지우기

                WriteLine(LINE); //화면에 보여질 UI를 출력한다.

                for (int i = 0; i < run0; i++)
                    Write(" ");
                Write("1");
                for (int i = (END_LINE - 2) - run0; i >= 0; i--)
                    Write(" ");
                WriteLine("|");

                for (int i = 0; i < run1; i++)
                    Write(" ");
                Write("2");
                for (int i = (END_LINE - 2) - run1; i >= 0; i--)
                    Write(" ");
                WriteLine("|");

                for (int i = 0; i < run2; i++)
                    Write(" ");
                Write("3");
                for (int i = (END_LINE - 2) - run2; i >= 0; i--)
                    Write(" ");
                WriteLine("|");

                for (int i = 0; i < run3; i++)
                    Write(" ");
                Write("4");
                for (int i = (END_LINE - 2) - run3; i >= 0; i--)
                    Write(" ");
                WriteLine("|");

                WriteLine(LINE);
       
                if (run0 >= END_LINE || run1 >= END_LINE || run2 >= END_LINE || run3 >= END_LINE) //1~4번말 중 하나라도 끝에 지점에 도달하면 아래 내용을 출력한다.
                {
                    int runNum = 0;
                    if (run0 >= END_LINE)
                        runNum = 1;
                    else if (run1 >= END_LINE)
                        runNum = 2;
                    else if (run2 >= END_LINE)
                        runNum = 3;
                    else
                        runNum = 4;

                    WriteLine("결과 : !! " + runNum + " 선수 우승 !!");

                    WriteLine();
                    Write("다시 하시겠습니까?(y/n) : ");
                    string strRestart = ReadLine();
                    if (strRestart == "y")
                    {
                        run0 = 0;
                        run1 = 0;
                        run2 = 0;
                        run3 = 0;
                        continue;
                    }
                    else if (strRestart == "n")
                    {
                        WriteLine();
                        WriteLine("게임이 종료되었습니다!");
                        break;
                    }
                }
            }
        }
    }
}
