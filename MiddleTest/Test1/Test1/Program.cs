using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleTest
{
    interface IShape
    {
        void CalArea();
        double Radius
        {
            get;
            set;
        }
    }

    class Circle : IShape
    {
        public double radius;
        public double ar;
        public void CalArea()// 면적 프로퍼티를 이용해서 면적 저장
        {
            Ar=Math.PI*radius*radius;
        }

    }
}
