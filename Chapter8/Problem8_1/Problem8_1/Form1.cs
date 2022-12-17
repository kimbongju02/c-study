using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter8
{
    public partial class Form1 : For
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.TextAlign=ContentAlignment.MiddleLeft;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.TextAlign=ContentAlignment.MiddleCenter;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.TextAlign= ContentAlignment.MiddleRight;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font.Name, label3.Font.Size, (label3.Font.Style|FontStyle.Bold));
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font.Name, label3.Font.Size, (label3.Font.Style|FontStyle.Underline));
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font.Name, label3.Font.Size, (label3.Font.Style|FontStyle.Italic));
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font.Name, label3.Font.Size, (label3.Font.Style|FontStyle.Strikeout));
        }
    }
}
