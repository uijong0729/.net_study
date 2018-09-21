using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_inherit
{
    class Program
    {
        //부모클래스
        class A
        {
            int number;
            protected string name = "hello";    //protected이므로 B클래스에서 사용할수있다.

            public A(int num)
            {
                this.number = num;
            }

            public void printA() {
                Console.WriteLine(this.number);
            }
        }

        //자식 클래스
        class B : A
        {
            string name = "world";

            //상위 클래스의 생성자를 호출할때의 형식
            public B(int numbering):base(numbering)
            {
                //상위클래스의 생성자가 호출되어 초기화되고 하위클래스의 생성자가 호출된다.
                
            }

            public void PrintB() {
                Console.WriteLine("{0} {1}", base.name, name);
            }
        }

        class P
        {
            public virtual void print() {
                Console.WriteLine("부모자식상팔자");
            }
        }

        class Q : P{
            public override void print() {
                Console.WriteLine("자식상팔자");
            }
        }

        class Overload
        {
            public void print() { }
            public void print(int val) { }
            public void print(float val) { }

        }

        static void Main(string[] args)
        {
            B test = new B(3);
            //자식클래스에서 상위 클래스에대한 값을 초기화했기 때문에 printA가 잘 작동한다.
            test.printA();
            test.PrintB();


            //자식객체
            Q qest = new Q();
            qest.print();

            //부모객체
            P pest = new P();
            
            //upcasting
            pest = qest;
            
            //upcasting된 경우 print는 재정의 된 메소드를 따르는가 기존 메소드를 따르는가 검증
            pest.print();   
            
        }
    }
}
