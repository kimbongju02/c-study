using System;

class Program
{
    static void Main(string[] args)
    {
        int i;
        if (args.Length == 0)
        {
            Console.WriteLine("명령행 인수는 없습니다.");
        }
        else
        {
            for (i = 0; i < args.Length; i++)
                Console.WriteLine((i + 1) + ":" + args[i]);
        }
    }
}