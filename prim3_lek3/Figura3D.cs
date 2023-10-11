using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim3_lek3
{
    internal class Figura3D
    {
        string figura = "";
        int h = 0;
        double pl = 0;
        public string Figura { get; set; }
        public int H { get; set; }  
        public Figura3D() {
            h = 10;
            figura = "Фігура";
        }
        public Figura3D(string name,int h)
         {
            this.figura = name;
            this.h = h;
        }
        public virtual string Show()
        {
            return "Фігура - " + this.figura + 
                " Висота = " + this.h.ToString();
        }
        public virtual double S()
        {
            return 0;
        }

    }
}
