using System;
namespace ConsoleApp1
{
    internal class Program4
    {
        public static void Main(string[] args)
        {
            string a;
            char max = '0';
            Console.WriteLine("수를 입력하시오 : ");
            a =Console.ReadLine();
            for(int i = 0; i < a.Length; i++)
            {
                if (max<a[i]) max=a[i];
                //0일때 유니코드와 a[i]의 유니코드 비교
            }
            Console.WriteLine((char)max);
        }
    }
}
