using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac06_control
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch 사용시 break가 없으면 에러표시가 된다.
            int nNum = 1;
            switch (nNum)
            {
                case 1:
                    Console.WriteLine("1입니다");
                    break;
                case 2:
                    Console.WriteLine("2입니다");
                    break;
                default:
                    break;

            }

            //foreach문
            int[] array = { 1, 2, 3, 4 };

            foreach (int nTemp in array)
            {
                Console.WriteLine(nTemp);
            }


            //foreach문 2 : 컬렉션
            ArrayList list = new ArrayList();
            list.Add(4);
            list.Add(5);
            list.Add(6);

            foreach (int nTemp in list)
            {
                // nTemp = 5;    //수정불가
                Console.WriteLine(nTemp);
            }


            // try catch
            int[] ar = { 1, 2, 3 };

            try
            {
                ar[3] = 10;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.ToString());
            }


            //try  finally
            int[] arr = { 1, 2, 3 };
            try
            {
                //arr[3] = 10;
            }
            finally
            {
                Console.WriteLine("fianlly");
            }

            Console.WriteLine("try이후 부분");

            YourList index = new YourList();
            int result = index.GetNumber(8);
            Console.WriteLine(result);

        }

        //항목에서 번호를 받아 꺼내는 메소드가 정의된 클래스
        class YourList {

            // throw
            public int GetNumber(int index)
            {
                int[] nums = { 300, 600, 900, 1200 };
                if (index >= nums.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return nums[index];
            }

        }

    }
}
