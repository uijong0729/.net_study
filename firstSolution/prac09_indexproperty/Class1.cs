using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace prac09_indexproperty
{
    class C
    {
        private int number;
        private string name;

        //Name이라는 속성이다. 
        //이 속성이 어떤 멤벼변수와 연관되어있는가를 나타내기 위해 앞문자를 대문자로 해서 비슷한 이름으로 지정한다.
        //멤버변수 number에 대한 get set 을 정의한 속성이 Name이다.
        public string Name {
            get { return name; }
            set { name = value; }
        }

        //Number라는 속성이다.
        //멤버변수 number에 대한 속성임을 알리기 위해 속성명은 Number로 했다.
        public int Number {
            get { return number;  }
            set
            {
                if(value < 0 || value > 9)
                {
                    number = 0;
                }
                else
                {
                    number = value;
                }
            }
        }
    }


    class B
    {
        private int[] number = new int[5];
        public int this[int index]
        {
            get { return number[index]; }
            set { number[index] = value; }
        }
    }


    class A
    {
        //외부에서 호출할수없도록 선언
        ArrayList list = new ArrayList();


        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < list.Count)
                {
                    return (string)list[index];
                }
                else
                {
                    return null;
                }
            }

            //여기서 나오는 value는 매개변수로 입력된 값(키워드)
            set
            {
                if (index >= 0 && index < list.Count)
                {
                    list[index] = value;
                }
                else
                {
                    if (index == list.Count)
                    {
                        list.Add(value);
                    }
                }
            }
        }
            public void Print()
            {
                foreach(string temp in list)
                {
                    Console.WriteLine(temp);
                }
            }
        }
    }





