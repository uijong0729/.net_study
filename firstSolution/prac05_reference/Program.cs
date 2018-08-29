using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac05_reference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };
            int[] refArray; //참조형 배열 변수

            refArray = array;

            refArray[1] = 20;

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
