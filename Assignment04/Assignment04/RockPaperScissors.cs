using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assignment04
{
    internal class RockPaperScissors
    {
        public RockPaperScissors()
        {
        }

        public void run()
        {
            Random rnd = new Random();
            int numAnswer = rnd.Next(0, 3);

            WriteLine("컴퓨터가 가위, 바위, 보 중 랜덤으로 하나를 정합니다.");
            WriteLine("컴퓨터를 이겨주세요!");

            while (true)
            {
                WriteLine();
                Write("숫자 입력(0:가위, 1:바위, 2:보) : ");
                string strInput = ReadLine();

                //enter, null, whitespace(s)가 입력될 경우 0으로 간주
                int numInput = string.IsNullOrWhiteSpace(strInput) ? 0 : int.Parse(strInput);
                switch (numInput)
                {
                    case 0:
                        WriteLine();
                        WriteLine("당신의 선택은 가위입니다.");
                        break;
                    case 1:
                        WriteLine();
                        WriteLine("당신의 선택은 바위입니다.");
                        break;
                    case 2:
                        WriteLine();
                        WriteLine("당신의 선택은 보입니다.");
                        break;
                }

                switch (numAnswer)
                {
                    case 0:
                        WriteLine("컴퓨터의 선택은 가위입니다.");
                        break;
                    case 1:
                        WriteLine("컴퓨터의 선택은 바위입니다.");
                        break;
                    case 2:
                        WriteLine("컴퓨터의 선택은 보입니다.");
                        break;
                }

                // 무승부, 승리, 패배
                int numResult = numInput - numAnswer;
                if (numResult == 0)
                {
                    WriteLine("무승부입니다!");
                }
                else if ((numResult == 1) || (numResult == -2))
                {
                    WriteLine("승리입니다!");
                }
                else
                {
                    WriteLine("패배입니다!");
                }

                WriteLine();
                Write("다시 하시겠습니까?(y/n) : ");
                string strRestart = ReadLine();
                if (strRestart == "y")
                {
                    numAnswer = rnd.Next(0, 3);
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
