using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Class03
{
    class Program
    {
        public static int count = 0;
        public static event Action myOwnAction;

        static void Main(string[] args)
        {
            /*
            WriteLine("hello world");
            WriteLine();
            WriteLine();

            int number = 3;
            string word = "Hi";

            WriteLine("1. " + number +  word);
            WriteLine("2. " + $"{number}{word}");
            WriteLine("3. {0}{1}", number, word);
            ReadKey();
            */

            /*
            MakeStar();
            ReadKey();
            */

            /*
            int floor = 0;
            int from = 0;
            int via = 1;
            int to = 2;
            string number = "";

            Write("Input floor : ");
            number = ReadLine();
            floor = int.Parse(number);

            HanoiTower(floor, from, via, to);

            WriteLine(floor + " = " + count);
            ReadKey();
            */

            /*
            string word1 = "";
            string word2 = "";
            string word3 = "";
            int number1 = 0;
            int randomNumber = 0;
            float totalTime = 0;

            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            while (stopwatch.IsRunning)
            {
                Write("입력숫자 : ");
                word1 = ReadLine();
                number1 = int.Parse(word1);

                Random random = new Random();
                randomNumber = random.Next(0, 100);

                WriteLine("랜덤숫자 : " + randomNumber);

                Write("배수인가?(y/n) : ");
                word3 = ReadLine();

                if ((randomNumber % number1 == 0 && word3 == "y") || (randomNumber % number1 != 0 && word3 == "n"))
                {
                    stopwatch.Stop();

                    WriteLine();
                    WriteLine("정답입니다.");

                    totalTime = stopwatch.ElapsedMilliseconds / 1000;
                    WriteLine(totalTime + "초");
                }
                else
                {
                    WriteLine();
                    WriteLine("오답입니다.");
                }

                WriteLine();
                Write("다시 하시겠습니까?(y/n) : ");
                word2 = ReadLine();

                if (word2 == "y")
                {
                    WriteLine();
                    stopwatch.Start();
                    // continue;
                }
                else
                {
                    break;
                }
            }

            WriteLine("finish");

            ReadKey();
            */


            while (true)
            {
                string s1 = ReadLine();

                switch (s1)
                {
                    case "1":
                        myOwnAction += One;
                        break;

                    case "2":
                        myOwnAction += Two;
                        break;
                    case "3":
                        myOwnAction += Three;
                        break;
                    case "4":
                        myOwnAction?.Invoke();
                        break;
                    default:
                        break;
                }

                if (s1 == "n")
                {
                    break;
                }
            }
        }

        static void MakeStar()
        {
            // 별을 만든다.
            int k = 5;

            for (int i = 0; i < 10; ++i)
            {
                // 첫번째줄 별을 감소한다.
                for (int j = 0; j < k - i; ++j)
                {
                    Write("*");
                }

                // 두번째줄 공백을 증가한다.
                for (int j = 0; j < i * 2; ++j)
                {
                    Write(" ");
                }

                // 세번째줄 별을 감소한다.
                for (int j = 0; j < k - i; ++j)
                {
                    Write("*");
                }

                WriteLine();
            }
        }

        static void HanoiTower(int floor, int from, int via, int to)
        {
            /*
            if (floor == 0)
            {
                WriteLine("aaa");
                WriteLine(from + " -> " + to);
                return;
            }
            else
            {
                HanoiTower(floor - 1, from, to, via);
                WriteLine(from + " -> " + to);
                HanoiTower(floor - 1, via, from, to);
            }
            */

            if (floor == 0) return;

            count++;

            HanoiTower(floor - 1, from, to, via);
            // WriteLine(floor + "    " + from + " -> " + to);
            HanoiTower(floor - 1, via, from, to);
        }


        static void One()
        {
            WriteLine("Hi world");
        }

        static void Two()
        {
            WriteLine("Hello world");
        }

        static void Three()
        {
            WriteLine("안녕");
        }
    }
}

/* 생성자
 * 가비지 콜렉터가 없기 때문에 생성자 사용x, 소멸자 사용x
 */

/* 제네릭
 * 제네릭 사용 방식은 T이 이다.
 * 어떤 요소라도 다 받아드릴수 있다.
 * 
 * Stack이란 Last in First out
 * 알 필요없음
 * 
 * Stack<T> where T : class
 * 
 * 같은 방식으로 T를 Class로만 받아들이는 제약조건이 존재함.
 * 
 * Stack을 예로 제네릭 만들고 사용해보기 (똑같이 만들기) 이후 스킵
 */

/* 대리자와 람다
 * 대리자 : 일을 대신 해준다., 메소드를 참조하고 있는 역역.
 * delegate type name();
 * 델리게이트는 멀티참조가 가능하다.
 */

/* 액션 -> 굉장히 많이 씀
 * 명예, 조건, 업적
 * 
 * 예)
 * public class ClassA
 * {
 *  public event Action<string> onAdd;
 *  
 *  private void SomethingHappened()
 *  {
 *      onAdd?.Invoke( "It happened");
 *  }
 * }
 * 
 * 
 * public class ClassB
 * {
 *  public ClassB()
 *  {
 *      var myClass = new ClassA();
 *      myClass.OnAdd += Add;
 *      myClass.OnAdd += Add;
 *      myClass.OnAdd += Add;
 *      myClass.OnAdd += Add;
 *  }
 *  
 *  private void Add(string Input)
 *  {
 *      //do someThing
 *  }
 * }
 */