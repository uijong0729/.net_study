using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prac07_string2
{
    //학생 정보가 담긴 구조체
    public struct Student {

        public int kor;
        public int math;
        public int eng;

        override
        public string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("국어 : ");
            sb.Append(kor);
            sb.Append("\r\n영어 : ");
            sb.Append(eng);
            sb.Append("\r\n수학 : ");
            sb.Append(math);
            sb.Append("\r\n\r\n");

            return sb.ToString();
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
        question:

            //화면으로부터 학생수와 3과목에 대한 점수를 입력 받은 후에 
            //다음과 같이 test.txt파일로 저장하는 프로그램을 작성해보자
            //단 각 과목의 점수는 스페이스로 구분하여 입력한다.
            int inputNumber;

            //학생 수 입력
            Console.Write("학생 수 : ");
            try
            { 
                inputNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException e)
            {
                goto question;
            }

            string[] inputPoint = new string[inputNumber];
            Student[] std = new Student[inputNumber];   //구조체 배열 생성
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i<inputNumber; i++)
            {
                //점수 입력
                Console.Write(i + "번째 학생의 점수 (국어 영어 수학) : ");
                inputPoint[i] = Console.ReadLine();

                //점수 구분
                string[] slicer = inputPoint[i].Split(new char[] { ' ' });

                std[i].kor = Convert.ToInt32(slicer[0]);
                std[i].eng = Convert.ToInt32(slicer[1]);
                std[i].math = Convert.ToInt32(slicer[2]);
                sb.Append(std[i].ToString());
            }

            //결과를 파일로 출력
            FileStream fos = new FileStream("test.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fos);
            sw.Write(sb.ToString());

            sw.Close();
            fos.Close();
            

        

            




        }
    }
}
