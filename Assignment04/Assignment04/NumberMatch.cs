using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assignment04
{
    internal class NumberMatch
    {
        public NumberMatch()
        {
        }

        public void run()
        {
            Random rnd = new Random();
            int numAnswer = rnd.Next(1, 101);
            int numTry = 0;

            WriteLine("컴퓨터가 1~100 중 랜덤 숫자 하나를 정합니다.");
            WriteLine("이 숫자를 맞춰주세요!");

            while (true)
            {
                WriteLine();
                Write("숫자 입력(1~100) : ");
                string strInput = ReadLine();

                numTry++;

                //enter, null, whitespace(s)가 입력될 경우 0으로 간주
                int numInput = string.IsNullOrWhiteSpace(strInput) ? 0 : int.Parse(strInput);
                if (numAnswer == numInput)
                {
                    WriteLine();
                    WriteLine("정답입니다! " + numTry + "회 만에 맞췄어요!");

                    WriteLine();
                    Write("다시 하시겠습니까?(y/n) : ");
                    string strRestart = ReadLine();
                    if (strRestart == "y")
                    {
                        numAnswer = rnd.Next(1, 101);
                        numTry = 0;
                        continue;
                    }
                    else if (strRestart == "n")
                    {
                        WriteLine();
                        WriteLine("게임이 종료되었습니다!");
                        break;
                    }
                    break;
                }

                string strUpDown = numAnswer > numInput ? "UP" : "DOWN";
                WriteLine(strUpDown);
            }
        }
    }
}
