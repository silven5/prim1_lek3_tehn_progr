using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim2_lek3
{
    internal class B:A
    {
        new int i = 1;//Приховуємо i з класу A
        public B (int b)
        {
           // base.i = 5;
            this.i = b;
        }
        public void Show()
        {
            //поле з класу A
            Console.WriteLine("поле i з класу A = " + base.i);
            //поле з класу B
            Console.WriteLine("поле i з класу B = " + this.i);
        }
    }
}
