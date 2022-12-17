using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Problem2
{
    class ThreadApp
    {
        private int[] rnd_data = new int[4];
        private int prod;
        public int this[int index]
        {
            get { return rnd_data[index]; }
            set
            {
                rnd_data[index] = value;
            }
        }
        public int PROD
        {
            get { return prod; }
            set
            {
                prod = value;
            }
        }

}