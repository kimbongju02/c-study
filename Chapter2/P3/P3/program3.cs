using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter2
{
    class program3
    {
        static void Main(string[] args)
        {
            int year = 300;
            if (year%4==0 && year%100!=0 && year%400==0)
                Console.WriteLine(year+"은 윤년입니다.");
        }

    }

}