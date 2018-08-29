using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac02_dataType
{
    class Program
    {
        static bool BoolVar;

        static void Main(string[] args)
        {
            //클래스의 정적변수 bool형의 기본 값과 지역 bool 변수 값을 출력해보자
            bool LocalBoolVar = true;
            Console.WriteLine("{0} {1}", BoolVar, LocalBoolVar);


            //문자상수 7을 int형으로 변환하고 1을 더한 결과를 출력해보자
            char seven = '7';
            int testChar = seven;
            Console.WriteLine('7'); // '7'
            Console.WriteLine(testChar);    //55
            Console.WriteLine('7' + 1);     //56
            Console.WriteLine("문자 상수 : {0}, 유니코드 : {1}", seven, testChar);
            char rewrite = (char) (testChar + 1);
            Console.WriteLine(rewrite); // 8


            //byte형 두 값을 더하고 그 값을 int형 변수에 대입하여 출력해보자
            int result = 0;
            byte x = 1, y = 2;  //선언과 동시에 초기화가 가능하고, 나열하여 한꺼번에 선언 할 수 있다.
            result = x + y;
            Console.WriteLine("바이트 합 : " + result); //3



            //short형의 유효범위 값을 출력해보자
            short min = short.MinValue;
            short max = short.MaxValue;
            Console.WriteLine("minValue : {0}, maxValue : {1}", min, max);


            //두 문자열을 합친 후에 합친 문자열과 4번째 문자를 출력해 보자
            string fristText = "I am a";
            string secondText = " boy";
            string plusText = fristText + secondText;
            string four = plusText.Substring(3, 1); //0부터 갯수를 세니까 3번 인덱스가 4번째 문자이다.
            
            Console.WriteLine("합친 문자열 : {0}, 4번째 문자 : {1}, 4번째 문자 다른 방식: {2}", plusText, four, plusText[3]);
            Console.WriteLine(plusText[3]); // m

            //문자열의 문자 개수를 Length로 확인해보자
            Console.WriteLine("문자 갯수 : " + plusText.Length);

            //문자열 비교
            if(plusText == "I am a boy")
            {
                Console.WriteLine("같음");
            }
            else
            {
                Console.WriteLine("다름");
            }



            //백스페이스가 있는 문자열을 출력해보자
            string str1 = "C:\\temp\\test.txt";
            string str2 = @"C:\temp\test.txt";
            Console.WriteLine("{0}, {1}", str1, str2);



            //var형 변수에 데이터가 분명한 값으로 선언과 초기화를 한 후에 두 값을 더한 결과를 출력해 보자
            var value1 = 3.14f;
            float value2 = 10.12f;
            float sum = value1 + value2;

            // {1:f1} : 1번 인덱스의 요소를 소수점 1번째까지 표시
            Console.WriteLine("{0} {1:f1} {2}", value1, value2, sum);


            //nullable형을 선언하고 판독해보자
            int? nullable = null;

            if(nullable.HasValue)
            {
                Console.WriteLine("올바른 값");
            }
            else
            {
                Console.WriteLine("Null 값");
            }
        }
    }
}
