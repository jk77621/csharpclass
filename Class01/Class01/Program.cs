using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class01
{
    class Program
    {
        static void Main(string[] args)
        {
            char testChar = 'd';
            int testInt = 3;
            long testLong = 3;
            float testFloat = 3;
            string testString = "hello world";
            double testDouble = 3;
            float testFloat2 = 3.3f;
            double testDouble2 = 3.3d;

            System.Console.WriteLine(testChar);
            System.Console.WriteLine(testInt);
            System.Console.WriteLine(testLong);
            System.Console.WriteLine(testFloat);
            System.Console.WriteLine(testString);
            System.Console.WriteLine(testDouble);
            System.Console.WriteLine(testFloat2);
            System.Console.WriteLine(testDouble2);
            System.Console.WriteLine("Hello Indigo Montoya");

            (string First, string Second, string Third) namedFruits = ("apple", "orange", "banana");

            namedFruits.First = "Eat";

            System.Console.WriteLine(namedFruits);

            int[] arr1 = new int[3];
            int[] arr2 = { 1, 2, 3 };
            arr2 = new int[3];
            arr2 = new int[] { 1, 2, 2 };
            int[,] arr3 = { { 1, 2 }, { 2, 3 }, { 4, 5 } };

            System.Console.WriteLine(arr1[0]);
            System.Console.WriteLine(arr1[1]);
            System.Console.WriteLine(arr1[2]);

            System.Console.WriteLine(arr2[0]);
            System.Console.WriteLine(arr2[1]);
            System.Console.WriteLine(arr2[2]);

            System.Console.WriteLine(arr3[0, 0]);
            System.Console.WriteLine(arr3[1, 0]);
            System.Console.WriteLine(arr3[2, 0]);

            System.Console.ReadKey();
        }
    }
}

/*
 * String
 * .compare 비교
 * .format 초기화
 * .concat 합치기
 * .toLower 소문자로
 * .toUpper 대문자로
 * .trim 양쪽에서 자른다
 * .replace 교체
 */

/*
 * null
 * int? age -> 변수가 null을 가질 수 있도록 지정함. (null 허용 한정자)
 * age = null;
 */

/*
 * 형변환 (long -> int)
 * long number1 = 132312425;
 * int number2 = (int) number1;
 */

/*
 * 오버플로우
 * 값이 넘어가는 경우, checked로 예외처리함
 */

/*
 * Array
 * sort - 정렬하기
 * BinarySearch - 검색 (이진탐색)
 * reverse - 뒤집기
 * clear - 지우기
 */
