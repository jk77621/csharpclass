using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            bool flag = true;
            int numX = 2;
            int numY = 2;
            int numMinY = 2;
            int numMaxY = 4;

            CursorVisible = false;

            WriteLine("게임을 선택해주세요.");

            SetCursorPosition(numX + 3, numMinY);
            Write("숫자 맞추기 게임");

            SetCursorPosition(numX + 3, numMinY + 1);
            Write("가위바위보 게임");

            SetCursorPosition(numX + 3, numMinY + 2);
            Write("숫자 경주 게임");

            SetCursorPosition(numX, numY);

            Write("▶");

            while (flag)
            {
                key = ReadKey(false);

                Clear();

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (numY > numMinY) numY--;

                        WriteLine("게임을 선택해주세요.");

                        SetCursorPosition(numX + 3, numMinY);
                        Write("숫자 맞추기 게임");

                        SetCursorPosition(numX + 3, numMinY + 1);
                        Write("가위바위보 게임");

                        SetCursorPosition(numX + 3, numMinY + 2);
                        Write("숫자 경주 게임");

                        SetCursorPosition(numX, numY);

                        Write("▶");
                        break;
                    case ConsoleKey.DownArrow:
                        if (numY < numMaxY) numY++;

                        WriteLine("게임을 선택해주세요.");

                        SetCursorPosition(numX + 3, numMinY);
                        Write("숫자 맞추기 게임");

                        SetCursorPosition(numX + 3, numMinY + 1);
                        Write("가위바위보 게임");

                        SetCursorPosition(numX + 3, numMinY + 2);
                        Write("숫자 경주 게임");

                        SetCursorPosition(numX, numY);

                        Write("▶");
                        break;
                    case ConsoleKey.Enter:
                        switch (numY) {
                            case 2:
                                NumberMatch numberMatch = new NumberMatch();
                                numberMatch.run();
                                break;
                            case 3:
                                RockPaperScissors rockPaperScissors = new RockPaperScissors();
                                rockPaperScissors.run();
                                break;
                            case 4:
                                NumberRacing numberRacing = new NumberRacing();
                                numberRacing.run();
                                break;
                        }

                        flag = false;
                        break;
                }
            }

            ReadKey();
        }
    }
}
