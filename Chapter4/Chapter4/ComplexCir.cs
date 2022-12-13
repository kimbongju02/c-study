using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Complex
    {
        public double numerator;
        public double denominator;
        public Complex(int numerator = 0, int denominator = 0)
        {
            this.numerator= numerator;
            this.denominator=denominator;
        }
        public String toString()
        {
            return String.Format($"({numerator}/{denominator})");
        }
        public static Complex operator+(Complex a, Complex b)
        {
            Complex re = new Complex();
            re.numerator = a.numerator*b.denominator+a.denominator*b.numerator;
            re.denominator = a.denominator*b.denominator;
            return re;
        }
        public static Complex operator-(Complex a, Complex b)
        {
            Complex re = new Complex();
            re.numerator = a.numerator*b.denominator-a.denominator*b.numerator;
            re.denominator = a.denominator*b.denominator;
            return re;
        }
        public static Complex operator*(Complex a, Complex b)
        {
            Complex re = new Complex();
            re.numerator = a.numerator*b.numerator;
            re.denominator = a.denominator*b.denominator;
            return re;
        }
        public static Complex operator/(Complex a, Complex b)
        {
            Complex re = new Complex();
            re.numerator = a.numerator*b.denominator;
            re.denominator = a.denominator*b.numerator;
            return re;
        }
    }
    internal class ComplexCir
    {
        public static void Main()
        {
            Complex a = new Complex(3, 4);
            Complex b = new Complex(5, 6);
            Console.WriteLine($"분수 a는{a.toString()}");
            Console.WriteLine($"분수 a는{b.toString()}");
            Complex result = a+b;
            Console.WriteLine($"a와 b의 덧셈은 {result.toString()}");
            result = a-b;
            Console.WriteLine($"a와 b의 뺄셈은 {result.toString()}");
            result = a*b;
            Console.WriteLine($"a와 b의 곱셈은 {result.toString()}");
            result = a/b;
            Console.WriteLine($"a와 b의 나눗셈은 {result.toString()}");
        }
    }
}
