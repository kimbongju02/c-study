//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Chapter5
//{
//    abstract class Figure
//    {
//        public abstract double Area();
//        public abstract double Girth();
//        public abstract void Draw();
//    }
//    class Circle : Figure
//    {
//        double circle;
//        public Circle(int a) { circle=a; }
//        override public double Area()
//        {
//            return circle*circle*3.14;
//        }
//        override public double Girth()
//        {
//            return 2*circle*3.14;
//        }
//        override public void Draw()
//        {
//            Console.WriteLine("원 그리기");
//        }
//    }
//    class Rect : Figure
//    {
//        double rect;
//        public Rect(int a) { rect=a; }
//        override public double Area()
//        {
//            return rect*rect;
//        }
//        override public double Girth()
//        {
//            return 4*rect;
//        }
//        override public void Draw()
//        {
//            Console.WriteLine("사각형 그리기");
//        }
//    }
//    internal class Problem5_8
//    {
//        public static void Main(String[] args)
//        {
//            Circle circle = new Circle(10);
//            Rect rect = new Rect(10);
//            Console.WriteLine("Circle Area: "+circle.Area());
//            Console.WriteLine("Ciecle Girth: "+circle.Girth());
//            circle.Draw();
//            Console.WriteLine("Rect Area: "+rect.Area());
//            Console.WriteLine("Rect Girth: "+rect.Girth());
//            rect.Draw();
//        }
//    }
//}
