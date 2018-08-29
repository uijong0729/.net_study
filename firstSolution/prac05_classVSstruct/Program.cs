using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac05_classVSstruct
{
    //구조체
    public struct MyStruct {
        public int age;
    }

    //클래스
    public class MyClass {
        public int age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //구조체
            MyStruct tests1 = new MyStruct();
            tests1.age = 12;

            MyStruct tests2 = tests1;
            tests2.age = 24;

            Console.WriteLine("{0}, {1}", tests1.age, tests2.age);



            //클래스
            MyClass testc = new MyClass();
            testc.age = 12;

            MyClass testc2 = testc;
            testc2.age = 24;

            Console.WriteLine("{0}, {1}", testc.age, testc2.age);
        }
    }
}
