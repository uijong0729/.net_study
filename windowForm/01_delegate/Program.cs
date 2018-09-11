using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_delegate
{
    delegate void MyDelegate(String str);

    class Test
    {
        public void print(String str)
        {
            Console.WriteLine(str);
        }

        public void printNum(string num)
        {
            Console.WriteLine("num : " + Convert.ToInt32(num));
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            MyDelegate method = new MyDelegate(test.print); //델리게이트 생성과 메소드 지정
            method("hello");    //델리게이트를 메소드로 사용

            MyDelegate method2 = test.print; //new를 통해 생성하지 않아도 된다. (C# 2.0)
            method2("hello2");

            MyDelegate method3 = new Test().print;
            method3("hello3");



            Test Multi = new Test();
            MyDelegate DelFunc = Multi.print;
            DelFunc += Multi.printNum;
            DelFunc("3345");
            DelFunc -= Multi.printNum;
            DelFunc("3322");


        }
    }
}
