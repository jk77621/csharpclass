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

        public void start()
        {
            Random rnd = new Random();
            const string LINE = "----------------------------------------------";
            const int END_LINE = 42;
            const int DELAY_TIME = 200; //0.2초마다 한번씩 실행
            int runA = 0; //1번말
            int runB = 0; //2번말
            int runC = 0; //3번말
            int runD = 0; //4번말

            while (true)
            {
                ++runA; //1번말 1칸앞으로
                ++runB; //2번말 1칸앞으로
                ++runC; //3번말 1칸앞으로
                ++runD; //4번말 1칸앞으로

                int rndNum = rnd.Next(0, 4);

                switch (rndNum)
                {
                    case 0:
                        ++runA; //1번말 1칸앞으로
                        break;
                    case 1:
                        ++runB; //2번말 1칸앞으로
                        break;
                    case 2:
                        ++runC; //3번말 1칸앞으로
                        break;
                    case 3:
                        ++runD; //4번말 1칸앞으로
                        break;
                }

                Thread.Sleep(DELAY_TIME); //딜레이
                Clear(); //화면 지우기

                WriteLine(LINE);
                for (int i = 0; i < runA; i++)
                    Write(" ");
                Write("1");
                for (int i = (END_LINE - 2) - runA; i >= 0; i--)
                    Write(" ");
                WriteLine("|");

                for (int i = 0; i < runB; i++)
                    Write(" ");
                Write("2");
                for (int i = (END_LINE - 2) - runB; i >= 0; i--)
                    Write(" ");
                WriteLine("|");

                for (int i = 0; i < runC; i++)
                    Write(" ");
                Write("3");
                for (int i = (END_LINE - 2) - runC; i >= 0; i--)
                    Write(" ");
                WriteLine("|");

                for (int i = 0; i < runD; i++)
                    Write(" ");
                Write("4");
                for (int i = (END_LINE - 2) - runD; i >= 0; i--)
                    Write(" ");
                WriteLine("|");

                WriteLine(LINE);

                if (runA >= END_LINE || runB >= END_LINE || runC >= END_LINE || runD >= END_LINE)
                {
                    int runNum = 0;
                    string strResult = "결과:    !!{0} 선수 우승 !!";
                    if (runA >= END_LINE)
                        runNum = 1;
                    else if (runB >= END_LINE)
                        runNum = 2;
                    else if (runC >= END_LINE)
                        runNum = 3;
                    else
                        runNum = 4;

                    WriteLine(strResult, runNum);

                    Write("다시하시려면 0번 입력: ");
                    if (0 == int.Parse(ReadLine()))
                    {
                        runA = 0;
                        runB = 0;
                        runC = 0;
                        runD = 0;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
