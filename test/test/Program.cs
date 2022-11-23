using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("당신의 학번은 ? :");
            String id = Console.ReadLine();
            Console.Write("당신의 성별은(남성(m), 여성(f))? :");
            String s = Console.ReadLine();
            if (s=="m")
                s = "남성";
            else
                s="여성";
            Console.WriteLine($"당신은 {s}이고 학번은 {id}입니다");

        }
    }
}
