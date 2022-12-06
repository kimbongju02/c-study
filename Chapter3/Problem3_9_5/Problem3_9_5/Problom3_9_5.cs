using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class Problem3_9_5
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("명령행 인수는 없습니다.");
            }

            int G;//최대공약수 변수
            int L;//최소공배수 변수
            int Min;
            int r;
            int X = int.Parse(args[0]);
            int Y = int.Parse(args[1]);

            if (X>Y) { G=X; Min=Y; }
            else { G=Y;Min=X; }

            while (true)//최대공약수 구하기
            {
                r=G%Min;
                G=Min;
                Min=r;
                if (r==0) break;
            }

            L=X*Y/G;//최소공배수 구하기

            Console.WriteLine($"최대공약수={G}, 최소공배수={L}");
        }

    }
}
