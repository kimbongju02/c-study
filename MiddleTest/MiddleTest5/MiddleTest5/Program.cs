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

}
