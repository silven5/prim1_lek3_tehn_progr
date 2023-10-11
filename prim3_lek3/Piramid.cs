using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim3_lek3
{
    internal class Piramid:Figura3D
    {
        int a;
        public Piramid(int a, int h)
        {
            this.a = a;
            H = h;
            Figura = "Піраміда";
        }
        public override double S()
        {
            var s4 = 0.5 * a * H;
            return 4 * s4 + a * a;
        }
        public override string Show()
        {
            return "Фігура - " + Figura +
                " Висота = " + H.ToString()
                + "Сторона = " + a;
        }
    }
}
