using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac07_array1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 배열의 기본 표현
            int[] nArray = { 1, 2, 3, 4 };

            //배열 반복문 1 : Length
            for (int i = 0; i < nArray.Length; i++)
                Console.WriteLine("{0}", nArray[i]);

            //배열 반복문 2 : foreach
            foreach (int m in nArray)
                Console.WriteLine("{0}", m);

            //  int형 2차원 배열
            int[,] arr = new int[2, 2];
            arr[0, 0] = 1;
            arr[0, 1] = 2;
            arr[1, 0] = 3;
            arr[1, 1] = 4;

            for(int i = 0; i < 2; i++)
            {
                for(int j= 0; j < 2; j++)
                {
                    Console.WriteLine(arr[i, j]);
                }
            }

            //  다차원형 문자열 배열
            string[,,] strArray = 
            {
                {
                    { "jk", "suki" },
                    { "ik", "juki" }
                },
                {
                    { "ak", "star"},
                    { "dk", "eei"}
                },
                {
                    { "ak", "star"},
                    { "dk", "eei"}
                }
            };

            for(int i = 0; i< 3; i++)
            {
                for(int j = 0; j < 2; j ++)
                {
                    for(int k = 0; k < 2; k++)
                    {
                        Console.WriteLine(strArray[i, j, k]);
                    }
                }
            }


            //가변배열 사용 예
            int[][] array = new int[2][];
            array[0] = new int[3] { 1, 2, 3 };
            array[1] = new int[2] { 4, 5 };

            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j< array[i].Length; j++)
                {
                    Console.WriteLine(array[i][j]);
                }
            }

            //가변 다차원 배열 사용 예 (3차원 : 면, 행, 열)
            int[][][] ar = new int[2][][];
            ar[0] = new int[2][];
            ar[1] = new int[3][];

            ar[0][0] = new int[3] { 1, 2, 3 };
            ar[0][1] = new int[2] { 4, 5 };

            ar[1][0] = new int[3] { 6, 7, 8 };
            ar[1][1] = new int[2] { 9, 10 };
            ar[1][2] = new int[2] { 11, 12 };

            for(int i=0; i<ar.Length; i++)
            {
                for(int j = 0; j < ar[i].Length; j++)
                {
                    for(int k = 0; k < ar[i][j].Length; k++)
                    {
                        Console.WriteLine(ar[i][j][k]);
                    }
                }
            }

        }
    }
}
