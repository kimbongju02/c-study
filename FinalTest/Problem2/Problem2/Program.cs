﻿using System;
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
ouble>();

            Console.Write("Read OP from keyboard ? : ");
            OP = int.Parse(Console.ReadLine());
            Console.Write("Read double data(1) from keyboard : ");
            double_indata_1 = double.Parse(Console.ReadLine());
            Console.Write("Read double data(2) from keyboard : ");
            double_indata_2 = double.Parse(Console.ReadLine());

            Console.WriteLine(doubleConn.Connent(OP, double_indata_1, double_indata_2));

            Console.Write("Read OP from keyboard ? : ");
            OP = int.Parse(Console.ReadLine());
            Console.Write("Read int  data(1) from keyboard : ");
            int_indata_1 = int.Parse(Console.ReadLine());
            Console.Write("Read int  data(2) from keyboard : ");
            int_indata_2 = int.Parse(Console.ReadLine());

            Console.WriteLine(intConn.Connent(OP, int_indata_1, int_indata_2));
        }
    }
}
