using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Matrix2D
    {
        private double[,] num;
        public Matrix2D()
        {
            num = new double[2, 2];
        }
        public double this[int row, int col]// 특정 열, 행에 값 저장
        {
            get { return num[row, col]; }
            set { num[row, col]=value; }
        }
        public static Matrix2D operator +(Matrix2D a, Matrix2D b)// 특정 행, 열의 값을 각각 덧셈
        {
            Matrix2D re = new Matrix2D();
            for (int i = 0; i<2; i++)
            {
                for (int j = 0; j<2; j++)
                {
                    re[i, j]=a[i, j]+b[i, j];
                }
            }
            return re;
        }
        override public string ToString()// 2차원 행렬 출력
        {
            string r_string;
            r_string = "    \n";
            for (int i = 0; i<2; i++)
            {
                for (int j = 0; j<2; j++)
                    r_string += String.Format($"M[{i},{j}]={num[i, j]}  ");
                r_string+=String.Format("\n");
            }
            return r_string;
        }

        internal class Program
        {
            static void Main(String[] args)
            {
                Matrix2D A = new Matrix2D();
                Matrix2D B = new Matrix2D();
                Matrix2D C = new Matrix2D();

                A[0, 0]=1.1;
                A[0, 1]=2.2;
                A[1, 0]=3.3;
                A[1, 1]=4.4;
                B[0, 0]=2.1;
                B[0, 1]=3.2;
                B[1, 0]=4.3;
                B[1, 1]=5.4;

                C=A+B;

                Console.WriteLine("***********************A, Matrix2D========");
                Console.WriteLine(A);
                Console.WriteLine("***********************B, Matrix2D========");
                Console.WriteLine(B);
                Console.WriteLine("***********************Result=A+B, Matrix2D========");
                Console.WriteLine(C);
            }
        }
    }
}
