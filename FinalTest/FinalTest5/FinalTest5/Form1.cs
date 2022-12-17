using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class ThreadApp
        {
            private int[] rnd_data = new int[4];
            private int prod;
            public int this[int index]
            {
                get { return rnd_data[index]; }
                set
                {
                    rnd_data[index] = value;
                }
            }
            public int PROD
            {
                get { return prod; }
                set
                {
                    prod = value;
                }
            }
            public void threadProd(object seed)//스레드 몸체
            {
                //명령행 인수의 값을 시드로 사용하니 args[0]의 값을 rnd_seed에 대입
                int rnd_seed = Convert.ToInt32(seed); ;
                Random rndSeed = new Random(rnd_seed);//정해진 시드로 랜덤값 생성
                int result_temp = 1;//곱셈의 결과값 저장
                for (int i = 0; i<4; i++)
                {
                    int intRandom = rndSeed.Next(6, 100);//6에서 99 사이의 랜덤값
                    rnd_data[i] = intRandom;
                    result_temp*=intRandom;
                    Thread.Sleep(1000);//1초씩 대기
                }
                prod = result_temp;
            }
        }

    }
}
