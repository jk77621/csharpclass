using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Class05
{
    class Program
    {
        //타이머 쓰기 위한 변수들
        //==============================
        static IntPtr ConsoleWindowHnd = GetForegroundWindow();
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("User32.Dll")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);
        const int VK_RETURN = 0x0D;
        const int WM_KEYDOWN = 0x100;
        //==============================

        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            int re;

            /* ref
            Swap(ref a, ref b);

            WriteLine(a);
            WriteLine(b);

            ReadKey();

            void Swap(ref int n1, ref int n2)
            {
                int temp;
                temp = n1;
                n1 = n2;
                n2 = temp;
            }
            */

            /*
            Add(a, b, out re);

            WriteLine(a);
            WriteLine(b);
            WriteLine(re);

            ReadKey();
            */

            /*
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int answer = 0;

            answer = solution(arr);

            WriteLine(answer);

            ReadKey();
            */

            /* Timer
            //타이머 시작
            theThreadTimer();

            // (진행 하게 될 게임 내용)
            //==============================
            var key = Console.ReadLine();

            //==============================
            WriteLine("is done");       //<- 타이머 종료시 ReadLine() 종료됨.

            ReadKey();
            */


        }

        static void Swap(ref int n1, ref int n2)
        {
            int temp;
            temp = n1;
            n1 = n2;
            n2 = temp;
        }

        static void Add(int n1, int n2, out int result)
        {
            result = n1 + n2;
        }

        static int solution(int[] nums)
        {
            int answer = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (isPrime(nums[i] + nums[j] + nums[k]))
                        {
                            answer++;
                        }
                    }
                }
            }

            return answer;
        }
        static bool isPrime(int n)
        {
            int nr = (int)Math.Sqrt(n);
            for (int i = 2; i <= nr; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        static async Task theThreadTimer()
        {
            int theTime = 0;            // 현재 타이머 시간
            int timeLimit = 5;          // 타이머 종료 시간(해당 시간이 되면 꺼짐. 3 -> 3초)
            while (theTime < timeLimit)
            {
                await Task.Delay(1000); //1초의 딜레이 (1초가 지났다는 뜻)
                theTime++;
                WriteLine();
                Write(theTime.ToString());
                WriteLine();

            }

            //해당 메세지를 보내면 ReadLine 강제 종료
            //===================================================
            PostMessage(ConsoleWindowHnd, WM_KEYDOWN, VK_RETURN, 0);
            //===================================================
        }
    }
}

/*
 * 
 * 
 * 
 */
