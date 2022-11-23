using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex9_DrawStringApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            string s = "This string is long enough to wrap.";
            s += " With a 250px-width rectangle, ";
            s += "it requires six lines to display the string in its entirety.";
            Font f = new Font("Tahoma", 15);
            Rectangle r = new Rectangle(10, 10, 250, 150);
            g.DrawRectangle(Pens.Black, r);
            g.DrawString(s, f, Brushes.Black, r);
            f.Dispose();

            //Graphics g = CreateGraphics();
            string s2 = "This string is long enough to wrap. "; // 출력할 문자열
            s2 += "We'll use a 15pt font, and assume ";
            s2 += "the text string must fit into a width of 250 pixels. ";
            Font f2 = new Font("Tahoma", 15); // 서체는 타호마, 글자 크기는 15.
            SizeF sf2 = g.MeasureString(s2, f2, 250); // 영역의 크기를 측정한다.
            RectangleF rf2 = new RectangleF(280, 20, sf2.Width, sf2.Height);
            Rectangle r2 = Rectangle.Ceiling(rf2); // 올림으로 변환
            g.DrawString(s2, f2, Brushes.Black, r2); // 문자열을 출력한다.
            g.DrawRectangle(Pens.Black, r2); // 외곽선을 그린다.
            f2.Dispose();
        }
    }
}
