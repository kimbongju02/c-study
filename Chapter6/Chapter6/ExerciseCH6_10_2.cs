//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace Chapter6
//{
//    class Ex : Exception { }
//    internal class ExerciseCH6_10_2
//    {
//        public static void Main(String[] args) {
//            Console.WriteLine("Entering first try block");
//            try
//            {
//                Console.WriteLine("Entering second try block");
//                try
//                {
//                    throw new Ex();
//                }
//                finally
//                {
//                    Console.WriteLine("finally in 2nd try block");
//                }
//            }
//            catch (Ex e)
//            {
//                Console.WriteLine("Caught Ex in first try block");
//            }
//            finally
//            {
//                Console.WriteLine("finally in 1st try block");
//            }
//        }
//    }
//}
