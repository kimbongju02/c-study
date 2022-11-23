//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

//namespace Chapter6
//{
//    internal class ExerciseCH6_14_1
//    {
//        public static void Main()
//        {
//            Console.Write("열 파일 이름 입력: ");
//            String k= @"C:\Users\kimbo\OneDrive\바탕 화면\2-2수업\비주얼프로그래밍\code\Chapter6\Chapter6\";
//            String n=Console.ReadLine();
//            try
//            {
//                String a = File.ReadAllText(k+n+".txt");
//                Console.WriteLine(a);
//            }
//            catch
//            {
//                Console.WriteLine("잘못된 이름의 파일이름");
//                Console.Write("열 파일 이름 입력: ");
//                n = Console.ReadLine();
//                String a = File.ReadAllText(k+n+".txt");
//                Console.WriteLine(a);
//            }
//        }
//    }
//}
