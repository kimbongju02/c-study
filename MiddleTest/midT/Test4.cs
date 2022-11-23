using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midT
{
    public delegate void MyEventHandler(int k);
    class Button
    {
        int a;
        public event MyEventHandler Push;
        public void OnPush()
        {
            Console.Write("Enter integer input (10 이하 정수 입력) => ");
            a = int.Parse(Console.ReadLine());
            Push(a);
        }
    }
    class EventHandlerClass
        {
            public void print(int k)
            {
                for (int i = 0; i <= k; i++)
                {
                    Console.Write("i= {0}, ", i);
                }
                Console.WriteLine();
            }
        }
    internal class Test4
    {
        static void Main(string[] args)
        {
            Button button = new Button();// 객체 생성
            EventHandlerClass obj = new EventHandlerClass();// 이벤트 처리기를 포함한 객체 생성
            button.Push += new MyEventHandler(obj.print);// 이벤트와 이벤트 처리기 연결
            button.OnPush();
        }
    }
}
