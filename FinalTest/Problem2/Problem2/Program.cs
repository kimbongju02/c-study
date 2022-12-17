using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Program
    {
        class CONN<T>
        {
            public string Connent(int OP,T a, T b)
            {
                string result=null;
                if (OP== 0)
                    result = a.ToString()+b.ToString();
                else if (OP== 1)
                    result =  b.ToString()+a.ToString();
                return result;
            }
        }
        static void Main(string[] args)
        {
            int OP;
            int int_indata_1, int_indata_2;
            double double_indata_1, double_indata_2;
            CONN<int> intConn = new CONN<int>();
            CONN<double> doubleConn = new CONN<double>();


        }
    }
}
