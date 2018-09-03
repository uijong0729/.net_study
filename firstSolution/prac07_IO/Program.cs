using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac07_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 12;
            float value2 = 3.14f;
            string value3 = "hello";

            //파일스트림 객체 생성 및 생성자(파일명, 파일모드, 파일액세스)
            FileStream fs = new FileStream("test.txt", FileMode.Create);

            //스트림라이터 생성 및 파일스트림 전송
            StreamWriter sw = new StreamWriter(fs);

            //파일 write작업
            sw.WriteLine(value);
            sw.Write(value);
            sw.Write(value2);
            sw.Write(value3);

            //close
            sw.Close();


            //using구문을 사용하면 close 처리가 필요없다.
            StreamWriter sw2;

            using (sw2 = new StreamWriter(new FileStream("Test2.txt", FileMode.Create)))
            {
                sw2.WriteLine("두 번째");
                sw2.WriteLine("세 번째");
            }



            //파일스트림 없이 StreamWriter만을 이용해서 파일쓰기
            StreamWriter noFs = new StreamWriter("noFs.txt");
            noFs.Write("우리집 강아지는 예쁜 강아지");
            noFs.Close();





            //파일스트림 (test.txt는 위에서 write한 텍스트 파일이다)
            FileStream fis = new FileStream("test.txt", FileMode.Open, FileAccess.Read);

            //스트림리더
            StreamReader sr = new StreamReader(fis);
           
            string str1 = sr.ReadLine();
            string str2 = sr.ReadLine();

            //폐쇄
            sr.Close();

            //결과출력
            Console.WriteLine("{0}, {1}", str1, str2);



            //using을 이용한 read
            StreamReader sr22;

            using (sr22 = new StreamReader(new FileStream("test.txt", FileMode.Open)))
            {
                string strr1 = sr22.ReadLine();
                string strr2 = sr22.ReadLine();
                Console.WriteLine("{0}, {1}", strr1, strr2);
            }



            //StreamReader만을 이용해서 읽기작업만 하기
            StreamReader readOnly = new StreamReader("test.txt");
            string st1 = readOnly.ReadLine();
            string st2 = readOnly.ReadLine();
            Console.WriteLine("{0} \n{1}", st1, st2);
            readOnly.Close();
        }
    }
}
