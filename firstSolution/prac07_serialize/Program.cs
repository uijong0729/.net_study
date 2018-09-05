using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace prac07_serialize
{
    // 직렬화를 이용하기 위해선 [Serializable]을 붙여야한다.
    [Serializable]
    struct DATA
    {
        public int var1;
        public float var2;
        public string str1;

        [NonSerialized]
        public char nonTarget;
    }

    class Program
    {
        private static readonly int DATA_SIZE = 5;

        static void Main(string[] args)
        {
            DATA[] data = new DATA[DATA_SIZE];
            
            for(int i = 0; i < data.Length; i++)
            {
                data[i].var1 = i;
                data[i].var2 = i * 3.14f;
                data[i].str1 = "do " + i + i;
            }

            //파일스트림 생성
            FileStream fs = new FileStream("test.dat", FileMode.Create);

            //바이너리 포메터 생성
            BinaryFormatter bf = new BinaryFormatter();

            //파일스트림 파일에 대한 정보와 구조체를 명시하면 한번에 저장됩니다.
            bf.Serialize(fs, data);

            fs.Close();

            /////////////////////////////////////////////////////////////////////////


            DATA[] resultData;

            FileStream fs2 = new FileStream("test.dat", FileMode.Open);

            BinaryFormatter bf2 = new BinaryFormatter();

            //Deserialize를 이용하면 serialize로 저장된 파일을 한꺼번에 불러옵니다.
            resultData = (DATA[])bf2.Deserialize(fs2);

            for(int i = 0; i < DATA_SIZE; i++)
            {
                Console.WriteLine("{0} {1} {2}", resultData[i].var1, resultData[i].var2, resultData[i].str1);
            }

        }
    }
}
