using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac05_enum
{
    //열거형 변수를 정수형 변수에 대입하여 출력해보자.
    enum Days : int {sun = 1, mon, tue, wed, thu, fri, sat };
    enum Days2 { sun = 1, mon, tue, wed, thu, fri, sat };


    class Program
    {
        static void Main(string[] args)
        {
            //enum은 기본적으로 int형을 전제로 하지만
            //일반 변수에 저장하기 위해선 데이터 타입을 명시해야한다.
            int nValue = (int)Days.mon;

            //그대로 대입하는 경우
            Days day = Days.tue;

            Console.WriteLine("{0} {1}", nValue, day);
           
        }
    }
}
