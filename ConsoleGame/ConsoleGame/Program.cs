using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Program
    {

        class Start
        {
            public static int x;
            public static int y;
            public static void Init()
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                #####    ###   ###     #     ####     #####     ");
                Console.WriteLine("                #       #     #       # #    #   #    #         ");
                Console.WriteLine("                ####    ####  #      #####   ####     ####      ");
                Console.WriteLine("                #           # #      #   #   #        #         ");
                Console.WriteLine("                #####   ####   ###   #   #   #        #####     ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            public static int MenuDraw()
            {

                x = 30;
                y = 15;

                Console.SetCursorPosition(x, y);
                Console.WriteLine(">  Start");
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("   information");
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("   exit  ");

                while (true)
                {
                    ConsoleKeyInfo info = Console.ReadKey();
                    switch (info.Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (y > 15)
                            {
                                Console.SetCursorPosition(x, y);
                                Console.Write(" ");
                                Console.SetCursorPosition(x, --y);
                                Console.Write(">");
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            if (y < 17)
                            {
                                Console.SetCursorPosition(x, y);
                                Console.Write(" ");
                                Console.SetCursorPosition(x, ++y);
                                Console.Write(">");
                            }
                            break;
                        case ConsoleKey.Enter:
                            return y - 15;
                    }
                }
            }

            public static void InfoDraw()
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                                [ 조작법 ]                     ");
                Console.WriteLine();
                Console.WriteLine("                              이 동 : 방향키                    ");
                Console.WriteLine();
                Console.WriteLine("                           선택 :    엔    터                   ");
                Console.WriteLine();
                Console.WriteLine("                   엔터를 누르면 메인화면으로 이동합니다.          ");

                while (true)
                {
                    ConsoleKeyInfo info = Console.ReadKey();
                    if (info.Key == ConsoleKey.Enter)
                        break;
                }
            }
            public static int MapListDarw()
            {
                x = 31;
                y = 12;

                Console.Clear();
                Console.SetCursorPosition(30, 8);
                Console.Write(" [ 맵 선택 ] ");
                Console.SetCursorPosition(x, y);
                Console.WriteLine(">  쉬움");
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("   어려움");
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("   뒤로");

                while (true)
                {
                    ConsoleKeyInfo info = Console.ReadKey();
                    switch (info.Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (y > 12)
                            {
                                Console.SetCursorPosition(x, y);
                                Console.Write(" ");
                                Console.SetCursorPosition(x, --y);
                                Console.Write(">");
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            if (y < 14)
                            {
                                Console.SetCursorPosition(x, y);
                                Console.Write(" ");
                                Console.SetCursorPosition(x, ++y);
                                Console.Write(">");
                            }
                            break;
                        case ConsoleKey.Enter:
                            return y - 12;
                    }
                }
            }
        }




        class Map
        {
            static int x;
            static int y;
            static int w;
            static int h;
            static string[,] tempMap = new string[35, 75];
            static string[,] map1 = new string[35, 75];
            static string[,] map2 = new string[35, 75];
            static bool isPlaying = true;
            static void DrawMap(int mapcode)
            {
                Console.Clear();
                Console.CursorVisible = false;

                if (mapcode == 0) //맵1 작성
                {
                    for (h = 0; h < 35; h++)
                    {
                        for (w = 0; w < 75; w++)
                        {
                            if (h == 0 || h == 34) map1[h, w] = "1";
                            else if (h > 3 && w == 6) map1[h, w] = "1";
                            else if (h == 3 && w > 5 && w < 69) map1[h, w] = "1";
                            else if (w == 68 && h > 3 && h < 32) map1[h, w] = "1";
                            else if ((w > 36 && w < 58) && h == 31) map1[h, w] = "1";
                            else if (w == 37 && (h < 32 && h > 20)) map1[h, w] = "1";
                            else if (h == 21 && (w < 37 && w > 10)) map1[h, w] = "1";
                            else if (w == 11 && (h < 21 && h > 8)) map1[h, w] = "1";
                            else if (w == 47 && (h < 30 && h > 25)) map1[h, w] = "1";
                            else if (h == 26 && (w < 68 && w > 47)) map1[h, w] = "1";
                            else if (h == 9 && (w < 30 && w > 11)) map1[h, w] = "1";
                            else if (w == 35 && (h < 12 && h > 5)) map1[h, w] = "1";
                            else if (h == 5 && (w < 62 && w > 34)) map1[h, w] = "1";
                            else if (h == 11 && (w < 36 && w > 17)) map1[h, w] = "1";
                            else if (w == 18 && (h < 20 && h > 11)) map1[h, w] = "1";
                            else if (h == 19 && (w < 50 && w > 18)) map1[h, w] = "1";
                            else if (w == 49 && (h < 26 && h > 11)) map1[h, w] = "1";
                            else if (w == 61 && (h < 23 && h > 5)) map1[h, w] = "1";
                            else if (h == 22 && (w < 61 && w > 53)) map1[h, w] = "1";
                            else
                            {
                                if (w == 0 || w == 74) map1[h, w] = "1";
                                else if (h == 32 && w == 2) map1[h, w] = "s";
                                else if (h == 17 && w == 37) map1[h, w] = "q";
                                else map1[h, w] = "0";
                            }
                        }
                    }
                    MemCpy(tempMap, map1);
                }

                else //맵2 작성
                {
                    for (h = 0; h < 35; h++)
                    {
                        for (w = 0; w < 75; w++)
                        {
                            if (h == 0 || h == 34) map2[h, w] = "1";
                            else if (w == 32 && h == 35) map2[h, w] = "1";
                            else if (w == 4 && (h < 34 && h > 5)) map2[h, w] = "1";
                            else if (h == 3 && (w < 71 && w > 3)) map2[h, w] = "1";
                            else if (w == 70 && (h < 32 && h > 3)) map2[h, w] = "1";
                            else if (w == 67 && (h < 34 && h > 28)) map2[h, w] = "1";
                            else if (h == 27 && (w < 70 && w > 63)) map2[h, w] = "1";
                            else if (w == 64 && (h < 32 && h > 27)) map2[h, w] = "1";
                            else if (w == 61 && (h < 34 && h > 24)) map2[h, w] = "1";
                            else if (h == 25 && (w < 68 && w > 61)) map2[h, w] = "1";
                            else if (w == 7 && (h < 32 && h > 3)) map2[h, w] = "1";
                            else if (w == 10 && (h < 34 && h > 5)) map2[h, w] = "1";
                            else if (w == 13 && (h < 8 && h > 3)) map2[h, w] = "1";
                            else if (h == 9 && (w < 16 && w > 12)) map2[h, w] = "1";
                            else if (w == 16 && (h < 10 && h > 4)) map2[h, w] = "1";
                            else if (h == 5 && (w < 68 && w > 16)) map2[h, w] = "1";
                            else if (w == 67 && (h < 23 && h > 4)) map2[h, w] = "1";
                            else if (h == 22 && (w < 70 && w > 67)) map2[h, w] = "1";
                            else if (h == 11 && (w < 21 && w > 10)) map2[h, w] = "1";
                            else if (w == 20 && (h < 16 && h > 6)) map2[h, w] = "1";
                            else if (h == 22 && (w < 67 && w > 57)) map2[h, w] = "1";
                            else if (w == 58 && (h < 33 && h > 22)) map2[h, w] = "1";
                            else if (h == 32 && (w < 58 && w > 13)) map2[h, w] = "1";
                            else if (w == 14 && (h < 32 && h > 26)) map2[h, w] = "1";
                            else if (h == 25 && (w < 17 && w > 10)) map2[h, w] = "1";
                            else if (w == 17 && (h < 31 && h > 24)) map2[h, w] = "1";
                            else if (w == 20 && (h < 32 && h > 22)) map2[h, w] = "1";
                            else if (h == 21 && (w < 23 && w > 12)) map2[h, w] = "1";
                            else if (w == 17 && (h < 24 && h > 21)) map2[h, w] = "1";
                            else if (w == 23 && (h < 31 && h > 18)) map2[h, w] = "1";
                            else if (w == 47 && (h < 9 && h > 5)) map2[h, w] = "1";
                            else if (h == 10 && (w < 57 && w > 22)) map2[h, w] = "1";
                            else if (h == 7 && (w < 45 && w > 20)) map2[h, w] = "1";
                            else if (w == 23 && (h < 18 && h > 10)) map2[h, w] = "1";
                            else if (h == 17 && (w < 23 && w > 16)) map2[h, w] = "1";
                            else if (w == 17 && (h < 18 && h > 11)) map2[h, w] = "1";
                            else if (w == 50 && (h < 10 && h > 6)) map2[h, w] = "1";
                            else if (h == 8 && (w < 65 && w > 52)) map2[h, w] = "1";
                            else if (w == 59 && (h < 21 && h > 8)) map2[h, w] = "1";
                            else if (h == 15 && (w < 67 && w > 61)) map2[h, w] = "1";
                            else if (w == 62 && (h < 14 && h > 8)) map2[h, w] = "1";
                            else if (h == 15 && (w < 15 && w > 10)) map2[h, w] = "1";
                            else if (h == 12 && (w < 52 && w > 25)) map2[h, w] = "1";
                            else if (w == 13 && (h < 20 && h > 15)) map2[h, w] = "1";
                            else if (w == 64 && (h < 21 && h > 15)) map2[h, w] = "1";
                            else if (h == 29 && (w < 38 && w > 23)) map2[h, w] = "1";
                            else if (w == 39 && (h < 32 && h > 26)) map2[h, w] = "1";
                            else if (h == 27 && (w < 40 && w > 25)) map2[h, w] = "1";
                            else if (w == 26 && (h < 27 && h > 16)) map2[h, w] = "1";
                            else if (w == 29 && (h < 20 && h > 12)) map2[h, w] = "1";
                            else if (h == 21 && (w < 33 && w > 26)) map2[h, w] = "1";
                            else if (w == 32 && (h < 22 && h > 12)) map2[h, w] = "1";
                            else if (w == 54 && (h < 18 && h > 10)) map2[h, w] = "1";
                            else if (h == 19 && (w < 59 && w > 51)) map2[h, w] = "1";
                            else if (w == 51 && (h < 20 && h > 13)) map2[h, w] = "1";
                            else if (h == 14 && (w < 51 && w > 34)) map2[h, w] = "1";
                            else if (w == 35 && (h < 25 && h > 14)) map2[h, w] = "1";
                            else if (h == 24 && (w < 36 && w > 28)) map2[h, w] = "1";
                            else if (w == 41 && (h < 26 && h > 15)) map2[h, w] = "1";
                            else if (h == 19 && (w < 41 && w > 35)) map2[h, w] = "1";
                            else if (w == 44 && (h < 32 && h > 19)) map2[h, w] = "1";
                            else if (h == 18 && (w < 47 && w > 41)) map2[h, w] = "1";
                            else if (w == 47 && (h < 32 && h > 17)) map2[h, w] = "1";
                            else if (w == 45 && (h < 17 && h > 14)) map2[h, w] = "1";
                            else if (h == 29 && (w < 58 && w > 49)) map2[h, w] = "1";
                            else if (w == 53 && (h < 28 && h > 19)) map2[h, w] = "1";


                            else
                            {
                                if (w == 0 || w == 74) map2[h, w] = "1";
                                else if (h == 32 && w == 2) map2[h, w] = "s";
                                else if (h == 17 && w == 37) map2[h, w] = "q";
                                else map2[h, w] = "0";
                            }
                        }
                    }
                    MemCpy(tempMap, map2);
                }

                //벽, 플레이어, 탈출구 색 지정
                for (h = 0; h < 35; h++)
                {
                    for (w = 0; w < 75; w++)
                    {
                        if (tempMap[h, w] == "1")
                        {
                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("#");
                        }
                        else if (tempMap[h, w] == "s")
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("@");
                            x = GetstartX(w);
                            y = GetStartY(h); //배열에서 시작 위치 가져오기
                        }
                        else if (tempMap[h, w] == "q")
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("O");
                        }

                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();

                }
                //Thread.Sleep(3000);

            }

            public static void MapLoop(int mapcode)
            {
                DrawMap(mapcode);

                while (isPlaying)
                {
                    DrawUI(x, y);
                    ConsoleKeyInfo info = Console.ReadKey();
                    switch (info.Key)
                    {
                        case ConsoleKey.UpArrow:
                            Move(0, -1, isPlaying);
                            break;
                        case ConsoleKey.DownArrow:
                            Move(0, 1, isPlaying);
                            break;
                        case ConsoleKey.LeftArrow:
                            Move(-1, 0, isPlaying);
                            break;
                        case ConsoleKey.RightArrow:
                            Move(1, 0, isPlaying);
                            break;
                            /*case ConsoleKey.Escape:
                                isPlaying = false;
                                break; */
                    }

                }

                Console.Clear();
                Console.SetCursorPosition(32, 8);
                Console.WriteLine("Game Clear!");
                Thread.Sleep(2000);

            }

            static void Move(int mx, int my, bool play)
            {
                string mCode;
                mCode = tempMap[y + my, x + mx];

                if (mCode == "0")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(x + mx, y + my);
                    Console.Write("@");

                    x += mx;
                    y += my;
                }
                else if (mCode == "q") //탈출구에 도착하면 루프 종료
                    isPlaying = false;
            }

            static void DrawUI(int uix, int uiy)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(2, 35);
                Console.WriteLine("위치 : {0}, {1}", uix, uiy);

            }
            static int GetstartX(int sx)
            {
                return sx;
            }

            static int GetStartY(int sy)
            {
                return sy;
            }

            static void MemCpy(string[,] tempMap, string[,] map)
            {
                for (h = 0; h < 35; h++)
                {
                    for (w = 0; w < 75; w++)
                    {
                        tempMap[h, w] = map[h, w];
                    }
                }
            }
        }




        static void Main(string[] args)
        {
            Console.SetWindowSize(75, 37);
            Console.CursorVisible = false;


            bool state = true;

            while (state)
            {
                Start.Init();
                int menuCode = Start.MenuDraw();
                if (menuCode == 0)
                {
                    int mapCode = Start.MapListDarw();
                    if (mapCode == 0)
                    {
                        Map.MapLoop(0);
                    }
                    else if (mapCode == 1)
                    {
                        Map.MapLoop(1);
                    }
                }
                else if (menuCode == 1)
                {
                    Start.InfoDraw();
                }
                else if (menuCode == 2)
                {
                    state = false;
                }
                Console.Clear();
            }


            /*Map map = new Map();
            Thread MapThread = new Thread(new ThreadStart(map.DrawMap));
            MapThread.Start(); */

        }
    }
}
