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

}
