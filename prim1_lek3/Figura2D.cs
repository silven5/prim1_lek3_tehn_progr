using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim1_lek3
{
    internal class Figura2D
    {
        int w, h;
        public int W
        { get { return w; } set { if (value>0) w = value; } }   
        public int H
        { get { return h; } set { if (value>0) h = value; } }
        public Figura2D () { 
            Random rn = new Random();
            w = rn.Next(1,100);
            h = rn.Next(1,100);
        }
        public string Show_WH()
        {
            return "Висота = " + h + " Ширина = " + w; 
        }
    }
}
