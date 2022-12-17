using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Problem2
{
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

}