﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace Chapter6
//{
//    class SimpleThread
//    {
//        public void SimpleMethod()
//        {
//            Random randomNumber = new Random();
//            for (int i = 0; i<3; i++) {
//                Console.WriteLine(i+" "+Thread.CurrentThread.Name);
//                Thread.Sleep(randomNumber.Next(1, 5)*1000);
//            }
//            Console.WriteLine("DONE! "+Thread.CurrentThread.Name);
//        }
//    }
//    internal class ExerciseCHa6_10_4
//    {
//        public static void Main()
//        {
//            SimpleThread obj = new SimpleThread();
//            ThreadStart ts = new ThreadStart(obj.SimpleMethod);
//            Thread worker1 = new Thread(ts);
//            Thread worker2 = new Thread(ts);
//            worker1.Name = "Apple";
//            worker2.Name = "Orange";
//            worker1.Start();
//            worker2.Start();
//        }
//    }
//}
