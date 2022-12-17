using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = args[0];
            double b = double.Parse(args[1]);
            double c = double.Parse(args[2]);

            if (a.Equals("+"))
                Console.WriteLine($"{b} {a} {c} = {b+c}");
            else if (a.Equals("*"))
                Console.WriteLine($"{b} {a} {c} = {b*c}");
            else
                Console.WriteLine("잘못된 연산자");

        }
    }
}
