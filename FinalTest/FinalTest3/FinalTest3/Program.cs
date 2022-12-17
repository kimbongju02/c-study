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
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadApp obj = new ThreadApp();//객체 생성
            Thread t = new Thread(obj.threadProd);//델리게이트 생성없이 스레드객체 생성
            t.Start(args[0]);//스레드 생성

            Console.WriteLine("Seed value for Random class = {0}",args[0]);
            t.Join();//스레드 종료
            Console.WriteLine("the accumulated produunt = {0} * {1} * {2} * {3} = {4}", obj[0],
                obj[1], obj[2], obj[3], obj.PROD);
        }
    }
}