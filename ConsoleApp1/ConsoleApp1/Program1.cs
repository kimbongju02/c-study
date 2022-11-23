using System;
class Program1
{
    public static void Main()
    {
        double a = 4, b = 4, c = 6, l, area;
        l=(a+b+c)/2;
        area = Math.Sqrt(l*(l-a)*(l-b)*(l-c));
        Console.Write("area = "+ a+ area);
    }
}
