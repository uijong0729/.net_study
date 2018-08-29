using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac03_dataConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToString()
            int value1 = 127;
            string str1 = value1.ToString();

            //Convert
            int value2 = Convert.ToInt32(str1);

            //Parse
            string str2 = "3.14";
            float value3 = float.Parse(str2);

            //int형 값을 박싱한 후에 다시 언박싱하여 출력해보자
            int i = 123;
            object obj = i;
            Console.WriteLine("{0}", (int)obj);

            //(힙 메모리) 박싱과 언박싱 과정에서 메모리 공유(포인터에 의한 참조형태)가 발생하는지, 복사가 발생하는지 확인해보자
            int k = 123;
            object o = k;
            k = 456;
            
            //만약 주소가 복사된다면 o는 456으로 바뀌었을 것이고, 값이 복사된다면 o는 123일 것이다.
            Console.WriteLine("{0} {1}", k, (int)o);
        }
    }
}
