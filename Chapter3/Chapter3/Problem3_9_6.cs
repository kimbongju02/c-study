using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class Problem3_9_6
    {
        public static void Main()
        {
            int S;
            int A=0, B=1;
            for(int i = 0; i<=100; i++)
            {
                A+=(2*i);//2*i를 i를 1부터 100까지 증가하며 더하는 시그마 연산
            }
            for(int i=1; i<=10; i++)
            {
                B*=i;//i를 1부터 10까지 증가하며 곱하는 연산
            }
            S= A+B;

            Console.WriteLine($"result = {S}");
        }

    }
}
