using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Chapter4
{
    class Complex {
        public double real;
        public double image;
        public Complex(int real=0, int image=0)
        {
            this.real= real;
            this.image=image;
        }
        public String toString()
        {
            return String.Format($"({real}, {image})");
        }
    }
    internal class complexNumber
    {
        static String addComplex(Complex a, Complex b)
        {
            double real = a.real+b.real;
            double image = a.image + b.image;
            return String.Format($"({real}, {image})");
        }
        static String subComplex(Complex a, Complex b)
        {
            double real = a.real - b.real;
            double image = a.image - b.image;
            return String.Format($"({real}, {image})");
        }
        static String mulComplex(Complex a, Complex b)
        {
            double real = (a.real * b.real) - (a.image * b.image);
            double image = (a.real * b.image) + (a.image * b.real);
            return String.Format($"({real}, {image})");
        }
        static String divComplex(Complex a, Complex b)
        {
            double real = ((a.real*b.real)+(a.image*b.image))/(b.real*b.real+b.image*b.image);
            double image = ((a.image*b.real)+(a.real*b.image))/(b.real*b.real+b.image*b.image);
            return String.Format($"({real}, {image})");
        }
        public static void Main() { 
            Complex b = new Complex(2,3);
            Complex c = new Complex(4,5);
            Console.WriteLine($"복소수 b는 {b.toString()}");
            Console.WriteLine($"복소수 c는 {c.toString()}");
            Console.WriteLine($"복소수 b와c의 덧셈은 {addComplex(b, c)}");
            Console.WriteLine($"복소수 b와c의 뺄셈은 {subComplex(b, c)}");
            Console.WriteLine($"복소수 b와c의 곱셈은 {mulComplex(b, c)}");
            Console.WriteLine($"복소수 b와c의 나눗셈은 {divComplex(b, c)}");
        }
    }
}
