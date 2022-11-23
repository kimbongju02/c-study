using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex10_DrawImageApp
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
            Image img = new Bitmap(@"C:\\Users\\kimbo\\OneDrive\\바탕 화면\\2-2수업\\비주얼프로그래밍\\code\\Chapter12\vs.png");
            //g.DrawImage(img, 0, 0); // g.DrawImage(img, new Point(0, 0));
            //g.DrawImage(img, ClientRectangle); 지정 영역에 그리기

            /*
            Point[] pts = {
                new Point(0, 0), // 원본의 왼쪽 상단 모서리의 대상 위치
                new Point(200, 0), // 원본의 오른쪽 상단 모서리의 대상 위치
                new Point(50, 100) // 원본의 왼쪽 하단 모서리의 대상 위치
            };
            g.DrawImage(img, pts);
            */

            /*
            Point[] pts = {//이미지 뒤집기
                new Point(0, 100), new Point(200, 100), new Point(0, 0)
            };
            g.DrawImage(img, pts);
            */

            /*
            Point[] pts = {//이미지 90도 회전
                new Point(100, 0), new Point(100, 200), new Point(0, 0)
            };
            g.DrawImage(img, pts);
            */

            Rectangle sr = new Rectangle(0, 0, 80, 30); // 원본의 부분적인 크기
            Rectangle dr = new Rectangle(0, 0, 200, 100); // 그려질 영역 크기
            g.DrawImage(img, dr, sr, GraphicsUnit.Pixel);
        }
    }
}
