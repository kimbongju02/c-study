using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midT
{
    class IA
    {
        public int a;
        public int b;
    }
    internal class Test2
    {
        static int class_sum(IA ia)
        {
            return ia.a+ia.b;
        }
        public static void Main(String[] args)
        {
            int result;
            IA class_ia = new IA();

            Console.Write("First Operand => ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Second Operand => ");
            int b = int.Parse(Console.ReadLine());

            class_ia.a = a;
            class_ia.b = b;
            result = class_sum(class_ia);
            Console.WriteLine($"a+b ={class_ia.a}+{class_ia.b}={result}");
        }
    }
}
