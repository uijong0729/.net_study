using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac05_dataType2
{
    public struct MyStruct
    {
        public const float PI = 3.14f;
        public static int Age = 12;

    }

    public struct MyStruct2
    {
        //const와 static변수를 제외하고는 구조체 안에서 초기화를 할 수 없다.
        public int age;

        //구조체 안에 선언할 수 있는 생성자는 매개변수가 반드시 있어야 한다. (생성자를 이용하면 생성과 동시에 초기화를 할 수 있다)
        public MyStruct2(int a)
        {
            age = a;
        }
    }

    public struct MyStruct3 {
        public int age;
    }


    class Program
    {
        static void Main(string[] args)
        {
            //static과 const의 경우 생성없이 바로 사용할 수 있다.
            Console.WriteLine("{0} {1}", MyStruct.PI, MyStruct.Age);

            MyStruct2 testStruct;
            testStruct.age = 12;
            Console.WriteLine(testStruct.age);

            MyStruct2 test2 = new MyStruct2(12);    //구조체의 생성자를 이용하여 선언과 동시에 초기화
            Console.WriteLine(test2.age);

            MyStruct2 test3 = new MyStruct2();  //구조체의 기본생성자를 만들지 않았음에도 생성가능
            Console.WriteLine(test3.age); //new를 통해서 사용하면 0으로 자동 초기화가 된다.
           
            MyStruct3 testruct1, testruct2;
            testruct1.age = 10;
            testruct2 = testruct1;  //구조체를 같은 구조체에 대입하게되면 값이 복사된다.
            Console.WriteLine("{0}", testruct2.age);

        }
    }
}
