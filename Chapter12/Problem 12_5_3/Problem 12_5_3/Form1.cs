using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem_12_5_3
{
    public partial class Form1 : Form
    {
        private Rectangle rb, zoomImgRect, rectMouse;
        Image img = new Bitmap(@"C:\Users\kimbo\OneDrive\바탕 화면\2-2수업\비주얼프로그래밍\code\Chapter12\Problem12_5_1\Problem12_5_1\석양.jpg");

        public Form1()
        {
            InitializeComponent();
             zoomImgRect = new Rectangle(0,0, 800, 450); // 원본의 부분적인 크기
             rb = new Rectangle(0, 0, 800, 450);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, rb, zoomImgRect, GraphicsUnit.Pixel);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                rectMouse.Width = e.X - rectMouse.X + 1; // 사각형 width 계산
                rectMouse.Height = e.Y - rectMouse.Y + 1; // 사각형 height 계산
                zoomImgRect.Width = rectMouse.Width;
                zoomImgRect.Height = rectMouse.Height;
                g.DrawRectangle(Pens.Black, rectMouse);
            }
            else
            {
                zoomImgRect = new Rectangle(0, 0, 800, 450);
            }
                Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left) {
                rectMouse.X = e.X;
                rectMouse.Y = e.Y;
                rectMouse.Width = 0;
                rectMouse.Height = 0;
                zoomImgRect.X = rectMouse.X;
                zoomImgRect.Y = rectMouse.Y;
                zoomImgRect.Width = 0;
                zoomImgRect.Height = 0;
            }

        }
    }
}
