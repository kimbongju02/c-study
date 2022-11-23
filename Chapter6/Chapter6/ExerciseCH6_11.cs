//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Chapter6
//{
//    class Swap<T>
//    {
//        public T x, y;
//        public void swap()
//        {
//            T temp;
//            temp=x;
//            x=y;
//            y=temp;
//        }
//    }
//    internal class ExerciseCH6_11
//    {
//        public static void Main()
//        {
//            Swap<int> i = new Swap<int>();
//            i.x=1;
//            i.y=2;
//            Console.WriteLine("x: "+ i.x+" y: "+i.y);
//            i.swap();
//            Console.WriteLine("x: "+ i.x+" y: "+i.y);
//            Swap<double> d = new Swap<double>();
//            d.x=1;
//            d.y=2.0;
//            Console.WriteLine("x: "+ d.x+" y: "+d.y);
//            d.swap();
//            Console.WriteLine("x: "+ d.x+" y: "+d.y);
//        }
//    }
//}
