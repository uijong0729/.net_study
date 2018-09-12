using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    interface IA
    {
        void PrintA();
    }

    interface IB
    {
        void PrintB();
    }

    class C : IA, IB
    {
        public void PrintA()
        {
            throw new NotImplementedException();
        }

        public void PrintB()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
