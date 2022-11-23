//using System;
//class Temperature // 부모클래스
//{
//    double degree;
//    public Temperature(double degree) // 매개변수 있는 생성자
//    {
//        this.degree = degree;
//    }
//    public double Degree  // 프로퍼티
//    {
//        get { return degree; }
//    }

//}
//class Celsius : Temperature // 자식클래스
//{
//    public Celsius(double t) : base(t) { }
//    public static explicit operator Celsius(double d) // double을 Celsius로 형변환하는 형변환 연산자
//    {
//        Celsius celcius = new Celsius(d);
//        return celcius;
//    }

//    public static explicit operator Celsius(Fahrenheit fahrenheit) //Fahrenheit을 Celsius로 형변환하는 형변환연산자
//    {
//        Celsius celcius = (Celsius)((fahrenheit.Degree - 32.0) * 5 / 9);
//        return celcius;
//    }

//    public static explicit operator double(Celsius celcius) // //Celsius를 double로 형변환하는 형변환연산자
//    {
//        return celcius.Degree;
//    }
//}
//class Fahrenheit : Temperature // 자식클래스
//{
//    public Fahrenheit(double t) : base(t) { }

//    public static explicit operator Fahrenheit(double d) //double을 Fahrenheit로 형변환하는 형변환연산자
//    {
//        Fahrenheit fahrenheit = new Fahrenheit(d);
//        return fahrenheit;
//    }

//    public static explicit operator Fahrenheit(Celsius celcius) //Celsius를 Fahrenheit로 형변환하는 형변환연산자
//    {
//        Fahrenheit fahrenheit = (Fahrenheit)((celcius.Degree * 9 / 5 + 32));
//        return fahrenheit;
//    }

//    public static explicit operator double(Fahrenheit fahrenheit) //Fahrenheit을 double로 형변환하는 형변환연산자
//    {
//        return fahrenheit.Degree;
//    }
//}
//public class Test
//{
//    public static void Main()
//    {
//        double d = 100;
//        Celsius celcius = (Celsius)d;         //double형을 Clsius로 형변환
//        Console.WriteLine("double " + d + " = Celsius " + celcius.Degree);
//        Fahrenheit fahrenheit = (Fahrenheit)celcius;   //Celsius형을 Fahrenheit로 형변환
//        Console.WriteLine("Celsius " + d + " = Fahrenheit " + fahrenheit.Degree);
//        double d2 = (double)celcius;          //Celcius형을 double로 변환
//        Console.WriteLine("Celsius " + d + " = double " + d2);

//        Fahrenheit fahrenheit2 = (Fahrenheit)d;   //double형을 Fahrenheit로 형변환
//        Console.WriteLine("double " + d + " = Fahrenheit " + fahrenheit2.Degree);
//        Celsius celcius2 = (Celsius)fahrenheit2;         //Fahrenheit형을 Celsius로 형변환
//        Console.WriteLine("Fahrenheit " + fahrenheit2.Degree + " =  Celsius " + celcius2.Degree);
//        double d3 = (double)fahrenheit2;          //Fahrenheit형을 double로 변환
//        Console.WriteLine("Fahrenheit " + d + " = double " + d2);
//    }
//}