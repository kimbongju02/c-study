using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4_10_6_6
{
    public partial class Form1 : Form
    {
        String title = "누른 키";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt || e.Control || e.Shift)
            {
                if (e.Alt&&e.KeyCode.ToString()!="Menu")
                    MessageBox.Show(e.KeyCode + " + Alt", title);
                else if (e.Control&&e.KeyCode.ToString()!="ControlKey")
                    MessageBox.Show(e.KeyCode + " + Control", title);
                else if (e.Shift&&e.KeyCode.ToString()!="ShiftKey")
                    MessageBox.Show(e.KeyCode + " + Shift", title);
            }
            else
                MessageBox.Show(e.KeyCode.ToString(), title);


        }


    }
}
