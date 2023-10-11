using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim1_lek3
{
    internal class Triangle:Figura2D
    {
        string style="";
        public string Style { get { return style; } set { style = value; } }
        public Triangle(string style)
        {
            this.style = style;
         }
        public double PL()
        {
            return W * H / 2;
        }
        public string Show_Style()
        {
            return " Трикутник " + style;
        }
    }
}
