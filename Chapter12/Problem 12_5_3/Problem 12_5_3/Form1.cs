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
        Rectangle rectMouse;
        private Bitmap img, rectBmp;
        private Rectangle zoomImgRect, rectRect;

        public Form1()
        {
            InitializeComponent();

            Bitmap origin = new Bitmap("C: \\Users\\kimbo\\OneDrive\\바탕 화면\\2-2수업\\비주얼프로그래밍\\code\\Chapter12\\석양.jpg");
            img = new Bitmap(origin, 800, 450);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e, MouseEventArgs f)
        {
            if(f.Button == MouseButtons.Left)
            {
                e.Graphics.DrawRectangle(Pens.Black, rectMouse);
                e.Graphics.DrawImage(img, zoomImgRect);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                rectMouse.X = e.X;
                rectMouse.Y = e.Y;
                rectMouse.Width = 0;
                rectMouse.Height = 0;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                rectMouse.Width = e.X - rectMouse.X + 1; // 사각형 width 계산
                rectMouse.Height = e.Y - rectMouse.Y + 1; // 사각형 height 계산
                zoomImgRect.X = -2 * (e.X - 75);
                zoomImgRect.Y = -2 * (e.Y - 75);
                pictureBox1.Invalidate();
            }
        }
    }
}
