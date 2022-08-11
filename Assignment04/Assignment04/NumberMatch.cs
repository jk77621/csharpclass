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
            Random rand = new Random();
            this.Answer = rand.Next(1, 101);
        }

        private int Answer { get; }

        public void start()
        {
            WriteLine("컴퓨터가 1~100 중 랜덤 숫자 하나를 정합니다.");
            WriteLine("이 숫자를 맞춰주세요.");

            int numTry = 0;
            while (true)
            {
                WriteLine();
                Write("숫자 입력(1~100): ");
                string numInput = ReadLine();

                numTry++;

                // enter, null, whitespace(s)가 입력될 경우 0으로 간주
                int numGuess = string.IsNullOrWhiteSpace(numInput) ? 0 : int.Parse(numInput);
                if (this.Answer == numGuess)
                {
                    WriteLine();
                    WriteLine("정답입니다! " + numTry + "회 만에 맞췄어요!");
                    break;
                }

                string strUpDown = this.Answer > numGuess ? "UP" : "DOWN";
                WriteLine(strUpDown);
            }
        }
    }
}
