using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Date
    {
        int ay,month, year;
        DateTime date;
        public Date(int yy=0, int mm=0, int dd=0)
        {
            year=yy;
            day=dd;
            month=mm;
            date=new DateTime(year,month,day);
        }
        public override string ToString()
        {
            return String.Format("{0}/{1}/{2}", year, month, day); 
        }
        public static Date operator +(Date d,int n) {
            DateTime a = d.date.AddDays(n);//AddDays를 이용해서 날짜를 더한다.
            Date re=new Date(a.Year,a.Month,a.Day);
            return re;
        }
        public static Date operator -(Date d, int n)
        {
            DateTime a = d.date.AddDays(-n);
            Date re = new Date(a.Year, a.Month, a.Day);
            return re;
        }
        public static Date operator ++(Date d)
        {
            DateTime a = d.date.AddDays(1);
            Date re = new Date(a.Year, a.Month, a.Day);
            return re;
        }
        public static Date operator --(Date d)
        {
            DateTime a = d.date.AddDays(-1);
            Date re = new Date(a.Year, a.Month, a.Day);
            return re;
        }
        public static bool operator <(Date d, Date a)
        {
            return d.date<a.date;
        }
        public static bool operator >(Date d, Date a)
        {
            return d.date>a.date;
        }
        public static bool operator ==(Date d, Date a)
        {
            return d.date==a.date;
        }
        public static bool operator !=(Date d, Date a)
        {
            return d.date!=a.date;
            
        }
    }
    internal class dayChap4
    {
        public static void Main()
        {
            Date a = new Date(2021, 12, 12);
            Date b = new Date(2021, 8, 20);
            Console.WriteLine($"a의 날짜는{a.ToString()}");
            Console.WriteLine($"b의 날짜는{b.ToString()}");
            Date c = a+8;
            Console.WriteLine($"a+8일은 {c}");
            c = a-8;
            Console.WriteLine($"a-8일은 {c}");
            c = ++a;
            Console.WriteLine($"++a은 {c}");
            c = --a;
            Console.WriteLine($"--a은 {c}");
            Console.WriteLine($"a<b는 {a<b}");
            Console.WriteLine($"a>b는 {a>b}");
            Console.WriteLine($"a==b은 {a==b}");
            Console.WriteLine($"a!=b은 {a!=b}");
        }
    }
}