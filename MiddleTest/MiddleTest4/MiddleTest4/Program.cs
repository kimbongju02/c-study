using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midT
{
    public delegate double Calc_Delegate(double a, double b);
    class Add_Mul
    {
        public double Calc_Add(double a, double b)
        {
            return a+b;
        }
        public double Calc_Mul(double a, double b)
        {
            return a*b;
        }
    }
    internal class Test3
    {
        public static void Main(String[] args)
        {
            double a, b, sum, mul;

            Console.Write("First Input data => ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Second input data => ");
            b = double.Parse(Console.ReadLine());

            Add_Mul addMul = new Add_Mul();
            Calc_Delegate calcDelegate = addMul.Calc_Add;//델리게이트 선언
            calcDelegate = addMul.Calc_Add;//Calc_Add 추가
            sum = calcDelegate(a, b);
            Console.WriteLine($"ADD : {a}+{b}={sum}");
            calcDelegate += addMul.Calc_Mul;//Calc_Mul 추가
            mul = calcDelegate(a, b);
            Console.WriteLine($"MUL : {a}*{b}={mul}");
        }
    }
}
