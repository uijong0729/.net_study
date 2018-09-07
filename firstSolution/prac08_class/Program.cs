using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac08_class
{
    class MyClass
    {

        public int number;
        public MyClass (int number)
        {
            this.number = number;
        }

        public MyClass() {
            Console.WriteLine("생성자 호출");
        }


        //소멸자
        ~MyClass() {
            Console.WriteLine("소멸자 호출");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();

        }
    }
}
