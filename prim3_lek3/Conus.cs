using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim3_lek3
{
    internal class Conus:Figura3D
    {
        int r=0;
      //  private string name;

        public Conus(int r,int h ) 
        {
            this.r = r;
            H= h;
            Figura = "Конус";
        }
        public override double S()
        {
            var l = Math.Sqrt(r * r + H * H);
            return Math.PI * l * r;
        }
        public override string Show()
        {
            return "Фігура - " + Figura +
                " Висота = " + H.ToString()
                + "Радіус = " + r;
        }
    }
}
