using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class Problem3_9_10
    {
        public static void Main()
        {

            Console.Write("구매 가격을 입력하세요: ");
            int Money=int.Parse(Console.ReadLine());

            int Change = 1000-Money;

            Console.Write($"거스름돈은 500원 {Change/500}개, 100원 {Change%500/100}개, 50원 {Change%100/50}개,\n" +
                $"10원 {Change%50/10}개, 5원 {Change%10/5}개, 1원 {Change%5}개이다.\n");
        }
    }
}
