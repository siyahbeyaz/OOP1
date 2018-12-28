using System;


namespace Sekiller
{
    public class Daire : Sekiller
    {
        int r;



        public int R
        {
            get { return r; }
            set { r = value; }
        }

        public Daire()
        {

        }
        public Daire(int r)
        {
            R = r;
            Alan = Math.Pow(R, 2) * Math.PI;
            Cevre = 2 * Math.PI * R;
        }
    }
}
