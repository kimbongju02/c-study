using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Stackcir
    {
        private int[] stack;
        int sp = -1;
        public Stackcir(int size=100)
        {
            stack = new int[size];
        }
        public void Push(int data)
        {
            sp++;
            stack[sp] = data;
        }
        public int pop()
        {
            int re = stack[sp];
            sp--;
            return re;
        }
    }
    internal class Stack
    {
        public static void Main()
        {
            Stackcir s = new Stackcir(5);
            s.Push(1);
            s.Push(6);
            s.Push(2);
            s.Push(3);
            s.Push(0);
            for(int i = 0; i<5; i++)
            {
                Console.WriteLine(s.pop());
            }
        }
    }
}
