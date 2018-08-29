/*
    using
    클래스의 네임스페이스를 선언하는 역할
    네임스페이스의 명시 없이 클래스를 사용 할 수 있게한다.

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//코드는 크게 using부분과 namespace 부분으로 나뉜다.
namespace prac01
{
    class Program
    {
        //적어도 하나 이상의 클래스 안에 main이 포함되어야 한다.
        //static : 객체의 생성 없이도 실행/호출 가능하다.
        static void Main(string[] args)
        {
            //main함수는 static 키워드가 반드시 필요하다.
            Console.Write("테스트\n");
            Console.WriteLine("테스트2");

            //출력형식을 지정하여 출력할 수 있다.
            Console.WriteLine("{0} + {1} = {2}", 1, 2, 1 + 2);

            //%단위로 0.45를 출력, 통화 단위로 4433 출력, 4433을 16진수로 2번 출력
            Console.WriteLine("{0:P} {1:C} {1:X} {1:X}", 0.45, 4433);
        }
    }
}
