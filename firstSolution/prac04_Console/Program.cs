using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace prac04_Console
{
    //사용자가 눌린 키를 화면에 출력하되 Esc키가 입력되면 프로그램을 종료하도록 작성하시오
    class Program
    {
        static void Main(string[] args)
        {
            //키 정보가 담겨지는 객체
            ConsoleKeyInfo keyinfo;

            do
            {
                //Console.ReadKey()는 딱 한글자만 담을 수 있습니다.
                //대소문자를 구분 할 수는 없고 눌려진 키의 대문자에 대해서만 정보를 받습니다.
                keyinfo = Console.ReadKey(true); //매개변수로 true를 주면 화면에 자기가 입력하는 값을 보여주지 않는다.

                if(keyinfo.KeyChar == 'a')
                {
                    Console.WriteLine("a가 눌렸어");
                }
                else
                {
                    Console.WriteLine(keyinfo.KeyChar); //누른 키를 출력하도록 
                }
                

            }
            while (keyinfo.Key != ConsoleKey.Escape);
        }
    }

}
