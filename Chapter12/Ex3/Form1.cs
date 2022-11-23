using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
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
            Point[] pts = {
                new Point(ClientRectangle.Width/2, 0),
                new Point(0, ClientRectangle.Height),
                new Point(ClientRectangle.Width, ClientRectangle.Height)
            };
            PathGradientBrush b = new PathGradientBrush(pts);
            g.FillRectangle(b, ClientRectangle);
            b.Dispose();
        }
    }
}
