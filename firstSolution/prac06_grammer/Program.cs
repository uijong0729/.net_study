using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac06_grammer
{
    class Program
    {
        static void Main(string[] args)
        {
            // ! 연산자 (not 연산자)
            Console.WriteLine("{0}", !true);

            // is 연산자
            int value = 10;
            object obj = value;

            if(value is float)
                Console.WriteLine("호환 됨");
            else
                Console.WriteLine("호환 안됨");

            if (value is object)
                Console.WriteLine("호환 됨");
            else
                Console.WriteLine("호환 안됨");

            if (obj is int)
                Console.WriteLine("호환 됨");
            else
                Console.WriteLine("호환 안됨");

            if(value is int)
                Console.WriteLine("호환 됨");
            else
                Console.WriteLine("호환 안됨");


            //as연산자
            string str = "123";
            object ob = str;
            string str2 = ob as string;

            if (str2 != null)
                Console.WriteLine(str2);
            else
                Console.WriteLine("형변환 실패");


            // ??연산자
            int? x = null;      //nullable 변수선언
            int y = x ?? -1;    //x가 null이 아니면 x를 대입하고 null이면 -1을 대입
            Console.WriteLine(y);
        }
    }
}
