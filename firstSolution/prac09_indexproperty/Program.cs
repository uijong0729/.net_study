using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac09_indexproperty
{
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            c.Name = "hello";   //속성 지정으로 멤버변수가 name이지만 접근은 Name으로 열려있다.
            c.Number = 9;       //속성 지정으로 멤버변수가 number이지만 접근은 Number로 열려있다.

            Console.WriteLine("{0}, {1}", c.Name, c.Number);


            
            B b = new B();

            //객체를 배열로 선언하지 않았음에도 배열로서 사용할 수 있는것은 인덱서가 있기 떄문이다.
            for (int i = 0; i < 5; i++)
            {
                b[i] = i;
                Console.WriteLine(b[i]);
            }


            A a = new A();
            a[0] = "a";
            a[1] = "b";
            a[2] = "c";

            a.Print();


        }
    }
}
