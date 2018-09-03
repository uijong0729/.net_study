using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prac07_binaryIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //dat확장자이므로 더블클릭으로 열리지 않는다.
            using (BinaryWriter bw = new BinaryWriter(new FileStream("test.dat", FileMode.Create)))
            {
                //아스키 코드값에 맞는 데이터는 제대로 저장되지만 다른 문자들은 깨진다.
                //이진파일의 경우 그냥 여는게 아니라 인코딩 설정이 포함된 BinaryReader를 통해 출력해야한다.
                bw.Write(12);
                bw.Write(3.14f);
                bw.Write("Hello World");

            }


            int var1;
            float var2;
            string str1;

            //이진파일 Read하는 법
            //File.Open은 static메소드로서, FileStream객체를 생성 할 필요가 없다.
            using (BinaryReader br = new BinaryReader(File.Open("test.dat", FileMode.Open)))
            {
                var1 = br.ReadInt32();
                var2 = br.ReadSingle();
                str1 = br.ReadString();
            }

            Console.WriteLine("{0} {1} {2}", var1, var2, str1);


        }
    }
}
