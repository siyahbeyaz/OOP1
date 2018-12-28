using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekiller
{
    public class dikdortgen : Sekiller
    {
        int a, b;

        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public int B
        {
            get { return b; }
            set { b = value; }
        }

        public dikdortgen()
        { }

        public dikdortgen(int kenar1, int kenar2)
        {
            A = kenar1;
            B = kenar2;
            Alan = A * B;
            Cevre = 2 * (A + B);
        }




    }
}
