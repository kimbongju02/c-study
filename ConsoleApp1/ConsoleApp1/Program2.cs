using System;

namespace chapter2
{
    internal class program2
    {
        static void Main(string[] args)
        {
            double f, c;
            Console.Write("Write Celsies : ");
            c=double.Parse(Console.ReadLine());
            f=(double)9/5*c+32;
            Console.WriteLine("Fahrenherit = "+ f);
        }
    }
}
