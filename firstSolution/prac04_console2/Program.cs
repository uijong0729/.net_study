using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac04_console2
{
    class Average
    {
        static void Main(string[] args)
        {
            int kor, eng, math, total;
            double avg;

            Console.Write("국어 점수를 입력하시오 : ");
            kor = Convert.ToInt32(Console.ReadLine());
            Console.Write("영어 점수를 입력하시오 : ");
            eng = Convert.ToInt32(Console.ReadLine());
            Console.Write("수학 점수를 입력하시오 : ");
            math = Convert.ToInt32(Console.ReadLine());

            total = kor + eng + math;
            avg = total / 3.0;
            
            //평균의 경우 소수 2번째까지
            Console.WriteLine("국어 : {0}, 수학: {1}, 영어: {2}, 총점: {3}, 평균: {4:f2}", kor, math, eng, total, avg);
        }
    }
}
