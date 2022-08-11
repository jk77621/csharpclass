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
            int nX = 2;
            int nY = 2;
            int nMinY = 2;
            int nMaxY = 4;

            CursorVisible = false;

            WriteLine("게임을 선택해주세요.");

            SetCursorPosition(nX + 3, 2);
            Write("숫자 맞추기 게임");

            SetCursorPosition(nX + 3, 3);
            Write("가위바위보 게임");

            SetCursorPosition(nX + 3, 4);
            Write("숫자 경주 게임");

            SetCursorPosition(nX, nY);

            Write("▶");

            while (flag)
            {
                key = ReadKey(false);

                Clear();

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (nY > nMinY) nY--;

                        WriteLine("게임을 선택해주세요.");

                        SetCursorPosition(nX + 3, 2);
                        Write("숫자 맞추기 게임");

                        SetCursorPosition(nX + 3, 3);
                        Write("가위바위보 게임");

                        SetCursorPosition(nX + 3, 4);
                        Write("숫자 경주 게임");

                        SetCursorPosition(nX, nY);

                        Write("▶");
                        break;
                    case ConsoleKey.DownArrow:
                        if (nY < nMaxY) nY++;

                        WriteLine("게임을 선택해주세요.");

                        SetCursorPosition(nX + 3, 2);
                        Write("숫자 맞추기 게임");

                        SetCursorPosition(nX + 3, 3);
                        Write("가위바위보 게임");

                        SetCursorPosition(nX + 3, 4);
                        Write("숫자 경주 게임");

                        SetCursorPosition(nX, nY);

                        Write("▶");
                        break;
                    case ConsoleKey.Enter:
                        switch (nY) {
                            case 2:
                                NumberMatch numberMatch = new NumberMatch();
                                numberMatch.start();
                                break;
                            case 3:
                                RockPaperScissors rockPaperScissors = new RockPaperScissors();
                                rockPaperScissors.start();
                                break;
                            case 4:
                                NumberRacing numberRacing = new NumberRacing();
                                numberRacing.start();
                                break;
                        }

                        flag = false;
                        break;
                }

                ReadKey();
            }
        }
    }
}
