using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace prac07_Serialize2
{
    [Serializable]
    struct Data
    {
        public int data;
        public string str;

        public Data(int d, string s)
        {
            data = d;
            str = s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Data> ResultList;
            List<Data> DataList = new List<Data>();

            //List에 데이터 추가
            for(int i = 3; i < 11; i++)
            {
                DataList.Add(new Data(i, "test"+i));
            }

            using (FileStream fs1 = new FileStream("test.dat", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs1, DataList);    //저장
            }

            using (FileStream fs2 = new FileStream("test.dat", FileMode.Open))
            {
                BinaryFormatter bf2 = new BinaryFormatter();
                ResultList = (List<Data>)bf2.Deserialize(fs2); //Object타입으로 리턴하므로 형변환이 필요
                   
            }

            //결과 출력
            for(int i = 0; i < DataList.Count; i++)
            {
                Console.WriteLine("{0} {1}", ResultList[i].data, ResultList[i].str);
            }
            
        }
    }
}
