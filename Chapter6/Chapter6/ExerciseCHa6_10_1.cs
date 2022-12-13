//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Chapter6
//{
//        class GClass<T>
//        {
//            private List<T> list;
//            public GClass()
//            {
//                list = new List<T>();
//            }
//            public String getValue()
//            {
//                String str = "";
//                foreach (T e in list) 
//                    str+=(e.ToString()+" ");
//                return str;
//            }
//            public void setValue(params T[] args)
//            {
//                foreach (T e in args) 
//                    list.Add(e);
//            }
//        }
//    internal class ExerciseCHa6_10_1
//    {
//        static void Main(string[] args)
//        {
//            GClass<int> gInteger = new GClass<int>();
//            gInteger.setValue(10,20,30);
//            Console.WriteLine(gInteger.getValue());
//        }
//    }
//}
