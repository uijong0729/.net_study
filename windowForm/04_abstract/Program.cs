using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_abstract
{
    //추상클래스
    abstract class A
    {
        int number = 3;
        public abstract void print();
        public void PrintNumber()
        {
            Console.WriteLine(number);
        }
    }

    class B : A
    {
        //abstract키워드의 메소드는 반드시 override키워드를 붙여 재정의해야한다.
        public override void print()
        {
            Console.WriteLine("abstract class");
        }
    }

    class C
    {
        public virtual void print() {
            Console.WriteLine("C print");
        }
    }

    class D : C
    {
        public override void print()
        {
            Console.WriteLine("D print");
            //base.print();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B test = new B();
            test.print();
            test.PrintNumber();

            //일반적인 다형성의 예
            C c = new D();
            c.print();

            //다형성 : cast형을 이용한 참조
            D d = new D();
            C casted_c = (C)d; 
            casted_c.print();


            //박싱과 언박싱
            int num = 3;
            object ob = num; //박싱
            int result = (int)ob; //언박싱
            Console.WriteLine("{0} {1}", num, result);

            DATA data = new DATA("test", 3);
            object obj = data;  //박싱
            DATA data2 = (DATA)obj; //언박싱
            Console.WriteLine("{0} {1}", data.name, data.number);


        }
    }
}
