using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class Problem3_9_8
    {
        static void Main(string[] args)
        {
            if (args.ength == 0)
            {
                Console.WriteLine("명령행 인수는 없습니다.");
            }

            int N = int.Parse(args[0]);
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{N} * {i} = {N*i}");
            }
        }
    }
}
