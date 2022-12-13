//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections;

//namespace Chapter5
//{
//    interface IOperation
//    {
//        void Insert(string str);
//        string Delete();
//        bool Search(string str);
//        string GetCurrentEIt();
//        int NumOfElements();
//    }
//    class stackClass : IOperation
//    {
//        Stack<string> stack = new Stack<string>();
//        public void Insert(string str)
//        {
//            stack.Push(str);
//        }
//        public string Delete()
//        {
//            return stack.Pop();
//        }
//        public bool Search(string str)
//        {
//            return stack.Contains(str) ? true : false;
//        }
//        public string GetCurrentEIt()
//        {
//            return stack.Peek();
//        }
//        public int NumOfElements()
//        {
//            return stack.Count;
//        }
//    }
//    class queueClass : IOperation
//    {
//        Queue<string> queue = new Queue<string>();

//        public void Insert(string str)
//        {
//            queue.Enqueue(str);
//        }
//        public string Delete()
//        {
//            return queue.Dequeue();
//        }
//        public bool Search(string str)
//        {
//            return queue.Contains(str) ? true : false;
//        }
//        public string GetCurrentEIt()
//        {
//            return queue.Peek();
//        }
//        public int NumOfElements()
//        {
//            return queue.Count;
//        }
//    }
//    internal class Problem5
//    {
//        public static void Main(string[] args)
//        {
//            stackClass s = new stackClass();
//            queueClass q = new queueClass();

//            s.Insert("a");
//            s.Insert("b");
//            s.Insert("c");
//            Console.WriteLine(s.Delete());
//            Console.WriteLine(s.Search("a"));
//            Console.WriteLine(s.GetCurrentEIt());
//            Console.WriteLine(s.NumOfElements());

//            q.Insert("a");
//            q.Insert("b");
//            q.Insert("c");
//            Console.WriteLine(q.Delete());
//            Console.WriteLine(q.Search("a"));
//            Console.WriteLine(q.GetCurrentEIt());
//            Console.WriteLine(q.NumOfElements());
//        }
//    }
//}
