using System;
namespace chapter2
{
    class program3
    {
        public static void Main(string[] args)
        {
            Console.Write("년도를 입력하세요 : ");
            int year = int.Parse(Console.ReadLine());
            if ((year%4==0 && year%100!=0) || year%400==0)
                //year을 4로 나눌때 나머지가 4이고 year을 100으로 나눌때 나머지가 4일때 또는 year을 400으로 나눌때 0이면 윤년이다
                Console.WriteLine(year+"은 윤년입니다.");
            else
                Console.WriteLine(year+"은 평년입니다.");
        }

    }
}
