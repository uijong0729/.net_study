using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac05_computeMethod
{
    /*
     국어 영어 수학 점수를 구조체 멤버변수로 입력하고 compute()메서드를 호출하면 평균과 총점이 계산되도록 하여 프로그래밍해 보자
     */

    public struct ComputeTools {
        public int kor, eng, math, total;
        public double average;

        public void compute() {
            total = kor + math + eng;
            average = total / 3.0;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            ComputeTools tool = new ComputeTools();
            Console.WriteLine("국어");
            tool.kor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("수학");
            tool.math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("영어");
            tool.eng = Convert.ToInt32(Console.ReadLine());

            //평균과 총점을 계산하는 메소드 실행
            tool.compute();

            Console.WriteLine("총점 : {0} \n평균 : {1:F2}", tool.total, tool.average);


        }
    }
}
