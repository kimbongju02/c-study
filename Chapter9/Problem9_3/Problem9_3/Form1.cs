using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problem9_6_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                fontDialog1.ShowColor=false; //font color change combobex delete
                fontDialog1.ShowApply=true; //apply button create
                fontDialog1.ShowDialog(); //font dialog box create
            }
            else if (checkBox1.Checked==false &&checkBox2.Checked==true)
            {
                fontDialog1.ShowColor=true; //font color change combobex add
                fontDialog1.ShowApply=false; //apply button delete
                fontDialog1.ShowDialog(); //font dialog box create
            }
            else if (checkBox1.Checked==true && checkBox2.Checked==true)
            {
                fontDialog1.ShowColor=true; //font color change add
                fontDialog1.ShowApply=true; //apply button create
                fontDialog1.ShowDialog(); //font dialog box create
            }
            else
            {
                fontDialog1.ShowColor=false; //font color change combobex delete
                fontDialog1.ShowApply=false; //apply button delete
                fontDialog1.ShowDialog(); //font dialog box create
            }
        }
    }
}
