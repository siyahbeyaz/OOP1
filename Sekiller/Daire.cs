using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekiller
{
    public class daire : Sekiller
    {
        int r;



        public int R
        {
            get { return r; }
            set { r = value; }
        }

        public daire()
        {

        }
        public daire(int r)
        {
            R = r;
            Alan = Math.Pow(R, 2) * Math.PI;
            Cevre = 2 * Math.PI * R;
        }
    }
}
