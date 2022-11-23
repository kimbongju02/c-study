using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Class1
    {
        public static void Main()
        {
            Console.Write("First data(double) : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Second data(double : ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Third data(int) : ");
            int c = int.Parse(Console.ReadLine());

            Console.write($"First Data = {a}, Second Data ={b}, Third Data ={c}")
            if (c%2==0)
                Console.WriteLine("Result = "+c*(a+b));
            else
                Console.WriteLine("Result = "+c/(a+b));

        }

    }
}
