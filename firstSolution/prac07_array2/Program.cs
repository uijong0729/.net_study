using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac07_array2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "워", "라", "수", "목", "금", "토", "일" };
            transArray(days);
            foreach (string str in days)
                Console.WriteLine(str);



            int[] nArray = { 1, 2, 3, 4, 5 };

            //2번 인덱스부터 3개의 배열을 비워라 
            //(첫번쨰 인자는 array가 오도록 되어있지만 이 부분이 가능한 이유는 배열은 Array를 상속받기 때문에 가능한 형태이다)
            Array.Clear(nArray, 2, 3);

            //배열 전체를 0으로 초기화하려면 아래와 같이 사용하면 된다.
            Array.Clear(nArray, 0, nArray.Length);
            
            foreach(int m in nArray)
            {
                Console.WriteLine(m);
            }

            //배열복사 메서드 (object타입으로 리턴하므로 형변환이 필요하다)
            int[] nCloneArray = (int[])nArray.Clone();


            

        }

        static void transArray(string[] arr)
        {
            string[] correctDay = { "일", "월", "화", "수", "목", "금", "토" };
            for(int i = 0; i<arr.Length; i++)
            {
                arr[i] = correctDay[i];
            }
        }

        static int[] createArray1(int nSize)
        {
            int[] arr = new int[nSize];
            for(int i = 0; i< arr.Length; i++)
            {
                arr[i] = i;
            }
            return arr;
        }

        static int[,] createArray2(int row, int col)
        {
            int index = 0;
            int[,] array = new int[row, col];

            for (int i = 0; i <row; i++)
            {
                for(int j = 0; j<col; j++)
                {
                    array[i, j] = index++;
                }
            }

            return array;
        }

    }
}
