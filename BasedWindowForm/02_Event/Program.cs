using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Event
{
    //델리게이트는 실제로 호출하고자하는 메소드들의 형식을 명시한다
    delegate void MyDelegate(string msg);

    class A
    {
        //클래스 내에서 이벤트 선언
        public event MyDelegate EventHandler;
        
        //EventHandler에서 메소드들을 호출하기위해선 함수를 선언하고 함수 안에서 호출해야한다.
        public void Func(string msg)
        {
            EventHandler(msg);
        }
    }

    class B
    {
        public void PrintA(string msg)
        {
            Console.WriteLine(msg);
        }
        public void PrintB(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A testA = new A();  //이벤트 핸들러가 있는 클래스
            B testB = new B();  //이벤트에 추가시킬 메소드가 있는 클래스

            //이벤트 핸들러에 메소드 추가
            testA.EventHandler += new MyDelegate(testB.PrintA);
            testA.EventHandler += new MyDelegate(testB.PrintB);
            testA.Func("goood!");

            //이벤트 핸들러에 메소드 삭제
            testA.EventHandler -= testB.PrintB;
            testA.Func("not Good");
            testA.EventHandler -= testB.PrintA;

            //메소드가 없어서 예외 반환
            try
            {
                testA.Func("can you hear it?");
            }
            catch(Exception e)
            {
               
            }

            //이벤트 핸들러에 다시 메소드 추가
            testA.EventHandler += testB.PrintA;
            testA.EventHandler += testB.PrintB;

            testA.Func("hello world");
        }
    }
}
