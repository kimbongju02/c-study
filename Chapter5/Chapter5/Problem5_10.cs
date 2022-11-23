using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    interface IPropwetyCounter
    {
        int Count { get; set; }
    }
    interface IMethodCounter
    {
        int Count(int i);
    }
    interface ICounter : IPropwetyCounter, IMethodCounter { }
    class InterfaceParameter : ICounter
    {
        public int count;
        int IPropwetyCounter.Count
        {
            get { return count; }
            set { count = value; }
        }
        int IMethodCounter.Count(int i)
        {
            count = i;
            return count;
        }

        void Test(ICounter x)
        {
            ((IMethodCounter)x).Count(1);
            ((IPropwetyCounter)x).Count = 1;
        }
    }

    internal class Problem5_10
    {
        public static void Main(String[] args)
        {
            InterfaceParameter a = new InterfaceParameter();
            Console.WriteLine("x.Count(1): "+((IMethodCounter)a).Count(1));
            Console.WriteLine("x.Count=1: "+((IPropwetyCounter)a).Count);
        }
    }
}
