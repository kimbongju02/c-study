using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Class2
    {

        static void Main(string[] args)
        {
            FileStream fs;
            try
            {
                fs = new FileStream("C:\\Users\\kimbo\\OneDrive\\바탕 화면\\2-2수업\\비주얼프로그래밍\\code\\test\\test\\test1.txt", FileMode.Open);
            }
            catch (IOException)
            {
                Console.WriteLine("파일을 열 수 없습니다.");
                return;
            }
            StreamReader r = new StreamReader(fs);
            String s;
            s=r.ReadLine();
            double s1=double.Parse(s);
            r.Close();
            
            int a = int.Parse(args[0]);
            int b = int.Parse(args[1]);
            FileStream fi;
            try
            {
                fi = new FileStream("C:\\Users\\kimbo\\OneDrive\\바탕 화면\\2-2수업\\비주얼프로그래밍\\code\\test\\test\\file2.txt", FileMode.Create);
            }
            catch (IOException)
            {
                Console.WriteLine("파일을 열 수 없습니다.");
                return;
            }
            int d = 1;
            StreamWriter w = new StreamWriter(fi);
            String o = $"({a}";
            for(int j = a; j<=b; j++)
            {
                d*=j;
            }
            for (int j = a+1; j<=b; j++)
            {
                o+=$"*{j}";
            }
            o+=")";
            double e = d/(2*s1);
            w.Write(o+$"/(2*{s1})={e}");
            w.Close();
            Console.WriteLine(o+$"/(2*{s1})={e}");
        }
    }
}
