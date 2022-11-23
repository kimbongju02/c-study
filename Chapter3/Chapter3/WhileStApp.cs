using System;
class WhileStApp
{ // h(n) = 1 + 1/2 + 1/3 + ... + 1/n
    public static void Main()
    {
        int i, n;
        double h = 0.0;
        Console.Write("Enter a number = ");
        n = Console.Read() - '0';
        i = 1;
        while (i <= n)
        {
            h = h + 1/(double)i;
            i++;
        }
        Console.WriteLine("n = {0}, h = {1}", n, h);
    }
}
