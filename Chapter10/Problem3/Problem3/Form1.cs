using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3_10_6_3
{
    public partial class Form1 : Form
    {
        Rectangle rectMouse;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.X>rectMouse.X)
                {
                    rectMouse.Width = e.X - rectMouse.X + 1; // 사각형 width 계산
                    rectMouse.Height = e.Y - rectMouse.Y + 1; // 사각형 height 계산
                }
                else
                {
                    rectMouse.Width = rectMouse.X - e.X + 1; // 사각형 width 계산
                    rectMouse.Height = rectMouse.Y - e.Y + 1; // 사각형 height 계산
                }
                Invalidate(); // WM_PAINT 메시지 발생시킴
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, rectMouse);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}