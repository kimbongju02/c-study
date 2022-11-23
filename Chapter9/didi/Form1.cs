using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace didi
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
            Pen p = new Pen(Color.Black,20);
           // p.Width = 10;
            g.DrawRectangle(p, 30, 30, 70, 70);
            p.Dispose();

        }
    }
}
